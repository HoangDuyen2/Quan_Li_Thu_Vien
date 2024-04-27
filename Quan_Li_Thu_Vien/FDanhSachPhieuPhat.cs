using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
            dtgvPhieuPhat.DataSource = dspp.DSPhieuPhat();
            dtgvPhieuPhat.RowHeadersVisible = false;
            dtgvPhieuPhat.BackgroundColor = Color.White;
            dtgvPhieuPhat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FDanhSachPhieuPhat_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FThemPhieuPhat fThemPhieuPhat = new FThemPhieuPhat();
            fThemPhieuPhat.ShowDialog();
            FDanhSachPhieuPhat_Load(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvPhieuPhat.DataSource = dspp.timKiemPhieuPhat(txtMaSach.Text);
                dtgvPhieuPhat.RowHeadersVisible = false;
                dtgvPhieuPhat.BackgroundColor = Color.White;
                dtgvPhieuPhat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }

        private void dtgvPhieuPhat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = dtgvPhieuPhat.Rows[e.RowIndex];

                // Đưa dữ liệu vào các control hoặc xử lý theo nhu cầu
                int tongtien;
                if (!int.TryParse(row.Cells["TongTien"].Value.ToString(), out tongtien))
                    tongtien = 0;
                PhieuPhat pp = new PhieuPhat(row.Cells["MaPhieuPhat"].Value.ToString(), row.Cells["MaPhieuMuonTra"].Value.ToString(),
                    row.Cells["TenDocGia"].Value.ToString(), row.Cells["TenSach"].Value.ToString(), tongtien);
                // Thêm logic xử lý khi cell được click sau khi áp dụng bộ lọc
                FChiTietPhieuPhat fChiTiet = new FChiTietPhieuPhat(pp);
                fChiTiet.ShowDialog();
                FDanhSachPhieuPhat_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Trễ hạn")
            {
                try
                {
                    dtgvPhieuPhat.DataSource = dspp.DSPhieuTreHan();
                    dtgvPhieuPhat.RowHeadersVisible = false;
                    dtgvPhieuPhat.BackgroundColor = Color.White;
                    dtgvPhieuPhat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch
                {
                    MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
                }
            }
            else FDanhSachPhieuPhat_Load(sender, e);
        }
    }
}
