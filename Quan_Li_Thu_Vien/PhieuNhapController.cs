using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Quan_Li_Thu_Vien;
using System.Data.Common;

namespace Quan_Li_Thu_Vien
{
    public class PhieuNhapController
    {
        DBConnection conn = new DBConnection();
        #region Thêm, sửa, tìm kiếm theo tên phiếu nhập
        public bool ThemPhieuNhap(PhieuNhap pn)
        {
            SqlCommand cmmd = new SqlCommand("InsertPhieuNhap",conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            string ngayNhap = pn.NgayNhap.ToString("yyyy-MM-dd");
            cmmd.Parameters.Add("@NgayNhap",SqlDbType.Date).Value = ngayNhap;
            cmmd.Parameters.Add("@GiaTriDonHang", SqlDbType.Int).Value = pn.GiaTri;
            cmmd.Parameters.Add("@TenNhaCC", SqlDbType.NVarChar).Value = pn.TenNCC;
            conn.openConnection();
            if(cmmd.ExecuteNonQuery() >0)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection( );
                return false;
            }
        }
        public bool suaPhieuNhap(PhieuNhap pn)
        {
            SqlCommand cmmd = new SqlCommand("UpdatePhieuNhap",conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.Add("@MaPhieuNhap", SqlDbType.NVarChar).Value = pn.MaPhieuNhap;
            cmmd.Parameters.Add("@NgayNhap", SqlDbType.DateTime).Value = pn.NgayNhap;
            cmmd.Parameters.Add("@GiaTriDonHang", SqlDbType.Float).Value = pn.GiaTri;
            cmmd.Parameters.Add("@TenNCC", SqlDbType.NVarChar).Value = pn.TenNCC;
            conn.openConnection( );
            if(cmmd.ExecuteNonQuery() > 0)
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
        public DataTable timKiemNCCTheoTen(string tenNCC)
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM func_SearchNCCName (@TenNCC)", conn.GetSqlConnection());
            cmmd.Parameters.Add("@TenNCC", SqlDbType.NVarChar).Value = tenNCC;
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        #endregion
        public bool suaChiTietPhieuNhap(PhieuNhap pn,int SLCu)
        {
            SqlCommand command = new SqlCommand("UpdateChiTietPhieuNhap", conn.GetSqlConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuNhap", SqlDbType.NVarChar).Value = pn.MaPhieuNhap;
            command.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = pn.TenSach;
            command.Parameters.Add("@DonGia", SqlDbType.Float).Value = pn.DonGia;
            command.Parameters.Add("@SL", SqlDbType.Int).Value = pn.SoLuong;
            command.Parameters.Add("@SLCu", SqlDbType.Int).Value = SLCu;
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
        public bool themChiTietPhieuNhap(PhieuNhap pn)
        {
            SqlCommand cmmd = new SqlCommand("InsertChiTietPhieuNhap",conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.Add("@MaPhieuNhap",SqlDbType.NVarChar).Value =pn.MaPhieuNhap;
            cmmd.Parameters.Add("@TenSach",SqlDbType.NVarChar).Value =pn.TenSach;
            cmmd.Parameters.Add("@DonGia",SqlDbType.Int).Value =pn.DonGia;
            cmmd.Parameters.Add("@SL",SqlDbType.Int).Value =pn.SoLuong;
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
        public DataTable DSPhieuNhap()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ViewPhieuNhap", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable DSChiTietPhieuNhap()
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
            SqlCommand cmmd = new SqlCommand("SELECT [dbo].[func_SearchTenNCCByName] (@TenNhaCungCap)", conn.GetSqlConnection());
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
            SqlCommand cmmd = new SqlCommand("SELECT [dbo].[func_SearchTenSachByName] (@TenSach)",conn.GetSqlConnection());
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
