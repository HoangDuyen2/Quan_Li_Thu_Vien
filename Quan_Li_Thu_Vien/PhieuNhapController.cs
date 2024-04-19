using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Quan_Li_Thu_Vien;

namespace Quan_Li_Thu_Vien
{
    public class PhieuNhapController
    {
        DBConnection conn = new DBConnection();

        public bool taoPhieuNhap(PhieuNhap pn)
        {
            SqlCommand command = new SqlCommand("pro_InsertPhieunhapChitietphieunhap", conn.GetSqlConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ngayNhap", SqlDbType.Date).Value = pn.NgayNhap;
            command.Parameters.Add("@giaTriDonHang", SqlDbType.Float).Value = pn.GiaTri;
            command.Parameters.Add("@maNhaCC", SqlDbType.NVarChar).Value = pn.MaNCC;
            command.Parameters.Add("@tenSach", SqlDbType.NVarChar).Value = pn.TenSach;
            command.Parameters.Add("@donGia", SqlDbType.Float).Value = pn.DonGia;
            command.Parameters.Add("@soLuong", SqlDbType.Int).Value = pn.SoLuong;
            command.Parameters.Add("@maNV", SqlDbType.NVarChar).Value = pn.MaNV;
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

        public DataTable DSPhieuPhat()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ViewDocGia", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

    }



}
