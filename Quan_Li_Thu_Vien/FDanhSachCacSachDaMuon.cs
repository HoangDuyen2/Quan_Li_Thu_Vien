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
    public partial class FDanhSachCacSachDaMuon : Form
    {
        MuonTraSachController dscsdm = new MuonTraSachController();
        public FDanhSachCacSachDaMuon()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                dtgvSachDaMuon.DataSource = dscsdm.DSSachDaMuonTrongNgay();
                dtgvSachDaMuon.RowHeadersVisible = false;
                dtgvSachDaMuon.BackgroundColor = Color.White;
                dtgvSachDaMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
        private void FDanhSachCacSachDaMuon_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
