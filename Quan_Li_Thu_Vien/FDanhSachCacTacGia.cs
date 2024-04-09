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
                else txtGioiTinh.Text = "Nam";
                txtNamSinh.Text = row.Cells["NamSinh"].Value.ToString();
                txtNamMat.Text = row.Cells["NamMat"].Value.ToString();
                txtQueQuan.Text = row.Cells["QueQuan"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Hide();
            btnSua.Hide();
            btnOK.Show();
            LoadText();
            ChinhSua();
        }
        public void LoadText()
        {
            txtMaTG.Text = "";
            txtTenTG.Text = "";
            txtGioiTinh.Text = "";
            txtNamSinh.Text = "";
            txtNamMat.Text = "";
            txtQueQuan.Text = "";
        }
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTG.Text) || string.IsNullOrEmpty(txtGioiTinh.Text))
            {
                MessageBox.Show("Please enter a valid value for 'TenTG' and 'GioiTinh'.");
                return;
            }
            string sex;
            if (txtGioiTinh.Text == "Nữ")
                sex = "F";
            else sex = "M";
            int namsinh, nammat;
            if (txtNamSinh.Text == "")
                namsinh = 0;
            else namsinh = int.Parse(txtNamMat.Text.ToString());
            if (txtNamMat.Text == "")
                nammat = 0;
            else nammat = int.Parse(txtNamMat.Text.ToString());
            tg = new TacGia("", txtTenTG.Text, sex, namsinh, nammat, txtQueQuan.Text, null);
            KhoaSua();
            if (dsTacGia.themTacGia(tg))
                MessageBox.Show("Thực thi thêm Tác giả thành công", "Thông báo", MessageBoxButtons.OK);
            else MessageBox.Show("Thực thi thêm Tác giả thất bại", "Thông báo", MessageBoxButtons.OK);
            btnOK.Hide();
            btnSua.Show();
            btnThem.Show();
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
