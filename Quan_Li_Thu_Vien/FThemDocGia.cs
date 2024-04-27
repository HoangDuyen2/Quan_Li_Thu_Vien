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
        DocGiaController docGiaController = new DocGiaController();
        public FThemDocGia()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FThemDocGia_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDocGia.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSoDienThoai.Text)
               || string.IsNullOrEmpty(txtMaLoaiDG.Text))
            {
                MessageBox.Show("Không để trống các trường.", "Thông báo");
                return;
            }
            if (txtMaLoaiDG.Text != "SV" && txtMaLoaiDG.Text == "GV")
            {
                MessageBox.Show("Hãy nhập SV hoặc GV", "Thông báo");
                return;
            }
            string sex;
            if (radiobtnNam.Checked)
                sex = "M";
            else sex = "F";
            DocGia docGia = new DocGia(txtMaDocGia.Text, txtTenDocGia.Text, txtEmail.Text, txtSoDienThoai.Text, sex, null, txtMaLoaiDG.Text);
            if (docGiaController.themDocGia(docGia))
            {
                MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
            }
            else MessageBox.Show("Thực thi dữ liệu thất bại", "Lỗi");

        }
    }
}
