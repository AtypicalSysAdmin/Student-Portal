namespace Student_Portal
{
    partial class Registration
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
            this.RegistrationCourseslistBox = new System.Windows.Forms.ListBox();
            this.AvailableCoursesLabel = new System.Windows.Forms.Label();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.DropCourseButton = new System.Windows.Forms.Button();
            this.SelectedCoursesLabel = new System.Windows.Forms.Label();
            this.RegisterCoursesButton = new System.Windows.Forms.Button();
            this.CancelRegistrationButton = new System.Windows.Forms.Button();
            this.SelectedCoursesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegistrationCourseslistBox
            // 
            this.RegistrationCourseslistBox.FormattingEnabled = true;
            this.RegistrationCourseslistBox.ItemHeight = 16;
            this.RegistrationCourseslistBox.Location = new System.Drawing.Point(105, 38);
            this.RegistrationCourseslistBox.Name = "RegistrationCourseslistBox";
            this.RegistrationCourseslistBox.Size = new System.Drawing.Size(321, 148);
            this.RegistrationCourseslistBox.TabIndex = 0;
            this.RegistrationCourseslistBox.SelectedIndexChanged += new System.EventHandler(this.RegistrationCourseslistBox_SelectedIndexChanged);
            // 
            // AvailableCoursesLabel
            // 
            this.AvailableCoursesLabel.AutoSize = true;
            this.AvailableCoursesLabel.Location = new System.Drawing.Point(105, 18);
            this.AvailableCoursesLabel.Name = "AvailableCoursesLabel";
            this.AvailableCoursesLabel.Size = new System.Drawing.Size(64, 17);
            this.AvailableCoursesLabel.TabIndex = 1;
            this.AvailableCoursesLabel.Text = "Courses:";
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(432, 38);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(71, 148);
            this.AddCourseButton.TabIndex = 4;
            this.AddCourseButton.Text = "Add";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // DropCourseButton
            // 
            this.DropCourseButton.Location = new System.Drawing.Point(432, 229);
            this.DropCourseButton.Name = "DropCourseButton";
            this.DropCourseButton.Size = new System.Drawing.Size(71, 148);
            this.DropCourseButton.TabIndex = 5;
            this.DropCourseButton.Text = "Drop";
            this.DropCourseButton.UseVisualStyleBackColor = true;
            this.DropCourseButton.Click += new System.EventHandler(this.DropCourseButton_Click);
            // 
            // SelectedCoursesLabel
            // 
            this.SelectedCoursesLabel.AutoSize = true;
            this.SelectedCoursesLabel.Location = new System.Drawing.Point(103, 196);
            this.SelectedCoursesLabel.Name = "SelectedCoursesLabel";
            this.SelectedCoursesLabel.Size = new System.Drawing.Size(123, 17);
            this.SelectedCoursesLabel.TabIndex = 6;
            this.SelectedCoursesLabel.Text = "Selected Courses:";
            // 
            // RegisterCoursesButton
            // 
            this.RegisterCoursesButton.Location = new System.Drawing.Point(476, 408);
            this.RegisterCoursesButton.Name = "RegisterCoursesButton";
            this.RegisterCoursesButton.Size = new System.Drawing.Size(147, 30);
            this.RegisterCoursesButton.TabIndex = 8;
            this.RegisterCoursesButton.Text = "Register";
            this.RegisterCoursesButton.UseVisualStyleBackColor = true;
            this.RegisterCoursesButton.Click += new System.EventHandler(this.RegisterCoursesButton_Click);
            // 
            // CancelRegistrationButton
            // 
            this.CancelRegistrationButton.Location = new System.Drawing.Point(629, 408);
            this.CancelRegistrationButton.Name = "CancelRegistrationButton";
            this.CancelRegistrationButton.Size = new System.Drawing.Size(147, 30);
            this.CancelRegistrationButton.TabIndex = 9;
            this.CancelRegistrationButton.Text = "Cancel Registraition";
            this.CancelRegistrationButton.UseVisualStyleBackColor = true;
            this.CancelRegistrationButton.Click += new System.EventHandler(this.CancelRegistrationButton_Click);
            // 
            // SelectedCoursesListBox
            // 
            this.SelectedCoursesListBox.FormattingEnabled = true;
            this.SelectedCoursesListBox.ItemHeight = 16;
            this.SelectedCoursesListBox.Location = new System.Drawing.Point(105, 229);
            this.SelectedCoursesListBox.Name = "SelectedCoursesListBox";
            this.SelectedCoursesListBox.Size = new System.Drawing.Size(321, 148);
            this.SelectedCoursesListBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID, Name, Section, Credits, Instructor, PreReq, CoReq";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectedCoursesListBox);
            this.Controls.Add(this.CancelRegistrationButton);
            this.Controls.Add(this.RegisterCoursesButton);
            this.Controls.Add(this.SelectedCoursesLabel);
            this.Controls.Add(this.DropCourseButton);
            this.Controls.Add(this.AddCourseButton);
            this.Controls.Add(this.AvailableCoursesLabel);
            this.Controls.Add(this.RegistrationCourseslistBox);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RegistrationCourseslistBox;
        private System.Windows.Forms.Label AvailableCoursesLabel;
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.Button DropCourseButton;
        private System.Windows.Forms.Label SelectedCoursesLabel;
        private System.Windows.Forms.Button RegisterCoursesButton;
        private System.Windows.Forms.Button CancelRegistrationButton;
        private System.Windows.Forms.ListBox SelectedCoursesListBox;
        private System.Windows.Forms.Label label1;
    }
}