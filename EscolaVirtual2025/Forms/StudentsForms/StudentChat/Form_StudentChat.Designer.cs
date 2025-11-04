namespace EscolaVirtual2025.Forms.TeacherForms.TeacherChat
{
    partial class Form_StudentChat
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialListBox listMessages;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listMessages = new MaterialSkin.Controls.MaterialListBox();
            this.SuspendLayout();
            // 
            // listMessages
            // 
            this.listMessages.BackColor = System.Drawing.Color.White;
            this.listMessages.BorderColor = System.Drawing.Color.LightGray;
            this.listMessages.Depth = 0;
            this.listMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listMessages.Location = new System.Drawing.Point(13, 89);
            this.listMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listMessages.MouseState = MaterialSkin.MouseState.HOVER;
            this.listMessages.Name = "listMessages";
            this.listMessages.SelectedIndex = -1;
            this.listMessages.SelectedItem = null;
            this.listMessages.Size = new System.Drawing.Size(554, 321);
            this.listMessages.TabIndex = 0;
            // 
            // Form_StudentChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 422);
            this.Controls.Add(this.listMessages);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_StudentChat";
            this.Padding = new System.Windows.Forms.Padding(13, 89, 13, 12);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_StudentChat_FormClosing);
            this.Load += new System.EventHandler(this.Form_StudentChat_Load);
            this.ResumeLayout(false);

        }
    }
}
