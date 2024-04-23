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
    public partial class FPhieuNhap : Form
    {
        PhieuNhap phieuNhap;
        PhieuNhapController nhapController = new PhieuNhapController();
        int SLCu;

        public FPhieuNhap(PhieuNhap pn) : this()
        {
            phieuNhap = pn;
            SLCu = pn.SoLuong;
        }
        public FPhieuNhap()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            txtMaPhieuNhap.Text = phieuNhap.MaPhieuNhap;
            txtNCC.Text = phieuNhap.TenNCC;
            txtNgayNhap.Text = phieuNhap.NgayNhap.ToString();
            txtGiaTriDonHang.Text = phieuNhap.GiaTri.ToString();
            btnOK.Hide();
        }
        private void FPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadData();
        }
 

        public void LoadPhieuNhap()
        {
            phieuNhap.MaPhieuNhap = txtMaPhieuNhap.Text;
            DateTime dateTime;
            if (!DateTime.TryParse(txtNgayNhap.Text, out dateTime))
                dateTime = DateTime.MinValue;
            phieuNhap.NgayNhap = dateTime;
            int giatri;
            if (!int.TryParse(txtGiaTriDonHang.Text, out giatri))
                MessageBox.Show("Số lượng đơn giá không hợp lệ", "Thông báo");
            phieuNhap.GiaTri = giatri;
            phieuNhap.TenNCC = txtNCC.Text;
        }
        #region Truy cập vào textbox
        public void KhongTruyCap()
        {
            txtMaPhieuNhap.Enabled = false;
            txtNCC.Enabled = false;
            txtNgayNhap.Enabled = false;
            txtGiaTriDonHang.Enabled = false;
        }
        public void TruyCap()
        {
            txtNCC.Enabled = true;
            txtGiaTriDonHang.Enabled = true;
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
            LoadPhieuNhap();
            if (nhapController.suaPhieuNhap(phieuNhap))
            {
                MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
            }
            else MessageBox.Show("Thực thi dữ liệu thất bại", "Lỗi");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FDanhSachPhieuNhap phieuNhap = new FDanhSachPhieuNhap();
            this.Hide();
            phieuNhap.ShowDialog();
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
        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            LoadPhieuNhap();
            FChiTietPhieNhap fChiTietPhieNhap = new FChiTietPhieNhap(phieuNhap);
            fChiTietPhieNhap.ShowDialog();
        }

        #endregion


    }
}
