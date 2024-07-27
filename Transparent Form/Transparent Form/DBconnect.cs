using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Transparent_Form
{
    internal class DBconnect
    {
        string connstring = "server=localhost;uid=admin;password=admin;database=studentdb";

        MySqlConnection connection = new MySqlConnection();
        con.ConnectionString = connstring;
        con.Open();
        string sql ="select * from "



        public MySqlConnection getconnection()
        {
          
            { 
                return connection;
            }
           
        }

        public void openConnect()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnect()
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Close();

        }
    }
}
