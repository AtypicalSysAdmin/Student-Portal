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
    public partial class AdminChangePassword : Form
    {
        public AdminChangePassword()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelChangePasswordButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReEnterNewPasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void NewPasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void NewPasswordReEntryTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdatePasswordButton_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(this.NewPasswordTextBox.Text) || !string.IsNullOrWhiteSpace(this.NewPasswordReEntryTextBox2.Text)){
                if (this.NewPasswordTextBox.Text == this.NewPasswordReEntryTextBox2.Text) {
                    Admin obj = new Admin();
                    
                    obj.AdminChangesPassword(this.NewPasswordTextBox.Text,DataBaseInterFace.ID);
                    MessageBox.Show("Password successfuly changed!", "Successful Write");
                }
                else
                {
                    MessageBox.Show("Passwords are not match!", "Error");
                }
            }
            else
            {
                MessageBox.Show("No empty fields allowed to change password!","Error");
            }
        }
    }
}
