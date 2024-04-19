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
    public partial class FTrangChuToMuonSach_ToTruong : Form
    {
        public FTrangChuToMuonSach_ToTruong()
        {
            InitializeComponent();
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            FThongTinCaNhan fThongTinCaNhan = new FThongTinCaNhan();
            fThongTinCaNhan.ShowDialog();
        }

        private void btnXemPMT_Click(object sender, EventArgs e)
        {
            FDanhSachPhieuMuonTra fDanhSachPhieuMuonTra = new FDanhSachPhieuMuonTra();
            this.Hide();
            fDanhSachPhieuMuonTra.ShowDialog();
            this.Show();
        }
        private void btnXemDocGia_Click(object sender, EventArgs e)
        {
            FDanhSachDocGia fDanhSachDocGia = new FDanhSachDocGia();
            this.Hide();
            fDanhSachDocGia.ShowDialog();
            this.Show();
        }
        private void btnXemDocGiaVP_Click(object sender, EventArgs e)
        {
            FDanhSachDocGiaViPham fDanhSachDocGiaViPham = new FDanhSachDocGiaViPham();
            this.Hide();
            fDanhSachDocGiaViPham.ShowDialog();
            this.Show();
        }
        private void btnXemPhieuTreHan_Click(object sender, EventArgs e)
        {
            FDanhSachPhieuTreHan fDanhSachPhieuTreHan = new FDanhSachPhieuTreHan();
            this.Hide();
            fDanhSachPhieuTreHan.ShowDialog();
            this.Show();
        }

        private void btnXemPhieuPhat_Click(object sender, EventArgs e)
        {
            FDanhSachPhieuPhat fDanhSachPhieuPhat = new FDanhSachPhieuPhat();
            this.Hide();
            fDanhSachPhieuPhat.ShowDialog();
            this.Show();
        }

        private void btnXemCacSachDaMuon_Click(object sender, EventArgs e)
        {
            FDanhSachCacSachDaMuon fDanhSachCacSachDaMuon = new FDanhSachCacSachDaMuon();
            this.Hide();
            fDanhSachCacSachDaMuon.ShowDialog();
            this.Show();
        }

        private void btnXemNhanVienTrongTo_Click(object sender, EventArgs e)
        {
            FDanhSachNVMuonTra fDanhSachNVMuonTra = new FDanhSachNVMuonTra();
            this.Hide();
            fDanhSachNVMuonTra.ShowDialog();
            this.Show();
        }
    }
}
