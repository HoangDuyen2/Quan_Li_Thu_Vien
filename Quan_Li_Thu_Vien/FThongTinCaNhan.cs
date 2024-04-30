using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quan_Li_Thu_Vien
{
    public partial class FThongTinCaNhan : Form
    {
        DBConnection conn;
        public FThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void FThongTinCaNhan_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            conn.openConnection();

            string maNV = TaiKhoan.maNV;

            string query = "SELECT tt.MaNV, tt.TenNV, tt.GioiTinh, tt.NgaySinh,tt.Luong, tt.DiaChi, tt.SDT, tt.Email,tt.NgayTao " +
                           "FROM ThongTinNhanVien tt " +
                           "WHERE tt.MaNV = @maNV";

            SqlCommand cmmd = new SqlCommand(query, conn.GetSqlConnection());
            cmmd.Parameters.AddWithValue("@maNV", maNV);

            SqlDataReader reader = cmmd.ExecuteReader();
            if (reader.Read())
            {
                string tenNV = reader["TenNV"].ToString();
                string gioiTinh = (reader["GioiTinh"].ToString() == "M") ? "Nam" : "Nữ";
                string ngaySinh = reader["NgaySinh"].ToString();
                string diaChi = reader["DiaChi"].ToString();
                int luong = reader.GetInt32(reader.GetOrdinal("Luong"));
                string sdt = reader["SDT"].ToString();
                string email = reader["Email"].ToString();
                DateTime ngaytao = reader.GetDateTime(reader.GetOrdinal("NgayTao"));

                txtMaNV.Text = maNV;
                txtHoVaTen.Text = tenNV;
                txtGioiTinh.Text = gioiTinh;
                txtNgaySinh.Text = ngaySinh;
                txtDiaChi.Text = diaChi;
                txtLuong.Text = luong.ToString();
                txtSoDienThoai.Text = sdt;
                txtEmail.Text = email;
                txtNgayTaoNV.Text = ngaytao.ToString("dd/MM/yyyy");
            }
            reader.Close();
            conn.closeConnection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
