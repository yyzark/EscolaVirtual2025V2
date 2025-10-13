using EscolaVirtual2025.Classes.Academic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaVirtual2025.Classes.Users;

namespace EscolaVirtual2025.Classes.Users
{
    public class Teacher : TeacherStudent
    {
        private Subject m_assignedSubject;
        private List<ClassRoom> m_assignedClassRooms;

        public List <ClassRoom> AssignedClassRooms
        {
            get {  return m_assignedClassRooms; }
            set { m_assignedClassRooms = value;}
        }
        public Subject AssignedSubject
        {
            get { return m_assignedSubject; }
            set { m_assignedSubject = value; }
        }
        public Teacher(string username, string password, string name, string nif, Subject subject) :
        base(username, password, name, UserType.Teacher, nif)
        {
            m_assignedSubject = subject;
            m_assignedClassRooms = new List<ClassRoom>();
        }

        public Teacher(string username, string password, string name, string nif, List<ClassRoom> classRooms, Subject subject) :
        base(username, password, name, UserType.Teacher, nif)
        {
            m_assignedSubject = subject;
            m_assignedClassRooms = classRooms;
        }
        public Teacher() : base() { }
    }
}
