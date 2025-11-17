using EscolaVirtual2025.Classes;
using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EscolaVirtual2025.Forms.TeacherForms.RelatorioTeacher
{
    public partial class Form_Relatorio : MaterialForm
    {
        //david campos sem nivel de acesso é crime

        private ClassRoom classRoom;
        private Teacher tchr;
        public Form_Relatorio(ClassRoom classRoom, Teacher tchr)
        {
            InitializeComponent();
            #region MaterialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Red300,    // cor principal clara
            Primary.Red700,    // cor principal escura
            Primary.Red100,    // cor de fundo ou destaque
            Accent.Orange200,  // acento laranja suave
            TextShade.WHITE    // cor do texto;
            );
            #endregion

            this.classRoom = classRoom;
            this.tchr = tchr;
        }

        private void Form_Relatorio_Load(object sender, EventArgs e)
        {
            txtTurma.Text = "Turma: " + classRoom.Year.AnoId + "º " + classRoom.Id;
            lblDisc.Text = "Disciplina: " + tchr.AssignedSubject.Name;

            for (int i = 0; i < 3; i++)
                LoadInfo(i);
        }

        private void LoadInfo(int perNum)
        {
            Relatorio per = RelatorioManager.RelatorioList.FirstOrDefault(r => r.NIF == tchr.NIF && r.Year == classRoom.Year.AnoId && r.Room == classRoom.Id && r.Period == perNum);
            //Se não for nulo
            if (per != null && perNum == 0)
            {
                lblBS1.Text = "Melhor aluno:" + per.MelhorAluno;
                lblMedia1.Text = "Média:" + per.MediaTurma;
                lblWS1.Text = "Pior aluno:" + per.PiorAluno;
                btnRelatório1.Text = "Exportar";
            }
            else if (per != null && perNum == 1)
            {
                lblBest2.Text = "Melhor aluno:" + per.MelhorAluno;
                lblMed2.Text = "Média:" + per.MediaTurma;
                lblWorst2.Text = "Pior aluno:" + per.PiorAluno;
                btnRelatorio2.Text = "Exportar";
            }
            else if (per != null && perNum == 2)
            {
                lblBest3.Text = "Melhor aluno:" + per.MelhorAluno;
                lblMed3.Text = "Média:" + per.MediaTurma;
                lblWorst3.Text = "Pior aluno:" + per.PiorAluno;
                btnRelatorio3.Text = "Exportar";
            }

            //Se for nulo
            if (per == null && perNum == 0)
            {
                lblBS1.Text = "Melhor aluno:" ;
                lblMedia1.Text = "Média:";
                lblWS1.Text = "Pior aluno:";
                btnRelatório1.Text = "Relatório";
            }
            else if (per == null && perNum == 1)
            {
                lblBest2.Text = "Melhor aluno:";
                lblMed2.Text = "Média:";
                lblWorst2.Text = "Pior aluno:";
                btnRelatorio2.Text = "Relatório";
            }
            else if (per == null && perNum == 2)
            {
                lblBest3.Text = "Melhor aluno:";
                lblMed3.Text = "Média:";
                lblWorst3.Text = "Pior aluno:";
                btnRelatorio3.Text = "Relatório";
            }
        }

        private void ExportReport(Button btn, int per)
        {
            if (btn.Text == "Exportar")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Title = "Exportar relatório";

                saveFileDialog.FileName = "Relatório_" + tchr.AssignedSubject.Name + "_" + classRoom.Year.AnoId + "º" + classRoom.Id + "_Per" + per + "_" + DateTime.Now.Date.ToString("dd_MM_yyyy");

                saveFileDialog.Filter = "JSON files (*.json)|*.json|XML files (*.xml)|*.xml";

                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string extention = Path.GetExtension(filePath).ToLower();


                    Relatorio rel = RelatorioManager.RelatorioList.FirstOrDefault(r => r.Year == classRoom.Year.AnoId && r.Room == classRoom.Id && r.NIF == tchr.NIF && r.Period == per);

                    if (extention == ".json")
                    {
                        RelatorioManager.ExportarRelatorioJSON(rel, filePath);
                    }
                    else if (extention == ".xml")
                    {
                        RelatorioManager.ExportarRelatorioXML(rel, filePath);
                    }
                    else
                    {
                        MaterialMessageBox.Show("Erro ao exportar o ficheiro!", "Erro");
                    }
                }
            }
            else
            {
                RelatorioManager.GerarRelatorioTurma(new Relatorio(classRoom, tchr, per));
                LoadInfo(per);
            }
        }
        private void btnRelatório1_Click(object sender, EventArgs e)
        {
            ExportReport(sender as Button, 0);
        }
        private void btnRelatorio2_Click(object sender, EventArgs e)
        {
            ExportReport(sender as Button, 1);
        }

        private void btnRelatorio3_Click(object sender, EventArgs e)
        {
            ExportReport(sender as Button, 2);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                Relatorio per = RelatorioManager.RelatorioList.FirstOrDefault(r => r.NIF == tchr.NIF && r.Year == classRoom.Year.AnoId && r.Room == classRoom.Id && r.Period == i);
                if(per != null)
                    RelatorioManager.RelatorioList.Remove(per);
            }

            for (int i = 0; i < 3; i++)
                LoadInfo(i);
        }
    }
}
