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
    public partial class L3A3 : Form
    {
        
        public L3A3()
        {
            InitializeComponent();
        }
        private double discounted_total = 0;
        private int qty_total = 0;
        private double discount_totalgiven = 0;
        private int qty;
        private double discount_amt, discounted_amt;
        private double cash_rendered;
        private double change;
        private double price;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnameTbox.Text = "jolly breakfast";
            priceTbox.Text = "89.50";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnameTbox.Text = "jolly breakfast";
            priceTbox.Text = "89.50";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                qty = Convert.ToInt32(qtyTbox.Text);
                discount_amt = Convert.ToDouble(textBox4.Text);
                discounted_amt = Convert.ToDouble(textBox5.Text);
                cash_rendered = Convert.ToDouble(cashrenderedTbox.Text);

                qty_total += qty;
                discount_totalgiven += discount_amt;
                discounted_total += discounted_amt;
                change = cash_rendered - discounted_amt;

                textBox6.Text = qty_total.ToString();
                textBox7.Text = discount_totalgiven.ToString("n");
                textBox8.Text = discounted_total.ToString("n");
                textBox10.Text = change.ToString("n");
                cashrenderedTbox.Text = cash_rendered.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure cash given textbox is not empty invalid");
                cashrenderedTbox.Clear();
                cashrenderedTbox.Focus();
            }
            

            }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void L3A3_Load(object sender, EventArgs e)
        {
            //code for disabling the textboxes
            itemnameTbox.Enabled = false;
            priceTbox.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox10.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                qty = Convert.ToInt32(qtyTbox.Text);
                price = Convert.ToDouble(priceTbox.Text);
                //create a formula for discount amt and discounted amt
                discount_amt = (qty * price) * 0.30;
                discounted_amt = (qty * price) - discount_amt;
                //converting numeric data to string and displaying it to the textbox
                textBox4.Text = discount_amt.ToString("n");
                textBox5.Text = discounted_amt.ToString("n");
                //codes for unchecking other radiobuttons when one is checked
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("input is invalid");
                qtyTbox.Clear();
                qtyTbox.Focus();
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                qty = Convert.ToInt32(qtyTbox.Text);
                price = Convert.ToDouble(priceTbox.Text);
                //create a formula for discount amt and discounted amt
                discount_amt = (qty * price) * 0.10;
                discounted_amt = (qty * price) - discount_amt;
                //converting numeric data to string and displaying it to the textbox
                textBox4.Text = discount_amt.ToString("n");
                textBox5.Text = discounted_amt.ToString("n");
                //codes for unchecking other radiobuttons when one is checked
                radioButton1.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("input is invalid");
                qtyTbox.Clear();
                qtyTbox.Focus();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                qty = Convert.ToInt32(qtyTbox.Text);
                price = Convert.ToDouble(priceTbox.Text);
                //create a formula for discount amt and discounted amt
                discount_amt = (qty * price) * 0.15;
                discounted_amt = (qty * price) - discount_amt;
                //converting numeric data to string and displaying it to the textbox
                textBox4.Text = discount_amt.ToString("n");
                textBox5.Text = discounted_amt.ToString("n");
                //codes for unchecking other radiobuttons when one is checked
                radioButton2.Checked = false;
                radioButton1.Checked = false;
                radioButton4.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("input is invalid");
                qtyTbox.Clear();
                qtyTbox.Focus();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                qty = Convert.ToInt32(qtyTbox.Text);
                price = Convert.ToDouble(priceTbox.Text);
                //create a formula for discount amt and discounted amt
                discount_amt = (qty * price) * 0;
                discounted_amt = (qty * price) - discount_amt;
                //converting numeric data to string and displaying it to the textbox
                textBox4.Text = discount_amt.ToString("n");
                textBox5.Text = discounted_amt.ToString("n");
                //codes for unchecking other radiobuttons when one is checked
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton1.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("input is invalid");
                qtyTbox.Clear();
                qtyTbox.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itemnameTbox.Clear();
            priceTbox.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox10.Clear();
            cashrenderedTbox.Clear();
            qtyTbox.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnameTbox.Text = "jolly breakfast";
            priceTbox.Text = "89.50";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnameTbox.Text = "jolly breakfast";
            priceTbox.Text = "89.50";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnameTbox.Text = "jolly breakfast";
            priceTbox.Text = "89.50";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnameTbox.Text = "jolly breakfast";
            priceTbox.Text = "89.50";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnameTbox.Text = "jolly breakfast";
            priceTbox.Text = "89.50";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnameTbox.Text = "jolly breakfast";
            priceTbox.Text = "89.50";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnameTbox.Text = "jolly breakfast";
            priceTbox.Text = "89.50";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnameTbox.Text = "jolly breakfast";
            priceTbox.Text = "89.50";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnameTbox.Text = "jolly breakfast";
            priceTbox.Text = "89.50";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnameTbox.Text = "jolly breakfast";
            priceTbox.Text = "89.50";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnameTbox.Text = "jolly breakfast";
            priceTbox.Text = "89.50";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnameTbox.Text = "jolly breakfast";
            priceTbox.Text = "89.50";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnameTbox.Text = "jolly breakfast";
            priceTbox.Text = "89.50";
        }
    }
}
