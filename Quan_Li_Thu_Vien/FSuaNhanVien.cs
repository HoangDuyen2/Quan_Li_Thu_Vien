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
    public partial class FSuaNhanVien : Form
    {
        DBConnection conn = new DBConnection();
        MuonTraSachController muonTraSachController = new MuonTraSachController();
        public FSuaNhanVien()
        {
            InitializeComponent();
        }
        private void FSuaNhanVien_Load(object sender, EventArgs e)
        {

        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNhanVien.Text) || string.IsNullOrEmpty(txtGioiTinh.Text) || (string.IsNullOrEmpty(txtNgaySinh.Text)) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtSoDienThoai.Text) || string.IsNullOrEmpty(txtLuong.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtMaTo.Text))
            {
                MessageBox.Show("Không để trống các trường.", "Thông báo");
                return;
            }
            if (txtTenNhanVien.Text != "" && txtGioiTinh.Text != "" && txtNgaySinh.Text != "" && txtDiaChi.Text != "" && txtSoDienThoai.Text != "" && txtLuong.Text != "" && txtEmail.Text != "" && txtMaTo.Text != "")
            {
                Person person = new Person(txtMaNV.Text, txtTenNhanVien.Text, txtGioiTinh.Text, txtNgaySinh.Text, txtDiaChi.Text, txtSoDienThoai.Text, int.Parse(txtLuong.Text), txtEmail.Text);
                if (muonTraSachController.suaThongTinNhanVien(person))
                {
                    MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
                }
                else MessageBox.Show("Thực thi dữ liệu thất bại", "Lỗi");
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
