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
    public partial class FDanhSachCacTacGia : Form
    {
        SachController dsTacGia = new SachController();
        public FDanhSachCacTacGia()
        {
            InitializeComponent();
            if(LoginInfo.Role == "ToTruong")
                btnThem.Hide();
        }
        #region Load data
        public void LoadData()
        {
            try
            {
                dtgvTG.DataSource = dsTacGia.DSTacGia();
                dtgvTG.RowHeadersVisible = false;
                dtgvTG.BackgroundColor = Color.White;
                dtgvTG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
        private void FDanhSachCacTacGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion

        private void dtgvTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dtgvTG.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                TacGia tg = new TacGia(row.Cells["MaTG"].Value.ToString(), row.Cells["TenTG"].Value.ToString(),
                    row.Cells["GioiTinh"].Value.ToString(), int.Parse(row.Cells["NamSinh"].Value.ToString()),
                    int.Parse(row.Cells["NamMat"].Value.ToString()), row.Cells["QueQuan"].Value.ToString(), null);
                // Thêm logic xử lý khi cell được click sau khi áp dụng bộ lọc
                FChiTietTacGia fChiTiet = new FChiTietTacGia(tg);
                this.Hide();
                fChiTiet.ShowDialog();
            }
        }
        #region Các event click button
        private void btnThem_Click(object sender, EventArgs e)
        {
            FNewAuthor fNewAuthor = new FNewAuthor();
            this.Hide();
            fNewAuthor.ShowDialog();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTGNhap.Text))
            {
                MessageBox.Show("Please enter a valid value for 'TenTG'.");
                LoadData();
                return;
            }
            else
            {
                try
                {
                    dtgvTG.DataSource = dsTacGia.timKiemTacGia(txtTenTGNhap.Text);
                    dtgvTG.RowHeadersVisible = false;
                    dtgvTG.BackgroundColor = Color.White;
                    dtgvTG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch
                {
                    MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
                }
            }

        }
    }
}
