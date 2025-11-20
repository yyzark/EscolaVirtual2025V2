namespace EscolaVirtual2025.Classes.Data
{
    public class SubjectData
    {
        public int Id;
        public string Name;
        public string Abreviation;
        public List<int> YearIds = new List<int>();
        public List<int> TeacherNIFs = new List<int>();
    }
}