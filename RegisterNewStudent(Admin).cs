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
    public partial class RegisterNewStudentAdmin : Form
    {
        public RegisterNewStudentAdmin()
        {
            InitializeComponent();
        }

        private void NewStudentNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminCancelRegisterButton_Click(object sender, EventArgs e)
        {
        
            this.Close();
        }

        private void AdminRegisterNewStudentButton_Click(object sender, EventArgs e)
        {
            Admin obj = new Admin();
            string firstname, lastname, phone, email, suite, street, postalcode;
            firstname = string.IsNullOrWhiteSpace(NewStudentFirstNameTextBox.Text) ? "NaN" : NewStudentFirstNameTextBox.Text;
            lastname = string.IsNullOrWhiteSpace(NewStudentLastNameTextBox.Text) ? "NaN" : NewStudentLastNameTextBox.Text;
            phone = string.IsNullOrWhiteSpace(NewStudentPhoneTextBox.Text) ? "NaN" : NewStudentPhoneTextBox.Text;
            email = string.IsNullOrWhiteSpace(NewStudentEmailTextBox.Text) ? "NaN" : NewStudentEmailTextBox.Text;
            suite = string.IsNullOrWhiteSpace(NewStudentSuiteTextBox.Text) ? "NaN" : NewStudentSuiteTextBox.Text;
            street = string.IsNullOrWhiteSpace(NewStudentStNumTextBox.Text) ? "NaN " : NewStudentStNumTextBox.Text;
            postalcode = string.IsNullOrWhiteSpace(NewStudentPostalCodeTextBox.Text) ? "NaN" : NewStudentPostalCodeTextBox.Text;

            string dataline=firstname + ',' +lastname + ',' + phone + ',' + email + ',' + suite + ',' + street+ ',' + postalcode ;
            obj.AdminRegisterNewStudent(dataline);
            MessageBox.Show("Entered data was added to the database file successfully!", "Successful write");
            this.Close();
        }
    }
}
