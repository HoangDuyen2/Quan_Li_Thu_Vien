using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Quan_Li_Thu_Vien
{
    public partial class FThemPhieuNhap : Form
    {

        PhieuNhapController phieuNhapController = new PhieuNhapController();
        public FThemPhieuNhap()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_tao_phieu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ngayNhap.Text) || string.IsNullOrEmpty(giaTri.Text) || string.IsNullOrEmpty(maNcc.Text) ||
                string.IsNullOrEmpty(tenSach.Text) || string.IsNullOrEmpty(donGia.Text) ||
                string.IsNullOrEmpty(soLuong.Text) || string.IsNullOrEmpty(maNv.Text))
            {
                MessageBox.Show("Không để trống các trường.", "Thông báo");
                return;
            }
            PhieuNhap phieuNhap = new PhieuNhap(DateTime.Parse(ngayNhap.Text), float.Parse(giaTri.Text), maNcc.Text, tenSach.Text,
                float.Parse(donGia.Text), int.Parse(soLuong.Text), maNv.Text);
            if(phieuNhapController.taoPhieuNhap(phieuNhap))
            {
                MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
            }
            else MessageBox.Show("Thực thi dữ liệu thất bại", "Lỗi");
        }

        private void view_list_phieu_nhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            view_list_phieu_nhap = new DataGridView();
            DataTable dataTable = phieuNhapController.DSPhieuPhat();
            view_list_phieu_nhap.DataSource = dataTable;
        }
    }
}
