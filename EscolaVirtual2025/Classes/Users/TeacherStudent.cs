using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2025.Classes
{
    public abstract class TeacherStudent : User
    {

        private string m_NIF;
        public string NIF
        {
            set { m_NIF = value; }
            get { return m_NIF; }
        }

        public TeacherStudent(string username, string password, string name, UserType userType,string nif) : 
        base(username, password, name, userType)
        {
            m_NIF = nif;
        }

        public TeacherStudent() : base()
        { }
    }
}
