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
        #region Thêm, sửa, xóa, tìm kiếm theo tên phiếu nhập
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
        public bool xoaPhieuNhap(string maPhieuNhap)
        {
            SqlCommand cmmd = new SqlCommand("proc_xoaPhieuNhap", conn.GetSqlConnection());
            cmmd.CommandType= CommandType.StoredProcedure;
            cmmd.Parameters.Add("@MaPhieuNhap",SqlDbType.NVarChar).Value = maPhieuNhap;
            conn.openConnection();
            if (cmmd.ExecuteNonQuery() > 0)
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
        public DataTable timKiemNCCTheoTen(string tenNCC)
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM func_SearchNCCNameTablePhieuNhap (@TenNCC)", conn.GetSqlConnection());
            cmmd.Parameters.Add("@TenNCC", SqlDbType.NVarChar).Value = tenNCC;
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        #endregion
        #region Thêm, sửa, xóa, tìm kiếm chi tiết phiếu nhập theo ngày nhập hàng
        public bool suaChiTietPhieuNhap(PhieuNhap pn, int SLCu, float DongiaCu)
        {
            SqlCommand command = new SqlCommand("UpdateChiTietPhieuNhap", conn.GetSqlConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuNhap", SqlDbType.NVarChar).Value = pn.MaPhieuNhap;
            command.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = pn.TenSach;
            command.Parameters.Add("@DonGia", SqlDbType.Float).Value = pn.DonGia;
            command.Parameters.Add("@SL", SqlDbType.Int).Value = pn.SoLuong;
            command.Parameters.Add("@SLCu", SqlDbType.Int).Value = SLCu;
            command.Parameters.Add("@DonGiaCu", SqlDbType.Int).Value = DongiaCu;
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
            SqlCommand cmmd = new SqlCommand("InsertChiTietPhieuNhap", conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.Add("@MaPhieuNhap", SqlDbType.NVarChar).Value = pn.MaPhieuNhap;
            cmmd.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = pn.TenSach;
            cmmd.Parameters.Add("@DonGia", SqlDbType.Int).Value = pn.DonGia;
            cmmd.Parameters.Add("@SL", SqlDbType.Int).Value = pn.SoLuong;
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
        public bool xoaChiTietPhieuNhap(string maPhieuNhap, string tenSach)
        {
            SqlCommand cmmd = new SqlCommand("proc_xoaChiTietPhieuNhap", conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.Add("@MaPhieuNhap", SqlDbType.NVarChar).Value = maPhieuNhap;
            cmmd.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = tenSach;
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
        public DataTable timKiemTheoNgay(DateTime NgayDB, DateTime NgayKT)
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM func_CategorizeChiTietPhieuNhapByDate(@NgayBD, @NgayKT)", conn.GetSqlConnection());
            string NgayBDCovert = NgayDB.ToString("yyyy-MM-dd");
            string NgayKTCovert = NgayKT.ToString("yyyy-MM-dd");
            cmmd.Parameters.Add("@NgayBD", SqlDbType.DateTime).Value = NgayBDCovert;
            cmmd.Parameters.Add("@NgayKT", SqlDbType.DateTime).Value = NgayKTCovert;

            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        #endregion

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
        public DataTable DSNCC()
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM NCCView",conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        #region thêm, sửa nhà cung cấp tìm kiếm theo tên nhà cung cấp
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
        public bool suaNhaCungCap(NCC ncc)
        {
            SqlCommand cmmd = new SqlCommand("pro_UpdateNCC",conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.Add("@MaNCC",SqlDbType.NVarChar).Value = ncc.MaNCC;
            cmmd.Parameters.Add("@TenNCC",SqlDbType.NVarChar).Value = ncc.TenNCC;
            cmmd.Parameters.Add("@DiaChi",SqlDbType.NVarChar).Value = ncc.DiaChi;
            cmmd.Parameters.Add("@SDT",SqlDbType.NVarChar).Value = ncc.SDT;
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
        #endregion
        #region Các check khi thêm phiếu nhập và chi tiết phiếu nhập
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
        #endregion
    }



}
