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
    public partial class Registration : Form
    {
        Course obj = new Course();
        


        public Registration()
        {
            InitializeComponent();
        }

        private void SelectedCourseslistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancelRegistrationButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void RegistrationCourseslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }



        private void Registration_Load(object sender, EventArgs e)
        {
            RegistrationCourseslistBox.Items.Clear();

            DirectoryInfo dInfo = new DirectoryInfo(@"database\\Courses");
            DirectoryInfo[] files = dInfo.GetDirectories();

            if (files.Count() > 0)
            {
                //Course obj = new Course();
                string fileName = " ";
                string[] AvailableCourses = new string[files.Count()];

                for (int i = 0; i < files.Count(); i++)
                {
                    fileName = Path.GetFileName(files[i].Name);

                    //MessageBox.Show(fileName);

                    if (obj.ReadCourseCapacityByID(fileName) == 0)
                    {
                        AvailableCourses[i] = "Unavailable:" + fileName + "," + obj.ReadCourseInfoByID(fileName);
                    }
                    else
                    {
                        AvailableCourses[i] = "Available:" + fileName + "," + obj.ReadCourseInfoByID(fileName);
                    }

                }
                RegistrationCourseslistBox.Items.AddRange(AvailableCourses);
            }
            else
            {
                MessageBox.Show("No courses found!", "Error");
            }

        }














        private void RegisterCoursesButton_Click(object sender, EventArgs e)
        {
            //Acount balance check
            if (Int32.Parse(obj.StudentGetAccountBal()) == 0)
            {
                int i = SelectedCoursesListBox.Items.Count-1 ;

                //MessageBox.Show(i.ToString());

                string[] selectedcourseID = new string[i+1];
                string filepath = @"database\\Students\\" + DataBaseInterFace.ID + "\\Courses\\";
                while (i != -1)
                {

                    
                    selectedcourseID[i] = SelectedCoursesListBox.Items[i].ToString().Split(',')[0];
                    obj.WriteNewLineData(filepath, selectedcourseID[i] + ".txt", "0");

                    i--;
                }

                MessageBox.Show("Courses were registered successfully!", "Successful");
                this.Close();
            }
            else
            {
                MessageBox.Show("You have over due balance!\nPay amount in order to be able to register courses", "Error");
            }

        }


        //Checks whehter current section is selected or not

        public bool AvailableSection(string section)
        {
            bool available = true;
            string coursesection = " ";
            for (int i = 0; i < SelectedCoursesListBox.Items.Count; i++)
            {
                coursesection = SelectedCoursesListBox.Items[i].ToString().Split(',')[2];
                if (section == coursesection)
                {
                    available = false;
                }
            }

            return available;
        }


        bool PreReqIsTaken(string id)
        {
            bool taken = false;

            string prereq = obj.GetCoursePreReqByID(id);
            if (prereq == "NaN")
            {
                taken = true;
                return taken;
            }

            string filepath = Path.Combine("database", "Students", DataBaseInterFace.ID, "Courses");
            //MessageBox.Show(filepath);
            DirectoryInfo dInfo = new DirectoryInfo(@filepath);
            FileInfo[] files = dInfo.GetFiles();

            if (files.Count() > 0)
            {

                //Course obj = new Course();
                string fileName = " ";
                string[] AvailableCourses = new string[files.Count()];

                for (int i = 0; i < files.Count(); i++)
                {
                    fileName = Path.GetFileNameWithoutExtension(files[i].Name);

                    if (obj.GetCourseNameByID(fileName) == prereq)
                    {
                        taken = true;
                        return taken;
                    }

                }
            }

            return taken;
        }


        bool CoReqIsTaken(string id)
        {
            bool taken = false;

            string coreq = obj.GetCourseCoReqByID(id);
            if (coreq == "NaN")
            {
                taken = true;
                return taken;
            }

            string filepath = Path.Combine("database", "Students", DataBaseInterFace.ID, "Courses");
            //MessageBox.Show(filepath);
            DirectoryInfo dInfo = new DirectoryInfo(@filepath);
            FileInfo[] files = dInfo.GetFiles();

            if (files.Count() > 0)
            {

                //Course obj = new Course();
                string fileName = " ";
                string[] AvailableCourses = new string[files.Count()];

                for (int i = 0; i < files.Count(); i++)
                {
                    fileName = Path.GetFileNameWithoutExtension(files[i].Name);

                    if (obj.GetCourseNameByID(fileName) == coreq)
                    {
                        taken = true;
                        return taken;
                    }

                }



               

            }


            if (SelectedCoursesListBox.Items.Count > 0)
            {

                for (int i = 0; i < files.Count(); i++)
                {
                    string selectedcourseid = SelectedCoursesListBox.Items[i].ToString().Split(',')[0];
                    obj.GetCourseNameByID(selectedcourseid);
                    //MessageBox.Show("Selected list coreq is:" + obj.GetCourseNameByID(selectedcourseid));
                    if (obj.GetCourseNameByID(selectedcourseid) == coreq)
                    {
                        taken = true;
                        return taken;
                    }

                }

                return taken;
            }

            return taken;


        }



        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            if (RegistrationCourseslistBox.SelectedItem != null)
            {

                string[] courseinfo = RegistrationCourseslistBox.SelectedItem.ToString().Split(':');
                string courseID = courseinfo[1].Split(',')[0];

                if (SelectedCoursesListBox.FindString(courseinfo[1]) == -1)
                {

                    //SelectedCoursesListBox.Items.Add(RegistrationCourseslistBox.SelectedItem.ToString());
                    Course obj = new Course();

                    //MessageBox.Show(courseID);


                    //Checks if course is not full

                    if (courseinfo[0] == "Available")
                    {
                        //Checks wheather the section is already taken or not
                        if (AvailableSection(courseinfo[1].Split(',')[2]))
                        {



                            if (PreReqIsTaken(courseID)&&CoReqIsTaken(courseID))
                            {

                                SelectedCoursesListBox.Items.Add(courseinfo[1]);
                                // if course section not found
                                int cap = obj.ReadCourseCapacityByID(courseID);
                                cap--;
                                string path = @"database\\Courses\\" + courseID + "\\";
                                obj.WriteNewLineData(path, "Capacity.txt", cap.ToString());


                                RegistrationCourseslistBox.Items.Clear();

                                DirectoryInfo dInfo = new DirectoryInfo(@"database\\Courses");
                                DirectoryInfo[] files = dInfo.GetDirectories();

                                if (files.Count() > 0)
                                {
                                    //Course obj = new Course();
                                    string fileName = " ";
                                    string[] AvailableCourses = new string[files.Count()];

                                    for (int i = 0; i < files.Count(); i++)
                                    {
                                        fileName = Path.GetFileName(files[i].Name);

                                        //MessageBox.Show(fileName);

                                        if (obj.ReadCourseCapacityByID(fileName) == 0)
                                        {
                                            AvailableCourses[i] = "Unavailable:" + fileName + "," + obj.ReadCourseInfoByID(fileName);
                                        }
                                        else
                                        {
                                            AvailableCourses[i] = "Available:" + fileName + "," + obj.ReadCourseInfoByID(fileName);
                                        }

                                    }
                                    RegistrationCourseslistBox.Items.AddRange(AvailableCourses);
                                }
                                else
                                {
                                    MessageBox.Show("No courses found!", "Error");
                                }

                            }

                            else
                            {
                                MessageBox.Show("Pre-Requisite or Co-Requisite course is required!", "Error");
                            }

                        }

                        else
                        {
                            MessageBox.Show("This section is already selected!", "Time Conflict");
                        }


                    }
                    else
                    {
                        MessageBox.Show("This Course is not available!","Error");
                    }

                   
                }
                else
                {
                    MessageBox.Show("This Course is already added!","Error");
                }

            }
            else
            {
                MessageBox.Show("A course must be selected to add!", "Error");
            }

        }






        private void DropCourseButton_Click(object sender, EventArgs e)
        {

            if (SelectedCoursesListBox.SelectedItem != null)
            {

                Course obj = new Course();
                string courseinfo = SelectedCoursesListBox.SelectedItem.ToString();
                string courseID = courseinfo.Split(',')[0];
                //MessageBox.Show(courseID);
                int cap = obj.ReadCourseCapacityByID(courseID);
                cap++;
                string path = @"database\\Courses\\" + courseID + "\\";
                obj.WriteNewLineData(path, "Capacity.txt", cap.ToString());
                SelectedCoursesListBox.Items.Remove(SelectedCoursesListBox.SelectedItem);


                RegistrationCourseslistBox.Items.Clear();

                DirectoryInfo dInfo = new DirectoryInfo(@"database\\Courses");
                DirectoryInfo[] files = dInfo.GetDirectories();

                if (files.Count() > 0)
                {
                    //Course obj = new Course();
                    string fileName = " ";
                    string[] AvailableCourses = new string[files.Count()];

                    for (int i = 0; i < files.Count(); i++)
                    {
                        fileName = Path.GetFileName(files[i].Name);

                        //MessageBox.Show(fileName);

                        if (obj.ReadCourseCapacityByID(fileName) == 0)
                        {
                            AvailableCourses[i] = "Unavailable:" + fileName + "," + obj.ReadCourseInfoByID(fileName);
                        }
                        else
                        {
                            AvailableCourses[i] = "Available:" + fileName + "," + obj.ReadCourseInfoByID(fileName);
                        }

                    }
                    RegistrationCourseslistBox.Items.AddRange(AvailableCourses);
                }
                else
                {
                    MessageBox.Show("No courses found!", "Error");
                }

            }

            else
            {
                MessageBox.Show("A course must be selected to drop!", "Error");
            }

        }
    
    }

}
