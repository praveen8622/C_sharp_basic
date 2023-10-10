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
    public partial class NewStudents : Form
    {
        public NewStudents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get values
            Student student = new Student();
            student.SID = int.Parse(textBox1.Text);
            student.FullName = textBox2.Text;
            student.Level = this.comboBox1.SelectedItem.ToString();
            student.Section = this.comboBox2.SelectedItem.ToString();
            student.Sub1 = double.Parse(textBox3.Text);
            student.Sub2 = double.Parse(textBox4.Text);

            //process
            StudentManager studentManager = new StudentManager(student);
            studentManager.Calculatetotal();
            studentManager.CalculateAverage();
            studentManager.CalculateResult();


            //display
            student = studentManager.STUDENT;
            this.textBox5.Text = student.Total.ToString();
            this.textBox6.Text = student.Average.ToString();
            this.textBox7.Text = student.Result;

        }
    }
}
