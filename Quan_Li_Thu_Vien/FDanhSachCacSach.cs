using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quan_Li_Thu_Vien
{
    public partial class FDanhSachCacSach : Form
    {
        SachController dssach = new SachController();
        public FDanhSachCacSach()
        {
            InitializeComponent();
            LoadComboboxLoaiSach();
            LoadComboboxNgonNgu();
        }
        #region LoadComboBox
        public void LoadComboboxLoaiSach()
        {
            comboBoxLoaiSach.DataSource = dssach.DSCacLoaiSach();
            comboBoxLoaiSach.DisplayMember = dssach.DSCacLoaiSach().Columns[0].ToString();
        }
        public void LoadComboboxNgonNgu()
        {
            comboBoxNgonNgu.DataSource = dssach.DSNgonNgu();
            comboBoxNgonNgu.DisplayMember = dssach.DSNgonNgu().Columns[0].ToString();
        }
        #endregion
        public void LoadData()
        {
            try
            {
                dtgvSach.DataSource = dssach.DSSach();
                dtgvSach.RowHeadersVisible = false;
                dtgvSach.BackgroundColor = Color.White;
                dtgvSach.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
        private void FDanhSachCacSach_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtgvSach.DataSource = dssach.DSSachTheoTheLoaiSach(comboBoxLoaiSach.Text);
                dtgvSach.RowHeadersVisible = false;
                dtgvSach.BackgroundColor = Color.White;
                dtgvSach.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }

        private void comboBoxNgonNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtgvSach.DataSource = dssach.DSSachTheoNgonNgu(comboBoxNgonNgu.Text);
                dtgvSach.RowHeadersVisible = false;
                dtgvSach.BackgroundColor = Color.White;
                dtgvSach.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvSach.DataSource = dssach.timKiemSach(txtTenSach.Text);
                dtgvSach.RowHeadersVisible = false;
                dtgvSach.BackgroundColor = Color.White;
                dtgvSach.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }
    }
}
