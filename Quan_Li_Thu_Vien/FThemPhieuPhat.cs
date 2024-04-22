using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Quan_Li_Thu_Vien
{
    public partial class FThemPhieuPhat : Form
    {
        DBConnection conn = new DBConnection();
        MuonTraSachController muonTraSachController = new MuonTraSachController();
        public FThemPhieuPhat()
        {
            InitializeComponent();
        }
        private void FThemPhieuPhat_Load(object sender, EventArgs e)
        {

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
