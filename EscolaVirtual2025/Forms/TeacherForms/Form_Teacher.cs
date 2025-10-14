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
using System.Xml.Schema;

namespace EscolaVirtual2025.Forms.TeacherForms
{
    public partial class Form_Teacher : MaterialForm
    {
        private Teacher tchr;
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

            btnUser.Text = Program.userAtual.Name + "";

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

            tchr = Program.userAtual as Teacher;



            Program.Anos = Program.Anos.OrderBy(yr => yr.AnoId).ToList();
            foreach (Year yr in tchr.AssignedClassRooms.Select(cr => cr.Year).Distinct())
            {
               cbbYear.Items.Add(yr.AnoId + "º");
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
                btnUser.Text = $"{Program.userAtual.Name} ▲"; // seta para cima
            else
                btnUser.Text = $"{Program.userAtual.Name} ▼"; // seta para baixo
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

                if (tchr.AssignedClassRooms.Where(cr => cr.Year.AnoId == anoSelecionado).ToList().Count > 0)
                {
                    cbbClassRoom.Enabled = true;
                    foreach (ClassRoom r in tchr.AssignedClassRooms.Where(cr => cr.Year.AnoId == anoSelecionado).ToList())
                    {
                        cbbClassRoom.Items.Add(r.Id);
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
            lsbStudents.Items.Clear();
            foreach(Student st in Program.Anos[cbbYear.SelectedIndex].ClassRooms[cbbClassRoom.SelectedIndex].Students)
            {
                if(st !=  null) 
                    lsbStudents.Items.Add(st.Name);
            }
        }

        private void lsbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsbStudents.SelectedIndex != -1)
            {
                btnCreateGrade.Enabled = true;  
            }
            else
            {
                btnCreateGrade.Enabled = false;
            }
        }

        private void btnCreateGrade_Click(object sender, EventArgs e)
        {
            Form_Grades form_Grades = new Form_Grades(tchr.AssignedClassRooms[cbbClassRoom.SelectedIndex].Students[lsbStudents.SelectedIndex], tchr.AssignedSubject);
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
    }
}
