--Tự động tăng mã nhân viên khi thêm nhân viên
CREATE FUNCTION func_Auto_NhanVienID()
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @id_next VARCHAR(10)
	DECLARE @max INT
	DECLARE @object VARCHAR(2)
	BEGIN
		SET @object = 'NV'
	END
	SELECT @max = COUNT(MaNV) FROM [ThongTinNhanVien]
	SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	-- Kiểm tra id đã tồn tại chưa
	WHILE(EXISTS(SELECT MaNV FROM [ThongTinNhanVien] WHERE MaNV = @id_next))
	BEGIN
		SET @max = @max + 1
		SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	END
		RETURN @id_next
END
GO
--Kết thúc hàm Tự động tăng mã nhân viên khi thêm nhân viên

-- Tự động tăng thêm Mã sách khi thêm sách
CREATE FUNCTION func_Auto_bookID()
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @id_next VARCHAR(10)
	DECLARE @max INT
	DECLARE @object VARCHAR(2)
	BEGIN
		SET @object = 'MS'
	END
	SELECT @max = COUNT(MaSach) FROM [Sach]
	SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	-- Kiểm tra id đã tồn tại chưa
	WHILE(EXISTS(SELECT MaSach FROM [Sach] WHERE MaSach = @id_next))
	BEGIN
		SET @max = @max + 1
		SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	END
		RETURN @id_next
END
GO
--Kết thúc hàm tự động thêm sách

--Tự động thêm mã ngôn ngữ khi thêm ngôn ngữ mới
CREATE FUNCTION func_Auto_LanguageID()
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @id_next VARCHAR(10)
	DECLARE @max INT
	DECLARE @object VARCHAR(2)
	BEGIN
		SET @object = 'NN'
	END
	SELECT @max = COUNT(MaNgonNgu) FROM [NgonNgu]
	SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	-- Kiểm tra id đã tồn tại chưa
	WHILE(EXISTS(SELECT MaNgonNgu FROM [NgonNgu] WHERE MaNgonNgu = @id_next))
	BEGIN
		SET @max = @max + 1
		SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	END
		RETURN @id_next
END
GO
-- Kết thúc hàm tự động thêm ngôn ngữ

--Tự động thêm mã nhà xuất bản khi thêm nhà xuất bản
CREATE FUNCTION func_Auto_NXBID()
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @id_next VARCHAR(10)
	DECLARE @max INT
	DECLARE @object VARCHAR(3)
	BEGIN
		SET @object = 'NXB'
	END
	SELECT @max = COUNT(MaNXB) FROM [NXB]
	SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	-- Kiểm tra id đã tồn tại chưa
	WHILE(EXISTS(SELECT MaNXB FROM [NXB] WHERE MaNXB = @id_next))
	BEGIN
		SET @max = @max + 1
		SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	END
		RETURN @id_next
END
GO
--Kết thúc hàm tự động thêm mã nhà xuất bản

--Tự động tăng mã tác giả khi thêm tác giả
CREATE FUNCTION func_Auto_TacGiaID()
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @id_next VARCHAR(10)
	DECLARE @max INT
	DECLARE @object VARCHAR(2)
	BEGIN
		SET @object = 'TG'
	END
	SELECT @max = COUNT(MaTG) FROM [TacGia]
	SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	-- Kiểm tra id đã tồn tại chưa
	WHILE(EXISTS(SELECT MaTG FROM [TacGia] WHERE MaTG = @id_next))
	BEGIN
		SET @max = @max + 1
		SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	END
		RETURN @id_next
END
GO
--Kết thúc hàm tự động thêm mã tác giả

--Tự động tăng Mã loại sách khi loại sách
CREATE FUNCTION func_Auto_LoaiSachID()
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @id_next VARCHAR(10)
	DECLARE @max INT
	DECLARE @object VARCHAR(2)
	BEGIN
		SET @object = 'LS'
	END
	SELECT @max = COUNT(MaLoaiSach) FROM [LoaiSach]
	SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	-- Kiểm tra id đã tồn tại chưa
	WHILE(EXISTS(SELECT MaLoaiSach FROM [LoaiSach] WHERE MaLoaiSach = @id_next))
	BEGIN
		SET @max = @max + 1
		SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	END
		RETURN @id_next
END
GO
--Kết thúc hàm tự động thêm mã loại sách


--Tự động tăng Mã nhà cung cấp khi cung cấp sách
CREATE FUNCTION func_Auto_CungCapID()
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @id_next VARCHAR(10)
	DECLARE @max INT
	DECLARE @object VARCHAR(2)
	BEGIN
		SET @object = 'NCC'
	END
	SELECT @max = COUNT(MaNhaCC) FROM [CungCap]
	SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	-- Kiểm tra id đã tồn tại chưa
	WHILE(EXISTS(SELECT MaNhaCC FROM [CungCap] WHERE MaNhaCC = @id_next))
	BEGIN
		SET @max = @max + 1
		SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	END
		RETURN @id_next
END
GO
--Kết thúc hàm tự động thêm mã nhà cung cấp

--Tự động tăng Mã phiếu nhập
CREATE FUNCTION func_Auto_PhieuMuonTraID()
RETURNS NVARCHAR(10)
AS
BEGIN
    DECLARE @id_next VARCHAR(10)
    DECLARE @max INT
    DECLARE @object VARCHAR(2)
    
    SET @object = 'MT'
    
    SELECT @max = ISNULL(MAX(CAST(SUBSTRING(MaPhieuMuonTra, 3, LEN(MaPhieuMuonTra) - 2) AS INT)), 0) 
    FROM PhieuMuonTra

    SET @id_next = @object + RIGHT('00' + CAST((@max + 1) AS nvarchar(10)), 3)

    RETURN @id_next
END
GO
--Kết thúc hàm tự động thêm mã nhà phiếu nhập
	
-- Tự động tăng thêm Mã Phiếu Mượn Trả khi thêm Phiếu Mượn Trả
CREATE FUNCTION func_Auto_PhieuMuonTraID()
RETURNS NVARCHAR(10)
AS
BEGIN
    DECLARE @id_next VARCHAR(10)
    DECLARE @max INT
    DECLARE @object VARCHAR(2)
    
    SET @object = 'MT'
    
    SELECT @max = ISNULL(CAST(RIGHT(MAX(MaPhieuMuonTra), 4) AS INT), 0) 
    FROM PhieuMuonTra

    SET @id_next = @object + RIGHT('0000' + CAST((@max + 1) AS nvarchar(10)), 4)

    RETURN @id_next
END
GO
--Kết thúc hàm tự động thêm Phiếu Mượn Trả
	
-- Tự động tăng thêm Mã Phiếu Phạt khi thêm Phiếu Phạt
CREATE FUNCTION func_Auto_PhieuPhatID()
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @id_next VARCHAR(10)
	DECLARE @max INT
	DECLARE @object VARCHAR(2)
	BEGIN
		SET @object = 'PP'
	END
	SELECT @max = COUNT(MaPhieuPhat) FROM [PhieuPhat]
	SET @id_next = @object + RIGHT('00' + CAST(@max AS nvarchar(10)), 3)
	-- Kiểm tra id đã tồn tại chưa
	WHILE(EXISTS(SELECT MaPhieuPhat FROM [PhieuPhat] WHERE MaPhieuPhat = @id_next))
	BEGIN
		SET @max = @max + 1
		SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	END
		RETURN @id_next
END
GO
--Kết thúc hàm tự động thêm Phiếu Phạt

--Bắt đầu hàm tìm sách mượn theo ngày
CREATE FUNCTION [dbo].[func_CategorizeBookByDate](@NgayBD datetime, @NgayKT datetime)
RETURNS @Book TABLE(MaSach nvarchar(10), TenSach nvarchar(255), TenLoaiSach nvarchar(50), TenNXB nvarchar(255), TenNgonNgu nvarchar(50), NamXB int,
TenTG nvarchar(255), TenDocGia nvarchar(50), TinhTrang nvarchar(50))
AS
BEGIN
	DECLARE @NgayBD_NoTime datetime = CONVERT(DATE, @NgayBD);
    DECLARE @NgayKT_NoTime datetime = CONVERT(DATE, @NgayKT);

	INSERT @Book
	SELECT s.MaSach, s.TenSach, ls.TenLoaiSach, nxb.TenNXB, nn.TenNgonNgu, s.NamXB, tg.TenTG, dg.TenDocGia, ctpm.TinhTrang
	FROM Sach s
	INNER JOIN NgonNgu nn ON s.MaNgonNgu = nn.MaNgonNgu
	INNER JOIN NXB nxb ON s.MaNXB = nxb.MaNXB
	INNER JOIN LoaiSach ls ON s.MaLoaiSach = ls.MaLoaiSach
	INNER JOIN ChiTietPhieuMuonTra ctpm ON ctpm.MaSach = s.MaSach
	INNER JOIN TacGiaSach tgs ON tgs.MaSach = s.MaSach
	INNER JOIN TacGia tg ON tg.MaTG = tgs.MaTG
	INNER JOIN PhieuMuonTra pmt ON pmt.MaPhieuMuonTra = ctpm.MaPhieuMuonTra
	INNER JOIN DocGia dg ON dg.MaDocGia = pmt.MaDocGia
	WHERE CONVERT(DATE,pmt.NgayMuon) BETWEEN @NgayBD_NoTime AND @NgayKT_NoTime
	RETURN
END
--Kết thúc hàm tự động thêm sách mượn theo ngày

--Bắt đầu tìm sách theo loại sách
CREATE FUNCTION [dbo].[func_CategorizeBookByGenre](@TenLoaiSach nvarchar(50))
RETURNS @Book TABLE(MaSach nvarchar(10), TenSach nvarchar(255), TenLoaiSach nvarchar(50), TenNXB nvarchar(255), TenNgonNgu nvarchar(50), NamXB int, SoLuongTon int, SoLuongSach int, TenTG nvarchar(255))
AS
BEGIN
	INSERT @Book
	SELECT s.MaSach, s.TenSach, ls.TenLoaiSach, nxb.TenNXB, nn.TenNgonNgu, s.NamXB, s.SoLuongTon, s.SoLuongSach, tg.TenTG
	FROM Sach s INNER JOIN NgonNgu nn ON nn.MaNgonNgu = s.MaNgonNgu INNER JOIN NXB nxb ON s.MaNXB = nxb.MaNXB 
	INNER JOIN LoaiSach ls ON ls.MaLoaiSach = s.MaLoaiSach INNER JOIN TacGiaSach tgs ON tgs.MaSach = s.MaSach
	INNER JOIN TacGia tg ON tgs.MaTG = tg.MaTG
	WHERE ls.TenLoaiSach = @TenLoaiSach
	RETURN
END
--Kết thúc tìm sách theo loại sách

--Bắt đầu tìm sách theo ngôn ngữ
CREATE FUNCTION [dbo].[func_CategorizeBookByLanguage](@TenNgonNgu nvarchar(50))
RETURNS @Book TABLE(MaSach nvarchar(10), TenSach nvarchar(255), TenLoaiSach nvarchar(50), TenNXB nvarchar(255), TenNgonNgu nvarchar(50), NamXB int, SoLuongTon int, SoLuongSach int, TenTG nvarchar(255))
AS
BEGIN
	INSERT @Book
	SELECT s.MaSach, s.TenSach, ls.TenLoaiSach, nxb.TenNXB, nn.TenNgonNgu, s.NamXB, s.SoLuongTon, s.SoLuongSach, tg.TenTG
	FROM Sach s INNER JOIN NgonNgu nn ON nn.MaNgonNgu = s.MaNgonNgu INNER JOIN NXB nxb ON s.MaNXB = nxb.MaNXB 
	INNER JOIN LoaiSach ls ON ls.MaLoaiSach = s.MaLoaiSach INNER JOIN TacGiaSach tgs ON tgs.MaSach = s.MaSach
	INNER JOIN TacGia tg ON tgs.MaTG = tg.MaTG
	WHERE nn.TenNgonNgu = @TenNgonNgu
	RETURN
END
--Kết thúc tìm sách theo ngôn ngữ

--Bắt đầu tìm sách theo tình trạng(Đã trả/chưa trả)
CREATE FUNCTION [dbo].[func_CategorizeBookBySituation](@TinhTrang nvarchar(50))
RETURNS @Book TABLE(MaSach nvarchar(10), TenSach nvarchar(255), TenLoaiSach nvarchar(50), TenNXB nvarchar(255), TenNgonNgu nvarchar(50), NamXB int,
TenTG nvarchar(255), TenDocGia nvarchar(50), TinhTrang nvarchar(50))
AS
BEGIN
	INSERT @Book
	SELECT s.MaSach, s.TenSach, ls.TenLoaiSach, nxb.TenNXB, nn.TenNgonNgu, s.NamXB, tg.TenTG, dg.TenDocGia, ctpm.TinhTrang
	FROM Sach s
	INNER JOIN NgonNgu nn ON s.MaNgonNgu = nn.MaNgonNgu
	INNER JOIN NXB nxb ON s.MaNXB = nxb.MaNXB
	INNER JOIN LoaiSach ls ON s.MaLoaiSach = ls.MaLoaiSach
	INNER JOIN ChiTietPhieuMuonTra ctpm ON ctpm.MaSach = s.MaSach
	INNER JOIN TacGiaSach tgs ON tgs.MaSach = s.MaSach
	INNER JOIN TacGia tg ON tg.MaTG = tgs.MaTG
	INNER JOIN PhieuMuonTra pmt ON pmt.MaPhieuMuonTra = ctpm.MaPhieuMuonTra
	INNER JOIN DocGia dg ON dg.MaDocGia = pmt.MaDocGia
	WHERE ctpm.TinhTrang = @TinhTrang
	RETURN
END
--Kết thúc tìm sách theo tình trạng

--Bắt đầu tìm sách theo tên sách
CREATE FUNCTION [dbo].[func_SearchBookName] (@TenSach NVARCHAR(50))
RETURNS @BookList TABLE(MaSach nvarchar(10), TenSach nvarchar(255), TenLoaiSach nvarchar(50), TenNXB nvarchar(255), TenNgonNgu nvarchar(50), NamXB int, SoLuongTon int, SoLuongSach int, TenTG nvarchar(255))
AS
BEGIN
	INSERT @BookList
	SELECT s.MaSach, s.TenSach, ls.TenLoaiSach, nxb.TenNXB, nn.TenNgonNgu, s.NamXB, s.SoLuongTon, s.SoLuongSach, tg.TenTG
	FROM Sach s INNER JOIN NgonNgu nn ON nn.MaNgonNgu = s.MaNgonNgu INNER JOIN NXB nxb ON s.MaNXB = nxb.MaNXB 
	INNER JOIN LoaiSach ls ON ls.MaLoaiSach = s.MaLoaiSach INNER JOIN TacGiaSach tgs ON tgs.MaSach = s.MaSach
	INNER JOIN TacGia tg ON tgs.MaTG = tg.MaTG
    WHERE TenSach LIKE N'%' + @TenSach + '%'
	RETURN
END
--Kết thúc tìm sách theo tên

--Bắt đầu tìm sách theo tên nxb
CREATE FUNCTION [dbo].[func_SearchNXBName] (@TenNXB NVARCHAR(50))
RETURNS @NXBList TABLE (MaNXB NVARCHAR(10), TenNXB NVARCHAR(50), DiaChi 
NVARCHAR(255), SDT NVARCHAR(10))
AS
BEGIN
	INSERT INTO @NXBList (MaNXB, TenNXB, DiaChi, SDT)
    SELECT MaNXB, TenNXB, DiaChi, SDT
    FROM dbo.NXB
    WHERE TenNXB LIKE N'%' + @TenNXB + '%'
	RETURN
END
--Kết thúc tìm sách theo tên nhà xuất bản

--Tìm loại sách theo tên loại sách
CREATE FUNCTION [dbo].[func_SearchTenLoaiSachByTenLoaiSach](@TenLoaiSach nvarchar(50))
RETURNS INT
AS
BEGIN
	DECLARE @LoaiSachCount INT

	SELECT @LoaiSachCount = COUNT(*)
	FROM LoaiSach
	WHERE @TenLoaiSach = TenLoaiSach

	IF(@LoaiSachCount > 0)
		RETURN 1
	RETURN 0
END
--Kết thúc tìm sách theo tên loại sách

--Bắt đầu tìm ngôn ngữ theo tên ngôn ngữ
CREATE FUNCTION [dbo].[func_SearchTenNgonNguByTenNgonNgu](@TenNgonNgu nvarchar(50))
RETURNS INT
AS
BEGIN
	DECLARE @NgonNguCount INT

	SELECT @NgonNguCount = COUNT(*)
	FROM NgonNgu
	WHERE @TenNgonNgu = TenNgonNgu

	IF(@NgonNguCount > 0)
		RETURN 1
	RETURN 0
END
--Kết thúc tìm ngôn ngữ theo tên ngôn ngữ

--Bắt đầu tìm tên nhà xuất bản theo tên nhà xuất bản
CREATE FUNCTION [dbo].[func_SearchTenNXBByName](@TenNXB nvarchar(255))
RETURNS INT
AS
BEGIN
	DECLARE @NXBCount INT
	SELECT @NXBCount = COUNT(*)
	FROM NXB
	WHERE TenNXB = @TenNXB
	
	IF @NXBCount > 0
		RETURN 1
	RETURN 0
END
--Kết thúc tìm tên nhà xuất bản theo tên nhà xuất bản

--Tìm kiếm tên tác giả theo tên tác giả
CREATE FUNCTION [dbo].[func_SearchTenTGByName](@TenTacGia nvarchar(50))
RETURNS INT
AS
BEGIN
	DECLARE @TenTGCount INT
	SELECT @TenTGCount = COUNT(*)
	FROM TacGia
	WHERE TenTG = @TenTacGia;
	
	IF(@TenTGCount > 0)
		RETURN 1
	RETURN 0
END
--Kết thúc tìm tên tác giả theo tên tác giả

--Danh sách các tác giả theo tên
CREATE FUNCTION [dbo].[func_SearchTGName] (@TenTG NVARCHAR(50))
RETURNS @TGList TABLE (MaTG NVARCHAR(10), TenTG NVARCHAR(50), GioiTinh 
NVARCHAR(1), NamSinh INT, NamMat INT, QueQuan NVARCHAR(50))
AS
BEGIN
	INSERT INTO @TGList (MaTG, TenTG, GioiTinh, NamSinh, NamMat, QueQuan)
    SELECT MaTG, TenTG, GioiTinh, NamSinh, NamMat, QueQuan
    FROM dbo.TacGia
    WHERE TenTG LIKE N'%' + @TenTG + '%'
	RETURN
END
--Kết thúc danh sách các tác giả theo tên

--Bắt đầu tên các loại ngôn ngữ
CREATE FUNCTION [dbo].[func_TenCacLoaiNgonNgu]()
RETURNS @DSTenNgonNgu TABLE(TenNgonNgu nvarchar(50))
AS
BEGIN
	INSERT @DSTenNgonNgu(TenNgonNgu)
	SELECT TenNgonNgu
	FROM NgonNgu
	RETURN
END
--Kết thúc tên các loại ngôn ngữ

--Bắt đầu tên các loại sách
CREATE FUNCTION [dbo].[func_TenCacLoaiSach]()
RETURNS @LoaiSach TABLE (TenLoaiSach nvarchar(50))
AS
BEGIN
	INSERT INTO @LoaiSach(TenLoaiSach)
	SELECT TenLoaiSach
	FROM LoaiSach
	RETURN
END
--Kết thúc tên các loại sách
--Tìm kiếm độc giả theo mã độc giả
CREATE FUNCTION [dbo].[func_SearchDocGiabyMaDocGia](@MaDocGia nvarchar(10))
RETURNS INT
AS
BEGIN
	DECLARE @MaDocGiaCount INT

	SELECT @MaDocGiaCount = COUNT(*)
	FROM DocGia
	WHERE @MaDocGia = MaDocGia

	IF(@MaDocGiaCount > 0)
		RETURN 1
	RETURN 0
--End Tìm kiếm độc giả theo mã độc giả
END
--Tìm kiếm Phiếu mượn trả theo tên độc giả
CREATE FUNCTION func_SearchPMTByTenDG
(
    @ReaderName NVARCHAR(50)
)
RETURNS @BookLoansList TABLE
(
    MaPhieuMuonTra NVARCHAR(10),
    TenNV NVARCHAR(255),
    TenDocGia NVARCHAR(255),
    NgayMuon DATE,
    HanTra DATE
)
AS
BEGIN
    INSERT INTO @BookLoansList
    SELECT
        pm.MaPhieuMuonTra,
        nv.TenNV,
        dg.TenDocGia,
        pm.NgayMuon,
        pm.HanTra
    FROM PhieuMuonTra pm
    INNER JOIN DocGia dg ON pm.MaDocGia = dg.MaDocGia
    INNER JOIN ThongTinNhanVien nv ON pm.MaNV = nv.MaNV
    WHERE dg.TenDocGia LIKE N'%' + @ReaderName + '%'
    RETURN
END
--END Tìm kiếm Phiếu mượn trả theo tên độc giả

--Tìm kiếm nhà cung cấp theo tên nhà cung cấp
CREATE FUNCTION [dbo].[func_SearchTenNCCByName](@TenNhaCungCap nvarchar(50))
RETURNS INT
AS
BEGIN
	DECLARE @TenNCCCount INT
	SELECT @TenNCCCount = COUNT(*)
	FROM CungCap
	WHERE TenNhaCC = @TenNhaCungCap;
	
	IF(@TenNCCCount > 0)
		RETURN 1
	RETURN 0
END
--Kết thúc tìm kiếm nhà cung cấp theo tên nhà cung cấp

--Tìm kiếm sách theo tên sách
CREATE FUNCTION [dbo].[func_SearchTenSachByName](@TenSach nvarchar(50))
RETURNS INT
AS
BEGIN
	DECLARE @TenSachCount INT
	SELECT @TenSachCount = COUNT(*)
	FROM Sach
	WHERE TenSach = @TenSach;
	
	IF(@TenSachCount > 0)
		RETURN 1
	RETURN 0
END
--Kết thúc tìm kiếm theo tên
--Tìm kiếm DocGia theo TenDocGia
CREATE FUNCTION func_SearchDocGiaByTenDocGia(
    @TenDocGia VARCHAR(255)
)
RETURNS TABLE
AS
RETURN (
    SELECT *
    FROM DocGia
    WHERE TenDocGia LIKE '%' + @TenDocGia + '%'
);
--Kết thúc tìm kiếm DocGia theo TenDocGia
--Tìm kiếm PhieuPhat theo MaSach
CREATE FUNCTION SearchPhieuPhatByTenSach
(
    @TenSach nvarchar(50)
)
RETURNS TABLE
AS
RETURN (
    SELECT pp.MaPhieuPhat, mt.MaPhieuMuonTra, dg.TenDocGia, s.TenSach, pp.TongTien
    FROM PhieuPhat pp
    INNER JOIN PhieuMuonTra mt ON pp.MaPhieuMuonTra = mt.MaPhieuMuonTra
    INNER JOIN DocGia dg ON mt.MaDocGia = dg.MaDocGia
    INNER JOIN Sach s ON s.MaSach = pp.MaSach
    WHERE s.MaSach = @MaSach
);
-Kết thúc Tìm kiếm PhieuPhat theo MaSach
