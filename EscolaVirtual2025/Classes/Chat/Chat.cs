using EscolaVirtual2025.Classes.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2025.Classes.Chat
{
    public class Chat
    {
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
        
        public User Admin {  get; set; }
        public List<Message> Messages { get; set; } = new List<Message>();

        public Chat(Teacher teacher, Student student)
        {
            Teacher = teacher;
            Student = student;
        }

        public Chat(User Admin, Student Student)
        {
            this.Student = Student;
            this.Admin = Admin;
        }

        public Chat(User Admin, Teacher Teacher)
        {
            this.Teacher = Teacher;
            this.Admin = Admin;
        }

        public void AddMessage(string sender, string text)
        {
            Messages.Add(new Message(sender, text));
        }
    }
}
