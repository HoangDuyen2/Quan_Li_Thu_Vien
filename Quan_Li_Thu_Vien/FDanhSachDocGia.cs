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
    public partial class FDanhSachDocGia : Form
    {
        DocGiaController dsdg = new DocGiaController();
        MuonTraSachController dsdgvp = new MuonTraSachController();
        public FDanhSachDocGia()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dtgvDocGia.DataSource = dsdg.DSDocGia();
            dtgvDocGia.RowHeadersVisible = false;
            dtgvDocGia.BackgroundColor = Color.White;
            dtgvDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FDanhSachDocGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvDocGia.DataSource = dsdg.timKiemDocGia(txtTenDocGia.Text);
                dtgvDocGia.RowHeadersVisible = false;
                dtgvDocGia.BackgroundColor = Color.White;
                dtgvDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FThemDocGia fThemDocGia = new FThemDocGia();
            fThemDocGia.ShowDialog();
            FDanhSachDocGia_Load(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = dtgvDocGia.Rows[e.RowIndex];

                // Đưa dữ liệu vào các control hoặc xử lý theo nhu cầu
                Person person = new Person(row.Cells["MaDocGia"].Value.ToString(), row.Cells["TenDocGia"].Value.ToString(),
                    row.Cells["GioiTinh"].Value.ToString(), row.Cells["TenLoaiDG"].Value.ToString(), "", row.Cells["SoDienThoai"].Value.ToString(),
                    0, row.Cells["Email"].Value.ToString());
                // Thêm logic xử lý khi cell được click sau khi áp dụng bộ lọc
                FSuaDocGia fChiTiet = new FSuaDocGia(person);
                fChiTiet.ShowDialog();
                FDanhSachDocGia_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Vi phạm")
            {
                try
                {
                    dtgvDocGia.DataSource = dsdgvp.DSDocGiaViPham();
                    dtgvDocGia.RowHeadersVisible = false;
                    dtgvDocGia.BackgroundColor = Color.White;
                    dtgvDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
                catch
                {
                    MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
                }
            }
        }
    }
}
