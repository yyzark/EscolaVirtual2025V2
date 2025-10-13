namespace EscolaVirtual2025.Forms.TeacherForms
{
    partial class Form_Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Teacher));
            this.btnUser = new MaterialSkin.Controls.MaterialButton();
            this.menuAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.materialToolStripItemAccount = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.materialToolStripItemNotification = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.Separator = new System.Windows.Forms.ToolStripSeparator();
            this.materialToolStripItemLeave = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.cbbClassRoom = new MaterialSkin.Controls.MaterialComboBox();
            this.cbbYear = new MaterialSkin.Controls.MaterialComboBox();
            this.btnCreateGrade = new MaterialSkin.Controls.MaterialButton();
            this.panelTreeView = new System.Windows.Forms.Panel();
            this.lsbStudents = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuAccount.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.panelTreeView.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnUser.Location = new System.Drawing.Point(539, 25);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUser.MinimumSize = new System.Drawing.Size(160, 39);
            this.btnUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUser.Name = "btnUser";
            this.btnUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUser.Size = new System.Drawing.Size(160, 39);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "materialButton1";
            this.btnUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnUser.UseAccentColor = false;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
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
            // 
            // materialToolStripItemNotification
            // 
            this.materialToolStripItemNotification.AutoSize = false;
            this.materialToolStripItemNotification.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.materialToolStripItemNotification.Image = global::EscolaVirtual2025.Properties.Resources.chat;
            this.materialToolStripItemNotification.Name = "materialToolStripItemNotification";
            this.materialToolStripItemNotification.Size = new System.Drawing.Size(160, 32);
            this.materialToolStripItemNotification.Text = "Chat";
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
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tableLayoutPanelMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(3, 64);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(693, 253);
            this.panelMain.TabIndex = 4;
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
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(653, 213);
            this.tableLayoutPanelMain.TabIndex = 3;
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 1;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.Controls.Add(this.btnCreateGrade, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(336, 0);
            this.tableLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 2;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(307, 203);
            this.tableLayoutPanelButtons.TabIndex = 3;
            // 
            // cbbClassRoom
            // 
            this.cbbClassRoom.AutoResize = false;
            this.cbbClassRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbClassRoom.Depth = 0;
            this.cbbClassRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbClassRoom.DropDownHeight = 174;
            this.cbbClassRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClassRoom.DropDownWidth = 121;
            this.cbbClassRoom.Enabled = false;
            this.cbbClassRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbClassRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbClassRoom.FormattingEnabled = true;
            this.cbbClassRoom.Hint = "Turma";
            this.cbbClassRoom.IntegralHeight = false;
            this.cbbClassRoom.ItemHeight = 43;
            this.cbbClassRoom.Location = new System.Drawing.Point(156, 3);
            this.cbbClassRoom.MaxDropDownItems = 4;
            this.cbbClassRoom.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbClassRoom.Name = "cbbClassRoom";
            this.cbbClassRoom.Size = new System.Drawing.Size(145, 49);
            this.cbbClassRoom.StartIndex = 0;
            this.cbbClassRoom.TabIndex = 5;
            this.cbbClassRoom.SelectedIndexChanged += new System.EventHandler(this.cbbClassRoom_SelectedIndexChanged);
            // 
            // cbbYear
            // 
            this.cbbYear.AutoResize = false;
            this.cbbYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbYear.Depth = 0;
            this.cbbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbYear.DropDownHeight = 174;
            this.cbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbYear.DropDownWidth = 121;
            this.cbbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.Hint = "Ano";
            this.cbbYear.IntegralHeight = false;
            this.cbbYear.ItemHeight = 43;
            this.cbbYear.Location = new System.Drawing.Point(3, 3);
            this.cbbYear.MaxDropDownItems = 4;
            this.cbbYear.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(144, 49);
            this.cbbYear.StartIndex = 0;
            this.cbbYear.TabIndex = 4;
            this.cbbYear.SelectedIndexChanged += new System.EventHandler(this.cbbYear_SelectedIndexChanged);
            // 
            // btnCreateGrade
            // 
            this.btnCreateGrade.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateGrade.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreateGrade.Depth = 0;
            this.btnCreateGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateGrade.Enabled = false;
            this.btnCreateGrade.Font = new System.Drawing.Font("Calibri", 36F);
            this.btnCreateGrade.HighEmphasis = true;
            this.btnCreateGrade.Icon = null;
            this.btnCreateGrade.Location = new System.Drawing.Point(4, 109);
            this.btnCreateGrade.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreateGrade.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreateGrade.Name = "btnCreateGrade";
            this.btnCreateGrade.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCreateGrade.Size = new System.Drawing.Size(299, 88);
            this.btnCreateGrade.TabIndex = 0;
            this.btnCreateGrade.Text = "Notas";
            this.btnCreateGrade.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCreateGrade.UseAccentColor = false;
            this.btnCreateGrade.UseVisualStyleBackColor = true;
            this.btnCreateGrade.Click += new System.EventHandler(this.btnCreateGrade_Click);
            // 
            // panelTreeView
            // 
            this.panelTreeView.Controls.Add(this.lsbStudents);
            this.panelTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTreeView.Location = new System.Drawing.Point(0, 0);
            this.panelTreeView.Margin = new System.Windows.Forms.Padding(0);
            this.panelTreeView.Name = "panelTreeView";
            this.panelTreeView.Size = new System.Drawing.Size(326, 213);
            this.panelTreeView.TabIndex = 4;
            // 
            // lsbStudents
            // 
            this.lsbStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbStudents.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lsbStudents.FormattingEnabled = true;
            this.lsbStudents.ItemHeight = 19;
            this.lsbStudents.Location = new System.Drawing.Point(0, 0);
            this.lsbStudents.Margin = new System.Windows.Forms.Padding(0);
            this.lsbStudents.Name = "lsbStudents";
            this.lsbStudents.Size = new System.Drawing.Size(326, 213);
            this.lsbStudents.TabIndex = 0;
            this.lsbStudents.SelectedIndexChanged += new System.EventHandler(this.lsbStudents_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cbbClassRoom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbbYear, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(307, 103);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Form_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 320);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Teacher";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escola Virtual";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Teacher_FormClosed);
            this.Load += new System.EventHandler(this.Form_Teacher_Load);
            this.menuAccount.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.tableLayoutPanelButtons.PerformLayout();
            this.panelTreeView.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnUser;
        private System.Windows.Forms.ContextMenuStrip menuAccount;
        private MaterialSkin.Controls.MaterialToolStripMenuItem materialToolStripItemAccount;
        private MaterialSkin.Controls.MaterialToolStripMenuItem materialToolStripItemNotification;
        private System.Windows.Forms.ToolStripSeparator Separator;
        private MaterialSkin.Controls.MaterialToolStripMenuItem materialToolStripItemLeave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private MaterialSkin.Controls.MaterialButton btnCreateGrade;
        private System.Windows.Forms.Panel panelTreeView;
        private System.Windows.Forms.ListBox lsbStudents;
        private MaterialSkin.Controls.MaterialComboBox cbbClassRoom;
        private MaterialSkin.Controls.MaterialComboBox cbbYear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}