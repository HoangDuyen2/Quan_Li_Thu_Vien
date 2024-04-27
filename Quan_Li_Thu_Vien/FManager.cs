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
using System.Runtime.Versioning;

namespace Quan_Li_Thu_Vien
{
    public partial class FManager : Form
    {
        ManagerController manager = new ManagerController();
        public FManager()
        {
            InitializeComponent();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan(txt_UserName.Text, txt_Password.Text, txt_EmpID.Text);
            if (manager.xoaTaiKhoan(tk))
            {
                MessageBox.Show("Thực thi thêm thành công", "Thông báo");
                FManager_Load(sender, e);
            }
            else MessageBox.Show("Thực thi thêm thất bại", "Thông báo");
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan(txt_UserName.Text, txt_Password.Text, txt_EmpID.Text);
            if (manager.suaTaiKhoan(tk))
            {
                MessageBox.Show("Thực thi thêm thành công", "Thông báo");
                FManager_Load(sender, e);
            }
            else MessageBox.Show("Thực thi thêm thất bại", "Thông báo");
        }

        private void FManager_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = manager.danhSachTaiKhoan();
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.BackgroundColor = Color.White;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
            try
            {
                dataGridView2.DataSource = manager.danhSachChuaCoTaiKhoan();
                dataGridView2.RowHeadersVisible = false;
                dataGridView2.BackgroundColor = Color.White;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Đưa dữ liệu vào các control hoặc xử lý theo nhu cầu
                txt_UserName.Text = row.Cells["Username"].Value.ToString();
                txt_Password.Text = row.Cells["PasswordUser"].Value.ToString();
                txt_EmpID.Text = row.Cells["MaNV"].Value.ToString();
                // Thêm logic xử lý khi cell được click sau khi áp dụng bộ lọc
                FManager_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                // Đưa dữ liệu vào các control hoặc xử lý theo nhu cầu
                txt_EmpID.Text = row.Cells["MaNV"].Value.ToString();
                // Thêm logic xử lý khi cell được click sau khi áp dụng bộ lọc
                FManager_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan("", "", txt_EmpID.Text);
            if (manager.themTaiKhoan(tk))
            {
                MessageBox.Show("Thực thi thêm thành công", "Thông báo");
                FManager_Load(sender, e);
            }
            else MessageBox.Show("Thực thi thêm thất bại", "Thông báo");
        }
    }
}
