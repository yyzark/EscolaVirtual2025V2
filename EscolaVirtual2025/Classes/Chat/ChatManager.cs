using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Forms.Admin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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

        public static Chat SendGetNotificationFromAdmin(User teacherStudent)
        {
            Chat chat = null;
            User admin = Program.Users[0];

            if (teacherStudent.UserType == UserType.Student)
            {
                var student = teacherStudent as Student;

                chat = Chats.FirstOrDefault(c => c.Admin == admin && c.Student == student);

                if (chat == null)
                {
                    chat = new Chat(admin, student);
                    Chats.Add(chat);
                }
            }
            else if (teacherStudent.UserType == UserType.Teacher)
            {
                var teacher = teacherStudent as Teacher;

                chat = Chats.FirstOrDefault(c => c.Admin == admin && c.Teacher == teacher);

                if (chat == null)
                {
                    chat = new Chat(admin, teacher);
                    Chats.Add(chat);
                }
            }

            return chat;
        }

        public static List<Chat> GetChatsByStudent(Student student)
        {
            return Chats.Where(c => c.Student == student).ToList();
        }


        private static readonly string documentsPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        private static readonly string saveFolder =
            Path.Combine(documentsPath, "EscolaData");

        private static readonly string chatFile =
            Path.Combine(saveFolder, "chats.json");


        public static void Save()
        {
            Directory.CreateDirectory(saveFolder);
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

            File.WriteAllText(chatFile, JsonSerializer.Serialize(Chats, options));

        }

        public static void Load()
        {
            try
            {
                if (!File.Exists(chatFile))
                {
                    Chats = new List<Chat>();
                    return;
                }

                string json = File.ReadAllText(chatFile);
                Chats = JsonSerializer.Deserialize<List<Chat>>(json) ?? new List<Chat>();
            }
            catch (FileNotFoundException ex)
            {

                    Chats = new List<Chat>();
                    Load();
                
            }
        }
    }
}
