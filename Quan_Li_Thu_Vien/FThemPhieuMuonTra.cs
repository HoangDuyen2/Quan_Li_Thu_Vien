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
    public partial class FThemPhieuMuonTra : Form
    {
        DBConnection conn = new DBConnection();
        MuonTraSachController muonTraSachController = new MuonTraSachController();
        public FThemPhieuMuonTra()
        {
            InitializeComponent();
        }
        private void FThemPhieuMuonTra_Load(object sender, EventArgs e)
        {

        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            string username = LoginInfo.Username;

            string query = "SELECT tk.MaNV " +
                           "FROM TaiKhoan tk " +
                           "WHERE tk.Username = @username";
            SqlCommand cmmd = new SqlCommand(query, conn.GetSqlConnection());
            cmmd.Parameters.AddWithValue("@username", username);
            conn.openConnection();
            string maNV = cmmd.ExecuteScalar()?.ToString();
            conn.closeConnection();

            txtMaNV.Text = maNV;

            if (string.IsNullOrEmpty(txtMaDocGia.Text) || string.IsNullOrEmpty(txtHanTra.Text))
            {
                MessageBox.Show("Không để trống các trường.", "Thông báo");
                return;
            }
            if (txtMaDocGia.Text != "" && txtHanTra.Text != "")
                checkMaDocGia(txtMaDocGia.Text);
            if (checkMaDocGia(txtMaDocGia.Text) == true)
            {
                PhieuMuonTra phieuMuonTra = new PhieuMuonTra(txtMaPMT.Text, txtMaNV.Text, txtMaDocGia.Text, txtNgayMuon.Text, txtHanTra.Text);
                if (muonTraSachController.themPhieuMuonTra(phieuMuonTra))
                {
                    MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
                }
                else MessageBox.Show("Thực thi dữ liệu thất bại", "Lỗi");
            }
        }
        public bool checkMaDocGia(string maDocGia)
        {
            if (!muonTraSachController.checkMaDocGia(maDocGia))
            {
                DialogResult result1 = MessageBox.Show("Mã độc giả không tồn tại!");
                return false;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FDanhSachPhieuMuonTra fDanhSachPhieuMuonTra = new FDanhSachPhieuMuonTra();
            this.Close();
            fDanhSachPhieuMuonTra.ShowDialog();
            this.Show();
        }

        private void txtMaDocGia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
