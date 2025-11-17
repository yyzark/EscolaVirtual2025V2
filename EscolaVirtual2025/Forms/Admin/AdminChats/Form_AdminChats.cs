using EscolaVirtual2025.Classes.Chat;
using MaterialSkin;using EscolaVirtual2025.Data;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual2025.Forms.Admin.AdminChats
{
    public partial class Form_AdminChats : MaterialForm
    {
        public Form_AdminChats()
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
        }

        private void Form_AdminChats_Load(object sender, EventArgs e)
        {
            lsbChats.Items.Clear();
            foreach (Notification notification in Program.Users[0].Notifications) 
            {
                string prefix = notification.Read ? "" : "[NÃO LIDO] ";
                lsbChats.Items.Add(new MaterialListBoxItem(prefix + "User: " + notification.Sender.Username + " Nome: " + notification.Sender.Name));
            }
        }

        private void lsbChats_DoubleClick(object sender, EventArgs e)
        {
            int index = lsbChats.SelectedIndex;
            if (index < 0 || index >= Program.Users[0].Notifications.Count) return;
            Program.Users[0].Notifications[index].Read = true;
            if (Program.Users[0].Notifications[index].Sender.UserType == Classes.UserType.Student)
            {
                Form_StudentRequest form_StudentRequest = new Form_StudentRequest(Program.userAtual.Notifications[lsbChats.SelectedIndex] as Request);
                this.Hide();
                form_StudentRequest.ShowDialog();
                if (Program.Users[0].Notifications.Count == 0)
                    this.Close();

                this.Show();
            }
            else
            {
                Form_TeacherRequest form_teacherRequest = new Form_TeacherRequest(Program.userAtual.Notifications[lsbChats.SelectedIndex] as Request);
                this.Hide();
                form_teacherRequest.ShowDialog();
                if (Program.Users[0].Notifications.Count == 0)
                    this.Close();

                this.Show();
            }
        }

        private void Form_AdminChats_VisibleChanged(object sender, EventArgs e)
        {
            lsbChats.Items.Clear();
            foreach (Notification notification in Program.Users[0].Notifications)
            {
                string prefix = notification.Read ? "" : "[NÃO LIDO] ";
                lsbChats.Items.Add(new MaterialListBoxItem(prefix + "User: " + notification.Sender.Username + " Nome: " + notification.Sender.Name));
            }
        }
    }
}
