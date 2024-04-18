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
    public partial class FNewLoaiSach : Form
    {
        string tenLoaiSach;
        SachController newLoaiSach = new SachController();
        public FNewLoaiSach(string tenLoaiSach) : this()
        {
            this.tenLoaiSach = tenLoaiSach;
        }
        public FNewLoaiSach()
        {
            InitializeComponent();
        }

        private void FNewLoaiSach_Load(object sender, EventArgs e)
        {
            txtMaLS.Enabled = false;
            if (tenLoaiSach != "")
                txtTenLS.Text = tenLoaiSach;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenLS.Text))
            {
                MessageBox.Show("Vui lòng nhập tên ngôn ngữ", "Thông báo");
                return;
            }
            else
            {
                if (newLoaiSach.ThemLoaiSach(txtTenLS.Text))
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
