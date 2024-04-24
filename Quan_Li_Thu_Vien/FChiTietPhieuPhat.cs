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
    public partial class FChiTietPhieuPhat : Form
    {
        MuonTraSachController dsctpp = new MuonTraSachController();
        private string maPhieuPhat;
        public FChiTietPhieuPhat()
        {
            InitializeComponent();
            LoadComboboxLoaiPhat();
        }
        public void SetMaPhieuPhat(string maPhieuPhat)
        {
            this.maPhieuPhat = maPhieuPhat;
        }
        public void LoadData()
        {
            dtgvChiTietPhieuPhat.DataSource = dsctpp.DSChiTietPhieuPhat(maPhieuPhat);
            dtgvChiTietPhieuPhat.RowHeadersVisible = false;
            dtgvChiTietPhieuPhat.BackgroundColor = Color.White;
            dtgvChiTietPhieuPhat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FChiTietPhieuPhat_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FDanhSachPhieuPhat fDanhSachPhieuPhat = new FDanhSachPhieuPhat();
            this.Hide();
            fDanhSachPhieuPhat.ShowDialog();
        }

        private void comboBoxLoaiPhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dsctpp.themChiTietPhieuPhat(maPhieuPhat, comboBoxLoaiPhat.Text))
            {
                MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thực thi dữ liệu thất bại", "Thông báo");
            }
            FChiTietPhieuPhat_Load(sender, e);
        }
        public void LoadComboboxLoaiPhat()
        {
            comboBoxLoaiPhat.DataSource = dsctpp.DSTenCacLoaiPhat();
            comboBoxLoaiPhat.DisplayMember = dsctpp.DSTenCacLoaiPhat().Columns[0].ToString();
        }

    }
}
