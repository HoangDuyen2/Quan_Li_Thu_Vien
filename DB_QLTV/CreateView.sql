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
SELECT DISTINCT S.MaSach, S.TenSach, NXB.TenNXB AS TenNXB, LS. TenLoaiSach AS TenLoaiSach, S.NamXB, NN.TenNgonNgu AS TenNgonNgu, S.SoLuongTon, S.SoLuongSach, TG.TenTG
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
SELECT DISTINCT s.MaSach, s.TenSach, ls.TenLoaiSach, s.NamXB, nn.TenNgonNgu, nxb.TenNXB, tg.TenTG, dg.TenDocGia
FROM ChiTietPhieuMuonTra ctpmt
INNER JOIN PhieuPhat pp ON ctpmt.MaPhieuMuonTra = pp.MaPhieuMuonTra 
INNER JOIN Sach s ON s.MaSach = ctpmt.MaSach
INNER JOIN LoaiSach ls ON s.MaLoaiSach = ls.MaLoaiSach
INNER JOIN NgonNgu nn ON s.MaNgonNgu = nn.MaNgonNgu
INNER JOIN NXB nxb ON s.MaNXB = nxb.MaNXB
INNER JOIN TacGiaSach tgs ON s.MaSach = tgs.MaSach
INNER JOIN TacGia tg ON tgs.MaTG = tg.MaTG
INNER JOIN DocGia dg ON dg.MaDocGia = ctpmt.MaPhieuMuonTra
--Kết thúc view Danh sách các sách bị hư

--Bắt đầu view Danh sách các độc giả
CREATE VIEW DocGiaView AS
SELECT DISTINCT DG.MaDocGia, DG.TenDocGia, DG.GioiTinh, DG.SoDienThoai, DG.Email, LDG.TenLoaiDG AS LoaiDocGia
FROM DocGia DG
INNER JOIN LoaiDocGia LDG ON DG. MaLoaiDG = LDG. MaLoaiDG;
--Kết thúc view Danh sách các độc giả

--Bắt đầu view Danh sách các nhân viên
CREATE VIEW NhanVienView AS
SELECT DISTINCT nv.MaNV, nv.TenNV, nv.GioiTinh, nt.TenTo, tt.TenNV AS TenToTruong, nv.SDT
FROM NhanVien nv
INNER JOIN dbo.NhomTo nt ON nv.MaTo = nt.MaTo
INNER JOIN NhanVien tt ON nv.MaTT = tt.MaNV
--Kết thúc view danh sách nhân viên

--Bắt đầu view danh sách các sách đang mượn
CREATE VIEW SachMuonView AS
SELECT DISTINCT s.MaSach, s.TenSach, s.NamXB, nn.TenNgonNgu, nxb.TenNXB, ls.TenLoaiSach, tg.TenTG
FROM Sach s
INNER JOIN NgonNgu nn ON s.MaNgonNgu = nn.MaNgonNgu
INNER JOIN NXB nxb ON s.MaNXB = nxb.MaNXB
INNER JOIN LoaiSach ls ON s.MaLoaiSach = ls.MaLoaiSach
INNER JOIN ChiTietPhieuMuonTra ctpm ON ctpm.MaSach = s.MaSach
INNER JOIN TacGiaSach tgs ON tgs.MaSach = s.MaSach
INNER JOIN TacGia tg ON tg.MaTG = tgs.MaTG
WHERE ctpm.NgayTra IS NULL
-- Kết thúc view danh sách các cuốn sách đang mượn

--Danh sách các cuốn sách đã mượn trong ngày
CREATE VIEW SachDaMuonTrongNgay AS
SELECT DISTINCT s.MaSach, s.TenSach, s.NamXB, nn.TenNgonNgu, nxb.TenNXB, ls.TenLoaiSach, tg.TenTG
FROM Sach s
INNER JOIN NgonNgu nn ON s.MaNgonNgu = nn.MaNgonNgu
INNER JOIN NXB nxb ON s.MaNXB = nxb.MaNXB
INNER JOIN LoaiSach ls ON s.MaLoaiSach = ls.MaLoaiSach
INNER JOIN ChiTietPhieuMuonTra ctpm ON ctpm.MaSach = s.MaSach
INNER JOIN PhieuMuonTra pmt ON ctpm.MaPhieuMuonTra = pmt.MaPhieuMuonTra
INNER JOIN TacGiaSach tgs ON s.MaSach = tgs.MaSach
INNER JOIN TacGia tg ON tgs.MaTG = tg.MaTG
WHERE pmt.NgayMuon = CONVERT(date,GETDATE())
--Kết thúc view danh sách các cuốn sách đã mượn trong ngày

