namespace EscolaVirtual2025.Forms.Admin.AdminForms.Teachers
{
    partial class Form_TeacherAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TeacherAdd));
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnClassRooms = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnAccept = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLogin = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNIF = new MaterialSkin.Controls.MaterialTextBox();
            this.panelMain.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tableLayoutPanelMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(3, 24);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(394, 373);
            this.panelMain.TabIndex = 2;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.txtNIF, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.txtName, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.txtPassword, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.txtLogin, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel13, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.btnClassRooms, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(354, 333);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // btnClassRooms
            // 
            this.btnClassRooms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClassRooms.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClassRooms.Depth = 0;
            this.btnClassRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClassRooms.HighEmphasis = true;
            this.btnClassRooms.Icon = null;
            this.btnClassRooms.Location = new System.Drawing.Point(4, 228);
            this.btnClassRooms.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClassRooms.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClassRooms.Name = "btnClassRooms";
            this.btnClassRooms.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClassRooms.Size = new System.Drawing.Size(169, 99);
            this.btnClassRooms.TabIndex = 11;
            this.btnClassRooms.Text = "Editar turmas";
            this.btnClassRooms.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnClassRooms.UseAccentColor = false;
            this.btnClassRooms.UseVisualStyleBackColor = true;
            this.btnClassRooms.Click += new System.EventHandler(this.btnClassRooms_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(4, 61);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(169, 44);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAccept.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAccept.Depth = 0;
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccept.Enabled = false;
            this.btnAccept.HighEmphasis = true;
            this.btnAccept.Icon = null;
            this.btnAccept.Location = new System.Drawing.Point(4, 6);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAccept.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAccept.Size = new System.Drawing.Size(169, 43);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Aceitar";
            this.btnAccept.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnAccept.UseAccentColor = false;
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Controls.Add(this.btnAccept, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.btnCancel, 0, 1);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(177, 222);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(177, 111);
            this.tableLayoutPanel13.TabIndex = 7;
            // 
            // txtLogin
            // 
            this.txtLogin.AnimateReadOnly = false;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Depth = 0;
            this.txtLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLogin.LeadingIcon = null;
            this.txtLogin.Location = new System.Drawing.Point(3, 3);
            this.txtLogin.MaxLength = 16;
            this.txtLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLogin.Multiline = false;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(171, 50);
            this.txtLogin.TabIndex = 12;
            this.txtLogin.Text = "";
            this.txtLogin.TrailingIcon = null;
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(180, 3);
            this.txtPassword.MaxLength = 16;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(171, 50);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Depth = 0;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(3, 114);
            this.txtName.MaxLength = 32;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 50);
            this.txtName.TabIndex = 14;
            this.txtName.Text = "";
            this.txtName.TrailingIcon = null;
            // 
            // txtNIF
            // 
            this.txtNIF.AnimateReadOnly = false;
            this.txtNIF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNIF.Depth = 0;
            this.txtNIF.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNIF.LeadingIcon = null;
            this.txtNIF.Location = new System.Drawing.Point(180, 114);
            this.txtNIF.MaxLength = 9;
            this.txtNIF.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNIF.Multiline = false;
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(171, 50);
            this.txtNIF.TabIndex = 15;
            this.txtNIF.Text = "";
            this.txtNIF.TrailingIcon = null;
            // 
            // Form_TeacherAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_TeacherAdd";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "Form_TeacherAdd";
            this.Load += new System.EventHandler(this.Form_TeacherAdd_Load);
            this.panelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private MaterialSkin.Controls.MaterialButton btnAccept;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnClassRooms;
        private MaterialSkin.Controls.MaterialTextBox txtLogin;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private MaterialSkin.Controls.MaterialTextBox txtNIF;
    }
}