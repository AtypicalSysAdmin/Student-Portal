namespace Student_Portal
{
    partial class SendWarningLetter
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
            this.WarningSubjecttb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lebelx = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbStudentId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.accBalLabel = new System.Windows.Forms.Label();
            this.EmailPasswordtb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SenderEmailAddresstb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SendWarningLetterButton = new System.Windows.Forms.Button();
            this.studentEmailtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.WarningTExttb = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WarningSubjecttb
            // 
            this.WarningSubjecttb.Location = new System.Drawing.Point(193, 231);
            this.WarningSubjecttb.Name = "WarningSubjecttb";
            this.WarningSubjecttb.Size = new System.Drawing.Size(343, 22);
            this.WarningSubjecttb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Student Id:";
            // 
            // lebelx
            // 
            this.lebelx.AutoSize = true;
            this.lebelx.Location = new System.Drawing.Point(58, 236);
            this.lebelx.Name = "lebelx";
            this.lebelx.Size = new System.Drawing.Size(87, 17);
            this.lebelx.TabIndex = 3;
            this.lebelx.Text = "Edit Subject:";
            this.lebelx.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Check Due Amount";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbStudentId
            // 
            this.tbStudentId.Location = new System.Drawing.Point(193, 23);
            this.tbStudentId.Name = "tbStudentId";
            this.tbStudentId.Size = new System.Drawing.Size(168, 22);
            this.tbStudentId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Due Amount:";
            // 
            // accBalLabel
            // 
            this.accBalLabel.AutoSize = true;
            this.accBalLabel.Location = new System.Drawing.Point(172, 64);
            this.accBalLabel.Name = "accBalLabel";
            this.accBalLabel.Size = new System.Drawing.Size(120, 17);
            this.accBalLabel.TabIndex = 7;
            this.accBalLabel.Text = "click check button";
            this.accBalLabel.Click += new System.EventHandler(this.accBalLabel_Click);
            // 
            // EmailPasswordtb
            // 
            this.EmailPasswordtb.Location = new System.Drawing.Point(193, 167);
            this.EmailPasswordtb.Name = "EmailPasswordtb";
            this.EmailPasswordtb.Size = new System.Drawing.Size(244, 22);
            this.EmailPasswordtb.TabIndex = 14;
            this.EmailPasswordtb.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gmail Password:";
            // 
            // SenderEmailAddresstb
            // 
            this.SenderEmailAddresstb.Location = new System.Drawing.Point(193, 134);
            this.SenderEmailAddresstb.Name = "SenderEmailAddresstb";
            this.SenderEmailAddresstb.Size = new System.Drawing.Size(244, 22);
            this.SenderEmailAddresstb.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Your Gmail:";
            // 
            // SendWarningLetterButton
            // 
            this.SendWarningLetterButton.Location = new System.Drawing.Point(531, 361);
            this.SendWarningLetterButton.Name = "SendWarningLetterButton";
            this.SendWarningLetterButton.Size = new System.Drawing.Size(112, 39);
            this.SendWarningLetterButton.TabIndex = 15;
            this.SendWarningLetterButton.Text = "Send Warning";
            this.SendWarningLetterButton.UseVisualStyleBackColor = true;
            this.SendWarningLetterButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // studentEmailtb
            // 
            this.studentEmailtb.Location = new System.Drawing.Point(193, 198);
            this.studentEmailtb.Name = "studentEmailtb";
            this.studentEmailtb.Size = new System.Drawing.Size(244, 22);
            this.studentEmailtb.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Student Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Enter Warning Text:";
            // 
            // WarningTExttb
            // 
            this.WarningTExttb.Location = new System.Drawing.Point(193, 267);
            this.WarningTExttb.Name = "WarningTExttb";
            this.WarningTExttb.Size = new System.Drawing.Size(343, 22);
            this.WarningTExttb.TabIndex = 16;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(649, 361);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(113, 39);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SendWarningLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.studentEmailtb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.WarningTExttb);
            this.Controls.Add(this.SendWarningLetterButton);
            this.Controls.Add(this.EmailPasswordtb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SenderEmailAddresstb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.accBalLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbStudentId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lebelx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WarningSubjecttb);
            this.Name = "SendWarningLetter";
            this.Text = "Send Warning (Admin)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox WarningSubjecttb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lebelx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbStudentId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label accBalLabel;
        private System.Windows.Forms.TextBox EmailPasswordtb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SenderEmailAddresstb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SendWarningLetterButton;
        private System.Windows.Forms.TextBox studentEmailtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox WarningTExttb;
        private System.Windows.Forms.Button CancelButton;
    }
}