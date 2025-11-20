using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using System.Linq;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace EscolaVirtual2025.Classes
{
    public class Relatorio
    {
        private int year;
        private char room;
        private string subject;
        private string[] students;
        private string teacher;
        private string piorAluno;
        private string melhorAluno;
        private double media;
        private int period;

        [JsonIgnore]
        [XmlIgnore]
        private string nif;

        public int Year { get { return year; } set { year = value; } }
        public char Room { get { return room; } set { room = value; } }
        public string Subject { get { return subject; } set { subject = value; } }
        public string TeacherAtual { get { return teacher; } set { teacher = value; } }
        public string[] ListaAlunos { get { return students; } set { students = value; } }

        public Relatorio(ClassRoom room, Teacher teacher, int period = 0)
        {
            Year = room.Year.Id;
            Room = room.Letter;
            TeacherAtual = teacher.Name;
            NIF = teacher.NIF.ToString();
            ListaAlunos = room.Students.Where(s => s != null).Select(s => s.Name).ToArray();
            Subject = teacher.AssignedSubject.Name;
            this.period = period;
        }

        public Relatorio()
        {
        }

        public double MediaTurma
        {
            set { media = value; }
            get { return media; }
        }

        public string MelhorAluno
        {
            set { melhorAluno = value; }
            get { return melhorAluno; }
        }

        public string PiorAluno
        {
            set { piorAluno = value; }
            get { return piorAluno; }
        }

        public int Period { get => period; set => period = value; }

        [JsonIgnore]
        [XmlIgnore]
        public string NIF { get => nif; set => nif = value; }
    }
}

