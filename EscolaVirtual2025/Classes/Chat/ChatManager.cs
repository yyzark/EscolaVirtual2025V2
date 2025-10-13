using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace EscolaVirtual2025.Classes.Chat
{
    internal class ChatManager
    {
        public static List<Chat> Chats = new List<Chat>();

        public static Chat GetOrCreateChat(Teacher teacher, Student student)
        {
           //procura chat
            var chat = Chats.FirstOrDefault(c => c.Teacher == teacher && c.Student == student);

            
            if (chat == null)
            {
                chat = new Chat(teacher, student);
                Chats.Add(chat);
            }

            return chat;
        }

        public static List<Chat> GetChatsByStudent(Student student)
        {
            return Chats.Where(c => c.Student == student).ToList();
        }

    }
}
