using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display form3
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();


        }

        private void form3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            //display form3
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }

        private void form4ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //display form4
            Form4 form4 = new Form4();
            form4.MdiParent = this;
            form4.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
