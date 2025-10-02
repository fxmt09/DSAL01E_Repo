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
    public partial class Lesson2_Example3_PrintFrm : Form
    {
        public Lesson2_Example3_PrintFrm()
        {
            InitializeComponent();
            printDispLbox.Items.AddRange(printDispLbox.Items);
        }

        private void Lesson2_Example3_PrintFrm_Load(object sender, EventArgs e)
        {

        }

        private void printDispLbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
