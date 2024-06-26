﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quan_Li_Thu_Vien
{
    public class DocGiaController
    {
        DBConnection conn = new DBConnection();
        public bool themDocGia(DocGia dg)
        {
            SqlCommand command = new SqlCommand("InsertDocGia", conn.GetSqlConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TenDocGia", SqlDbType.NVarChar).Value = dg.TenDocGia;
            command.Parameters.Add("@Email", SqlDbType.Char).Value = dg.Email;
            command.Parameters.Add("@SoDienThoai", SqlDbType.Char).Value = dg.SoDienThoai;
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = dg.GioiTinh;
            command.Parameters.Add("@MaLoaiDG", SqlDbType.NVarChar).Value = dg.MaLoaiDG;
            conn.openConnection();
            if (command.ExecuteNonQuery() > 0)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

        public bool suaDocGia(DocGia dg)
        {
            SqlCommand command = new SqlCommand("UpdateDocGia", conn.GetSqlConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaDocGia", SqlDbType.NVarChar).Value = dg.MaDocGia;
            command.Parameters.Add("@TenDocGia", SqlDbType.NVarChar).Value = dg.TenDocGia;
            command.Parameters.Add("@Email", SqlDbType.Char).Value = dg.Email;
            command.Parameters.Add("@SoDienThoai", SqlDbType.Char).Value = dg.SoDienThoai;
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = dg.GioiTinh;
            command.Parameters.Add("@TenLoaiDG", SqlDbType.NVarChar).Value = dg.MaLoaiDG;
            conn.openConnection();
            if (command.ExecuteNonQuery() > 0)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

        public DataTable DSDocGia()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DocGiaView", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public bool XoaDocGia(string maDocGia)
        {
            SqlCommand cmd = new SqlCommand("DeleteDocGia", conn.GetSqlConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDocGia", SqlDbType.NVarChar).Value = maDocGia;
            conn.openConnection();
            if(cmd.ExecuteNonQuery() > 0)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
        public DataTable timKiemDocGia(string tenDocGia)
        {
            string funcName = "func_SearchDocGiaByTenDocGia";
            SqlCommand command = new SqlCommand("Select * from " + funcName + " (@TenDocGia)", conn.GetSqlConnection());
            command.Parameters.Add("@TenDocGia", SqlDbType.NVarChar).Value = tenDocGia;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
    }
}
