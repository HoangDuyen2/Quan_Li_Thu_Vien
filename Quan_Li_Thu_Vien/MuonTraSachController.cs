using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Quan_Li_Thu_Vien
{
    public class MuonTraSachController
    {
        DBConnection conn = new DBConnection();
        #region list view
        public DataTable DSPhieuMuonTra()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM MuonTraView", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable DSChiTietPhieuMuonTra(string maPMT)
        {
            SqlCommand cmd = new SqlCommand("EXEC XemCTPMTtheoMaPMT @mapmt = '" + maPMT + "'", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable DSChiTietPhieuPhat(string maPhieuPhat)
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM func_TimKiemTheoMaPhieuPhat(@MaPP)",conn.GetSqlConnection());
            cmmd.Parameters.Add("@MaPP", SqlDbType.NVarChar).Value = maPhieuPhat;
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable DSTenCacLoaiPhat()
        {
            SqlCommand cmmd = new SqlCommand("SELECT LoaiPhat FROM Phat", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable DSNhanVien()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ThongTinNhanVienView", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable DSDocGia()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DocGiaView", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable DSDocGiaViPham()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DanhSachDocGiaViPham", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable DSPhieuTreHan()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM MuonTraTreHanView", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable DSPhieuPhat()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuPhatView", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable DSSachDaMuonTrongNgay()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SachDaMuonTrongNgay", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable DSNhanVienTheoToMuonSach()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVienTheoToMuonSach", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        #endregion
        public bool checkMaDocGia(string maDocGia)
        {
            string funcName = "[dbo].[func_SearchDocGiaByMaDocGia]";
            SqlCommand cmmd = new SqlCommand("SELECT " + funcName + " (@MaDocGia)", conn.GetSqlConnection());
            cmmd.Parameters.AddWithValue("@MaDocGia", maDocGia);
            conn.openConnection();
            int result = (int)cmmd.ExecuteScalar();
            if (result == 0)
            {
                return false;
            }
            return true;
        }
        public bool checkTinhTrangCTPMT(string mapmt, string maSach)
        {
            SqlCommand cmmd = new SqlCommand("SELECT [dbo].[func_KiemTraTinhTrangPhieuMuonTra] (@MaPhieuMuonTra, @MaSach)", conn.GetSqlConnection());
            cmmd.Parameters.AddWithValue("@MaPhieuMuonTra", mapmt);
            cmmd.Parameters.AddWithValue("@MaSach", maSach);
            conn.openConnection() ;
            if((int)cmmd.ExecuteScalar() == 0)
                return false;
            return true;
        }
        public bool themChiTietPhieuPhat(string mapp, string tenPhat)
        {
            SqlCommand cmmd = new SqlCommand("InsertChiTietPhieuPhat", conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.Add("@MaPhieuPhat",SqlDbType.NVarChar).Value = mapp;
            cmmd.Parameters.Add("@LoaiPhat", SqlDbType.NVarChar).Value = tenPhat;
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
        #region Phiếu mượn trả
        public bool suaPhieuMuonTra(PhieuMuonTra phieuMuonTra)
        {
            SqlCommand cmmd = new SqlCommand("UpdatePhieuMuonTra", conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.Add("@MaPhieuMuonTra", SqlDbType.NVarChar).Value = phieuMuonTra.MaPhieuMuonTra;
            cmmd.Parameters.Add("@TenDocGia", SqlDbType.NVarChar).Value = phieuMuonTra.TenDocGia;
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

        public bool themPhieuMuonTra(PhieuMuonTra phieuMuonTra)
        {
            SqlCommand cmmd = new SqlCommand("InsertPhieuMuonTra", conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = phieuMuonTra.TenNV;
            cmmd.Parameters.Add("@MaDocGia", SqlDbType.NVarChar).Value = phieuMuonTra.TenDocGia;
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
        public bool XoaPhieuMuonTra(string maPMT)
        {
            using (SqlConnection connection = conn.GetSqlConnection())
            {
                try
                {
                    conn.openConnection();
                    using (SqlCommand command = new SqlCommand("DeletePhieuMuonTra", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@mapmt", maPMT);
                        int rowsAffected = command.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa phiếu mượn trả: " + ex.Message, "Lỗi");
                    return false;
                }
                finally
                {
                    conn.closeConnection();
                }
            }
        }
        #endregion
        #region Chi tiết phiếu mượn trả
        public bool themChiTietPhieuMuonTra(string maPMT, string MaSach)
        {
            SqlCommand cmmd = new SqlCommand("InsertChiTietPhieuMuonTra", conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.AddWithValue("@MaPhieuMuonTra", maPMT);
            cmmd.Parameters.AddWithValue("@MaSach", MaSach);
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
        public bool daTraChiTietPhieuMuonTra(string maPMT, string MaSach)
        {
            SqlCommand cmmd = new SqlCommand("DaTraChiTietPhieuMuonTra", conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.AddWithValue("@MaPhieuMuonTra", maPMT);
            cmmd.Parameters.AddWithValue("@MaSach", MaSach);
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
        public bool xoaChiTietPhieuMuonTra(string maPMT, string maSach)
        {
            SqlCommand cmmd = new SqlCommand("DeleteChiTietPhieuMuonTra", conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.AddWithValue("@MaPhieuMuonTra", maPMT);
            cmmd.Parameters.AddWithValue("@MaSach", maSach);
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
        #endregion

        public bool themPhieuPhat(PhieuPhat phieuPhat)
        {
            SqlCommand cmmd = new SqlCommand("InsertPhieuPhat", conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.AddWithValue("@MaPhieuMuonTra", phieuPhat.MaPhieuMuonTra);
            cmmd.Parameters.AddWithValue("@MaSach", phieuPhat.MaSach);
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
        public bool XoaPhieuPhat(string maPhieuPhat)
        {
            using (SqlConnection connection = conn.GetSqlConnection())
            {
                try
                {
                    conn.openConnection();
                    using (SqlCommand command = new SqlCommand("DeletePhieuPhat", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@maphieuphat", maPhieuPhat);
                        int rowsAffected = command.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa phiếu phạt: " + ex.Message, "Lỗi");
                    return false;
                }
                finally
                {
                    conn.closeConnection();
                }
            }
        }

        #region Nhân viên
        public bool themThongTinNhanVien(Person person, string maTo)
        {
            SqlCommand cmmd = new SqlCommand("InsertNhanVienvaNhanVien", conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.AddWithValue("@TenNV", person.TenNguoi);
            cmmd.Parameters.AddWithValue("@GioiTinh", person.GioiTinh);
            cmmd.Parameters.AddWithValue("@NgaySinh", person.NgaySinh1);
            cmmd.Parameters.AddWithValue("@DiaChi", person.DiaChi);
            cmmd.Parameters.AddWithValue("@SDT", person.SDT1);
            cmmd.Parameters.AddWithValue("@Luong", person.Luong);
            cmmd.Parameters.AddWithValue("@Email", person.Email);
            cmmd.Parameters.AddWithValue("@MaTo", maTo);
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
        public bool suaThongTinNhanVien(Person person)
        {
            SqlCommand cmmd = new SqlCommand("UpdateStaff", conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.AddWithValue("@MaNV", person.MaNguoi);
            cmmd.Parameters.AddWithValue("@TenNV", person.TenNguoi);
            cmmd.Parameters.AddWithValue("@GioiTinh", person.GioiTinh);
            cmmd.Parameters.AddWithValue("@NgaySinh", person.NgaySinh1);
            cmmd.Parameters.AddWithValue("@Luong", person.Luong);
            cmmd.Parameters.AddWithValue("@DiaChi", person.DiaChi);
            cmmd.Parameters.AddWithValue("@SDT", person.SDT1);
            cmmd.Parameters.AddWithValue("@Email", person.Email);
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
        public bool xoaThongTinNhanVien(string maNV)
        {
            SqlCommand cmmd = new SqlCommand("DeleteStaff", conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.Add("@MaNV",SqlDbType.NVarChar).Value = maNV;
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
        #endregion

        public bool checkTenDocGia(string tenDocGia)
        {
            string funcName = "[dbo].[func_SearchTenDocGiabyTenDocGia]";
            SqlCommand cmmd = new SqlCommand("SELECT " + funcName + " (@TenDocGia)", conn.GetSqlConnection());
            cmmd.Parameters.AddWithValue("@TenDocGia", tenDocGia);
            conn.openConnection();
            int result = (int)cmmd.ExecuteScalar();
            if (result == 0)
            {
                return false;
            }
            return true;
        }
        #region tìm kiếm
        public DataTable timKiemPhieuMuonTra(string tenDocGia)
        {
            string funcName = "func_SearchPMTByTenDG";
            SqlCommand command = new SqlCommand("Select * from " + funcName + " (@ReaderName)", conn.GetSqlConnection());
            command.Parameters.Add("@ReaderName", SqlDbType.NVarChar).Value = tenDocGia;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable timKiemPhieuPhat(string MaSach)
        {
            string funcName = "SearchPhieuPhatByTenSach";
            SqlCommand command = new SqlCommand("Select * from " + funcName + " (@TenSach)", conn.GetSqlConnection());
            command.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = MaSach;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable timKiemNV(string tenNV)
        {
            string funcName = "func_SearchNhanVienByTen";
            SqlCommand command = new SqlCommand("Select * from " + funcName + " (@TenNV)", conn.GetSqlConnection());
            command.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = tenNV;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        #endregion
    }
}
