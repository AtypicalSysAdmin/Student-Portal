using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace Student_Portal
{
    class DataBaseInterFace
    {
        public static string[] fields=new string [7];
        public static string ID;
        public string password;


        public void ReadAllLinesOfTextFile(string filepath)
        {
            if (!File.Exists(filepath))
            {
                MessageBox.Show("File not found!", "Error");
            }
            else
            {
                List<string> lines = File.ReadAllLines(filepath).ToList();
                foreach (var line in lines)
                {
                    fields = line.Split(',');
                }
            }
            
        }

        public void ReadPasswordByID(string id, string path)
        {
            string filepath = @path + id + "\\" + "Password.txt";
           // MessageBox.Show(filepath);
            if (!Directory.Exists(path))
            {
                MessageBox.Show("File not found!", "Error");
            }
            else
            {
                //MessageBox.Show(filepath);
                StreamReader InputFile;
                InputFile = File.OpenText(filepath);
                while (!InputFile.EndOfStream)
                {
                    password = InputFile.ReadLine();
                }
                InputFile.Close();
            }

        }

        

        public void WriteNewLineData(string filepath, string filename,string dataline)
        {
            if (!File.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
                File.Create(filename).Close();
            }
           
            File.WriteAllText(filepath+filename, dataline);
            
                
        }

        public void AddNewLineData(string filepath, string filename, string dataline)
        {
            if (!File.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
                File.Create(filename).Close();
            }

            File.AppendAllText(filepath + filename, dataline+Environment.NewLine);
            
            
        }


        public bool Login(string id, string pass, string path)
        {
           
            if (!Directory.Exists(path))
            {
                MessageBox.Show("File not found!", "Error");
                return false;
            }
            else
            {
                ReadPasswordByID(id, path);
                if (pass == password)
                {
                    ID = id;

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void SendEmail(string SenderEmail, string SenderEmailPassword,string RecieverEmail, string AttachmentAddress,
            string Subject,string BodyText)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            MailMessage message = new MailMessage();
            message.From = new MailAddress(SenderEmail);
            message.To.Add(RecieverEmail);
            message.Subject = Subject;
            message.Body = BodyText;
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;

            if (AttachmentAddress != "")
            {
                message.Attachments.Add(new Attachment(AttachmentAddress));

            }

            client.Credentials = new System.Net.NetworkCredential(SenderEmail,SenderEmailPassword);
            client.Send(message);
            message = null;

        }

        public string ReadAccountBalanceByID(string id, string path)
        {
            string filepath = path + id + "\\Account Balance.txt";

            //MessageBox.Show(@filepath);

            if (!File.Exists(@filepath))
            {
                MessageBox.Show("File not found!", "Error");
                return " ";
            }
            else
            {
                
                String accBal = "No Data";
                StreamReader InputFile;
                InputFile = File.OpenText(@filepath);
                while (!InputFile.EndOfStream)
                {
                    accBal = InputFile.ReadLine();
                }
                InputFile.Close();
                return accBal;
            }
        }




    }
}

