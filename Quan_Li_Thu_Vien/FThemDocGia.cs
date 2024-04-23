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
    public partial class FThemDocGia : Form
    {
        DBConnection conn = new DBConnection();
        DocGiaController docGiaController = new DocGiaController();
        public FThemDocGia()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FDanhSachDocGia fDanhSachDocGia = new FDanhSachDocGia();
            this.Close();
            fDanhSachDocGia.ShowDialog();
            this.Show();
        }

        private void FThemDocGia_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDocGia.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSoDienThoai.Text) || string.IsNullOrEmpty(txtGioiTinh.Text) || string.IsNullOrEmpty(txtMaLoaiDG.Text))
            {
                MessageBox.Show("Không để trống các trường.", "Thông báo");
                return;
            }
            if (txtTenDocGia.Text != "" && txtEmail.Text != "" && txtSoDienThoai.Text != "" && txtGioiTinh.Text != "" && txtMaLoaiDG.Text != "")
            {    
                DocGia docGia = new DocGia(txtMaDocGia.Text, txtTenDocGia.Text, txtEmail.Text, txtSoDienThoai.Text, txtGioiTinh.Text, txtNgayTao.Text, txtMaLoaiDG.Text);
                if (docGiaController.themDocGia(docGia))
                {
                    MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
                }
                else MessageBox.Show("Thực thi dữ liệu thất bại", "Lỗi");
            }
        }
    }
}
