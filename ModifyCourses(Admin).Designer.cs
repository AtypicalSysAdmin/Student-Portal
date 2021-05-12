namespace Student_Portal
{
    partial class ModifyCoursesAdmin
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
            this.CourseNameLable = new System.Windows.Forms.Label();
            this.CourseIDLabel = new System.Windows.Forms.Label();
            this.CourseSectionLabel = new System.Windows.Forms.Label();
            this.CourseInstructorLabel = new System.Windows.Forms.Label();
            this.CourseNewNameTextBox = new System.Windows.Forms.TextBox();
            this.CourseIDTextBox = new System.Windows.Forms.TextBox();
            this.CourseNewSectionTextBox = new System.Windows.Forms.TextBox();
            this.CourseNewInstructorTextBox = new System.Windows.Forms.TextBox();
            this.AdminEditCoursesButton = new System.Windows.Forms.Button();
            this.AdminEditCourseCancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CourseNewCreditsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CourseNewPreReqTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CourseNewCoReqTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CourseNewCapTextBox = new System.Windows.Forms.TextBox();
            this.CourseCapLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseNameLable
            // 
            this.CourseNameLable.AutoSize = true;
            this.CourseNameLable.Location = new System.Drawing.Point(23, 127);
            this.CourseNameLable.Name = "CourseNameLable";
            this.CourseNameLable.Size = new System.Drawing.Size(132, 17);
            this.CourseNameLable.TabIndex = 0;
            this.CourseNameLable.Text = "Enter course name:";
            this.CourseNameLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // CourseIDLabel
            // 
            this.CourseIDLabel.AutoSize = true;
            this.CourseIDLabel.Location = new System.Drawing.Point(23, 26);
            this.CourseIDLabel.Name = "CourseIDLabel";
            this.CourseIDLabel.Size = new System.Drawing.Size(132, 17);
            this.CourseIDLabel.TabIndex = 1;
            this.CourseIDLabel.Text = "Enter the course id:";
            // 
            // CourseSectionLabel
            // 
            this.CourseSectionLabel.AutoSize = true;
            this.CourseSectionLabel.Location = new System.Drawing.Point(23, 156);
            this.CourseSectionLabel.Name = "CourseSectionLabel";
            this.CourseSectionLabel.Size = new System.Drawing.Size(142, 17);
            this.CourseSectionLabel.TabIndex = 2;
            this.CourseSectionLabel.Text = "Enter course section:";
            // 
            // CourseInstructorLabel
            // 
            this.CourseInstructorLabel.AutoSize = true;
            this.CourseInstructorLabel.Location = new System.Drawing.Point(23, 212);
            this.CourseInstructorLabel.Name = "CourseInstructorLabel";
            this.CourseInstructorLabel.Size = new System.Drawing.Size(156, 17);
            this.CourseInstructorLabel.TabIndex = 3;
            this.CourseInstructorLabel.Text = "Enter course instructor:";
            this.CourseInstructorLabel.Click += new System.EventHandler(this.CourseInstructorLabel_Click);
            // 
            // CourseNewNameTextBox
            // 
            this.CourseNewNameTextBox.Location = new System.Drawing.Point(186, 124);
            this.CourseNewNameTextBox.Name = "CourseNewNameTextBox";
            this.CourseNewNameTextBox.Size = new System.Drawing.Size(172, 22);
            this.CourseNewNameTextBox.TabIndex = 4;
            // 
            // CourseIDTextBox
            // 
            this.CourseIDTextBox.Location = new System.Drawing.Point(186, 23);
            this.CourseIDTextBox.Name = "CourseIDTextBox";
            this.CourseIDTextBox.Size = new System.Drawing.Size(172, 22);
            this.CourseIDTextBox.TabIndex = 5;
            this.CourseIDTextBox.TextChanged += new System.EventHandler(this.CourseIDTextBox_TextChanged);
            // 
            // CourseNewSectionTextBox
            // 
            this.CourseNewSectionTextBox.Location = new System.Drawing.Point(186, 153);
            this.CourseNewSectionTextBox.Name = "CourseNewSectionTextBox";
            this.CourseNewSectionTextBox.Size = new System.Drawing.Size(172, 22);
            this.CourseNewSectionTextBox.TabIndex = 6;
            // 
            // CourseNewInstructorTextBox
            // 
            this.CourseNewInstructorTextBox.Location = new System.Drawing.Point(186, 212);
            this.CourseNewInstructorTextBox.Name = "CourseNewInstructorTextBox";
            this.CourseNewInstructorTextBox.Size = new System.Drawing.Size(172, 22);
            this.CourseNewInstructorTextBox.TabIndex = 7;
            // 
            // AdminEditCoursesButton
            // 
            this.AdminEditCoursesButton.Location = new System.Drawing.Point(526, 396);
            this.AdminEditCoursesButton.Name = "AdminEditCoursesButton";
            this.AdminEditCoursesButton.Size = new System.Drawing.Size(119, 29);
            this.AdminEditCoursesButton.TabIndex = 8;
            this.AdminEditCoursesButton.Text = "Edit course";
            this.AdminEditCoursesButton.UseVisualStyleBackColor = true;
            this.AdminEditCoursesButton.Click += new System.EventHandler(this.AdminEditCoursesButton_Click);
            // 
            // AdminEditCourseCancelButton
            // 
            this.AdminEditCourseCancelButton.Location = new System.Drawing.Point(651, 396);
            this.AdminEditCourseCancelButton.Name = "AdminEditCourseCancelButton";
            this.AdminEditCourseCancelButton.Size = new System.Drawing.Size(119, 29);
            this.AdminEditCourseCancelButton.TabIndex = 9;
            this.AdminEditCourseCancelButton.Text = "Cancel";
            this.AdminEditCourseCancelButton.UseVisualStyleBackColor = true;
            this.AdminEditCourseCancelButton.Click += new System.EventHandler(this.AdminEditCourseCancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "(You must insert exact course ID)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter the new information of the course below:";
            // 
            // CourseNewCreditsTextBox
            // 
            this.CourseNewCreditsTextBox.Location = new System.Drawing.Point(186, 184);
            this.CourseNewCreditsTextBox.Name = "CourseNewCreditsTextBox";
            this.CourseNewCreditsTextBox.Size = new System.Drawing.Size(172, 22);
            this.CourseNewCreditsTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter course credits:";
            // 
            // CourseNewPreReqTextBox
            // 
            this.CourseNewPreReqTextBox.Location = new System.Drawing.Point(186, 242);
            this.CourseNewPreReqTextBox.Name = "CourseNewPreReqTextBox";
            this.CourseNewPreReqTextBox.Size = new System.Drawing.Size(172, 22);
            this.CourseNewPreReqTextBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Enter course pre-req:";
            // 
            // CourseNewCoReqTextBox
            // 
            this.CourseNewCoReqTextBox.Location = new System.Drawing.Point(186, 275);
            this.CourseNewCoReqTextBox.Name = "CourseNewCoReqTextBox";
            this.CourseNewCoReqTextBox.Size = new System.Drawing.Size(172, 22);
            this.CourseNewCoReqTextBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Enter course co-req:";
            // 
            // CourseNewCapTextBox
            // 
            this.CourseNewCapTextBox.Location = new System.Drawing.Point(186, 309);
            this.CourseNewCapTextBox.Name = "CourseNewCapTextBox";
            this.CourseNewCapTextBox.Size = new System.Drawing.Size(172, 22);
            this.CourseNewCapTextBox.TabIndex = 19;
            // 
            // CourseCapLabel
            // 
            this.CourseCapLabel.AutoSize = true;
            this.CourseCapLabel.Location = new System.Drawing.Point(23, 309);
            this.CourseCapLabel.Name = "CourseCapLabel";
            this.CourseCapLabel.Size = new System.Drawing.Size(149, 17);
            this.CourseCapLabel.TabIndex = 18;
            this.CourseCapLabel.Text = "Enter course capacity:";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(186, 51);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(119, 29);
            this.SearchButton.TabIndex = 20;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ModifyCoursesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CourseNewCapTextBox);
            this.Controls.Add(this.CourseCapLabel);
            this.Controls.Add(this.CourseNewCoReqTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CourseNewPreReqTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CourseNewCreditsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminEditCourseCancelButton);
            this.Controls.Add(this.AdminEditCoursesButton);
            this.Controls.Add(this.CourseNewInstructorTextBox);
            this.Controls.Add(this.CourseNewSectionTextBox);
            this.Controls.Add(this.CourseIDTextBox);
            this.Controls.Add(this.CourseNewNameTextBox);
            this.Controls.Add(this.CourseInstructorLabel);
            this.Controls.Add(this.CourseSectionLabel);
            this.Controls.Add(this.CourseIDLabel);
            this.Controls.Add(this.CourseNameLable);
            this.Name = "ModifyCoursesAdmin";
            this.Text = "Modify Courses (Admin)";
            this.Load += new System.EventHandler(this.ModifyCoursesAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseNameLable;
        private System.Windows.Forms.Label CourseIDLabel;
        private System.Windows.Forms.Label CourseSectionLabel;
        private System.Windows.Forms.Label CourseInstructorLabel;
        private System.Windows.Forms.TextBox CourseNewNameTextBox;
        private System.Windows.Forms.TextBox CourseIDTextBox;
        private System.Windows.Forms.TextBox CourseNewSectionTextBox;
        private System.Windows.Forms.TextBox CourseNewInstructorTextBox;
        private System.Windows.Forms.Button AdminEditCoursesButton;
        private System.Windows.Forms.Button AdminEditCourseCancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CourseNewCreditsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CourseNewPreReqTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CourseNewCoReqTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CourseNewCapTextBox;
        private System.Windows.Forms.Label CourseCapLabel;
        private System.Windows.Forms.Button SearchButton;
    }
}

