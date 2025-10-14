using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Chat;
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

namespace EscolaVirtual2025.Forms.Admin.AdminChats
{
    public partial class Form_TeacherRequest : MaterialForm
    {

        private Request m_notification;
        private Teacher newData;
        private Teacher oldData;
        public Form_TeacherRequest(Request notification)
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


            m_notification = notification;
            newData = notification.NewData as Teacher;
            oldData = notification.Sender as Teacher;
        }

        private void Form_TeacherRequest_Load(object sender, EventArgs e)
        {
            lblName.Text += " " + oldData.Name;
            lblPassword.Text += " " + oldData.Password;
            lblUser.Text += " " + oldData.Username;
            lblNif.Text += " " + oldData.NIF;
            lblDisc.Text += " " + oldData.AssignedSubject.Name;

            lblAssignedSubject.Text += " " + newData.AssignedSubject.Name;
            lblNewLogin.Text += " " + newData.Username;
            lblNewName.Text += " " + newData.Name;
            lblNewNif.Text += " " + newData.NIF;

            if (newData.Password != oldData.Password)
            {
                lblPassword.Text = "Password: Mudança de password";
                lblNewPassword.Text = "Password: Mudança de password";
            }
            else
            {
                lblPassword.Text = "Password: Password permanece";
                lblNewPassword.Text = "Password: Password permanece";
            }
        }

        private void btnClassRooms_Click(object sender, EventArgs e)
        {
            string result = "Turmas:";
            foreach(ClassRoom classRoom in oldData.AssignedClassRooms)
            {
                result += "\n" + classRoom.Year.AnoId + "º" + classRoom.Id;
            }
            MessageBox.Show(result, "De turmas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNewClassRooms_Click(object sender, EventArgs e)
        {
            string result = "Turmas:";
            foreach (ClassRoom classRoom in newData.AssignedClassRooms)
            {
                result += "\n" + classRoom.Year.AnoId + "º" + classRoom.Id;
            }
            MessageBox.Show(result, "De turmas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            ChatManager.SendGetNotificationFromAdmin(oldData).AddMessage(Program.Users[0].Name, "Lamentamos mas a alteração de dados foi rejeitada.");
            Program.Users[0].Notifications.Remove(m_notification);
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (Program.Users.Any(usr => usr.Username == newData.Username.Trim()))
            {
                MessageBox.Show(
                "Já existe um utilizador com este nome de utilizador!",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
                return;
            }
            ChatManager.SendGetNotificationFromAdmin(oldData)
               .AddMessage(Program.Users[0].Name, "A alteração de dados foi aprovada!");

            // Atualiza dados básicos
            oldData.Username = newData.Username;
            oldData.Name = newData.Name;
            oldData.Password = newData.Password;
            oldData.NIF = newData.NIF;
            oldData.AssignedSubject = newData.AssignedSubject;

            // Remove teacher das turmas antigas
            foreach (var cls in Program.ClassRooms)
            {
                foreach (var clsSubj in cls.Subjects)
                {
                    if (clsSubj.AssignedTeacher == oldData && clsSubj.Subject != oldData.AssignedSubject)
                        clsSubj.AssignedTeacher = null;
                }
            }

            // Adiciona teacher nas novas turmas
            foreach (var cls in oldData.AssignedClassRooms)
            {
                foreach (var clsSubj in cls.Subjects)
                {
                    if (clsSubj.Subject == oldData.AssignedSubject)
                        clsSubj.AssignedTeacher = oldData;
                }
            }

            Program.Users[0].Notifications.Remove(m_notification);
            this.Close();
        }
    }
}
