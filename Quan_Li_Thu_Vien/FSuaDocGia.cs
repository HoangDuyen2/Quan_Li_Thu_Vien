using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Thu_Vien
{
    public partial class FSuaDocGia : Form
    {
        DocGiaController docGiaController = new DocGiaController();
        Person person = new Person();
        public FSuaDocGia(Person p) : this()
        {
            person = p;
        }
        public FSuaDocGia()
        {
            InitializeComponent();
        }
        private void FSuaDocGia_Load(object sender, EventArgs e)
        {
            LoadData();
            KhongTruyCap();
        }
        public void LoadData()
        {
            txtMaDocGia.Text = person.MaNguoi;
            txtTenDocGia.Text = person.TenNguoi;
            txtEmail.Text = person.Email;
            txtSoDienThoai.Text = person.SDT1;
            txtMaLoaiDG.Text = person.NgaySinh1;
            if(person.GioiTinh == "M")
                radiobtnNam.Checked = true;
            else radioBtnNu.Checked = true;
            btnOK.Hide();
        }
        #region Các button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btnOK.Hide();
            btnSua.Show();
            KhongTruyCap();
            if (string.IsNullOrEmpty(txtTenDocGia.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtSoDienThoai.Text) || string.IsNullOrEmpty(txtMaLoaiDG.Text))
            {
                MessageBox.Show("Không để trống các trường.", "Thông báo");
                return;
            }
            string sex;
            if (radiobtnNam.Checked)
                sex = "M";
            else sex = "F";
            DocGia docGia = new DocGia(txtMaDocGia.Text, txtTenDocGia.Text, txtEmail.Text, txtSoDienThoai.Text,
                sex, null, txtMaLoaiDG.Text);
            if (docGiaController.suaDocGia(docGia))
            {
                MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
            }
            else MessageBox.Show("Thực thi dữ liệu thất bại", "Lỗi");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.Hide();
            btnOK.Show();
            TruyCap();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (docGiaController.XoaDocGia(txtMaDocGia.Text))
            {
                MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
                btnOK.Hide();
                btnSua.Hide();
            }
            else MessageBox.Show("Thực thi dữ liệu thất bại", "Lỗi");
        }
        #endregion
        #region Truy cập vào textbox
        public void KhongTruyCap()
        {
            txtMaDocGia.Enabled = false;
            txtEmail.Enabled = false;
            txtMaLoaiDG.Enabled = false;
            txtTenDocGia.Enabled = false;
            txtSoDienThoai.Enabled = false;
            radiobtnNam.Enabled = false;
            radioBtnNu.Enabled = false;
        }
        public void TruyCap()
        {
            txtEmail.Enabled = true;
            txtTenDocGia.Enabled = true;
            txtSoDienThoai.Enabled = true;
            radiobtnNam.Enabled = true;
            radioBtnNu.Enabled = true ;
        }
        #endregion
    }
}
