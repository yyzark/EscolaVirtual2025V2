using System.Collections.Generic;
namespace EscolaVirtual2025.Classes.Data
{
    public class ClassRoomData
    {
        public int Id;
        public char Letter;
        public int YearId;
        public List<string> StudentNIFs = new List<string>();
        public List<int> ClassSubjectIds = new List<int>();
    }
}