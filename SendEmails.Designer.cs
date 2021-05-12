namespace Student_Portal
{
    partial class SendEmailsAdmin
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
            this.AdminSendEmailButton = new System.Windows.Forms.Button();
            this.AdminCancelSendEmailButton = new System.Windows.Forms.Button();
            this.EmailTextLabel = new System.Windows.Forms.Label();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.TargetEmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.EmailBodyTextBox = new System.Windows.Forms.TextBox();
            this.SenderEmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AttachmentTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminSendEmailButton
            // 
            this.AdminSendEmailButton.Location = new System.Drawing.Point(570, 384);
            this.AdminSendEmailButton.Name = "AdminSendEmailButton";
            this.AdminSendEmailButton.Size = new System.Drawing.Size(99, 33);
            this.AdminSendEmailButton.TabIndex = 0;
            this.AdminSendEmailButton.Text = "Send";
            this.AdminSendEmailButton.UseVisualStyleBackColor = true;
            this.AdminSendEmailButton.Click += new System.EventHandler(this.AdminSendEmailButton_Click);
            // 
            // AdminCancelSendEmailButton
            // 
            this.AdminCancelSendEmailButton.Location = new System.Drawing.Point(675, 384);
            this.AdminCancelSendEmailButton.Name = "AdminCancelSendEmailButton";
            this.AdminCancelSendEmailButton.Size = new System.Drawing.Size(99, 33);
            this.AdminCancelSendEmailButton.TabIndex = 2;
            this.AdminCancelSendEmailButton.Text = "Cancel";
            this.AdminCancelSendEmailButton.UseVisualStyleBackColor = true;
            this.AdminCancelSendEmailButton.Click += new System.EventHandler(this.AdminCancelSendEmailButton_Click);
            // 
            // EmailTextLabel
            // 
            this.EmailTextLabel.AutoSize = true;
            this.EmailTextLabel.Location = new System.Drawing.Point(21, 203);
            this.EmailTextLabel.Name = "EmailTextLabel";
            this.EmailTextLabel.Size = new System.Drawing.Size(77, 17);
            this.EmailTextLabel.TabIndex = 3;
            this.EmailTextLabel.Text = "Email Text:";
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.AutoSize = true;
            this.EmailAddressLabel.Location = new System.Drawing.Point(21, 93);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(148, 17);
            this.EmailAddressLabel.TabIndex = 4;
            this.EmailAddressLabel.Text = "Target Email Address:";
            // 
            // TargetEmailAddressTextBox
            // 
            this.TargetEmailAddressTextBox.Location = new System.Drawing.Point(197, 93);
            this.TargetEmailAddressTextBox.Name = "TargetEmailAddressTextBox";
            this.TargetEmailAddressTextBox.Size = new System.Drawing.Size(244, 22);
            this.TargetEmailAddressTextBox.TabIndex = 5;
            // 
            // EmailBodyTextBox
            // 
            this.EmailBodyTextBox.Location = new System.Drawing.Point(197, 203);
            this.EmailBodyTextBox.Multiline = true;
            this.EmailBodyTextBox.Name = "EmailBodyTextBox";
            this.EmailBodyTextBox.Size = new System.Drawing.Size(244, 115);
            this.EmailBodyTextBox.TabIndex = 6;
            // 
            // SenderEmailAddressTextBox
            // 
            this.SenderEmailAddressTextBox.Location = new System.Drawing.Point(197, 37);
            this.SenderEmailAddressTextBox.Name = "SenderEmailAddressTextBox";
            this.SenderEmailAddressTextBox.Size = new System.Drawing.Size(244, 22);
            this.SenderEmailAddressTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Your Gmail:";
            // 
            // EmailPasswordTextBox
            // 
            this.EmailPasswordTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.EmailPasswordTextBox.Location = new System.Drawing.Point(197, 65);
            this.EmailPasswordTextBox.Name = "EmailPasswordTextBox";
            this.EmailPasswordTextBox.Size = new System.Drawing.Size(244, 22);
            this.EmailPasswordTextBox.TabIndex = 10;
            this.EmailPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gmail Password:";
            // 
            // AttachmentTextBox
            // 
            this.AttachmentTextBox.Location = new System.Drawing.Point(197, 121);
            this.AttachmentTextBox.Name = "AttachmentTextBox";
            this.AttachmentTextBox.Size = new System.Drawing.Size(244, 22);
            this.AttachmentTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Attachment:";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(447, 121);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(99, 22);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Attach";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Location = new System.Drawing.Point(197, 175);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(244, 22);
            this.SubjectTextBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Subject:";
            // 
            // SendEmailsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AttachmentTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmailPasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SenderEmailAddressTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailBodyTextBox);
            this.Controls.Add(this.TargetEmailAddressTextBox);
            this.Controls.Add(this.EmailAddressLabel);
            this.Controls.Add(this.EmailTextLabel);
            this.Controls.Add(this.AdminCancelSendEmailButton);
            this.Controls.Add(this.AdminSendEmailButton);
            this.Name = "SendEmailsAdmin";
            this.Text = "Send Emails (Admin)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminSendEmailButton;
        private System.Windows.Forms.Button AdminCancelSendEmailButton;
        private System.Windows.Forms.Label EmailTextLabel;
        private System.Windows.Forms.Label EmailAddressLabel;
        private System.Windows.Forms.TextBox TargetEmailAddressTextBox;
        private System.Windows.Forms.TextBox EmailBodyTextBox;
        private System.Windows.Forms.TextBox SenderEmailAddressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailPasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AttachmentTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.Label label4;
    }
}