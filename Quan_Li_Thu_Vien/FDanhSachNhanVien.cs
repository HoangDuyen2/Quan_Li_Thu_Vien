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
    public partial class FDanhSachNhanVien : Form
    {
        SachController dsNhanVien = new SachController();
        public FDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadData()
        {
            try
            {
                dtgvNhanVien.DataSource = dsNhanVien.DSNhanVienTrongTo();
                dtgvNhanVien.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }

        private void FDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dtgvNhanVien.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtTenNV.Text = row.Cells["TenNV"].Value.ToString();
                if (row.Cells["GioiTinh"].Value.ToString() == "M")
                    txtGioiTinh.Text = "Nữ";
                else txtGioiTinh.Text = "Nam";
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtTenTo.Text = row.Cells["TenTo"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                dtNgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
            }
        }
    }
}
