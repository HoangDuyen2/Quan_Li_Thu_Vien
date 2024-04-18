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
    public partial class FNhanVien : Form
    {
        public FNhanVien()
        {
            InitializeComponent();
        }

        private void FNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnThaoTacSach_Click(object sender, EventArgs e)
        {
            FTrangChuToSach_NhanVien fTrangChuToSach_NhanVien = new FTrangChuToSach_NhanVien();
            this.Hide();
            fTrangChuToSach_NhanVien.ShowDialog();
            this.Show();
        }
    }
}
