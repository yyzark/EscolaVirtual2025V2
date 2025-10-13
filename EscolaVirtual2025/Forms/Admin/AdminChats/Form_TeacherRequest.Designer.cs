namespace EscolaVirtual2025.Forms.Admin.AdminChats
{
    partial class Form_TeacherRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TeacherRequest));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAccept = new MaterialSkin.Controls.MaterialButton();
            this.btnReject = new MaterialSkin.Controls.MaterialButton();
            this.grbTo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNewClassRooms = new MaterialSkin.Controls.MaterialButton();
            this.lblNewNif = new MaterialSkin.Controls.MaterialLabel();
            this.lblAssignedSubject = new MaterialSkin.Controls.MaterialLabel();
            this.lblNewPassword = new MaterialSkin.Controls.MaterialLabel();
            this.lblNewLogin = new MaterialSkin.Controls.MaterialLabel();
            this.lblNewName = new MaterialSkin.Controls.MaterialLabel();
            this.grbFrom = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClassRooms = new MaterialSkin.Controls.MaterialButton();
            this.lblNif = new MaterialSkin.Controls.MaterialLabel();
            this.lblDisc = new MaterialSkin.Controls.MaterialLabel();
            this.lblPassword = new MaterialSkin.Controls.MaterialLabel();
            this.lblUser = new MaterialSkin.Controls.MaterialLabel();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.grbTo.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.grbFrom.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAccept, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnReject, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grbTo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.grbFrom, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 441);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnAccept
            // 
            this.btnAccept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAccept.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAccept.Depth = 0;
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccept.HighEmphasis = true;
            this.btnAccept.Icon = null;
            this.btnAccept.Location = new System.Drawing.Point(401, 407);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAccept.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAccept.Size = new System.Drawing.Size(389, 28);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Text = "Aprovar";
            this.btnAccept.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnAccept.UseAccentColor = false;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnReject
            // 
            this.btnReject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReject.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReject.Depth = 0;
            this.btnReject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReject.HighEmphasis = true;
            this.btnReject.Icon = null;
            this.btnReject.Location = new System.Drawing.Point(4, 407);
            this.btnReject.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReject.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReject.Name = "btnReject";
            this.btnReject.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReject.Size = new System.Drawing.Size(389, 28);
            this.btnReject.TabIndex = 6;
            this.btnReject.Text = "Recusar";
            this.btnReject.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnReject.UseAccentColor = false;
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // grbTo
            // 
            this.grbTo.BackColor = System.Drawing.SystemColors.Control;
            this.grbTo.Controls.Add(this.tableLayoutPanel3);
            this.grbTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbTo.Location = new System.Drawing.Point(400, 3);
            this.grbTo.Name = "grbTo";
            this.grbTo.Padding = new System.Windows.Forms.Padding(10);
            this.grbTo.Size = new System.Drawing.Size(391, 395);
            this.grbTo.TabIndex = 3;
            this.grbTo.TabStop = false;
            this.grbTo.Text = "Para";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnNewClassRooms, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblNewNif, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblAssignedSubject, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblNewPassword, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblNewLogin, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblNewName, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 36);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(371, 349);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // btnNewClassRooms
            // 
            this.btnNewClassRooms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewClassRooms.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNewClassRooms.Depth = 0;
            this.btnNewClassRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewClassRooms.HighEmphasis = true;
            this.btnNewClassRooms.Icon = null;
            this.btnNewClassRooms.Location = new System.Drawing.Point(4, 291);
            this.btnNewClassRooms.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNewClassRooms.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNewClassRooms.Name = "btnNewClassRooms";
            this.btnNewClassRooms.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNewClassRooms.Size = new System.Drawing.Size(363, 52);
            this.btnNewClassRooms.TabIndex = 8;
            this.btnNewClassRooms.Text = "Turmas";
            this.btnNewClassRooms.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnNewClassRooms.UseAccentColor = false;
            this.btnNewClassRooms.UseVisualStyleBackColor = true;
            this.btnNewClassRooms.Click += new System.EventHandler(this.btnNewClassRooms_Click);
            // 
            // lblNewNif
            // 
            this.lblNewNif.AutoSize = true;
            this.lblNewNif.Depth = 0;
            this.lblNewNif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewNif.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNewNif.Location = new System.Drawing.Point(3, 228);
            this.lblNewNif.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNewNif.Name = "lblNewNif";
            this.lblNewNif.Size = new System.Drawing.Size(365, 57);
            this.lblNewNif.TabIndex = 5;
            this.lblNewNif.Text = "Nif:";
            this.lblNewNif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAssignedSubject
            // 
            this.lblAssignedSubject.AutoSize = true;
            this.lblAssignedSubject.Depth = 0;
            this.lblAssignedSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAssignedSubject.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAssignedSubject.Location = new System.Drawing.Point(3, 171);
            this.lblAssignedSubject.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAssignedSubject.Name = "lblAssignedSubject";
            this.lblAssignedSubject.Size = new System.Drawing.Size(365, 57);
            this.lblAssignedSubject.TabIndex = 4;
            this.lblAssignedSubject.Text = "Disciplina:";
            this.lblAssignedSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Depth = 0;
            this.lblNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNewPassword.Location = new System.Drawing.Point(3, 114);
            this.lblNewPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(365, 57);
            this.lblNewPassword.TabIndex = 3;
            this.lblNewPassword.Text = "Password:";
            this.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNewLogin
            // 
            this.lblNewLogin.AutoSize = true;
            this.lblNewLogin.Depth = 0;
            this.lblNewLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewLogin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNewLogin.Location = new System.Drawing.Point(3, 0);
            this.lblNewLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNewLogin.Name = "lblNewLogin";
            this.lblNewLogin.Size = new System.Drawing.Size(365, 57);
            this.lblNewLogin.TabIndex = 1;
            this.lblNewLogin.Text = "Utilizador:";
            this.lblNewLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Depth = 0;
            this.lblNewName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNewName.Location = new System.Drawing.Point(3, 57);
            this.lblNewName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(365, 57);
            this.lblNewName.TabIndex = 2;
            this.lblNewName.Text = "Nome:";
            this.lblNewName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbFrom
            // 
            this.grbFrom.BackColor = System.Drawing.SystemColors.Control;
            this.grbFrom.Controls.Add(this.tableLayoutPanel2);
            this.grbFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbFrom.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbFrom.Location = new System.Drawing.Point(3, 3);
            this.grbFrom.Name = "grbFrom";
            this.grbFrom.Padding = new System.Windows.Forms.Padding(10);
            this.grbFrom.Size = new System.Drawing.Size(391, 395);
            this.grbFrom.TabIndex = 2;
            this.grbFrom.TabStop = false;
            this.grbFrom.Text = "De";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnClassRooms, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblNif, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblDisc, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblPassword, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblUser, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 36);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(371, 349);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btnClassRooms
            // 
            this.btnClassRooms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClassRooms.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClassRooms.Depth = 0;
            this.btnClassRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClassRooms.HighEmphasis = true;
            this.btnClassRooms.Icon = null;
            this.btnClassRooms.Location = new System.Drawing.Point(4, 291);
            this.btnClassRooms.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClassRooms.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClassRooms.Name = "btnClassRooms";
            this.btnClassRooms.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClassRooms.Size = new System.Drawing.Size(363, 52);
            this.btnClassRooms.TabIndex = 8;
            this.btnClassRooms.Text = "Turmas";
            this.btnClassRooms.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnClassRooms.UseAccentColor = false;
            this.btnClassRooms.UseVisualStyleBackColor = true;
            this.btnClassRooms.Click += new System.EventHandler(this.btnClassRooms_Click);
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Depth = 0;
            this.lblNif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNif.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNif.Location = new System.Drawing.Point(3, 228);
            this.lblNif.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(365, 57);
            this.lblNif.TabIndex = 5;
            this.lblNif.Text = "Nif:";
            this.lblNif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.Depth = 0;
            this.lblDisc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisc.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDisc.Location = new System.Drawing.Point(3, 171);
            this.lblDisc.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(365, 57);
            this.lblDisc.TabIndex = 4;
            this.lblDisc.Text = "Disciplina:";
            this.lblDisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Depth = 0;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPassword.Location = new System.Drawing.Point(3, 114);
            this.lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(365, 57);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Depth = 0;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUser.Location = new System.Drawing.Point(3, 0);
            this.lblUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(365, 57);
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
            this.lblName.Location = new System.Drawing.Point(3, 57);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(365, 57);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nome:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_TeacherRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_TeacherRequest";
            this.Sizable = false;
            this.Text = "Form_TeacherRequest";
            this.Load += new System.EventHandler(this.Form_TeacherRequest_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grbTo.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.grbFrom.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnAccept;
        private MaterialSkin.Controls.MaterialButton btnReject;
        private System.Windows.Forms.GroupBox grbTo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialLabel lblNewNif;
        private MaterialSkin.Controls.MaterialLabel lblAssignedSubject;
        private MaterialSkin.Controls.MaterialLabel lblNewPassword;
        private MaterialSkin.Controls.MaterialLabel lblNewLogin;
        private MaterialSkin.Controls.MaterialLabel lblNewName;
        private System.Windows.Forms.GroupBox grbFrom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel lblNif;
        private MaterialSkin.Controls.MaterialLabel lblDisc;
        private MaterialSkin.Controls.MaterialLabel lblPassword;
        private MaterialSkin.Controls.MaterialLabel lblUser;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialButton btnNewClassRooms;
        private MaterialSkin.Controls.MaterialButton btnClassRooms;
    }
}