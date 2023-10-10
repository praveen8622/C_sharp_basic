using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SectionBGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "hello Pcps";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Click Me";
            label1.Text = " ";
            button2.Text = "Date Time";
            
            textBox1.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            textBox1.Text = DateTime.Now.ToString("ddd, dd MMMM yyyy hh:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString("ddd, dd MMMM yyyy hh:mm:ss");

        }
    }
}
