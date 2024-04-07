using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Thu_Vien
{
    public class Sach
    {
        public Sach() { }
        private string maSach;
        private string tenSach;
        private string maNXB;
        private string tenLoaiSach;
        private string tenNgonNgu;
        private string NamXB;
        private string soLuongTon;

        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string MaNXB { get => maNXB; set => maNXB = value; }
        public string TenLoaiSach { get => tenLoaiSach; set => tenLoaiSach = value; }
        public string TenNgonNgu { get => tenNgonNgu; set => tenNgonNgu = value; }
        public string NamXB1 { get => NamXB; set => NamXB = value; }
        public string SoLuongTon { get => soLuongTon; set => soLuongTon = value; }
    }
}
