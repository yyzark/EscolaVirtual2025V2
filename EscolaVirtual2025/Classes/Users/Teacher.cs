using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.InterFace;
using EscolaVirtual2025.Data;
using System.Collections.Generic;
using System.Linq;

namespace EscolaVirtual2025.Classes.Users
{
    public class Teacher : TeacherStudent
    {
        private int m_assignedSubjectId;
        private List<int> m_assignedClassRoomIds = new List<int>();

        public Subject AssignedSubject
        {
            get => DataManager.Subjects.FirstOrDefault(s => s.Id == m_assignedSubjectId);
            set => m_assignedSubjectId = value.Id;
        }

        public EntityCollection<ClassRoom, int> AssignedClassRooms = new EntityCollection<ClassRoom, int>(DataManager.ClassRooms, cl => cl.Id);

        public Teacher() : base() { }

        public Teacher(string username, string password, string name, int nif, Subject subject)
            : base(username, password, name, UserType.Teacher, nif)
        {
            AssignedSubject = subject;
        }
    }
}
