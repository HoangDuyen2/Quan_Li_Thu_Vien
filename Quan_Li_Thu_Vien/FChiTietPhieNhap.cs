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
    public partial class FChiTietPhieNhap : Form
    {
        PhieuNhap phieuNhap;
        PhieuNhapController nhapController = new PhieuNhapController();

        public FChiTietPhieNhap(PhieuNhap phieu) : this()
        {
            phieuNhap = phieu;

        }
        public FChiTietPhieNhap()
        {
            InitializeComponent();
        }
        private void FChiTietPhieNhap_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            txtMaPhieuNhap.Text = phieuNhap.MaPhieuNhap;
            txtTenSach.Text = phieuNhap.TenSach;
            txtDonGia.Text = phieuNhap.DonGia.ToString();
            txtNCC.Text = phieuNhap.TenNCC;
            txtNgayNhap.Text = phieuNhap.NgayNhap.ToString();
            txtSoLuongSach.Text = phieuNhap.SoLuong.ToString();
            btnOK.Hide();
        }
        public void LoadPhieuNhap()
        {
            phieuNhap.MaPhieuNhap = txtMaPhieuNhap.Text;
            DateTime dateTime;
            if (!DateTime.TryParse(txtNgayNhap.Text, out dateTime))
                dateTime = DateTime.MinValue;
            phieuNhap.TenSach = txtTenSach.Text;
            phieuNhap.NgayNhap = dateTime;
            int dongia,sl;
            if (!int.TryParse(txtSoLuongSach.Text, out sl))
                MessageBox.Show("Số lượng sách không hợp lệ", "Thông báo");
            if(!int.TryParse(txtDonGia.Text, out dongia))
                MessageBox.Show("Số lượng đơn giá không hợp lệ", "Thông báo");
            phieuNhap.DonGia = dongia;
            phieuNhap.SoLuong = sl;
            phieuNhap.TenNCC = txtNCC.Text;
        }
        #region Truy cập vào textbox
        public void KhongTruyCap()
        {
            txtMaPhieuNhap.Enabled = false;
            txtTenSach.Enabled = false;
            txtDonGia.Enabled = false;
            txtNCC.Enabled = false;
            txtNgayNhap.Enabled = false;
            txtSoLuongSach.Enabled = false;
        }
        public void TruyCap()
        {
            txtTenSach.Enabled = true;
            txtDonGia.Enabled = true;
            txtNCC.Enabled = true;
            txtSoLuongSach.Enabled = true;
        }
        #endregion
        #region Các button
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            btnChinhSua.Hide();
            btnOK.Show();
            TruyCap();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btnOK.Hide();
            btnChinhSua.Show();
            KhongTruyCap();
            if (txtNCC.Text != "")
                checkTenNCC(txtNCC.Text);
            if (txtTenSach.Text != "")
                checkTenSach(txtTenSach.Text);
            LoadPhieuNhap();
            if (nhapController.themChiTietPhieuNhap(phieuNhap))
            {
                MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
            }
            else MessageBox.Show("Thực thi dữ liệu thất bại", "Lỗi");
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            FDanhSachChiTietPhieuNhap danhSachPhieuNhap = new FDanhSachChiTietPhieuNhap();
            this.Hide();
            danhSachPhieuNhap.ShowDialog();
        }

        #endregion

        #region Các check khi thêm, sửa
        public void checkTenNCC(string tenNCC)
        {
            if (nhapController.checkTenNCC(tenNCC) == false)
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
            }
        }
        public void checkTenSach(string tenSach)
        {
            if (nhapController.checkTenSach(tenSach) == false)
            {
                DialogResult result1 = MessageBox.Show("Tên sách bạn nhập không có trong danh sách sách. Bạn có muốn thêm sách này vào danh sách?", "Warning", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                { 
                    FThemSach newSach = new FThemSach(tenSach);
                    newSach.ShowDialog();
                }
            }
        }

        #endregion

        
    }
}
