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
    public partial class FDanhSachPhieuNhap : Form
    {
        PhieuNhapController phieuNhapController = new PhieuNhapController();
        public FDanhSachPhieuNhap()
        {
            InitializeComponent();
        }

        private void FDanhSachPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                dtgvPhieuNhap.DataSource = phieuNhapController.DSPhieuNhap();
                dtgvPhieuNhap.RowHeadersVisible = false;
                dtgvPhieuNhap.BackgroundColor = Color.White;
                dtgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dtgvPhieuNhap.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                float giatri;

                if (!float.TryParse(row.Cells["GiaTriDonHang"].Value.ToString(), out giatri))
                    giatri = 0;
                DateTime dateTime;
                if (!DateTime.TryParse(row.Cells["NgayNhap"].Value.ToString(), out dateTime))
                    dateTime = DateTime.MinValue;
                PhieuNhap phieuNhap = new PhieuNhap(row.Cells["MaPhieuNhap"].Value.ToString(), dateTime, giatri, row.Cells["TenNhaCC"].Value.ToString(),
                    null, 0,0);
                // Thêm logic xử lý khi cell được click sau khi áp dụng bộ lọc
                FPhieuNhap fChiTietPhieNhap = new FPhieuNhap(phieuNhap);
                fChiTietPhieNhap.ShowDialog();
                FDanhSachPhieuNhap_Load(sender, e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FThemPhieuNhap themPhieuNhap = new FThemPhieuNhap();
            themPhieuNhap.ShowDialog();
            FDanhSachPhieuNhap_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTenNCC.Text != "")
            {
                try
                {
                    dtgvPhieuNhap.DataSource = phieuNhapController.timKiemNCCTheoTen(txtTenNCC.Text);
                    dtgvPhieuNhap.RowHeadersVisible = false;
                    dtgvPhieuNhap.BackgroundColor = Color.White;
                    dtgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch
                {
                    MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
                }
            }
        }
    }
}
