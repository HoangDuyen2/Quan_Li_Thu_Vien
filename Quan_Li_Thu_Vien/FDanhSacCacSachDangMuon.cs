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
    public partial class FDanhSacCacSachDangMuon : Form
    {
        SachController dsSachMuon = new SachController();
        public FDanhSacCacSachDangMuon()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                dtgvSach.DataSource = dsSachMuon.DSSachMuon();
                dtgvSach.RowHeadersVisible = false;
                dtgvSach.BackgroundColor = Color.White;
                dtgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
        private void FDanhSacCacSachDangMuon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dtgvSach.Rows[e.RowIndex];

                // Đưa dữ liệu vào các control hoặc xử lý theo nhu cầu
                Sach sach = new Sach(row.Cells["MaSach"].Value.ToString(), row.Cells["TenSach"].Value.ToString(), row.Cells["TenNXB"].Value.ToString(),
                    row.Cells["TenLoaiSach"].Value.ToString(), row.Cells["TenNgonNgu"].Value.ToString(), row.Cells["NamXB"].Value.ToString(), null,
                    null, row.Cells["TenTG"].Value.ToString());
                // Thêm logic xử lý khi cell được click sau khi áp dụng bộ lọc
                FChiTietSachMuon fChiTiet = new FChiTietSachMuon(sach, row.Cells["TenDocGia"].Value.ToString(), row.Cells["TinhTrang"].Value.ToString());
                fChiTiet.ShowDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvSach.DataSource = dsSachMuon.DSSachTheoNgayMuon(dtBatDau.Value,dtKetThuc.Value);
                DataView dv = new DataView((DataTable)dtgvSach.DataSource);
                dtgvSach.DataSource = dv.ToTable();
                dtgvSach.RowHeadersVisible = false;
                dtgvSach.BackgroundColor = Color.White;
                dtgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }

        private void comboBoxTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtgvSach.DataSource = dsSachMuon.DSSachTheoTinhTrang(comboBoxTinhTrang.Text);
                DataView dv = new DataView((DataTable)dtgvSach.DataSource);
                dtgvSach.DataSource = dv.ToTable();
                dtgvSach.RowHeadersVisible = false;
                dtgvSach.BackgroundColor = Color.White;
                dtgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
    }
}
