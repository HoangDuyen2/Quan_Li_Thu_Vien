﻿using System;
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
    public partial class FNhanVien : Form
    {
        DBConnection conn;
        public FNhanVien()
        {
            InitializeComponent();
        }

        private void FNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnThaoTacSach_Click(object sender, EventArgs e)
        {
            FTrangChuToSach_NhanVien fTrangChuToSach_NhanVien = new FTrangChuToSach_NhanVien();
            this.Hide();
            fTrangChuToSach_NhanVien.ShowDialog();
            this.Show();
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoVaTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGioiTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgayTaoNV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
