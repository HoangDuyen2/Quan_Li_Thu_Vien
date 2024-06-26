--Tổ Sách
--Bắt đầu thêm Sách mới
CREATE PROCEDURE InsertBook (@TenSach nvarchar(50),
								@TenNXB nvarchar(50),
								@TenLoaiSach nvarchar(50),
								@TenNgonNgu nvarchar(50),
								@NamXB int,
								@SoLuongTon varchar(10),
								@SoLuongSach varchar(50))
AS
BEGIN
	BEGIN TRANSACTION Tran_InsertBook
	BEGIN TRY
		DECLARE @MaNXB NVARCHAR(10)
		SET @MaNXB = (SELECT @TenNXB FROM NXB WHERE @TenNXB = NXB.TenNXB)
		DECLARE @MaLoaiSach NVARCHAR(10)
		SET @MaLoaiSach = (SELECT @TenLoaiSach FROM LoaiSach WHERE @TenLoaiSach = LoaiSach.TenLoaiSach)
		DECLARE @MaNgonNgu NVARCHAR(10)
		SET @MaNgonNgu = (SELECT @TenNgonNgu FROM NgonNgu WHERE @TenNgonNgu = NgonNgu.TenNgonNgu)

		INSERT INTO dbo.Sach(TenSach, MaNXB, MaLoaiSach, MaNgonNgu, NamXB, SoLuongTon, SoLuongSach)
		VALUES (@TenSach, @MaNXB, @MaLoaiSach, @MaNgonNgu, @NamXB, @SoLuongTon, @SoLuongSach)

		COMMIT TRANSACTION Tran_InsertBook
    END TRY
	BEGIN CATCH
		PRINT('Thêm không thành công!')
		COMMIT TRANSACTION Tran_InsertBook
	END CATCH
END
GO
--Kết thúc thêm sách mới

--Bắt đầu sửa sách
CREATE PROCEDURE [dbo].[proc_suaSach]
	@MaSach nvarchar(10),
	@TenSach nvarchar(50),
	@TenNXB nvarchar(255),
	@TenLoaiSach nvarchar(50),
	@NamXB int,
	@TenNgonNgu nvarchar(50),
	@SoLuongTon int,
	@SoLuongSach int,
	@TenTGNew nvarchar(50),
	@TenTGOld nvarchar(50)
AS
BEGIN
	BEGIN TRY
	-- Thêm mới sản phẩm
		DECLARE @MaNXB nvarchar(10)
		SELECT @MaNXB = MaNXB
		FROM NXB
		WHERE TenNXB = @TenNXB

		DECLARE @MaLoaiSach nvarchar(10)
		SELECT @MaLoaiSach = MaLoaiSach
		FROM LoaiSach
		WHERE TenLoaiSach = @TenLoaiSach

		DECLARE @MaNgonNgu nvarchar(10)
		SELECT @MaNgonNgu = MaNgonNgu
		FROM NgonNgu
		WHERE TenNgonNgu = @TenNgonNgu

		DECLARE @MaTGNew nvarchar(10)
		SELECT @MaTGNew = MaTG
		FROM TacGia
		WHERE @TenTGNew = TenTG

		DECLARE @MaTGOld nvarchar(10)
		SELECT @MaTGOld = MaTG
		FROM TacGia
		WHERE @TenTGOld = TenTG

		UPDATE dbo.Sach SET TenSach = @TenSach, NamXB = @NamXB, SoLuongTon = @SoLuongTon, SoLuongSach = @SoLuongSach,MaNXB = @MaNXB,
							MaLoaiSach = @MaLoaiSach, MaNgonNgu = @MaNgonNgu
		WHERE MaSach = @MaSach

	
		DELETE FROM TacGiaSach WHERE MaSach = @MaSach AND MaTG = @MaTGOld

		INSERT INTO TacGiaSach(MaTG, MaSach) VALUES (@MaTGNew, @MaSach)
	END TRY
	BEGIN CATCH
	DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
	END CATCH
END
--Kết thúc sửa sách

--Bắt đầu thêm tác giả
CREATE PROCEDURE [dbo].[InsertTacGia] 
    @TenTG nvarchar(50),
    @GioiTinh nvarchar(1),
    @NamSinh int,
    @NamMat int,
    @QueQuan nvarchar(255)
AS
BEGIN
    BEGIN TRANSACTION Tran_InsertTacGia
    BEGIN TRY
        DECLARE @LastID NVARCHAR(10)
        SELECT @LastID = MAX(MaTG) FROM dbo.TacGia

        DECLARE @NextID NVARCHAR(10)
        SET @NextID = LEFT(@LastID, LEN(@LastID) - 1) + CAST((CAST(RIGHT(@LastID, 1) AS INT) + 1) AS NVARCHAR(1))

        INSERT INTO dbo.TacGia (MaTG, TenTG, GioiTinh, NamSinh, NamMat, QueQuan)
        VALUES (@NextID, @TenTG, @GioiTinh, @NamSinh, @NamMat, @QueQuan)
        
        COMMIT TRANSACTION Tran_InsertTacGia
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
        SELECT @err = N'Lỗi: ' + ERROR_MESSAGE()
        RAISERROR(@err, 16, 1)
        ROLLBACK TRANSACTION Tran_InsertTacGia
    END CATCH
END
--Kết thúc thêm tác giả

--Bắt đầu sửa tác giả
CREATE PROCEDURE pro_UpdateTacGia (@MaTG nvarchar(10),
								@TenTacGia nvarchar(50),
								@GioiTinh nvarchar(1),
								@NamSinh int,
								@NamMat int,
								@QueQuan nvarchar(50))
AS
BEGIN
	BEGIN TRANSACTION Tran_UpdateTacGia
	BEGIN TRY
		UPDATE dbo.TacGia SET TenTG = @TenTacGia,
							  GioiTinh = @GioiTinh,
							  NamSinh = @NamSinh,
							  NamMat = @NamMat,
							  QueQuan = @QueQuan
		WHERE MaTG = @MaTG

		COMMIT TRANSACTION Tran_UpdateTacGia
	END TRY
	BEGIN CATCH
		PRINT('Cập nhật không thành công')
		ROLLBACK TRANSACTION Tran_UpdateTacGia
	END CATCH
END
--Kết thúc sửa tác giả

--Bắt đầu thêm nhà xuất bản
CREATE PROCEDURE [dbo].[pro_InsertNXB] 
    @TenNXB nvarchar(50),
    @DiaChi nvarchar(255),
    @SDT nvarchar(11)
AS
BEGIN
    BEGIN TRANSACTION Tran_InsertNXB
    BEGIN TRY
        DECLARE @LastID NVARCHAR(10)
        SELECT @LastID = MAX(MaNXB) FROM dbo.NXB

        DECLARE @NextID NVARCHAR(10)
		SET @NextID = LEFT(@LastID, LEN(@LastID) - 3) + RIGHT('000' + CAST(CAST(RIGHT(@LastID, 3) AS INT) + 1 AS NVARCHAR), 3);

        INSERT INTO dbo.NXB(MaNXB, TenNXB, DiaChi, SDT)
        VALUES (@NextID, @TenNXB, @DiaChi, @SDT)
        
        COMMIT TRANSACTION Tran_InsertNXB
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
        SELECT @err = N'Lỗi: ' + ERROR_MESSAGE()
        RAISERROR(@err, 16, 1)
        ROLLBACK TRANSACTION Tran_InsertNXB
    END CATCH
END
--Kết thúc thêm nhà xuất bản

--Bắt đầu sửa nhà xuất bản
CREATE PROCEDURE pro_UpdateNXB (@MaNXB nvarchar(10),
								@TenNXB nvarchar(50),
								@DiaChi nvarchar(255),
								@SDT nvarchar(11))
AS
BEGIN
	BEGIN TRANSACTION Tran_UpdateNXB
	BEGIN TRY
		UPDATE dbo.NXB SET TenNXB = @TenNXB,
						   DiaChi = @DiaChi,
						   SDT = @SDT
						WHERE MaNXB = @MaNXB

		COMMIT TRANSACTION Tran_UpdateNXB
	END TRY
	BEGIN CATCH
		PRINT('Cập nhật không thành công')
		ROLLBACK TRANSACTION Tran_UpdateNXB
	END CATCH
END
--Kết thúc sửa nhà xuất bản

--Bắt đầu thêm Ngôn ngữ
CREATE PROCEDURE [dbo].[pro_InsertNgonNgu] 
    @TenNN nvarchar(50)
AS
BEGIN
    BEGIN TRANSACTION Tran_InsertNgonNgu
    BEGIN TRY
        DECLARE @LastID NVARCHAR(10)
        SELECT @LastID = MAX(MaNgonNgu) FROM dbo.NgonNgu

        DECLARE @NextID NVARCHAR(10)
		SET @NextID = LEFT(@LastID, LEN(@LastID) - 3) + RIGHT('000' + CAST(CAST(RIGHT(@LastID, 3) AS INT) + 1 AS NVARCHAR), 3);

        INSERT INTO dbo.NgonNgu(MaNgonNgu, TenNgonNgu)
        VALUES (@NextID, @TenNN)
        
        COMMIT TRANSACTION Tran_InsertNgonNgu
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
        SELECT @err = N'Lỗi: ' + ERROR_MESSAGE()
        RAISERROR(@err, 16, 1)
        ROLLBACK TRANSACTION Tran_InsertNgonNgu
    END CATCH
END
--Kết thúc thêm ngôn ngữ

--Bắt đầu thêm loại sách
CREATE PROCEDURE [dbo].[pro_InsertLoaiSach] 
    @TenLS nvarchar(50)
AS
BEGIN
    BEGIN TRANSACTION Tran_InsertLoaiSach
    BEGIN TRY
        DECLARE @LastID NVARCHAR(10)
        SELECT @LastID = MAX(MaLoaiSach) FROM dbo.LoaiSach

        DECLARE @NextID NVARCHAR(10)
		SET @NextID = LEFT(@LastID, LEN(@LastID) - 3) + RIGHT('000' + CAST(CAST(RIGHT(@LastID, 3) AS INT) + 1 AS NVARCHAR), 3);

        INSERT INTO dbo.LoaiSach(MaLoaiSach, TenLoaiSach)
        VALUES (@NextID, @TenLS)
        
        COMMIT TRANSACTION Tran_InsertLoaiSach
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
        SELECT @err = N'Lỗi: ' + ERROR_MESSAGE()
        RAISERROR(@err, 16, 1)
        ROLLBACK TRANSACTION Tran_InsertLoaiSach
    END CATCH
END
--Kết thúc thêm loại sách
--Kết thúc tổ Sách

--Tổ nhập sách
--Thêm nhà cung cấp
CREATE PROCEDURE [dbo].[pro_InsertNCC] 
    @TenNCC nvarchar(50),
    @DiaChi nvarchar(255),
    @SDT nvarchar(11)
AS
BEGIN
    BEGIN TRANSACTION Tran_InsertNCC
    BEGIN TRY
        DECLARE @LastID NVARCHAR(10)
        SELECT @LastID = MAX(MaNhaCC) FROM dbo.CungCap

        DECLARE @NextID NVARCHAR(10)
		SET @NextID = LEFT(@LastID, LEN(@LastID) - 3) + RIGHT('000' + CAST(CAST(RIGHT(@LastID, 3) AS INT) + 1 AS NVARCHAR), 3);

        INSERT INTO dbo.CungCap(MaNhaCC, TenNhaCC, DiaChi, SoDienThoai)
        VALUES (@NextID, @TenNCC, @DiaChi, @SDT)
        
        COMMIT TRANSACTION Tran_InsertNCC
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
        SELECT @err = N'Lỗi: ' + ERROR_MESSAGE()
        RAISERROR(@err, 16, 1)
        ROLLBACK TRANSACTION Tran_InsertNCC
    END CATCH
END
--Kết thúc thêm nhà cung cấp

--Sửa nhà cung cấp
CREATE PROCEDURE pro_UpdateNCC (@MaNCC nvarchar(10),
								@TenNCC nvarchar(50),
								@DiaChi nvarchar(255),
								@SDT nvarchar(11))
AS
BEGIN
	BEGIN TRANSACTION Tran_UpdateNCC
	BEGIN TRY
		UPDATE dbo.CungCap SET TenNhaCC = @TenNCC,
						   DiaChi = @DiaChi,
						   SoDienThoai = @SDT
						WHERE MaNhaCC = @MaNCC

		COMMIT TRANSACTION Tran_UpdateNCC
	END TRY
	BEGIN CATCH
		PRINT('Cập nhật không thành công')
		ROLLBACK TRANSACTION Tran_UpdateNCC
	END CATCH
END
--Kết thúc sửa nhà cung cấp

--Thêm Phiếu nhập
CREATE Procedure InsertPhieuNhap(
    @NgayNhap DATE,
    @GiaTriDonHang INT,
	@TenNhaCC NVARCHAR(50)
)
AS
BEGIN
    BEGIN TRANSACTION Tran_InsertPhieuNhap
	BEGIN TRY
		DECLARE @MaNCC NVARCHAR(10)
		SELECT @MaNCC = MaNhaCC FROM CungCap WHERE TenNhaCC = @TenNhaCC

		DECLARE @LastID NVARCHAR(10)
        SELECT @LastID = MAX(MaPhieuNhap) FROM dbo.PhieuNhap

        DECLARE @NextID NVARCHAR(10)
		SET @NextID = LEFT(@LastID, LEN(@LastID) - 3) + RIGHT('000' + CAST(CAST(RIGHT(@LastID, 3) AS INT) + 1 AS NVARCHAR), 3);

		INSERT INTO dbo.PhieuNhap(MaPhieuNhap, NgayNhap, GiaTriDonHang, MaNhaCC, NgayTao)
		VALUES (@NextID, @NgayNhap, @GiaTriDonHang, @MaNCC,GETDATE())

		COMMIT TRANSACTION Tran_InsertPhieuNhap
    END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION Tran_InsertPhieuNhap
		PRINT('Thêm không thành công!')
	END CATCH
END
--Kết thúc thêm phiếu nhập

--Bắt đầu sửa phiếu nhập
CREATE Procedure UpdatePhieuNhap(
    @MaPhieuNhap NVARCHAR(10),
	@NgayNhap DATETIME,
    @GiaTriDonHang FLOAT,
	@TenNCC NVARCHAR(50)
)
AS
BEGIN
    BEGIN TRANSACTION Tran_UpdatePhieuNhap
	BEGIN TRY
		DECLARE @MaNCC NVARCHAR(10)
		SELECT @MaNCC = MaNhaCC FROM CungCap WHERE TenNhaCC = @TenNCC

		UPDATE dbo.PhieuNhap SET MaNhaCC = @MaNCC
						WHERE MaPhieuNhap = @MaPhieuNhap

		COMMIT TRANSACTION Tran_UpdatePhieuNhap
    END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION Tran_UpdatePhieuNhap
		PRINT('Thêm không thành công!')
	END CATCH
END			
--Kết thúc sửa phiếu nhập

--Bắt đầu xóa phiếu nhập
CREATE PROCEDURE [dbo].[proc_xoaPhieuNhap]
    @MaPhieuNhap NVARCHAR(10)
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        DECLARE @SoPhieu INT, @i INT;
        SELECT @SoPhieu = COUNT(MaSach)
        FROM ChiTietPhieuNhap
        WHERE MaPhieuNhap = @MaPhieuNhap;
        
        SET @i = 1;
        WHILE @i <= @SoPhieu
        BEGIN
            DECLARE @MaSach NVARCHAR(10);
            SELECT TOP 1 @MaSach = MaSach
            FROM ChiTietPhieuNhap
            WHERE MaPhieuNhap = @MaPhieuNhap

            DECLARE @SL INT;
            SELECT @SL = SL
            FROM ChiTietPhieuNhap
            WHERE MaPhieuNhap = @MaPhieuNhap AND MaSach = @MaSach;

            UPDATE dbo.Sach
            SET SoLuongTon = SoLuongTon - @SL,
                SoLuongSach = SoLuongSach - @SL
            WHERE MaSach = @MaSach;

            DELETE FROM dbo.ChiTietPhieuNhap
            WHERE MaPhieuNhap = @MaPhieuNhap AND MaSach = @MaSach;

            SET @i = @i + 1;
        END

        DELETE FROM dbo.PhieuNhap
        WHERE MaPhieuNhap = @MaPhieuNhap;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        DECLARE @err NVARCHAR(MAX);
        SELECT @err = N'Lỗi: ' + ERROR_MESSAGE();
        RAISERROR(@err, 16, 1);
    END CATCH
END
--Kết thúc xóa phiếu nhập

--Thêm chi tiết phiếu nhập
CREATE Procedure InsertChiTietPhieuNhap(
    @MaPhieuNhap NVARCHAR(10),
	@TenSach NVARCHAR(50),
    @DonGia INT,
	@SL INT
)
AS
BEGIN
    BEGIN TRANSACTION Tran_InsertChiTietPhieuNhap
	BEGIN TRY
		DECLARE @MaSach NVARCHAR(10)
		SELECT @MaSach = MaSach FROM Sach WHERE TenSach = @TenSach

		INSERT INTO dbo.ChiTietPhieuNhap(MaPhieuNhap, MaSach, DonGia, SL)
		VALUES (@MaPhieuNhap, @MaSach, @DonGia, @SL)

		COMMIT TRANSACTION Tran_InsertChiTietPhieuNhap
    END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION Tran_InsertChiTietPhieuNhap
		PRINT('Thêm không thành công!')
	END CATCH
END
--Kết thúc thêm chi tiết phiếu nhập

--Sửa chi tiết phiếu nhập
CREATE Procedure UpdateChiTietPhieuNhap(
    @MaPhieuNhap NVARCHAR(10),
	@TenSach NVARCHAR(50),
    @DonGia INT,
	@SLCu INT,
	@SL INT
)
AS
BEGIN
    BEGIN TRANSACTION Tran_UpdateChiTietPhieuNhap
	BEGIN TRY
		DECLARE @MaSach NVARCHAR(10)
		SELECT @MaSach = MaSach FROM Sach WHERE TenSach = @TenSach

		UPDATE dbo.ChiTietPhieuNhap SET DonGia = @DonGia,
						   SL = @SL
						WHERE MaPhieuNhap = @MaPhieuNhap AND MaSach = @MaSach
		UPDATE dbo.Sach SET SoLuongSach = SoLuongSach - @SLCu + @SL,
							SoLuongTon = SoLuongTon - @SLCu + @SL
						WHERE MaSach = @MaSach

		COMMIT TRANSACTION Tran_UpdateChiTietPhieuNhap
    END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION Tran_UpdateChiTietPhieuNhap
		PRINT('Thêm không thành công!')
	END CATCH
END
--Kết thúc cập nhật chi tiết phiếu nhập

--Bắt đầu xóa chi tiết phiếu nhập
CREATE PROCEDURE [dbo].[proc_xoaChiTietPhieuNhap](
	@MaPhieuNhap NVARCHAR(10),
	@TenSach NVARCHAR(50))
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		DECLARE @MaSach NVARCHAR(10)
		SELECT @MaSach = MaSach FROM Sach WHERE TenSach = @TenSach

		DECLARE @SL FLOAT, @DonGia FLOAT
		SELECT @SL = SL, @DonGia = DonGia FROM ChiTietPhieuNhap WHERE MaSach = @MaSach AND MaPhieuNhap = @MaPhieuNhap

		IF (@SL * @DonGia <= (SELECT GiaTriDonHang FROM dbo.PhieuNhap WHERE MaPhieuNhap = @MaPhieuNhap))
		BEGIN
			UPDATE dbo.PhieuNhap  SET GiaTriDonHang = GiaTriDonHang - (@SL * @DonGia) WHERE MaPhieuNhap = @MaPhieuNhap
			UPDATE dbo.Sach SET SoLuongTon = SoLuongTon - @SL, SoLuongSach = SoLuongSach - @SL WHERE MaSach = @MaSach
			DELETE FROM dbo.ChiTietPhieuNhap WHERE MaPhieuNhap = @MaPhieuNhap AND MaSach = @MaSach
		END
		ELSE
		BEGIN
			RAISERROR ('Giá trị GiaTriDonHang không thể âm.', 16, 1)
		END

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK
		DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi: ' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
	END CATCH
END
--Kết thúc xóa chi tiết phiếu nhập
--Kết thúc tổ Nhập sách

--Tổ Sách
	    
--Bắt đầu sửa nhân viên mới
CREATE PROCEDURE UpdateStaff (@TenNV nvarchar(32),
								@GioiTinh nvarchar(1),
								@NgaySinh DATETIME,
								@DiaChi nvarchar(255),
								@SDT varchar(10),
								@Email varchar(50),
AS
BEGIN
	BEGIN TRANSACTION Tran_UpdateStaff
	BEGIN TRY
		UPDATE dbo.ThongTinNhanVien SET TenNV = @TenNV,
					GioiTinh = @GioiTinh,
					NgaySinh = @NgaySinh,
					DiaChi = @DiaChi,
					SDT = @SDT,
					Email = @Email,

		WHERE MaNV = @MaNV
		COMMIT TRANSACTION Tran_UpdateStaff
	END TRY
	BEGIN CATCH
		PRINT('Sửa không thành công')
		ROLLBACK TRANSACTION Tran_UpdateStaff
	END CATCH
END
GO
--Kết Thúc Procedure sửa nhân viên

--bắt đầu thêm độc giả mới
CREATE PROCEDURE InsertDocGia
    @TenDocGia NVARCHAR(50),
    @Email NVARCHAR(50),
    @SoDienThoai NVARCHAR(20),
    @GioiTinh NCHAR(1),
    @MaLoaiDG NVARCHAR(10)
AS
BEGIN
    BEGIN TRANSACTION Tran_InsertDocGia
	BEGIN TRY
		DECLARE @NgayTao DATE = CAST(GETDATE() AS DATE);
		DECLARE @MaDocGia NVARCHAR(10) = [dbo].func_Auto_DocGiaID();

		-- Thêm độc giả mới
		INSERT INTO DocGia (MaDocGia, TenDocGia, Email, SoDienThoai, GioiTinh, MaLoaiDG, NgayTao)
		VALUES (@MaDocGia, @TenDocGia, @Email, @SoDienThoai, @GioiTinh, @MaLoaiDG, @NgayTao);

		COMMIT TRANSACTION Tran_InsertDocGia
    END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION Tran_InsertDocGia
		PRINT('Thêm không thành công!')
	END CATCH
END
--kết thúc thêm đọc giả


--bắt đầu sửa độc giả mới
CREATE PROCEDURE UpdateDocGia
    @MaDocGia NVARCHAR(10),
    @TenDocGia NVARCHAR(50),
    @Email NVARCHAR(50),
    @SoDienThoai NVARCHAR(20),
    @GioiTinh NCHAR(1),
    @MaLoaiDG NVARCHAR(10)
AS
BEGIN

	BEGIN TRANSACTION Tran_UpdateDocGia
	BEGIN TRY
	UPDATE DocGia
		SET TenDocGia = @TenDocGia,
			Email = @Email,
			SoDienThoai = @SoDienThoai,
			GioiTinh = @GioiTinh,
			MaLoaiDG = @MaLoaiDG
		WHERE MaDocGia = @MaDocGia;

		COMMIT TRANSACTION Tran_UpdateDocGia
	END TRY
	BEGIN CATCH
		PRINT('Cập nhật không thành công')
		ROLLBACK TRANSACTION Tran_UpdateDocGia
	END CATCH
END
--kết thúc sửa đọc giả

--Xóa DocGia
CREATE PROCEDURE DeleteDocGia
    @MaDocGia NVARCHAR(10)
AS
BEGIN
	BEGIN TRANSACTION Tran_DeleteDocGia
	BEGIN TRY
	-- Delete related records from PhieuMuonTra table
    DELETE FROM PhieuMuonTra
    WHERE MaDocGia = @MaDocGia;

    -- Delete record from DocGia table
    DELETE FROM DocGia
    WHERE MaDocGia = @MaDocGia;

		COMMIT TRANSACTION Tran_DeleteDocGia
	END TRY
	BEGIN CATCH
		PRINT('Cập nhật không thành công')
		ROLLBACK TRANSACTION Tran_DeleteDocGia
	END CATCH
END
--End xóa DocGia
	
--Tìm kiếm nhân viên theo tổ
CREATE PROCEDURE NhanVienTheoTo
    @MaTo nvarchar(10)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaTo = @MaTo)
    BEGIN
        RAISERROR('Mã Tổ không tồn tại', 16, 1);
        RETURN;
    END

    SELECT 
        ttnv.MaNV, ttnv.TenNV, ttnv.GioiTinh, ttnv.NgaySinh, ttnv.Luong, 
        ttnv.DiaChi, ttnv.SDT, ttnv.Email, ttnv.NgayTao
    FROM ThongTinNhanVien ttnv
    INNER JOIN NhanVien nv ON ttnv.MaNV = nv.MaNV
    WHERE nv.MaTo = @MaTo;
END
GO
-- End Tìm kiếm nhân viên theo tổ
	
--Insert PMT
CREATE Procedure InsertPhieuMuonTra(
    @MaNV VARCHAR(10),
    @MaDocGia VARCHAR(10),
    @HanTra DATE
)
AS
BEGIN
    -- Kiểm tra mã nhân viên và mã độc giả đã tồn tại chưa
	 DECLARE @newID NVARCHAR(10)
        SET @newID = dbo.func_Auto_PhieuMuonTraID()
    IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaNV = @MaNV)
        RETURN 'Mã nhân viên không tồn tại'
    IF NOT EXISTS (SELECT 1 FROM DocGia WHERE MaDocGia = @MaDocGia)
        RETURN 'Mã độc giả không tồn tại'
    INSERT INTO PhieuMuonTra (MaPhieuMuonTra,MaNV, MaDocGia,NgayMuon, HanTra)
    VALUES (@newID,@MaNV, @MaDocGia,GETDATE(), @HanTra)
END
--END Insert ChiTietPhieuMuonTra

--Update PMT
CREATE Procedure UpdatePhieuMuonTra(
    @MaPhieuMuonTra nvarchar(10),
    @MaDocGia VARCHAR(10),
    @HanTra DATE
)
AS
BEGIN
    -- Kiểm tra mã nhân viên và mã độc giả đã tồn tại chưa
     IF NOT EXISTS (SELECT 1 FROM PhieuMuonTra WHERE MaPhieuMuonTra=@MaPhieuMuonTra)
        RETURN 'Mã phiếu mượn trả không tồn tại'
    IF NOT EXISTS (SELECT 1 FROM DocGia WHERE MaDocGia = @MaDocGia)
        RETURN 'Mã độc giả không tồn tại'
    UPDATE PhieuMuonTra
	SET MaDocGia=@MaDocGia,HanTra=@HanTra
    WHERE MaPhieuMuonTra=@MaPhieuMuonTra
END
--END Update PhieuMuonTra

--Delete PMT
CREATE PROCEDURE DeletePhieuMuonTra
    @mapmt nvarchar(10)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION;

    -- Xóa các bản ghi liên quan trong bảng ChiTietPhieuPhat
    DELETE FROM ChiTietPhieuPhat
    WHERE MaPhieuPhat IN (
        SELECT MaPhieuPhat
        FROM PhieuPhat
        WHERE MaPhieuMuonTra = @mapmt
    );

    -- Xóa các bản ghi liên quan trong bảng PhieuPhat
    DELETE FROM PhieuPhat
    WHERE MaPhieuMuonTra = @mapmt;

    -- Xóa các bản ghi liên quan trong bảng ChiTietPhieuMuonTra
    DELETE FROM ChiTietPhieuMuonTra
    WHERE MaPhieuMuonTra = @mapmt;

    -- Xóa bản ghi trong bảng PhieuMuonTra
    DELETE FROM PhieuMuonTra
    WHERE MaPhieuMuonTra = @mapmt;

    COMMIT TRANSACTION;
END
--End Delete PMT

--Insert PhieuPhat
CREATE PROCEDURE InsertPhieuPhat
    @MaPhieuMuonTra VARCHAR(20),
    @MaSach VARCHAR(20)
AS
BEGIN

	BEGIN TRANSACTION Tran_InsertPhieuPhat
	BEGIN TRY
		DECLARE @MaPhieuPhat VARCHAR(20)
    DECLARE @NgayXuatPhieu DATE
    SET @MaPhieuPhat = dbo.func_Auto_PhieuPhatID()
    SET @NgayXuatPhieu = CAST(GETDATE() AS DATE)

    IF EXISTS (SELECT 1 FROM ChiTietPhieuMuonTra WHERE MaPhieuMuonTra = @MaPhieuMuonTra AND MaSach = @MaSach)
    BEGIN
        INSERT INTO PhieuPhat (MaPhieuPhat, MaPhieuMuonTra, MaSach, NgayXuatPhieu, TongTien)
        VALUES (@MaPhieuPhat, @MaPhieuMuonTra, @MaSach, @NgayXuatPhieu, 0)
    END
    ELSE
    BEGIN
        RAISERROR('Mã sách không tồn tại trong phiếu mượn trả.', 16, 1)
        RETURN
    END

		COMMIT TRANSACTION Tran_InsertPhieuPhat
    END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION Tran_InsertPhieuPhat
		PRINT('Thêm không thành công!')
	END CATCH
END
--End Insert PhieuPhat

--Đã trả Chi tiết Phiếu mượn trả	    
CREATE PROCEDURE DaTraChiTietPhieuMuonTra
    @MaPhieuMuonTra VARCHAR(20),
    @MaSach VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @NgayTra DATE

    SET @NgayTra = CAST(GETDATE() AS DATE)

    IF @MaSach IS NOT NULL
    BEGIN
        UPDATE ChiTietPhieuMuonTra
        SET TinhTrang = 'Đã trả',
            NgayTra = @NgayTra
        WHERE MaPhieuMuonTra = @MaPhieuMuonTra
          AND MaSach = @MaSach
    END
    ELSE
    BEGIN
        RAISERROR('Không tìm thấy mã sách đã nhập trong PMT này', 16, 1)
        RETURN
    END
END
GO
--End Đã trả Chi tiết Phiếu mượn trả	
	    
--DeletePhieuPhat
CREATE PROCEDURE DeletePhieuPhat
    @MaPhieuPhat NVARCHAR(10)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Xóa dữ liệu từ bảng ChiTietPhieuPhat
        DELETE FROM ChiTietPhieuPhat WHERE MaPhieuPhat = @MaPhieuPhat;

        -- Xóa dữ liệu từ bảng PhieuPhat
        DELETE FROM PhieuPhat WHERE MaPhieuPhat = @MaPhieuPhat;

        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;

        THROW;
    END CATCH;
END
-- End DeletePhieuPhat

--Thêm chi tiết phiếu mượn trả
CREATE PROCEDURE InsertChiTietPhieuMuonTra
    @MaPhieuMuonTra VARCHAR(20),
    @MaSach VARCHAR(20) 
	AS
BEGIN
    SET NOCOUNT ON;
	Declare
	@TinhTrang NVARCHAR(50) = N'Chưa trả',
    @NgayTra DATE = null
    INSERT INTO ChiTietPhieuMuonTra (MaPhieuMuonTra, MaSach, TinhTrang, NgayTra)
    VALUES (@MaPhieuMuonTra, @MaSach, @TinhTrang, @NgayTra)
END
--Kết thúc thêm chi tiết phiếu mượn trả

--Del CTPMT
--Delete PMT
CREATE PROCEDURE DeletePhieuMuonTra
    @mapmt nvarchar(10)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION;

    -- Xóa các bản ghi liên quan trong bảng ChiTietPhieuPhat
    DELETE FROM ChiTietPhieuPhat
    WHERE MaPhieuPhat IN (
        SELECT MaPhieuPhat
        FROM PhieuPhat
        WHERE MaPhieuMuonTra = @mapmt
    );

    -- Xóa các bản ghi liên quan trong bảng PhieuPhat
    DELETE FROM PhieuPhat
    WHERE MaPhieuMuonTra = @mapmt;

    -- Xóa các bản ghi liên quan trong bảng ChiTietPhieuMuonTra
    DELETE FROM ChiTietPhieuMuonTra
    WHERE MaPhieuMuonTra = @mapmt;

    -- Xóa bản ghi trong bảng PhieuMuonTra
    DELETE FROM PhieuMuonTra
    WHERE MaPhieuMuonTra = @mapmt;

    COMMIT TRANSACTION;
END
--End Delete PMT
--End Del CTPMT

--Insert ThongTinNhanVienvaNhanVien
CREATE PROCEDURE InsertNhanVienvaNhanVien
    @TenNV NVARCHAR(50),
    @GioiTinh NCHAR(1),
    @NgaySinh DATE,
    @DiaChi NVARCHAR(200),
    @SDT NVARCHAR(20),
    @Luong DECIMAL(18,2),
    @Email NVARCHAR(50),
    @MaTo NVARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION

    BEGIN TRY
        -- Kiểm tra MaTo có nằm trong bảng NhomTo hay không
        IF NOT EXISTS (SELECT 1 FROM NhomTo WHERE MaTo = @MaTo)
        BEGIN
            RAISERROR('Mã tổ không hợp lệ. Vui lòng kiểm tra lại.', 16, 1)
            RETURN
        END

        DECLARE @MaNV NVARCHAR(10) = dbo.func_Auto_NhanVienID()
        DECLARE @NgayTao DATE = GETDATE()

        INSERT INTO ThongTinNhanVien (MaNV, TenNV, GioiTinh, NgaySinh, DiaChi, SDT, Luong, Email, NgayTao)
        VALUES (@MaNV, @TenNV, @GioiTinh, @NgaySinh, @DiaChi, @SDT, @Luong, @Email, @NgayTao)

        INSERT INTO NhanVien (MaNV, MaTo)
        VALUES (@MaNV, @MaTo)

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        THROW
    END CATCH
END
--End Insert InsertThongTinNhanVienvaNhanVien

--Insert TaiKhoan
CREATE PROCEDURE InsertTaiKhoan
   @username nvarchar(50),
    @password nvarchar(50),
    @manv nvarchar(10)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;
        
        IF EXISTS (SELECT * FROM TaiKhoan WHERE Username = @username)
        BEGIN
            THROW 50000, 'Đã tồn tại Username này trong hệ thống', 1;
        END;

        IF NOT EXISTS (SELECT * FROM ThongTinNhanVien tt WHERE tt.MaNV = @manv)
        BEGIN
            THROW 50000, 'Không tồn tại mã nhân viên này trong hệ thống', 1;
        END;

        DECLARE @login nvarchar(4000);
        SET @login = N'CREATE LOGIN ' + QUOTENAME(@username) + ' WITH PASSWORD = ' +   
                     QUOTENAME(@password, '''') + ', default_database = ' + QUOTENAME('QL_ThuVien');
        EXEC(@login);
        
        DECLARE @user nvarchar(4000);
        SET @user = N'CREATE USER ' + QUOTENAME(@username) + ' FOR LOGIN ' + QUOTENAME(@username);
        EXEC(@user);

        IF EXISTS (SELECT * FROM NhanVien tt WHERE tt.MaNV = @manv)
        BEGIN
            EXEC sp_addrolemember 'Staff', @username;
        END;

        IF EXISTS (SELECT * FROM ToTruong tt WHERE tt.MaNV = @manv)
        BEGIN
            EXEC sp_addrolemember 'Leader', @username;
        END;

        IF EXISTS (SELECT * FROM NguoiQuanLi tt WHERE tt.MaNV = @manv)
        BEGIN
            EXEC sp_addrolemember 'Manager', @username;
        END;

        COMMIT;
        RETURN 'Tạo tài khoản thành công';
    END TRY
    BEGIN CATCH
        ROLLBACK;
        RETURN ERROR_MESSAGE();
    END CATCH;
END;

--End Insert TaiKhoan
--Insert ChiTietPhieuPhat
CREATE PROCEDURE InsertChiTietPhieuPhat
    @MaPhieuPhat NVARCHAR(10),
    @LoaiPhat NVARCHAR(50)
AS
BEGIN
 BEGIN TRANSACTION Tran_InsertDocGia
	BEGIN TRY
		IF @LoaiPhat IN (N'Hư hỏng', N'Trễ hạn', N'Mất sách')
    BEGIN
        INSERT INTO ChiTietPhieuPhat (MaPhieuPhat, LoaiPhat)
        VALUES (@MaPhieuPhat, @LoaiPhat)
    END
    ELSE
    BEGIN
        RAISERROR('Loại phạt không hợp lệ. Vui lòng chọn một trong các loại: Hư hỏng, Trễ hạn, Mất sách.', 16, 1)
    END

		COMMIT TRANSACTION Tran_InsertDocGia
    END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION Tran_InsertDocGia
		PRINT('Thêm không thành công!')
	END CATCH
    
END
--End Insert ChiTietPhieuPhat

-- Procedure tạo tài khoản nhân viên
GO
CREATE PROCEDURE proc_UpdateAccountEmpploye
    @Username NVARCHAR(50),
    @PasswordUser NVARCHAR(100),
    @MaNV NVARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION tran_CreateAccount
    BEGIN TRY
        IF EXISTS (SELECT * FROM TaiKhoan WHERE Username = @Username)
        BEGIN
            RAISERROR ('Tài khoản đã tồn tại',16,1)
            RETURN
        END;
        
        UPDATE TaiKhoan 
        SET Username = @Username, PasswordUser = @PasswordUser, MaNV = @MaNV
        WHERE Username = @Username

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        THROW
    END CATCH
END
