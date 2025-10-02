using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON5ACTIVITY
{
    public partial class Form2 : Form
    {
        // Variables for tracking item details, pricing, discounts, payment, and totals
        private double total_amount = 0;
        private int total_qty = 0;
        private double cash_given, change, total_amountPaid;
        private int qty;
        private double price, discount_amount, discounted_amount;
        public Form2()
        {
            InitializeComponent();
          

            this.AutoScaleMode = AutoScaleMode.Dpi;   // Adjust to DPI
            this.AutoSize = true;                     // Allow auto resizing
            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //disabling textboxes
            dscamtTbox.Enabled = false;
            DiscamtTbox.Enabled = false;
            priceTbox.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox8.Enabled = false;
            //codes to disable checkboxes
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            checkBox7.Enabled = false;
            checkBox8.Enabled = false;
            checkBox9.Enabled = false;
            checkBox10.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cash_given = Convert.ToDouble(cashgivenTbox.Text);           // Convert cash input to double
                total_amountPaid = Convert.ToDouble(textBox5.Text);          // Convert total amount input to double
                change = cash_given - total_amountPaid;                      // Calculate change

                textBox8.Text = change.ToString("n");                         // Display change with number formatting

                dispLBox.Items.Add("Total Bills: " + textBox5.Text);         // Log total bill
                dispLBox.Items.Add("Cash Given: " + cashgivenTbox.Text);     // Log cash input
                dispLBox.Items.Add("Change: " + textBox8.Text);              // Log calculated change
                dispLBox.Items.Add("Total No. of Items: " + textBox6.Text);  // Log item count
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid data in cash given textbox!");  // Show error message for invalid cash input
                cashgivenTbox.Clear();                                       // Clear cash input field
                cashgivenTbox.Focus();                                       // Set focus back to cash input field
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            DiscamtTbox.Text = "0.00";
            priceTbox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(checkBox20.Text + priceTbox.Text);
            //codes for putting text property value of the textbox
            qtyTbox.Text = "0";
            //codes for putting the focus on the textbox    
            qtyTbox.Focus();
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            DiscamtTbox.Text = "0.00";
            priceTbox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(checkBox25.Text + priceTbox.Text);
            //codes for putting text property value of the textbox
            qtyTbox.Text = "0";
            //codes for putting the focus on the textbox    
            qtyTbox.Focus();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            //code for changing the form background
            this.BackColor = Color.LightCyan;
            //code for Foodbundle B not to be selected
            radioButton2.Checked = false;
            //inserting image inside the picturebox
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\SYMON\\Pictures\\pics for lesson3.3\\fooda.jfif");
            //codes to check the checkboxes
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            //codes to uncheck the checkboxes
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            //codes for displaying data inside the textboxes
            priceTbox.Text = "1,000.00";
            dscamtTbox.Text = "(20% of the Price) 200.00";
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(radioButton2.Text  + priceTbox.Text);
            dispLBox.Items.Add("Discount Amount: " + dscamtTbox.Text);
            qtyTbox.Text = "0";
            qtyTbox.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            //code for changing the form background
            this.BackColor = Color.LightBlue;
            //code for Foodbundle B not to be selected
            radioButton1.Checked = false;
            //inserting image inside the picturebox
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\SYMON\\Pictures\\pics for lesson3.3\\foodb.jfif");
            //codes to check the checkboxes
            checkBox6.Enabled = true;
            checkBox7.Enabled = true;
            checkBox8.Enabled = true;
            checkBox9.Enabled = true;
            checkBox10.Enabled = true;
            //codes to uncheck the checkboxes
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            //codes for displaying data inside the textboxes
            priceTbox.Text = "1,299.00";
            dscamtTbox.Text = "(15% of the Price) P194.85";
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(radioButton1.Text + priceTbox.Text);
            dispLBox.Items.Add("Discount Amount: " + dscamtTbox.Text);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //codes for calling the other form connected to this form
            Lesson2_Example3_PrintFrm print = new Lesson2_Example3_PrintFrm();
            print.printDispLbox.Items.AddRange(dispLBox.Items);
            print.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dispLBox.Items.RemoveAt(dispLBox.SelectedIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // This block resets the form to its default state by unchecking all radio buttons and checkboxes,
            // and updating the DisplayPictureBox with a loading image. It ensures that no options are selected
            // and prepares the interface for a fresh user interaction or a new transaction.

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\SYMON\\Pictures\\pics for lesson3.3\\laoding.gif");

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
            checkBox28.Checked = false;
            checkBox29.Checked = false;
            checkBox30.Checked = false;
            //removing the contents of a listbox
            dispLBox.Items.Clear();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void qtyTbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                price = Convert.ToDouble(priceTbox.Text);               // Convert price input to double
                qty = Convert.ToInt32(qtyTbox.Text);                    // Convert quantity input to integer
                discount_amount = Convert.ToDouble(DiscamtTbox.Text);   // Convert discount amount input to double

                discounted_amount = (price * qty) - discount_amount;    // Calculate discounted total amount

                total_qty += qty;                                       // Add current quantity to total quantity
                textBox6.Text = total_qty.ToString();                   // Display updated total quantity

                total_amount += discounted_amount;                      // Add discounted amount to total amount
                textBox5.Text = total_amount.ToString("n");             // Display total amount with number formatting

                dscamtTbox.Text = discounted_amount.ToString("n");      // Display discounted amount with number formatting
            }
            catch (Exception)
            {
                MessageBox.Show("Enter number of quantity ordered");    // Show error message for invalid quantity input
                qtyTbox.Focus();                                        // Set focus back to quantity textbox
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            DiscamtTbox.Text = "0.00";
            priceTbox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(checkBox11.Text + priceTbox.Text);
            //codes for putting text property value of the textbox
            qtyTbox.Text = "0";
            //codes for putting the focus on the textbox    
            qtyTbox.Focus();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            DiscamtTbox.Text = "0.00";
            priceTbox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(checkBox12.Text + priceTbox.Text);
            //codes for putting text property value of the textbox
            qtyTbox.Text = "0";
            //codes for putting the focus on the textbox    
            qtyTbox.Focus();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            DiscamtTbox.Text = "0.00";
            priceTbox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(checkBox13.Text + priceTbox.Text);
            //codes for putting text property value of the textbox
            qtyTbox.Text = "0";
            //codes for putting the focus on the textbox    
            qtyTbox.Focus();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            DiscamtTbox.Text = "0.00";
            priceTbox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(checkBox14.Text + priceTbox.Text);
            //codes for putting text property value of the textbox
            qtyTbox.Text = "0";
            //codes for putting the focus on the textbox    
            qtyTbox.Focus();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            DiscamtTbox.Text = "0.00";
            priceTbox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(checkBox15.Text + priceTbox.Text);
            //codes for putting text property value of the textbox
            qtyTbox.Text = "0";
            //codes for putting the focus on the textbox    
            qtyTbox.Focus();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            DiscamtTbox.Text = "0.00";
            priceTbox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(checkBox16.Text + priceTbox.Text);
            //codes for putting text property value of the textbox
            qtyTbox.Text = "0";
            //codes for putting the focus on the textbox    
            qtyTbox.Focus();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            DiscamtTbox.Text = "0.00";
            priceTbox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(checkBox17.Text + priceTbox.Text);
            //codes for putting text property value of the textbox
            qtyTbox.Text = "0";
            //codes for putting the focus on the textbox    
            qtyTbox.Focus();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            DiscamtTbox.Text = "0.00";
            priceTbox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(checkBox18.Text + priceTbox.Text);
            //codes for putting text property value of the textbox
            qtyTbox.Text = "0";
            //codes for putting the focus on the textbox    
            qtyTbox.Focus();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            DiscamtTbox.Text = "0.00";
            priceTbox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(checkBox19.Text + priceTbox.Text);
            //codes for putting text property value of the textbox
            qtyTbox.Text = "0";
            //codes for putting the focus on the textbox    
            qtyTbox.Focus();
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            DiscamtTbox.Text = "0.00";
            priceTbox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(checkBox21.Text + priceTbox.Text);
            //codes for putting text property value of the textbox
            qtyTbox.Text = "0";
            //codes for putting the focus on the textbox    
            qtyTbox.Focus();
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            DiscamtTbox.Text = "0.00";
            priceTbox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(checkBox22.Text + priceTbox.Text);
            //codes for putting text property value of the textbox
            qtyTbox.Text = "0";
            //codes for putting the focus on the textbox    
            qtyTbox.Focus();
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            DiscamtTbox.Text = "0.00";
            priceTbox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(checkBox23.Text + priceTbox.Text);
            //codes for putting text property value of the textbox
            qtyTbox.Text = "0";
            //codes for putting the focus on the textbox    
            qtyTbox.Focus();
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            DiscamtTbox.Text = "0.00";
            priceTbox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(checkBox24.Text + priceTbox.Text);
            //codes for putting text property value of the textbox
            qtyTbox.Text = "0";
            //codes for putting the focus on the textbox    
            qtyTbox.Focus();
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            DiscamtTbox.Text = "0.00";
            priceTbox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(checkBox26.Text + priceTbox.Text);
            //codes for putting text property value of the textbox
            qtyTbox.Text = "0";
            //codes for putting the focus on the textbox    
            qtyTbox.Focus();
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            DiscamtTbox.Text = "0.00";
            priceTbox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(checkBox27.Text + priceTbox.Text);
            //codes for putting text property value of the textbox
            qtyTbox.Text = "0";
            //codes for putting the focus on the textbox    
            qtyTbox.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            DiscamtTbox.Text = "0.00";
            priceTbox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(checkBox28.Text + priceTbox.Text);
            //codes for putting text property value of the textbox
            qtyTbox.Text = "0";
            //codes for putting the focus on the textbox    
            qtyTbox.Focus();
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            DiscamtTbox.Text = "0.00";
            priceTbox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(checkBox29.Text + priceTbox.Text);
            //codes for putting text property value of the textbox
            qtyTbox.Text = "0";
            //codes for putting the focus on the textbox    
            qtyTbox.Focus();
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            DiscamtTbox.Text = "0.00";
            priceTbox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(priceTbox.Text);
            //codes for inserting data inside the listbox
            dispLBox.Items.Add(checkBox30.Text + priceTbox.Text);
            //codes for putting text property value of the textbox
            qtyTbox.Text = "0";
            //codes for putting the focus on the textbox    
            qtyTbox.Focus();
        }

        private void priceTbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 