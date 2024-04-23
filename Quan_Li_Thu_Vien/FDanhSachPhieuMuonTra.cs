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
    public partial class FDanhSachPhieuMuonTra : Form
    {
        DBConnection conn = new DBConnection();
        MuonTraSachController dspmt = new MuonTraSachController();
        private string maPMT;

        public FDanhSachPhieuMuonTra()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dtgvPhieuMuonTra.DataSource = dspmt.DSPhieuMuonTra();
            dtgvPhieuMuonTra.RowHeadersVisible = false;
            dtgvPhieuMuonTra.BackgroundColor = Color.White;
            dtgvPhieuMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FDanhSachPhieuMuonTra_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dtgvPhieuMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dtgvPhieuMuonTra.Columns[e.ColumnIndex].Name == "MaPhieuMuonTra")
            {
                maPMT = dtgvPhieuMuonTra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvPhieuMuonTra.DataSource = dspmt.timKiemPhieuMuonTra(txtTenDocGia.Text);
                dtgvPhieuMuonTra.RowHeadersVisible = false;
                dtgvPhieuMuonTra.BackgroundColor = Color.White;
                dtgvPhieuMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FThemPhieuMuonTra fThemPhieuMuonTra = new FThemPhieuMuonTra();
            this.Close();
            fThemPhieuMuonTra.ShowDialog();
            this.Show();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maPMT))
            {
                bool isDeleted = dspmt.XoaPhieuMuonTra(maPMT);

                if (isDeleted)
                {
                    MessageBox.Show("Xóa phiếu mượn trả thành công", "Thông báo");
                    FDanhSachPhieuMuonTra danhSachPhieuMuonTra = new FDanhSachPhieuMuonTra();
                    this.Close();
                    danhSachPhieuMuonTra.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Xóa phiếu mượn trả không thành công", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn trả để xóa", "Thông báo");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            FSuaPhieuMuonTra fSuaPhieuMuonTra = new FSuaPhieuMuonTra();
            this.Close();
            fSuaPhieuMuonTra.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChiTietPhieuMuonTra_Click(object sender, EventArgs e)
        {
            FChiTietPhieuMuonTra fChiTietPhieuMuonTra = new FChiTietPhieuMuonTra();
            fChiTietPhieuMuonTra.SetMaPMT(maPMT);
            this.Close();
            fChiTietPhieuMuonTra.ShowDialog();
            this.Show();
        }
    }
}
