﻿using System;
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
    public partial class FTrangChuToSach_NhanVien : Form
    {
        public FTrangChuToSach_NhanVien()
        {
            InitializeComponent();
        }

        private void btnXemDSSach_Click(object sender, EventArgs e)
        {
            FDanhSachCacSach danhSachCacSach = new FDanhSachCacSach();
            danhSachCacSach.ShowDialog();
        }

        private void btnDanhSachCacSachBiHu_Click(object sender, EventArgs e)
        {
            FDanhSachCacSachBiHu danhSachCacSachBiHu = new FDanhSachCacSachBiHu();
            danhSachCacSachBiHu.ShowDialog();
        }

        private void btnDanhSachSachDangMuon_Click(object sender, EventArgs e)
        {
            FDanhSachCacSachDangMuon danhSacCacSachDangMuon = new FDanhSachCacSachDangMuon();
            danhSacCacSachDangMuon.ShowDialog();
        }

        private void btnDSTacGia_Click(object sender, EventArgs e)
        {
            FDanhSachCacTacGia danhSachCacTacGia = new FDanhSachCacTacGia();
            danhSachCacTacGia.ShowDialog();
        }

        private void btnDSNXB_Click(object sender, EventArgs e)
        {
            FDanhSachCacNhaXuatBan danhSachCacNhaXuatBan = new FDanhSachCacNhaXuatBan();
            danhSachCacNhaXuatBan.ShowDialog();
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            FThongTinCaNhan fThongTinCaNhan = new FThongTinCaNhan();
            fThongTinCaNhan.ShowDialog();
        }
    }
}
