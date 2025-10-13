using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaVirtual2025.Classes.Chat;

namespace EscolaVirtual2025.Classes.Chat
{
    public class NotificationMessage : Notification
    {
        public NotificationMessage(User sender, User reciever) : base(NotificationType.message, sender, reciever)
        {
        }
    }
}
