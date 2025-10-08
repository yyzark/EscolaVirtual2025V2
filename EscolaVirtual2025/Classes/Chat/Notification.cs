using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2025.Classes.Chat
{
    public enum NotificationType
    {
        message,
        request
    }
    public class Notification
    {
        private readonly string m_message;
        private readonly NotificationType m_type;
        private bool m_read;
        public string Message
        {
            get { return m_message; }
        } 

        public bool Read
        {
            get { return m_read; }
            set { m_read = value; }
        }

        public NotificationType Type
        {
            get { return m_type; }
        }

        public Notification(string message, NotificationType type)
        {
            m_message = message;
            m_type = type;
            m_read = false;
        }
    }
}
