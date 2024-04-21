using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Thu_Vien
{
    public class PhieuMuonTra
    {
            public PhieuMuonTra() { }
            private string maPhieuMuonTra;
            private string maNV;
            private string maDocGia;
            private string ngayMuon;
            private string hanTra;

            public PhieuMuonTra(string maPhieuMuonTra, string maNV, string maDocGia, string ngayMuon, string hanTra)
            {
                this.maPhieuMuonTra = maPhieuMuonTra;
                this.maNV = maNV;
                this.maDocGia = maDocGia;
                this.ngayMuon = ngayMuon;
                this.hanTra = hanTra;
            }

            public string MaPhieuMuonTra { get => maPhieuMuonTra; set => maPhieuMuonTra = value; }
            public string MaNV { get => maNV; set => maNV = value; }
            public string MaDocGia { get => maDocGia; set => maDocGia = value; }
            public string NgayMuon { get => ngayMuon; set => ngayMuon = value; }
            public string HanTra { get => hanTra; set => hanTra = value; }
    }
}
