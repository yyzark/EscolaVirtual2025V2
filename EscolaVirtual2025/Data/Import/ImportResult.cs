using System.Collections.Generic;

namespace EscolaVirtual2025.Data.Import
{
    public class ImportResult
    {
        public int ImportedCount { get; set; } = 0;
        public List<string> Errors { get; set; } = new List<string>();
        public bool Success => Errors.Count == 0;
    }
}
