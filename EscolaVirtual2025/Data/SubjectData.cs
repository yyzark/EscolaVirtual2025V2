using System.Collections.Generic;
namespace EscolaVirtual2025.Classes.Data
{
    public class SubjectData
    {
        public int Id;
        public string Name;
        public string Abreviation;
        public List<int> YearIds = new List<int>();
        public List<string> TeacherNIFs = new List<string>();
    }
}