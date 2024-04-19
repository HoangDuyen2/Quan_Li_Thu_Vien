using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Quan_Li_Thu_Vien
{
    public class MuonSachController
    {
        DBConnection conn = new DBConnection();
        #region list view
        public DataTable DSPhieuMuonTra()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuMuon", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable DSPhieuMuonTra()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuMuon", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable DSPhieuMuonTra()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuMuon", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable DSPhieuMuonTra()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuMuon", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable DSPhieuMuonTra()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuMuon", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable DSPhieuMuonTra()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuMuon", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable DSPhieuMuonTra()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuMuon", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
