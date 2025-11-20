using EscolaVirtual2025.Classes.InterFace;
using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Data;

namespace EscolaVirtual2025.Classes.Academic
{
    public class Subject
    {
        private string m_name;
        private string m_abreviation;
        private int m_id;

        public string Name
        {
            get => m_name;
            set => m_name = value;
        }

        public string Abreviation
        {
            get => m_abreviation;
            set => m_abreviation = value;
        }

        public int Id
        {
            get => m_id;
            set => m_id = value;
        }

        public EntityCollection<Year, int> Years = new EntityCollection<Year, int>(DataManager.Years, yr => yr.Id);

        public EntityCollection<Teacher, string> Teachers = new EntityCollection<Teacher, string>(DataManager.Teachers, tc => tc.NIF);

        public Subject() { }

        public Subject(string name, string abrv, int id)
        {
            m_name = name;
            m_abreviation = abrv;
            m_id = id;
        }
    }
}