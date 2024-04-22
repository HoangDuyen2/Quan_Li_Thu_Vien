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
                dataGridView1.DataSource = phieuNhapController.DSPhieuNhap();
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.BackgroundColor = Color.White;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                int sl, dongia;
                if (int.TryParse(row.Cells["Sl"].Value.ToString(), out sl))
                    sl = 0;
                if (int.TryParse(row.Cells["DonGia"].Value.ToString(), out dongia))
                    dongia = 0;
                PhieuNhap phieuNhap = new PhieuNhap(row.Cells["MaPhieuNhap"].Value.ToString(), row.Cells["NgayNhap"].Value.ToString(), row.Cells["TenNhaCC"].Value.ToString(),
                    row.Cells["TenSach"].Value.ToString(), dongia, sl, row.Cells["TenNV"].Value.ToString());
                // Thêm logic xử lý khi cell được click sau khi áp dụng bộ lọc
                FChiTietPhieNhap fChiTietPhieNhap = new FChiTietPhieNhap(phieuNhap);
                fChiTietPhieNhap.ShowDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
