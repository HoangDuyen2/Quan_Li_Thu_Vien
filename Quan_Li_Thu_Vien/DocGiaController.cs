﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Quan_Li_Thu_Vien
{
    public class DocGiaController
    {
        DBConnection conn = new DBConnection();
        public bool themDocGia(DocGia dg)
        {
            SqlCommand command = new SqlCommand("pro_InsertDocGia", conn.GetSqlConnection());
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

        public bool capnhatDocGia(DocGia dg)
        {
            SqlCommand command = new SqlCommand("pro_UpdateDocGia", conn.GetSqlConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaDocGia", SqlDbType.NVarChar).Value = dg.MaDocGia;
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

        public DataTable DSDocGia()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ViewDocGia", conn.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

    }
}