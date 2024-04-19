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
    public partial class FDanhSachCacSachBiHu : Form
    {
        SachController dsSachBiHu = new SachController();
        public FDanhSachCacSachBiHu()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                dtgvSachBiHu.DataSource = dsSachBiHu.DSSachHu();
                dtgvSachBiHu.RowHeadersVisible = false;
                dtgvSachBiHu.BackgroundColor = Color.White;
                dtgvSachBiHu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }

        private void dtgvSachBiHu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dtgvSachBiHu.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                Sach sach = new Sach(row.Cells["MaSach"].Value.ToString(), row.Cells["TenSach"].Value.ToString(), row.Cells["TenNXB"].Value.ToString(),
                    row.Cells["TenLoaiSach"].Value.ToString(), row.Cells["TenNgonNgu"].Value.ToString(), row.Cells["NamXB"].Value.ToString(), null,
                    null, row.Cells["TenTG"].Value.ToString());
                // Thêm logic xử lý khi cell được click sau khi áp dụng bộ lọc
                FChiTietSachMuon fChiTiet = new FChiTietSachMuon(sach, row.Cells["TenDocGia"].Value.ToString(), row.Cells["TinhTrang"].Value.ToString());
                fChiTiet.ShowDialog();
            }
        }

        private void FDanhSachCacSachBiHu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
