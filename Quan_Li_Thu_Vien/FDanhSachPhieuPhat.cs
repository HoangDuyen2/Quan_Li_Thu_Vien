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
        MuonTraSachController dspp = new MuonTraSachController();
        public FDanhSachPhieuPhat()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                dtgvPhieuPhat.DataSource = dspp.DSPhieuPhat();
                dtgvPhieuPhat.RowHeadersVisible = false;
                dtgvPhieuPhat.BackgroundColor = Color.White;
                dtgvPhieuPhat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
        private void FDanhSachPhieuPhat_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
