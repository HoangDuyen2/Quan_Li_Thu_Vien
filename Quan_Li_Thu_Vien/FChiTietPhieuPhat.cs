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
        PhieuPhat PhieuPhat = new PhieuPhat();
        string loaiPhat;
        public FChiTietPhieuPhat(PhieuPhat pp) : this()
        {
            PhieuPhat = pp;
        }
        public FChiTietPhieuPhat()
        {
            InitializeComponent();
            LoadComboboxLoaiPhat();
        }
        public void LoadData()
        {
            dtgvChiTietPhieuPhat.DataSource = dsctpp.DSChiTietPhieuPhat(PhieuPhat.MaPhieuPhat);
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
            this.Close();
        }

        private void comboBoxLoaiPhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaiPhat = comboBoxLoaiPhat.Text;
        }
        public void LoadComboboxLoaiPhat()
        {
            comboBoxLoaiPhat.DataSource = dsctpp.DSTenCacLoaiPhat();
            comboBoxLoaiPhat.DisplayMember = dsctpp.DSTenCacLoaiPhat().Columns[0].ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dsctpp.XoaPhieuPhat(PhieuPhat.MaPhieuPhat))
            {
                MessageBox.Show("Xóa phiếu phạt thành công", "Thông báo");
                btnThemMaSach.Hide();
            }
            else
            {
                MessageBox.Show("Xóa phiếu mượn trả không thành công", "Lỗi");
            }
        }

        private void btnThemChiTIetPhieuPhat_Click(object sender, EventArgs e)
        {
            if (dsctpp.themChiTietPhieuPhat(PhieuPhat.MaPhieuPhat, loaiPhat))
            {
                MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thực thi dữ liệu thất bại", "Thông báo");
            }
            FChiTietPhieuPhat_Load(sender, e);
        }
    }
}
