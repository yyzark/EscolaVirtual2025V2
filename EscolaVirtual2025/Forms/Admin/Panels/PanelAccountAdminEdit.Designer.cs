namespace EscolaVirtual2025.Forms.Admin.Panels
{
    partial class PanelAccountAdminEdit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbDetails = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnApply = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.txtUser = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox2();
            this.grbDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDetails
            // 
            this.grbDetails.Controls.Add(this.tableLayoutPanel1);
            this.grbDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetails.Location = new System.Drawing.Point(0, 0);
            this.grbDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grbDetails.Name = "grbDetails";
            this.grbDetails.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.grbDetails.Size = new System.Drawing.Size(451, 464);
            this.grbDetails.TabIndex = 1;
            this.grbDetails.TabStop = false;
            this.grbDetails.Text = "Detalhes";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 39);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(425, 413);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.HideSelection = true;
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(4, 210);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PrefixSuffixText = null;
            this.txtPassword.ReadOnly = false;
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(333, 48);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TabStop = false;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnApply, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnCancel, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 313);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(417, 96);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // btnApply
            // 
            this.btnApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApply.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnApply.Depth = 0;
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApply.HighEmphasis = true;
            this.btnApply.Icon = null;
            this.btnApply.Location = new System.Drawing.Point(213, 55);
            this.btnApply.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnApply.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnApply.Name = "btnApply";
            this.btnApply.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnApply.Size = new System.Drawing.Size(199, 34);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Aplicar";
            this.btnApply.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnApply.UseAccentColor = false;
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = false;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(5, 55);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(198, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtUser
            // 
            this.txtUser.AnimateReadOnly = false;
            this.txtUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUser.Depth = 0;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUser.HideSelection = true;
            this.txtUser.LeadingIcon = null;
            this.txtUser.Location = new System.Drawing.Point(4, 4);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.MaxLength = 32767;
            this.txtUser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PrefixSuffixText = null;
            this.txtUser.ReadOnly = false;
            this.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(333, 48);
            this.txtUser.TabIndex = 7;
            this.txtUser.TabStop = false;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.TrailingIcon = null;
            this.txtUser.UseSystemPasswordChar = false;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.HideSelection = true;
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(4, 107);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaxLength = 32767;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PrefixSuffixText = null;
            this.txtName.ReadOnly = false;
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(333, 48);
            this.txtName.TabIndex = 8;
            this.txtName.TabStop = false;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TrailingIcon = null;
            this.txtName.UseSystemPasswordChar = false;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // PanelAccountAdminEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.grbDetails);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PanelAccountAdminEdit";
            this.Size = new System.Drawing.Size(451, 464);
            this.Load += new System.EventHandler(this.PanelAccountAdminEdit_Load);
            this.VisibleChanged += new System.EventHandler(this.PanelAccountAdminEdit_VisibleChanged);
            this.grbDetails.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialButton btnApply;
        private MaterialSkin.Controls.MaterialTextBox2 txtPassword;
        private MaterialSkin.Controls.MaterialTextBox2 txtUser;
        private MaterialSkin.Controls.MaterialTextBox2 txtName;
    }
}
