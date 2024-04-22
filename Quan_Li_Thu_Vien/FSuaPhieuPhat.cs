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
    public partial class FSuaPhieuPhat : Form
    {
        public FSuaPhieuPhat()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FDanhSachPhieuPhat fDanhSachPhieuPhat = new FDanhSachPhieuPhat();
            this.Close();
            fDanhSachPhieuPhat.ShowDialog();
            this.Show();
        }
    }
}
