using EscolaVirtual2025.Classes.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EscolaVirtual2025.Classes.Academic
{
    
    [DataContract]
    public class Subject
    {
        private string m_name;
        private string m_abreviation;
        private int m_Id;
        private List<Teacher> m_teachers;
        private List<Year> m_years;

        
        [DataMember]
        public List<Year> Years
        {
            get { return m_years; }
            set { m_years = value; }
        }

        [DataMember]
        public string Abreviation
        {
            get { return m_abreviation; }
            set { m_abreviation = value; }
        }

        [DataMember]
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        [DataMember]
        public int Id
        {
            get { return m_Id; }
            set { m_Id = value; }
        }

        public Subject() { }

        public Subject(string name, string abreviation, int id)
        {
            m_name = name;
            m_Id = id;
            m_abreviation = abreviation;
            m_teachers = new List<Teacher>();
            m_years = new List<Year>();
        }

        [DataMember]
        public List<Teacher> Teachers
        {
            get { return m_teachers; }
            set { m_teachers = value; }
        }
    }
}