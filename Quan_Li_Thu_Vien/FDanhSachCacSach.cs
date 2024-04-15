using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quan_Li_Thu_Vien
{
    public partial class FDanhSachCacSach : Form
    {
        SachController dssach = new SachController();
        public FDanhSachCacSach()
        {
            InitializeComponent();
            LoadComboboxLoaiSach();
            LoadComboboxNgonNgu();
        }
        #region LoadComboBox
        public void LoadComboboxLoaiSach()
        {
            comboBoxLoaiSach.DataSource = dssach.DSCacLoaiSach();
            comboBoxLoaiSach.DisplayMember = dssach.DSCacLoaiSach().Columns[0].ToString();
        }
        public void LoadComboboxNgonNgu()
        {
            comboBoxNgonNgu.DataSource = dssach.DSNgonNgu();
            comboBoxNgonNgu.DisplayMember = dssach.DSNgonNgu().Columns[0].ToString();
        }
        #endregion
        public void LoadData()
        {
            try
            {
                dtgvSach.DataSource = dssach.DSSach();
                dtgvSach.RowHeadersVisible = false;
                dtgvSach.BackgroundColor = Color.White;
                dtgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
        private void FDanhSachCacSach_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        #region Chọn dữ liệu dựa trên chọn trên Combobox
        private void comboBoxLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtgvSach.DataSource = dssach.DSSachTheoTheLoaiSach(comboBoxLoaiSach.Text);
                dtgvSach.RowHeadersVisible = false;
                dtgvSach.BackgroundColor = Color.White;
                dtgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }

        private void comboBoxNgonNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtgvSach.DataSource = dssach.DSSachTheoNgonNgu(comboBoxNgonNgu.Text);
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
        #endregion
        #region Button Tìm kiếm, Exit
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvSach.DataSource = dssach.timKiemSach(txtTenSach.Text);
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
        #endregion
        private void dtgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = dtgvSach.Rows[e.RowIndex];

                // Đưa dữ liệu vào các control hoặc xử lý theo nhu cầu
                Sach sach = new Sach(row.Cells["MaSach"].Value.ToString(), row.Cells["TenSach"].Value.ToString(), row.Cells["TenNXB"].Value.ToString(), 
                    row.Cells["TenLoaiSach"].Value.ToString(), row.Cells["TenNgonNgu"].Value.ToString(), row.Cells["NamXB"].Value.ToString(), row.Cells["SoLuongTon"].Value.ToString(),
                    row.Cells["SoLuongSach"].Value.ToString(), row.Cells["TenTG"].Value.ToString());
                // Thêm logic xử lý khi cell được click sau khi áp dụng bộ lọc
                FChiTietSach fChiTiet = new FChiTietSach(sach);
                this.Hide();
                fChiTiet.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FThemSach themSach = new FThemSach();
            this.Hide();
            themSach.ShowDialog();
            
        }
    }
}
