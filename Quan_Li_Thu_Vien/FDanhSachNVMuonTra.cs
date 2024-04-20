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
    public partial class FDanhSachNVMuonTra : Form
    {
        public FDanhSachNVMuonTra()
        {
            InitializeComponent();
        }
        MuonSachController dsnvtmt = new MuonSachController();
        public void LoadData()
        {
            try
            {
                dtgvNVToMuonTra.DataSource = dsnvtmt.DSNhanVienTheoToMuonSach();
                dtgvNVToMuonTra.RowHeadersVisible = false;
                dtgvNVToMuonTra.BackgroundColor = Color.White;
                dtgvNVToMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
        private void FDanhSachNVMuonTra_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
