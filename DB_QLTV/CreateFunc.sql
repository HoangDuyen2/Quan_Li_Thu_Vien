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
--Kết thúc hàm tự động thêm mã nhà cung cấp


