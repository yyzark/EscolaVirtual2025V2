using System.Collections.Generic;

namespace EscolaVirtual2025.Data.Import.Dto
{
    public class ClassRoomDto
    {
        public int? id { get; set; }
        public string letter { get; set; }
        public int? yearId { get; set; }

        public List<StudentDto> alunos { get; set; } = new List<StudentDto>();
    }
}
