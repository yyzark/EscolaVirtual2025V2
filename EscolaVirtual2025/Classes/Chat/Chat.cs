using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Data;
using System.Collections.Generic;
using System.Linq;

namespace EscolaVirtual2025.Classes.Chat
{
    public class Chat
    {
        private int? m_teacherNif;
        private int? m_studentNif;
        private bool m_hasAdmin;

        public List<Message> Messages { get; set; } = new List<Message>();

        public Teacher Teacher
        {
            get => m_teacherNif.HasValue ? DataManager.Teachers.FirstOrDefault(t => t.NIF == m_teacherNif.Value) : null;
            set => m_teacherNif = value?.NIF;
        }

        public Student Student
        {
            get => m_studentNif.HasValue ? DataManager.Students.FirstOrDefault(s => s.NIF == m_studentNif.Value) : null;
            set => m_studentNif = value?.NIF;
        }

        public bool HasAdmin => m_hasAdmin;

        public User Admin => m_hasAdmin ? DataManager.Users.FirstOrDefault(u => u.UserType == UserType.Admin) : null;

        // Construtores
        public Chat(Teacher teacher, Student student)
        {
            Teacher = teacher;
            Student = student;
            m_hasAdmin = false;
        }

        public Chat(Student student)
        {
            Student = student;
            m_hasAdmin = true;
        }

        public Chat(Teacher teacher)
        {
            Teacher = teacher;
            m_hasAdmin = true;
        }

        // Adiciona uma mensagem
        public void AddMessage(string sender, string text)
        {
            Messages.Add(new Message(sender, text));
        }
    }
}
