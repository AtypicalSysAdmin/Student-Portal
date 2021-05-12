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
    public partial class ModifyCoursesAdmin : Form
    {
        public ModifyCoursesAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminEditCoursesButton_Click(object sender, EventArgs e)
        {
            string[] data = new string[6];

            if (this.CourseIDTextBox.Text != null || File.Exists(@"database\\Courses\\" + this.CourseIDTextBox.Text + "\\Info.txt"))
            {
                Admin obj = new Admin();
                data[0] = string.IsNullOrWhiteSpace(this.CourseNewNameTextBox.Text) ? " " : this.CourseNewNameTextBox.Text;
                data[1] = string.IsNullOrWhiteSpace(this.CourseNewSectionTextBox.Text) ? " " : this.CourseNewSectionTextBox.Text;
                data[2] = string.IsNullOrWhiteSpace(this.CourseNewCreditsTextBox.Text) ? " " : this.CourseNewCreditsTextBox.Text;
                data[3] = string.IsNullOrWhiteSpace(this.CourseNewInstructorTextBox.Text) ? " " : this.CourseNewInstructorTextBox.Text;
                data[4] = string.IsNullOrWhiteSpace(this.CourseNewPreReqTextBox.Text) ? " " : this.CourseNewPreReqTextBox.Text;
                data[5] = string.IsNullOrWhiteSpace(this.CourseNewCoReqTextBox.Text) ? " " : this.CourseNewCoReqTextBox.Text;
           
                obj.AdminEditsCourse(this.CourseIDTextBox.Text, data);
                if (!string.IsNullOrWhiteSpace(CourseNewCapTextBox.Text))
                {
                    obj.WriteNewLineData("database\\Courses\\"+CourseIDTextBox.Text+"\\","Capacity.txt",CourseNewCapTextBox.Text);
                }
                MessageBox.Show("Course's info was modified", "Successful Write");
                this.Close();
            }
            else
            {
                MessageBox.Show("Coures ID not found!");

            }
        }

        private void ModifyCoursesAdmin_Load(object sender, EventArgs e)
        {

        }

        private void AdminEditCourseCancelButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void CourseIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CourseInstructorLabel_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (this.CourseIDTextBox.Text != null || File.Exists(@"database\\Courses\\" + this.CourseIDTextBox.Text + "\\Info.txt"))
            {
                Admin obj = new Admin();
                string path = @"database\\Courses\\" + CourseIDTextBox.Text + "\\";
                obj.ReadAllLinesOfTextFile(path + "Info.txt");
                this.CourseNewNameTextBox.Text = DataBaseInterFace.fields[0];
                this.CourseNewSectionTextBox.Text = DataBaseInterFace.fields[1];
                this.CourseNewCreditsTextBox.Text = DataBaseInterFace.fields[2];
                this.CourseNewInstructorTextBox.Text = DataBaseInterFace.fields[3];
                this.CourseNewPreReqTextBox.Text = DataBaseInterFace.fields[4];
                this.CourseNewCoReqTextBox.Text = DataBaseInterFace.fields[5];

                string filepath = Path.Combine("database", "Courses", CourseIDTextBox.Text, "Capacity.txt");
                obj.ReadAllLinesOfTextFile(filepath);
                this.CourseNewCapTextBox.Text = DataBaseInterFace.fields[0];
            }
            else
            {
                MessageBox.Show("Coures ID not found!");
            }
        }
    }
}
