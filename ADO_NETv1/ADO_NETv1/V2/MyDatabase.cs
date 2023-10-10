using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace ADO_NETv1.V2
{
    internal class MyDatabase
    {
        private MySqlConnection conn;
        private string url = "datasource=localhost;database=SectionB;port3306;User=root;password=9860juno#";
        public MySqlConnection Connect() {
            try { 
                conn = new MySqlConnection(url);
                conn.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());  
            }
             return conn; 
        }
        public bool Close(MySqlConnection conn)
        {
            bool result= false;
            try {
                conn.Close();
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;  

        }
    }      

}

