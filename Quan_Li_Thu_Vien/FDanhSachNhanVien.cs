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
        DBConnection conn = new DBConnection();
        MuonTraSachController dsnv = new MuonTraSachController();
        public string maNV;

        public FDanhSachNhanVien()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dtgvNV.DataSource = dsnv.DSNhanVien();
            dtgvNV.RowHeadersVisible = false;
            dtgvNV.BackgroundColor = Color.White;
            dtgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dtgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dtgvNV.Columns[e.ColumnIndex].Name == "MaNV")
            {
                maNV = dtgvNV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvNV.DataSource = dsnv.timKiemNV(txtTenNV.Text);
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
            this.Show();
            this.Close();
        }
    }
}
