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
    public partial class FTrangChuToNhapSach_ToTruong : Form
    {
        public FTrangChuToNhapSach_ToTruong()
        {
            InitializeComponent();
        }

        private void btn_DanhSachPhieuNhap_Click(object sender, EventArgs e)
        {
            FDanhSachPhieuNhap danhSachPhieuNhap = new FDanhSachPhieuNhap();
            danhSachPhieuNhap.ShowDialog();
        }

        private void btn_ThongTinCaNhan_Click(object sender, EventArgs e)
        {
            FThongTinCaNhan thongTinCaNhan = new FThongTinCaNhan();
            thongTinCaNhan.ShowDialog();
        }
    }
}
