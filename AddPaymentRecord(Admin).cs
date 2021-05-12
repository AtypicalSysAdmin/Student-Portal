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
    public partial class AddPaymentRecord : Form
    {
        public AddPaymentRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(StudentIDTextBox.Text)|| !string.IsNullOrWhiteSpace(PaymentAmountTextBox.Text)||
                !string.IsNullOrWhiteSpace(PaymentDateTextBox.Text))
            {
                string data = PaymentAmountTextBox.Text + "," + PaymentDateTextBox.Text;
                Admin obj = new Admin();
                obj.AdminAddNewPaymentRecord(this.StudentIDTextBox.Text, data);
                MessageBox.Show("Record was added successfully!","Successful Write");
            }
            else
            {
                MessageBox.Show("No empty text boxes are allowed!","Error");
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
