using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Portal
{
    public partial class SendEmailsAdmin : Form
    {
        public SendEmailsAdmin()
        {
            InitializeComponent();
        }

        private void AdminCancelSendEmailButton_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void AdminSendEmailButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.SenderEmailAddressTextBox.Text)||!string.IsNullOrWhiteSpace(this.EmailPasswordTextBox.Text))
            {
                string Att;
                DataBaseInterFace db = new DataBaseInterFace();
                if (string.IsNullOrWhiteSpace(AttachmentTextBox.Text))
                {
                    Att = " ";
                    db.SendEmail(this.SenderEmailAddressTextBox.Text, this.EmailPasswordTextBox.Text, this.TargetEmailAddressTextBox.Text,
                        Att, this.SubjectTextBox.Text, this.EmailBodyTextBox.Text);
                }
                else
                {
                    Att = AttachmentTextBox.Text;
                    db.SendEmail(this.SenderEmailAddressTextBox.Text, this.EmailPasswordTextBox.Text, this.TargetEmailAddressTextBox.Text,
                        Att, this.SubjectTextBox.Text, this.EmailBodyTextBox.Text);
                }
                MessageBox.Show("Email Sent!", "Successful");
            }
            else
            {
                MessageBox.Show("Invalid email or password!", "Error");
            }
        }

        OpenFileDialog openFileDialog = new OpenFileDialog();
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                AttachmentTextBox.Text = openFileDialog.FileName.ToString();
            }
        }
    }
}
