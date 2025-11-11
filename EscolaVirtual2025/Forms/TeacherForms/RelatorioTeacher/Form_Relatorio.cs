using EscolaVirtual2025.Classes;
using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Forms.TeacherForms.TeacherAccount;
using EscolaVirtual2025.Forms.TeacherForms.TeacherChat;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual2025.Forms.TeacherForms.RelatorioTeacher
{
    public partial class Form_Relatorio : MaterialForm
    {
        Relatorio relatorio;
        public Form_Relatorio(Relatorio r)
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
            relatorio = r;
        }

        private void Form_Relatorio_Load(object sender, EventArgs e)
        {
            txtTurma.Text = "Turma: " + relatorio.Room.Year.AnoId + "º " + relatorio.Room.Id;
            lblDisc.Text = "Disciplina: " + relatorio.Subject.Name;
        }

        private void btnRelatório1_Click(object sender, EventArgs e)
        {
            lblMedia1.Text = "Média: " + RelatorioManager.GerarRelatorioTurma(relatorio, 0).MediaTurma;
            lblBS1.Text = "Melhor Aluno: " + RelatorioManager.GerarRelatorioTurma(relatorio, 0).MelhorAluno.Name;
            lblWS1.Text = "Pior Aluno: " + RelatorioManager.GerarRelatorioTurma(relatorio, 0).PiorAluno.Name;
        }
    }
}
