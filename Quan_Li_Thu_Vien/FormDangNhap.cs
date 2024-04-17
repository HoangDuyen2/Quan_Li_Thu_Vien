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
    public partial class FormDangNhap : Form
    {
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
                FTrangChuToSach_NhanVien fTrangChuToSach_NhanVien = new FTrangChuToSach_NhanVien();
                this.Hide();
                fTrangChuToSach_NhanVien.ShowDialog();
                this.Show();
            }
            else if (radbtnToTruong.Checked)
            {
                FTrangChuToSach_ToTruong fTrangChuToSach_ToTruong = new FTrangChuToSach_ToTruong();
                this.Hide();
                fTrangChuToSach_ToTruong.ShowDialog();
                this.Show();
            }
        }
    }
}
