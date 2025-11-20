using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EscolaVirtual2025.Data.Import.Dto
{
    public class StudentsRootDto
    {
        [JsonPropertyName("alunos")]
        public List<StudentDto> Alunos { get; set; } = new List<StudentDto>();
    }
}
