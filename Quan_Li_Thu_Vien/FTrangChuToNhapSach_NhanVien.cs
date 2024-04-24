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
    public partial class FTrangChuToNhapSach_NhanVien : Form
    {
        public FTrangChuToNhapSach_NhanVien()
        {
            InitializeComponent();
        }

        private void btnDSPhieuNhap_Click(object sender, EventArgs e)
        {
            FDanhSachPhieuNhap danhSachPhieuNhap = new FDanhSachPhieuNhap();
            danhSachPhieuNhap.ShowDialog();
        }

        private void btnDSCTPN_Click(object sender, EventArgs e)
        {
            FDanhSachChiTietPhieuNhap fDanhSachChiTietPhieuNhap = new FDanhSachChiTietPhieuNhap();
            fDanhSachChiTietPhieuNhap.ShowDialog();
        }

        private void btnDSCacSach_Click(object sender, EventArgs e)
        {
            FDanhSachCacSach fDanhSachCacSach = new FDanhSachCacSach();
            fDanhSachCacSach.ShowDialog();
        }

        private void btnDSNCC_Click(object sender, EventArgs e)
        {
            FDanhSachNhaCungCap fDanhSachNhaCungCap = new FDanhSachNhaCungCap();
            fDanhSachNhaCungCap.ShowDialog();
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            FThongTinCaNhan fThongTinCaNhan = new FThongTinCaNhan();
            fThongTinCaNhan.ShowDialog();
        }
    }
}
