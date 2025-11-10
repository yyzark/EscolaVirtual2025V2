using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Forms.TeacherForms;
namespace EscolaVirtual2025.Classes.Users
{
    public class Student : TeacherStudent
    {
        private ClassRoom m_classRoom;
        private List<Grade> m_grades;
        private SchoolCard m_schoolCard;

        public SchoolCard SchoolCard
        {
            get { return m_schoolCard; }
            set { m_schoolCard = value; }
        }
        public ClassRoom ClassRoom
        {
            get { return m_classRoom; }
            set { m_classRoom = value; }
        }
        public List<Grade> Grades
        {
            get { return m_grades; }
            set { m_grades = value; }
        }

        public Student(string username, string password, string name, string nif, ClassRoom classRoom, SchoolCard schoolCard) :
        base(username, password, name, UserType.Student, nif)
        {
            m_classRoom = classRoom;
            m_grades = new List<Grade>();
            this.SchoolCard = schoolCard;
        }

        public Student() { }
    }
}
