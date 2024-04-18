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
    public partial class FormDangNhap : Form
    {
        DBConnection conn;
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void radbtnNguoiQuanLy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radbtnNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnNhanVien.Checked)
            {

            }
        }
        private void radbtnToTruong_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnToTruong.Checked)
            {

            }
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xac nhan thoat chuong trinh?", "Thong bao", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (radbtnNhanVien.Checked)
            {
                conn = new DBConnection();
                conn.openConnection();
                string tk = txtTenDangNhap.Text;
                string mk = txtMatKhau.Text;
                string cmmd = "SELECT * FROM TaiKhoan WHERE Username=@username AND PasswordUser=@password";
                SqlCommand cmd = new SqlCommand(cmmd, conn.GetSqlConnection());
                cmd.Parameters.AddWithValue("@username", tk);
                cmd.Parameters.AddWithValue("@password", mk);

                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read())
                {
                    MessageBox.Show("Đăng nhập thành công");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }

                conn.closeConnection();

                FNhanVien fNhanVien = new FNhanVien();
                this.Hide();
                fNhanVien.ShowDialog();
                this.Show();
            }
        }
    }
}