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
        private void btnThem_Click(object sender, EventArgs e)
        {
            FThemPhieuMuonTra fThemPhieuMuonTra = new FThemPhieuMuonTra();
            this.Hide();
            fThemPhieuMuonTra.ShowDialog();
            this.Show();
        }
        private void dtgvPhieuMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một ô hợp lệ trong cột "MaPhieuMuonTra" hay không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dtgvPhieuMuonTra.Columns[e.ColumnIndex].Name == "MaPhieuMuonTra")
            {
                // Lưu giá trị của ô được chọn trong cột "MaPhieuMuonTra" vào biến maPMT
                maPMT = dtgvPhieuMuonTra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn mã phiếu mượn trả hay chưa
            if (!string.IsNullOrEmpty(maPMT))
            {
                // Gọi stored procedure DeletePhieuMuonTra để xóa phiếu mượn trả
                bool isDeleted = dspmt.XoaPhieuMuonTra(maPMT);

                // Kiểm tra kết quả xóa
                if (isDeleted)
                {
                    // Xóa thành công
                    MessageBox.Show("Xóa phiếu mượn trả thành công", "Thông báo");
                    FDanhSachPhieuMuonTra danhSachPhieuMuonTra = new FDanhSachPhieuMuonTra();
                    this.Hide();
                    this.Close();
                    danhSachPhieuMuonTra.ShowDialog();
                    this.Show();
                }
                else
                {
                    // Xóa không thành công
                    MessageBox.Show("Xóa phiếu mượn trả không thành công", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn trả để xóa", "Thông báo");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
