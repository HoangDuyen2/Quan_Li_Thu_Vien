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
    public partial class FThemSach : Form
    {
        public FThemSach()
        {
            InitializeComponent();
        }
        SachController sachController = new SachController();
        private void FThemSach_Load(object sender, EventArgs e)
        {
            txtMaSach.Enabled = false;
        }
        #region Các button
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSach.Text)||string.IsNullOrEmpty(txtLoaiSach.Text)||string.IsNullOrEmpty(txtNamXB.Text)||
                string.IsNullOrEmpty(txtNgonNgu.Text)||string.IsNullOrEmpty(txtNXB.Text)||string.IsNullOrEmpty(txtSoLuongSach.Text)||
                string.IsNullOrEmpty(txtSoLuongTon.Text)||string.IsNullOrEmpty(txtTacGia1.Text))
            {
                MessageBox.Show("Không để trống các trường.","Thông báo");
                return;
            }
            if (txtLoaiSach.Text != "")
                checkTenLoaiSach(txtLoaiSach.Text);
            if (txtNXB.Text != "")
                checkTenNXB(txtNXB.Text);
            if (txtTacGia1.Text != "")
                checkTenTacGia(txtTacGia1.Text);
            if (txtNgonNgu.Text != "")
                checkTenNgonNgu(txtNgonNgu.Text);
            Sach sach = new Sach(txtMaSach.Text, txtTenSach.Text, txtNXB.Text, txtLoaiSach.Text, txtNgonNgu.Text, txtNamXB.Text,
                txtSoLuongTon.Text, txtSoLuongSach.Text, txtTacGia1.Text);
            if (sachController.themSach(sach))
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
        #region Các check khi thêm, sửa
        public void checkTenNXB(string tenNXB)
        {
            if (!sachController.checkTenNXB(tenNXB))
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
            if (sachController.checkTenLoaiSach(tenLoaiSach) == false)
            {
                DialogResult result1 = MessageBox.Show("Tên loại sách bạn nhập không có trong danh sách loại sách. Bạn có muốn thêm loại sách này vào danh sách?", "Warning", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    FNewLoaiSach newAuthor = new FNewLoaiSach(tenLoaiSach);
                    newAuthor.ShowDialog();
                }
            }
        }
        public void checkTenTacGia(string tenTacGia)
        {
            if (sachController.checkTenTG(tenTacGia) == false)
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
            }
        }

        #endregion
    }
}