using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quan_Li_Thu_Vien
{
    public partial class FDanhSachDocGia : Form
    {
        DBConnection conn = new DBConnection();
        DocGiaController dsdg = new DocGiaController();
        private string maDocGia;

        public FDanhSachDocGia()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dtgvDocGia.DataSource = dsdg.DSDocGia();
            dtgvDocGia.RowHeadersVisible = false;
            dtgvDocGia.BackgroundColor = Color.White;
            dtgvDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FDanhSachDocGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dtgvDocGia.Columns[e.ColumnIndex].Name == "MaDocGia")
            {
                maDocGia = dtgvDocGia.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maDocGia))
            {
                bool isDeleted = dsdg.XoaDocGia(maDocGia);

                if (isDeleted)
                {
                    MessageBox.Show("Xóa phiếu mượn trả thành công", "Thông báo");
                    FDanhSachDocGia danhSachDocGia = new FDanhSachDocGia();
                    this.Close();
                    danhSachDocGia.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Xóa độc giả không thành công", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một độc giả để xóa", "Thông báo");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
