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
    public partial class FToTruong : Form
    {
        public FToTruong()
        {
            InitializeComponent();
        }

        private void btnToTruong_Click(object sender, EventArgs e)
        {
            FTrangChuToSach_ToTruong fTrangChuToSach_ToTruong = new FTrangChuToSach_ToTruong();
            this.Hide();
            fTrangChuToSach_ToTruong.ShowDialog();
            this.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
