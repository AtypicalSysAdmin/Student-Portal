using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;



namespace Student_Portal
{
    class Course:Student
    {
        public string ReadCourseInfoByID(string id)
        {
            string filepath = Path.Combine("database", "Courses", id, "Info.txt"); 
            //var absolutPath = Path.GetFullPath(filepath);
            //MessageBox.Show(absolutPath);
            string dataline=" ";
            if (!File.Exists(filepath))
            {
                MessageBox.Show("File not found!", "Error");
                return dataline;
            }
            else
            {

                StreamReader InputFile;
                InputFile = File.OpenText(filepath);
                while (!InputFile.EndOfStream)
                {
                    dataline = InputFile.ReadLine();
                }
                InputFile.Close();
                

                return dataline;
            }

        }




        public string GetCoursePreReqByID(string id)
        {
            //MessageBox.Show("Selected Course PreRequisite:"+ReadCourseInfoByID(id).Split(',')[4]);
            return ReadCourseInfoByID(id).Split(',')[4];

        }

        public string GetCourseCoReqByID(string id)
        {
            //MessageBox.Show(ReadCourseInfoByID(id).Split(',')[5]);
            return ReadCourseInfoByID(id).Split(',')[5];

        }

        public string GetCourseNameByID(string id)
        {
            
            //MessageBox.Show("Taken Course:"+ReadCourseInfoByID(id).Split(',')[0]);
            return ReadCourseInfoByID(id).Split(',')[0];

        }

        public int ReadCourseCapacityByID(string id)
        {
            string filepath = Path.Combine("database", "Courses", id, "Capacity.txt");
            //MessageBox.Show(filepath);
            int cap = 0;
            if (!File.Exists(@filepath))
            {
                MessageBox.Show("File not found!", "Error");
                return cap;
            }
            else
            {

                StreamReader InputFile;
                InputFile = File.OpenText(@filepath);
                while (!InputFile.EndOfStream)
                {
                    cap = Int32.Parse(InputFile.ReadLine());
                }
                InputFile.Close();
                return cap;
            }
        }

        public int GetCourseCredits(string id)
        {
            string filepath = Path.Combine("database", "Courses", id, "Info.txt");

            if (File.Exists(@filepath))
            {
                ReadAllLinesOfTextFile(filepath);
                return Int32.Parse(fields[2]);
            }
            else
            {
                return 0;
            }
        }

        public int GetCourseGPA(string id)
        {
            string filepath = "database\\Students\\" + ID + "\\Courses\\" +id+".txt" ;
            if (File.Exists(@filepath))
            {
                ReadAllLinesOfTextFile(filepath);
                return Int32.Parse(fields[0]);
            }
            else
            {
                return 0;
            }
        

      

        }

        public double TotalGPA()
        {


            string filepath = Path.Combine("database", "Students", ID, "Courses");
            //MessageBox.Show(filepath);
            DirectoryInfo dInfo = new DirectoryInfo(@filepath);
            FileInfo[] files = dInfo.GetFiles();

            if (files.Count() > 0)
            {
                int coursecredits;
                int totalcoursecredits=0;
                double totalcoursegpa=0;
               

                string courseID = " ";
                string[] AvailableCourses = new string[files.Count()];

                for (int i = 0; i < files.Count(); i++)
                {
                    courseID = Path.GetFileNameWithoutExtension(files[i].Name);
                    coursecredits = GetCourseCredits(courseID);
                    totalcoursecredits += coursecredits;

                    totalcoursegpa += GetCourseGPA(courseID)*coursecredits;

                }
                //MessageBox.Show(totalcoursecredits.ToString());
                //MessageBox.Show(totalcoursegpa.ToString());
                return totalcoursegpa/totalcoursecredits;
            }
            else
            {
                MessageBox.Show("No Courses Found!","Error");
                return 0;
            }
                    
        }



        //N
        public int GetCourseSection(string id)
        {
            string filepath = Path.Combine("database", "Courses", id, "Info.txt");
            //MessageBox.Show(filepath);
            if (File.Exists(@filepath))
            {
                ReadAllLinesOfTextFile(filepath);
                return Int32.Parse(fields[1]);
            }
            else
            {
                return 0;
            }


        }
        public string GetCourseName(string id)
        {
            string filepath = Path.Combine("database", "Courses", id, "Info.txt");
            //MessageBox.Show(filepath);
            if (File.Exists(@filepath))
            {
                ReadAllLinesOfTextFile(filepath);
                return fields[0];
            }
            else
            {
                return "Course Name";
            }


        }



    }
}
