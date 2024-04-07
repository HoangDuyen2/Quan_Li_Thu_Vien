using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Thu_Vien
{
    public class SachController
    {
        DBConnection conn = new DBConnection();
        public DataTable DSSach()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SachView", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
