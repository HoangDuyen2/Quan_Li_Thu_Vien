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

            if (checkTenNCC(txtNCC.Text)){
                LoadPhieuNhap();
                if (phieuNhapController.ThemPhieuNhap(phieuNhap1))
                {
                    MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thực thi dữ liệu thất bại", "Thông báo");
                }
            }
            else return;
        }
        public void LoadPhieuNhap()
        {
            float giaTri = 0;
            DateTime dateTime;
            if (!DateTime.TryParse(txtNgayNhap.Text, out dateTime))
                dateTime = DateTime.MinValue;
            phieuNhap1.NgayNhap = dateTime;
            phieuNhap1.MaPhieuNhap = txtMaPhieuNhap.Text;
            phieuNhap1.GiaTri = giaTri;
            phieuNhap1.TenNCC = txtNCC.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FThemPhieuNhap_Load(object sender, EventArgs e)
        {
            string ngayNhap;
            DateTime dateTime = DateTime.Now;
            ngayNhap = dateTime.ToShortDateString();
            txtNgayNhap.Text = ngayNhap;
        }
        #region Các check khi thêm, sửa
        public bool checkTenNCC(string tenNCC)
        {
            if (phieuNhapController.checkTenNCC(tenNCC) == false)
            {
                DialogResult result1 = MessageBox.Show("Tên nhà cung cấp bạn nhập không có trong danh sách nhà cung cấp. Bạn có muốn thêm nhà cung cấp này vào danh sách?", "Warning", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    FNewNCC newNCC = new FNewNCC(tenNCC);
                    newNCC.ShowDialog();
                }
                else
                {
                    FDanhSachNhaCungCap dsNCC = new FDanhSachNhaCungCap();
                    dsNCC.ShowDialog();
                }
                return false;
            }
            return true;
        }


        #endregion
    }
}
