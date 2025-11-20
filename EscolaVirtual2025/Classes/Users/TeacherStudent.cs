namespace EscolaVirtual2025.Classes
{
    public class TeacherStudent : User
    {

        private string m_NIF;
        public string NIF
        {
            set { m_NIF = value; }
            get { return m_NIF; }
        }

        public TeacherStudent(string username, string password, string name, UserType userType, string nif) :
        base(username, password, name, userType)
        {
            m_NIF = nif;
        }

        public TeacherStudent(UserType usertype) : base(usertype)
        { }
    }
}
