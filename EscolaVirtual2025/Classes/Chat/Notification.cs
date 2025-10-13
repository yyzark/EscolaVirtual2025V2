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
        private bool m_read;
        private NotificationType m_type;
        private User m_sender;
        private User m_reciever;
        public bool Read
        {
            get { return m_read; }
            set { m_read = value; }
        }

        public NotificationType Type
        {
            get { return m_type; }
            set { m_type = value; }
        }
        public User Sender
        {
            get { return m_sender; }
            set { m_sender = value; }
        }

        public User Reciever
        {
            get { return m_reciever; }
        }

        public Notification(NotificationType type, User sender, User reciever)
        {
            m_type = type;
            m_read = false;
            m_sender = sender;
            m_reciever = reciever;
        }
    }
}
