using EscolaVirtual2025.Classes.Chat;
using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Data;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EscolaVirtual2025.Forms.Admin.AdminChats
{
    public partial class Form_StudentRequest : MaterialForm
    {
        private Request m_notification;
        private Student newData;
        private Student oldData;
        public Form_StudentRequest(Request notification)
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
            newData = notification.NewData as Student;
            oldData = notification.Sender as Student;
        }

        private void Form_StudentRequest_Load(object sender, EventArgs e)
        {
            lblClassRoom.Text += " " + oldData.ClassRoom.Year.Id + "º" + oldData.ClassRoom.Id;
            lblName.Text += " " + oldData.Name;
            lblPassword.Text += " " + oldData.Password;
            lblUser.Text += " " + oldData.Username;
            lblNif.Text += " " + oldData.NIF;

            lblNewClassRoom.Text += " " + newData.ClassRoom.Year.Id + "º" + newData.ClassRoom.Id;
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

        private void btnReject_Click(object sender, EventArgs e)
        {
            ChatManager.SendGetNotificationFromAdmin(oldData).AddMessage(DataManager.Users[0].Name, "Lamentamos mas a alteração de dados foi rejeitada.");
            DataManager.Users[0].Notifications.Remove(m_notification);
            ////DataManager.Save();
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (DataManager.Users.Any(usr => usr.Username == newData.Username.Trim()))
            {
                MessageBox.Show(
                "Já existe um utilizador com este nome de utilizador!",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
                return;
            }
            // Envia mensagem via chat
            ChatManager.SendGetNotificationFromAdmin(oldData)
                       .AddMessage(DataManager.Users[0].Name, "A alteração de dados foi aprovada!");

            // Atualiza dados básicos
            oldData.Username = newData.Username;
            oldData.Name = newData.Name;
            oldData.Password = newData.Password;
            oldData.NIF = newData.NIF;

            // Remove das turmas antigas
            foreach (var cls in DataManager.ClassRooms)
            {
                cls.RemoveStudent(oldData);
            }

            // Adiciona na nova turma
            var newClass = newData.ClassRoom;
            newClass.AddStudent(newData);
            oldData.ClassRoom = newClass;

            // Notificação
            oldData.Notifications.Add(new Notification(NotificationType.message, DataManager.Users[0], oldData));

            // Remove notificação do admin
            DataManager.Users[0].Notifications.Remove(m_notification);
            //DataManager.Save();
            this.Close();
        }
    }
}
