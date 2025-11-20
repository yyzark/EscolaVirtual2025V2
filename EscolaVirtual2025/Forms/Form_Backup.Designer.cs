namespace EscolaVirtual2025.Forms
{
    partial class Form_Backup
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnPath = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnLoad = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(23, 47);
            this.txtPath.MaxLength = 16;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(330, 31);
            this.txtPath.TabIndex = 4;
            // 
            // btnPath
            // 
            this.btnPath.AutoSize = false;
            this.btnPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPath.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPath.Depth = 0;
            this.btnPath.HighEmphasis = true;
            this.btnPath.Icon = null;
            this.btnPath.Location = new System.Drawing.Point(360, 47);
            this.btnPath.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPath.Name = "btnPath";
            this.btnPath.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPath.Size = new System.Drawing.Size(116, 31);
            this.btnPath.TabIndex = 7;
            this.btnPath.Text = "Caminho";
            this.btnPath.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnPath.UseAccentColor = false;
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(23, 87);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(116, 31);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Salvar";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.AutoSize = false;
            this.btnLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLoad.Depth = 0;
            this.btnLoad.HighEmphasis = true;
            this.btnLoad.Icon = null;
            this.btnLoad.Location = new System.Drawing.Point(147, 87);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLoad.Size = new System.Drawing.Size(116, 31);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Carregar";
            this.btnLoad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnLoad.UseAccentColor = false;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form_Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 144);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPath);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "Form_Backup";
            this.Padding = new System.Windows.Forms.Padding(20, 44, 20, 20);
            this.Sizable = false;
            this.Text = "Form_Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private MaterialSkin.Controls.MaterialButton btnPath;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnLoad;
    }
}