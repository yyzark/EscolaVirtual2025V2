using EscolaVirtual2025.Classes.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2025.Classes.Academic
{
    public class ClassRoom
    {
        private Student[] m_students;
        private char m_id;
        private List<ClassSubject> m_subjects;
        private Year m_year;
        private int m_studentsCount;
        public char Id
        {
            get { return m_id; }
            set { m_id = value; }
        }
        public Student[] Students
        {
            get { return m_students; }
            set { m_students = value; }
        }

        public ClassRoom() {}

        public ClassRoom(char id, Year year)
        {
            m_id = id;
            Subjects = new List<ClassSubject>();
            m_students = new Student[20];
            m_year = year;
            m_studentsCount = 0;
            foreach(Subject sbjct in Year.Subjects)
            {
                Subjects.Add(new ClassSubject(null, sbjct));
            }
        }
        public List<ClassSubject> Subjects
        {
            get { return m_subjects; }
            set { m_subjects = value; }
        }

        public Year Year   
        {
            get { return m_year; }
            set { m_year = value; }
        }

        public int StudentsCount
        {
            get { return m_studentsCount; }
            set { m_studentsCount = value; }
        }

        public void RemoveStudent(Student student)
        {
            for (int i = 0; i < m_studentsCount; i++)
            {
                if(m_students[i].NIF == student.NIF)
                {
                    // "shift-left" para tapar o buraco no array
                    for (int j = i; j < m_studentsCount - 1; j++)
                    {
                        m_students[j] = m_students[j + 1];
                    }

                    // limpar última posição
                    m_students[m_studentsCount - 1] = null;
                    m_studentsCount--;
                }
            }
        }

        public void OrderStudentsByName()
        {
            if (m_studentsCount <= 1) return; 

            List<Student> alunosExistentes = m_students
                .Take(m_studentsCount)
                .ToList();

            alunosExistentes = alunosExistentes
                .OrderBy(s => s.Name)
                .ToList();

            for (int i = 0; i < m_studentsCount; i++)
            {
                m_students[i] = alunosExistentes[i];
            }
        }

    }
}
