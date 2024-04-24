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
    public partial class FThemTaiKhoanMoiTao : Form
    {
        DBConnection conn = new DBConnection();
        MuonTraSachController nvmt = new MuonTraSachController();
        private string maNV;
        public FThemTaiKhoanMoiTao()
        {
            InitializeComponent();
        }
        public void SetMaNV(string maNV)
        {
            this.maNV = maNV;
        }
        private void FThemTaiKhoanMoiTao_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaiKhoan.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Không để trống các trường.", "Thông báo");
                return;
            }
            if (txtTaiKhoan.Text != "" && txtMatKhau.Text != "")
            {
                TaiKhoan taiKhoan = new TaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text, maNV);
                if (nvmt.themTaiKhoanNhanVien(taiKhoan))
                {
                    MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FDanhSachNhanVien fDanhSachNhanVien = new FDanhSachNhanVien();
            this.Close();
            fDanhSachNhanVien.ShowDialog();
            this.Show();
        }
    }
}
