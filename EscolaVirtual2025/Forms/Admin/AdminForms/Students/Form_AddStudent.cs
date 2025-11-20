using EscolaVirtual2025.Classes;
using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Data;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EscolaVirtual2025.Forms.Admin.AdminForms.Students
{
    public partial class Form_AddStudent : MaterialForm
    {
        public Form_AddStudent()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

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

        }

        private void Form_AddStudent_Load(object sender, EventArgs e)
        {
            foreach (Year year in DataManager.Years)
            {
                cbbYear.Items.Add(year.Id);
            }

            DataManager.Years.Sort((y1, y2) => y1.Id.CompareTo(y2.Id));
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (DataManager.Users.Any(usr => usr.Username == txtLogin.Text.Trim()))
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
                if (txtPassword.Text.Length < 6)
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

                    int yearIndex = cbbYear.SelectedIndex;
                    int classRoomIndex = cbbClassRoom.SelectedIndex;

                    var selectedYear = DataManager.Years[yearIndex];
                    var selectedClassRoom = selectedYear.ClassRooms.Items[classRoomIndex];



                    // Criar aluno
                    Student newStudent = new Student(
                        txtLogin.Text,
                        txtPassword.Text,
                        txtName.Text,
                        txtNIF.Text,
                        selectedClassRoom,
                        new SchoolCard(DataManager.SchoolCards.Count + 1)
                        );

                    // Adicionar o aluno na turma
                    DataManager.Students.Add(newStudent);
                    selectedClassRoom.OrderStudentsByName();
                    DataManager.Users.Add(newStudent);

                    MessageBox.Show("Aluno adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //DataManager.Save();
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_AddStudent_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void cbbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbYear.SelectedIndex != -1)
            {
                cbbClassRoom.Items.Clear();
                var selectedYear = DataManager.Years[cbbYear.SelectedIndex];
                if (selectedYear.ClassRooms.Items.Count > 0)
                {
                    foreach (var classRoom in selectedYear.ClassRooms.Items)
                    {
                        cbbClassRoom.Items.Add(classRoom.Letter);
                    }
                    cbbClassRoom.Enabled = true;
                    cbbClassRoom.Focus();
                }
                else
                {
                    cbbClassRoom.Enabled = false;
                    cbbClassRoom.Text = "";
                    cbbClassRoom.SelectedIndex = -1;
                }
            }
            else
            {
                cbbClassRoom.Enabled = false;
            }

            UpdateAcceptButtonState();
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

        private void UpdateAcceptButtonState()
        {
            bool allFieldsValid =
                !string.IsNullOrWhiteSpace(txtLogin.Text) &&
                !string.IsNullOrWhiteSpace(txtName.Text) &&
                !string.IsNullOrWhiteSpace(txtNIF.Text) &&
                !string.IsNullOrWhiteSpace(txtPassword.Text) &&
                cbbYear.SelectedIndex != -1 &&
                cbbClassRoom.SelectedIndex != -1 &&
                txtLogin.Text != "Username" &&
                txtName.Text != "Nome" &&
                txtNIF.Text != "NIF" &&
                txtPassword.Text != "Password" &&
                txtNIF.TextLength >= 9;

            btnAccept.Enabled = allFieldsValid;
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
    }
}
