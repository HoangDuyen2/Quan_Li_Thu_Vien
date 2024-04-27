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
    public partial class FThemPhieuPhat : Form
    {
        MuonTraSachController muonTraSachController = new MuonTraSachController();
        public FThemPhieuPhat()
        {
            InitializeComponent();
        }
        private void FThemPhieuPhat_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieuMuonTra.Text) || string.IsNullOrEmpty(txtMaSach.Text))
            {
                MessageBox.Show("Không để trống các trường.", "Thông báo");
                return;
            }
            if (muonTraSachController.checkTinhTrangCTPMT(txtMaPhieuMuonTra.Text, txtMaSach.Text))
            {
                PhieuPhat phieuPhat = new PhieuPhat(txtMaPhieuPhat.Text, txtMaPhieuMuonTra.Text, txtMaSach.Text, txtNgayXuatPhieu.Text, 0);
                if (muonTraSachController.themPhieuPhat(phieuPhat))
                {
                    MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thực thi dữ liệu thất bại", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Phiếu mượn trả phải được trả trước khi tạo phiếu phạt", "Thông báo");
            }
        }
    }
}
