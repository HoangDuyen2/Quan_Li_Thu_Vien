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
    public partial class FAddDocGia : Form
    {
        DocGiaController docGiaController = new DocGiaController();
        public FAddDocGia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tenDocGia.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(soDienThoai.Text) ||
                string.IsNullOrEmpty(gioiTinh.Text) || string.IsNullOrEmpty(loaiDocGia.Text))
            {
                MessageBox.Show("Không để trống các trường.", "Thông báo");
                return;
            }
            DocGia docGia = new DocGia(null, tenDocGia.Text, email.Text, soDienThoai.Text, gioiTinh.Text, null, loaiDocGia.Text);
            if (docGiaController.themDocGia(docGia))
            {
                MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
            }
            else MessageBox.Show("Thực thi dữ liệu thất bại", "Lỗi");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void update_docgia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tenDocGia.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(soDienThoai.Text) ||
                string.IsNullOrEmpty(gioiTinh.Text) || string.IsNullOrEmpty(loaiDocGia.Text) || string.IsNullOrEmpty(maDocGia.Text))
            {
                MessageBox.Show("Không để trống các trường.", "Thông báo");
                return;
            }
            DocGia docGia = new DocGia(maDocGia.Text, tenDocGia.Text, email.Text, soDienThoai.Text, gioiTinh.Text, ngayTao.Text, loaiDocGia.Text);
            if (docGiaController.themDocGia(docGia))
            {
                MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
            }
            else MessageBox.Show("Thực thi dữ liệu thất bại", "Lỗi");
        }

        private void btn_find_doc_gia_Click(object sender, EventArgs e)
        {

        }

        private void view_list_doc_gia_Click(object sender, EventArgs e)
        {
            dataGridView1 = new DataGridView();
            DataTable dataTable = docGiaController.DSDocGia();
            dataGridView1.DataSource = dataTable;
        }
    }
}
