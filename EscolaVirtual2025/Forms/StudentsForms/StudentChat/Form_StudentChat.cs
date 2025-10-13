using EscolaVirtual2025.Classes.Chat;
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
using static System.Net.Mime.MediaTypeNames;

namespace EscolaVirtual2025.Forms.TeacherForms.TeacherChat
{
    public partial class Form_StudentChat : MaterialForm
    {
        private readonly Chat m_chat;
        public Form_StudentChat(Chat chat)
        {
            InitializeComponent();

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

            m_chat = chat;

            if (chat.Teacher != null)
                Text = $"Chat com: {chat.Teacher.Name}";
            else if (chat.Admin != null)
                Text = $"Chat com: {chat.Admin.Name}";
        }

        private void Form_StudentChat_Load(object sender, EventArgs e)
        {
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
    }
}
