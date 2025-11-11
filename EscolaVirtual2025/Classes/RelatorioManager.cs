using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EscolaVirtual2025.Classes
{
    public static class RelatorioManager
    {
        public static List<Relatorio> RelatorioList = new List<Relatorio>();

        public static Relatorio GerarRelatorioTurma(Relatorio r, int periodo)
        {
            //Media Turma
            double mediaTurma = r.ListaAlunos.SelectMany(s => s.Grades).Where(n => n.Gradesubject == r.Subject).Average(n => n.p_Grade[periodo]);

            //Melhor Aluno
            int melhorNota = 0;
            Student bestStudent = new Student();
            foreach (Student st in r.ListaAlunos)
            {
                foreach (Grade gr in st.Grades)
                {
                    if (gr.Gradesubject == r.Subject)
                    {
                        if (gr.p_Grade[periodo] > melhorNota)
                        {
                            melhorNota = gr.p_Grade[periodo];
                            bestStudent = st;
                        }
                    }
                }

            }

            //Pior Aluno
            int piorNota = 20;
            Student worstStudent = new Student();
            foreach (Student st in r.ListaAlunos)
            {
                foreach (Grade gr in st.Grades)
                {
                    if (gr.Gradesubject == r.Subject)
                    {
                        if (gr.p_Grade[periodo] < piorNota)
                        {
                            piorNota = gr.p_Grade[periodo];
                            worstStudent = st;
                        }
                    }
                }

            }

            Relatorio rlt = new Relatorio(r.Room, r.TeacherAtual)
            {
                MediaTurma = mediaTurma,
                MelhorAluno = bestStudent,
                PiorAluno = worstStudent
            };

            return rlt;
        }

        public static void ExportarRelatorioJSON(Relatorio r, string caminho)
        {
            try
            {
                File.WriteAllText(caminho, JsonSerializer.Serialize(r));
                MessageBox.Show("A exportação foi bem sucedida", "Feito", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ExportarRelatorioXML(Relatorio r, string caminho)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Relatorio));
                using (TextWriter txtwriter = new StreamWriter(caminho))
                {
                    serializer.Serialize(txtwriter, r);
                }

                MessageBox.Show("A exportação foi bem sucedida", "Feito", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}