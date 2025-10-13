namespace EscolaVirtual2025.Forms.StudentsForms.StudentChat
{
    partial class Form_StudentChats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_StudentChats));
            this.lsbChats = new MaterialSkin.Controls.MaterialListBox();
            this.SuspendLayout();
            // 
            // lsbChats
            // 
            this.lsbChats.BackColor = System.Drawing.Color.White;
            this.lsbChats.BorderColor = System.Drawing.Color.LightGray;
            this.lsbChats.Depth = 0;
            this.lsbChats.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lsbChats.Location = new System.Drawing.Point(23, 47);
            this.lsbChats.MouseState = MaterialSkin.MouseState.HOVER;
            this.lsbChats.Name = "lsbChats";
            this.lsbChats.SelectedIndex = -1;
            this.lsbChats.SelectedItem = null;
            this.lsbChats.Size = new System.Drawing.Size(294, 270);
            this.lsbChats.TabIndex = 0;
            this.lsbChats.DoubleClick += new System.EventHandler(this.lsbChats_DoubleClick);
            // 
            // Form_StudentChats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 340);
            this.Controls.Add(this.lsbChats);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_StudentChats";
            this.Padding = new System.Windows.Forms.Padding(20, 44, 20, 20);
            this.Text = "Form_StudentChats";
            this.Load += new System.EventHandler(this.Form_StudentChats_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListBox lsbChats;
    }
}