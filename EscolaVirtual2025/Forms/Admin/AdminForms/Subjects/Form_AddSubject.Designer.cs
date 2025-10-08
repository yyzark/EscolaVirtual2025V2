namespace EscolaVirtual2025.Forms.Admin.AdminForms.Subjects
{
    partial class Form_AddSubject
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAbreviation = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnAccept = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.btnYears = new MaterialSkin.Controls.MaterialButton();
            this.panelMain.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tableLayoutPanelMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(2, 20);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.panelMain.Size = new System.Drawing.Size(396, 222);
            this.panelMain.TabIndex = 1;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.btnYears, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.txtName, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.txtAbreviation, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel13, 1, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(356, 182);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(3, 3);
            this.txtName.MaxLength = 16;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 50);
            this.txtName.TabIndex = 10;
            this.txtName.Text = "";
            this.txtName.TrailingIcon = null;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtAbreviation
            // 
            this.txtAbreviation.AnimateReadOnly = false;
            this.txtAbreviation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAbreviation.Depth = 0;
            this.txtAbreviation.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAbreviation.LeadingIcon = null;
            this.txtAbreviation.Location = new System.Drawing.Point(181, 3);
            this.txtAbreviation.MaxLength = 3;
            this.txtAbreviation.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAbreviation.Multiline = false;
            this.txtAbreviation.Name = "txtAbreviation";
            this.txtAbreviation.Size = new System.Drawing.Size(170, 50);
            this.txtAbreviation.TabIndex = 9;
            this.txtAbreviation.Text = "";
            this.txtAbreviation.TrailingIcon = null;
            this.txtAbreviation.TextChanged += new System.EventHandler(this.txtAbreviation_TextChanged);
            this.txtAbreviation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbreviation_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(4, 51);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(170, 34);
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
            this.btnAccept.Size = new System.Drawing.Size(170, 33);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Aceitar";
            this.btnAccept.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnAccept.UseAccentColor = false;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Controls.Add(this.btnAccept, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.btnCancel, 0, 1);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(178, 91);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(178, 91);
            this.tableLayoutPanel13.TabIndex = 7;
            // 
            // btnYears
            // 
            this.btnYears.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnYears.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnYears.Depth = 0;
            this.btnYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnYears.HighEmphasis = true;
            this.btnYears.Icon = null;
            this.btnYears.Location = new System.Drawing.Point(4, 97);
            this.btnYears.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnYears.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYears.Name = "btnYears";
            this.btnYears.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnYears.Size = new System.Drawing.Size(170, 79);
            this.btnYears.TabIndex = 11;
            this.btnYears.Text = "Editar anos";
            this.btnYears.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnYears.UseAccentColor = false;
            this.btnYears.UseVisualStyleBackColor = true;
            this.btnYears.Click += new System.EventHandler(this.btnYears_Click);
            // 
            // Form_AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 244);
            this.Controls.Add(this.panelMain);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_AddSubject";
            this.Padding = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.Text = "Form_AddSubject";
            this.Load += new System.EventHandler(this.Form_AddSubject_Load);
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
        private MaterialSkin.Controls.MaterialButton btnAccept;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private MaterialSkin.Controls.MaterialTextBox txtAbreviation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private MaterialSkin.Controls.MaterialButton btnYears;
    }
}