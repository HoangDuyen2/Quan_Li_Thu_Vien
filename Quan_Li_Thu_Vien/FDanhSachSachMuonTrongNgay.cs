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
    public partial class FDanhSachSachMuonTrongNgay : Form
    {
        SachController dsSachMuonTrongNgay = new SachController();
        public FDanhSachSachMuonTrongNgay()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            try
            {
                dtgvSach.DataSource = dsSachMuonTrongNgay.DSSachMuon();
                dtgvSach.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }

        private void FDanhSachSachMuonTrongNgay_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dtgvSach.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value.ToString();
                txtNXB.Text = row.Cells["TenNXB"].Value.ToString();
                txtLoaiSach.Text = row.Cells["TenLoaiSach"].Value.ToString();
                txtNamXB.Text = row.Cells["NamXB"].Value.ToString();
                txtNgonNgu.Text = row.Cells["TenNgonNgu"].Value.ToString();
                txtTacGia.Text = row.Cells["TenTG"].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
