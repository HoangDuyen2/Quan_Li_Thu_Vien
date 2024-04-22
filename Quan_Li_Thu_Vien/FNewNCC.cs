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
    public partial class FNewNCC : Form
    {
        string tenNCC;
        PhieuNhapController nhapController = new PhieuNhapController();
        public FNewNCC(string tenNhaCC) : this()
        {
            tenNCC = tenNhaCC;
        }
        public FNewNCC()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNCC.Text)||string.IsNullOrEmpty(txtDiaChi.Text)||string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các dữ kiện", "Thông báo");
                return;
            }
            else
            {
                if (nhapController.ThemNhaCungCap(txtTenNCC.Text,txtDiaChi.Text,txtSDT.Text))
                {
                    MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
                }
                else MessageBox.Show("Thực thi dữ liệu thất bại", "Thông báo");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FNewNCC_Load(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = false;
            if (tenNCC != "")
                txtTenNCC.Text = tenNCC;
        }
    }
}
