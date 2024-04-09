using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


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
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
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
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable DSNhanVienTrongTo()
        {
            SqlCommand command = new SqlCommand("proc_NhanVienTheoTo", conn.GetSqlConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MaTo", "TO01");
            DataTable table = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(table);
            }
            return table;
        }
        public DataTable DSTacGia()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TacGiaView", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            return datatable;
        }
        public bool themTacGia(TacGia tg)
        {
            SqlCommand command = new SqlCommand("InsertTacGia", conn.GetSqlConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TenTG", SqlDbType.NVarChar).Value = tg.TenTG;
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = tg.GioiTinh1;
            if(tg.NamSinh1 != 0)
                command.Parameters.Add("@NamSinh", SqlDbType.Int).Value = tg.NamSinh1;
            else command.Parameters.Add("@NamSinh", SqlDbType.Int).Value = DBNull.Value;
            if(tg.NamMat1 != 0)
                command.Parameters.Add("@NamMat", SqlDbType.Int).Value = tg.NamMat1;
            else command.Parameters.Add("@NamMat", SqlDbType.Int).Value = DBNull.Value;
            if(tg.QueQuan1 != "")
                command.Parameters.Add("@QueQuan", SqlDbType.NVarChar).Value = tg.QueQuan1;
            else command.Parameters.Add("@QueQuan", SqlDbType.NVarChar).Value = tg.QueQuan1;
            conn.openConnection();
            if (command.ExecuteNonQuery() > 0)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

    }

}
