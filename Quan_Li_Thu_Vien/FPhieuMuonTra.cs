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
    public partial class FPhieuMuonTra : Form
    {
        PhieuMuonTra phieuMuonTra = new PhieuMuonTra();
        MuonTraSachController muonTraSach = new MuonTraSachController();
        public FPhieuMuonTra(PhieuMuonTra pmt):this()
        {
            phieuMuonTra = pmt;
        }
        public FPhieuMuonTra()
        {
            InitializeComponent();
            
        }

        private void FPhieuMuonTra_Load(object sender, EventArgs e)
        {
            LoadData();
            KhongTruyCap();
        }
        public void LoadData()
        {
            txtMaPMT.Text = phieuMuonTra.MaPhieuMuonTra;
            txtTenDocGia.Text = phieuMuonTra.TenDocGia;
            txtTenNV.Text = phieuMuonTra.TenNV;

            DateTime date1, date2;
            if (DateTime.TryParse(phieuMuonTra.NgayMuon, out date1))
            {
                dtNgayMuon.Value = date1;
            }
            if (DateTime.TryParse(phieuMuonTra.HanTra, out date2))
            {
                dtNgayTra.Value = date2;
            }

            btnOK.Hide();
        }
        #region Các button
        private void btnOK_Click(object sender, EventArgs e)
        {
            btnChinhSua.Show();
            btnOK.Hide();
            KhongTruyCap();
            if (string.IsNullOrEmpty(txtTenDocGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và chính xác các thông tin.", "Thông báo");
                return;
            }
            if (muonTraSach.checkTenDocGia(txtTenDocGia.Text))
            {
                PhieuMuonTra pmt = new PhieuMuonTra(txtMaPMT.Text, txtTenNV.Text, txtTenDocGia.Text,
                    dtNgayMuon.Value.ToShortDateString(), dtNgayTra.Value.ToShortDateString());
                if (muonTraSach.suaPhieuMuonTra(pmt))
                {
                    MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
                }
                else MessageBox.Show("Thực thi dữ liệu thất bại", "Lỗi");
            }
            else
            {
                MessageBox.Show("Tên độc giả không tồn tại", "Thông báo");
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            btnChinhSua.Hide();
            btnOK.Show();
            TruyCap();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (muonTraSach.XoaPhieuMuonTra(txtMaPMT.Text))
            {
                MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
                btnChinhSua.Hide() ;
                btnOK.Hide();
                btnChiTietPhieuMuonTra.Hide();
            }
            else MessageBox.Show("Thực thi dữ liệu thất bại", "Lỗi");
        }
        #endregion

        #region Truy cập vào textbox
        public void KhongTruyCap()
        {
            txtMaPMT.Enabled = false;
            txtTenNV.Enabled = false;
            txtTenDocGia.Enabled = false;
            dtNgayMuon.Enabled = false;
            dtNgayTra.Enabled = false;

        }
        public void TruyCap()
        {
            txtTenDocGia.Enabled = true;
        }
        #endregion

        private void btnChiTietPhieuMuonTra_Click(object sender, EventArgs e)
        {
            FChiTietPhieuMuonTra fChiTietPhieuMuonTra = new FChiTietPhieuMuonTra(txtMaPMT.Text);
            fChiTietPhieuMuonTra.ShowDialog();
        }
    }
}
