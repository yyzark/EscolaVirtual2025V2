using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Forms.Admin.AdminForms.ClassRooms;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EscolaVirtual2025.Forms.Admin.AdminForms.Subjects
{
    public partial class Form_EditSubject : MaterialForm
    {
        private readonly Form_AddSubjectYearsChose subjectYearsChose;
        private readonly Subject originalSubject; // referência original
        private Subject editedSubject;            // cópia editável

        public Form_EditSubject(Subject subject)
        {
            InitializeComponent();

            #region MaterialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red300,
                Primary.Red700,
                Primary.Red100,
                Accent.Orange200,
                TextShade.WHITE
            );
            #endregion

            originalSubject = subject;

            // cria cópia independente para editar sem alterar o original diretamente
            editedSubject = new Subject
            {
                Id = subject.Id,
                Name = subject.Name,
                Abreviation = subject.Abreviation,
                Years = subject.Years.ToList()
            };

            subjectYearsChose = new Form_AddSubjectYearsChose(editedSubject);

            txtName.Hint = "Nome";
            txtAbreviation.Hint = "Abreviação";
        }

        private void Form_EditSubject_Load(object sender, EventArgs e)
        {
            txtName.Text = editedSubject.Name;
            txtAbreviation.Text = editedSubject.Abreviation;
            UpdateAcceptButtonState();
        }

        private void txtName_TextChanged(object sender, EventArgs e) => UpdateAcceptButtonState();
        private void txtAbreviation_TextChanged(object sender, EventArgs e) => UpdateAcceptButtonState();

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtAbreviation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnYears_Click(object sender, EventArgs e)
        {
            subjectYearsChose.ShowDialog();
            UpdateAcceptButtonState();
        }

        private void UpdateAcceptButtonState()
        {
            bool nameChanged = txtName.Text != originalSubject.Name;
            bool abbrChanged = txtAbreviation.Text != originalSubject.Abreviation;
            bool yearsChanged = !subjectYearsChose.p_Subject.Years.SequenceEqual(originalSubject.Years);

            btnAccept.Enabled =
                (nameChanged || abbrChanged || yearsChanged)
                && !string.IsNullOrWhiteSpace(txtName.Text)
                && !string.IsNullOrWhiteSpace(txtAbreviation.Text)
                && subjectYearsChose.SubjectYearsChosen;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            // Atualiza dados da cópia
            editedSubject.Name = txtName.Text.Trim();
            editedSubject.Abreviation = txtAbreviation.Text.Trim();
            editedSubject.Years = subjectYearsChose.p_Subject.Years.ToList();

            // === 1️⃣ Atualiza lista global de Subjects ===
            int idx = Program.Subjects.IndexOf(originalSubject);
            if (idx >= 0)
                Program.Subjects[idx] = editedSubject;
            else
                Program.Subjects.Add(editedSubject);

            // === 2️⃣ Atualiza cada Ano ===
            foreach (var year in Program.Anos)
            {
                year.Subjects.RemoveAll(s => s.Id == originalSubject.Id);

                if (editedSubject.Years.Any(y => y.AnoId == year.AnoId))
                {
                    if (!year.Subjects.Any(s => s.Id == editedSubject.Id))
                        year.Subjects.Add(editedSubject);
                }

                // Atualiza as turmas dentro do ano
                foreach (var cls in year.ClassRooms)
                {
                    cls.Subjects.RemoveAll(cs => cs.Subject.Id == originalSubject.Id);

                    if (editedSubject.Years.Any(y => y.AnoId == year.AnoId))
                    {
                        if (!cls.Subjects.Any(cs => cs.Subject.Id == editedSubject.Id))
                            cls.Subjects.Add(new ClassSubject(null, editedSubject));
                    }
                }
            }

            // === 3️⃣ Atualiza turmas globais ===
            foreach (var cls in Program.ClassRooms)
            {
                cls.Subjects.RemoveAll(cs => cs.Subject.Id == originalSubject.Id);

                if (editedSubject.Years.Any(y => y.AnoId == cls.Year.AnoId))
                {
                    if (!cls.Subjects.Any(cs => cs.Subject.Id == editedSubject.Id))
                        cls.Subjects.Add(new ClassSubject(null, editedSubject));
                }
            }

            // === 4️⃣ Atualiza professores ===
            foreach (var teacher in Program.Teachers)
            {
                if (teacher.AssignedSubject != null && teacher.AssignedSubject.Id == originalSubject.Id)
                {
                    teacher.AssignedSubject = editedSubject;
                }
            }

            this.Close();
        }
    }
}
