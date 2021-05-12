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
    public partial class SendWarningLetter : Form
    {
        private DataTable dtDues = new DataTable();
        private string emailSt = "";
       private  string studentID;
       private  string fname;
       private  string lname;
       private  string accbal;
        private DataBaseInterFace db = new DataBaseInterFace();
        private Admin admin = new Admin();
        public SendWarningLetter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FillTable()
        {
            dtDues.Columns.Add("StudentID");
            dtDues.Columns.Add("Due Amount");


            dtDues.Rows.Add("1","abjb");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            studentID = this.tbStudentId.Text;
            string path = @"database\\Students\\" + studentID + "\\"+"Info.txt";

            db.ReadAllLinesOfTextFile(path);
            emailSt = DataBaseInterFace.fields[3];
            fname = DataBaseInterFace.fields[0];
            accbal=admin.AdminGetAccountBal(studentID);

            this.accBalLabel.Text = accbal;
            this.studentEmailtb.Text =emailSt;
            this.WarningSubjecttb.Text ="Warning letter for submission of due fees";
            this.WarningTExttb.Text ="Hi "+fname+", your fee: "+accbal+" is pending.\n Kindly submit this amount as soon as possible, You would be in trouble in either cases";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.SenderEmailAddresstb.Text) || !string.IsNullOrWhiteSpace(this.EmailPasswordtb.Text))
            {
                db.SendEmail(this.SenderEmailAddresstb.Text, this.EmailPasswordtb.Text, this.studentEmailtb.Text,
                        " ", this.WarningSubjecttb.Text, this.WarningTExttb.Text);
                MessageBox.Show("Letter Sent!", "Successful");
            }
            else
            {
                MessageBox.Show("Invalid email or password!", "Error");
            }
        }

        private void accBalLabel_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
