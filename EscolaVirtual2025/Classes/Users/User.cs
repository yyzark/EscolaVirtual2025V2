using EscolaVirtual2025.Classes.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2025.Classes
{
    public enum UserType
    {
        Admin,
        Teacher,
        Student
    }
    public class User
    {
        private string m_username;
        private string m_password;
        private string m_name;
        private readonly UserType m_userType;
        public string Username
        {
            get { return m_username; }
            set { m_username = value; }
        }

        public string Password
        {
            get { return m_password; }
            set { m_password = value; }
        }

        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        public UserType UserType
        {
            get { return m_userType; }
        }

        public User(
        string username, 
        string password, 
        string name, 
        UserType userType)
        {
            m_username = username;
            m_password = password;
            m_name = name;
            m_userType = userType;
        }

        private List<Notification> m_notifications = new List<Notification>();
        public List<Notification> Notifications
        {
            get { return m_notifications; }
            set { m_notifications = value; }
        }
    }
}
