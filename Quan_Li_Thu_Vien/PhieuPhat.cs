using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Thu_Vien
{
    public class PhieuPhat
    {
        public PhieuPhat() { }

        private string maPhieuPhat;
        private string maPhieuMuonTra;
        private string maSach;
        private string ngayXuatPhieu;
        private int tongTien;

        public PhieuPhat(string maPhieuPhat, string maPhieuMuonTra, string maSach, string ngayXuatPhieu, int tongTien)
        {
            this.maPhieuPhat = maPhieuPhat;
            this.maPhieuMuonTra = maPhieuMuonTra;
            this.maSach = maSach;
            this.ngayXuatPhieu = ngayXuatPhieu;
            this.tongTien = tongTien;
        }

        public string MaPhieuPhat { get => maPhieuPhat; set => maPhieuPhat = value; }
        public string MaPhieuMuonTra { get => maPhieuMuonTra; set => maPhieuMuonTra = value; }
        public string MaSach { get => maSach; set => maSach = value; }
        public string NgayXuatPhieu { get => ngayXuatPhieu; set => ngayXuatPhieu = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
    }
}
