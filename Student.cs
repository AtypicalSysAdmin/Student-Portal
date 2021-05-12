using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Student_Portal
{
    
    class Student : DataBaseInterFace
    {
        private PrintDocument printDocument1 = new PrintDocument();
        public void PrintPaymentHistory(string id)
        {
            string docName = "PaymentHistory.txt";
            string docPath = @"database\\Students" + id + "\\";
            printDocument1.DocumentName = docName;
            printDocument1.Print();
            MessageBox.Show("Successful Print","Done");
        }

        public void StudentChangesPassword(string newPass, string id)
        {
            string path = @"database\\Students\\" + id + "\\";
            WriteNewLineData(path, "Password.txt", newPass);
        }

        public void EditPersonalInfo(string id, string[] Data)
        {
            int i = 0;
            string path = @"database\\Students\\" + id + "\\";
            ReadAllLinesOfTextFile(path + "Info.txt");
            for (i = 0; i < Data.Length; i++)
            {
                if (Data[i] != " ")
                {
                    fields[i+2] = Data[i];
                }
            }

            string dataline = String.Join(",", fields);
            WriteNewLineData(path, "Info.txt", dataline);

        }


        public string StudentGetAccountBal()
        {
            string id = DataBaseInterFace.ID;
            string path = "database\\Students\\";
            return ReadAccountBalanceByID(id, path);
        }


    }
    
}
