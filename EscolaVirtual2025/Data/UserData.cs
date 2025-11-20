using System.Collections.Generic;
namespace EscolaVirtual2025.Classes.Data
{
    public class UserData
    {
        public string Username;
        public string Password;
        public string Name;
        public UserType UserType;
        public string NIF;
        public int ClassRoomId;
        public int SchoolCardId;
        public List<int> AssignedClassRoomIds = new List<int>();
        public int AssignedSubjectId;
        public List<int> GradeIds = new List<int>();
    }
}