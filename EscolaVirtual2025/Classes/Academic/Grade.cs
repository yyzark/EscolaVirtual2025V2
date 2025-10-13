using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2025.Classes.Academic
{
    public class Grade
    {
        private int[] m_grade;
        private string[] m_comment;
        private Subject m_subject;
        private int m_gradeCount;
        public int[] p_Grade
        { 
            get { return m_grade; }
            set { m_grade = value; } 
        }
        public string[] Comment 
        { 
            get { return m_comment; } 
            set { m_comment = value; } 
        }

        public int GradeCount
        {
            get { return m_gradeCount; }
            set { m_gradeCount = value; }
        }

        public Subject Gradesubject 
        { 
            get { return m_subject; }
            set { m_subject = value; }
        } 

        public Grade(Subject gradeSubject)
        {
            m_subject = gradeSubject;
            m_gradeCount = 0;
            m_grade = new int[3] { -1, -1, -1 };
            m_comment = new string[3];
        }

        public void OrderGradesByName()
        {
            if (m_grade != null && m_grade.Length > 1)
            {
                // Ordena o array pelo nome da disciplina e sobrescreve m_grades
                m_grade = m_grade.OrderBy(g => m_subject).ToArray();
            }
        }
    }
}
