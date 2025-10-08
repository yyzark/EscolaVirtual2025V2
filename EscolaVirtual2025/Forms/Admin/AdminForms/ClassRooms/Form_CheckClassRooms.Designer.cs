namespace EscolaVirtual2025.Forms.Admin.AdminForms.ClassRooms
{
    partial class Form_CheckClassRooms
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
            this.lsvCheckClassRoom = new System.Windows.Forms.ListView();
            this.clmClassRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnRemove = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvCheckClassRoom);
            this.panel1.Controls.Add(this.tableLayoutPanelButtons);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panel1.Size = new System.Drawing.Size(527, 404);
            this.panel1.TabIndex = 1;
            // 
            // lsvCheckClassRoom
            // 
            this.lsvCheckClassRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmClassRoom});
            this.lsvCheckClassRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvCheckClassRoom.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvCheckClassRoom.FullRowSelect = true;
            this.lsvCheckClassRoom.HideSelection = false;
            this.lsvCheckClassRoom.Location = new System.Drawing.Point(27, 25);
            this.lsvCheckClassRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsvCheckClassRoom.Name = "lsvCheckClassRoom";
            this.lsvCheckClassRoom.Scrollable = false;
            this.lsvCheckClassRoom.Size = new System.Drawing.Size(473, 305);
            this.lsvCheckClassRoom.TabIndex = 3;
            this.lsvCheckClassRoom.UseCompatibleStateImageBehavior = false;
            this.lsvCheckClassRoom.View = System.Windows.Forms.View.Details;
            this.lsvCheckClassRoom.SelectedIndexChanged += new System.EventHandler(this.lsvCheckClassRoom_SelectedIndexChanged);
            // 
            // clmClassRoom
            // 
            this.clmClassRoom.Text = "Turma:";
            this.clmClassRoom.Width = 472;
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
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(27, 330);
            this.tableLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 1;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(473, 49);
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
            this.btnAdd.Location = new System.Drawing.Point(5, 7);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(226, 35);
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
            this.btnRemove.Location = new System.Drawing.Point(241, 7);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemove.Size = new System.Drawing.Size(227, 35);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remover";
            this.btnRemove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnRemove.UseAccentColor = false;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form_CheckClassRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 431);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_CheckClassRooms";
            this.Padding = new System.Windows.Forms.Padding(3, 25, 3, 2);
            this.Sizable = false;
            this.Text = "Form_CheckClassRooms";
            this.Load += new System.EventHandler(this.Form_CheckClassRooms_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.tableLayoutPanelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lsvCheckClassRoom;
        private System.Windows.Forms.ColumnHeader clmClassRoom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnRemove;
    }
}