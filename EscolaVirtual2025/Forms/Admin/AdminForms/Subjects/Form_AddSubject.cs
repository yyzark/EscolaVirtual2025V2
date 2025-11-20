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
            newSubject.Id = DataManager.Subjects.Count + 1;

            DataManager.Subjects.Add(newSubject);
            DataManager.Years.Sort((x, y) => x.Id.CompareTo(y.Id));

            foreach (var year in newSubject.Years.Items)
            {
                var targetYear = DataManager.Years.FirstOrDefault(a => a.Id == year.Id);
                if (targetYear != null)
                {
                    targetYear.Subjects.Add(newSubject);

                    foreach (var cls in targetYear.ClassRooms.Items)
                    {
                        cls.ClassSubjects.Add(new ClassSubject(null, newSubject));
                    }
                }
            }
            //DataManager.Save();
            this.Close();
        }

        private void btnYears_Click(object sender, EventArgs e)
        {
            subjectYearsChose.ShowDialog();
            if (subjectYearsChose.SubjectYearsChosen && txtAbreviation.Text != string.Empty && txtName.Text != string.Empty)
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
    }
}
