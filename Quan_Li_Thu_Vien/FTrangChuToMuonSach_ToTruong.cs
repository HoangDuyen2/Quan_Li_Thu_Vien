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
            fDanhSachPhieuMuonTra.ShowDialog();
        }
        private void btnXemDocGia_Click(object sender, EventArgs e)
        {
            FDanhSachDocGia fDanhSachDocGia = new FDanhSachDocGia();
            fDanhSachDocGia.ShowDialog();
        }

        private void btnXemPhieuPhat_Click(object sender, EventArgs e)
        {
            FDanhSachPhieuPhat fDanhSachPhieuPhat = new FDanhSachPhieuPhat();
            fDanhSachPhieuPhat.ShowDialog();
        }

        private void btnXemCacSachDaMuon_Click(object sender, EventArgs e)
        {
            FDanhSachCacSachDangMuon danhSachCacSachDangMuon = new FDanhSachCacSachDangMuon();
            danhSachCacSachDangMuon.ShowDialog();
        }

        private void btnXemNhanVienTrongTo_Click(object sender, EventArgs e)
        {
            FDanhSachNhanVien danhSachNhanVien = new FDanhSachNhanVien();
            danhSachNhanVien.ShowDialog();
        }
    }
}
