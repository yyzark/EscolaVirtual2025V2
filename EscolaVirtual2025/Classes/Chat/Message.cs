using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2025.Classes.Chat
{
    public class Message
    {
        private string m_sender;

        public string Sender
        {
            get { return m_sender; }
            set { m_sender = value; }
        }
        private string m_text;

        public string Text
        {
            get { return m_text; }
            set { m_text = value; }
        }
        public Message(string sender, string text)
        {
            Sender = sender;
            Text = text;
        }

        public override string ToString()
        {
            return $"{Sender}: {Text}";
        }
    }
}
