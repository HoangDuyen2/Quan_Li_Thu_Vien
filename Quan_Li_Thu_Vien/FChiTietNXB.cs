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
    public partial class FChiTietNXB : Form
    {
        NXB nXB = new NXB();
        SachController nxbSach = new SachController();
        public FChiTietNXB(NXB nxb) : this()
        {
            this.nXB = nxb;
        }
        public FChiTietNXB()
        {
            InitializeComponent();
        }
        private void FChiTietNXB_Load(object sender, EventArgs e)
        {
            LoadData();
            KhongTruyCap();
        }
        public void LoadData()
        {
            txtMaNXB.Text = nXB.MaNXB;
            txtNXB.Text = nXB.TenNXB;
            txtDiaChi.Text = nXB.DiaChi1;
            txtSDT.Text = nXB.SDT1;
            btnOK.Hide();
        }
        #region Truy cập vào textbox
        public void KhongTruyCap()
        {
            txtMaNXB.Enabled = false;
            txtNXB.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;

        }
        public void TruyCap()
        {
            txtNXB.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
        }
        #endregion
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            btnChinhSua.Hide();
            btnOK.Show();
            TruyCap();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btnChinhSua.Show();
            btnOK.Hide();
            KhongTruyCap();
            if (string.IsNullOrEmpty(txtNXB.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và chính xác các thông tin.","Thông báo");
            }
            else
            {
                NXB NXB = new NXB(txtMaNXB.Text,txtNXB.Text,txtDiaChi.Text,txtSDT.Text);
                if (nxbSach.suaNXB(NXB))
                {
                    MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
                }
                else MessageBox.Show("Thực thi dữ liệu thất bại", "Lỗi");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FDanhSachCacNhaXuatBan dsNXB = new FDanhSachCacNhaXuatBan();
            this.Hide();
            dsNXB.ShowDialog();
        }


    }
}
