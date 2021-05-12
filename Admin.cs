using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Student_Portal
{
    class Admin:DataBaseInterFace 
    {


        public int GenerateStudentID()
        {
            Random studentID = new Random();
            int id=studentID.Next(100000, 1000000);
            while (Directory.Exists(@"database\\Students\\" + id.ToString()))
            {
                id = studentID.Next(100000, 1000000);
            }
            return id;
        }



        public string GenerateRandomTempPassword()
        {
            string password;
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            password = new string(stringChars); 
            return password;
        }



        public void AdminAddNewCourse(string name, string section, string credit, string instructor, string PreReq, string CoReq, string Cap)
        {

            int id= System.IO.Directory.GetDirectories(@"database\\Courses\\").Length+1;
            string path = @"database\\Courses\\00" + id.ToString()+"\\";
            string dataline = name + ','+ section + ',' + credit + ',' + instructor + ',' + PreReq + ','+CoReq;
            WriteNewLineData(path, "Capacity.txt", Cap);
            WriteNewLineData(path, "Info.txt", dataline);
        } 



        public void AdminRegisterNewStudent(string dataline)
        {
            string id = GenerateStudentID().ToString();
            string path = @"database\\Students\\" + id+"\\";
            WriteNewLineData(path, "Info.txt", dataline);
            string pathForpassword = @"database\\Students\\" + id+"\\";
            string tempPass = GenerateRandomTempPassword();
            WriteNewLineData(pathForpassword,"Password.txt", tempPass);
        }

        public void AdminEditsStudent(string id, string[] Data)
        {
            int i = 0;
            string path = @"database\\Students\\" + id + "\\";
            ReadAllLinesOfTextFile(path+"Info.txt");
            for (i= 0; i < Data.Length; i++)
            {
                if (Data[i]!=" ")
                {
                    fields[i] = Data[i];
                }
            }
            
            string dataline = String.Join(",", fields);
            WriteNewLineData(path,"Info.txt",dataline); 
   
        }



        public void AdminEditsCourse(string id, string[] Data)
        {
            int i = 0;
            string path = @"database\\Courses\\" + id + "\\";
            ReadAllLinesOfTextFile(path + "Info.txt");
            for (i = 0; i < Data.Length; i++)
            {
                if (Data[i] != " ")
                {
                    fields[i] = Data[i];
                }
            }

            string dataline = String.Join(",", fields);
            WriteNewLineData(path, "Info.txt", dataline);

        }


        public void AdminChangesPassword(string newPass, string id)
        {
            
            string path = @"database\\Admins\\" + id + "\\";
            WriteNewLineData(path, "Password.txt", newPass);
        }

        public void AdminAddNewPaymentRecord(string id, string dataline)
        {
            string path = @"database\\Students\\"+id+"\\";
            AddNewLineData(path, "PaymentHistory.txt", dataline);
        }


        public string AdminGetAccountBal(string id)
        {
            string path = @"database\\Students\\";
            return ReadAccountBalanceByID(id, path);
        }



    }
}
