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
    public partial class FNewNV : Form
    {
        MuonTraSachController muonTraSachController = new MuonTraSachController();
        public FNewNV()
        {
            InitializeComponent();
        }
        private void FNewNV_Load(object sender, EventArgs e)
        {
            txtMaTo.Text = LoginInfo.maTo;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNhanVien.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtSoDienThoai.Text)
                || string.IsNullOrEmpty(txtLuong.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Không để trống các trường.", "Thông báo");
                return;
            }
            string sex;
            if (radiobtnNam.Checked)
                sex = "M";
            else sex = "F";
            int luong;
            if (!int.TryParse(txtLuong.Text, out luong))
                MessageBox.Show("Lương nhập không hợp lệ, vui lòng nhập lại", "Thông báo");
            Person person = new Person(txtMaNV.Text, txtTenNhanVien.Text, sex,dtNgaySinh.Value.ToShortDateString(),
                txtDiaChi.Text, txtSoDienThoai.Text, luong, txtEmail.Text);
            if (muonTraSachController.themThongTinNhanVien(person, LoginInfo.maTo))
            {
                MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
