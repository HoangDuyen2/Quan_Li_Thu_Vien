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
    public partial class FChiTietPhieuMuonTra : Form
    {
        DBConnection conn = new DBConnection();
        MuonTraSachController dsctpmt = new MuonTraSachController();
        private string maPMT;
        public FChiTietPhieuMuonTra()
        {
            InitializeComponent();
        }
        public void SetMaPMT(string maPMT)
        {
            this.maPMT = maPMT;
        }
        public void LoadData()
        {
            dtgvChiTietPhieuMuonTra.DataSource = dsctpmt.DSChiTietPhieuMuonTra(maPMT);
            dtgvChiTietPhieuMuonTra.RowHeadersVisible = false;
            dtgvChiTietPhieuMuonTra.BackgroundColor = Color.White;
            dtgvChiTietPhieuMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FChiTietPhieuMuonTra_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FDanhSachPhieuMuonTra danhSachPhieuMuonTra = new FDanhSachPhieuMuonTra();
            this.Close();
            danhSachPhieuMuonTra.ShowDialog();
            this.Show();
        }

        private void btnThemMaSach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSach.Text))
            {
                MessageBox.Show("Không để trống các trường.", "Thông báo");
                return;
            }
            if (txtMaSach.Text != "")
            {
                if (dsctpmt.themChiTietPhieuMuonTra(maPMT, txtMaSach.Text))
                {
                    MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
                }
            }
            FChiTietPhieuMuonTra fChiTietPhieuMuonTra = new FChiTietPhieuMuonTra();
            fChiTietPhieuMuonTra.SetMaPMT(maPMT);
            this.Close();
            fChiTietPhieuMuonTra.ShowDialog();
            this.Show();
        }

        private void btnDaTra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSach.Text))
            {
                MessageBox.Show("Không để trống các trường.", "Thông báo");
                return;
            }
            if (txtMaSach.Text != "")
            {
                if (dsctpmt.daTraChiTietPhieuMuonTra(maPMT, txtMaSach.Text))
                {
                    MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
                }
            }
            FChiTietPhieuMuonTra fChiTietPhieuMuonTra = new FChiTietPhieuMuonTra();
            fChiTietPhieuMuonTra.SetMaPMT(maPMT);
            this.Close();
            fChiTietPhieuMuonTra.ShowDialog();
            this.Show();
        }
    }
}
