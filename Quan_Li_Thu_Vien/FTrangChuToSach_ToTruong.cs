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
    public partial class FTrangChuToSach_ToTruong : Form
    {
        public FTrangChuToSach_ToTruong()
        {
            InitializeComponent();
        }



        private void btnDSTacGia_Click(object sender, EventArgs e)
        {
            FDanhSachCacTacGia dsTG = new FDanhSachCacTacGia();
            dsTG.ShowDialog();
        }

        private void btnDSNXB_Click(object sender, EventArgs e)
        {
            FDanhSachCacNhaXuatBan dsNXB = new FDanhSachCacNhaXuatBan();
            dsNXB.ShowDialog();
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            FThongTinCaNhan fThongTinCaNhan = new FThongTinCaNhan();
            fThongTinCaNhan.ShowDialog();
        }

        private void btnDSNhanVien_Click(object sender, EventArgs e)
        {
            FDanhSachNhanVien fDanhSachNhanVien = new FDanhSachNhanVien();
            fDanhSachNhanVien.ShowDialog();
        }

        private void btnXemDSSach_Click(object sender, EventArgs e)
        {
            FDanhSachCacSach danhSachCacSach = new FDanhSachCacSach();
            danhSachCacSach.ShowDialog();
        }

        private void btnDanhSachSachDangMuon_Click(object sender, EventArgs e)
        {
            FDanhSachCacSachDangMuon dangMuon = new FDanhSachCacSachDangMuon();
            dangMuon.ShowDialog();
        }

        private void btnDanhSachCacSachBiHu_Click(object sender, EventArgs e)
        {
            FDanhSachCacSachBiHu sachBiHu = new FDanhSachCacSachBiHu();
            sachBiHu.ShowDialog();
        }
    }
}
