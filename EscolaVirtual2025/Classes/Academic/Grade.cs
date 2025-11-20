using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Data;
using System.Linq;

namespace EscolaVirtual2025.Classes.Academic
{
    public class Grade
    {
        public int Id { get; set; }

        private int[] m_grade = new int[3] { -1, -1, -1 };
        private string[] m_comment = new string[3];

        private int m_studentId;
        private int m_subjectId;

        public int[] P_Grade
        {
            get => m_grade;
            set => m_grade = value;
        }

        public string[] Comment
        {
            get => m_comment;
            set => m_comment = value;
        }

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
