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
        MuonTraSachController dsctpmt = new MuonTraSachController();
        string maPhieu;
        public FChiTietPhieuMuonTra(string pmt):this()
        {
            maPhieu = pmt;
        }
        public FChiTietPhieuMuonTra()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dtgvChiTietPhieuMuonTra.DataSource = dsctpmt.DSChiTietPhieuMuonTra(maPhieu);
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
            this.Close();
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
                if (dsctpmt.themChiTietPhieuMuonTra(maPhieu, txtMaSach.Text))
                {
                    MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
                }
            }
            FChiTietPhieuMuonTra_Load(sender,e);
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
                if (dsctpmt.daTraChiTietPhieuMuonTra(maPhieu, txtMaSach.Text))
                {
                    MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
                }
            }
            FChiTietPhieuMuonTra_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSach.Text))
            {
                MessageBox.Show("Không để trống các trường.", "Thông báo");
                return;
            }
            if (txtMaSach.Text != "")
            {
                if (dsctpmt.xoaChiTietPhieuMuonTra(maPhieu, txtMaSach.Text))
                {
                    MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
                }
            }
            FChiTietPhieuMuonTra_Load(sender, e);
        }
    }
}
