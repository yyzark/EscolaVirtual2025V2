namespace EscolaVirtual2025.Data.Import.Dto
{
    public class StudentDto
    {
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string nif { get; set; }
        public int? classId { get; set; }
        public int? schoolCardId { get; set; }
    }
}
