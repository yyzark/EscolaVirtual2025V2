using EscolaVirtual2025.Classes;
using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

            #region textbox placeholders
            txtPassword.GotFocus += (s, e) =>
            {
                if (txtPassword.Text == "Password")
                {
                    txtPassword.Text = "";
                    txtPassword.ForeColor = Color.Black;
                }
            };

            txtPassword.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    txtPassword.Text = "Password";
                    txtPassword.ForeColor = Color.Gray;
                }
            };

            txtLogin.GotFocus += (s, e) =>
            {
                if (txtLogin.Text == "Username")
                {
                    txtLogin.Text = "";
                    txtLogin.ForeColor = Color.Black;
                }
            };

            txtLogin.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtLogin.Text))
                {
                    txtLogin.Text = "Username";
                    txtLogin.ForeColor = Color.Gray;
                }
            };

            txtNIF.GotFocus += (s, e) =>
            {
                if (txtNIF.Text == "NIF")
                {
                    txtNIF.Text = "";
                    txtNIF.ForeColor = Color.Black;
                }
            };

            txtNIF.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtNIF.Text))
                {
                    txtNIF.Text = "NIF";
                    txtNIF.ForeColor = Color.Gray;
                }
            };

            txtName.GotFocus += (s, e) =>
            {
                if (txtName.Text == "Nome")
                {
                    txtName.Text = "";
                    txtName.ForeColor = Color.Black;
                }
            };

            txtName.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    txtName.Text = "Nome";
                    txtName.ForeColor = Color.Gray;
                }
            };
            #endregion
        }

        private void Form_AddStudent_Load(object sender, EventArgs e)
        {
            DefaultProps();

            foreach (Year year in Program.Anos)
            {
                cbbYear.Items.Add(year.AnoId);
            }

            Program.Anos.Sort((y1, y2) => y1.AnoId.CompareTo(y2.AnoId));
        }

        private void DefaultProps()
        {
            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.Gray;
            txtLogin.Text = "Username";
            txtLogin.ForeColor = Color.Gray;
            txtNIF.Text = "NIF";
            txtNIF.ForeColor = Color.Gray;
            txtName.Text = "Nome";
            txtName.ForeColor = Color.Gray;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int yearIndex = cbbYear.SelectedIndex;
            int classRoomIndex = cbbClassRoom.SelectedIndex;

            var selectedYear = Program.Anos[yearIndex];
            var selectedClassRoom = selectedYear.ClassRooms[classRoomIndex];

            // Criar aluno
            Student newStudent = new Student(
                txtLogin.Text,
                txtPassword.Text,
                txtName.Text,
                txtNIF.Text,
                selectedClassRoom);
            

            // Adicionar o aluno na turma
            Program.students.Add(newStudent);
            selectedClassRoom.Students[selectedClassRoom.StudentsCount] = newStudent;
            selectedClassRoom.StudentsCount++;
            Program.Users.Add(newStudent);

            MessageBox.Show("Aluno adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
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
            if(cbbYear.SelectedIndex != -1)
            {
                cbbClassRoom.Items.Clear();
                var selectedYear = Program.Anos[cbbYear.SelectedIndex];
                if (selectedYear.ClassRooms.Count > 0)
                {
                    foreach (var classRoom in selectedYear.ClassRooms)
                    {
                        cbbClassRoom.Items.Add(classRoom.Id);
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
            if(!Char.IsDigit(e.KeyChar))
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
