using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace EscolaVirtual2025.Classes
{
    public static class RelatorioManager
    {
        public static List<Relatorio> RelatorioList = new List<Relatorio>();

        public static Relatorio GerarRelatorioTurma(Relatorio r)
        {
            //Media Turma
            double mediaTurma = Program.ClassRooms.FirstOrDefault(rl => rl.Year.AnoId == r.Year && rl.Id == r.Room).Students
                .Where(s => s != null)
                .SelectMany(s => s.Grades)
                .Where(n => n.Gradesubject.Name == r.Subject)
                .Average(n => n.p_Grade[r.Period]);

            //Melhor Aluno
            int melhorNota = 0;
            string bestStudent = "";
            foreach(Student st in Program.ClassRooms.FirstOrDefault(rl => rl.Year.AnoId == r.Year && rl.Id == r.Room).Students)
            {
                if (st != null)
                {
                    foreach (Grade gr in st.Grades)
                    {
                        if (gr.Gradesubject.Name == r.Subject)
                        {
                            if (gr.p_Grade[r.Period] > melhorNota)
                            {
                                melhorNota = gr.p_Grade[r.Period];
                                bestStudent = st.Name;
                            }
                        }
                    }
                }

            }

            //Pior Aluno
            int piorNota = 20;
            string worstStudent = "";
            foreach (Student st in Program.ClassRooms.FirstOrDefault(rl => rl.Year.AnoId == r.Year && rl.Id == r.Room).Students)
            {
                if (st != null)
                {
                    foreach (Grade gr in st.Grades)
                    {
                        if (gr.Gradesubject.Name == r.Subject)
                        {
                            if (gr.p_Grade[r.Period] < piorNota)
                            {
                                piorNota = gr.p_Grade[r.Period];
                                worstStudent = st.Name;
                            }
                        }
                    }
                }

            }

            Relatorio rlt = new Relatorio(Program.ClassRooms.FirstOrDefault(rl => rl.Year.AnoId == r.Year && rl.Id == r.Room), Program.Teachers.FirstOrDefault(t => t.NIF == r.NIF), r.Period)
            {
                MediaTurma = mediaTurma,
                MelhorAluno = bestStudent,
                PiorAluno = worstStudent
            };
            RelatorioList.Add(rlt);
            return rlt;
        }

        public static void ExportarRelatorioJSON(Relatorio r, string caminho)
        {
            try
            {

                File.WriteAllText(caminho, JsonSerializer.Serialize(
                    r,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true,
                        ReferenceHandler = ReferenceHandler.IgnoreCycles
                    }));
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