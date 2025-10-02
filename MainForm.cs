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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Auto scale UI based on screen DPI
            this.AutoScaleMode = AutoScaleMode.Dpi;

            // Always start maximized to fit screen resolution
            this.WindowState = FormWindowState.Maximized;

            // Optional: force bounds to match the primary screen
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void serToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeRegistratioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pOSCashiertToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void greensPOSINCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newMDIChild = new Form2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void greensPOSOrderingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            L3A3 newMDIChild = new L3A3();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void simplePOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson1 newMDIChild = new Lesson1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void greensPOSIncToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 posAdmin = new Form2();
            posAdmin.MdiParent = this;
            posAdmin.Show();
        }

        private void greensPOSOrderingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            L3A3 orderAdmin = new L3A3();
            orderAdmin.MdiParent = this;
            orderAdmin.Show();
        }

        private void userAccountPageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            User_AccontFrm newMDIChild = new User_AccontFrm();
            newMDIChild.MdiParent = this; 
            newMDIChild.Show();
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
           
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void payrollApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Payrollsys = new Form1();
            Payrollsys.MdiParent = this;
            Payrollsys.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
