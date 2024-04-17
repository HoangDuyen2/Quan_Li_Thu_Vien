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
    public partial class FDanhSachCacNhaXuatBan : Form
    {
        SachController dsnxb = new SachController();
        public FDanhSachCacNhaXuatBan()
        {
            InitializeComponent();
        }
        private void FDanhSachCacNhaXuatBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                dtgvSach.DataSource = dsnxb.DSNhaXuatBan();
                dtgvSach.RowHeadersVisible = false;
                dtgvSach.BackgroundColor = Color.White;
                dtgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dtgvSach.Rows[e.RowIndex];

                // Đưa dữ liệu vào các control hoặc xử lý theo nhu cầu
                NXB nxb = new NXB(row.Cells["MaNXB"].Value.ToString(), row.Cells["TenNXB"].Value.ToString(),
                    row.Cells["DiaChi"].Value.ToString(), row.Cells["SDT"].Value.ToString());
                // Thêm logic xử lý khi cell được click sau khi áp dụng bộ lọc
                FChiTietNXB fChiTiet = new FChiTietNXB(nxb);
                this.Hide();
                fChiTiet.ShowDialog();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvSach.DataSource = dsnxb.timKiemNXB(txtTenNXB.Text);
                dtgvSach.RowHeadersVisible = false;
                dtgvSach.BackgroundColor = Color.White;
                dtgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FNewNXB fNewNXB = new FNewNXB();
            this.Hide();
            fNewNXB.ShowDialog();
        }
    }
}
