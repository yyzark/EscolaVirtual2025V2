using EscolaVirtual2025.Forms.Admin.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual2025.Forms.Admin
{
    public partial class PanelAccountAdmin : UserControl
    {
        public event EventHandler Edit;
        public PanelAccountAdmin()
        {
            InitializeComponent();
        }
        private void btnShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            lblPassword.Text = $"Senha: {Program.userAtual.Password}";
        }

        private void PanelAccountAdmin_Load(object sender, EventArgs e)
        {
            lblName.Text = $"Nome: {Program.userAtual.Name}";
            lblPassword.Text = $"Senha: {new string('*', Program.userAtual.Password.Length)}";
            lblUser.Text = $"Utilizador: {Program.userAtual.Username}";
            lblUserType.Text = $"Cargo: {Program.userAtual.UserType}";
        }
        private void btnShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            lblPassword.Text = $"Senha: {new string('*', Program.userAtual.Password.Length)}";
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            Edit?.Invoke(this, EventArgs.Empty);
        }
        private void PanelAccountAdmin_VisibleChanged(object sender, EventArgs e)
        {
            lblName.Text = $"Nome: {Program.userAtual.Name}";
            lblPassword.Text = $"Senha: {new string('*', Program.userAtual.Password.Length)}";
            lblUser.Text = $"Utilizador: {Program.userAtual.Username}";
            lblUserType.Text = $"Cargo: {Program.userAtual.UserType}";
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {

        }

        private void grbDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
