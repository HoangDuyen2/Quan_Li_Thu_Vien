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
        public FSuaDocGia()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDocGia.Text) || string.IsNullOrEmpty(txtTenDocGia.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSoDienThoai.Text) || string.IsNullOrEmpty(txtGioiTinh.Text) || string.IsNullOrEmpty(txtMaLoaiDG.Text))
            {
                MessageBox.Show("Không để trống các trường.", "Thông báo");
                return;
            }
            if (txtMaDocGia.Text != "" && txtTenDocGia.Text != "" && txtEmail.Text != "" && txtSoDienThoai.Text != "" && txtGioiTinh.Text != "" && txtMaLoaiDG.Text != "")
            {
                DocGia docGia = new DocGia(txtMaDocGia.Text, txtTenDocGia.Text, txtEmail.Text, txtSoDienThoai.Text, txtGioiTinh.Text, txtNgayTao.Text, txtMaLoaiDG.Text);
                if (docGiaController.suaDocGia(docGia))
                {
                    MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
                }
                else MessageBox.Show("Thực thi dữ liệu thất bại", "Lỗi");
            }
        }
    }
}
