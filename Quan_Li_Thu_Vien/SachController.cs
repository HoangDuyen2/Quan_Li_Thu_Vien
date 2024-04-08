using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public DataTable DSSachHu()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SachBiHu", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter( cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable DSSachMuon()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SachMuonView", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable DSSachMuonTrongNgay()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SachDaMuonTrongNgay", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable DSNhanVienTrongTo()
        {
            SqlCommand command = new SqlCommand("proc_NhanVienTheoTo",conn.GetSqlConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MaTo","TO01");
            DataTable table = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(table);
            }
            return table;
        }
    }
}
