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
    public partial class Payment : Form
    {
        

        public Payment()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void Print_Click(object sender, EventArgs e)
        {
           
            
         Student obj = new Student();
         obj.PrintPaymentHistory(DataBaseInterFace.ID);
            
          
            

        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }
    }
}
