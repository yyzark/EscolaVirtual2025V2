namespace EscolaVirtual2025.Classes.Data
{
    public class ChatData
    {
        public int TeacherNIF;
        public int StudentNIF;
        public bool HasAdmin;
        public List<(string Sender, string Text)> Messages = new List<(string Sender, string Text)>();
    }
}