//2-4-22
//Program that uses forms to display a Cafe ordering system.  User can select different items to add to cart, delete items, and checkout.  Program calculates cost and displays 'success' screen.
namespace ProgrammingCafeAssignment
{
    public partial class Form1 : Form
    {

        double coffee = 2;
        double pastry = 2;
        double tea = 2;
        double whippedCream = 0.75; 
        double cinnamon = 0.50;    
        double cocoa = 0.75;        
        double extra = 0;
        
        double total;               
        double finalTotal = 0;       


        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (whippedCreamCheckBox.Checked == true && cinnamonCheckBox.Checked == true && cocoaCheckBox.Checked == true)
            {
                extra += whippedCream + cinnamon + cocoa;
            }
            
            else if (whippedCreamCheckBox.Checked == true && cinnamonCheckBox.Checked == true)
            {
                extra += whippedCream + cinnamon;
            }
            
            else if (whippedCreamCheckBox.Checked == true && cocoaCheckBox.Checked == true)
            {
                extra += whippedCream + cocoa;
            }
            
            else if (cinnamonCheckBox.Checked == true && cocoaCheckBox.Checked == true)
            {
                extra += cinnamon + cocoa;
            }
            
            else if (whippedCreamCheckBox.Checked == true)
            {
                extra += whippedCream;
            }
            
            else if (cinnamonCheckBox.Checked == true)
            {
                extra += cinnamon;
            }
            
            else if (cocoaCheckBox.Checked == true)
            {
                extra += cocoa;
            }

            total = coffee + extra;

            listView1.Items.Add("Coffee"); //adds the items selected to the list on the right
            listView2.Items.Add(total.ToString("$ 0.00"));
            finalTotal += total;
            textBox7.Text = "";
            textBox7.AppendText(finalTotal.ToString("$ 0.00"));
            total = 0; extra = 0; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            finalTotal = 0;
            total = 0;
            extra = 0;
            listView1.Items.Clear();
            listView2.Items.Clear();
            textBox7.Text = "";
            cinnamonCheckBox.Checked = false;
            cocoaCheckBox.Checked = false;
            creamCheckBox.Checked = false;
            sugarCheckBox.Checked = false;
            whippedCreamCheckBox.Checked = false;
            whippedCreamCheckBox2.Checked = false;
            sugarCheckBox2.Checked = false;
            creamCheckBox2.Checked = false;
            

        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (whippedCreamCheckBox2.Checked == true)
            {
                extra += whippedCream;
            }

            total = tea + extra; 

            listView1.Items.Add("Tea"); //adds the items selected to the list on the right
            listView2.Items.Add(total.ToString("$ 0.00"));
            finalTotal += total; ///calculates the final total for checkout
            textBox7.Text = "";
            textBox7.AppendText(finalTotal.ToString("$ 0.00"));
            total = 0; extra = 0; 

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            extra = 0;  //this is put here so that each time the pastry selection is altered, the extra value is set to '0'
                        //this will lead to the next lines of code (below) which add the price of a pastry per selected item
                        //otherwise, the math will be messed up each time the user selects a pastry and adds it to the cart

            foreach (var item in checkedListBox1.CheckedItems)
            {
                extra = extra + pastry;
            }

        }

        public void button3_Click(object sender, EventArgs e)
        {
            total = extra;

            listView1.Items.Add("Pastry"); //adds the items selected to the list on the right
            listView2.Items.Add(total.ToString("$ 0.00"));
            finalTotal += total;
            textBox7.Text = "";
            textBox7.AppendText(finalTotal.ToString("$ 0.00"));
            total = 0; extra = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 secondWindow = new Form2();
            secondWindow.Show();
        }
    }
    
}