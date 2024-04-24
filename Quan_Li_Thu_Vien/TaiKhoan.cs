using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Thu_Vien
{
    public class TaiKhoan
    {
        public TaiKhoan() { }

        private string username;
        private string passwordUser;
        private string maNV;

        public TaiKhoan(string username, string passwordUser, string maNV)
        {
            this.username = username;
            this.passwordUser = passwordUser;
            this.maNV = maNV;
        }

        public string Username { get => username; set => username = value; }
        public string PasswordUser { get => passwordUser; set => passwordUser = value; }
        public string MaNV { get => maNV; set => maNV = value; }
    }
}
