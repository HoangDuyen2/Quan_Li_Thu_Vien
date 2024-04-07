using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Thu_Vien
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);

        public SqlConnection GetSqlConnection()
        {
            return conn;
        }
        // open the connection
        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
