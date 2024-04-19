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
    public partial class FNewLanguage : Form
    {
        string tenNgonNgu;
        SachController newLanguage = new SachController();
        public FNewLanguage(string tenNgonNgu) : this()
        {
            this.tenNgonNgu = tenNgonNgu;
        }
        public FNewLanguage()
        {
            InitializeComponent();
        }

        private void FNewLanguage_Load(object sender, EventArgs e)
        {
            txtMaNN.Enabled = false;
            if(tenNgonNgu != "")
                txtTenNN.Text = tenNgonNgu;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNN.Text))
            {
                MessageBox.Show("Vui lòng nhập tên ngôn ngữ", "Thông báo");
                return;
            }
            else
            {
                if (newLanguage.ThemNgonNgu(txtTenNN.Text))
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
