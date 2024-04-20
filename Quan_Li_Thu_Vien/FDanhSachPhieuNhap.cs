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
    public partial class FDanhSachPhieuNhap : Form
    {
        PhieuNhapController phieuNhapController = new PhieuNhapController();
        public FDanhSachPhieuNhap()
        {
            InitializeComponent();
        }

        private void FDanhSachPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                dataGridView1.DataSource = phieuNhapController.DSPhieuNhap();
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.BackgroundColor = Color.White;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
    }
}
