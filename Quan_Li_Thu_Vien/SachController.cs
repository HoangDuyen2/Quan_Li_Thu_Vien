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
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace Quan_Li_Thu_Vien
{
    public class SachController
    {
        DBConnection conn = new DBConnection();
        #region list view
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
        public DataTable DSNhanVienTrongTo(string maTo)
        {
            SqlCommand command = new SqlCommand("NhanVienTheoTo", conn.GetSqlConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaTo", SqlDbType.NVarChar).Value = maTo;
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
        public DataTable DSNhaXuatBan()
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM view_NhaXuatBan", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        #endregion
        #region Add, Update, Search Author
        public bool themTacGia(TacGia tg)
        {
            SqlCommand command = new SqlCommand("pro_InsertTacGia", conn.GetSqlConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TenTG", SqlDbType.NVarChar).Value = tg.TenTG;
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = tg.GioiTinh1;
            int namsinh = tg.NamSinh1;
            if(namsinh != 0)
                command.Parameters.Add("@NamSinh", SqlDbType.Int).Value = namsinh;
            else command.Parameters.Add("@NamSinh", SqlDbType.Int).Value = DBNull.Value;
            int nammat = tg.NamMat1;
            if(nammat != 0)
                command.Parameters.Add("@NamMat", SqlDbType.Int).Value = nammat;
            else command.Parameters.Add("@NamMat", SqlDbType.Int).Value = DBNull.Value;
            if(tg.QueQuan1 != "")
                command.Parameters.Add("@QueQuan", SqlDbType.NVarChar).Value = tg.QueQuan1;
            else command.Parameters.Add("@QueQuan", SqlDbType.NVarChar).Value = DBNull.Value;
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
        public bool suaTacGia(TacGia tg)
        {
            SqlCommand command = new SqlCommand("pro_UpdateTacGia", conn.GetSqlConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaTG", SqlDbType.NVarChar).Value = tg.MaTG;
            command.Parameters.Add("@TenTacGia", SqlDbType.NVarChar).Value = tg.TenTG;
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = tg.GioiTinh1;
            int namsinh = tg.NamSinh1;
            if (namsinh != 0)
                command.Parameters.Add("@NamSinh", SqlDbType.Int).Value = namsinh;
            else command.Parameters.Add("@NamSinh", SqlDbType.Int).Value = DBNull.Value;
            int nammat = tg.NamMat1;
            if (nammat != 0)
                command.Parameters.Add("@NamMat", SqlDbType.Int).Value = nammat;
            else command.Parameters.Add("@NamMat", SqlDbType.Int).Value = DBNull.Value;
            if (tg.QueQuan1 != "")
                command.Parameters.Add("@QueQuan", SqlDbType.NVarChar).Value = tg.QueQuan1;
            else command.Parameters.Add("@QueQuan", SqlDbType.NVarChar).Value = DBNull.Value;
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
        public void thucThiThemSua(TacGia tg)
        {
            string matg = tg.MaTG;
            if (matg == "")
            {
                if (themTacGia(tg))
                    MessageBox.Show("Thực thi thêm tác giả thành công", "Information", MessageBoxButtons.OK);
                else MessageBox.Show("Thực thi thêm tác giả thất bại", "Information", MessageBoxButtons.OK);
            }
            else {
                if (suaTacGia(tg))
                    MessageBox.Show("Thực thi sửa tác giả thành công", "Information", MessageBoxButtons.OK);
                else MessageBox.Show("Thực thi sửa tác giả thất bại", "Information", MessageBoxButtons.OK);
            }
        }
        public DataTable timKiemTacGia(string tenTG)
        {
            string funcName = "func_SearchTGName";
            SqlCommand command = new SqlCommand("Select * from " + funcName + " (@TenTG)", conn.GetSqlConnection());
            command.Parameters.Add("@TenTG", SqlDbType.NVarChar).Value = tenTG;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        #endregion
        #region Add, Update, Search Book
        public DataTable timKiemSach(string tenSach)
        {
            string funcName = "func_SearchBookName";
            SqlCommand command = new SqlCommand("Select * from " + funcName + " (@TenSach)", conn.GetSqlConnection());
            command.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = tenSach;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public bool suaSach(Sach sach, string tenTGold)
        {
            SqlCommand command = new SqlCommand("[dbo].[proc_suaSach]", conn.GetSqlConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaSach", SqlDbType.NVarChar).Value = sach.MaSach;
            command.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = sach.TenSach;
            command.Parameters.Add("@TenNXB", SqlDbType.NVarChar).Value = sach.TenNXB;
            command.Parameters.Add("@TenLoaiSach", SqlDbType.NVarChar).Value = sach.TenLoaiSach;
            command.Parameters.Add("@NamXB", SqlDbType.Int).Value = sach.NamXB1;
            command.Parameters.Add("@TenNgonNgu", SqlDbType.NVarChar).Value = sach.TenNgonNgu;
            command.Parameters.Add("@SoLuongTon", SqlDbType.Int).Value = sach.SoLuongTon;
            command.Parameters.Add("@SoLuongSach", SqlDbType.Int).Value = sach.SoLuongSach;
            command.Parameters.Add("@TenTGNew", SqlDbType.NVarChar).Value = sach.TacGia1;
            command.Parameters.Add("@TenTGOld", SqlDbType.NVarChar).Value = tenTGold;
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
        public bool themSach(Sach sach)
        {
            SqlCommand cmmd = new SqlCommand("pro_InsertBook", conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = sach.TenSach;
            cmmd.Parameters.Add("@TenNXB", SqlDbType.NVarChar).Value = sach.TenNXB;
            cmmd.Parameters.Add("@TenLoaiSach", SqlDbType.NVarChar).Value = sach.TenLoaiSach;
            cmmd.Parameters.Add("@TenNgonNgu", SqlDbType.NVarChar).Value = sach.TenNgonNgu;
            cmmd.Parameters.Add("@NamXB", SqlDbType.Int).Value = sach.NamXB1;
            cmmd.Parameters.Add("@SoLuongTon", SqlDbType.Int).Value = sach.SoLuongTon;
            cmmd.Parameters.Add("@SoLuongSach", SqlDbType.Int).Value = sach.SoLuongSach;
            cmmd.Parameters.Add("@TenTacGia1", SqlDbType.NVarChar).Value = sach.TacGia1;
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
        #region Add, Update, Search NXB
        public DataTable timKiemNXB(string tenNXB)
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM func_SearchNXBName (@TenNXB)", conn.GetSqlConnection());
            cmmd.Parameters.Add("@TenNXB", SqlDbType.NVarChar).Value = tenNXB;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            adapter.Fill(table);
            return table;
        }
        public bool suaNXB(NXB nxb)
        {
            SqlCommand cmmd = new SqlCommand("pro_UpdateNXB", conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.Add("@MaNXB",SqlDbType.NVarChar).Value = nxb.MaNXB;
            cmmd.Parameters.Add("@TenNXB",SqlDbType.NVarChar).Value = nxb.TenNXB;
            cmmd.Parameters.Add("@DiaChi",SqlDbType.NVarChar).Value = nxb.DiaChi1;
            cmmd.Parameters.Add("@SDT",SqlDbType.NVarChar).Value = nxb.SDT1;
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
        public bool themNXB(NXB nxb)
        {
            SqlCommand cmmd = new SqlCommand("pro_InsertNXB", conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.Add("@TenNXB", SqlDbType.NVarChar).Value = nxb.TenNXB;
            cmmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nxb.DiaChi1;
            cmmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nxb.SDT1;
            conn.openConnection() ;
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
        #region Add Ngôn ngữ
        public bool ThemNgonNgu(string tenNgonNgu)
        {
            SqlCommand cmmd = new SqlCommand("pro_InsertNgonNgu", conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.Add("@TenNN", SqlDbType.NVarChar).Value = tenNgonNgu;
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
        #region Add Loại sách
        public bool ThemLoaiSach(string tenLS)
        {
            SqlCommand cmmd = new SqlCommand("pro_InsertLoaiSach", conn.GetSqlConnection());
            cmmd.CommandType = CommandType.StoredProcedure;
            cmmd.Parameters.Add("@TenLS", SqlDbType.NVarChar).Value = tenLS;
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
        #region Kiểm tra điều kiện khi thêm sách
        public bool checkTenTG(string tenTG)
        {
            string funcName = "[dbo].[func_SearchTenTGByName]";
            SqlCommand cmmd = new SqlCommand("SELECT " + funcName + " (@TenTacGia)", conn.GetSqlConnection());
            cmmd.Parameters.AddWithValue("@TenTacGia", tenTG);
            conn.openConnection();
            int result = (int)cmmd.ExecuteScalar();
            if (result == 0)
            {
                return false;
            }
            return true;
            
        }
        public bool checkTenNXB(string tenNXB)
        {
            string funcName = "[dbo].[func_SearchTenNXBByName]";
            SqlCommand cmmd = new SqlCommand("SELECT " + funcName + " (@TenNXB)", conn.GetSqlConnection());
            cmmd.Parameters.AddWithValue("@TenNXB", tenNXB);
            conn.openConnection();
            int result = (int)cmmd.ExecuteScalar();
            if(result == 0)
            {
                return false;
            }
            return true;
        }
        public bool checkTenLoaiSach(string tenLoaiSach)
        {
            string funcName = "[dbo].[func_SearchTenLoaiSachByTenLoaiSach]";
            SqlCommand cmmd = new SqlCommand("SELECT " + funcName + " (@TenLoaiSach)", conn.GetSqlConnection());
            cmmd.Parameters.AddWithValue("@TenLoaiSach", tenLoaiSach);
            conn.openConnection();
            int result = (int)cmmd.ExecuteScalar();
            if (result == 0)
            {
                return false;
            }
            return true;
        }
        public bool checkTenNgonNgu(string tenNgonNgu)
        {
            string funcName = "[dbo].[func_SearchTenNgonNguByTenNgonNgu]";
            SqlCommand cmmd = new SqlCommand("SELECT " + funcName + " (@TenNgonNgu)", conn.GetSqlConnection());
            cmmd.Parameters.AddWithValue("@TenNgonNgu", tenNgonNgu);
            conn.openConnection();
            int result = (int)cmmd.ExecuteScalar();
            if (result == 0)
            {
                return false;
            }
            return true;
        }
        #endregion
        #region Load data combobox
        public DataTable DSTenCacLoaiSach()
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM func_TenCacLoaiSach()",conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable DSTenNgonNgu()
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM func_TenCacLoaiNgonNgu()", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        #endregion
        #region Filter book
        public DataTable DSSachTheoTheLoaiSach(string tenLoaiSach)
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM func_CategorizeBookByGenre(@TenLoaiSach)", conn.GetSqlConnection());
            cmmd.Parameters.Add("@TenLoaiSach", SqlDbType.NVarChar).Value = tenLoaiSach;
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable DSSachTheoNgonNgu(string tenNgonNgu)
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM func_CategorizeBookByLanguage(@TenNgonNgu)", conn.GetSqlConnection());
            cmmd.Parameters.Add("@TenNgonNgu", SqlDbType.NVarChar).Value = tenNgonNgu;
            SqlDataAdapter adapter = new SqlDataAdapter( cmmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable DSSachTheoTinhTrang(string tinhTrang)
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM func_CategorizeBookBySituation(@TinhTrang)", conn.GetSqlConnection());
            cmmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = tinhTrang;
            SqlDataAdapter adapter= new SqlDataAdapter( cmmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable DSSachTheoNgayMuon(DateTime ngayBD, DateTime ngayKT)
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM func_CategorizeBookByDate(@NgayBD, @NgayKT)", conn.GetSqlConnection());

            // Chuyển đổi ngày từ dạng DateTime C# sang dạng yyyy-MM-dd
            string ngayBDFormatted = ngayBD.ToString("yyyy-MM-dd");
            string ngayKTFormatted = ngayKT.ToString("yyyy-MM-dd");

            // Chuyển đổi kiểu dữ liệu DateTime C# sang kiểu datetime SQL
            cmmd.Parameters.Add("@NgayBD", SqlDbType.DateTime).Value = ngayBDFormatted;
            cmmd.Parameters.Add("@NgayKT", SqlDbType.DateTime).Value = ngayKTFormatted;

            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public object timKiemNV(string text)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}