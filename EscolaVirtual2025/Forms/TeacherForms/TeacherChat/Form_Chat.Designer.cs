namespace EscolaVirtual2025.Forms.TeacherForms.TeacherChat
{
    partial class Form_Chat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private MaterialSkin.Controls.MaterialListBox listMessages;
        private MaterialSkin.Controls.MaterialTextBox txtMessage;
        private MaterialSkin.Controls.MaterialButton btnSend;

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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Chat));
            this.listMessages = new MaterialSkin.Controls.MaterialListBox();
            this.txtMessage = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSend = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // listMessages
            // 
            this.listMessages.BackColor = System.Drawing.Color.White;
            this.listMessages.BorderColor = System.Drawing.Color.LightGray;
            this.listMessages.Depth = 0;
            this.listMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listMessages.Location = new System.Drawing.Point(20, 80);
            this.listMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listMessages.MouseState = MaterialSkin.MouseState.HOVER;
            this.listMessages.Name = "listMessages";
            this.listMessages.SelectedIndex = -1;
            this.listMessages.SelectedItem = null;
            this.listMessages.Size = new System.Drawing.Size(540, 330);
            this.listMessages.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.AnimateReadOnly = false;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Depth = 0;
            this.txtMessage.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMessage.LeadingIcon = null;
            this.txtMessage.Location = new System.Drawing.Point(20, 430);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage.MaxLength = 200;
            this.txtMessage.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMessage.Multiline = false;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(420, 50);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.Text = "";
            this.txtMessage.TrailingIcon = null;
            // 
            // btnSend
            // 
            this.btnSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSend.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSend.Depth = 0;
            this.btnSend.HighEmphasis = true;
            this.btnSend.Icon = null;
            this.btnSend.Location = new System.Drawing.Point(460, 441);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSend.Size = new System.Drawing.Size(73, 36);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Enviar";
            this.btnSend.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSend.UseAccentColor = false;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form_Chat
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 510);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.listMessages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Chat";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Chat_FormClosing);
            this.Load += new System.EventHandler(this.Form_Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
