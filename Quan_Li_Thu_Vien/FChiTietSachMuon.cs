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
    public partial class FChiTietSachMuon : Form
    {
        Sach sach;
        string tenDG;
        string tinhTrang;
        public FChiTietSachMuon(Sach sach, string tenDG, string tinhTrang): this()
        {
            this.sach = sach;
            this.tenDG = tenDG;
            this.tinhTrang = tinhTrang;
        }
        public FChiTietSachMuon()
        {
            InitializeComponent();
        }

        private void FChiTietSachMuon_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            txtMaSach.Text = sach.MaSach;
            txtTenSach.Text = sach.TenSach;
            txtLoaiSach.Text = sach.TenLoaiSach;
            txtNXB.Text = sach.TenNXB;
            txtNamXB.Text = sach.NamXB1;
            txtNgonNgu.Text = sach.TenNgonNgu;
            txtTacGia1.Text = sach.TacGia1;
            txtTenDocGia.Text = tenDG;
            txtTinhTrang.Text = tinhTrang;
        }
        #region Các button
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion
    }
}
