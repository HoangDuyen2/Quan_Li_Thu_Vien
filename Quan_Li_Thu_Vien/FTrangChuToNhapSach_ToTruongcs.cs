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
    public partial class FTrangChuToNhapSach_ToTruongcs : Form
    {
        public FTrangChuToNhapSach_ToTruongcs()
        {
            InitializeComponent();
        }

        private void btnDSCacSach_Click(object sender, EventArgs e)
        {
            FDanhSachCacSach fDanhSachCacSach = new FDanhSachCacSach();
            fDanhSachCacSach.ShowDialog();
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            FThongTinCaNhan fThongTinCaNhan = new FThongTinCaNhan();
            fThongTinCaNhan.ShowDialog();
        }

        private void btnXemNhanVienTrongTo_Click(object sender, EventArgs e)
        {
            FDanhSachNhanVien danhSachNhanVien = new FDanhSachNhanVien();
            danhSachNhanVien.ShowDialog();
        }

        private void btnDSPhieuNhap_Click(object sender, EventArgs e)
        {
            FDanhSachPhieuNhap danhSachPhieuNhap = new FDanhSachPhieuNhap();
            danhSachPhieuNhap.ShowDialog();
        }

        private void btnDSNCC_Click(object sender, EventArgs e)
        {
            FDanhSachNhaCungCap danhSachNhaCungCap = new FDanhSachNhaCungCap();
            danhSachNhaCungCap.ShowDialog();
        }

        private void btnDSCTPN_Click(object sender, EventArgs e)
        {
            FDanhSachChiTietPhieuNhap chiTietPhieuNhap = new FDanhSachChiTietPhieuNhap();
            chiTietPhieuNhap.ShowDialog();
        }
    }
}
