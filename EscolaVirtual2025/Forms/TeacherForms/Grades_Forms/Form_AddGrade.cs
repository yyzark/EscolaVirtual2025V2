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
using EscolaVirtual2025.Classes.Academic;

namespace EscolaVirtual2025.Forms.Admin.AdminForms.Teachers.Grades_Forms
{
    public partial class Form_AddGrade : MaterialForm
    {
        private Grade m_grade;
        private int m_per;
        public Grade p_grade
        {
            get { return m_grade; }
            set { m_grade = value; }
        }
        public Form_AddGrade(Grade grade, int per)
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
            m_grade.p_Grade[m_per] = Convert.ToInt32(nudGrade.Value);
            m_grade.Comment[m_per] = txtComment.Text;
            m_grade.GradeCount += 1;
            this.Close();
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            if(txtComment.Text.Length > 0)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled=false;
            }
        }
    }
}
