namespace EscolaVirtual2025.Forms.StudentsForms
{
    partial class Form_Student
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Student));
            this.panelMain = new System.Windows.Forms.Panel();
            this.paneInfo = new System.Windows.Forms.Panel();
            this.panelAvaliation = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grbDetails = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUser = new MaterialSkin.Controls.MaterialLabel();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPassword = new MaterialSkin.Controls.MaterialLabel();
            this.btnShowPassword = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblClassRoom = new MaterialSkin.Controls.MaterialLabel();
            this.btnEditUser = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeposit = new MaterialSkin.Controls.MaterialButton();
            this.lblSaldo = new MaterialSkin.Controls.MaterialLabel();
            this.lblcardNumber = new MaterialSkin.Controls.MaterialLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tmsCartãoEscolar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsAvaliation = new System.Windows.Forms.ToolStripMenuItem();
            this.ºPeriodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ºPeriodoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ºPeriodoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNotifications = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUser = new MaterialSkin.Controls.MaterialButton();
            this.menuAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Separator = new System.Windows.Forms.ToolStripSeparator();
            this.materialToolStripItemLeave = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelMain.SuspendLayout();
            this.paneInfo.SuspendLayout();
            this.panelAvaliation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.grbDetails.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.paneInfo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMain.Location = new System.Drawing.Point(180, 79);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(887, 475);
            this.panelMain.TabIndex = 5;
            // 
            // paneInfo
            // 
            this.paneInfo.Controls.Add(this.tableLayoutPanel1);
            this.paneInfo.Controls.Add(this.panelAvaliation);
            this.paneInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneInfo.Location = new System.Drawing.Point(0, 0);
            this.paneInfo.Margin = new System.Windows.Forms.Padding(0);
            this.paneInfo.Name = "paneInfo";
            this.paneInfo.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.paneInfo.Size = new System.Drawing.Size(887, 475);
            this.paneInfo.TabIndex = 2;
            // 
            // panelAvaliation
            // 
            this.panelAvaliation.Controls.Add(this.chart1);
            this.panelAvaliation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAvaliation.Location = new System.Drawing.Point(27, 25);
            this.panelAvaliation.Margin = new System.Windows.Forms.Padding(0);
            this.panelAvaliation.Name = "panelAvaliation";
            this.panelAvaliation.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panelAvaliation.Size = new System.Drawing.Size(833, 425);
            this.panelAvaliation.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(27, 25);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "1ºPeriodo";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(779, 375);
            this.chart1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.grbDetails, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 25);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(833, 425);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // grbDetails
            // 
            this.grbDetails.BackColor = System.Drawing.SystemColors.Control;
            this.grbDetails.Controls.Add(this.tableLayoutPanel2);
            this.grbDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDetails.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbDetails.Location = new System.Drawing.Point(31, 29);
            this.grbDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbDetails.Name = "grbDetails";
            this.grbDetails.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.grbDetails.Size = new System.Drawing.Size(381, 367);
            this.grbDetails.TabIndex = 1;
            this.grbDetails.TabStop = false;
            this.grbDetails.Text = "Detalhes";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblUser, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 45);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(355, 310);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Depth = 0;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUser.Location = new System.Drawing.Point(4, 0);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(347, 77);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Utilizador:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblName.Location = new System.Drawing.Point(4, 77);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(347, 77);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nome:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel3.Controls.Add(this.lblPassword, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnShowPassword, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 158);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(347, 69);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Depth = 0;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPassword.Location = new System.Drawing.Point(4, 0);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(206, 69);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.AutoSize = false;
            this.btnShowPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowPassword.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnShowPassword.Depth = 0;
            this.btnShowPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowPassword.HighEmphasis = true;
            this.btnShowPassword.Icon = null;
            this.btnShowPassword.Location = new System.Drawing.Point(219, 7);
            this.btnShowPassword.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnShowPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnShowPassword.Size = new System.Drawing.Size(123, 55);
            this.btnShowPassword.TabIndex = 4;
            this.btnShowPassword.Text = "Mostrar";
            this.btnShowPassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnShowPassword.UseAccentColor = false;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            this.btnShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowPassword_MouseDown);
            this.btnShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowPassword_MouseUp);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel4.Controls.Add(this.lblClassRoom, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnEditUser, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 235);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(347, 71);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // lblClassRoom
            // 
            this.lblClassRoom.AutoSize = true;
            this.lblClassRoom.Depth = 0;
            this.lblClassRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClassRoom.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblClassRoom.Location = new System.Drawing.Point(4, 0);
            this.lblClassRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblClassRoom.Name = "lblClassRoom";
            this.lblClassRoom.Size = new System.Drawing.Size(206, 71);
            this.lblClassRoom.TabIndex = 4;
            this.lblClassRoom.Text = "Turma:";
            this.lblClassRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEditUser
            // 
            this.btnEditUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditUser.Depth = 0;
            this.btnEditUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditUser.HighEmphasis = true;
            this.btnEditUser.Icon = null;
            this.btnEditUser.Location = new System.Drawing.Point(219, 7);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnEditUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditUser.Size = new System.Drawing.Size(123, 57);
            this.btnEditUser.TabIndex = 5;
            this.btnEditUser.Text = "Editar";
            this.btnEditUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditUser.UseAccentColor = false;
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(416, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.groupBox1.Size = new System.Drawing.Size(390, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cartão escolar";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.btnDeposit, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.lblSaldo, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblcardNumber, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(27, 58);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(336, 292);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // btnDeposit
            // 
            this.btnDeposit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeposit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeposit.Depth = 0;
            this.btnDeposit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeposit.HighEmphasis = true;
            this.btnDeposit.Icon = null;
            this.btnDeposit.Location = new System.Drawing.Point(5, 226);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnDeposit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeposit.Size = new System.Drawing.Size(326, 59);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Depósitar";
            this.btnDeposit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeposit.UseAccentColor = false;
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Depth = 0;
            this.lblSaldo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSaldo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSaldo.Location = new System.Drawing.Point(4, 98);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(4, 25, 4, 0);
            this.lblSaldo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(328, 48);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "Saldo:";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblcardNumber
            // 
            this.lblcardNumber.AutoSize = true;
            this.lblcardNumber.Depth = 0;
            this.lblcardNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblcardNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblcardNumber.Location = new System.Drawing.Point(4, 0);
            this.lblcardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcardNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblcardNumber.Name = "lblcardNumber";
            this.lblcardNumber.Size = new System.Drawing.Size(328, 73);
            this.lblcardNumber.TabIndex = 0;
            this.lblcardNumber.Text = "N:";
            this.lblcardNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsCartãoEscolar,
            this.tmsAvaliation,
            this.tsmiNotifications});
            this.menuStrip1.Location = new System.Drawing.Point(0, 79);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(196, 475);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tmsCartãoEscolar
            // 
            this.tmsCartãoEscolar.ForeColor = System.Drawing.Color.White;
            this.tmsCartãoEscolar.Image = global::EscolaVirtual2025.Properties.Resources.home__1_;
            this.tmsCartãoEscolar.Name = "tmsCartãoEscolar";
            this.tmsCartãoEscolar.Size = new System.Drawing.Size(179, 37);
            this.tmsCartãoEscolar.Text = "Principal";
            this.tmsCartãoEscolar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tmsCartãoEscolar.Click += new System.EventHandler(this.tmsCartãoEscolar_Click);
            // 
            // tmsAvaliation
            // 
            this.tmsAvaliation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ºPeriodoToolStripMenuItem,
            this.ºPeriodoToolStripMenuItem1,
            this.ºPeriodoToolStripMenuItem2});
            this.tmsAvaliation.ForeColor = System.Drawing.Color.White;
            this.tmsAvaliation.Image = global::EscolaVirtual2025.Properties.Resources.check_list;
            this.tmsAvaliation.Name = "tmsAvaliation";
            this.tmsAvaliation.Size = new System.Drawing.Size(179, 37);
            this.tmsAvaliation.Text = "Avaliações";
            this.tmsAvaliation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ºPeriodoToolStripMenuItem
            // 
            this.ºPeriodoToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ºPeriodoToolStripMenuItem.Name = "ºPeriodoToolStripMenuItem";
            this.ºPeriodoToolStripMenuItem.Size = new System.Drawing.Size(182, 28);
            this.ºPeriodoToolStripMenuItem.Text = "1ºPeriodo";
            this.ºPeriodoToolStripMenuItem.Click += new System.EventHandler(this.ºPeriodoToolStripMenuItem_Click);
            // 
            // ºPeriodoToolStripMenuItem1
            // 
            this.ºPeriodoToolStripMenuItem1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ºPeriodoToolStripMenuItem1.Name = "ºPeriodoToolStripMenuItem1";
            this.ºPeriodoToolStripMenuItem1.Size = new System.Drawing.Size(182, 28);
            this.ºPeriodoToolStripMenuItem1.Text = "2ºPeriodo";
            this.ºPeriodoToolStripMenuItem1.Click += new System.EventHandler(this.ºPeriodoToolStripMenuItem1_Click);
            // 
            // ºPeriodoToolStripMenuItem2
            // 
            this.ºPeriodoToolStripMenuItem2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ºPeriodoToolStripMenuItem2.Name = "ºPeriodoToolStripMenuItem2";
            this.ºPeriodoToolStripMenuItem2.Size = new System.Drawing.Size(182, 28);
            this.ºPeriodoToolStripMenuItem2.Text = "3ºPeriodo";
            this.ºPeriodoToolStripMenuItem2.Click += new System.EventHandler(this.ºPeriodoToolStripMenuItem2_Click);
            // 
            // tsmiNotifications
            // 
            this.tsmiNotifications.ForeColor = System.Drawing.Color.White;
            this.tsmiNotifications.Image = global::EscolaVirtual2025.Properties.Resources.notification;
            this.tsmiNotifications.Name = "tsmiNotifications";
            this.tsmiNotifications.Size = new System.Drawing.Size(179, 37);
            this.tsmiNotifications.Text = "Notificações";
            this.tsmiNotifications.Click += new System.EventHandler(this.tsmiNotifications_Click);
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
            this.btnUser.Location = new System.Drawing.Point(857, 30);
            this.btnUser.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnUser.MinimumSize = new System.Drawing.Size(213, 48);
            this.btnUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUser.Name = "btnUser";
            this.btnUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUser.Size = new System.Drawing.Size(213, 49);
            this.btnUser.TabIndex = 6;
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
            this.Separator,
            this.materialToolStripItemLeave,
            this.toolStripSeparator});
            this.menuAccount.Name = "menuAccount";
            this.menuAccount.Size = new System.Drawing.Size(160, 69);
            this.menuAccount.VisibleChanged += new System.EventHandler(this.menuAccount_VisibleChanged);
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
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "YOOOOO";
            this.notifyIcon.Visible = true;
            // 
            // Form_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "Form_Student";
            this.Padding = new System.Windows.Forms.Padding(0, 79, 0, 0);
            this.Sizable = false;
            this.Text = "Escola Virtual";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Student_FormClosed);
            this.Load += new System.EventHandler(this.Form_Student_Load);
            this.panelMain.ResumeLayout(false);
            this.paneInfo.ResumeLayout(false);
            this.panelAvaliation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grbDetails.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuAccount.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private MaterialSkin.Controls.MaterialButton btnUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmsCartãoEscolar;
        private System.Windows.Forms.ToolStripMenuItem tmsAvaliation;
        private System.Windows.Forms.Panel panelAvaliation;
        private System.Windows.Forms.ToolStripMenuItem ºPeriodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ºPeriodoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ºPeriodoToolStripMenuItem2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ContextMenuStrip menuAccount;
        private System.Windows.Forms.ToolStripSeparator Separator;
        private MaterialSkin.Controls.MaterialToolStripMenuItem materialToolStripItemLeave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Panel paneInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btnDeposit;
        private MaterialSkin.Controls.MaterialLabel lblSaldo;
        private MaterialSkin.Controls.MaterialLabel lblcardNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem tsmiNotifications;
        private System.Windows.Forms.GroupBox grbDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel lblUser;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialLabel lblPassword;
        private MaterialSkin.Controls.MaterialButton btnShowPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialLabel lblClassRoom;
        private MaterialSkin.Controls.MaterialButton btnEditUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}