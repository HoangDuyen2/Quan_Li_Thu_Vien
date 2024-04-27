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
    public partial class FChiTietNCC : Form
    {
        NCC ncc = new NCC();
        PhieuNhapController phieu = new PhieuNhapController();
        public FChiTietNCC(NCC nCC) : this()
        {
            ncc = nCC;
        }
        public FChiTietNCC()
        {
            InitializeComponent();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            btnChinhSua.Hide();
            btnOK.Show();
            TruyCap();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btnChinhSua.Show();
            btnOK.Hide();
            KhongTruyCap();
            if (string.IsNullOrEmpty(txtTenNCC.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và chính xác các thông tin.", "Thông báo");
            }
            else
            {
                ncc.MaNCC = txtMaNCC.Text;
                ncc.TenNCC = txtTenNCC.Text;
                ncc.DiaChi = txtDiaChi.Text;
                ncc.SDT = txtSDT.Text;
                if (phieu.suaNhaCungCap(ncc))
                {
                    MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
                }
                else MessageBox.Show("Thực thi dữ liệu thất bại", "Lỗi");
            }
        }
        public void LoadData()
        {
            txtMaNCC.Text = ncc.MaNCC;
            txtTenNCC.Text = ncc.TenNCC;
            txtDiaChi.Text = ncc.DiaChi;
            txtSDT.Text = ncc.SDT;
            btnOK.Hide();
        }
        #region Truy cập vào textbox
        public void KhongTruyCap()
        {
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;

        }
        public void TruyCap()
        {
            txtTenNCC.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
        }
        #endregion

        private void FChiTietNCC_Load(object sender, EventArgs e)
        {
            LoadData();
            KhongTruyCap();
        }
    }
}
