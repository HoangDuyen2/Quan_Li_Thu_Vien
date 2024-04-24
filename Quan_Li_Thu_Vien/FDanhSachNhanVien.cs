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

        private void btnSua_Click(object sender, EventArgs e)
        {
            FSuaNhanVien fSuaNhanVien = new FSuaNhanVien();
            this.Close();
            fSuaNhanVien.ShowDialog();
            this.Show();
        }

        private void btnThemTaiKhoanNhanVienMoiTao_Click(object sender, EventArgs e)
        {
            FThemTaiKhoanMoiTao fThemTaiKhoanMoiTao = new FThemTaiKhoanMoiTao();
            fThemTaiKhoanMoiTao.SetMaNV(maNV);
            this.Hide();
            fThemTaiKhoanMoiTao.ShowDialog();
            this.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maNV))
            {
                bool isDeleted = dsnv.xoaThongTinNhanVien(maNV);

                if (isDeleted)
                {
                    MessageBox.Show("Xóa nhân viên thành công", "Thông báo");
                    FDanhSachNhanVien fDanhSachNhanVien = new FDanhSachNhanVien();
                    this.Hide();
                    fDanhSachNhanVien.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Xóa Nhân Viên không thành công", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa", "Thông báo");
            }
        }
    }
}
