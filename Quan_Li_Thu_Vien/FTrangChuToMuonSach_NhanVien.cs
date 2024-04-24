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
    public partial class FTrangChuToMuonSach_NhanVien : Form
    {
        public FTrangChuToMuonSach_NhanVien()
        {
            InitializeComponent();
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            FThongTinCaNhan fThongTinCaNhan = new FThongTinCaNhan();
            fThongTinCaNhan.ShowDialog();
        }

        private void btnDSPhieuMuonTra_Click(object sender, EventArgs e)
        {
            FDanhSachPhieuMuonTra fDanhSachPhieuMuonTra = new FDanhSachPhieuMuonTra();
            fDanhSachPhieuMuonTra.ShowDialog();
        }

        private void btnDSDocGia_Click(object sender, EventArgs e)
        {
            FDanhSachDocGia fDanhSachDocGia = new FDanhSachDocGia();
            fDanhSachDocGia.ShowDialog();
        }

        private void btnDSPhieuPhat_Click(object sender, EventArgs e)
        {
            FDanhSachPhieuPhat fDanhSachPhieuPhat = new FDanhSachPhieuPhat();
            fDanhSachPhieuPhat.ShowDialog();
        }

        private void btnDanhSachSachDangMuon_Click(object sender, EventArgs e)
        {
            FDanhSachCacSachDangMuon fDanhSachCacSachDangMuon = new FDanhSachCacSachDangMuon();
            fDanhSachCacSachDangMuon.ShowDialog();
        }
    }
}
