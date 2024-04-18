using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Thu_Vien
{
    public class Person
    {
        private string maNguoi;
        private string tenNguoi;
        private string gioiTinh;
        private string NgaySinh;
        private string diaChi;
        private string SDT;
        private string maNQL;
        private string maTo;
        private string maTT;
        private double luong;
        private string email
        public Person(string maNguoi, string tenNguoi, string gioiTinh, string ngaySinh, string diaChi, string sDT, string maNQL, string maTo, string maTT, double luong,string email)
        {
            this.maNguoi = maNguoi;
            this.tenNguoi = tenNguoi;
            this.gioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.SDT = sDT;
            this.maNQL = maNQL;
            this.maTo = maTo;
            this.maTT = maTT;
            this.luong = luong;
            this.email = email;
        }

        public string MaNguoi { get => maNguoi; set => maNguoi = value; }
        public string TenNguoi { get => tenNguoi; set => tenNguoi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string MaNQL { get => maNQL; set => maNQL = value; }
        public string MaTo { get => maTo; set => maTo = value; }
        public string MaTT { get => maTT; set => maTT = value; }
        public double Luong { get => luong; set => luong = value; }
        public string Email { get => email; set => email = value; }
    }
}
