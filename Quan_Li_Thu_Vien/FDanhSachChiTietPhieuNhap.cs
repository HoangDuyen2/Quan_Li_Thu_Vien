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
    public partial class FDanhSachChiTietPhieuNhap : Form
    {
        PhieuNhapController nhapController = new PhieuNhapController();
        public FDanhSachChiTietPhieuNhap()
        {
            InitializeComponent();
        }

        private void dtgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dtgvPhieuNhap.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                float donGia;
                int sl;
                if (!float.TryParse(row.Cells["DonGia"].Value.ToString(), out donGia))
                    donGia = 0;
                if (!int.TryParse(row.Cells["SL"].Value.ToString(), out sl))
                    sl = 0;
                DateTime dateTime;
                if (!DateTime.TryParse(row.Cells["NgayNhap"].Value.ToString(), out dateTime))
                    dateTime = DateTime.MinValue;
                PhieuNhap phieuNhap = new PhieuNhap(row.Cells["MaPhieuNhap"].Value.ToString(), dateTime, 0, row.Cells["TenNhaCC"].Value.ToString(),
                    row.Cells["TenSach"].Value.ToString(), donGia,sl);
                // Thêm logic xử lý khi cell được click sau khi áp dụng bộ lọc
                FSuaChiTietPhieuNhap fPhieNhap = new FSuaChiTietPhieuNhap(phieuNhap);
                this.Hide();
                fPhieNhap.ShowDialog();
            }
        }
        public void LoadData()
        {
            try
            {
                dtgvPhieuNhap.DataSource = nhapController.DSChiTietPhieuNhap();
                dtgvPhieuNhap.RowHeadersVisible = false;
                dtgvPhieuNhap.BackgroundColor = Color.White;
                dtgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
        private void FDanhSachChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
