using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Data;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace EscolaVirtual2025.Forms.TeacherForms.TeacherAccount
{
    public partial class Form_TeacherAccount : MaterialForm
    {
        private Teacher tchr;
        public Form_TeacherAccount()
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

            tchr = DataManager.currentUser as Teacher;
        }

        private void Form_TeacherAccount_Load(object sender, EventArgs e)
        {
            lblDisc.Text += tchr.AssignedSubject.Name;
            lblName.Text += tchr.Name;
            lblNif.Text += tchr.NIF;
            lblPassword.Text = $"Senha: {new String('*', tchr.Password.Length)}";
            lblUsername.Text += tchr.Username;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClassRooms_Click(object sender, EventArgs e)
        {
            string result = "Turmas: ";
            foreach (ClassRoom clsrm in tchr.AssignedClassRooms.Items)
            {
                result += "\n" + $"{clsrm.Year.Id}º{clsrm.Id}";
            }
            MessageBox.Show(result, "Turmas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            lblPassword.Text = $"Senha: {tchr.Password}";
        }

        private void btnShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            lblPassword.Text = $"Senha: {new String('*', tchr.Password.Length)}";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form_EditTeacherAccount form_EditTeacherAccount = new Form_EditTeacherAccount(tchr);
            this.Hide();
            form_EditTeacherAccount.ShowDialog();
            this.Close();
        }
    }
}
