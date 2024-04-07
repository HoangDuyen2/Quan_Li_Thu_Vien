CREATE VIEW DanhSachDocGiaViPham AS
SELECT DISTINCT
    p.MaDocGia,
    dg.TenDocGia,
    dg.Email,
    dg.SoDienThoai,
    pp.MaPhieuPhat,
    pp.TongTien,
    pp.NgayXuatPhieu
FROM
    PhieuPhat pp
INNER JOIN
    PhieuMuonTra p ON pp.MaPhieuMuonTra = p.MaPhieuMuonTra
INNER JOIN
    DocGia dg ON p.MaDocGia = dg.MaDocGia;
