using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace EscolaVirtual2025.Classes
{
    public class Relatorio
    {
        private ClassRoom room;
        private Subject subject;
        private Student[] students;
        private Teacher teacher;
        private Student piorAluno;
        private Student melhorAluno;
        private double media;

        public ClassRoom Room { get { return room; } set { room = value; } }
        public Subject Subject { get { return subject; } set { subject = value; } }
        public Teacher TeacherAtual { get { return teacher; } set { teacher = value; } }
        public Student[] ListaAlunos { get { return students; } set { students = value; } }

        public Relatorio(ClassRoom room, Teacher teacher)
        {
            Room = room;
            TeacherAtual = teacher;
            ListaAlunos = room.Students;
            Subject = teacher.AssignedSubject;
        }

        public double MediaTurma
        {
            set { media = value; }
            get { return media; }
        }

        public Student MelhorAluno
        {
            set { melhorAluno = value; }
            get { return melhorAluno; }
        }

        public Student PiorAluno
        {
            set { piorAluno = value; }
            get { return piorAluno; }
        }
    }
}

        