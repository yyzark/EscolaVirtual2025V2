using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2025.Classes.Chat
{
    public class Request : Notification
    {
        private User m_newData;

        public User NewData
        {
            get { return m_newData; }
        }

        public Request(User sender, User reciever, User newData) : base(NotificationType.request, sender, reciever)
        {
            m_newData = newData;
        }
    }
}
