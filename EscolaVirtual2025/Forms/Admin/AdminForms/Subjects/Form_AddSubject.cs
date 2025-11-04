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
    public partial class Form_AddSubject : MaterialForm
    {
        private Form_AddSubjectYearsChose subjectYearsChose;
        private Subject newSubject;
        public Form_AddSubject()
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


            newSubject = new Subject(null, null, -1);
            subjectYearsChose = new Form_AddSubjectYearsChose(newSubject);

            txtName.Hint = "Nome";
            txtAbreviation.Hint = "Abreviação";

        }

        private void Form_AddSubject_Load(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            newSubject.Abreviation = txtAbreviation.Text;
            newSubject.Name = txtName.Text;
            newSubject.Years = subjectYearsChose.p_Subject.Years;
            newSubject.Id = Program.Subjects.Count + 1;

            Program.Subjects.Add(newSubject);
            Program.Anos.Sort((x, y) => x.AnoId.CompareTo(y.AnoId));

            foreach (var year in newSubject.Years)
            {
                var targetYear = Program.Anos.FirstOrDefault(a => a.AnoId == year.AnoId);
                if (targetYear != null)
                {
                    targetYear.Subjects.Add(newSubject);

                    foreach (var cls in targetYear.ClassRooms)
                    {
                        cls.Subjects.Add(new ClassSubject(null, newSubject));
                    }
                }
            }
            Program.Save();
            this.Close();
        }

        private void btnYears_Click(object sender, EventArgs e)
        {
            subjectYearsChose.ShowDialog();
            if(subjectYearsChose.SubjectYearsChosen && txtAbreviation.Text != string.Empty && txtName.Text != string.Empty)
            {
                btnAccept.Enabled = true;
            }
            else
            {
              btnAccept.Enabled = false;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (subjectYearsChose.SubjectYearsChosen && txtAbreviation.Text != string.Empty && txtName.Text != string.Empty)
            {
                btnAccept.Enabled = true;
            }
            else
            {
                btnAccept.Enabled = false;
            }
        }

        private void txtAbreviation_TextChanged(object sender, EventArgs e)
        {
            if (subjectYearsChose.SubjectYearsChosen && txtAbreviation.Text != string.Empty && txtName.Text != string.Empty)
            {
                btnAccept.Enabled = true;
            }
            else
            {
                btnAccept.Enabled = false;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
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
    }
}
