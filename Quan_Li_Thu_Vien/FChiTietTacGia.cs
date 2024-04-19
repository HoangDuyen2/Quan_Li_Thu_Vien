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
    public partial class FChiTietTacGia : Form
    {
        TacGia tacGia;
        SachController TacGia = new SachController();
        public FChiTietTacGia(TacGia tg) : this()
        {
            tacGia = tg;
        }
        public FChiTietTacGia()
        {
            InitializeComponent();
        }
        private void FChiTietTacGia_Load(object sender, EventArgs e)
        {
            KhoaSua();
            btnChinhSua.Show();
            LoadData();
            btnOK.Hide();
        }
        public void LoadData()
        {
            txtMaTG.Text = tacGia.MaTG;
            txtTacGia.Text = tacGia.TenTG;
            if (tacGia.GioiTinh1 == "F")
                radioBtnNu.Checked = true;
            else radiobtnNam.Checked = true;
            txtNamSinh.Text = tacGia.NamSinh1.ToString();
            txtNamMat.Text = tacGia.NamMat1.ToString();
            txtQueQuan.Text = tacGia.QueQuan1;
        }
        #region Cấp quyền truy cập
        public void ChinhSua()
        {
            txtTacGia.Enabled = true;
            radioBtnNu.Enabled = true;
            radiobtnNam.Enabled = true;
            txtNamSinh.Enabled = true;
            txtNamMat.Enabled = true;
            txtQueQuan.Enabled = true;
        }
        public void KhoaSua()
        {
            txtMaTG.Enabled = false;
            txtTacGia.Enabled = false;
            radioBtnNu.Enabled = false;
            radiobtnNam.Enabled = false;
            txtNamSinh.Enabled = false;
            txtNamMat.Enabled = false;
            txtQueQuan.Enabled = false;
        }
        #endregion
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            btnChinhSua.Hide();
            ChinhSua();
            btnOK.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTacGia.Text))
            {
                MessageBox.Show("Please enter a valid value for 'TenTG' and 'GioiTinh'.");
                return;
            }
            string sex = "";
            if (radioBtnNu.Checked)
                sex = "F";
            else
                sex = "M";
            int namsinh, nammat;
            if (!int.TryParse(txtNamSinh.Text, out namsinh))
                namsinh = 0;
            if (!int.TryParse(txtNamMat.Text, out nammat))
                nammat = 0;
            TacGia tg1 = new TacGia(txtMaTG.Text, txtTacGia.Text, sex, namsinh, nammat, txtQueQuan.Text, null);
            KhoaSua();
            TacGia.thucThiThemSua(tg1);
            btnOK.Hide();
            btnChinhSua.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FDanhSachCacTacGia danhsachCacTacGia = new FDanhSachCacTacGia();
            this.Hide();
            danhsachCacTacGia.ShowDialog();
        }

        
    }
}
