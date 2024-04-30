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
        DBConnection conn = new DBConnection();
        public FormDangNhap()
        {
            InitializeComponent();
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
            conn.openConnection();
            string tk = txtTenDangNhap.Text;
            string mk = txtMatKhau.Text;

            // Check if @username and @password match the existing logins
            string commands = "IF EXISTS (SELECT 1 FROM sys.sql_logins WHERE name = @username AND PWDCOMPARE(@password, password_hash) = 1) SELECT 1 ELSE SELECT 0";
            SqlCommand cmdCheckLogin = new SqlCommand(commands, conn.GetSqlConnection());
            cmdCheckLogin.Parameters.AddWithValue("@username", tk);
            cmdCheckLogin.Parameters.AddWithValue("@password", mk);
            int loginExists = Convert.ToInt32(cmdCheckLogin.ExecuteScalar());

            if (loginExists == 1)
            {
                string cmmd = "SELECT DISTINCT * FROM " + Role + " nv INNER JOIN TaiKhoan tk ON nv.MaNV=tk.MaNV WHERE Username=@username AND PasswordUser=@password";
                SqlCommand cmd = new SqlCommand(cmmd, conn.GetSqlConnection());
                cmd.Parameters.AddWithValue("@username", tk);
                cmd.Parameters.AddWithValue("@password", mk);
                SqlDataReader dta = cmd.ExecuteReader();

                if (dta.Read())
                {
                    MessageBox.Show("Đăng nhập thành công");
                    LoginInfo.Username = txtTenDangNhap.Text;
                    LoginInfo.Password = txtMatKhau.Text;
                    string query = "SELECT tk.MaNV, nv.MaTo FROM TaiKhoan tk INNER JOIN " + Role + " nv ON tk.MaNV = nv.MaNV WHERE tk.Username = @username";

                    SqlCommand cmdGetMaNV = new SqlCommand(query, conn.GetSqlConnection());
                    cmdGetMaNV.Parameters.AddWithValue("@username", tk);
                    string maNV = dta["MaNV"].ToString();

                    LoginInfo.Role = Role;
                    if (Role == "NhanVien")
                    {
                        string maTo = dta["MaTo"].ToString();
                        LoginInfo.maTo = maTo;
                        if (maTo == "TO01")
                        {
                            FTrangChuToNhapSach_NhanVien fTrangChuToNhapSach_NhanVien = new FTrangChuToNhapSach_NhanVien();
                            this.Hide();
                            fTrangChuToNhapSach_NhanVien.ShowDialog();
                            this.Show();
                        }
                        else if (maTo == "TO02")
                        {
                            FTrangChuToMuonSach_NhanVien fTrangChuToMuonSach_NhanVien = new FTrangChuToMuonSach_NhanVien();
                            this.Hide();
                            fTrangChuToMuonSach_NhanVien.ShowDialog();
                            this.Show();
                        }
                        else if (maTo == "TO03")
                        {
                            FTrangChuToSach_NhanVien fTrangChuToSach_NhanVien = new FTrangChuToSach_NhanVien();
                            this.Hide();
                            fTrangChuToSach_NhanVien.ShowDialog();
                            this.Show();
                        }
                    }
                    else if (Role == "ToTruong")
                    {
                        string maTo = dta["MaTo"].ToString();
                        LoginInfo.maTo = maTo;
                        if (maTo == "TO01")
                        {
                            FTrangChuToNhapSach_ToTruongcs fTrangChuToNhapSach_ToTruong = new FTrangChuToNhapSach_ToTruongcs();
                            this.Hide();
                            fTrangChuToNhapSach_ToTruong.ShowDialog();
                            this.Show();
                        }
                        else if (maTo == "TO02")
                        {
                            FTrangChuToMuonSach_ToTruong fTrangChuToMuonSach_ToTruong = new FTrangChuToMuonSach_ToTruong();
                            this.Hide();
                            fTrangChuToMuonSach_ToTruong.ShowDialog();
                            this.Show();
                        }
                        else if (maTo == "TO03")
                        {
                            FTrangChuToSach_ToTruong fTrangChuToSach_ToTruong = new FTrangChuToSach_ToTruong();
                            this.Hide();
                            fTrangChuToSach_ToTruong.ShowDialog();
                            this.Show();
                        }
                    }
                    else if (Role == "NguoiQuanLi")
                    {
                        FManager fManager = new FManager();
                        fManager.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
                dta.Close();
            }
        }
    }
}