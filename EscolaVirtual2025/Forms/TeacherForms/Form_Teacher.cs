using EscolaVirtual2025.Classes;
using EscolaVirtual2025.Classes.Academic;
using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Data;
using EscolaVirtual2025.Forms.TeacherForms.RelatorioTeacher;
using EscolaVirtual2025.Forms.TeacherForms.TeacherAccount;
using EscolaVirtual2025.Forms.TeacherForms.TeacherChat;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EscolaVirtual2025.Forms.TeacherForms
{
    public partial class Form_Teacher : MaterialForm
    {
        public Teacher tchr;
        public Relatorio rlt;
        private bool ClosedByButton = false;
        public Form_Teacher()
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
        }

        private void Form_Teacher_Load(object sender, EventArgs e)
        {

            btnUser.Text = DataManager.currentUser.Name + "";

            #region toolstrip

            btnUser.AutoSize = false;
            btnUser.Left = this.ClientSize.Width - btnUser.Width;
            btnUser.Top = 25;


            int totalHeight = 0;

            foreach (ToolStripItem item in menuAccount.Items)
            {
                int itemHeight = item.Height;
                int paddingTop = item.Padding.Top;
                int paddingBottom = item.Padding.Bottom;

                totalHeight += itemHeight + paddingTop + paddingBottom;
            }

            menuAccount.Size = new Size(
            menuAccount.Width,
            totalHeight
            );
            #endregion

            UpdateUserArrow();

            tchr = DataManager.currentUser as Teacher;



            DataManager.Years = DataManager.Years.OrderBy(yr => yr.Id).ToList();
            foreach (Year yr in tchr.AssignedClassRooms.Items.Select(cr => cr.Year).Distinct())
            {
                cbbYear.Items.Add(yr.Id + "º");
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            menuAccount.Show(btnUser, new Point(0, btnUser.Height));
        }

        private void materialToolStripItemLeave_Click(object sender, EventArgs e)
        {
            ClosedByButton = true;
            this.Close();
            Program.formLogin.Show();
        }

        private void Form_Teacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ClosedByButton == false)
            {
                Program.formLogin.Close();
            }
        }

        private void UpdateUserArrow()
        {
            if (menuAccount.Visible)
                btnUser.Text = $"{DataManager.currentUser.Name} ▲"; // seta para cima
            else
                btnUser.Text = $"{DataManager.currentUser.Name} ▼"; // seta para baixo
        }

        private void menuAccount_VisibleChanged(object sender, EventArgs e)
        {
            UpdateUserArrow();
        }

        private void cbbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbbClassRoom.Items.Clear();

            if (cbbYear.SelectedIndex != -1)
            {
                int anoSelecionado = Convert.ToInt32(cbbYear.SelectedItem.ToString().Replace("º", ""));

                if (tchr.AssignedClassRooms.Items.Where(cr => cr.Year.Id == anoSelecionado).ToList().Count > 0)
                {
                    cbbClassRoom.Enabled = true;
                    foreach (ClassRoom r in tchr.AssignedClassRooms.Items.Where(cr => cr.Year.Id == anoSelecionado).ToList())
                    {
                        cbbClassRoom.Items.Add(r.Letter);
                    }
                }
            }
            else
            {
                cbbClassRoom.SelectedIndex = -1;
                cbbClassRoom.Enabled = false;
            }
        }

        private void cbbClassRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnReport.Enabled = true;
            lsbStudents.Items.Clear();
            foreach (Student st in DataManager.Years[cbbYear.SelectedIndex].ClassRooms.Items[cbbClassRoom.SelectedIndex].Students)
            {
                if (st != null)
                    lsbStudents.Items.Add(st.Name);
            }
        }

        private void lsbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbStudents.SelectedIndex != -1)
            {
                btnCreateGrade.Enabled = true;
                btnReport.Text = "Relatório de Aluno";
            }
            else
            {
                btnCreateGrade.Enabled = false;
                btnReport.Text = "Relatório de Turma";
            }
        }

        private void btnCreateGrade_Click(object sender, EventArgs e)
        {
            Form_Grades form_Grades = new Form_Grades(tchr.AssignedClassRooms.Items[cbbClassRoom.SelectedIndex].Students[lsbStudents.SelectedIndex], tchr.AssignedSubject);
            this.Hide();
            form_Grades.ShowDialog();
            this.Show();
        }

        private void materialToolStripItemNotification_Click(object sender, EventArgs e)
        {
            Form_TeacherChat form_TeacherChat = new Form_TeacherChat(tchr);
            this.Hide();
            form_TeacherChat.ShowDialog();
            this.Show();
        }

        private void materialToolStripItemAccount_Click(object sender, EventArgs e)
        {
            Form_TeacherAccount form_TeacherAccount = new Form_TeacherAccount();
            this.Hide();
            form_TeacherAccount.ShowDialog();
            this.Show();
        }

        private void Form_Teacher_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (btnReport.Text == "Relatório de Aluno")
            {

            }
            else if (btnReport.Text == "Relatório de Turma")
            {
                Form_Relatorio frm = new Form_Relatorio(DataManager.Years[cbbYear.SelectedIndex].ClassRooms.Items[cbbClassRoom.SelectedIndex], tchr);
                frm.ShowDialog();
                this.Hide();
            }

        }
    }
}
