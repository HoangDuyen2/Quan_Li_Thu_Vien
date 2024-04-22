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
    public partial class FDanhSachPhieuPhat : Form
    {
        DBConnection conn = new DBConnection();
        MuonTraSachController dspp = new MuonTraSachController();
        private string maPhieuPhat;
        public FDanhSachPhieuPhat()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dtgvPhieuPhat.DataSource = dspp.DSPhieuPhat();
            dtgvPhieuPhat.RowHeadersVisible = false;
            dtgvPhieuPhat.BackgroundColor = Color.White;
            dtgvPhieuPhat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FDanhSachPhieuPhat_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FThemPhieuPhat fThemPhieuPhat = new FThemPhieuPhat();
            this.Hide();
            fThemPhieuPhat.ShowDialog();
            this.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FSuaPhieuPhat fSuaPhieuPhat = new FSuaPhieuPhat();
            this.Hide();
            fSuaPhieuPhat.ShowDialog();
            this.Show();
        }
    }
}
