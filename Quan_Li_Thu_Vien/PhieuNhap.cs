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
        private string maNcc;
        private string tenSach;
        private float donGia;
        private int soLuong;
        private string maNv;


        public PhieuNhap(
        DateTime ngayNhap,
        float giaTri,
        string maNcc,
        string tenSach,
        float donGia,
        int soLuong,
        string maNv)
        {
            this.ngayNhap= ngayNhap;
            this.giaTri= giaTri;
            this.maNcc= maNcc;
            this.tenSach= tenSach;
            this.donGia= donGia;
            this.soLuong= soLuong;
            this.maNv= maNv;
        }


        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public float GiaTri  { get => giaTri; set => giaTri = value; }
        public string MaNCC { get => maNcc; set => maNcc = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string MaNV { get => maNv; set => maNv = value; }
    }
}
