--Kiểm tra số điện thoại trùng của Nhà cung cấp
CREATE TRIGGER CC_TrungSDT
ON CungCap
AFTER INSERT, UPDATE
AS
BEGIN
 -- Kiểm tra số điện thoại vừa thêm có bị trùng lặp
	IF EXISTS (
			 SELECT *
			 FROM inserted i
			 WHERE EXISTS (
				 SELECT *
				 FROM CungCap cc
				 WHERE cc.SoDienThoai = i.SoDienThoai AND cc.MaNhaCC <> i.MaNhaCC
			 ))
	 BEGIN
		 -- Nếu trùng thì rollback
		 --PRINT N'Số điện thoại đã tồn tại'
		 ROLLBACK;
	 END
END
--Kết thúc kiểm tra số điện thoại nhà cung cấp

--Kiểm tra số điện thoại trùng của Nhà xuất bản
CREATE TRIGGER NXB_TrungSDT
ON NXB
AFTER INSERT, UPDATE
AS
BEGIN
 -- Kiểm tra số điện thoại vừa thêm có bị trùng lặp
	IF EXISTS (
			 SELECT *
			 FROM inserted i
			 WHERE EXISTS (
				 SELECT *
				 FROM NXB nxb
				 WHERE nxb.SDT = i.SDT AND nxb.MaNXB <> i.MaNXB
			 ))
	 BEGIN
		 -- Nếu trùng thì rollback
		 --PRINT N'Số điện thoại đã tồn tại'
		 ROLLBACK;
	 END
END
--Kết thúc kiểm tra số điện thoại nhà xuất bản

--Kiểm tra số điện thoại trùng của Độc giả
CREATE TRIGGER DocGia_TrungSDT
ON DocGia
AFTER INSERT, UPDATE
AS
BEGIN
 -- Kiểm tra số điện thoại vừa thêm có bị trùng lặp
	IF EXISTS (
			 SELECT *
			 FROM inserted i
			 WHERE EXISTS (
				 SELECT *
				 FROM DocGia dg
				 WHERE dg.SoDienThoai = i.SoDienThoai AND dg.MaDocGia <> i.MaLoaiDG
			 ))
	 BEGIN
		 -- Nếu trùng thì rollback
		 --PRINT N'Số điện thoại đã tồn tại'
		 ROLLBACK;
	 END
END
--Kết thúc kiểm tra số điện thoại của độc giả

--Kiểm tra số điện thoại trùng của Nhân viên
CREATE TRIGGER Nhanvien_TrungSDT
ON NhanVien
AFTER INSERT, UPDATE
AS
BEGIN
 -- Kiểm tra số điện thoại vừa thêm có bị trùng lặp
	IF EXISTS (
			 SELECT *
			 FROM inserted i
			 WHERE EXISTS (
				 SELECT *
				 FROM NhanVien nv
				 WHERE nv.SDT = i.SDT AND nv.MaNV <> i.MaNV
			 ))
	 BEGIN
		 -- Nếu trùng thì rollback
		 --PRINT N'Số điện thoại đã tồn tại'
		 ROLLBACK;
	 END
END
--Kết thúc kiểm tra số điện thoại của nhân viên

--Trigger NgayTao trong bảng Sach
CREATE TRIGGER trg_Inserted_Updated_Book
ON Sach
FOR INSERT, UPDATE
AS
DECLARE @NgayTao DATETIME
DECLARE @bookID NVARCHAR(10)
BEGIN
	IF TRIGGER_NESTLEVEL() > 1
    RETURN

	SELECT @bookID = Inserted.MaSach, @NgayTao = Inserted.NgayTao
	FROM Inserted
    -- Inserted
	IF (@NgayTao IS NULL)
	BEGIN
        -- Tự động tạo ngày tạo
		SET @NgayTao = GETDATE()
		UPDATE Sach SET NgayTao = @NgayTao WHERE MaSach = @bookID

        -- Tự động tạo ID
	    SET @bookID = dbo.func_Auto_bookID()
	    UPDATE [Sach] SET MaSach = @bookID WHERE MaSach = 'XX000'
	END
    -- Updated
	ELSE
	BEGIN
        -- Tự động tạo ngày cập nhật
		SET @NgayTao = GETDATE()
		UPDATE dbo.Sach SET NgayTao = @NgayTao WHERE MaSach = @bookID
	END
END
GO
--Kết thúc trigger NgayTao trong bảng Sach

--Trigger NgayTao trong bảng NXB
CREATE TRIGGER trg_Inserted_Updated_NXB
ON dbo.NXB
FOR INSERT, UPDATE
AS
DECLARE @NgayTao DATETIME
DECLARE @NXBID NVARCHAR(10)
BEGIN
	IF TRIGGER_NESTLEVEL() > 1
    RETURN

	SELECT @NXBID = Inserted.MaNXB, @NgayTao = Inserted.NgayTao
	FROM Inserted
    -- Inserted
	IF (@NgayTao IS NULL)
	BEGIN
        -- Tự động tạo ngày tạo
		SET @NgayTao = GETDATE()
		UPDATE NXB SET NgayTao = @NgayTao WHERE MaNXB = @NXBID

        -- Tự động tạo ID
	    SET @NXBID = dbo.func_Auto_NXBID()
	    UPDATE [NXB] SET MaNXB = @NXBID WHERE MaNXB = 'XX000'
	END
    -- Updated
	ELSE
	BEGIN
        -- Tự động tạo ngày cập nhật
		SET @NgayTao = GETDATE()
		UPDATE dbo.NXB SET NgayTao = @NgayTao WHERE MaNXB = @NXBID
	END
END
GO
--Kết thúc trigger NgayTao trong bảng NXB

--Bắt đầu trigger trong bảng Tác giả
CREATE TRIGGER trg_Inserted_Updated_TacGia
ON dbo.TacGia
FOR INSERT, UPDATE
AS
DECLARE @NgayTao DATETIME
DECLARE @TacGiaID NVARCHAR(10)
BEGIN
	IF TRIGGER_NESTLEVEL() > 1
    RETURN

	SELECT @TacGiaID = Inserted.MaTG, @NgayTao = Inserted.NgayTao
	FROM Inserted
    -- Inserted
	IF (@NgayTao IS NULL)
	BEGIN
        -- Tự động tạo ngày tạo
		SET @NgayTao = GETDATE()
		UPDATE TacGia SET NgayTao = @NgayTao WHERE MaTG = @TacGiaID

        -- Tự động tạo ID
	    SET @TacGiaID = dbo.func_Auto_TacGiaID()
	    UPDATE [TacGia] SET MaTG = @TacGiaID WHERE MaTG = 'XX000'
	END
    -- Updated
	ELSE
	BEGIN
        -- Tự động tạo ngày cập nhật
		SET @NgayTao = GETDATE()
		UPDATE dbo.TacGia SET NgayTao = @NgayTao WHERE MaTG = @TacGiaID
	END
END
GO
--Kết thúc bảng trigger NgayTao trong bảng Tác giả

--Bắt đầu bảng trigger trong bảng Ngôn ngữ
CREATE TRIGGER trg_Inserted_Updated_NgonNgu
ON dbo.NgonNgu
FOR INSERT, UPDATE
AS
DECLARE @NgayTao DATETIME
DECLARE @MaNgonNguID NVARCHAR(10)
BEGIN
	IF TRIGGER_NESTLEVEL() > 1
    RETURN

	SELECT @MaNgonNguID = Inserted.MaNgonNgu, @NgayTao = Inserted.NgayTao
	FROM Inserted
    -- Inserted
	IF (@NgayTao IS NULL)
	BEGIN
        -- Tự động tạo ngày tạo
		SET @NgayTao = GETDATE()
		UPDATE NgonNgu SET NgayTao = @NgayTao WHERE MaNgonNgu = @MaNgonNguID

        -- Tự động tạo ID
	    SET @MaNgonNguID = dbo.func_Auto_LanguageID()
	    UPDATE [NgonNgu] SET MaNgonNgu = @MaNgonNguID WHERE MaNgonNgu = 'XX000'
	END
    -- Updated
	ELSE
	BEGIN
        -- Tự động tạo ngày cập nhật
		SET @NgayTao = GETDATE()
		UPDATE dbo.NgonNgu SET NgayTao = @NgayTao WHERE MaNgonNgu = @MaNgonNguID
	END
END
GO
--Kết thúc trigger NgayTao trong bảng Ngôn ngữ

--Bắt đầu trigger NgayTao trong bảng Loại sách
CREATE TRIGGER trg_Inserted_Updated_LoaiSach
ON dbo.LoaiSach
FOR INSERT, UPDATE
AS
DECLARE @NgayTao DATETIME
DECLARE @MaLoaiSachID NVARCHAR(10)
BEGIN
	IF TRIGGER_NESTLEVEL() > 1
    RETURN

	SELECT @MaLoaiSachID = Inserted.MaLoaiSach, @NgayTao = Inserted.NgayTao
	FROM Inserted
    -- Inserted
	IF (@NgayTao IS NULL)
	BEGIN
        -- Tự động tạo ngày tạo
		SET @NgayTao = GETDATE()
		UPDATE LoaiSach SET NgayTao = @NgayTao WHERE MaLoaiSach = @MaLoaiSachID

        -- Tự động tạo ID
	    SET @MaLoaiSachID = dbo.func_Auto_LoaiSachID()
	    UPDATE [LoaiSach] SET MaLoaiSach = @MaLoaiSachID WHERE MaLoaiSach = 'XX000'
	END
    -- Updated
	ELSE
	BEGIN
        -- Tự động tạo ngày cập nhật
		SET @NgayTao = GETDATE()
		UPDATE dbo.LoaiSach SET NgayTao = @NgayTao WHERE MaLoaiSach = @MaLoaiSachID
	END
END
GO
--Kết thúc NgayTao trong bảng Loại sách




