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
    public partial class FDanhSachPhieuMuonTra : Form
    {
        MuonTraSachController dspmt = new MuonTraSachController();
        public FDanhSachPhieuMuonTra()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                dtgvPhieuMuonTra.DataSource = dspmt.DSPhieuMuonTra();
                dtgvPhieuMuonTra.RowHeadersVisible = false;
                dtgvPhieuMuonTra.BackgroundColor = Color.White;
                dtgvPhieuMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
        private void FDanhSachPhieuMuonTra_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
