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
    public partial class AddNewCourseAdmin : Form
    {
        public AddNewCourseAdmin()
        {
            InitializeComponent();
        }

        private void AdminNewCourseNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelAddCourseAdminButton_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void SubmitNewCourseAdminButton_Click(object sender, EventArgs e)
        {
            Admin obj = new Admin();
            string name, section, credits, instructor, PreReq, CoReq, Cap;
            name = string.IsNullOrWhiteSpace(AdminNewCourseNameTextBox.Text) ? "NaN" : AdminNewCourseNameTextBox.Text;
            section= string.IsNullOrWhiteSpace(AdminNewCourseSectionTextBox.Text) ? "NaN" : AdminNewCourseSectionTextBox.Text;
            credits= string.IsNullOrWhiteSpace(AdminNewCourseCreditsTextBox.Text) ? "NaN" : AdminNewCourseCreditsTextBox.Text;
            instructor= string.IsNullOrWhiteSpace(AdminNewCourseInstructorTextBox.Text) ? "NaN" : AdminNewCourseInstructorTextBox.Text;
            PreReq= string.IsNullOrWhiteSpace(AdminNewCoursePreReqTextBox.Text) ? "NaN" : AdminNewCoursePreReqTextBox.Text;
            CoReq=string.IsNullOrWhiteSpace(AdminNewCourseCoReqTextBox.Text) ? "NaN " : AdminNewCourseCoReqTextBox.Text;
            Cap = string.IsNullOrWhiteSpace(AdminNewCourseCapTextBox.Text) ? "NaN" : AdminNewCourseCapTextBox.Text;
           
            obj.AdminAddNewCourse(name, section, credits, instructor, PreReq, CoReq,Cap);
            MessageBox.Show("Course was added to database file succcessfully!", "Successful write");
            this.Close();
        }

        private void AdminNewCourseCoReqTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
