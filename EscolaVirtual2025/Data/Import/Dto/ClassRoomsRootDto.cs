using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EscolaVirtual2025.Data.Import.Dto
{
    public class ClassRoomsRootDto
    {
        [JsonPropertyName("turmas")]
        public List<ClassRoomDto> Turmas { get; set; } = new List<ClassRoomDto>();
    }
}
