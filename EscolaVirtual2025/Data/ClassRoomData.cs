namespace EscolaVirtual2025.Classes.Data
{
    public class ClassRoomData
    {
        public int Id;
        public char Letter;
        public int YearId;
        public List<int> StudentNIFs = new List<int>();
        public List<int> ClassSubjectIds = new List<int>();
    }
}