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
    public partial class FDanhSachDocGia : Form
    {
        MuonTraSachController dsdg = new MuonTraSachController();
        public FDanhSachDocGia()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                dtgvDocGia.DataSource = dsdg.DSDocGia();
                dtgvDocGia.RowHeadersVisible = false;
                dtgvDocGia.BackgroundColor = Color.White;
                dtgvDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
        private void FDanhSachDocGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
