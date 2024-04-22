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
    public partial class FSuaPhieuMuonTra : Form
    {
        DBConnection conn = new DBConnection();
        MuonTraSachController muonTraSachController = new MuonTraSachController();
        public FSuaPhieuMuonTra()
        {
            InitializeComponent();
        }
        private void FSuaPhieuMuonTra_Load(object sender, EventArgs e)
        {

        }         
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPMT.Text) || string.IsNullOrEmpty(txtMaDocGia.Text) || string.IsNullOrEmpty(txtHanTra.Text))
            {
                MessageBox.Show("Không để trống các trường.", "Thông báo");
                return;
            }
            if (txtMaPMT.Text != "" && txtMaDocGia.Text != "" && txtHanTra.Text != "")
            {
                PhieuMuonTra phieuMuonTra = new PhieuMuonTra(txtMaPMT.Text, txtMaNV.Text, txtMaDocGia.Text, txtNgayMuon.Text, txtHanTra.Text);
                if (muonTraSachController.suaPhieuMuonTra(phieuMuonTra))
                {
                    MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
                }
                else MessageBox.Show("Thực thi dữ liệu thất bại", "Lỗi");
            }
            FDanhSachPhieuMuonTra fDanhSachPhieuMuonTra = new FDanhSachPhieuMuonTra();
            this.Hide();
            fDanhSachPhieuMuonTra.ShowDialog();
            this.Show();
        }
    }
}
