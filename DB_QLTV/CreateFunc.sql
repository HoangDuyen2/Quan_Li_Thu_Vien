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
	SELECT @max = COUNT(MaNV) FROM [NhanVien]
	SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	-- Kiểm tra id đã tồn tại chưa
	WHILE(EXISTS(SELECT MaNV FROM [NhanVien] WHERE MaNV = @id_next))
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

--Tự động tăng Mã đọc giả
CREATE FUNCTION func_Auto_DocGiaID(@role TINYINT)
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @id_next VARCHAR(10)
	DECLARE @max INT
	DECLARE @object VARCHAR(2)
	IF @role = N'SV'
		BEGIN
			SET @object = 'SV'
		END
		ELSE
			BEGIN
				SET @object = 'GV'
			END
		SELECT @max = COUNT(MaLoaiDG) FROM dbo.DocGia WHERE MaLoaiDG = @role
	SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	-- Kiểm tra id đã tồn tại chưa
	WHILE(EXISTS(SELECT MaDocGia FROM [DocGia] WHERE MaDocGia = @id_next))
	BEGIN
		SET @max = @max + 1
		SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	END
		RETURN @id_next
END
GO
--Kết thúc hàm tự động thêm mã độc giả


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
CREATE FUNCTION func_Auto_PhieuNhapID()
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @id_next VARCHAR(10)
	DECLARE @max INT
	DECLARE @object VARCHAR(2)
	BEGIN
		SET @object = 'PN'
	END
	SELECT @max = COUNT(MaPhieuNhap) FROM [PhieuNhap]
	SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	-- Kiểm tra id đã tồn tại chưa
	WHILE(EXISTS(SELECT MaPhieuNhap FROM [PhieuNhap] WHERE MaPhieuNhap = @id_next))
	BEGIN
		SET @max = @max + 1
		SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	END
		RETURN @id_next
END
GO
--Kết thúc hàm tự động thêm mã nhà phiếu nhập

--Bắt đầu hàm danh sách nhân viên theo tổ
CREATE FUNCTION [dbo].[func_NhanVienTheoTo] (@string NVARCHAR(50))
RETURNS @NVList TABLE (MaNV NVARCHAR(10), TenNV NVARCHAR(50), GioiTinh CHAR(1), DiaChi NVARCHAR(255), SDT NVARCHAR(10), TenTo NVARCHAR(50))
AS BEGIN
	INSERT INTO @NVList SELECT MaNV, TenNV, GioiTinh, DiaChi, SDT, nt.TenTo
	FROM dbo.NhanVien nv INNER JOIN NhomTo nt ON nv.MaTo = nt.MaTo
	WHERE nv.MaTo = @string
	RETURN
END
--Kết thúc hàm nhân viên theo tổ
-- Tự động tăng thêm Mã Phiếu Mượn Trả khi thêm Phiếu Mượn Trả
CREATE FUNCTION func_Auto_PhieuMuonTraID()
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @id_next VARCHAR(10)
	DECLARE @max INT
	DECLARE @object VARCHAR(2)
	BEGIN
		SET @object = 'MT'
	END
	SELECT @max = COUNT(MaPhieuMuonTra) FROM [PhieuMuonTra]
	SET @id_next = @object + RIGHT('00' + CAST(@max AS nvarchar(10)), 4)
	-- Kiểm tra id đã tồn tại chưa
	WHILE(EXISTS(SELECT MaPhieuMuonTra FROM [PhieuMuonTra] WHERE MaPhieuMuonTra = @id_next))
	BEGIN
		SET @max = @max + 1
		SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	END
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
	SET @id_next = @object + RIGHT('00' + CAST(@max AS nvarchar(10)), 4)
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
-- Tự động tăng thêm Mã Tổ khi thêm Tổ
CREATE FUNCTION func_Auto_ToID()
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @id_next VARCHAR(10)
	DECLARE @max INT
	DECLARE @object VARCHAR(2)
	BEGIN
		SET @object = 'TO'
	END
	SELECT @max = COUNT(MaTo) FROM [NhomTo]
	SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 2)
	-- Kiểm tra id đã tồn tại chưa
	WHILE(EXISTS(SELECT MaTo FROM [NhomTo] WHERE MaTo = @id_next))
	BEGIN
		SET @max = @max + 1
		SET @id_next = @object + RIGHT('0' + CAST(@max AS nvarchar(10)), 3)
	END
		RETURN @id_next
END
GO
--Kết thúc hàm tự động thêm Tổ



