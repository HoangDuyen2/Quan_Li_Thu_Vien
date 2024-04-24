using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Quan_Li_Thu_Vien
{
    public partial class FDanhSachPhieuPhat : Form
    {
        DBConnection conn = new DBConnection();
        MuonTraSachController dspp = new MuonTraSachController();
        private string maPhieuPhat;
        public FDanhSachPhieuPhat()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dtgvPhieuPhat.DataSource = dspp.DSPhieuPhat();
            dtgvPhieuPhat.RowHeadersVisible = false;
            dtgvPhieuPhat.BackgroundColor = Color.White;
            dtgvPhieuPhat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FDanhSachPhieuPhat_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FThemPhieuPhat fThemPhieuPhat = new FThemPhieuPhat();
            this.Close();
            fThemPhieuPhat.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvPhieuPhat.DataSource = dspp.timKiemPhieuPhat(txtMaSach.Text);
                dtgvPhieuPhat.RowHeadersVisible = false;
                dtgvPhieuPhat.BackgroundColor = Color.White;
                dtgvPhieuPhat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }

        private void dtgvPhieuPhat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dtgvPhieuPhat.Columns[e.ColumnIndex].Name == "MaPhieuPhat")
            {
                maPhieuPhat = dtgvPhieuPhat.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maPhieuPhat))
            {
                bool isDeleted = dspp.XoaPhieuPhat(maPhieuPhat);

                if (isDeleted)
                {
                    MessageBox.Show("Xóa phiếu phạt thành công", "Thông báo");
                    FDanhSachPhieuPhat danhSachPhieuPhat = new FDanhSachPhieuPhat();
                    this.Close();
                    danhSachPhieuPhat.ShowDialog();
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

        private void btnChiTietMuonTra_Click(object sender, EventArgs e)
        {
            FChiTietPhieuPhat fChiTietPhieuPhat = new FChiTietPhieuPhat();
            this.Close();
            fChiTietPhieuPhat.ShowDialog();
            this.Show();
        }
    }
}
