using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Thu_Vien
{
    public class TacGia
    {
        private string maTG;
        private string tenTG;
        private string GioiTinh;
        private int NamSinh;
        private int NamMat;
        private string QueQuan;
        private string NgayTao;

        public string MaTG { get => maTG; set => maTG = value; }
        public string TenTG { get => tenTG; set => tenTG = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public int NamSinh1 { get => NamSinh; set => NamSinh = value; }
        public int NamMat1 { get => NamMat; set => NamMat = value; }
        public string QueQuan1 { get => QueQuan; set => QueQuan = value; }
        public string NgayTao1 { get => NgayTao; set => NgayTao = value; }
        public TacGia(string maTG, string tenTG, string gioiTinh, int namSinh, int namMat, string queQuan, string ngayTao)
        {
            MaTG = maTG;
            TenTG = tenTG;
            GioiTinh = gioiTinh;
            NamSinh = namSinh;
            NamMat = namMat;
            QueQuan = queQuan;
            NgayTao = ngayTao;

        }
        public TacGia() { }
    }
}
