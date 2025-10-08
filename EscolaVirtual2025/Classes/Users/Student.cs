using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaVirtual2025.Classes.Academic;
namespace EscolaVirtual2025.Classes.Users
{
    public class Student : TeacherStudent
    {
        private ClassRoom m_classRoom;

        public ClassRoom ClassRoom
        {
            get { return m_classRoom; }
            set { m_classRoom = value; }
        }


        public Student(string username, string password, string name, string nif, ClassRoom classRoom) :
        base(username, password, name, UserType.Student, nif)
        {
            m_classRoom = classRoom;
        }
    }
}
