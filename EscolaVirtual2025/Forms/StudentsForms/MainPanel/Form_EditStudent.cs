using EscolaVirtual2025.Classes;
using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Chat;
using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Data;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EscolaVirtual2025.Forms.StudentsForms.MainPanel
{
    public partial class Form_EditStudent : MaterialForm
    {
        private Student stdnt;
        public Form_EditStudent(Student student)
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

            stdnt = student;
        }

        private void Form_EditStudent_Load(object sender, EventArgs e)
        {

            foreach (ClassRoom room in stdnt.ClassRoom.Year.ClassRooms.Items)
            {
                cbbClassRoom.Items.Add($"{stdnt.ClassRoom.Year.Id}º{room.Id}");
            }
            cbbClassRoom.SelectedIndex = stdnt.ClassRoom.Year.ClassRooms.Items.IndexOf(stdnt.ClassRoom);

            txtLogin.Text = stdnt.Username;
            txtPassword.Text = stdnt.Password;
            txtName.Text = stdnt.Name;
            txtNIF.Text = stdnt.NIF.ToString();

            UpdateAcceptButtonState();
        }
        private void UpdateAcceptButtonState()
        {
            bool allFieldsValid =
                txtLogin.Text == stdnt.Username &&
                txtPassword.Text == stdnt.Password &&
                txtName.Text == stdnt.Name &&
                txtNIF.Text == stdnt.NIF.ToString() &&
                cbbClassRoom.SelectedIndex == stdnt.ClassRoom.Year.ClassRooms.Items.IndexOf(stdnt.ClassRoom);

            bool allFieldsFilled =
                txtLogin.Text.Length > 0 &&
                txtPassword.Text.Length > 0 &&
                txtName.Text.Length > 0 &&
                txtNIF.TextLength == 9;

            btnAccept.Enabled = allFieldsFilled && !allFieldsValid;
        }

        private void txtNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Utils.IsAllowedNameCharacter(e.KeyChar) || Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Utils.IsAllowedCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Utils.IsAllowedCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            UpdateAcceptButtonState();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            UpdateAcceptButtonState();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            UpdateAcceptButtonState();
        }

        private void txtNIF_TextChanged(object sender, EventArgs e)
        {
            UpdateAcceptButtonState();
        }

        private void cbbClassRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAcceptButtonState();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_EditStudent_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (DataManager.Users.Any(usr => usr.Username == txtLogin.Text.Trim() && usr.Username != stdnt.Username))
            {
                MessageBox.Show(
                "Já existe um utilizador com este nome de utilizador!",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
                return;
            }
            else
            {
                if (txtPassword.Text.Length < 4)
                {
                    MessageBox.Show(
                    "A senha deve ter pelo menos 4 caracteres!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                    return;
                }
                else
                {
                    // Verifica se o NIF tem exatamente 9 dígitos numéricos
                    string nif = txtNIF.Text;
                    if (nif != stdnt.NIF.ToString())
                    {
                        // Verifica duplicações de NIF em Teachers e Students
                        bool nifExists = DataManager.Users.Any(u =>
                        {
                            if (u.UserType == UserType.Teacher && u is Teacher teacher)
                                return teacher.NIF.ToString() == nif;

                            if (u.UserType == UserType.Student && u is Student student)
                                return student.NIF.ToString() == nif;

                            return false;
                        });

                        if (nifExists)
                        {
                            MessageBox.Show("Já existe um utilizador (professor ou aluno) com este NIF.",
                                            "NIF duplicado",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            txtNIF.Focus();
                            return;
                        }
                    }

                    foreach (Notification notification in DataManager.Users[0].Notifications)
                    {
                        if (notification.Sender == stdnt)
                            DataManager.Users[0].Notifications.Remove(notification);
                    }

                    DataManager.Users[0].Notifications.Add(new Request(stdnt, DataManager.Users[0], new Student(txtLogin.Text, txtPassword.Text, txtName.Text, Convert.ToInt32(nif), stdnt.ClassRoom.Year.ClassRooms.Items[cbbClassRoom.SelectedIndex], stdnt.SchoolCard)));

                    MessageBox.Show("O pedido foi enviado ao administrador!.",
                                        "Sucesso",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
