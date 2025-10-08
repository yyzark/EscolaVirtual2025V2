using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaVirtual2025.Classes.Users;

namespace EscolaVirtual2025.Classes.Academic
{
    public class ClassSubject
    {
        private Teacher m_teacher;
        private Subject m_subject;
        public Teacher AssignedTeacher
        {
            get { return m_teacher; }
            set { m_teacher = value; }
        }

        public Subject Subject
        {
            get { return m_subject; }
            set { m_subject = value; }
        }

        public ClassSubject(Teacher teacher, Subject subject)
        {
            m_teacher = teacher;
            m_subject = subject;
        }
    }
}
