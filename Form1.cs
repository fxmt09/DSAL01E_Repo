using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LESSON5ACTIVITY
{
    public partial class Form1 : Form
    {

        // Variables for computing net income based on hours and rates for basic, honorarium, and other categories
        private Double basic_netincome = 0.00,
             basic_numhrs = 0.00,
             basic_rate = 0.00,
             hono_netincome = 0.00,
             hono_numhrs = 0.00,
             hono_rate = 0.00,
             other_netincome = 0.00,
             other_numhrs = 0.00,
             other_rate = 0.00;




        private void other_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            other_numhrs = Convert.ToDouble(other_numhrstbox.Text);
            other_rate = Convert.ToDouble(other_ratetbox.Text);
            other_netincome = other_numhrs * other_rate;
            other_netincometbox.Text = other_netincome.ToString("n");

            
            
        }

        private void hono_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            hono_numhrs = Convert.ToDouble(hono_numhrstbox.Text);
            hono_rate = Convert.ToDouble(hono_ratetbox.Text);
            hono_netincome = hono_numhrs * hono_rate;
            hono_netincometbox.Text = hono_netincome.ToString("n");
        }

        private void basic_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            basic_numhrs = Double.Parse(basic_numhrstbox.Text);
            basic_rate = Convert.ToDouble(basic_ratetbox.Text);
            basic_netincome = basic_numhrs * basic_rate;
            basic_netincometbox.Text = basic_netincome.ToString("n");
        }

        private void basic_netincomeTxtbox_TextChanged(object sender, EventArgs e)
        {
            basic_numhrs = Double.Parse(basic_numhrstbox.Text);
            basic_rate = Convert.ToDouble(basic_ratetbox.Text);
            basic_netincome = basic_numhrs * basic_rate;
            basic_netincometbox.Text = basic_netincome.ToString("n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            net_incometbox.Text = Convert.ToString(grossincome - total_deduction);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image File | * .gif; * .jpg; * .png; * .bmp";
            openFileDialog1.Title = " Select Employee Picture";
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }
        private void button5_Click(object sender, EventArgs e)  
        {
            //Populates the PRINTLESSON5 form with employee payroll details and displays it.
            PRINTLESSON5 print = new PRINTLESSON5();           
            print.deptbox.Text = DeptNameTxtbox.Text;
            print.Payperiodbox.Text = paydateDatePicker.Text;
            print.cutofftbox.Text = paydateDatePicker.Text;
            print.Employeecodebox.Text = emp_noTxtbox.Text;
            print.Employeenamebox.Text = firstnameTxtbox.Text + " " + Middlenametxt.Text + " " + Surnametbox.Text;
            print.bpaytbox.Text = basic_netincometbox.Text;
            print.overtimetbox.Text = hono_netincometbox.Text;
            print.honorariumtboxhrs.Text = other_netincometbox.Text;
            print.textBox1.Text = "Lyceum of the Philippines University";
            print.textBox2.Text = tax_contribtbox.Text;
            print.textBox3.Text = sss_contribtbox.Text;
            print.textBox4.Text = pagibig_contribtbox.Text;
            print.textBox5.Text = philhealth_contribtbox.Text;
            print.textBox6.Text = "750.00";
            print.textBox7.Text = gross_incometbox.Text;
            print.textBox11.Text = total_deducttbox.Text;
            print.textBox12.Text = net_incometbox.Text;
            print.textBox8.Text = gross_incometbox.Text;
            print.textBox9.Text = net_incometbox.Text;
            print.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void empStatusTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Calculates gross income and total deductions based on contributions and loans entered in the form.
            sss_contrib = Convert.ToDouble(sss_contribtbox.Text);
            pagibig_contrib = Convert.ToDouble(pagibig_contribtbox.Text);
            philhealth_contrib = Convert.ToDouble(philhealth_contribtbox.Text);
            tax_contrib = Convert.ToDouble(tax_contribtbox.Text);
            sss_loan = Convert.ToDouble(sss_loantbox.Text);
            pagibig_loan = Convert.ToDouble(pagibig_loantbox.Text);
            salary_loan = Convert.ToDouble(sal_loantbox.Text);
            faculty_sav_loan = Convert.ToDouble(FS_loantbox.Text);
            salary_savings = Convert.ToDouble(FSD_deposittbox.Text);
            other_deduction = Convert.ToDouble(otherLoantBox.Text);

            grossincome = basic_netincome + hono_netincome + other_netincome;
            gross_incometbox.Text = grossincome.ToString();

            basic_netincome = Convert.ToDouble(basic_netincometbox.Text);
            hono_netincome = Convert.ToDouble(hono_netincometbox.Text);
            other_netincome = Convert.ToDouble(other_netincometbox.Text);

            total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib + tax_contrib;
            total_loan = sss_loan + pagibig_loan + salary_loan + faculty_sav_loan + salary_savings + other_deduction;
            total_deduction = total_contrib + total_loan;


            // Assigns SSS contribution based on gross income brackets and sets tax contribution to zero if income is below threshold.
            if (gross_income < 5250)
            {
                sss_contribtbox.Text = "250.00";
            }
            else if (gross_income > 5250 && gross_income <= 5749.99)
            {
                sss_contribtbox.Text = "275.00";
            }
            else if (gross_income > 5749.99 && gross_income <= 6299.99)
            {
                sss_contribtbox.Text = "300.00";
            }
            else if (gross_income > 6499.99 && gross_income <= 6749.99)
            {
                sss_contribtbox.Text = "325.00";
            }
            else if (gross_income > 6749.99 && gross_income <= 7249.99)
            {
                sss_contribtbox.Text = "350.00";
            }
            else if (gross_income > 7249.99 && gross_income <= 7749.99)
            {
                sss_contribtbox.Text = "375.00";
            }
            else if (gross_income > 7749.99 && gross_income <= 8249.99)
            {
                sss_contribtbox.Text = "400.00";
            }
            else if (gross_income > 8249.99 && gross_income <= 8749.99)
            {
                sss_contribtbox.Text = "425.00";
            }
            else if (gross_income > 8749.99 && gross_income <= 9249.99)
            {
                sss_contribtbox.Text = "450.00";
            }
            else if (gross_income > 9249.99 && gross_income <= 9749.99)
            {
                sss_contribtbox.Text = "475.00";
            }
            else if (gross_income > 9749.99 && gross_income <= 10499.99)
            {
                sss_contribtbox.Text = "500.00";
            }
            else if (gross_income > 10499.99 && gross_income <= 10749.99)
            {
                sss_contribtbox.Text = "525.00";
            }
            else if (gross_income > 10749.99 && gross_income <= 11249.99)
            {
                sss_contribtbox.Text = "550.00";
            }
            else if (gross_income > 11249.99 && gross_income <= 11749.99)
            {
                sss_contribtbox.Text = "575.00";
            }
            else if (gross_income > 11749.99 && gross_income <= 12249.99)
            {
                sss_contribtbox.Text = "600.00";
            }
            else if (gross_income > 12249.99 && gross_income <= 12749.99)
            {
                sss_contribtbox.Text = "625.00";
            }
            else if (gross_income > 12749.99 && gross_income <= 13249.99)
            {
                sss_contribtbox.Text = "650.00";
            }
            else if (gross_income > 13249.99 && gross_income <= 13749.99)
            {
                sss_contribtbox.Text = "675.00";
            }
            else if (gross_income > 13749.99 && gross_income <= 14499.99)
            {
                sss_contribtbox.Text = "700.00";
            }
            else if (gross_income > 14499.99 && gross_income <= 14749.99)
            {
                sss_contribtbox.Text = "725.00";
            }
            else if (gross_income > 14749.99 && gross_income <= 15249.99)
            {
                sss_contribtbox.Text = "750.00";
            }
            else if (gross_income > 15249.99 && gross_income <= 15749.99)
            {
                sss_contribtbox.Text = "775.00";
            }
            else if (gross_income > 15749.99 && gross_income <= 16249.99)
            {
                sss_contribtbox.Text = "800.00";
            }
            else if (gross_income > 16249.99 && gross_income <= 16749.99)
            {
                sss_contribtbox.Text = "825.00";
            }
            else if (gross_income > 16749.99 && gross_income <= 17249.99)
            {
                sss_contribtbox.Text = "850.00";
            }
            else if (gross_income > 17249.99 && gross_income <= 17749.99)
            {
                sss_contribtbox.Text = "875.00";
            }
            else if (gross_income > 17749.99 && gross_income <= 18499.99)
            {
                sss_contribtbox.Text = "900.00";
            }
            else if (gross_income > 18499.99 && gross_income <= 18749.99)
            {
                sss_contribtbox.Text = "925.00";
            }
            else if (gross_income > 18749.99 && gross_income <= 19249.99)
            {
                sss_contribtbox.Text = "950.00";
            }
            else if (gross_income > 19249.99 && gross_income <= 19749.99)
            {
                sss_contribtbox.Text = "975.00";
            }
            else if (gross_income > 19749.99 && gross_income <= 20249.99)
            {
                sss_contribtbox.Text = "1000.00";
            }

            if (grossincome < (25000 / 24))
            {
                tax_contribtbox.Text = "0";
            }

            else if (grossincome > (250000/24) && grossincome <= (400000/24))
            {
                tax = .15 * (grossincome - (250000/24));
                tax_contribtbox.Text = Convert.ToString(tax);
            }
            else if (grossincome > (400000/24) && grossincome <= (800000/24))
            {
                tax = (22500/24) + .2 * (grossincome - (400000/24));
                tax_contribtbox.Text = Convert.ToString(tax);
            }
            else if (grossincome > (800000/4) && grossincome <= (20000/24))
            {
                tax = (102500/24) + .25 * (grossincome - (800000/24));
                tax_contribtbox.Text = Convert.ToString(tax);
            }
            else if (grossincome > (2000000/24) && grossincome <= (8000000/24))
            {
                tax = (402500/24) + .3 * (grossincome - (2000000/24));
                tax_contribtbox.Text = Convert.ToString(tax);
            }
            else
            {
                tax = (2202500/24) + .35 * (grossincome - (8000000/24));
                tax_contribtbox.Text = Convert.ToString(tax);

            }
            // PHILHEALTH CONTRI
            if (grossincome < 100000)
            {
                philhealth_contribtbox.Text = Convert.ToString(grossincome * .05);
            }
            else
            {
                philhealth_contribtbox.Text = Convert.ToString("5000");
            }

            //PAG IBIG CONTRI

            pagibig_contribtbox.Text = "200.00";


            sss_contrib = Convert.ToDouble(sss_contribtbox.Text);
            pagibig_contrib = Convert.ToDouble(pagibig_contribtbox.Text);
            philhealth_contrib = Convert.ToDouble(philhealth_contribtbox.Text);
            tax_contrib = Convert.ToDouble(tax_contribtbox.Text);
            sss_loan = Convert.ToDouble(sss_loantbox.Text);
            pagibig_loan = Convert.ToDouble(pagibig_loantbox.Text);
            salary_loan = Convert.ToDouble(sal_loantbox.Text);
            other_deduction = Convert.ToDouble(otherLoantBox.Text);


            total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib + tax_contrib;
            total_loan = sss_loan + pagibig_loan + salary_loan + faculty_sav_loan + salary_savings + other_deduction;
            total_deduction = total_contrib + total_loan;
            total_deducttbox.Text = Convert.ToString(total_deduction);
        }



        private void button3_Click(object sender, EventArgs e)
        {
            // Clears all input fields and resets financial variables to default values for a fresh payroll entry.
            emp_noTxtbox.Clear();
            firstnameTxtbox.Clear();
            Middlenametxt.Clear();
            Surnametbox.Clear();
            civil_statustbox.Clear();
            designtbox.Clear();
            DeptNameTxtbox.Clear();
            empStatusTxtbox.Clear();
            DeptNameTxtbox.Clear();

            basic_netincometbox.Clear();
            basic_numhrstbox.Text = "0.00";
            basic_ratetbox.Text = "0.00";

            hono_netincometbox.Clear();
            hono_numhrstbox.Text = "0.00";
            hono_ratetbox.Text = "0.00";

            other_netincometbox.Clear();
            other_numhrstbox.Text = "0.00";
            other_ratetbox.Text = "0.00";

            net_incometbox.Clear();
            gross_incometbox.Clear();

            sss_contribtbox.Clear();
            pagibig_contribtbox.Clear();
            philhealth_contribtbox.Clear();
            tax_contribtbox.Clear();

            sss_loantbox.Clear();
            pagibig_loantbox.Clear();
        }

        private Double netincome = 0.00,
            grossincome = 0.00,
            sss_contrib = 0.00,
            pagibig_contrib = 0.00,
            philhealth_contrib = 0.00,
            tax_contrib = 0.00;

        private Double sss_loan = 0.00,
           pagibig_loan = 0.00,
           salary_loan = 0.00,
           salary_savings = 0.00,
           faculty_sav_loan = 0.00,
           other_deduction = 0.00,
           total_deduction = 0.00,
           total_contrib = 0.00,
           total_loan = 0.00;

        private Double gross_income = 0.00;
        private Double tax = 0.00;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //This code disables the textboxes to prevent user input.
            basic_netincometbox.Enabled = false;
            hono_netincometbox.Enabled = false;
            other_netincometbox.Enabled = false;
            net_incometbox.Enabled = false;
            gross_incometbox.Enabled = false;
            total_deducttbox.Enabled = false;
            sss_contribtbox.Enabled = false;
            pagibig_contribtbox.Enabled = false;
            philhealth_contribtbox.Enabled = false;
            tax_contribtbox.Enabled = false;
            //Asisgning default values to textboxes
            basic_ratetbox.Text = "0.00";
            hono_ratetbox.Text = "0.00";
            other_ratetbox.Text = "0.00";
            sss_contribtbox.Text = "0.00";
            pagibig_contribtbox.Text = "0.00";
            philhealth_contribtbox.Text = "0.00";
            tax_contribtbox.Text = "0.00";
            sss_loantbox.Text = "0.00";
            pagibig_loantbox.Text = "0.00";
            FSD_deposittbox.Text = "0.00";
            FS_loantbox.Text = "0.00";
            sal_loantbox.Text = "0.00";
            otherLoantBox.Text = "0.00";
        }
    }
}
