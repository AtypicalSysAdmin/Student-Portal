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
    public partial class AdminMainPage : Form
    {
        public AdminMainPage()
        {
            InitializeComponent();
        }

        private void AdminRegisterNewStudentButton_Click(object sender, EventArgs e)
        {
            RegisterNewStudentAdmin F = new RegisterNewStudentAdmin();
            F.Show();
            
        }

        private void AdminSendEmailButton_Click(object sender, EventArgs e)
        {
            SendEmailsAdmin f = new SendEmailsAdmin();
            f.Show();
            
        }

        private void AdminModifyStudentsButton_Click(object sender, EventArgs e)
        {
            ModifyStudentInfoAdmin f = new ModifyStudentInfoAdmin();
            f.Show();
            
        }

        private void AdminModifyCoursesButton_Click(object sender, EventArgs e)
        {
            ModifyCoursesAdmin f = new ModifyCoursesAdmin();
            f.Show();
            
        }

        private void AdminAddNewCourseButton_Click(object sender, EventArgs e)
        {
            AddNewCourseAdmin f = new AddNewCourseAdmin();
            f.Show();
            
        }

        private void AdminChangePasswordButton_Click(object sender, EventArgs e)
        {
            AdminChangePassword f = new AdminChangePassword();
            f.Show();
            
        }

        private void AdminMainPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPaymentRecord f = new AddPaymentRecord();
            f.Show();
        }

        private void SendWarningLetterButton_Click(object sender, EventArgs e)
        {
            SendWarningLetter f = new SendWarningLetter();
            f.Show();
        }
    }
}
