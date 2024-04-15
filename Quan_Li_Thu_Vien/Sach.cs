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
        private string tenNXB;
        private string tenLoaiSach;
        private string tenNgonNgu;
        private string NamXB;
        private string soLuongTon;
        private string soLuongSach;
        private string tacGia1;

        public Sach(string maSach, string tenSach, string tenNXB, string tenLoaiSach, string tenNgonNgu, string namXB, string soLuongTon, string soLuongSach, string tacGia1) { 
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.tenNXB = tenNXB;
            this.tenLoaiSach = tenLoaiSach;
            this.tenNgonNgu = tenNgonNgu;
            this.NamXB = namXB;
            this.soLuongTon = soLuongTon;
            this.soLuongSach = soLuongSach;
            this.tacGia1 = tacGia1;
        }

        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TenNXB { get => tenNXB; set => tenNXB = value; }
        public string TenLoaiSach { get => tenLoaiSach; set => tenLoaiSach = value; }
        public string TenNgonNgu { get => tenNgonNgu; set => tenNgonNgu = value; }
        public string NamXB1 { get => NamXB; set => NamXB = value; }
        public string SoLuongTon { get => soLuongTon; set => soLuongTon = value; }
        public string SoLuongSach { get => soLuongSach; set => soLuongSach = value; }
        public string TacGia1 { get => tacGia1; set => tacGia1 = value; }
    }
}
