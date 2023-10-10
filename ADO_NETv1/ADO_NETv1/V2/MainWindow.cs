using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NETv1.V2
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void newStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStudents newStudent = new NewStudents();
            newStudent.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStudents newStudents = new NewStudents();
            newStudents.Show();
        }
    }
}
