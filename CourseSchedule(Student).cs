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
    public partial class CourseSchedule : Form
    {
        Course obj = new Course();

        public CourseSchedule()
        {
            InitializeComponent();
        }

        private void courseScheduleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CourseSchedule_Load(object sender, EventArgs e)
        {







            courseScheduleListBox.Items.Clear();

            DirectoryInfo dInfo = new DirectoryInfo(@"database\\Students\\" + DataBaseInterFace.ID + "\\Courses\\");
            FileInfo[] files = dInfo.GetFiles();

            if (files.Count() > 0)
            {

                
                //Course obj = new Course();
                string fileName = " ";
                string[] CoursesArr = new string[files.Count()];

                for (int i = 0; i < files.Count(); i++)
                {
                    fileName = Path.GetFileNameWithoutExtension(files[i].Name);

                    //MessageBox.Show(fileName);

                    
                        CoursesArr[i] = "Course: " + obj.GetCourseName(fileName) + " , " + " Section: "+ obj.GetCourseSection(fileName);
                   

                }
                courseScheduleListBox.Items.AddRange(CoursesArr);

                TotalGPALabel.Text = obj.TotalGPA().ToString();
            }
            else
            {
                MessageBox.Show("No courses found :(", "Error");
                this.Close();
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
