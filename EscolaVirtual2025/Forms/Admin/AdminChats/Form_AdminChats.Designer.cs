namespace EscolaVirtual2025.Forms.Admin.AdminChats
{
    partial class Form_AdminChats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AdminChats));
            this.lsbChats = new MaterialSkin.Controls.MaterialListBox();
            this.SuspendLayout();
            // 
            // lsbChats
            // 
            this.lsbChats.BackColor = System.Drawing.Color.White;
            this.lsbChats.BorderColor = System.Drawing.Color.LightGray;
            this.lsbChats.Depth = 0;
            this.lsbChats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbChats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lsbChats.Location = new System.Drawing.Point(20, 84);
            this.lsbChats.MouseState = MaterialSkin.MouseState.HOVER;
            this.lsbChats.Name = "lsbChats";
            this.lsbChats.SelectedIndex = -1;
            this.lsbChats.SelectedItem = null;
            this.lsbChats.Size = new System.Drawing.Size(360, 296);
            this.lsbChats.TabIndex = 1;
            this.lsbChats.DoubleClick += new System.EventHandler(this.lsbChats_DoubleClick);
            // 
            // Form_AdminChats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.lsbChats);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_AdminChats";
            this.Padding = new System.Windows.Forms.Padding(20, 84, 20, 20);
            this.Sizable = false;
            this.Text = "Pedidos:";
            this.Load += new System.EventHandler(this.Form_AdminChats_Load);
            this.VisibleChanged += new System.EventHandler(this.Form_AdminChats_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListBox lsbChats;
    }
}