using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
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
        #endregion
        #region Load data combobox
        public DataTable DSCacLoaiSach()
        {
            SqlCommand cmmd = new SqlCommand("SELECT * FROM func_TenCacLoaiSach()",conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable DSNgonNgu()
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
        #endregion
    }
}

