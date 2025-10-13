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
            this.listMessages.Location = new System.Drawing.Point(10, 72);
            this.listMessages.Margin = new System.Windows.Forms.Padding(2);
            this.listMessages.MouseState = MaterialSkin.MouseState.HOVER;
            this.listMessages.Name = "listMessages";
            this.listMessages.SelectedIndex = -1;
            this.listMessages.SelectedItem = null;
            this.listMessages.Size = new System.Drawing.Size(415, 261);
            this.listMessages.TabIndex = 0;
            // 
            // Form_StudentChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 343);
            this.Controls.Add(this.listMessages);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_StudentChat";
            this.Padding = new System.Windows.Forms.Padding(10, 72, 10, 10);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Form_StudentChat_Load);
            this.ResumeLayout(false);

        }
    }
}
