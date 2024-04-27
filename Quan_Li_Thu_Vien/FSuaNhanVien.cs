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
        MuonTraSachController muonTraSachController = new MuonTraSachController();
        Person person1;
        string maTo;
        public FSuaNhanVien(Person person, string to) : this()
        {
            person1 = person;
            maTo = to;
        }
        public FSuaNhanVien()
        {
            InitializeComponent();
        }
        private void FSuaNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            KhongTruyCap();
        }
        public void LoadData()
        {
            txtMaNV.Text = person1.MaNguoi;
            txtTenNhanVien.Text = person1.TenNguoi;
            if (person1.GioiTinh == "M")
                radiobtnNam.Checked = true;
            else
            {
                radiobtnNu.Checked = true;
            }
            DateTime date = DateTime.Parse(person1.NgaySinh1);
            dtNgaySinh.Value = date;
            txtDiaChi.Text = person1.DiaChi;
            txtEmail.Text = person1.Email;
            txtLuong.Text = person1.Luong.ToString();
            txtMaTo.Text = person1.MaTo;
            txtSoDienThoai.Text = person1.SDT1;
            txtMaTo.Text = maTo;
            btnOK.Hide();
        }
        #region Các button
        private void btnOK_Click(object sender, EventArgs e)
        {
            btnOK.Hide();
            btnChinhSua.Show();
            KhongTruyCap();
            string sex;
            if (radiobtnNam.Checked)
                sex = "M";
            else sex = "F";
            int luong;
            if (!int.TryParse(txtLuong.Text, out luong))
                MessageBox.Show("Lương nhập không hợp lệ, vui lòng nhập lại", "Thông báo");
            Person person = new Person(txtMaNV.Text, txtTenNhanVien.Text, sex,
                    dtNgaySinh.Value.ToShortDateString(), txtDiaChi.Text, txtSoDienThoai.Text, luong,
                    txtEmail.Text);
            person.MaTo = txtMaTo.Text;
            if (muonTraSachController.suaThongTinNhanVien(person))
            {
                MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
            }
            else MessageBox.Show("Thực thi dữ liệu thất bại", "Lỗi");
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            btnChinhSua.Hide();
            btnOK.Show();
            TruyCap();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (muonTraSachController.xoaThongTinNhanVien(txtMaNV.Text))
            {
                MessageBox.Show("Xóa nhân viên thành công", "Thông báo");
                btnOK.Hide();
                btnChinhSua.Hide();
            }
            else
            {
                MessageBox.Show("Xóa Nhân Viên không thành công", "Lỗi");
            }
        }
        #endregion
        #region Truy cập vào textbox
        public void KhongTruyCap()
        {
            txtMaNV.Enabled = false;
            txtMaTo.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtLuong.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtTenNhanVien.Enabled = false;
            dtNgaySinh.Enabled = false;
            radiobtnNam.Enabled = false;
            radiobtnNu.Enabled = false;
        }
        public void TruyCap()
        {
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            txtLuong.Enabled = true;
            txtSoDienThoai.Enabled = true;
            txtTenNhanVien.Enabled = true;
            radiobtnNam.Enabled = true;
            radiobtnNu.Enabled = true;
            dtNgaySinh.Enabled = true;
        }

        #endregion
    }
}

