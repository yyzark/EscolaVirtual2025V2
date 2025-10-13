using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Forms.Admin.AdminForms.Teachers.Grades_Forms;
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

namespace EscolaVirtual2025.Forms.TeacherForms
{
    public partial class Form_Grades :  MaterialForm
    {
        private Student m_actualStudent;
        private Subject m_actualSubject;
        public Form_Grades(Student actualStudent, Subject subject)
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

            m_actualStudent = actualStudent;
            m_actualSubject = subject;

            UpdateGrades();
        }

        private void Form_Grades_Load(object sender, EventArgs e)
        {
            txtStudentName.Text = "Aluno: " + m_actualStudent.Name;
        }

        private void UpdateGrades()
        {
            var grade = m_actualStudent.Grades.FirstOrDefault(grd => grd.Gradesubject == m_actualSubject);

            // Controles para notas 2 e 3
            MaterialLabel[] lblNotas = { lblNota2, lblNota3 };
            MaterialButton[] btnNotas = { btnNota2, btnNota3 };
            MaterialMultiLineTextBox[] txtComents = { txtComent2, txtComent3 };

            // Inicializa todas as notas como invisíveis
            for (int i = 0; i < lblNotas.Length; i++)
            {
                lblNotas[i].Visible = false;
                lblNotas[i].Text = "Nota: N/D";
                btnNotas[i].Visible = false;
                btnNotas[i].Text = "Lançar nota";
                txtComents[i].Visible = false;
                txtComents[i].Text = "Comentário";
            }

            // Nota 1 sempre visível
            lblNota1.Visible = true;
            txtComent1.Visible = true;
            btnNota1.Visible = true;

            if (grade == null || grade.GradeCount == 0)
            {
                lblNota1.Text = "Nota: N/D";
                txtComent1.Text = "Comentário";
                btnNota1.Text = "Lançar nota";
            }
            else
            {
                // Preenche notas existentes
                lblNota1.Text = "Nota: " + grade.p_Grade[0];
                txtComent1.Text = grade.Comment[0];
                btnNota1.Text = "Editar";

                if (grade.GradeCount >= 2)
                {
                    lblNotas[0].Visible = true;
                    lblNotas[0].Text = "Nota: " + grade.p_Grade[1];
                    txtComents[0].Visible = true;
                    txtComents[0].Text = grade.Comment[1];
                    btnNotas[0].Visible = true;
                    btnNotas[0].Text = "Editar";
                }
                else
                {
                    // Próxima nota disponível
                    lblNotas[0].Visible = true;
                    lblNotas[0].Text = "Nota: N/D";
                    txtComents[0].Visible = true;
                    txtComents[0].Text = "Comentário";
                    btnNotas[0].Visible = true;
                    btnNotas[0].Text = "Lançar nota";
                }

                if (grade.GradeCount >= 3)
                {
                    lblNotas[1].Visible = true;
                    lblNotas[1].Text = "Nota: " + grade.p_Grade[2];
                    txtComents[1].Visible = true;
                    txtComents[1].Text = grade.Comment[2];
                    btnNotas[1].Visible = true;
                    btnNotas[1].Text = "Editar";
                }
                else if (grade.GradeCount == 2)
                {
                    // Próxima nota disponível
                    lblNotas[1].Visible = true;
                    lblNotas[1].Text = "Nota: N/D";
                    txtComents[1].Visible = true;
                    txtComents[1].Text = "Comentário";
                    btnNotas[1].Visible = true;
                    btnNotas[1].Text = "Lançar nota";
                }
            }
        }


        private void btnNota1_Click(object sender, EventArgs e)
        {
            if(btnNota1.Text.ToLower() == "lançar nota")
            {
                var grade = m_actualStudent.Grades.FirstOrDefault(grd => grd.Gradesubject == m_actualSubject);
                if (grade != null)
                {
                    Form_AddGrade newForm = new Form_AddGrade(grade, 0);
                    newForm.ShowDialog();
                    UpdateGrades();
                }
                else
                {
                    Grade newGrade = new Grade(m_actualSubject);
                    m_actualStudent.Grades.Add(newGrade);
                    Form_AddGrade newForm = new Form_AddGrade(newGrade, 0);
                    newForm.ShowDialog();
                    UpdateGrades();
                }
            }
            else
            {
                Form_EditGrade newForm = new Form_EditGrade(m_actualStudent.Grades.FirstOrDefault(grd => grd.Gradesubject == m_actualSubject), 0);
                newForm.ShowDialog();
                UpdateGrades();
            }
        }

        private void btnNota2_Click(object sender, EventArgs e)
        {
            if (btnNota2.Text.ToLower() == "lançar nota")
            {
                var grade = m_actualStudent.Grades.FirstOrDefault(grd => grd.Gradesubject == m_actualSubject);
                if (grade != null)
                {
                    Form_AddGrade newForm = new Form_AddGrade(grade, 1);
                    newForm.ShowDialog();
                    UpdateGrades();
                }
                else
                {
                    Grade newGrade = new Grade(m_actualSubject);
                    m_actualStudent.Grades.Add(newGrade);
                    Form_AddGrade newForm = new Form_AddGrade(newGrade, 1);
                    newForm.ShowDialog();
                    UpdateGrades();
                }
            }
            else
            {
                Form_EditGrade newForm = new Form_EditGrade(m_actualStudent.Grades.FirstOrDefault(grd => grd.Gradesubject == m_actualSubject), 1);
                newForm.ShowDialog();
                UpdateGrades();
            }
        }

        private void btnNota3_Click(object sender, EventArgs e)
        {
            if (btnNota3.Text.ToLower() == "lançar nota")
            {
                var grade = m_actualStudent.Grades.FirstOrDefault(grd => grd.Gradesubject == m_actualSubject);
                if (grade != null)
                {
                    Form_AddGrade newForm = new Form_AddGrade(grade, 2);
                    newForm.ShowDialog();
                    UpdateGrades();
                }
                else
                {
                    Grade newGrade = new Grade(m_actualSubject);
                    m_actualStudent.Grades.Add(newGrade);
                    Form_AddGrade newForm = new Form_AddGrade(newGrade, 2);
                    newForm.ShowDialog();
                    UpdateGrades();
                }
            }
            else
            {
                Form_EditGrade newForm = new Form_EditGrade(m_actualStudent.Grades.FirstOrDefault(grd => grd.Gradesubject == m_actualSubject), 2);
                newForm.ShowDialog();
                UpdateGrades();
            }
        }
    }
}
