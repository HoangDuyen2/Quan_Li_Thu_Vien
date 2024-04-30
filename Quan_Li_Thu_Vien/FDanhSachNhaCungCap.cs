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
    public partial class FDanhSachNhaCungCap : Form
    {
        PhieuNhapController phieuNhapController = new PhieuNhapController();
        NCC ncc = new NCC();
        public FDanhSachNhaCungCap()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dtgvTG.DataSource = phieuNhapController.DSNCC();
            dtgvTG.RowHeadersVisible = false;
            dtgvTG.BackgroundColor = Color.White;
            dtgvTG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dtgvTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = dtgvTG.Rows[e.RowIndex];

                // Đưa dữ liệu vào các control hoặc xử lý theo nhu cầu
                ncc.MaNCC = row.Cells["MaNhaCC"].Value.ToString();
                ncc.TenNCC = row.Cells["TenNhaCC"].Value.ToString();
                ncc.DiaChi = row.Cells["DiaChi"].Value.ToString();
                ncc.SDT = row.Cells["SoDienThoai"].Value.ToString();

                // Thêm logic xử lý khi cell được click sau khi áp dụng bộ lọc
                FChiTietNCC fChiTiet = new FChiTietNCC(ncc);
                fChiTiet.ShowDialog();
                FDanhSachNhaCungCap_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FNewNCC themNCC = new FNewNCC();
            themNCC.ShowDialog();
            FDanhSachNhaCungCap_Load(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgvTG.DataSource = phieuNhapController.timKiemNCCTheoTen(txtTenNCCNhap.Text);
            dtgvTG.RowHeadersVisible = false;
            dtgvTG.BackgroundColor = Color.White;
            dtgvTG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FDanhSachNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
