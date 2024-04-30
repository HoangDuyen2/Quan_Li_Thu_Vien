using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace Quan_Li_Thu_Vien
{
    public class ManagerController
    {
        DBConnection conn = new DBConnection();
        public ManagerController() { }
        public bool suaTaiKhoan(TaiKhoanUser tk)
        {
            SqlCommand cmmd = new SqlCommand("proc_UpdateAccountEmpploye", conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.AddWithValue("@PasswordUser", tk.PasswordUser);
            cmmd.Parameters.AddWithValue("@MaNV", tk.MaNV);
            conn.openConnection();
            if(cmmd.ExecuteNonQuery() > 0)
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
        public bool themTaiKhoan(TaiKhoanUser tk)
        {
            SqlCommand cmmd = new SqlCommand("InsertTaiKhoan", conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.AddWithValue("@MaNV", tk.MaNV);
            conn.openConnection();
            if (cmmd.ExecuteNonQuery() > 0)
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
        public bool xoaTaiKhoan(TaiKhoanUser tk)
        {
            SqlCommand cmmd = new SqlCommand("proc_DeleteAccountEmpploye", conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.AddWithValue("@MaNV", tk.MaNV);
            cmmd.Parameters.AddWithValue("@Username", tk.Username);
            cmmd.Parameters.AddWithValue("@PasswordUser", tk.PasswordUser);
            conn.openConnection();
            if (cmmd.ExecuteNonQuery() > 0)
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
        public DataTable danhSachTaiKhoan()
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM TaiKhoanView", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable danhSachChuaCoTaiKhoan()
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM ChuaCoTaiKhoanView", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
    }
}
