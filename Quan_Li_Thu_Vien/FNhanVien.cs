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
    public partial class FNhanVien : Form
    {
        DBConnection conn;
        public FNhanVien()
        {
            InitializeComponent();
        }

        private void FNhanVien_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            conn.openConnection();

            string username = LoginInfo.Username;

            string query = "SELECT tk.MaNV, tt.TenNV, tt.GioiTinh, tt.NgaySinh, tt.DiaChi, tt.SDT, tt.Email " +
                           "FROM TaiKhoan tk " +
                           "INNER JOIN ThongTinNhanVien tt ON tk.MaNV = tt.MaNV " +
                           "WHERE tk.Username = @username";

            SqlCommand cmmd = new SqlCommand(query, conn.GetSqlConnection());
            cmmd.Parameters.AddWithValue("@username", username);

            SqlDataReader reader = cmmd.ExecuteReader();
            if (reader.Read())
            {
                // Lấy các giá trị từ cột tương ứng
                string maNV = reader["MaNV"].ToString();
                string tenNV = reader["TenNV"].ToString();
                string gioiTinh = reader["GioiTinh"].ToString();
                string ngaySinh = reader["NgaySinh"].ToString();
                string diaChi = reader["DiaChi"].ToString();
                string sdt = reader["SDT"].ToString();
                string email = reader["Email"].ToString();

                // Lấp các giá trị vào TextBox
                txtMaNV.Text = maNV;
                txtHoVaTen.Text = tenNV;
                txtGioiTinh.Text = gioiTinh;
                txtNgaySinh.Text = ngaySinh;
                txtDiaChi.Text = diaChi;
                txtSoDienThoai.Text = sdt;
                txtEmail.Text = email;
            }
            reader.Close();

            conn.closeConnection();
        }

        private void btnThaoTacSach_Click(object sender, EventArgs e)
        {
            FTrangChuToSach_NhanVien fTrangChuToSach_NhanVien = new FTrangChuToSach_NhanVien();
            this.Hide();
            fTrangChuToSach_NhanVien.ShowDialog();
            this.Show();
        }
    }
}
