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
    public partial class FTrangChuToMuonSach_ToTruong : Form
    {
        public FTrangChuToMuonSach_ToTruong()
        {
            InitializeComponent();
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            FThongTinCaNhan fThongTinCaNhan = new FThongTinCaNhan();
            fThongTinCaNhan.ShowDialog();
        }
    }
}
