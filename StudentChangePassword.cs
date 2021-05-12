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
    public partial class StudentChangePassword : Form
    {
        public StudentChangePassword()
        {
            InitializeComponent();
        }

        private void UpdatePasswordButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.NewPasswordTextBox.Text) || !string.IsNullOrWhiteSpace(this.NewPasswordReEntryTextBox2.Text))
            {
                if (this.NewPasswordTextBox.Text == this.NewPasswordReEntryTextBox2.Text)
                {
                    Student obj = new Student();
                    obj.StudentChangesPassword(this.NewPasswordTextBox.Text, DataBaseInterFace.ID);
                    MessageBox.Show("Password successfuly changed!", "Successful Write");
                }
                else
                {
                    MessageBox.Show("Passwords are not match!", "Error");
                }
            }
            else
            {
                MessageBox.Show("No empty fields allowed to change password!", "Error");
            }
        }
    }
}
