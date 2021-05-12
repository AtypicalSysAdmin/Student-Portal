using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Student_Portal
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void StudentForgotIDButton_Click(object sender, EventArgs e)
        {

        }
        
        private void AdminIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AdminIDTextBox.Text) || string.IsNullOrWhiteSpace(AdminPasswordTextBox.Text))
            {
                MessageBox.Show("Please Enter a valid admin ID or Password to login!", "Error");
            }
            else
            {
                if (Directory.Exists("database\\Admins\\"+AdminIDTextBox.Text))
                {
                    Admin obj = new Admin();
                    if (obj.Login(AdminIDTextBox.Text, AdminPasswordTextBox.Text,"database\\Admins\\"))
                    {
                        //MessageBox.Show(DataBaseInterFace.ID);
                        AdminMainPage f = new AdminMainPage();
                        f.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Wrong password!", "Login Error");
                    }
                }
                else
                {
                    MessageBox.Show("ID not found!", "Login Error");
                }
            }
        }

        private void LoginStudentButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StudentIDTextBox.Text) || string.IsNullOrWhiteSpace(StudentIDTextBox.Text))
            {
                MessageBox.Show("Please Enter a valid admin ID or Password to login!", "Error");
            }
            else
            {
                if (Directory.Exists("database\\Students\\" + StudentIDTextBox.Text))
                {
                    Student obj = new Student();
                    if (obj.Login(StudentIDTextBox.Text, StudentPasswordTextBox.Text, "database\\Students\\"))
                    {
                        StudentMainPage f = new StudentMainPage();
                        f.Show();

                    }
                    else
                    {
                        MessageBox.Show("Wrong password!", "Login Error");
                    }
                }
                else
                {
                    MessageBox.Show("ID not found!", "Login Error");
                }
            }
        }
    }
}
