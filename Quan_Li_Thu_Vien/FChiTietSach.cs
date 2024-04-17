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
    public partial class FChiTietSach : Form
    {
        Sach sachForm = new Sach();
        SachController sachController = new SachController();
        string tenTGOld = "";
        public FChiTietSach(Sach sach) : this()
        {
            this. sachForm = sach;
        }
        public FChiTietSach()
        {
            InitializeComponent();
        }
        private void FChiTietSach_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            txtMaSach.Text = sachForm.MaSach;
            txtTenSach.Text = sachForm.TenSach;
            txtLoaiSach.Text = sachForm.TenLoaiSach;
            txtNXB.Text = sachForm.TenNXB;
            txtNamXB.Text = sachForm.NamXB1;
            txtNgonNgu.Text = sachForm.TenNgonNgu;
            txtTacGia1.Text = sachForm.TacGia1;
            txtSoLuongTon.Text = sachForm.SoLuongTon;
            txtSoLuongSach.Text = sachForm.SoLuongSach;
            tenTGOld = sachForm.TacGia1;
            btnOK.Hide();
        }
        #region Các button
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            btnChinhSua.Hide();
            btnOK.Show();
            TruyCap();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            btnOK.Hide();
            btnChinhSua.Show();
            KhongTruyCap();
            if(txtLoaiSach.Text != "")
                checkTenLoaiSach(txtLoaiSach.Text);
            if(txtNXB.Text != "")
                checkTenNXB(txtNXB.Text);
            if(txtTacGia1.Text != "")
                checkTenTacGia(txtTacGia1.Text);
            if(txtNgonNgu.Text != "")
                checkTenNgonNgu(txtNgonNgu.Text);
            Sach sach = new Sach(txtMaSach.Text, txtTenSach.Text, txtNXB.Text, txtLoaiSach.Text, txtNgonNgu.Text, txtNamXB.Text, 
                txtSoLuongTon.Text,txtSoLuongSach.Text, txtTacGia1.Text);
            if(sachController.suaSach(sach, tenTGOld))
            {
                MessageBox.Show("Thực thi dữ liệu thành công", "Thông báo");
            }
            else MessageBox.Show("Thực thi dữ liệu thất bại", "Lỗi");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FDanhSachCacSach dsSach = new FDanhSachCacSach();
            this.Hide();
            dsSach.ShowDialog();
        }
        #endregion
        #region Truy cập vào textbox
        public void KhongTruyCap()
        {
            txtMaSach.Enabled = false;
            txtTenSach.Enabled = false;
            txtLoaiSach.Enabled = false;
            txtNXB.Enabled = false;
            txtNamXB.Enabled = false;
            txtNgonNgu.Enabled = false;
            txtTacGia1.Enabled = false;
            txtSoLuongTon.Enabled = false;
            txtSoLuongSach.Enabled = false;
        }
        public void TruyCap()
        {
            txtTenSach.Enabled = true;
            txtLoaiSach.Enabled = true;
            txtNXB.Enabled = true;
            txtNamXB.Enabled = true;
            txtNgonNgu.Enabled = true;
            txtTacGia1.Enabled = true;
        }
        #endregion
        #region Các check khi thêm, sửa
        public void checkTenNXB(string tenNXB)
        {
            if (sachController.checkTenNXB(tenNXB) == false)
            {
                DialogResult result1 = MessageBox.Show("Tên nhà xuất bản bạn nhập không có trong danh sách nhà xuất bản. Bạn có muốn thêm nhà xuất bản này vào danh sách?", "Warning", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    FNewNXB newAuthor = new FNewNXB(tenNXB);
                    newAuthor.ShowDialog();
                }
                else
                {
                    FDanhSachCacNhaXuatBan dsNXB = new FDanhSachCacNhaXuatBan();
                    dsNXB.ShowDialog();
                }
            }
        }
        public void checkTenLoaiSach(string tenLoaiSach)
        {
            if(sachController.checkTenLoaiSach(tenLoaiSach) == false)
            {
                DialogResult result1 = MessageBox.Show("Tên loại sách bạn nhập không có trong danh sách loại sách. Bạn có muốn thêm loại sách này vào danh sách?", "Warning", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    FNewLoaiSach newAuthor = new FNewLoaiSach(tenLoaiSach);
                    newAuthor.ShowDialog();
                }
                else
                {
                    FDanhSachCacLoaiSach dsLoaiSach = new FDanhSachCacLoaiSach();
                    dsLoaiSach.ShowDialog();
                }
            }
        }
        public void checkTenTacGia(string tenTacGia)
        {
            if(sachController.checkTenTG(tenTacGia) == false)
            {
                DialogResult result1 = MessageBox.Show("Tên tác giả bạn nhập không có trong danh sách tác giả. Bạn có muốn thêm tác giả vào danh sách?", "Warning", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    FNewAuthor newAuthor = new FNewAuthor(tenTacGia);
                    newAuthor.ShowDialog();
                }
                else
                {
                    FDanhSachCacTacGia dsTacGia = new FDanhSachCacTacGia();
                    dsTacGia.ShowDialog();
                }
            }
        }
        public void checkTenNgonNgu(string tenNgonNgu)
        {
            if (sachController.checkTenNgonNgu(tenNgonNgu) == false)
            {
                DialogResult result1 = MessageBox.Show("Tên tác giả bạn nhập không có trong danh sách tác giả. Bạn có muốn thêm tác giả vào danh sách?", "Warning", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    FNewLanguage newLanguage = new FNewLanguage(tenNgonNgu);
                    newLanguage.ShowDialog();
                }
                else
                {
                    FDanhSachCacTacGia dsTacGia = new FDanhSachCacTacGia();
                    dsTacGia.ShowDialog();
                }
            }
        }
        #endregion
    }
}
