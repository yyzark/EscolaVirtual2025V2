using EscolaVirtual2025.Classes;
using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Data;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Linq;

namespace EscolaVirtual2025.Forms.Admin.AdminForms.Teachers.Grades.Items_Forms
{
    public partial class Form_AddGrade : MaterialForm
    {
        private Grade m_grade;
        private int m_per;

        public Form_AddGrade(Grade grade, int per)
        {
            InitializeComponent();

            #region MaterialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red300,
                Primary.Red700,
                Primary.Red100,
                Accent.Orange200,
                TextShade.WHITE
            );
            #endregion

            m_grade = grade;
            m_per = per;

            // Garante que os arrays não são nulos e têm tamanho mínimo de 3
            if (m_grade.P_Grade == null)
                m_grade.P_Grade = new int[3];

            if (m_grade.Comment == null)
                m_grade.Comment = new string[3];

            if (m_grade.P_Grade.Length < 3)
            {
                Array.Resize(ref m_grade.P_Grade, 3);
                Array.Resize(ref m_grade.Comment, 3);
            }

            // Define o valor inicial da nota
            if (m_grade.P_Grade[m_per] >= nudGrade.Minimum && m_grade.P_Grade[m_per] <= nudGrade.Maximum)
                nudGrade.Value = m_grade.P_Grade[m_per];
            else
                nudGrade.Value = nudGrade.Minimum;

            txtComment.Text = m_grade.Comment[m_per] ?? "";
            btnAdd.Enabled = !string.IsNullOrEmpty(txtComment.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int notaAntiga = m_grade.P_Grade[m_per];
            int notaNova = Convert.ToInt32(nudGrade.Value);

            m_grade.P_Grade[m_per] = notaNova;
            m_grade.Comment[m_per] = txtComment.Text;

            m_grade.GradeCount = m_grade.P_Grade.Count(n => n > 0);

            if (notaNova != notaAntiga)
            {
                var teacher = DataManager.currentUser as Teacher;

                HistoricoAvaliacao novaEntrada = new HistoricoAvaliacao
                {
                    AlunoId = m_grade.Student?.NIF,
                    Disciplina = teacher?.AssignedSubject?.Name ?? "N/D",
                    NotaAntiga = notaAntiga,
                    NotaNova = notaNova,
                };

                HistoricoService.AdicionarEGravarAlteracao(novaEntrada);
            }

            this.Close();
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = txtComment.Text.Length > 0;
        }
    }
}
