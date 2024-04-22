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
            command.Parameters.Add("@TenNhaCC", SqlDbType.NVarChar).Value = pn.TenNCC;
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

        public DataTable DSPhieuNhap()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ViewPhieuNhapChiTiet", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public bool ThemNhaCungCap(string TenNCC,string DiaChi,string SDT)
        {
            SqlCommand cmmd = new SqlCommand("pro_InsertNCC", conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.Add("@TenNCC",SqlDbType.NVarChar).Value = TenNCC;
            cmmd.Parameters.Add("@DiaChi",SqlDbType.NVarChar).Value = DiaChi;
            cmmd.Parameters.Add("@SDT",SqlDbType.NVarChar).Value = SDT;
            conn.openConnection() ;
            if(cmmd.ExecuteNonQuery() > 0)
            {
                conn.closeConnection() ;
                return true;
            }
            else
            {
                conn.closeConnection( );
                return false;
            }
        }
        public bool suaNhaCungCap(string maNCC, string tenNCC, string DiaChi,string SDT)
        {
            SqlCommand cmmd = new SqlCommand("pro_UpdateNCC");
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.Add("@MaNCC",SqlDbType.NVarChar).Value = maNCC;
            cmmd.Parameters.Add("@TenNCC",SqlDbType.NVarChar).Value = tenNCC;
            cmmd.Parameters.Add("@DiaChi",SqlDbType.NVarChar).Value = DiaChi;
            cmmd.Parameters.Add("@SDT",SqlDbType.NVarChar).Value = SDT;
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
        public bool checkTenNCC(string tenNCC)
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM func_SearchTenNCCByName(@TenNhaCungCap)", conn.GetSqlConnection());
            cmmd.Parameters.Add("@TenNhaCungCap",SqlDbType.NVarChar).Value = tenNCC;
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            conn.openConnection();
            int result = (int)cmmd.ExecuteScalar();
            if(result == 1)
            {
                conn.closeConnection() ;
                return true;
            }
            else
            {
                conn.closeConnection( );
                return false;
            }
        }

        public bool checkTenSach(string tenSach)
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM func_SearchTenSachByName(@TenSach)",conn.GetSqlConnection());
            cmmd.Parameters.Add("@TenSach",SqlDbType.NVarChar).Value = tenSach;
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            conn.openConnection();
            int result = ( int)cmmd.ExecuteScalar();
            if(result == 1)
            {
                conn.closeConnection() ;
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
