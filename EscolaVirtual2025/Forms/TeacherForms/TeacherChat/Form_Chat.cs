using EscolaVirtual2025.Classes.Chat;
using MaterialSkin;using EscolaVirtual2025.Data;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace EscolaVirtual2025.Forms.TeacherForms.TeacherChat
{
    public partial class Form_Chat : MaterialForm
    {
        private readonly Chat m_chat;

        public Form_Chat(Chat chat)
        {
            InitializeComponent();
            m_chat = chat;

            // Configuração MaterialSkin
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.LIGHT;
            skin.ColorScheme = new ColorScheme(
                Primary.Red300,
                Primary.Red700,
                Primary.Red100,
                Accent.Orange200,
                TextShade.WHITE
            );

            Text = $"Chat com: {chat.Student.Name}";
        }

        private void Form_Chat_Load(object sender, EventArgs e)
        {
            UpdateMessages();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string text = txtMessage.Text.Trim();
            if (string.IsNullOrEmpty(text))
                return;

            // Adiciona mensagem do professor
            m_chat.AddMessage(m_chat.Teacher.Name, text);
            m_chat.Student.Notifications.Add(new NotificationMessage(m_chat.Teacher, m_chat.Student));

            txtMessage.Text = string.Empty;
            UpdateMessages();
        }

        private void UpdateMessages()
        {
            listMessages.Items.Clear();

            foreach (var msg in m_chat.Messages)
            {
                var item = new MaterialListBoxItem($"{msg.Sender}: {msg.Text}");
                listMessages.Items.Add(item);
            }

            // Rola para a última mensagem
            if (listMessages.Items.Count > 0)
                listMessages.SelectedIndex = listMessages.Items.Count - 1;
        }

        private void Form_Chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DataManager.Save();
        }
    }
}
