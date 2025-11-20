using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Data;
using System.Linq;

namespace EscolaVirtual2025.Classes.Academic
{
    public class Grade
    {
        public int Id { get; set; }

        public int[] P_Grade = new int[3] { -1, -1, -1 };
        public string[] Comment = new string[3];

        private string m_studentId;
        private int m_subjectId;



        public int GradeCount { get; set; }

        public Subject GradeSubject
        {
            get => DataManager.Subjects.FirstOrDefault(s => s.Id == m_subjectId);
            set => m_subjectId = value.Id;
        }

        public Student Student
        {
            get => DataManager.Students.FirstOrDefault(s => s.NIF == m_studentId);
            set => m_studentId = value.NIF;
        }

        public Grade(Subject GradeSubject, Student student, int Id)
        {
            this.GradeSubject = GradeSubject;
            Student = student;
            GradeCount = 0;
            this.Id = Id;
        }
    }
}
