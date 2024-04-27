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
    public partial class FNewAuthor : Form
    {
        string tenTG;
        SachController newAuthor = new SachController();
        public FNewAuthor(string tenTG) : this()
        {
            this.tenTG = tenTG;
        }
        public FNewAuthor()
        {
            InitializeComponent();
        }
        private void FNewAuthor_Load(object sender, EventArgs e)
        {
            txtMaTG.Enabled = false;
            if (tenTG != "")
                txtTacGia.Text = tenTG;
        }
        #region Các button
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTacGia.Text) || radiobtnNam.Checked == false&& radioBtnNu.Checked == false)
            {
                MessageBox.Show("Không để trống các trường.", "Thông báo");
                return;
            }
            string sex;
            if (radiobtnNam.Checked)
                sex = "M";
            else sex = "F";
            int namsinh, nammat;
            if (!int.TryParse(txtNamSinh.Text, out namsinh))
                namsinh = 0;
            if(!int.TryParse(txtNamMat.Text,out nammat))
                nammat = 0;
            TacGia tacGia = new TacGia("",txtTacGia.Text,sex, namsinh, nammat,txtQueQuan.Text, DateTime.Now.ToString());
            newAuthor.thucThiThemSua(tacGia);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
