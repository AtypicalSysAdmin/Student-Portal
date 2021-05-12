namespace Student_Portal
{
    partial class AddPaymentRecord
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
            this.PaymentAmountLabel = new System.Windows.Forms.Label();
            this.StudentIDLabel = new System.Windows.Forms.Label();
            this.PaymentDateLabel = new System.Windows.Forms.Label();
            this.AddRecordButton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.StudentIDTextBox = new System.Windows.Forms.TextBox();
            this.PaymentAmountTextBox = new System.Windows.Forms.TextBox();
            this.PaymentDateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PaymentAmountLabel
            // 
            this.PaymentAmountLabel.AutoSize = true;
            this.PaymentAmountLabel.Location = new System.Drawing.Point(25, 74);
            this.PaymentAmountLabel.Name = "PaymentAmountLabel";
            this.PaymentAmountLabel.Size = new System.Drawing.Size(119, 17);
            this.PaymentAmountLabel.TabIndex = 0;
            this.PaymentAmountLabel.Text = "Payment Amount:";
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Location = new System.Drawing.Point(25, 42);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(78, 17);
            this.StudentIDLabel.TabIndex = 1;
            this.StudentIDLabel.Text = "Studetn ID:";
            // 
            // PaymentDateLabel
            // 
            this.PaymentDateLabel.AutoSize = true;
            this.PaymentDateLabel.Location = new System.Drawing.Point(25, 106);
            this.PaymentDateLabel.Name = "PaymentDateLabel";
            this.PaymentDateLabel.Size = new System.Drawing.Size(189, 17);
            this.PaymentDateLabel.TabIndex = 2;
            this.PaymentDateLabel.Text = "Payment Date: (yyyy/mm/dd)";
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.Location = new System.Drawing.Point(556, 387);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(104, 36);
            this.AddRecordButton.TabIndex = 3;
            this.AddRecordButton.Text = "Add Record";
            this.AddRecordButton.UseVisualStyleBackColor = true;
            this.AddRecordButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(675, 387);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(104, 36);
            this.Cancelbutton.TabIndex = 4;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // StudentIDTextBox
            // 
            this.StudentIDTextBox.Location = new System.Drawing.Point(326, 37);
            this.StudentIDTextBox.Name = "StudentIDTextBox";
            this.StudentIDTextBox.Size = new System.Drawing.Size(226, 22);
            this.StudentIDTextBox.TabIndex = 5;
            // 
            // PaymentAmountTextBox
            // 
            this.PaymentAmountTextBox.Location = new System.Drawing.Point(326, 65);
            this.PaymentAmountTextBox.Name = "PaymentAmountTextBox";
            this.PaymentAmountTextBox.Size = new System.Drawing.Size(226, 22);
            this.PaymentAmountTextBox.TabIndex = 6;
            // 
            // PaymentDateTextBox
            // 
            this.PaymentDateTextBox.Location = new System.Drawing.Point(326, 93);
            this.PaymentDateTextBox.Name = "PaymentDateTextBox";
            this.PaymentDateTextBox.Size = new System.Drawing.Size(226, 22);
            this.PaymentDateTextBox.TabIndex = 7;
            // 
            // AddPaymentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PaymentDateTextBox);
            this.Controls.Add(this.PaymentAmountTextBox);
            this.Controls.Add(this.StudentIDTextBox);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.AddRecordButton);
            this.Controls.Add(this.PaymentDateLabel);
            this.Controls.Add(this.StudentIDLabel);
            this.Controls.Add(this.PaymentAmountLabel);
            this.Name = "AddPaymentRecord";
            this.Text = "Add Payment Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PaymentAmountLabel;
        private System.Windows.Forms.Label StudentIDLabel;
        private System.Windows.Forms.Label PaymentDateLabel;
        private System.Windows.Forms.Button AddRecordButton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.TextBox StudentIDTextBox;
        private System.Windows.Forms.TextBox PaymentAmountTextBox;
        private System.Windows.Forms.TextBox PaymentDateTextBox;
    }
}