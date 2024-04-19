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
    public partial class FNewNXB : Form
    {
        string tenNXB;
        SachController newNXB = new SachController();
        public FNewNXB(string tenNXB) : this()
        {
            this.tenNXB = tenNXB;
        }
        public FNewNXB()
        {
            InitializeComponent();
        }

        private void FNewNXB_Load(object sender, EventArgs e)
        {
            txtMaNXB.Enabled = false;
            if (tenNXB != "")
                txtTenNXB.Text = tenNXB;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNXB.Text)||string.IsNullOrEmpty(txtDiaChi.Text)||string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin", "Thông báo");
                return;
            }
            else
            {
                NXB nXB = new NXB("",txtTenNXB.Text,txtDiaChi.Text,txtSDT.Text);
                if (newNXB.themNXB(nXB))
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
    }
}
