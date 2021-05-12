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
    public partial class StudentMainPage : Form
    {
        public StudentMainPage()
        {
            InitializeComponent();
        }

        private void StudentRegisterationButton_Click(object sender, EventArgs e)
        {
            Registration F = new Registration();
            F.Show();
            
        }

        private void StudentCoursesButton_Click(object sender, EventArgs e)
        {
            CourseSchedule f = new CourseSchedule();
            f.Show();
            
        }

        private void StudentEditInfoButton_Click(object sender, EventArgs e)
        {
            EditPersonalInformation f = new EditPersonalInformation();
            f.Show();
            
        }

        private void StudentMakePaymentButton_Click(object sender, EventArgs e)
        {
            Payment f = new Payment();
            f.Show();
            
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            StudentChangePassword f = new StudentChangePassword();
            f.Show();
            
        }
    }
}
