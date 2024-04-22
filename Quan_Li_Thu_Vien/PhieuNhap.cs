using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Quan_Li_Thu_Vien
{
    public class PhieuNhap
    {
        private DateTime ngayNhap;
        private float giaTri;
        private string tenNcc;
        private string tenSach;
        private float donGia;
        private int soLuong;
        private string maPhieuNhap;

        public PhieuNhap() { }
        public PhieuNhap(string maPieuNhap,DateTime ngayNhap,float giaTri, string tenNcc, string tenSach, float donGia, int soLuong)
        {
            this.maPhieuNhap = maPieuNhap;
            this.ngayNhap= ngayNhap;
            this.tenNcc= tenNcc;
            this.tenSach= tenSach;
            this.donGia= donGia;
            this.soLuong= soLuong;
            this.giaTri = giaTri;
        }


        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public float GiaTri  { get => giaTri; set => giaTri = value; }
        public string TenNCC { get => tenNcc; set => tenNcc = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
    }
}
