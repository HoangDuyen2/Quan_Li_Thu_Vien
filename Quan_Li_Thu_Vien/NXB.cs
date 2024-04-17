using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Thu_Vien
{
    public class NXB
    {
        private string maNXB;
        private string tenNXB;
        private string DiaChi;
        private string SDT;
        public NXB(string maNXB, string tenNXB, string diaChi, string sDT)
        {
            this.MaNXB = maNXB;
            this.TenNXB = tenNXB;
            DiaChi1 = diaChi;
            SDT1 = sDT;
        }
        public NXB() { }
        public string MaNXB { get => maNXB; set => maNXB = value; }
        public string TenNXB { get => tenNXB; set => tenNXB = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
    }
}
