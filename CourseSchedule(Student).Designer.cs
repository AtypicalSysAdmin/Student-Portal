namespace Student_Portal
{
    partial class CourseSchedule
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
            this.courseScheduleListBox = new System.Windows.Forms.ListBox();
            this.backButton = new System.Windows.Forms.Button();
            this.scheduleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalGPALabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // courseScheduleListBox
            // 
            this.courseScheduleListBox.FormattingEnabled = true;
            this.courseScheduleListBox.ItemHeight = 16;
            this.courseScheduleListBox.Location = new System.Drawing.Point(132, 57);
            this.courseScheduleListBox.Name = "courseScheduleListBox";
            this.courseScheduleListBox.Size = new System.Drawing.Size(549, 260);
            this.courseScheduleListBox.TabIndex = 0;
            this.courseScheduleListBox.SelectedIndexChanged += new System.EventHandler(this.courseScheduleListBox_SelectedIndexChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(606, 377);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 30);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // scheduleLabel
            // 
            this.scheduleLabel.AutoSize = true;
            this.scheduleLabel.Location = new System.Drawing.Point(132, 29);
            this.scheduleLabel.Name = "scheduleLabel";
            this.scheduleLabel.Size = new System.Drawing.Size(206, 17);
            this.scheduleLabel.TabIndex = 2;
            this.scheduleLabel.Text = "Schedules of Enrolled Courses:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total GPA:";
            // 
            // TotalGPALabel
            // 
            this.TotalGPALabel.AutoSize = true;
            this.TotalGPALabel.Location = new System.Drawing.Point(229, 333);
            this.TotalGPALabel.Name = "TotalGPALabel";
            this.TotalGPALabel.Size = new System.Drawing.Size(20, 17);
            this.TotalGPALabel.TabIndex = 4;
            this.TotalGPALabel.Text = "...";
            // 
            // CourseSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 439);
            this.Controls.Add(this.TotalGPALabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scheduleLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.courseScheduleListBox);
            this.Name = "CourseSchedule";
            this.Text = "Courses\' Schedule";
            this.Load += new System.EventHandler(this.CourseSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox courseScheduleListBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label scheduleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalGPALabel;
    }
}