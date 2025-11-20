using EscolaVirtual2025.Classes;
using EscolaVirtual2025.Data;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            txtName.Text = DataManager.currentUser.Name;
            txtPassword.Text = DataManager.currentUser.Password;
            txtUser.Text = DataManager.currentUser.Username;
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
            DataManager.currentUser.Name != txtName.Text ||
            DataManager.currentUser.Password != txtPassword.Text ||
            DataManager.currentUser.Username != txtUser.Text
            )
            {
                if (DataManager.Users.Any(usr => usr.Username == txtUser.Text)
                     && DataManager.currentUser.Username != txtUser.Text)
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
                            DataManager.currentUser.Name = txtName.Text;
                            DataManager.currentUser.Password = txtPassword.Text;
                            DataManager.currentUser.Username = txtUser.Text;

                            Cancel?.Invoke(this, EventArgs.Empty);
                        }
                        else
                        {
                            txtName.Text = DataManager.currentUser.Name;
                            txtPassword.Text = DataManager.currentUser.Password;
                            txtUser.Text = DataManager.currentUser.Username;
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
            txtName.Text = DataManager.currentUser.Name;
            txtPassword.Text = DataManager.currentUser.Password;
            txtUser.Text = DataManager.currentUser.Username;
        }
    }
}
