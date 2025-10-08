namespace EscolaVirtual2025.Forms.Admin.AdminForms.Subjects
{
    partial class Form_SubjectsCheck
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbbAno = new System.Windows.Forms.ComboBox();
            this.lsvCheckSubject = new System.Windows.Forms.ListView();
            this.clmClassRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmClassRoomName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnRemove = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.tableLayoutPanelButtons);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(396, 328);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cbbAno, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lsvCheckSubject, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 248);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // cbbAno
            // 
            this.cbbAno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAno.FormattingEnabled = true;
            this.cbbAno.Location = new System.Drawing.Point(2, 2);
            this.cbbAno.Margin = new System.Windows.Forms.Padding(2);
            this.cbbAno.Name = "cbbAno";
            this.cbbAno.Size = new System.Drawing.Size(352, 21);
            this.cbbAno.TabIndex = 0;
            this.cbbAno.SelectedIndexChanged += new System.EventHandler(this.cbbAno_SelectedIndexChanged);
            // 
            // lsvCheckSubject
            // 
            this.lsvCheckSubject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmClassRoom,
            this.clmClassRoomName});
            this.lsvCheckSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvCheckSubject.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvCheckSubject.FullRowSelect = true;
            this.lsvCheckSubject.HideSelection = false;
            this.lsvCheckSubject.Location = new System.Drawing.Point(3, 23);
            this.lsvCheckSubject.Name = "lsvCheckSubject";
            this.lsvCheckSubject.Scrollable = false;
            this.lsvCheckSubject.Size = new System.Drawing.Size(350, 222);
            this.lsvCheckSubject.TabIndex = 3;
            this.lsvCheckSubject.UseCompatibleStateImageBehavior = false;
            this.lsvCheckSubject.View = System.Windows.Forms.View.Details;
            // 
            // clmClassRoom
            // 
            this.clmClassRoom.Text = "Id";
            this.clmClassRoom.Width = 223;
            // 
            // clmClassRoomName
            // 
            this.clmClassRoomName.Text = "Nome";
            this.clmClassRoomName.Width = 220;
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 3;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Controls.Add(this.btnAdd, 1, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btnRemove, 2, 0);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(20, 268);
            this.tableLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 1;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(356, 40);
            this.tableLayoutPanelButtons.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(4, 6);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(170, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRemove.Depth = 0;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.HighEmphasis = true;
            this.btnRemove.Icon = null;
            this.btnRemove.Location = new System.Drawing.Point(182, 6);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemove.Size = new System.Drawing.Size(170, 28);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remover";
            this.btnRemove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnRemove.UseAccentColor = false;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form_SubjectsCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_SubjectsCheck";
            this.Padding = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.Text = "Form_SubjectsCheck";
            this.Load += new System.EventHandler(this.Form_SubjectsCheck_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.tableLayoutPanelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lsvCheckSubject;
        private System.Windows.Forms.ColumnHeader clmClassRoom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnRemove;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbbAno;
        private System.Windows.Forms.ColumnHeader clmClassRoomName;
    }
}