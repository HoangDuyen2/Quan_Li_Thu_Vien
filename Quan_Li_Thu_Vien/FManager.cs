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
    public partial class FManager : Form
    {
        DBConnection db = new DBConnection();
        string sqlQuery;
        public FManager()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = db.GetSqlConnection())
            {
                sqlQuery = "proc_InsertTaiKhoan";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = txt_UserName.Text;
                cmd.Parameters.Add("@PasswordUser", SqlDbType.NVarChar, 100).Value = txt_Password.Text;
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar, 10).Value = txt_EmpID.Text;
                conn.Open();
                cmd.ExecuteReader();
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

        }
    }
}
