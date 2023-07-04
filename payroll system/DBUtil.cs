using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace payroll_system
{
    class DBUtil
    {
        public static MySqlConnection get_DBConnection()
        {
            //configuring the database connection 
            MySqlConnection conncetion = new MySqlConnection("server = localhost; database = payroll_system; uid = root; pwd =  ");
            return conncetion;
        }

        public static void open_Connection(MySqlConnection connection)
        {
            //check if the connection is closed to ensure connection is closed before the open the connection.
            //if closed then open the connection
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
    }
}
