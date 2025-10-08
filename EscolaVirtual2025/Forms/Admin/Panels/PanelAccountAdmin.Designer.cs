namespace EscolaVirtual2025.Forms.Admin
{
    partial class PanelAccountAdmin
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
            this.lblUser = new MaterialSkin.Controls.MaterialLabel();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPassword = new MaterialSkin.Controls.MaterialLabel();
            this.btnShowPassword = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserType = new MaterialSkin.Controls.MaterialLabel();
            this.btnEditUser = new MaterialSkin.Controls.MaterialButton();
            this.grbDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDetails
            // 
            this.grbDetails.BackColor = System.Drawing.SystemColors.Control;
            this.grbDetails.Controls.Add(this.tableLayoutPanel1);
            this.grbDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetails.Location = new System.Drawing.Point(0, 0);
            this.grbDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbDetails.Name = "grbDetails";
            this.grbDetails.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.grbDetails.Size = new System.Drawing.Size(453, 466);
            this.grbDetails.TabIndex = 0;
            this.grbDetails.TabStop = false;
            this.grbDetails.Text = "Detalhes";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 39);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(427, 415);
            this.tableLayoutPanel1.TabIndex = 5;
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
            this.lblUser.Size = new System.Drawing.Size(419, 103);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Utilizador";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblName.Location = new System.Drawing.Point(4, 103);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(419, 103);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nome";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.Controls.Add(this.lblPassword, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnShowPassword, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 210);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(419, 95);
            this.tableLayoutPanel2.TabIndex = 5;
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
            this.lblPassword.Size = new System.Drawing.Size(278, 95);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.AutoSize = false;
            this.btnShowPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowPassword.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnShowPassword.Depth = 0;
            this.btnShowPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnShowPassword.HighEmphasis = true;
            this.btnShowPassword.Icon = null;
            this.btnShowPassword.Location = new System.Drawing.Point(291, 44);
            this.btnShowPassword.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnShowPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnShowPassword.Size = new System.Drawing.Size(123, 44);
            this.btnShowPassword.TabIndex = 4;
            this.btnShowPassword.Text = "Mostrar";
            this.btnShowPassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnShowPassword.UseAccentColor = false;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            this.btnShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowPassword_MouseDown);
            this.btnShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowPassword_MouseUp);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel3.Controls.Add(this.lblUserType, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnEditUser, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 313);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(419, 98);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Depth = 0;
            this.lblUserType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserType.Location = new System.Drawing.Point(4, 0);
            this.lblUserType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(278, 98);
            this.lblUserType.TabIndex = 4;
            this.lblUserType.Text = "Cargo:";
            this.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEditUser
            // 
            this.btnEditUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditUser.Depth = 0;
            this.btnEditUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditUser.HighEmphasis = true;
            this.btnEditUser.Icon = null;
            this.btnEditUser.Location = new System.Drawing.Point(291, 55);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnEditUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditUser.Size = new System.Drawing.Size(123, 36);
            this.btnEditUser.TabIndex = 5;
            this.btnEditUser.Text = "Editar";
            this.btnEditUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditUser.UseAccentColor = false;
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // PanelAccountAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.grbDetails);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PanelAccountAdmin";
            this.Size = new System.Drawing.Size(453, 466);
            this.Tag = "pnl";
            this.Load += new System.EventHandler(this.PanelAccountAdmin_Load);
            this.VisibleChanged += new System.EventHandler(this.PanelAccountAdmin_VisibleChanged);
            this.grbDetails.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDetails;
        private MaterialSkin.Controls.MaterialLabel lblUser;
        private MaterialSkin.Controls.MaterialLabel lblPassword;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialLabel lblUserType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialButton btnShowPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialButton btnEditUser;
    }
}
