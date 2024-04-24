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
    public partial class FDanhSachNhanVien : Form
    {
        SachController dsnv = new SachController();
        public string maTo;
        public FDanhSachNhanVien()
        {
            InitializeComponent();
        }
        private void FDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            maTo = LoginInfo.maTo;
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                dtgvNV.DataSource = dsnv.DSNhanVienTrongTo(maTo);
                dtgvNV.RowHeadersVisible = false;
                dtgvNV.BackgroundColor = Color.White;
                dtgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FNewNV fNewNV = new FNewNV();
            this.Hide();
            fNewNV.ShowDialog();
        }

        private void dtgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dtgvNV.Rows[e.RowIndex];

                // Đưa dữ liệu vào các control hoặc xử lý theo nhu cầu
                double luong;
                if (!double.TryParse(row.Cells["Luong"].Value.ToString(), out luong))
                    luong = 0;

                    Person nv = new Person(row.Cells["MaNV"].Value.ToString(), row.Cells["TenNV"].Value.ToString(),
                        row.Cells["GioiTinh"].Value.ToString(), row.Cells["NgaySinh"].Value.ToString(), row.Cells["DiaChi"].Value.ToString(),
                        row.Cells["SDT"].Value.ToString(), luong, row.Cells["Email"].Value.ToString());
                    // Thêm logic xử lý khi cell được click sau khi áp dụng bộ lọc
                
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
               // dtgvNV.DataSource = dsnv.timKiemNV(txtTenNV.Text);
                dtgvNV.RowHeadersVisible = false;
                dtgvNV.BackgroundColor = Color.White;
                dtgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
    }
}
