using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Thu_Vien
{
    public class DocGia
    {
        public DocGia() { }
        private string maDocGia;
        private string tenDocGia;
        private string email;
        private string soDienThoai;
        private string gioiTinh;
        private string ngayTao;
        private string maLoaiDG;

        public DocGia(string maDocGia, string tenDocGia, string email, string soDienThoai, string gioiTinh, string ngayTao, string maLoaiDG)
        {
            this.maDocGia = maDocGia;
            this.tenDocGia = tenDocGia;
            this.email = email;
            this.soDienThoai = soDienThoai;
            this.gioiTinh = gioiTinh;
            this.ngayTao = ngayTao;
            this.maLoaiDG = maLoaiDG;
        }

        public string MaDocGia { get => maDocGia; set => maDocGia = value; }
        public string TenDocGia { get => tenDocGia; set => tenDocGia = value; }
        public string Email { get => email; set => email = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
        public string MaLoaiDG { get => maLoaiDG; set => maLoaiDG = value; }
    }
}
