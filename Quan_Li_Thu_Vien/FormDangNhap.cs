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
    public partial class FormDangNhap : Form
    {
        DBConnection conn;
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void radbtnNguoiQuanLy_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnNguoiQuanLy.Checked)
            {

            }
        }

        private void radbtnNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnNhanVien.Checked)
            {

            }
        }
        private void radbtnToTruong_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnToTruong.Checked)
            {

            }
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xac nhan thoat chuong trinh?", "Thong bao", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (radbtnNhanVien.Checked)
                DangNhap("NhanVien");
            if (radbtnNguoiQuanLy.Checked)
                DangNhap("NguoiQuanLi");
            if (radbtnToTruong.Checked)
                DangNhap("ToTruong");
        }
        private void DangNhap(string Role)
        {
            conn = new DBConnection();
            conn.openConnection();
            string tk = txtTenDangNhap.Text;
            string mk = txtMatKhau.Text;
            string cmmd = "select distinct * from "+Role+" nv INNER JOIN TaiKhoan tk ON nv.MaNV=tk.MaNV WHERE Username=@username AND PasswordUser=@password";
            SqlCommand cmd = new SqlCommand(cmmd, conn.GetSqlConnection());
            cmd.Parameters.AddWithValue("@username", tk);
            cmd.Parameters.AddWithValue("@password", mk);

            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read())
            {
                MessageBox.Show("Đăng nhập thành công");
                LoginInfo.Username = txtTenDangNhap.Text;
                string query = "SELECT tk.MaNV, nv.MaTo FROM TaiKhoan tk INNER JOIN "+Role+" nv ON tk.MaNV = nv.MaNV WHERE tk.Username = @username";
                SqlCommand cmdGetMaNV = new SqlCommand(query, conn.GetSqlConnection());
                cmdGetMaNV.Parameters.AddWithValue("@username", tk);
                string maNV = dta["MaNV"].ToString();
                string maTo = dta["MaTo"].ToString();
                if (Role == "NhanVien")
                {
                    if (maTo == "TO02")
                    {
                        FTrangChuToMuonSach_NhanVien fTrangChuToMuonSach_NhanVien = new FTrangChuToMuonSach_NhanVien();
                        this.Hide();
                        fTrangChuToMuonSach_NhanVien.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        if (maTo == "TO03")
                        {
                            FTrangChuToSach_NhanVien fTrangChuToSach_NhanVien = new FTrangChuToSach_NhanVien();
                            this.Hide();
                            fTrangChuToSach_NhanVien.ShowDialog();
                            this.Show();
                        }
                    }
                }
                if (Role == "ToTruong")
                {
                    if (maTo == "TO02")
                    {
                        FTrangChuToMuonSach_ToTruong fTrangChuToMuonSach_ToTruong = new FTrangChuToMuonSach_ToTruong();
                        this.Hide();
                        fTrangChuToMuonSach_ToTruong.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        if (maTo == "TO03")
                        {
                            FTrangChuToSach_ToTruong fTrangChuToSach_ToTruong = new FTrangChuToSach_ToTruong();
                            this.Hide();
                            fTrangChuToSach_ToTruong.ShowDialog();
                            this.Show();
                        }
                    }
                }
                if(Role == "NguoiQuanLi")
                {

                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
            conn.closeConnection();
        }
    }
}