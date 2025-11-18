using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2025.Classes
{
    public class HistoricoAvaliacao
    {

        
        public int AlunoId { get; set; }

        
        public int ProfessorId { get; set; }


        public string Disciplina { get; set; } = string.Empty;


        public int NotaAntiga { get; set; }


        public int NotaNova { get; set; }


        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}

