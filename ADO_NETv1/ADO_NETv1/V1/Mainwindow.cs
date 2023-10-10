using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NETv1
{
    public partial class mainwindow : Form
    {
        public mainwindow()
        {
            InitializeComponent();
        }

        private void connectDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectDB con = new ConnectDB();
            con.Show();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertRecord record = new InsertRecord();
            record.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchRecord rec = new SearchRecord();
            rec.Show();
        }

        private void searchUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDelete search = new SearchDelete();
            search.Show();
        }

        private void searchDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDelete serch = new SearchDelete();
            serch.Show();
        }

        private void displayAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAll display = new DisplayAll();  
            display.Show();
        }
    }
}
