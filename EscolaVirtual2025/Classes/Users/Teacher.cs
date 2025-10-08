using EscolaVirtual2025.Classes.Academic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2025.Classes.Users
{
    public class Teacher : TeacherStudent
    {
        private Subject m_assignedSubject;

        public Subject AssignedSubject
        {
            get { return m_assignedSubject; }
            set { m_assignedSubject = value; }
        }

        //cavalo especial de corrida nº2
        public List<ClassRoom> AssignedClassRooms
        {
            get
            {
                return Program.ClassRooms
                              .Where(c => c.Subjects.Any(cs => cs.AssignedTeacher == this))
                              .ToList();
            }
        }
        public Teacher(string username, string password, string name, string nif, Subject subject) :
        base(username, password, name, UserType.Teacher, nif)
        {
            m_assignedSubject = subject;
        }
    }
}
