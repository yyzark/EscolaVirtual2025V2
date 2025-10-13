using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Forms.Admin.AdminForms.ClassRooms;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual2025.Forms.Admin.AdminForms.Subjects
{
    public partial class Form_EditSubject : MaterialForm
    {
        private Form_AddSubjectYearsChose subjectYearsChose;
        private Subject newSubject;
        public Form_EditSubject(Subject subject)
        {
            InitializeComponent();


            #region MaterialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Red300,    // cor principal clara
            Primary.Red700,    // cor principal escura
            Primary.Red100,    // cor de fundo ou destaque
            Accent.Orange200,  // acento laranja suave
            TextShade.WHITE    // cor do texto;
            );
            #endregion


            newSubject = subject;
            subjectYearsChose = new Form_AddSubjectYearsChose(newSubject);

            txtName.Hint = "Nome";
            txtAbreviation.Hint = "Abreviação";
        }

        private void Form_EditSubject_Load(object sender, EventArgs e)
        {
            txtAbreviation.Text = newSubject.Abreviation;
            txtName.Text = newSubject.Name;
        }

        private void btnYears_Click(object sender, EventArgs e)
        {
            subjectYearsChose.ShowDialog();
            UpdateAcceptButtonState();
        }

        private void txtAbreviation_TextChanged(object sender, EventArgs e)
        {
            UpdateAcceptButtonState();
        }

        private void UpdateAcceptButtonState()
        {
            // Verifica se algum campo mudou
            bool nameChanged = txtName.Text != newSubject.Name;
            bool abbrChanged = txtAbreviation.Text != newSubject.Abreviation;
            bool yearsChanged = !subjectYearsChose.p_Subject.Years.SequenceEqual(newSubject.Years);

            // Ativa o botão se alguma informação mudou e se os campos não estão vazios
            btnAccept.Enabled = (nameChanged || abbrChanged || yearsChanged)
                                && !string.IsNullOrWhiteSpace(txtName.Text)
                                && !string.IsNullOrWhiteSpace(txtAbreviation.Text)
                                && subjectYearsChose.SubjectYearsChosen;
        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {
            UpdateAcceptButtonState();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAbreviation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            newSubject.Name = txtName.Text;
            newSubject.Abreviation = txtAbreviation.Text;
            newSubject.Years = subjectYearsChose.p_Subject.Years;

            if (!Program.Subjects.Contains(newSubject))
            {
                newSubject.Id = Program.Subjects.Count + 1;
                Program.Subjects.Add(newSubject);
            }

            foreach (var year in newSubject.Years)
            {
                var targetYear = Program.Anos.FirstOrDefault(a => a.AnoId == year.AnoId);
                if (targetYear != null)
                {
                    if (!targetYear.Subjects.Contains(newSubject))
                        targetYear.Subjects.Add(newSubject);

                    foreach (var cls in targetYear.ClassRooms)
                    {
                        if (!cls.Subjects.Any(cs => cs.Subject == newSubject))
                            cls.Subjects.Add(new ClassSubject(null, newSubject));
                    }
                }
            }

            this.Close();
        }
    }
}
