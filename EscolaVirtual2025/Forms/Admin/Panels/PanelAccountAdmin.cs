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
using EscolaVirtual2025.Data;
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
            lblPassword.Text = $"Senha: {DataManager.currentUser.Password}";
        }

        private void PanelAccountAdmin_Load(object sender, EventArgs e)
        {
            lblName.Text = $"Nome: {DataManager.currentUser.Name}";
            lblPassword.Text = $"Senha: {new string('*', DataManager.currentUser.Password.Length)}";
            lblUser.Text = $"Utilizador: {DataManager.currentUser.Username}";
            lblUserType.Text = $"Cargo: {DataManager.currentUser.UserType}";
        }
        private void btnShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            lblPassword.Text = $"Senha: {new string('*', DataManager.currentUser.Password.Length)}";
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            Edit?.Invoke(this, EventArgs.Empty);
        }
        private void PanelAccountAdmin_VisibleChanged(object sender, EventArgs e)
        {
            lblName.Text = $"Nome: {DataManager.currentUser.Name}";
            lblPassword.Text = $"Senha: {new string('*', DataManager.currentUser.Password.Length)}";
            lblUser.Text = $"Utilizador: {DataManager.currentUser.Username}";
            lblUserType.Text = $"Cargo: {DataManager.currentUser.UserType}";
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {

        }

        private void grbDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
