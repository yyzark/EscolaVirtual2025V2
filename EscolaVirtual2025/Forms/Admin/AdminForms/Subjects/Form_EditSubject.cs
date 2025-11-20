using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Data;
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
                Years = subject.Years
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
            bool yearsChanged = !subjectYearsChose.p_Subject.Years.Items.SequenceEqual(originalSubject.Years.Items);

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
            editedSubject.Years = subjectYearsChose.p_Subject.Years;

            // === 1️⃣ Atualiza lista global de Subjects ===
            int idx = DataManager.Subjects.IndexOf(originalSubject);
            if (idx >= 0)
                DataManager.Subjects[idx] = editedSubject;
            else
                DataManager.Subjects.Add(editedSubject);

            // === 2️⃣ Atualiza cada Ano ===
            foreach (var year in DataManager.Years)
            {
                year.Subjects.RemoveAll(s => s.Id == originalSubject.Id);

                if (editedSubject.Years.Items.Any(y => y.Id == year.Id))
                {
                    if (!year.Subjects.Items.Any(s => s.Id == editedSubject.Id))
                        year.Subjects.Add(editedSubject);
                }

                // Atualiza as turmas dentro do ano
                foreach (var cls in year.ClassRooms.Items)
                {
                    cls.ClassSubjects.RemoveAll(cs => cs.Id == originalSubject.Id);

                    if (editedSubject.Years.Items.Any(y => y.Id == year.Id))
                    {
                        if (!cls.ClassSubjects.Items.Any(cs => cs.Id == editedSubject.Id))
                            cls.ClassSubjects.Add(new ClassSubject(null, editedSubject));
                    }
                }
            }

            // === 3️⃣ Atualiza turmas globais ===
            foreach (var cls in DataManager.ClassRooms)
            {
                cls.ClassSubjects.RemoveAll(cs => cs.Id == originalSubject.Id);

                if (editedSubject.Years.Items.Any(y => y.Id == cls.Year.Id))
                {
                    if (!cls.ClassSubjects.Items.Any(cs => cs.Id == editedSubject.Id))
                        cls.ClassSubjects.Add(new ClassSubject(null, editedSubject));
                }
            }

            // === 4️⃣ Atualiza professores ===
            foreach (var teacher in DataManager.Teachers)
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
