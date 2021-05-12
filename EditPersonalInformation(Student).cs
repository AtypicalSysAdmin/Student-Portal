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
    public partial class EditPersonalInformation : Form
    {
        public EditPersonalInformation()
        {
            InitializeComponent();
        }

        private void StudentCancelsInfoChangeButton_Click(object sender, EventArgs e)
        {
      
            this.Close();
        }

        private void StudentConfirmsNewInfoButton_Click(object sender, EventArgs e)
        {
            string[] data = new string[5];

           
                Student obj = new Student();
                data[0] = string.IsNullOrWhiteSpace(this.StudentNewPhoneTextBox.Text) ? " " : this.StudentNewPhoneTextBox.Text;
                data[1] = string.IsNullOrWhiteSpace(this.StudentNewEmailTextBox.Text) ? " " : this.StudentNewEmailTextBox.Text;
                data[2] = string.IsNullOrWhiteSpace(this.StudentNewSuiteTextBox.Text) ? " " : this.StudentNewSuiteTextBox.Text;
                data[3] = string.IsNullOrWhiteSpace(this.StudentNewStreetNumTextBox.Text) ? " " : this.StudentNewStreetNumTextBox.Text;
                data[4] = string.IsNullOrWhiteSpace(this.StudentNewPostalCodeTextBox.Text) ? " " : this.StudentNewPostalCodeTextBox.Text;
                
                obj.EditPersonalInfo(DataBaseInterFace.ID, data);
                MessageBox.Show("Student's info was modified", "Successful Write");
                this.Close();
           
        }

        private void EditPersonalInformation_Load(object sender, EventArgs e)
        {
            Student obj = new Student();
            string path = @"database\\Students\\" + DataBaseInterFace.ID + "\\";
            obj.ReadAllLinesOfTextFile(path + "Info.txt");
            this.StudentNewPhoneTextBox.Text = DataBaseInterFace.fields[2];
            this.StudentNewEmailTextBox.Text = DataBaseInterFace.fields[3];
            this.StudentNewSuiteTextBox.Text = DataBaseInterFace.fields[4];
            this.StudentNewStreetNumTextBox.Text = DataBaseInterFace.fields[5];
            this.StudentNewPostalCodeTextBox.Text = DataBaseInterFace.fields[6];
        }
    }
}
