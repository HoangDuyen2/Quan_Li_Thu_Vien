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
    public partial class FDanhSachCacSach : Form
    {
        SachController dssach = new SachController();
        public FDanhSachCacSach()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                dtgvSach.DataSource = dssach.DSSach();
                dtgvSach.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
        private void FDanhSachCacSach_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dtgvSach.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtTenSach.Text = row.Cells[1].Value.ToString();
                txtNXB.Text = row.Cells[2].Value.ToString();
                txtLoaiSach.Text = row.Cells[3].Value.ToString();
                txtNamXB.Text = row.Cells[4].Value.ToString();
                txtNgonNgu.Text = row.Cells[5].Value.ToString();
                txtSLConLai.Text = row.Cells[6].Value.ToString();
                txtTacGia.Text = row.Cells[8].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
