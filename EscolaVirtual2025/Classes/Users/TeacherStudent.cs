namespace EscolaVirtual2025.Classes
{
    public class TeacherStudent : User
    {

        private int m_NIF;
        public int NIF
        {
            set { m_NIF = value; }
            get { return m_NIF; }
        }

        public TeacherStudent(string username, string password, string name, UserType userType, int nif) :
        base(username, password, name, userType)
        {
            m_NIF = nif;
        }

        public TeacherStudent() : base()
        { }
    }
}
