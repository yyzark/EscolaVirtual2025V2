using EscolaVirtual2025.Classes.Chat;
using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Forms.TeacherForms.TeacherChat;
using MaterialSkin;using EscolaVirtual2025.Data;
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

namespace EscolaVirtual2025.Forms.StudentsForms.StudentChat
{
    public partial class Form_StudentChats : MaterialForm
    {
        private List<Chat> m_currentChats = new List<Chat>();
        private Student m_student;

        public Form_StudentChats()
        {
            InitializeComponent();

            m_student = Program.userAtual as Student;

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

        private void Form_StudentChats_Load(object sender, EventArgs e)
        {
            lsbChats.Items.Clear();
            m_currentChats.Clear();

            foreach (var chat in ChatManager.GetChatsByStudent(m_student))
            {
                m_currentChats.Add(chat);

                string name = chat.Teacher != null ? chat.Teacher.Name : chat.Admin.Name;

                bool hasUnread = m_student.Notifications.Any(n =>
                    !n.Read &&
                    ((chat.Teacher != null && n.Sender == chat.Teacher) ||
                     (chat.Admin != null && n.Sender == chat.Admin))
                );

                string displayText = hasUnread ? "[NÃO LIDO] " + name : name;

                lsbChats.Items.Add(new MaterialListBoxItem(displayText));
            }

        }

        private void lsbChats_DoubleClick(object sender, EventArgs e)
        {
            int index = lsbChats.SelectedIndex;
            if (index < 0 || index >= m_currentChats.Count) return;

            Chat chat = m_currentChats[index];
            m_student.Notifications[index].Read = true;
            Form_StudentChat chatForm = new Form_StudentChat(chat);
            this.Hide();
            chatForm.ShowDialog();
            this.Show();
        }

        private void Form_StudentChats_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible) return;

            lsbChats.Items.Clear();
            m_currentChats.Clear();

            foreach (var chat in ChatManager.GetChatsByStudent(m_student))
            {
                m_currentChats.Add(chat);

                string name = chat.Teacher != null ? chat.Teacher.Name : chat.Admin.Name;

                bool hasUnread = m_student.Notifications.Any(n =>
                    !n.Read &&
                    ((chat.Teacher != null && n.Sender == chat.Teacher) ||
                     (chat.Admin != null && n.Sender == chat.Admin))
                );

                string displayText = hasUnread ? "[NÃO LIDO] " + name : name;
                lsbChats.Items.Add(new MaterialListBoxItem(displayText));
            }
        }
    }
}
