--Bắt đầu view Danh sách độc giả đã vi phạm
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
--Kết thúc view Danh sách độc giả vi phạm

--Bắt đầu view Danh sách các sách trong dữ liệu
CREATE VIEW SachView AS
SELECT S.MaSach, S.TenSach, NXB.TenNXB AS TenNXB, LS. TenLoaiSach AS TenLoaiSach, S.NamXB, NN.TenNgonNgu AS TenNgonNgu, S.SoLuongTon, S.SoLuongSach, TG.TenTG
FROM Sach S
INNER JOIN TacGiaSach TGS ON S.MaSach = TGS.MaSach
INNER JOIN TacGia TG ON TGS.MaTG = TG.MaTG
INNER JOIN NXB ON S.MaNXB = NXB.MaNXB
INNER JOIN LoaiSach LS ON S.MaLoaiSach = LS.MaLoaiSach
INNER JOIN NgonNgu NN ON S.MaNgonNgu = NN.MaNgonNgu;
--Kết thúc view Danh sách các sách

--Bắt đầu view Danh sách các sách bị hư
CREATE VIEW SachBiHu 
AS
SELECT DISTINCT s.MaSach, s.TenSach, s.MaLoaiSach, s.NamXB, s.MaNgonNgu, s.MaNXB
FROM ChiTietPhieuMuonTra ctpmt
INNER JOIN PhieuPhat pp ON ctpmt.MaPhieuMuonTra = pp.MaPhieuMuonTra 
INNER JOIN Sach s ON s.MaSach = ctpmt.MaSach
--Kết thúc view Danh sách các sách bị hư

