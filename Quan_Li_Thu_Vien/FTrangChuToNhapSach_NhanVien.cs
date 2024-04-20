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

        private void btn_nhap_sach_Click(object sender, EventArgs e)
        {
            FThemPhieuNhap themPhieuNhap = new FThemPhieuNhap();
            themPhieuNhap.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FDanhSachPhieuNhap danhSachPhieuNhap = new FDanhSachPhieuNhap();
            danhSachPhieuNhap.ShowDialog();
        }

        private void btn_thong_tin_ca_nhan_Click(object sender, EventArgs e)
        {
            FThongTinCaNhan thongTinCaNhan = new FThongTinCaNhan();
            thongTinCaNhan.ShowDialog();
        }
    }
}
