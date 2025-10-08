using EscolaVirtual2025.Classes;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace EscolaVirtual2025.Forms.Admin.Panels
{
    public partial class PanelAccountAdminEdit : UserControl
    {
        public event EventHandler Cancel;

        public event EventHandler BeforeDialog;
        public event EventHandler AfterDialog;

        public PanelAccountAdminEdit()
        {
            InitializeComponent();
        }

        private void PanelAccountAdminEdit_Load(object sender, EventArgs e)
        {
            txtName.Text = Program.userAtual.Name;
            txtPassword.Text = Program.userAtual.Password;
            txtUser.Text = Program.userAtual.Username;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke(this, EventArgs.Empty);
        }

        private async void btnApply_Click(object sender, EventArgs e)
        {
            MaterialTextBox2[] txt = { txtName, txtPassword, txtUser };
            if (txt.Any(tx => string.IsNullOrEmpty(tx.Text)))
            {
                MessageBox.Show(
                    "Preencha todos os campos!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            if (
            Program.userAtual.Name != txtName.Text ||
            Program.userAtual.Password != txtPassword.Text ||
            Program.userAtual.Username != txtUser.Text
            )
            {
                if (Program.Users.Any(usr => usr.Username == txtUser.Text)
                     && Program.userAtual.Username != txtUser.Text)
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
                        BeforeDialog?.Invoke(this, EventArgs.Empty);

                        DialogResult result = MessageBox.Show(
                        "Tem a certeza que quer aplicar as alterações?",
                        "Confirmação",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                        );

                        if (result == DialogResult.Yes)
                        {
                            //aplicar alterações
                            Program.userAtual.Name = txtName.Text;
                            Program.userAtual.Password = txtPassword.Text;
                            Program.userAtual.Username = txtUser.Text;

                            Cancel?.Invoke(this, EventArgs.Empty);
                        }
                        else
                        {
                            txtName.Text = Program.userAtual.Name;
                            txtPassword.Text = Program.userAtual.Password;
                            txtUser.Text = Program.userAtual.Username;
                        }
                        await Task.Delay(200);
                        AfterDialog?.Invoke(this, EventArgs.Empty);
                    }
                }
            }
            else
            {
                Cancel?.Invoke(this, EventArgs.Empty);
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Utils.IsAllowedNameCharacter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PanelAccountAdminEdit_VisibleChanged(object sender, EventArgs e)
        {
            txtName.Text = Program.userAtual.Name;
            txtPassword.Text = Program.userAtual.Password;
            txtUser.Text = Program.userAtual.Username;
        }
    }
}
