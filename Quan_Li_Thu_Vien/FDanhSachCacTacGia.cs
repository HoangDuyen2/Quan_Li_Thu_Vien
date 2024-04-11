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
    public partial class FDanhSachCacTacGia : Form
    {
        SachController dsTacGia = new SachController();
        TacGia tg = null;
        public FDanhSachCacTacGia()
        {
            InitializeComponent();
        }
        #region Load data
        public void LoadText()
        {
            txtMaTG.Text = "";
            txtTenTG.Text = "";
            txtGioiTinh.Text = "";
            txtNamSinh.Text = "";
            txtNamMat.Text = "";
            txtQueQuan.Text = "";
        }
        public void LoadData()
        {
            try
            {
                dtgvTG.DataSource = dsTacGia.DSTacGia();
                dtgvTG.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
        private void FDanhSachCacTacGia_Load(object sender, EventArgs e)
        {
            LoadData();
            btnOK.Hide();
        }
        #endregion

        #region Cấp quyền truy cập
        public void ChinhSua()
        {
            txtTenTG.Enabled = true;
            txtGioiTinh.Enabled = true;
            txtNamSinh.Enabled = true;
            txtNamMat.Enabled = true;
            txtQueQuan.Enabled = true;
        }
        public void KhoaSua()
        {
            txtTenTG.Enabled = false;
            txtGioiTinh.Enabled = false;
            txtNamSinh.Enabled = false;
            txtNamMat.Enabled = false;
            txtQueQuan.Enabled = false;
        }
        #endregion
        private void dtgvTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dtgvTG.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaTG.Text = row.Cells["MaTG"].Value.ToString();
                txtTenTG.Text = row.Cells["TenTG"].Value.ToString();
                if (row.Cells["GioiTinh"].Value.ToString() == "F")
                    txtGioiTinh.Text = "Nữ";
                if (row.Cells["GioiTinh"].Value.ToString() == "M")
                    txtGioiTinh.Text = "Nam";
                txtNamSinh.Text = row.Cells["NamSinh"].Value.ToString();
                txtNamMat.Text = row.Cells["NamMat"].Value.ToString();
                txtQueQuan.Text = row.Cells["QueQuan"].Value.ToString();
            }
        }
        #region Các event click button
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Hide();
            btnSua.Hide();
            btnOK.Show();
            LoadText();
            ChinhSua();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Hide();
            btnSua.Hide();
            btnOK.Show();
            LoadData();
            ChinhSua();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTG.Text)||string.IsNullOrEmpty(txtGioiTinh.Text))
            {
                MessageBox.Show("Please enter a valid value for 'TenTG' and 'GioiTinh'.");
                return;
            }
            string sex = "";
            if (txtGioiTinh.Text == "Nữ")
                sex = "F";
            if (txtGioiTinh.Text == "Nam")
                sex = "M";
            int namsinh, nammat;
            if (!int.TryParse(txtNamSinh.Text, out namsinh))
                namsinh = 0;
            if (!int.TryParse(txtNamMat.Text, out nammat))
                nammat = 0;
            tg = new TacGia(txtMaTG.Text, txtTenTG.Text, sex, namsinh, nammat, txtQueQuan.Text, null);
            KhoaSua();
            dsTacGia.thucThiThemSua(tg);
            btnOK.Hide();
            btnSua.Show();
            btnThem.Show();
            LoadData();
        }
        #endregion
    }
}
