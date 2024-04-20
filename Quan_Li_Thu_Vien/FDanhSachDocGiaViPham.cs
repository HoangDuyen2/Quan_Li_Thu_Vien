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
    public partial class FDanhSachDocGiaViPham : Form
    {
        MuonSachController dsdgvp = new MuonSachController();
        public FDanhSachDocGiaViPham()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                dtgvDocGiaViPham.DataSource = dsdgvp.DSDocGiaViPham();
                dtgvDocGiaViPham.RowHeadersVisible = false;
                dtgvDocGiaViPham.BackgroundColor = Color.White;
                dtgvDocGiaViPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
        private void FDanhSachDocGiaViPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
