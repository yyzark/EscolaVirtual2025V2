using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EscolaVirtual2025.Classes
{
    public static class ExportStudentReportClass
    {
        private static List<Student> students;

        public static List<Student> Students
        {
            set { students = value; }
        }

        public static void ExportStudentReport(Student st, string tipo, string caminho)
        {


            if (tipo == "Json")
            {
                var jsonObj = new JsonObject
                {
                    ["Nome"] = st.Name,
                    ["NIF"] = st.NIF,
                    ["Turma"] = st.ClassRoom != null ? st.ClassRoom.Year.Id + "º " + st.ClassRoom.Letter : "Sem Turma",
                    ["Disciplinas"] = new JsonArray(),
                    ["Notas"] = new JsonArray()
                };

                var disciplinasArray = (JsonArray)jsonObj["Disciplinas"];
                var notasArray = (JsonArray)jsonObj["Notas"];
                var periodo1Notas = new List<int>();
                var periodo2Notas = new List<int>();
                var periodo3Notas = new List<int>();
                var notasTotais = new List<int>();

                foreach (var grade in st.Grades.Items)
                {

                    disciplinasArray.Add(new JsonObject
                    {
                        ["Nome"] = grade.GradeSubject.Name
                    });


                    var notasDisciplina = new JsonObject
                    {
                        ["Disciplina"] = grade.GradeSubject.Name
                    };

                    var periodosArray = new JsonArray();

                    for (int i = 0; i < grade.P_Grade.Length; i++)
                    {
                        var nota = grade.P_Grade[i];

                        if (nota >= 0)
                        {
                            // acumular para média dos períodos
                            if (i == 0) periodo1Notas.Add(nota);
                            if (i == 1) periodo2Notas.Add(nota);
                            if (i == 2) periodo3Notas.Add(nota);

                            // acumular para média final do ano
                            notasTotais.Add(nota);
                        }

                        periodosArray.Add(new JsonObject
                        {
                            ["Periodo"] = (i + 1).ToString(),
                            ["Nota"] = grade.P_Grade[i]
                        });
                    }

                    var notasValidasDisciplina = grade.P_Grade.Where(n => n >= 0).ToList();
                    double mediaDisciplina = notasValidasDisciplina.Count > 0 ? notasValidasDisciplina.Average() : -1;

                    notasDisciplina["MediaFinal"] = mediaDisciplina;
                    notasDisciplina["Periodos"] = periodosArray;

                    notasArray.Add(notasDisciplina);
                }

                double mediaP1 = periodo1Notas.Count > 0 ? periodo1Notas.Average() : -1;
                double mediaP2 = periodo2Notas.Count > 0 ? periodo2Notas.Average() : -1;
                double mediaP3 = periodo3Notas.Count > 0 ? periodo3Notas.Average() : -1;

                double mediaFinalAno = notasTotais.Count > 0 ? notasTotais.Average() : -1;

                jsonObj["MediasGerais"] = new JsonObject
                {
                    ["Periodo1"] = mediaP1,
                    ["Periodo2"] = mediaP2,
                    ["Periodo3"] = mediaP3,
                    ["MediaFinalAno"] = mediaFinalAno
                };

                File.WriteAllText(caminho, jsonObj.ToJsonString(new JsonSerializerOptions { WriteIndented = true }));

            }
            if (tipo == "Xml")
            {
                /*var periodo1Notas = new List<int>();
                var periodo2Notas = new List<int>();
                var periodo3Notas = new List<int>();
                var notasTotais = new List<int>();

                // Criar documento XML
                var xml = new XDocument(
                    new XElement("Aluno",
                        new XElement("Nome", st.Name),
                        new XElement("NIF", st.NIF),
                        new XElement("Turma",
                            st.ClassRoom != null
                                ? st.ClassRoom.Year.Id + "º " + st.ClassRoom.Letter
                                : "Sem Turma"
                        ),
                        new XElement("Disciplinas",
                            st.Grades.Items.Select(grade =>
                                new XElement("Disciplina",
                                    new XElement("Nome", grade.GradeSubject.Name)
                                )
                            )
                        ),
                        new XElement("Notas",
                            st.Grades.Items.Select(grade =>
                            {
                                var notasValidas = grade.P_Grade.Where(n => n >= 0).ToList();
                                double mediaDisciplina =
                                    notasValidas.Count > 0 ? notasValidas.Average() : -1;

                                // acumular para média geral
                                for (int i = 0; i < 3; i++)
                                {
                                    if (grade.P_Grade[i] >= 0)
                                    {
                                        if (i == 0) periodo1Notas.Add(grade.P_Grade[i]);
                                        if (i == 1) periodo2Notas.Add(grade.P_Grade[i]);
                                        if (i == 2) periodo3Notas.Add(grade.P_Grade[i]);

                                        notasTotais.Add(grade.P_Grade[i]);
                                    }
                                }
                                new XElement("Disciplina",
                                                    new XAttribute("Nome", grade.GradeSubject.Name),
                                                    new XElement("Periodos",
                                                        Enumerable.Range(0, grade.P_Grade.Length).Select(i =>
                                                            new XElement("Periodo",
                                                                new XAttribute("Numero", (i + 1).ToString()),
                                                                new XAttribute("Nota", grade.P_Grade[i])
                                                            )
                                                        )
                                                    ),
                                                    new XElement("MediaFinal", mediaDisciplina)
                                                );
                            })
                        )
                    )
                );

                xml.Save(caminho);
            }*/

                
                var periodo1Notas = new List<int>();
                var periodo2Notas = new List<int>();
                var periodo3Notas = new List<int>();
                var notasTotais = new List<int>();


                //Xml principal
                var xml = new XDocument(
                    new XElement("Aluno",
                        new XElement("Nome", st.Name),
                        new XElement("NIF", st.NIF),
                        new XElement("Turma",
                            st.ClassRoom != null
                                ? st.ClassRoom.Year.Id + "º " + st.ClassRoom.Letter
                                : "Sem Turma"
                        ),

                        //colocar disciplinas
                        new XElement("Disciplinas",
                            st.Grades.Items.Select(grade =>
                                new XElement("Disciplina",
                                    new XElement("Nome", grade.GradeSubject.Name)
                                )
                            )
                        ),

                        //notas de cada disciplinas e médias
                        new XElement("Notas",
                            st.Grades.Items.Select(grade =>
                            {
                                // média da disciplina
                                var notasValidas = grade.P_Grade.Where(n => n >= 0).ToList();
                                double mediaDisciplina =
                                    notasValidas.Count > 0 ? notasValidas.Average() : -1;

                                // acumular para média geral
                                for (int i = 0; i < 3; i++)
                                {
                                    if (grade.P_Grade[i] >= 0)
                                    {
                                        if (i == 0) periodo1Notas.Add(grade.P_Grade[i]);
                                        if (i == 1) periodo2Notas.Add(grade.P_Grade[i]);
                                        if (i == 2) periodo3Notas.Add(grade.P_Grade[i]);

                                        notasTotais.Add(grade.P_Grade[i]);
                                    }
                                }

                                return new XElement("Disciplina",
                                    new XAttribute("Nome", grade.GradeSubject.Name),

                                    // períodos individuais
                                    new XElement("Periodos",
                                        Enumerable.Range(0, grade.P_Grade.Length).Select(i =>
                                            new XElement("Periodo",
                                                new XAttribute("Numero", i + 1),
                                                new XAttribute("Nota", grade.P_Grade[i])
                                            )
                                        )
                                    ),

                                    // média final dessa disciplina
                                    new XElement("MediaFinal", mediaDisciplina)
                                );
                            })
                        )
                    )
                );


                //calcular médias gerais
                double mediaP1 = periodo1Notas.Count > 0 ? periodo1Notas.Average() : -1;
                double mediaP2 = periodo2Notas.Count > 0 ? periodo2Notas.Average() : -1;
                double mediaP3 = periodo3Notas.Count > 0 ? periodo3Notas.Average() : -1;
                double mediaFinalAno = notasTotais.Count > 0 ? notasTotais.Average() : -1;


                //adicionar médias gerais ao xml
                if (xml.Root != null)
                {
                    xml.Root.Add(
                    new XElement("MediasGerais",
                        new XElement("Periodo1", mediaP1),
                        new XElement("Periodo2", mediaP2),
                        new XElement("Periodo3", mediaP3),
                        new XElement("MediaFinalAno", mediaFinalAno)
                    )
                );
                }


                //guardar o ficheiro
                xml.Save(caminho);

            }
        }

    }
}

