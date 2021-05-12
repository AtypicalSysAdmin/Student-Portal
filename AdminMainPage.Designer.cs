namespace Student_Portal
{
    partial class AdminMainPage
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
            this.AdminRegisterNewStudentButton = new System.Windows.Forms.Button();
            this.AdminSendEmailButton = new System.Windows.Forms.Button();
            this.AdminModifyStudentsButton = new System.Windows.Forms.Button();
            this.AdminModifyCoursesButton = new System.Windows.Forms.Button();
            this.AdminAddNewCourseButton = new System.Windows.Forms.Button();
            this.AdminChangePasswordButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SendWarningLetterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminRegisterNewStudentButton
            // 
            this.AdminRegisterNewStudentButton.Location = new System.Drawing.Point(234, 20);
            this.AdminRegisterNewStudentButton.Name = "AdminRegisterNewStudentButton";
            this.AdminRegisterNewStudentButton.Size = new System.Drawing.Size(328, 49);
            this.AdminRegisterNewStudentButton.TabIndex = 0;
            this.AdminRegisterNewStudentButton.Text = "Register New Student";
            this.AdminRegisterNewStudentButton.UseVisualStyleBackColor = true;
            this.AdminRegisterNewStudentButton.Click += new System.EventHandler(this.AdminRegisterNewStudentButton_Click);
            // 
            // AdminSendEmailButton
            // 
            this.AdminSendEmailButton.Location = new System.Drawing.Point(234, 69);
            this.AdminSendEmailButton.Name = "AdminSendEmailButton";
            this.AdminSendEmailButton.Size = new System.Drawing.Size(328, 49);
            this.AdminSendEmailButton.TabIndex = 1;
            this.AdminSendEmailButton.Text = "Send Emails";
            this.AdminSendEmailButton.UseVisualStyleBackColor = true;
            this.AdminSendEmailButton.Click += new System.EventHandler(this.AdminSendEmailButton_Click);
            // 
            // AdminModifyStudentsButton
            // 
            this.AdminModifyStudentsButton.Location = new System.Drawing.Point(234, 167);
            this.AdminModifyStudentsButton.Name = "AdminModifyStudentsButton";
            this.AdminModifyStudentsButton.Size = new System.Drawing.Size(328, 49);
            this.AdminModifyStudentsButton.TabIndex = 2;
            this.AdminModifyStudentsButton.Text = "Modify Students Info";
            this.AdminModifyStudentsButton.UseVisualStyleBackColor = true;
            this.AdminModifyStudentsButton.Click += new System.EventHandler(this.AdminModifyStudentsButton_Click);
            // 
            // AdminModifyCoursesButton
            // 
            this.AdminModifyCoursesButton.Location = new System.Drawing.Point(234, 216);
            this.AdminModifyCoursesButton.Name = "AdminModifyCoursesButton";
            this.AdminModifyCoursesButton.Size = new System.Drawing.Size(328, 49);
            this.AdminModifyCoursesButton.TabIndex = 3;
            this.AdminModifyCoursesButton.Text = "Modify Courses";
            this.AdminModifyCoursesButton.UseVisualStyleBackColor = true;
            this.AdminModifyCoursesButton.Click += new System.EventHandler(this.AdminModifyCoursesButton_Click);
            // 
            // AdminAddNewCourseButton
            // 
            this.AdminAddNewCourseButton.Location = new System.Drawing.Point(234, 265);
            this.AdminAddNewCourseButton.Name = "AdminAddNewCourseButton";
            this.AdminAddNewCourseButton.Size = new System.Drawing.Size(328, 49);
            this.AdminAddNewCourseButton.TabIndex = 4;
            this.AdminAddNewCourseButton.Text = "Add New Course";
            this.AdminAddNewCourseButton.UseVisualStyleBackColor = true;
            this.AdminAddNewCourseButton.Click += new System.EventHandler(this.AdminAddNewCourseButton_Click);
            // 
            // AdminChangePasswordButton
            // 
            this.AdminChangePasswordButton.Location = new System.Drawing.Point(234, 363);
            this.AdminChangePasswordButton.Name = "AdminChangePasswordButton";
            this.AdminChangePasswordButton.Size = new System.Drawing.Size(328, 49);
            this.AdminChangePasswordButton.TabIndex = 5;
            this.AdminChangePasswordButton.Text = "Change Password";
            this.AdminChangePasswordButton.UseVisualStyleBackColor = true;
            this.AdminChangePasswordButton.Click += new System.EventHandler(this.AdminChangePasswordButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Payment Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SendWarningLetterButton
            // 
            this.SendWarningLetterButton.Location = new System.Drawing.Point(234, 118);
            this.SendWarningLetterButton.Name = "SendWarningLetterButton";
            this.SendWarningLetterButton.Size = new System.Drawing.Size(328, 49);
            this.SendWarningLetterButton.TabIndex = 7;
            this.SendWarningLetterButton.Text = "Send Warning Letters";
            this.SendWarningLetterButton.UseVisualStyleBackColor = true;
            this.SendWarningLetterButton.Click += new System.EventHandler(this.SendWarningLetterButton_Click);
            // 
            // AdminMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SendWarningLetterButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AdminChangePasswordButton);
            this.Controls.Add(this.AdminAddNewCourseButton);
            this.Controls.Add(this.AdminModifyCoursesButton);
            this.Controls.Add(this.AdminModifyStudentsButton);
            this.Controls.Add(this.AdminSendEmailButton);
            this.Controls.Add(this.AdminRegisterNewStudentButton);
            this.Name = "AdminMainPage";
            this.Text = "Admin Main Page";
            this.Load += new System.EventHandler(this.AdminMainPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminRegisterNewStudentButton;
        private System.Windows.Forms.Button AdminSendEmailButton;
        private System.Windows.Forms.Button AdminModifyStudentsButton;
        private System.Windows.Forms.Button AdminModifyCoursesButton;
        private System.Windows.Forms.Button AdminAddNewCourseButton;
        private System.Windows.Forms.Button AdminChangePasswordButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SendWarningLetterButton;
    }
}