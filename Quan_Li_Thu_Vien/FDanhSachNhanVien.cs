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
    public partial class FDanhSachNhanVien : Form
    {
        MuonTraSachController dsnv = new MuonTraSachController();
        SachController sach = new SachController();
        public string maNV;

        public FDanhSachNhanVien()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dtgvNV.DataSource = sach.DSNhanVienTrongTo(LoginInfo.maTo);
            dtgvNV.RowHeadersVisible = false;
            dtgvNV.BackgroundColor = Color.White;
            dtgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvNV.DataSource = dsnv.timKiemNV(txtTenNV.Text,LoginInfo.maTo);
                dtgvNV.RowHeadersVisible = false;
                dtgvNV.BackgroundColor = Color.White;
                dtgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            FNewNV fNewNV = new FNewNV();
            fNewNV.ShowDialog();
            FDanhSachNhanVien_Load(sender, e);
        }


        private void dtgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = dtgvNV.Rows[e.RowIndex];

                // Đưa dữ liệu vào các control hoặc xử lý theo nhu cầu
                int luong;
                if (!int.TryParse(row.Cells["Luong"].Value.ToString(), out luong))
                    MessageBox.Show("Lương nhập không hợp lệ, vui lòng nhập lại", "Thông báo");
                Person person = new Person(row.Cells["MaNV"].Value.ToString(), row.Cells["TenNV"].Value.ToString(), row.Cells["GioiTinh"].Value.ToString(),
                    row.Cells["NgaySinh"].Value.ToString(), row.Cells["DiaChi"].Value.ToString(), row.Cells["SDT"].Value.ToString(), luong,
                    row.Cells["Email"].Value.ToString());
                // Thêm logic xử lý khi cell được click sau khi áp dụng bộ lọc
                FSuaNhanVien fChiTiet = new FSuaNhanVien(person,LoginInfo.maTo);
                fChiTiet.ShowDialog();
                FDanhSachNhanVien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
    }
}
