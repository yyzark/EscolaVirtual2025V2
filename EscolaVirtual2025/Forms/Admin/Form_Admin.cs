using EscolaVirtual2025.Data;
using EscolaVirtual2025.Forms.Admin.AdminChats;
using EscolaVirtual2025.Forms.Admin.AdminForms;
using EscolaVirtual2025.Forms.Admin.AdminForms.ClassRooms;
using EscolaVirtual2025.Forms.Admin.AdminForms.Subjects;
using EscolaVirtual2025.Forms.Admin.AdminForms.Teachers;
using EscolaVirtual2025.Forms.Admin.AdminForms.YearForms;
using EscolaVirtual2025.Forms.Admin.Panels;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace EscolaVirtual2025.Forms.Admin
{
    public partial class Form_Admin : MaterialForm
    {
        bool ClosedByButton = false;
        private PanelAccountAdmin accountPanel;
        private PanelAccountAdminEdit editPanel;

        Timer hideTimer;

        public Form_Admin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

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

            //inicialização do timer
            hideTimer = new Timer();
            hideTimer.Interval = 100; // a cada 100 ms
            hideTimer.Tick += HideTimer_Tick;
        }

        private void Form_Admin_Load(object sender, EventArgs e)
        {
            #region Paneis e toolstrip

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

            //painel de conta 
            accountPanel = new PanelAccountAdmin();
            accountPanel.Visible = false;
            this.Controls.Add(accountPanel);
            accountPanel.AutoSize = false;
            accountPanel.Size = new Size(300, 386);
            accountPanel.Location = new Point(this.ClientSize.Width - accountPanel.Width, 64);
            accountPanel.Edit += AccountPanel_EditClicked;
            accountPanel.VisibleChanged += AccountPanel_VisibleChanged;
            //painel edit de conta 
            editPanel = new PanelAccountAdminEdit();
            editPanel.Visible = false;
            this.Controls.Add(editPanel);
            editPanel.AutoSize = false;
            editPanel.Size = new Size(300, 386);
            editPanel.Location = new Point(this.ClientSize.Width - editPanel.Width, 64);
            editPanel.Cancel += EditPanel_CancelClicked;
            editPanel.VisibleChanged += EditPanel_VisibleChanged;

            //cavalo especial de corrida
            editPanel.BeforeDialog += (send, args) => hideTimer.Stop();
            editPanel.AfterDialog += (send, args) =>
            {
                if (accountPanel.Visible || editPanel.Visible)
                    hideTimer.Start();
            };


            UpdateUserArrow();

            #endregion

            #region treeView 
            tvwAdmin.Font = new Font("Calibri", 16, FontStyle.Regular);
            tvwAdmin.Nodes[0].Expand();
            tvwAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;

            UpdateTreeView();
            #endregion


            #region notificações
            int notificationCount = DataManager.currentUser.Notifications.Count(n => !n.Read);

            if (notificationCount > 0)
            {
                notifyIcon.BalloonTipText = notificationCount > 1 ?
                $"Tem {notificationCount} novas notificações" :
                $"Tem {1} nova notificação";

                menuAccount.Items[1].Text = $"Notificações";
                menuAccount.Items[1].Image = Properties.Resources.notificationRinging;
                notifyIcon.ShowBalloonTip(3000);
            }
            else
            {
                menuAccount.Items[1].Text = $"Notificações";
                menuAccount.Items[1].Image = Properties.Resources.notification;
            }
            #endregion
        }

        #region paneis e toolstrip
        private void EditPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (accountPanel.Visible || editPanel.Visible)
            {
                hideTimer.Start();
            }
            else
            {
                hideTimer.Stop();
            }
            UpdateUserArrow();
        }

        private void AccountPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (accountPanel.Visible || editPanel.Visible)
            {
                hideTimer.Start();
            }
            else
            {
                hideTimer.Stop();
            }
            UpdateUserArrow();
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

        private void Form_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ClosedByButton == false)
            {
                Program.formLogin.Close();
            }
        }

        private void materialToolStripItemAccount_Click(object sender, EventArgs e)
        {
            accountPanel.BringToFront();
            accountPanel.Visible = true;
        }

        private async void HideTimer_Tick(object sender, EventArgs e)
        {
            var mousePos = this.PointToClient(Cursor.Position);


            bool overAccount = accountPanel.Bounds.Contains(mousePos);
            bool overEdit = editPanel.Visible && editPanel.Bounds.Contains(mousePos);

            if (!overAccount && !overEdit)
            {
                await Task.Delay(200);
                accountPanel.Visible = false;
                editPanel.Visible = false;
                hideTimer.Stop();
                UpdateUserArrow();
            }
        }

        private void Form_Admin_SizeChanged(object sender, EventArgs e)
        {
            if (accountPanel != null && editPanel != null) // previne erros ao iniciar o form
            {
                accountPanel.Location = new Point(this.Width - accountPanel.Width, 64);
                editPanel.Location = new Point(this.Width - editPanel.Width, 64);
            }
            tvwAdmin.Font = new Font("Calibri", 16, FontStyle.Regular);
            tvwAdmin.Nodes[0].Expand();
            tvwAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
        }

        private void UpdateUserArrow()
        {
            if (menuAccount.Visible || accountPanel.Visible || editPanel.Visible)
                btnUser.Text = $"{DataManager.currentUser.Name} ▲"; // seta para cima
            else
                btnUser.Text = $"{DataManager.currentUser.Name} ▼"; // seta para baixo
        }

        private void menuAccount_VisibleChanged(object sender, EventArgs e)
        {
            UpdateUserArrow();
        }

        private void AccountPanel_EditClicked(object sender, EventArgs e)
        {
            accountPanel.Visible = false;
            editPanel.BringToFront();
            editPanel.Visible = true;
        }

        private void EditPanel_CancelClicked(object sender, EventArgs e)
        {
            editPanel.Visible = false;
            accountPanel.BringToFront();
            accountPanel.Visible = true;
        }
        #endregion

        private void btnStudents_Click(object sender, EventArgs e)
        {
            Form_StudentCheck form_StudentCheck = new Form_StudentCheck();
            form_StudentCheck.ShowDialog();
            UpdateTreeView();
        }

        private void UpdateTreeView()
        {
            tvwAdmin.Nodes[0].Nodes[0].Nodes.Clear();
            tvwAdmin.Nodes[0].Nodes[1].Nodes.Clear();
            for (int i = 0; i < DataManager.Years.Count; i++)
            {
                TreeNode tree = new TreeNode();
                tree.Text = DataManager.Years.OrderBy(yr => yr.Id).ToList()[i].Id.ToString();
                tree.Nodes.Add("Turmas");
                tree.Nodes.Add("Disciplinas");
                //adicionar turmas
                DataManager.Years[i].ClassRooms.Reorder(clsrm => clsrm.Letter);
                for (int j = 0; j < DataManager.Years[i].ClassRooms.Items.Count; j++)
                {
                    TreeNode clas = new TreeNode();
                    clas.Text = $"{DataManager.Years.OrderBy(yr => yr.Id).ToList()[i].Id}º{DataManager.Years[i].ClassRooms.Items[j].Letter}";
                    //adicionar alunos
                    clas.Nodes.Add("Alunos");
                    clas.Nodes.Add("Disciplinas");
                    for (int h = 0; h < DataManager.Years[i].ClassRooms.Items[j].StudentsCount; h++)
                    {
                        TreeNode student = new TreeNode();
                        student.Text = DataManager.Years[i].ClassRooms.Items[j].Students[h].Name;
                        clas.Nodes[0].Nodes.Add(student);
                    }
                    //adicionar disciplinas nas turmas
                    for (int h = 0; h < DataManager.Years[i].ClassRooms.Items[j].ClassSubjects.Items.Count; h++)
                    {
                        TreeNode subject = new TreeNode();
                        subject.Text = DataManager.Years[i].ClassRooms.Items[j].ClassSubjects.Items[h].Name;
                        if (DataManager.Years[i].ClassRooms.Items[j].ClassSubjects.Items[h].Teacher != null)
                        {
                            subject.Nodes.Add($"Professor: {DataManager.Years[i].ClassRooms.Items[j].ClassSubjects.Items[h].Teacher.Name}");
                        }
                        else
                        {
                            subject.Nodes.Add($"Professor: ND");
                        }
                        clas.Nodes[1].Nodes.Add(subject);
                    }

                    tree.Nodes[0].Nodes.Add(clas);
                }

                //adicionar disciplinas
                for (int j = 0; j < DataManager.Years[i].Subjects.Items.Count; j++)
                {
                    TreeNode subject = new TreeNode();
                    subject.Text = $"{DataManager.Years[i].Subjects.Items[j].Name}";
                    //adicionar professores
                    for (int h = 0; h < DataManager.Years[i].Subjects.Items[j].Teachers.Items.Count; h++)
                    {
                        TreeNode teacher = new TreeNode();
                        teacher.Text = DataManager.Years[i].Subjects.Items[j].Teachers.Items[h].Name;
                        subject.Nodes.Add(teacher);
                    }
                    tree.Nodes[1].Nodes.Add(subject);
                }
                tvwAdmin.Nodes[0].Nodes[0].Nodes.Add(tree);
            }

            //adicionar professores
            for (int i = 0; i < DataManager.Teachers.Count; i++)
            {
                TreeNode teacher = new TreeNode();
                teacher.Text = DataManager.Teachers[i].Name;
                tvwAdmin.Nodes[0].Nodes[1].Nodes.Add(teacher);
            }
        }

        private void btnYears_Click(object sender, EventArgs e)
        {
            Form_CheckYears form_CheckYears = new Form_CheckYears();
            form_CheckYears.ShowDialog();
            UpdateTreeView();
        }

        private void btnClassRooms_Click(object sender, EventArgs e)
        {
            Form_CheckClassRooms form_CheckClassRooms = new Form_CheckClassRooms();
            form_CheckClassRooms.ShowDialog();
            UpdateTreeView();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            Form_SubjectsCheck form_SubjectsCheck = new Form_SubjectsCheck();
            form_SubjectsCheck.ShowDialog();
            UpdateTreeView();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            Form_CheckTeachers form_CheckTeachers = new Form_CheckTeachers();
            form_CheckTeachers.ShowDialog();
            UpdateTreeView();
        }

        private void materialToolStripItemNotification_Click(object sender, EventArgs e)
        {
            if (DataManager.Users[0].Notifications.Count == 0)
            {
                MessageBox.Show("Não há pedidos pendentes", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Form_AdminChats form_AdminChats = new Form_AdminChats();
            this.Hide();
            form_AdminChats.ShowDialog();
            this.Show();
            UpdateTreeView();

            #region notificações
            int notificationCount = DataManager.currentUser.Notifications.Count(n => !n.Read);

            if (notificationCount > 0)
            {
                notifyIcon.BalloonTipText = notificationCount > 1 ?
                $"Tem {notificationCount} novas notificações" :
                $"Tem {1} nova notificação";

                menuAccount.Items[1].Text = $"Notificações";
                menuAccount.Items[1].Image = Properties.Resources.notificationRinging;
                notifyIcon.ShowBalloonTip(3000);
            }
            else
            {
                menuAccount.Items[1].Text = $"Notificações";
                menuAccount.Items[1].Image = Properties.Resources.notification;
                notifyIcon.ShowBalloonTip(3000);
            }
            #endregion
            this.Show();
        }

        private void materialToolStripBackup_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form_Backup().ShowDialog();
            this.Show();
            UpdateTreeView();
        }
    }
}
