namespace EscolaVirtual2025.Forms.Admin
{
    partial class Form_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Anos");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Professores");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Escola", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin));
            this.menuAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.materialToolStripItemAccount = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.materialToolStripItemNotification = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.Separator = new System.Windows.Forms.ToolStripSeparator();
            this.materialToolStripItemLeave = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnUser = new MaterialSkin.Controls.MaterialButton();
            this.tvwAdmin = new System.Windows.Forms.TreeView();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSubjects = new MaterialSkin.Controls.MaterialButton();
            this.btnClassRooms = new MaterialSkin.Controls.MaterialButton();
            this.btnYears = new MaterialSkin.Controls.MaterialButton();
            this.btnStudents = new MaterialSkin.Controls.MaterialButton();
            this.btnTeachers = new MaterialSkin.Controls.MaterialButton();
            this.panelTreeView = new System.Windows.Forms.Panel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuAccount.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.panelTreeView.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAccount
            // 
            this.menuAccount.AutoSize = false;
            this.menuAccount.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materialToolStripItemAccount,
            this.materialToolStripItemNotification,
            this.Separator,
            this.materialToolStripItemLeave,
            this.toolStripSeparator});
            this.menuAccount.Name = "menuAccount";
            this.menuAccount.Size = new System.Drawing.Size(160, 200);
            this.menuAccount.VisibleChanged += new System.EventHandler(this.menuAccount_VisibleChanged);
            // 
            // materialToolStripItemAccount
            // 
            this.materialToolStripItemAccount.AutoSize = false;
            this.materialToolStripItemAccount.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialToolStripItemAccount.Image = global::EscolaVirtual2025.Properties.Resources.account;
            this.materialToolStripItemAccount.Name = "materialToolStripItemAccount";
            this.materialToolStripItemAccount.Size = new System.Drawing.Size(160, 32);
            this.materialToolStripItemAccount.Text = "Conta";
            this.materialToolStripItemAccount.Click += new System.EventHandler(this.materialToolStripItemAccount_Click);
            // 
            // materialToolStripItemNotification
            // 
            this.materialToolStripItemNotification.AutoSize = false;
            this.materialToolStripItemNotification.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.materialToolStripItemNotification.Image = global::EscolaVirtual2025.Properties.Resources.notification;
            this.materialToolStripItemNotification.Name = "materialToolStripItemNotification";
            this.materialToolStripItemNotification.Size = new System.Drawing.Size(160, 32);
            this.materialToolStripItemNotification.Text = "Notificações";
            this.materialToolStripItemNotification.Click += new System.EventHandler(this.materialToolStripItemNotification_Click);
            // 
            // Separator
            // 
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(156, 6);
            // 
            // materialToolStripItemLeave
            // 
            this.materialToolStripItemLeave.AutoSize = false;
            this.materialToolStripItemLeave.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.materialToolStripItemLeave.Image = global::EscolaVirtual2025.Properties.Resources.logout;
            this.materialToolStripItemLeave.Name = "materialToolStripItemLeave";
            this.materialToolStripItemLeave.Size = new System.Drawing.Size(160, 32);
            this.materialToolStripItemLeave.Text = "Sair";
            this.materialToolStripItemLeave.Click += new System.EventHandler(this.materialToolStripItemLeave_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(156, 6);
            // 
            // btnUser
            // 
            this.btnUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUser.AutoSize = false;
            this.btnUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUser.Depth = 0;
            this.btnUser.HighEmphasis = true;
            this.btnUser.Icon = null;
            this.btnUser.Location = new System.Drawing.Point(637, 25);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUser.MinimumSize = new System.Drawing.Size(160, 39);
            this.btnUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUser.Name = "btnUser";
            this.btnUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUser.Size = new System.Drawing.Size(160, 39);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "Conta";
            this.btnUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnUser.UseAccentColor = false;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // tvwAdmin
            // 
            this.tvwAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwAdmin.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwAdmin.Location = new System.Drawing.Point(6, 6);
            this.tvwAdmin.Name = "tvwAdmin";
            treeNode1.Name = "NodeYears";
            treeNode1.Text = "Anos";
            treeNode2.Name = "NodeSchoolTeachers";
            treeNode2.Text = "Professores";
            treeNode3.Name = "NodeSchool";
            treeNode3.Text = "Escola";
            this.tvwAdmin.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tvwAdmin.Size = new System.Drawing.Size(365, 407);
            this.tvwAdmin.TabIndex = 2;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tableLayoutPanelMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(3, 64);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(794, 459);
            this.panelMain.TabIndex = 3;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelButtons, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelTreeView, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(754, 419);
            this.tableLayoutPanelMain.TabIndex = 3;
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 1;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.Controls.Add(this.btnSubjects, 0, 2);
            this.tableLayoutPanelButtons.Controls.Add(this.btnClassRooms, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.btnYears, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btnStudents, 0, 4);
            this.tableLayoutPanelButtons.Controls.Add(this.btnTeachers, 0, 3);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(377, 0);
            this.tableLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 5;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(377, 419);
            this.tableLayoutPanelButtons.TabIndex = 3;
            // 
            // btnSubjects
            // 
            this.btnSubjects.AutoSize = false;
            this.btnSubjects.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubjects.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSubjects.Depth = 0;
            this.btnSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubjects.Font = new System.Drawing.Font("Calibri", 36F);
            this.btnSubjects.HighEmphasis = true;
            this.btnSubjects.Icon = null;
            this.btnSubjects.Location = new System.Drawing.Point(4, 172);
            this.btnSubjects.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSubjects.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSubjects.Size = new System.Drawing.Size(369, 71);
            this.btnSubjects.TabIndex = 4;
            this.btnSubjects.Text = "Disciplinas";
            this.btnSubjects.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSubjects.UseAccentColor = false;
            this.btnSubjects.UseVisualStyleBackColor = true;
            this.btnSubjects.Click += new System.EventHandler(this.btnSubjects_Click);
            // 
            // btnClassRooms
            // 
            this.btnClassRooms.AutoSize = false;
            this.btnClassRooms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClassRooms.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClassRooms.Depth = 0;
            this.btnClassRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClassRooms.Font = new System.Drawing.Font("Calibri", 36F);
            this.btnClassRooms.HighEmphasis = true;
            this.btnClassRooms.Icon = null;
            this.btnClassRooms.Location = new System.Drawing.Point(4, 89);
            this.btnClassRooms.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClassRooms.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClassRooms.Name = "btnClassRooms";
            this.btnClassRooms.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClassRooms.Size = new System.Drawing.Size(369, 71);
            this.btnClassRooms.TabIndex = 2;
            this.btnClassRooms.Text = "Turmas";
            this.btnClassRooms.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnClassRooms.UseAccentColor = false;
            this.btnClassRooms.UseVisualStyleBackColor = true;
            this.btnClassRooms.Click += new System.EventHandler(this.btnClassRooms_Click);
            // 
            // btnYears
            // 
            this.btnYears.AutoSize = false;
            this.btnYears.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnYears.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnYears.Depth = 0;
            this.btnYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnYears.Font = new System.Drawing.Font("Calibri", 36F);
            this.btnYears.HighEmphasis = true;
            this.btnYears.Icon = null;
            this.btnYears.Location = new System.Drawing.Point(4, 6);
            this.btnYears.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnYears.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYears.Name = "btnYears";
            this.btnYears.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnYears.Size = new System.Drawing.Size(369, 71);
            this.btnYears.TabIndex = 1;
            this.btnYears.Text = "Anos";
            this.btnYears.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYears.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnYears.UseAccentColor = false;
            this.btnYears.UseVisualStyleBackColor = true;
            this.btnYears.Click += new System.EventHandler(this.btnYears_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStudents.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStudents.Depth = 0;
            this.btnStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStudents.HighEmphasis = true;
            this.btnStudents.Icon = null;
            this.btnStudents.Location = new System.Drawing.Point(4, 338);
            this.btnStudents.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStudents.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStudents.Size = new System.Drawing.Size(369, 75);
            this.btnStudents.TabIndex = 3;
            this.btnStudents.Text = "Alunos";
            this.btnStudents.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnStudents.UseAccentColor = false;
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTeachers.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTeachers.Depth = 0;
            this.btnTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeachers.Font = new System.Drawing.Font("Calibri", 36F);
            this.btnTeachers.HighEmphasis = true;
            this.btnTeachers.Icon = null;
            this.btnTeachers.Location = new System.Drawing.Point(4, 255);
            this.btnTeachers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTeachers.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTeachers.Size = new System.Drawing.Size(369, 71);
            this.btnTeachers.TabIndex = 0;
            this.btnTeachers.Text = "Professores";
            this.btnTeachers.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnTeachers.UseAccentColor = false;
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // panelTreeView
            // 
            this.panelTreeView.Controls.Add(this.tvwAdmin);
            this.panelTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTreeView.Location = new System.Drawing.Point(0, 0);
            this.panelTreeView.Margin = new System.Windows.Forms.Padding(0);
            this.panelTreeView.Name = "panelTreeView";
            this.panelTreeView.Padding = new System.Windows.Forms.Padding(6);
            this.panelTreeView.Size = new System.Drawing.Size(377, 419);
            this.panelTreeView.TabIndex = 4;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "YOOOOO";
            this.notifyIcon.Visible = true;
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Form_Admin";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "     Escola Virtual";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Admin_FormClosed);
            this.Load += new System.EventHandler(this.Form_Admin_Load);
            this.SizeChanged += new System.EventHandler(this.Form_Admin_SizeChanged);
            this.menuAccount.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.tableLayoutPanelButtons.PerformLayout();
            this.panelTreeView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip menuAccount;
        private MaterialSkin.Controls.MaterialToolStripMenuItem materialToolStripItemAccount;
        private MaterialSkin.Controls.MaterialButton btnUser;
        private MaterialSkin.Controls.MaterialToolStripMenuItem materialToolStripItemLeave;
        private System.Windows.Forms.ToolStripSeparator Separator;
        private MaterialSkin.Controls.MaterialToolStripMenuItem materialToolStripItemNotification;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.TreeView tvwAdmin;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MaterialSkin.Controls.MaterialButton btnTeachers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private MaterialSkin.Controls.MaterialButton btnStudents;
        private MaterialSkin.Controls.MaterialButton btnClassRooms;
        private MaterialSkin.Controls.MaterialButton btnYears;
        private System.Windows.Forms.Panel panelTreeView;
        private MaterialSkin.Controls.MaterialButton btnSubjects;
    }
}