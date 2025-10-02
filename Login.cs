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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "admin" && textBox2.Text == "123456")
            {
                MessageBox.Show("Welcome Admin Page!!!");
                MainForm adminfrm = new MainForm();
                adminfrm.Show();
                textBox1.Clear();
                textBox2.Clear();
            }
            else if (textBox1.Text == "cashier1" && textBox2.Text == "123456")
            {
                MessageBox.Show("Welcome Cashier POS Page!!!");
                L3A3 cashierfrm = new L3A3();
                cashierfrm.Show();
                textBox1.Clear();
                textBox2.Clear();
            }
            else if (textBox1.Text == "cashier2" && textBox2.Text == "123456")
            {
                MessageBox.Show("Welcome Cashier Ordering POS Page!!!");
                Form2 cashier2frm = new Form2();
                cashier2frm.Show();
                textBox1.Clear();
                textBox2.Clear();
            }
            else if (textBox1.Text == "payroll" && textBox2.Text == "123456")
            {
                MessageBox.Show("Welcome Payroll Page!!!");
                Form1 payrollfrm = new Form1();
                payrollfrm.Show();
                textBox1.Clear();
                textBox2.Clear();
            }
            else
                MessageBox.Show("Invalid Username or Password!!!");
            textBox1.Clear();
            textBox2.Clear();
        }





                private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
