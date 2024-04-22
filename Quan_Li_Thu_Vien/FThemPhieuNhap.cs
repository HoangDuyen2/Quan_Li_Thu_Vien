using Microsoft.IdentityModel.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Quan_Li_Thu_Vien
{
    public partial class FThemPhieuNhap : Form
    {
        PhieuNhap phieuNhap1 = new PhieuNhap();
        PhieuNhapController phieuNhapController = new PhieuNhapController();
        public FThemPhieuNhap()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNCC.Text))
            {
                MessageBox.Show("Không để trống các trường.", "Thông báo");
                return;
            }
            float giaTri;
            if (!float.TryParse(txtGiaTriDonHang.Text, out giaTri))

                MessageBox.Show("Giá trị đơn hàng lỗi", "Thông báo");
            DateTime dateTime;
            if (!DateTime.TryParse(txtNgayNhap.Text, out dateTime))
                dateTime = DateTime.MinValue;
            phieuNhap1.NgayNhap = dateTime;
            phieuNhap1.MaPhieuNhap = txtMaPhieuNhap.Text;
            phieuNhap1.GiaTri = giaTri;
            phieuNhap1.TenNCC = txtNCC.Text;
            PhieuNhap phieuNhap = new PhieuNhap(txtMaPhieuNhap.Text, dateTime, giaTri, txtNCC.Text, "", 0, 0);
            if (phieuNhapController.ThemPhieuNhap(phieuNhap))
            {
                MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
                
            }
            else
            {
                MessageBox.Show("Thực thi dữ liệu thất bại", "Thông báo");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FDanhSachPhieuNhap fDanhSachPhieuNhap = new FDanhSachPhieuNhap();
            this.Hide();
            fDanhSachPhieuNhap.ShowDialog();
        }

        private void FThemPhieuNhap_Load(object sender, EventArgs e)
        {
            string ngayNhap;
            DateTime dateTime = DateTime.Now;
            ngayNhap = dateTime.ToShortDateString();
            txtNgayNhap.Text = ngayNhap;
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {

        }
    }
}
