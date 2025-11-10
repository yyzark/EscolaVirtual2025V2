using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2025.Classes
{
    public class Relatorio
    {
        private ClassRoom room;
        private Subject subject;
        private Student[] students;
        private Teacher teacher;
        private int periodo;

        public ClassRoom Room { get {return room;  } set {room = value;} }
        public Subject Subject { get { return subject; } set { subject = value; } }
        public Teacher TeacherAtual { get { return teacher; } set { teacher = value; } }
        public int Periodo { get { return periodo; } set { periodo = value; } }
        public Student[] ListaAlunos { get { return students; } set { students = value; } }

        public Relatorio(ClassRoom room, Teacher teacher, int per)
        {
            Room = room;
            TeacherAtual = teacher;
            ListaAlunos = room.Students;
            Periodo = per;
            Subject = teacher.AssignedSubject;
        }

        public double MediaTurma
        {
            get
            {
                int soma = 0, cnt=0;
                double media = 0;
                foreach (Student st in students)
                {
                    foreach (Grade gr in st.Grades)
                    {
                        if (gr.Gradesubject == Subject)
                        {
                            soma += gr.p_Grade[periodo];
                            cnt++;
                        }
                    }

                }
                media = (double)soma / cnt;
                return media;
            }
        }
        
        public Student MelhorAluno
        {
            get
            {
                int melhorAluno = 0;
                Student bestStudent = new Student();
                foreach (Student st in students)
                {
                    foreach (Grade gr in st.Grades)
                    {
                        if (gr.Gradesubject == Subject)
                        {
                            if (gr.p_Grade[periodo] > melhorAluno)
                            {
                                melhorAluno = gr.p_Grade[periodo];
                                bestStudent = st;
                            }
                        }
                    }

                }
                return bestStudent;
            }
        }

        public Student PiorAluno
        {
            get
            {
                int piorAluno = 20;
                Student worstStudent = new Student();
                foreach (Student st in students)
                {
                    foreach (Grade gr in st.Grades)
                    {
                        if (gr.Gradesubject == Subject)
                        {
                            if (gr.p_Grade[periodo] < piorAluno)
                            {
                                piorAluno = gr.p_Grade[periodo];
                                worstStudent = st;
                            }
                        }
                    }

                }
                return worstStudent;
            }
        }

    }
}
