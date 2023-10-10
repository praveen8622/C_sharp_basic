using MySqlConnector;
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
    public partial class ConnectDB : Form
    {
        public ConnectDB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Connect with the database
            string url = "datasource=localhost; Database=SectionB; port=3306; User=root; Password=9860juno#";
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(url);
                conn.Open();
                conn.Close();
                MessageBox.Show("Connect with database server successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
