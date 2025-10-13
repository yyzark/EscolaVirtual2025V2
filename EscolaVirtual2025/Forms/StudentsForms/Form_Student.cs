using EscolaVirtual2025.Classes.Users;
using EscolaVirtual2025.Forms.StudentsForms.MainPanel;
using EscolaVirtual2025.Forms.StudentsForms.StudentChat;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace EscolaVirtual2025.Forms.StudentsForms
{
    public partial class Form_Student : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        private bool ClosedByButton;
        Student stdnt;

        public Form_Student()
        {
            InitializeComponent();

            #region MaterialSkin
            materialSkinManager = MaterialSkinManager.Instance;
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

            ClosedByButton = false;
        }

        private void Form_Student_Load(object sender, EventArgs e)
        {
            menuStrip1.BackColor = materialSkinManager.ColorScheme.PrimaryColor;

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
            totalHeight + 1
            );
            #endregion

            #region notificações
            int notificationCount = Program.userAtual.Notifications.Count(n => !n.Read);

            if (notificationCount > 0)
            {
                notifyIcon.BalloonTipText = notificationCount > 1 ?
                $"Tem {notificationCount} novas notificações" :
                $"Tem {1} nova notificação";

                tsmiNotifications.Text = $"Notificações ({notificationCount})";
                tsmiNotifications.Image = Properties.Resources.notificationRinging;
                notifyIcon.ShowBalloonTip(3000);
            }
            #endregion

            

            btnUser.Text = Program.userAtual.Name + "";

            stdnt = Program.userAtual as Student;

            btnUser.Text = stdnt.Name;

            UpdateUserArrow();
            UpdateUserPanel();
            UpdateSchoolCard();

            panelAvaliation.SendToBack();
            paneInfo.BringToFront();
        }

        private void UpdateUserPanel()
        {
            lblName.Text = $"Nome: {stdnt.Name}";
            lblPassword.Text = $"Senha: {new String('*', stdnt.Password.Length)}" ;
            lblUser.Text = $"Utilizador: {stdnt.Username}";
            lblClassRoom.Text = $"Turma: {stdnt.ClassRoom.Year.AnoId}º{stdnt.ClassRoom.Id}";
        }

        private void UpdateSchoolCard()
        {
            lblcardNumber.Text = $"Nº: {stdnt.SchoolCard.SchoolCardId}";
            lblSaldo.Text = $"Saldo: {stdnt.SchoolCard.Saldo/100.00}€";
        }

        private void MostrarNotasAlunoPorPeriodo(int periodoIndex)
        {
                chart1.Series.Clear();

                stdnt.Grades.ForEach(grd => grd.OrderGradesByName());

                var series = new Series
                {
                    Name = $"{periodoIndex + 1}ºperiodo ",
                    IsValueShownAsLabel = true,
                    ChartType = SeriesChartType.Column
                };

                foreach (var grade in stdnt.Grades)
                {
                    int nota = grade.p_Grade[periodoIndex];
                    series.Points.AddXY(grade.Gradesubject.Name, nota);
                }

                chart1.Series.Add(series);

                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 20;
                chart1.ChartAreas[0].AxisY.Title = "Nota";

                chart1.ChartAreas[0].AxisX.Title = "Disciplina";
                chart1.ChartAreas[0].AxisX.Interval = 1;

                chart1.Invalidate();
        }

        private void ºPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!stdnt.Grades.Any(g => g.p_Grade[0] != -1))
            {
                MessageBox.Show("Não existem notas para este período.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MostrarNotasAlunoPorPeriodo(0);

            paneInfo.SendToBack();
            panelAvaliation.BringToFront();
        }
        private void ºPeriodoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!stdnt.Grades.Any(g => g.p_Grade[1] != -1))
            {
                MessageBox.Show("Não existem notas para este período.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MostrarNotasAlunoPorPeriodo(1);

            paneInfo.SendToBack();
            panelAvaliation.BringToFront();
        }

        private void ºPeriodoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!stdnt.Grades.Any(g => g.p_Grade[2] != -1))
            {
                MessageBox.Show("Não existem notas para este período.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MostrarNotasAlunoPorPeriodo(2);

            paneInfo.SendToBack();
            panelAvaliation.BringToFront();
        }

        private void tmsCartãoEscolar_Click(object sender, EventArgs e)
        {
            panelAvaliation.SendToBack();
            paneInfo.BringToFront();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            menuAccount.Show(btnUser, new Point(0, btnUser.Height));
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

        private void materialToolStripItemLeave_Click(object sender, EventArgs e)
        {
            ClosedByButton = true;
            this.Close();
            Program.formLogin.Show();
        }

        private void btnShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            lblPassword.Text = $"Senha: {stdnt.Password}";
        }

        private void btnShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            lblPassword.Text = $"Senha: {new String('*', stdnt.Password.Length)}";
        }

        private void Form_Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ClosedByButton == false)
            {
                Program.formLogin.Close();
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Form_Deposit deposit = new Form_Deposit(stdnt);
            this.Hide();
            deposit.ShowDialog();
            this.Show();
            UpdateSchoolCard();
            menuStrip1.BackColor = materialSkinManager.ColorScheme.PrimaryColor;
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            Form_EditStudent editStudentForm = new Form_EditStudent(stdnt);
            this.Hide();
            editStudentForm.ShowDialog();
            this.Show();
            menuStrip1.BackColor = materialSkinManager.ColorScheme.PrimaryColor;
        }

        private void tsmiNotifications_Click(object sender, EventArgs e)
        {
            Form_StudentChats form_StudentChats = new Form_StudentChats();
            this.Hide();
            form_StudentChats.ShowDialog();
            this.Show();
            menuStrip1.BackColor = materialSkinManager.ColorScheme.PrimaryColor;
        }

        private void chart1_DoubleClick(object sender, MouseEventArgs e)
        {
            HitTestResult result = chart1.HitTest(e.X, e.Y);

            // Só continua se clicou numa coluna (ponto da série)
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                int pointIndex = result.PointIndex;
                Series series = result.Series;

                // Recupera a disciplina (nome no eixo X)
                string disciplina = series.Points[pointIndex].AxisLabel;

                // Localiza o objeto "grade" correspondente
                var grade = stdnt.Grades.FirstOrDefault(g => g.Gradesubject.Name == disciplina);
                if (grade == null) return;

                // Identifica o período (exemplo: 0 = 1º, 1 = 2º, etc)
                int periodoIndex = int.Parse(series.Name.Split(' ')[1]) - 1;

                // Recupera o comentário
                string comentario = grade.Comment[periodoIndex] ?? "Sem comentário.";

                // Mostra
                MessageBox.Show(
                    $"Comentário para {disciplina} ({series.Name}):\n\n{comentario}",
                    "Comentário da Nota",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
