using EscolaVirtual2025.Classes;
using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Data;
using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace EscolaVirtual2025.Forms.Admin.AdminForms.Teachers.Grades.Items_Forms
{
    public partial class Form_EditGrade : MaterialForm
    {
        private Grade m_grade;
        private int m_per;
        public Form_EditGrade(Grade grade, int per)
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

            m_grade = grade;
            m_per = per;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int notaAntiga = m_grade.P_Grade[m_per];
            int notaNova = Convert.ToInt32(nudGrade.Value);

            m_grade.P_Grade[m_per] = notaNova;
            m_grade.Comment[m_per] = txtComment.Text;

            //  REGISTO DO HISTÓRICO 
            if (notaAntiga != notaNova)
            {
                HistoricoAvaliacao novaEntrada = new HistoricoAvaliacao
                {
                    AlunoId = m_grade.Student.NIF,
                    ProfessorId = (DataManager.currentUser as Teacher).NIF,
                    Disciplina = m_grade.GradeSubject.Name,
                    NotaAntiga = notaAntiga,
                    NotaNova = notaNova,
                };

                HistoricoService.AdicionarEGravarAlteracao(novaEntrada);
            }

            //DataManager.Save();
            this.Close();
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            if (txtComment.Text.Length > 0)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void Form_EditGrade_Load(object sender, EventArgs e)
        {
            txtComment.Text = m_grade.Comment[m_per];
            nudGrade.Value = m_grade.P_Grade[m_per];
        }
    }
}

