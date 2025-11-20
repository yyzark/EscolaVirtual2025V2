using EscolaVirtual2025.Classes.InterFace;
using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Data;
using System;
using System.Linq;

namespace EscolaVirtual2025.Classes.Academic
{
    public class ClassRoom
    {
        public int Id { get; set; }
        public char Letter { get; set; }

        private int[] m_studentsNif = new int[20];
        private int m_yearId;

        private int m_studentsCount = 0;
        public int StudentsCount => m_studentsCount;

        public Student[] Students
        {
            get => m_studentsNif
                .Take(m_studentsCount)
                .Select(nif => DataManager.Students.FirstOrDefault(s => s.NIF == nif))
                .Where(s => s != null)
                .ToArray();
            set
            {
                if (value.Length > 20)
                    throw new InvalidOperationException("Cannot assign more than 20 students.");

                m_studentsCount = value.Length;
                for (int i = 0; i < m_studentsCount; i++)
                    m_studentsNif[i] = value[i].NIF;
            }
        }

        public EntityCollection<ClassSubject, int> ClassSubjects = new EntityCollection<ClassSubject, int>(DataManager.ClassSubjects, cls => cls.Id);
        public Year Year
        {
            get { return DataManager.Years.FirstOrDefault(yr => yr.Id == m_yearId); }
            set { m_yearId = value.Id; }
        }
        public ClassRoom() { }

        public ClassRoom(char letter, Year year, int id)
        {
            Letter = letter;
            m_yearId = year.Id;
            m_studentsCount = 0;
            Id = id;

            foreach (var sbj in DataManager.Subjects.Where(s => s.Years.Items.Any(y => y.Id == m_yearId)))
                ClassSubjects.Add(new ClassSubject(null, sbj));
        }

        public void AddStudent(Student student)
        {
            if (m_studentsCount >= m_studentsNif.Length)
                throw new InvalidOperationException("A turma está cheia.");

            if (m_studentsNif.Take(m_studentsCount).Contains(student.NIF))
                throw new InvalidOperationException("O aluno já está nesta turma.");

            m_studentsNif[m_studentsCount] = student.NIF;
            m_studentsCount++;
        }

        public void RemoveStudent(Student student)
        {
            int index = Array.IndexOf(m_studentsNif, student.NIF, 0, m_studentsCount);
            if (index == -1)
                throw new InvalidOperationException("O aluno não está nesta turma.");

            for (int i = index; i < m_studentsCount - 1; i++)
                m_studentsNif[i] = m_studentsNif[i + 1];

            m_studentsNif[m_studentsCount - 1] = 0;
            m_studentsCount--;
        }

        public void OrderStudentsByName()
        {
            if (m_studentsCount <= 1) return;

            var sorted = m_studentsNif
                .Take(m_studentsCount)
                .Select(nif => DataManager.Students.FirstOrDefault(s => s.NIF == nif))
                .Where(s => s != null)
                .OrderBy(s => s.Name)
                .ToArray();

            for (int i = 0; i < sorted.Length; i++)
                m_studentsNif[i] = sorted[i].NIF;
        }
    }
}
