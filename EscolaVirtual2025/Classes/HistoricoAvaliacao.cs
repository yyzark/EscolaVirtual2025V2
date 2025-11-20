using System;

namespace EscolaVirtual2025.Classes
{
    public class HistoricoAvaliacao
    {


        public string AlunoId { get; set; }


        public string ProfessorId { get; set; }


        public string Disciplina { get; set; } = string.Empty;


        public int NotaAntiga { get; set; }


        public int NotaNova { get; set; }


        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}

