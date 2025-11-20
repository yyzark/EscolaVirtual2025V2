using System.Collections.Generic;
namespace EscolaVirtual2025.Classes.Data
{
    public class ChatData
    {
        public string TeacherNIF;
        public string StudentNIF;
        public bool HasAdmin;
        public List<(string Sender, string Text)> Messages = new List<(string Sender, string Text)>();
    }
}