using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgrammingCafeAssignment;


namespace ProgrammingCafeAssignment
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
            textBox1.AppendText("Your order is in and will be ready shortly!  Thanks for shopping with us!");
            textBox2.AppendText("We invite you to take part in giving your review of your experience!  Your opinion is important to us!");
            textBox3.AppendText("Please tell us your experience at : customerservice.cakeshopcafe.com");
           
        }

        

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
