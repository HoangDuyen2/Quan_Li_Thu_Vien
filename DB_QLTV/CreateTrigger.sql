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
GO
CREATE TRIGGER Nhanvien_TrungSDT
ON ThongTinNhanVien
AFTER INSERT, UPDATE
AS
BEGIN
 -- Kiểm tra số điện thoại vừa thêm có bị trùng lặp
	IF EXISTS (
			 SELECT *
			 FROM inserted i
			 WHERE EXISTS (
				 SELECT *
				 FROM ThongTinNhanVien nv
				 WHERE nv.SDT = i.SDT AND nv.MaNV <> i.MaNV
			 ))
	 BEGIN
		 -- Nếu trùng thì rollback
		 --PRINT N'Số điện thoại đã tồn tại'
		 ROLLBACK;
	 END
END
--Kết thúc kiểm tra số điện thoại của nhân viên

--Trigger NgayTao trong bảng NhanVien
CREATE TRIGGER trg_Inserted_Updated_NhanVien
ON Sach
FOR INSERT, UPDATE
AS
DECLARE @NgayTao DATETIME
DECLARE @nhanVienID NVARCHAR(10)
BEGIN
	IF TRIGGER_NESTLEVEL() > 1
    RETURN

	SELECT @nhanVienID = Inserted.MaNV, @NgayTao = Inserted.NgayTao
	FROM Inserted
    -- Inserted
	IF (@NgayTao IS NULL)
	BEGIN
        -- Tự động tạo ngày tạo
		SET @NgayTao = GETDATE()
		UPDATE NhanVien SET NgayTao = @NgayTao WHERE MaNV = @nhanVienID

        -- Tự động tạo ID
	    SET @nhanVienID = dbo.func_Auto_NhanVienID()
	    UPDATE [NhanVien] SET MaNV = @nhanVienID WHERE MaNV = 'XX000'
	END
    -- Updated
	ELSE
	BEGIN
        -- Tự động tạo ngày cập nhật
		SET @NgayTao = GETDATE()
		UPDATE dbo.NhanVien SET NgayTao = @NgayTao WHERE MaNV = @nhanVienID
	END
END
GO
--Kết thúc trigger NgayTao trong bảng NhanVien
		 
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

--Bắt đầu trigger kiểm tra số lượng sách còn lại trong bảng Chi tiết phiếu mượn trả
CREATE TRIGGER KiemTraSoLuongSachConLai
ON ChiTietPhieuMuonTra
INSTEAD OF INSERT
AS
BEGIN
 -- Kiểm tra số lượng sách còn lại
	DECLARE @SoLuongTon INT;
	SELECT @SoLuongTon = Sach.SoLuongTon
	FROM Sach
	WHERE Sach.MaSach IN (SELECT inserted.MaSach FROM inserted);
	 -- 
	IF @SoLuongTon > 1
	BEGIN
 -- Nếu còn sách thêm phiếu mượn vào PhieuMuonTra
		INSERT INTO ChiTietPhieuMuonTra (MaPhieuMuonTra, MaSach, TinhTrang, NgayTra)
		SELECT MaPhieuMuonTra, MaSach, TinhTrang, NgayTra
		FROM inserted;
 
 -- Cập nhật sô lượng sách
		UPDATE Sach
		SET SoLuongTon = SoLuongTon - 1
		WHERE Sach.MaSach IN (SELECT inserted.MaSach FROM inserted);
	END
	ELSE
		BEGIN
	 -- Nếu không còn sách, không thêm phiếu mượn và thông báo lỗi
			RAISERROR ('Số Lượng sách không đủ để mượn' , 16, 1)
			ROLLBACK;
		END
END
--Kết thúc trigger kiểm tra số lượng sách còn lại trong bảng Chi tiết phiếu mượn trả

--Bắt đầu trigger kiểm tra nhân viên
GO
CREATE TRIGGER CheckNV
ON ThongTinNhanVien
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE NgaySinh < '1900-01-01'
    )
    BEGIN
        RAISERROR('Ngày sinh không hợp lệ', 16, 1);
        ROLLBACK;
        RETURN;
    END

    IF EXISTS (
        SELECT 1
        FROM INSERTED i
        WHERE LEN(i.SDT) <> 10 OR i.SDT NOT LIKE '[0-9]%'
    )
    BEGIN
        RAISERROR('Số điện thoại không hợp lệ', 16, 1);
        ROLLBACK;
        RETURN;
    END

    PRINT 'Cập nhật thành công';
END;
--Kết thúc trigger kiểm tra nhân viên khi cập nhật/Chèn dữ liệu

--Bắt đầu trigger Cập nhật số lượng sách khi nhập sách
CREATE TRIGGER CapNhatSachKhiNhap
ON ChiTietPhieuNhap
AFTER INSERT
AS
BEGIN
    UPDATE Sach
    SET SoLuongSach = Sach.SoLuongSach + i.SL
    FROM Sach
    INNER JOIN inserted i ON Sach.MaSach = i.MaSach;
END;
--Kết thúc trigger Cập nhật số lượng sách khi nhập sách

--Kiểm tra phiếu phạt khi trả sách 
GO
CREATE TRIGGER UpdateStock_AfterLoanUpdate
ON ChiTietPhieuMuonTra
AFTER UPDATE
AS
BEGIN
    DECLARE @MaSach nchar(10);
    DECLARE @OldTrangThai nvarchar(255);
    DECLARE @NewTrangThai nvarchar(255);
    DECLARE @HasFine BIT;

    SELECT
        @MaSach = i.MaSach,
        @OldTrangThai = d.TinhTrang,
        @NewTrangThai = i.TinhTrang,
        @HasFine = (CASE WHEN EXISTS(SELECT 1 FROM PhieuPhat pp WHERE pp.MaPhieuMuonTra = i.MaPhieuMuonTra) THEN 1 ELSE 0 END)
    FROM
        INSERTED i
    JOIN
        DELETED d ON i.MaPhieuMuonTra = d.MaPhieuMuonTra;

    IF @OldTrangThai != @NewTrangThai AND @HasFine = 0
    BEGIN
        IF @OldTrangThai = N'Đang mượn' AND @NewTrangThai = N'Đã trả'
        BEGIN
            UPDATE Sach
            SET SoLuongTon = SoLuongTon + 1
            WHERE MaSach = @MaSach;
        END
        ELSE IF @OldTrangThai = N'Đã trả' AND @NewTrangThai = N'Đang mượn'
        BEGIN
            UPDATE Sach
            SET SoLuongTon = SoLuongTon - 1
            WHERE MaSach = @MaSach;
        END;
    END;
END;
--Kiểm tra phiếu phạt khi trả sách 

--Bắt đầu trigger NCC trong bảng CungCap
CREATE TRIGGER trg_Inserted_Updated_CungCap
ON dbo.CungCap
FOR INSERT, UPDATE
AS
DECLARE @NgayTao DATETIME
DECLARE @MaCungCapID NVARCHAR(10)
BEGIN
	IF TRIGGER_NESTLEVEL() > 1
    RETURN

	SELECT @MaCungCapID = Inserted.MaNhaCC, @NgayTao = Inserted.NgayTao
	FROM Inserted
    -- Inserted
	IF (@NgayTao IS NULL)
	BEGIN
        -- Tự động tạo ngày tạo
		SET @NgayTao = GETDATE()
		UPDATE CungCap SET NgayTao = @NgayTao WHERE MaNhaCC = @MaCungCapID

        -- Tự động tạo ID
	    SET @MaCungCapID = dbo.func_Auto_CungCapID()
	    UPDATE [CungCap] SET MaNhaCC = @MaCungCapID WHERE MaNhaCC = 'XX000'
	END
    -- Updated
	ELSE
	BEGIN
        -- Tự động tạo ngày cập nhật
		SET @NgayTao = GETDATE()
		UPDATE dbo.CungCap SET NgayTao = @NgayTao WHERE MaNhaCC = @MaCungCapID
	END
END
GO


--Bắt đầu trigger phiếu nhập trong bảng PhieuNhap
CREATE TRIGGER trg_Inserted_Updated_PhieuNhap
ON dbo.PhieuNhap
FOR INSERT, UPDATE
AS
DECLARE @NgayTao DATETIME
DECLARE @MaPhieuNhapID NVARCHAR(10)
BEGIN
	IF TRIGGER_NESTLEVEL() > 1
    RETURN

	SELECT @MaPhieuNhapID = Inserted.MaPhieuNhap, @NgayTao = Inserted.NgayTao
	FROM Inserted
    -- Inserted
	IF (@NgayTao IS NULL)
	BEGIN
        -- Tự động tạo ngày tạo
		SET @NgayTao = GETDATE()
		UPDATE PhieuNhap SET NgayTao = @NgayTao WHERE MaPhieuNhap = @MaPhieuNhapID

        -- Tự động tạo ID
	    SET @MaPhieuNhapID = dbo.func_Auto_PhieuNhapID()
	    UPDATE [PhieuNhap] SET MaPhieuNhap = @MaPhieuNhapID WHERE MaPhieuNhap = 'XX000'
	END
    -- Updated
	ELSE
	BEGIN
        -- Tự động tạo ngày cập nhật
		SET @NgayTao = GETDATE()
		UPDATE dbo.PhieuNhap SET NgayTao = @NgayTao WHERE MaPhieuNhap = @MaPhieuNhapID
	END
END
GO

//

