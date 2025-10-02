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
    public partial class Lesson1 : Form
    {
        //declaration of global variables
        private double amount_paid, price, cash_given, change;
        private int quantity;
        
        public Lesson1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Code for inserting or assigning a value to the Text property of a textbox
            textBox1.Text = "Pancake and Chicken Dog";
            priceTbox.Text = "75.00";
            qtyTbox.Focus();
            qtyTbox.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Code for inserting or assigning a value to the Text property of a textbox
            textBox1.Text = "Burger Steak";
            priceTbox.Text = "75.00";
            qtyTbox.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Code for inserting or assigning a value to the Text property of a textbox
            textBox1.Text = "Jolly Bucket 2";
            priceTbox.Text = "675.00";
            qtyTbox.Focus();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Code for inserting or assigning a value to the Text property of a textbox
            textBox1.Text = "Chicken meal";
            priceTbox.Text = "99.00";
            qtyTbox.Focus();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //Code for inserting or assigning a value to the Text property of a textbox
            textBox1.Text = "7 pcs bucket meal";
            priceTbox.Text = "675.00";
            qtyTbox.Focus();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //Code for inserting or assigning a value to the Text property of a textbox
            textBox1.Text = "Jolly Chicken with spaghetti";
            priceTbox.Text = "145.00";
            qtyTbox.Focus();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //Code for inserting or assigning a value to the Text property of a textbox
            textBox1.Text = "KFC Bucket";
            priceTbox.Text = "375.00";
            qtyTbox.Focus();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //Code for inserting or assigning a value to the Text property of a textbox
            textBox1.Text = "ChowFan with Drinks";
            priceTbox.Text = "95.00";
            qtyTbox.Focus();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //Code for inserting or assigning a value to the Text property of a textbox
            textBox1.Text = "KFC Family Meal";
            priceTbox.Text = "475.00";
            qtyTbox.Focus();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //Code for inserting or assigning a value to the Text property of a textbox
            textBox1.Text = "Family Pan";
            priceTbox.Text = "275.00";
            qtyTbox.Focus();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //Code for inserting or assigning a value to the Text property of a textbox
            textBox1.Text = "Chicken with Coke Float";
            priceTbox.Text = "105.00";
            qtyTbox.Focus();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            //Code for inserting or assigning a value to the Text property of a textbox
            textBox1.Text = "Zark's Burger";
            priceTbox.Text = "110.00";
            qtyTbox.Focus();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            //Code for inserting or assigning a value to the Text property of a textbox
            textBox1.Text = "StarBucks Breakfast";
            priceTbox.Text = "125.00";
            qtyTbox.Focus();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            //Code for inserting or assigning a value to the Text property of a textbox
            textBox1.Text = "KFC super meal";
            priceTbox.Text = "175.00";
            qtyTbox.Focus();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            //Code for inserting or assigning a value to the Text property of a textbox
            textBox1.Text = "2 piece of chicken wings";
            priceTbox.Text = "85.00";
            qtyTbox.Focus();
        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                amount_paid = Convert.ToDouble(amtpaidTbox.Text);        // Convert amount paid input to double
                cash_given = Convert.ToDouble(cashgivenTbox.Text);       // Convert cash given input to double
                change = cash_given - amount_paid;                       // Calculate change

                changeTbox.Text = change.ToString("C");                  // Display change in currency format
                amtpaidTbox.Text = amount_paid.ToString("C");            // Format and display amount paid
                cashgivenTbox.Text = cash_given.ToString("c");           // Format and display cash given
            }
            catch (Exception)
            {
                MessageBox.Show("Please put valid numbers");             // Show error message for invalid input
                cashgivenTbox.Clear();                                   // Clear cash given textbox
                cashgivenTbox.Focus();                                   // Set focus back to cash given textbox
            }
            finally
            {
                MessageBox.Show("Successfully Calculated!");             // Notify user that calculation is complete
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void amtpaidTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void qtyTbox_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                price = Convert.ToDouble(priceTbox.Text);         // Convert unit price input to double
                quantity = Convert.ToInt32(qtyTbox.Text);         // Convert quantity input to integer
                amount_paid = price * quantity;                   // Calculate total amount to be paid
                amtpaidTbox.Text = amount_paid.ToString("C");     // Display formatted amount in currency
                cashgivenTbox.Focus();                            // Move focus to cash input field
            }
            catch (Exception)
            {
                MessageBox.Show("invalid data input");            // Show error message for invalid input
                qtyTbox.Clear();                                  // Clear quantity textbox
                qtyTbox.Focus();                                  // Return focus to quantity textbox
            }

        }

        private void cashgivenTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void changeTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            // Code for clearing or emptying the value of the Text property of a textbox
            textBox1.Clear();
            priceTbox.Clear();
            qtyTbox.Clear();
            amtpaidTbox.Clear();
            cashgivenTbox.Clear();
            changeTbox.Clear();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lesson1_Load(object sender, EventArgs e)
        {
            changeTbox.Enabled = false;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}
