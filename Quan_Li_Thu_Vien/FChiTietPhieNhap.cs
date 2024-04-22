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
        string tenSachCu = "";
        public FChiTietPhieNhap(PhieuNhap phieu) : this()
        {
            phieuNhap = phieu;
            tenSachCu = phieu.TenSach;
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
            txtMaNV.Text = phieuNhap.MaNV;
            txtNCC.Text = phieuNhap.TenNCC;
            txtNgayNhap.Text = phieuNhap.NgayNhap;
            txtSoLuongSach.Text = phieuNhap.SoLuong.ToString();
            btnOK.Hide();
        }
        #region Truy cập vào textbox
        public void KhongTruyCap()
        {
            txtMaPhieuNhap.Enabled = false;
            txtTenSach.Enabled = false;
            txtDonGia.Enabled = false;
            txtMaNV.Enabled = false;
            txtNCC.Enabled = false;
            txtNgayNhap.Enabled = false;
            txtMaNV.Enabled = false;
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
            int sl, dongia;
            if (int.TryParse(txtSoLuongSach.Text, out sl))
                MessageBox.Show("Vui lòng nhập số sách >0");
            if (int.TryParse(txtDonGia.Text, out dongia))
                MessageBox.Show("Vui lòng nhập đơn giá >= 0");
            PhieuNhap phieu = new PhieuNhap(txtMaPhieuNhap.Text, txtNgayNhap.Text, txtNCC.Text, txtTenSach.Text, dongia, sl, txtMaNV.Text);
            if (nhapController.suaChiTietPhieuNhap(phieu, tenSachCu))
            {
                MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
            }
            else MessageBox.Show("Thực thi dữ liệu thất bại", "Lỗi");
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            FDanhSachPhieuNhap danhSachPhieuNhap = new FDanhSachPhieuNhap();
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
