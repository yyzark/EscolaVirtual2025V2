using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Data;
using System.Linq;
using System.Runtime.Serialization;

namespace EscolaVirtual2025.Classes.Academic
{
    [DataContract]
    public class ClassSubject : Subject
    {
        private string m_teacherNif;

        public Teacher Teacher
        {
            get { return DataManager.Teachers.FirstOrDefault(tch => tch.NIF == m_teacherNif); }
            set { m_teacherNif = value.NIF; }
        }
        public ClassSubject()
        {
        }

        public ClassSubject(string teacherNif, Subject subject) : base(subject.Name, subject.Abreviation, subject.Id)
        {
            this.m_teacherNif = teacherNif;
        }

        public ClassSubject(string name, string abreviation, int id, string teacherNif) : base(name, abreviation, id)
        {
            m_teacherNif = teacherNif;
        }
    }
}
