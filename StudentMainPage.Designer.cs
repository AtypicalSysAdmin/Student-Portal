namespace Student_Portal
{
    partial class StudentMainPage
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
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.StudentMakePaymentButton = new System.Windows.Forms.Button();
            this.StudentEditInfoButton = new System.Windows.Forms.Button();
            this.StudentCoursesButton = new System.Windows.Forms.Button();
            this.StudentRegisterationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(236, 283);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(328, 49);
            this.ChangePasswordButton.TabIndex = 11;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // StudentMakePaymentButton
            // 
            this.StudentMakePaymentButton.Location = new System.Drawing.Point(236, 228);
            this.StudentMakePaymentButton.Name = "StudentMakePaymentButton";
            this.StudentMakePaymentButton.Size = new System.Drawing.Size(328, 49);
            this.StudentMakePaymentButton.TabIndex = 9;
            this.StudentMakePaymentButton.Text = "Make Payments";
            this.StudentMakePaymentButton.UseVisualStyleBackColor = true;
            this.StudentMakePaymentButton.Click += new System.EventHandler(this.StudentMakePaymentButton_Click);
            // 
            // StudentEditInfoButton
            // 
            this.StudentEditInfoButton.Location = new System.Drawing.Point(236, 173);
            this.StudentEditInfoButton.Name = "StudentEditInfoButton";
            this.StudentEditInfoButton.Size = new System.Drawing.Size(328, 49);
            this.StudentEditInfoButton.TabIndex = 8;
            this.StudentEditInfoButton.Text = "Edit Personal Info";
            this.StudentEditInfoButton.UseVisualStyleBackColor = true;
            this.StudentEditInfoButton.Click += new System.EventHandler(this.StudentEditInfoButton_Click);
            // 
            // StudentCoursesButton
            // 
            this.StudentCoursesButton.Location = new System.Drawing.Point(236, 118);
            this.StudentCoursesButton.Name = "StudentCoursesButton";
            this.StudentCoursesButton.Size = new System.Drawing.Size(328, 49);
            this.StudentCoursesButton.TabIndex = 7;
            this.StudentCoursesButton.Text = "Courses";
            this.StudentCoursesButton.UseVisualStyleBackColor = true;
            this.StudentCoursesButton.Click += new System.EventHandler(this.StudentCoursesButton_Click);
            // 
            // StudentRegisterationButton
            // 
            this.StudentRegisterationButton.Location = new System.Drawing.Point(236, 63);
            this.StudentRegisterationButton.Name = "StudentRegisterationButton";
            this.StudentRegisterationButton.Size = new System.Drawing.Size(328, 49);
            this.StudentRegisterationButton.TabIndex = 6;
            this.StudentRegisterationButton.Text = "Registeration";
            this.StudentRegisterationButton.UseVisualStyleBackColor = true;
            this.StudentRegisterationButton.Click += new System.EventHandler(this.StudentRegisterationButton_Click);
            // 
            // StudentMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.StudentMakePaymentButton);
            this.Controls.Add(this.StudentEditInfoButton);
            this.Controls.Add(this.StudentCoursesButton);
            this.Controls.Add(this.StudentRegisterationButton);
            this.Name = "StudentMainPage";
            this.Text = "Student Main Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Button StudentMakePaymentButton;
        private System.Windows.Forms.Button StudentEditInfoButton;
        private System.Windows.Forms.Button StudentCoursesButton;
        private System.Windows.Forms.Button StudentRegisterationButton;
    }
}