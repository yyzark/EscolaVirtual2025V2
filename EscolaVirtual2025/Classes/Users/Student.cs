using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.InterFace;
using EscolaVirtual2025.Data;
using System.Linq;

namespace EscolaVirtual2025.Classes.Users
{
    public class Student : TeacherStudent
    {
        private SchoolCard m_schoolCard;

        public SchoolCard SchoolCard
        {
            get => m_schoolCard;
            set => m_schoolCard = value;
        }

        public ClassRoom ClassRoom
        {
            get => DataManager.ClassRooms.FirstOrDefault(c => c.Students.Any(s => s.NIF == NIF));
            set
            {
                var oldClass = ClassRoom;
                if (oldClass != null)
                    oldClass.RemoveStudent(this);

                if (value != null)
                    value.AddStudent(this);
            }
        }

        public EntityCollection<Grade, int> Grades = new EntityCollection<Grade, int>(DataManager.Grades, gd => gd.Id);
        public Student() : base(UserType.Student){  }

        public Student(string username, string password, string name, string nif, ClassRoom classRoom, SchoolCard schoolCard)
            : base(username, password, name, UserType.Student, nif)
        {
            ClassRoom = classRoom;
            SchoolCard = schoolCard;
        }
    }
}
