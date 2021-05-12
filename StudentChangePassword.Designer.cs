namespace Student_Portal
{
    partial class StudentChangePassword
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
            this.NewPasswordReEntryTextBox2 = new System.Windows.Forms.TextBox();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ReEnterNewPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.CancelChangePasswordButton = new System.Windows.Forms.Button();
            this.UpdatePasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewPasswordReEntryTextBox2
            // 
            this.NewPasswordReEntryTextBox2.Location = new System.Drawing.Point(250, 67);
            this.NewPasswordReEntryTextBox2.Name = "NewPasswordReEntryTextBox2";
            this.NewPasswordReEntryTextBox2.Size = new System.Drawing.Size(227, 22);
            this.NewPasswordReEntryTextBox2.TabIndex = 11;
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Location = new System.Drawing.Point(250, 39);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(227, 22);
            this.NewPasswordTextBox.TabIndex = 10;
            // 
            // ReEnterNewPasswordLabel
            // 
            this.ReEnterNewPasswordLabel.AutoSize = true;
            this.ReEnterNewPasswordLabel.Location = new System.Drawing.Point(41, 64);
            this.ReEnterNewPasswordLabel.Name = "ReEnterNewPasswordLabel";
            this.ReEnterNewPasswordLabel.Size = new System.Drawing.Size(165, 17);
            this.ReEnterNewPasswordLabel.TabIndex = 9;
            this.ReEnterNewPasswordLabel.Text = "Re-Enter New Password:";
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Location = new System.Drawing.Point(41, 38);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(142, 17);
            this.NewPasswordLabel.TabIndex = 8;
            this.NewPasswordLabel.Text = "Enter New Password:";
            // 
            // CancelChangePasswordButton
            // 
            this.CancelChangePasswordButton.Location = new System.Drawing.Point(658, 377);
            this.CancelChangePasswordButton.Name = "CancelChangePasswordButton";
            this.CancelChangePasswordButton.Size = new System.Drawing.Size(102, 35);
            this.CancelChangePasswordButton.TabIndex = 7;
            this.CancelChangePasswordButton.Text = "Cancel";
            this.CancelChangePasswordButton.UseVisualStyleBackColor = true;
            // 
            // UpdatePasswordButton
            // 
            this.UpdatePasswordButton.Location = new System.Drawing.Point(451, 377);
            this.UpdatePasswordButton.Name = "UpdatePasswordButton";
            this.UpdatePasswordButton.Size = new System.Drawing.Size(186, 35);
            this.UpdatePasswordButton.TabIndex = 6;
            this.UpdatePasswordButton.Text = "Update Password";
            this.UpdatePasswordButton.UseVisualStyleBackColor = true;
            this.UpdatePasswordButton.Click += new System.EventHandler(this.UpdatePasswordButton_Click);
            // 
            // StudentChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewPasswordReEntryTextBox2);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.ReEnterNewPasswordLabel);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.CancelChangePasswordButton);
            this.Controls.Add(this.UpdatePasswordButton);
            this.Name = "StudentChangePassword";
            this.Text = "Student Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewPasswordReEntryTextBox2;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.Label ReEnterNewPasswordLabel;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.Button CancelChangePasswordButton;
        private System.Windows.Forms.Button UpdatePasswordButton;
    }
}