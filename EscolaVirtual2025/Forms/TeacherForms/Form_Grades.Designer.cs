namespace EscolaVirtual2025.Forms.TeacherForms
{
    partial class Form_Grades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Grades));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbSecondPeriod = new System.Windows.Forms.GroupBox();
            this.grbFirstPeriod = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelPeriods = new System.Windows.Forms.TableLayoutPanel();
            this.grbThirdPeriod = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.txtStudentName = new MaterialSkin.Controls.MaterialLabel();
            this.btnNota1 = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanelNota1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNota1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtComent1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNota2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtComent2 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.btnNota2 = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNota3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtComent3 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.btnNota3 = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.grbSecondPeriod.SuspendLayout();
            this.grbFirstPeriod.SuspendLayout();
            this.tableLayoutPanelPeriods.SuspendLayout();
            this.grbThirdPeriod.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelNota1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanelMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(650, 376);
            this.panel1.TabIndex = 0;
            // 
            // grbSecondPeriod
            // 
            this.grbSecondPeriod.Controls.Add(this.tableLayoutPanel1);
            this.grbSecondPeriod.Controls.Add(this.btnNota2);
            this.grbSecondPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbSecondPeriod.Location = new System.Drawing.Point(206, 3);
            this.grbSecondPeriod.Name = "grbSecondPeriod";
            this.grbSecondPeriod.Size = new System.Drawing.Size(197, 270);
            this.grbSecondPeriod.TabIndex = 0;
            this.grbSecondPeriod.TabStop = false;
            this.grbSecondPeriod.Text = "2ºPeriodo";
            // 
            // grbFirstPeriod
            // 
            this.grbFirstPeriod.Controls.Add(this.tableLayoutPanelNota1);
            this.grbFirstPeriod.Controls.Add(this.btnNota1);
            this.grbFirstPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbFirstPeriod.Location = new System.Drawing.Point(3, 3);
            this.grbFirstPeriod.Name = "grbFirstPeriod";
            this.grbFirstPeriod.Size = new System.Drawing.Size(197, 270);
            this.grbFirstPeriod.TabIndex = 1;
            this.grbFirstPeriod.TabStop = false;
            this.grbFirstPeriod.Text = "1ºPeriodo";
            // 
            // tableLayoutPanelPeriods
            // 
            this.tableLayoutPanelPeriods.ColumnCount = 3;
            this.tableLayoutPanelPeriods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPeriods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPeriods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPeriods.Controls.Add(this.grbThirdPeriod, 2, 0);
            this.tableLayoutPanelPeriods.Controls.Add(this.grbSecondPeriod, 1, 0);
            this.tableLayoutPanelPeriods.Controls.Add(this.grbFirstPeriod, 0, 0);
            this.tableLayoutPanelPeriods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPeriods.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanelPeriods.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelPeriods.Name = "tableLayoutPanelPeriods";
            this.tableLayoutPanelPeriods.RowCount = 1;
            this.tableLayoutPanelPeriods.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPeriods.Size = new System.Drawing.Size(610, 276);
            this.tableLayoutPanelPeriods.TabIndex = 2;
            // 
            // grbThirdPeriod
            // 
            this.grbThirdPeriod.Controls.Add(this.tableLayoutPanel2);
            this.grbThirdPeriod.Controls.Add(this.btnNota3);
            this.grbThirdPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbThirdPeriod.Location = new System.Drawing.Point(409, 3);
            this.grbThirdPeriod.Name = "grbThirdPeriod";
            this.grbThirdPeriod.Size = new System.Drawing.Size(198, 270);
            this.grbThirdPeriod.TabIndex = 2;
            this.grbThirdPeriod.TabStop = false;
            this.grbThirdPeriod.Text = "3ºPeriodo";
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelPeriods, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.txtStudentName, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(610, 336);
            this.tableLayoutPanelMain.TabIndex = 3;
            // 
            // txtStudentName
            // 
            this.txtStudentName.AutoSize = true;
            this.txtStudentName.Depth = 0;
            this.txtStudentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStudentName.Location = new System.Drawing.Point(3, 0);
            this.txtStudentName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(604, 60);
            this.txtStudentName.TabIndex = 3;
            this.txtStudentName.Text = "Aluno: Nome";
            this.txtStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNota1
            // 
            this.btnNota1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNota1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNota1.Depth = 0;
            this.btnNota1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNota1.HighEmphasis = true;
            this.btnNota1.Icon = null;
            this.btnNota1.Location = new System.Drawing.Point(3, 231);
            this.btnNota1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNota1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNota1.Name = "btnNota1";
            this.btnNota1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNota1.Size = new System.Drawing.Size(191, 36);
            this.btnNota1.TabIndex = 0;
            this.btnNota1.Text = "Lançar Nota";
            this.btnNota1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNota1.UseAccentColor = false;
            this.btnNota1.UseVisualStyleBackColor = true;
            this.btnNota1.Click += new System.EventHandler(this.btnNota1_Click);
            // 
            // tableLayoutPanelNota1
            // 
            this.tableLayoutPanelNota1.ColumnCount = 1;
            this.tableLayoutPanelNota1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelNota1.Controls.Add(this.lblNota1, 0, 0);
            this.tableLayoutPanelNota1.Controls.Add(this.txtComent1, 0, 1);
            this.tableLayoutPanelNota1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelNota1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelNota1.Name = "tableLayoutPanelNota1";
            this.tableLayoutPanelNota1.RowCount = 2;
            this.tableLayoutPanelNota1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelNota1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelNota1.Size = new System.Drawing.Size(191, 215);
            this.tableLayoutPanelNota1.TabIndex = 1;
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Depth = 0;
            this.lblNota1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNota1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNota1.Location = new System.Drawing.Point(3, 0);
            this.lblNota1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(185, 60);
            this.lblNota1.TabIndex = 0;
            this.lblNota1.Text = "Nota: ";
            this.lblNota1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtComent1
            // 
            this.txtComent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtComent1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComent1.Depth = 0;
            this.txtComent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComent1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtComent1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtComent1.Location = new System.Drawing.Point(3, 63);
            this.txtComent1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtComent1.Name = "txtComent1";
            this.txtComent1.ReadOnly = true;
            this.txtComent1.Size = new System.Drawing.Size(185, 149);
            this.txtComent1.TabIndex = 1;
            this.txtComent1.Text = "Comentario";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblNota2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtComent2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(191, 215);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Depth = 0;
            this.lblNota2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNota2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNota2.Location = new System.Drawing.Point(3, 0);
            this.lblNota2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(185, 60);
            this.lblNota2.TabIndex = 0;
            this.lblNota2.Text = "Nota: Nota2";
            this.lblNota2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtComent2
            // 
            this.txtComent2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtComent2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComent2.Depth = 0;
            this.txtComent2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComent2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtComent2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtComent2.Location = new System.Drawing.Point(3, 63);
            this.txtComent2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtComent2.Name = "txtComent2";
            this.txtComent2.ReadOnly = true;
            this.txtComent2.Size = new System.Drawing.Size(185, 149);
            this.txtComent2.TabIndex = 1;
            this.txtComent2.Text = "Comentario";
            // 
            // btnNota2
            // 
            this.btnNota2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNota2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNota2.Depth = 0;
            this.btnNota2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNota2.HighEmphasis = true;
            this.btnNota2.Icon = null;
            this.btnNota2.Location = new System.Drawing.Point(3, 231);
            this.btnNota2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNota2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNota2.Name = "btnNota2";
            this.btnNota2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNota2.Size = new System.Drawing.Size(191, 36);
            this.btnNota2.TabIndex = 2;
            this.btnNota2.Text = "Lançar Nota";
            this.btnNota2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNota2.UseAccentColor = false;
            this.btnNota2.UseVisualStyleBackColor = true;
            this.btnNota2.Click += new System.EventHandler(this.btnNota2_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblNota3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtComent3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(192, 215);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Depth = 0;
            this.lblNota3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNota3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNota3.Location = new System.Drawing.Point(3, 0);
            this.lblNota3.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(186, 60);
            this.lblNota3.TabIndex = 0;
            this.lblNota3.Text = "Nota: Nota3";
            this.lblNota3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtComent3
            // 
            this.txtComent3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtComent3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComent3.Depth = 0;
            this.txtComent3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComent3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtComent3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtComent3.Location = new System.Drawing.Point(3, 63);
            this.txtComent3.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtComent3.Name = "txtComent3";
            this.txtComent3.ReadOnly = true;
            this.txtComent3.Size = new System.Drawing.Size(186, 149);
            this.txtComent3.TabIndex = 1;
            this.txtComent3.Text = "Comentario";
            // 
            // btnNota3
            // 
            this.btnNota3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNota3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNota3.Depth = 0;
            this.btnNota3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNota3.HighEmphasis = true;
            this.btnNota3.Icon = null;
            this.btnNota3.Location = new System.Drawing.Point(3, 231);
            this.btnNota3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNota3.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNota3.Name = "btnNota3";
            this.btnNota3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNota3.Size = new System.Drawing.Size(192, 36);
            this.btnNota3.TabIndex = 2;
            this.btnNota3.Text = "Lançar Nota";
            this.btnNota3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNota3.UseAccentColor = false;
            this.btnNota3.UseVisualStyleBackColor = true;
            this.btnNota3.Click += new System.EventHandler(this.btnNota3_Click);
            // 
            // Form_Grades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Grades";
            this.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.Sizable = false;
            this.Text = "Form_Grades";
            this.Load += new System.EventHandler(this.Form_Grades_Load);
            this.panel1.ResumeLayout(false);
            this.grbSecondPeriod.ResumeLayout(false);
            this.grbSecondPeriod.PerformLayout();
            this.grbFirstPeriod.ResumeLayout(false);
            this.grbFirstPeriod.PerformLayout();
            this.tableLayoutPanelPeriods.ResumeLayout(false);
            this.grbThirdPeriod.ResumeLayout(false);
            this.grbThirdPeriod.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.tableLayoutPanelNota1.ResumeLayout(false);
            this.tableLayoutPanelNota1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPeriods;
        private System.Windows.Forms.GroupBox grbThirdPeriod;
        private System.Windows.Forms.GroupBox grbSecondPeriod;
        private System.Windows.Forms.GroupBox grbFirstPeriod;
        private MaterialSkin.Controls.MaterialLabel txtStudentName;
        private MaterialSkin.Controls.MaterialButton btnNota1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNota1;
        private MaterialSkin.Controls.MaterialLabel lblNota1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtComent1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel lblNota3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtComent3;
        private MaterialSkin.Controls.MaterialButton btnNota3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel lblNota2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtComent2;
        private MaterialSkin.Controls.MaterialButton btnNota2;
    }
}