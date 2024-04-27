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
    public partial class FDanhSachPhieuMuonTra : Form
    {
        MuonTraSachController dspmt = new MuonTraSachController();
        public FDanhSachPhieuMuonTra()
        {
            InitializeComponent();

        }
        public void LoadData()
        {
            try
            {
                dtgvPhieuMuonTra.DataSource = dspmt.DSPhieuMuonTra();
                dtgvPhieuMuonTra.RowHeadersVisible = false;
                dtgvPhieuMuonTra.BackgroundColor = Color.White;
                dtgvPhieuMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
        private void FDanhSachPhieuMuonTra_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvPhieuMuonTra.DataSource = dspmt.timKiemPhieuMuonTra(txtTenDocGia.Text);
                dtgvPhieuMuonTra.RowHeadersVisible = false;
                dtgvPhieuMuonTra.BackgroundColor = Color.White;
                dtgvPhieuMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FThemPhieuMuonTra fThemPhieuMuonTra = new FThemPhieuMuonTra();
            fThemPhieuMuonTra.ShowDialog();
            FDanhSachPhieuMuonTra_Load(sender,e);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvPhieuMuonTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dtgvPhieuMuonTra.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                PhieuMuonTra pmt = new PhieuMuonTra(row.Cells["MaPhieuMuonTra"].Value.ToString(),
                    row.Cells["TenNV"].Value.ToString(), row.Cells["TenDocGia"].Value.ToString(),
                    row.Cells["NgayMuon"].Value.ToString(), row.Cells["HanTra"].Value.ToString());
                // Thêm logic xử lý khi cell được click sau khi áp dụng bộ lọc
                FPhieuMuonTra fPhieuMuonTra = new FPhieuMuonTra(pmt);
                fPhieuMuonTra.ShowDialog();
                FDanhSachPhieuMuonTra_Load(sender, e);
            }
        }
    }
}
