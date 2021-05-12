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
    public partial class ModifyStudentInfoAdmin : Form
    {
        public ModifyStudentInfoAdmin()
        {
            InitializeComponent();
        }

        private void AdminCancelStudentInfoChangeButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        

        private void StudentIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentNewCreditsLabel_Click(object sender, EventArgs e)
        {

        }

        private void EditFirstNameButton_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminEditsNewStudentButton_Click(object sender, EventArgs e)
        {
           
            string[] data= new string[7];
           
            if (this.StudentIDTextBox.Text != null || File.Exists(@"database\\Students\\" + this.StudentIDTextBox.Text+"\\Info.txt"))
            {
                Admin obj = new Admin();
                data[0] = string.IsNullOrWhiteSpace(this.NewFirstNameTextBox.Text) ? " " : this.NewFirstNameTextBox.Text;
                data[1] = string.IsNullOrWhiteSpace(this.NewLastNameTextBox.Text) ? " " : this.NewLastNameTextBox.Text;
                data[2] = string.IsNullOrWhiteSpace(this.NewPhoneTextBox.Text) ? " " : this.NewPhoneTextBox.Text;
                data[3] = string.IsNullOrWhiteSpace(this.NewEmailTextBox.Text) ? " " : this.NewEmailTextBox.Text;
                data[4] = string.IsNullOrWhiteSpace(this.NewSuiteTextBox.Text) ? " " : this.NewSuiteTextBox.Text;
                data[5] = string.IsNullOrWhiteSpace(this.NewStreetNumTextBox.Text) ? " " : this.NewStreetNumTextBox.Text;
                data[6] = string.IsNullOrWhiteSpace(this.NewPostalCodeTextBox.Text) ? " " : this.NewPostalCodeTextBox.Text;
                obj.AdminEditsStudent(this.StudentIDTextBox.Text,data);
                MessageBox.Show("Student's info was modified", "Successful Write");
                this.Close();
            }
            else
            {
                MessageBox.Show("Student ID not found!");

            }
           
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (this.StudentIDTextBox.Text != null || Directory.Exists(@"database\\Students\\" + this.StudentIDTextBox.Text + "\\Info.txt"))
            {
                Admin obj = new Admin();
                string path = @"database\\Students\\" + StudentIDTextBox.Text + "\\";
                obj.ReadAllLinesOfTextFile(path + "Info.txt");
                this.NewFirstNameTextBox.Text = DataBaseInterFace.fields[0];
                this.NewLastNameTextBox.Text = DataBaseInterFace.fields[1];
                this.NewPhoneTextBox.Text = DataBaseInterFace.fields[2];
                this.NewEmailTextBox.Text = DataBaseInterFace.fields[3];
                this.NewSuiteTextBox.Text = DataBaseInterFace.fields[4];
                this.NewStreetNumTextBox.Text = DataBaseInterFace.fields[5];
                this.NewPostalCodeTextBox.Text = DataBaseInterFace.fields[6];
            }
            else
            {
                MessageBox.Show("Student ID not found!");
            }
        }
    }
}
