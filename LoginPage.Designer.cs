namespace Student_Portal
{
    partial class LoginPage
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
            this.AdminIDLabel = new System.Windows.Forms.Label();
            this.AdminPasswordLabel = new System.Windows.Forms.Label();
            this.AdminLoginButton = new System.Windows.Forms.Button();
            this.AdminIDTextBox = new System.Windows.Forms.TextBox();
            this.AdminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.StudentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.StudentIDTextBox = new System.Windows.Forms.TextBox();
            this.LoginStudentButton = new System.Windows.Forms.Button();
            this.StudentPasswordLabel = new System.Windows.Forms.Label();
            this.StudentIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminIDLabel
            // 
            this.AdminIDLabel.AutoSize = true;
            this.AdminIDLabel.Location = new System.Drawing.Point(11, 166);
            this.AdminIDLabel.Name = "AdminIDLabel";
            this.AdminIDLabel.Size = new System.Drawing.Size(68, 17);
            this.AdminIDLabel.TabIndex = 0;
            this.AdminIDLabel.Text = "Admin ID:";
            // 
            // AdminPasswordLabel
            // 
            this.AdminPasswordLabel.AutoSize = true;
            this.AdminPasswordLabel.Location = new System.Drawing.Point(11, 199);
            this.AdminPasswordLabel.Name = "AdminPasswordLabel";
            this.AdminPasswordLabel.Size = new System.Drawing.Size(116, 17);
            this.AdminPasswordLabel.TabIndex = 1;
            this.AdminPasswordLabel.Text = "Admin Password:";
            // 
            // AdminLoginButton
            // 
            this.AdminLoginButton.Location = new System.Drawing.Point(144, 222);
            this.AdminLoginButton.Name = "AdminLoginButton";
            this.AdminLoginButton.Size = new System.Drawing.Size(202, 25);
            this.AdminLoginButton.TabIndex = 2;
            this.AdminLoginButton.Text = "Login as admin";
            this.AdminLoginButton.UseVisualStyleBackColor = true;
            this.AdminLoginButton.Click += new System.EventHandler(this.AdminLoginButton_Click);
            // 
            // AdminIDTextBox
            // 
            this.AdminIDTextBox.Location = new System.Drawing.Point(144, 166);
            this.AdminIDTextBox.Name = "AdminIDTextBox";
            this.AdminIDTextBox.Size = new System.Drawing.Size(202, 22);
            this.AdminIDTextBox.TabIndex = 4;
            this.AdminIDTextBox.TextChanged += new System.EventHandler(this.AdminIDTextBox_TextChanged);
            // 
            // AdminPasswordTextBox
            // 
            this.AdminPasswordTextBox.Location = new System.Drawing.Point(144, 194);
            this.AdminPasswordTextBox.Name = "AdminPasswordTextBox";
            this.AdminPasswordTextBox.Size = new System.Drawing.Size(202, 22);
            this.AdminPasswordTextBox.TabIndex = 5;
            this.AdminPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // StudentPasswordTextBox
            // 
            this.StudentPasswordTextBox.Location = new System.Drawing.Point(537, 189);
            this.StudentPasswordTextBox.Name = "StudentPasswordTextBox";
            this.StudentPasswordTextBox.Size = new System.Drawing.Size(202, 22);
            this.StudentPasswordTextBox.TabIndex = 12;
            this.StudentPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // StudentIDTextBox
            // 
            this.StudentIDTextBox.Location = new System.Drawing.Point(537, 161);
            this.StudentIDTextBox.Name = "StudentIDTextBox";
            this.StudentIDTextBox.Size = new System.Drawing.Size(202, 22);
            this.StudentIDTextBox.TabIndex = 11;
            // 
            // LoginStudentButton
            // 
            this.LoginStudentButton.Location = new System.Drawing.Point(537, 217);
            this.LoginStudentButton.Name = "LoginStudentButton";
            this.LoginStudentButton.Size = new System.Drawing.Size(202, 25);
            this.LoginStudentButton.TabIndex = 9;
            this.LoginStudentButton.Text = "Login as student";
            this.LoginStudentButton.UseVisualStyleBackColor = true;
            this.LoginStudentButton.Click += new System.EventHandler(this.LoginStudentButton_Click);
            // 
            // StudentPasswordLabel
            // 
            this.StudentPasswordLabel.AutoSize = true;
            this.StudentPasswordLabel.Location = new System.Drawing.Point(404, 194);
            this.StudentPasswordLabel.Name = "StudentPasswordLabel";
            this.StudentPasswordLabel.Size = new System.Drawing.Size(126, 17);
            this.StudentPasswordLabel.TabIndex = 8;
            this.StudentPasswordLabel.Text = "Student Password:";
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Location = new System.Drawing.Point(404, 161);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(78, 17);
            this.StudentIDLabel.TabIndex = 7;
            this.StudentIDLabel.Text = "Student ID:";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StudentPasswordTextBox);
            this.Controls.Add(this.StudentIDTextBox);
            this.Controls.Add(this.LoginStudentButton);
            this.Controls.Add(this.StudentPasswordLabel);
            this.Controls.Add(this.StudentIDLabel);
            this.Controls.Add(this.AdminPasswordTextBox);
            this.Controls.Add(this.AdminIDTextBox);
            this.Controls.Add(this.AdminLoginButton);
            this.Controls.Add(this.AdminPasswordLabel);
            this.Controls.Add(this.AdminIDLabel);
            this.Name = "LoginPage";
            this.Text = "Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminIDLabel;
        private System.Windows.Forms.Label AdminPasswordLabel;
        private System.Windows.Forms.Button AdminLoginButton;
        private System.Windows.Forms.TextBox AdminIDTextBox;
        private System.Windows.Forms.TextBox AdminPasswordTextBox;
        private System.Windows.Forms.TextBox StudentPasswordTextBox;
        private System.Windows.Forms.TextBox StudentIDTextBox;
        private System.Windows.Forms.Button LoginStudentButton;
        private System.Windows.Forms.Label StudentPasswordLabel;
        private System.Windows.Forms.Label StudentIDLabel;
    }
}