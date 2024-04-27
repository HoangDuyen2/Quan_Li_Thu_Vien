using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Thu_Vien
{
    public class PhieuMuonTra
    {
            private string maPhieuMuonTra;
            private string tenNV;
            private string tenDocGia;
            private string ngayMuon;
            private string hanTra;
        public PhieuMuonTra() { }
            public PhieuMuonTra(string maPhieuMuonTra, string tenNV, string tenDocGia, string ngayMuon, string hanTra)
            {
                this.maPhieuMuonTra = maPhieuMuonTra;
                this.tenNV = tenNV;
                this.tenDocGia = tenDocGia;
                this.ngayMuon = ngayMuon;
                this.hanTra = hanTra;
            }

            public string MaPhieuMuonTra { get => maPhieuMuonTra; set => maPhieuMuonTra = value; }
            public string TenNV { get => tenNV; set => tenNV = value; }
            public string TenDocGia { get => tenDocGia; set => tenDocGia = value; }
            public string NgayMuon { get => ngayMuon; set => ngayMuon = value; }
            public string HanTra { get => hanTra; set => hanTra = value; }
    }
}
