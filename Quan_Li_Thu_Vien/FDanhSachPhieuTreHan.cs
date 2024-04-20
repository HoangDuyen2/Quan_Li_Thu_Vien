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
    public partial class FDanhSachPhieuTreHan : Form
    {
        public FDanhSachPhieuTreHan()
        {
            InitializeComponent();
        }
        MuonSachController dspth = new MuonSachController();
        public void LoadData()
        {
            try
            {
                dtgvPhieuTreHan.DataSource = dspth.DSPhieuTreHan();
                dtgvPhieuTreHan.RowHeadersVisible = false;
                dtgvPhieuTreHan.BackgroundColor = Color.White;
                dtgvPhieuTreHan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
        private void FDanhSachPhieuTreHan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
