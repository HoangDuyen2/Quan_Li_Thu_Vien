--Bắt đầu thêm nhân viên mới
CREATE PROCEDURE InsertStaff (@TenNV nvarchar(50),
								@GioiTinh nvarchar(1),
								@NgaySinh DATETIME,
								@DiaChi nvarchar(255),
								@Luong int,
								@SDT varchar(10),
								@Email varchar(50),
								@MaNQL nvarchar(255),
								@MaTT varchar(20),
								@MaTo nvarchar(10))
AS
BEGIN
	BEGIN TRANSACTION Tran_InsertStaff
	BEGIN TRY
		DECLARE @role TINYINT
        SET @role = @MaTo

		INSERT INTO dbo.NhanVien(TenNV, GioiTinh, NgaySinh, DiaChi, Luong, SDT, Email, MaNQL, MaTT, MaTo)
		VALUES (@TenNV, @GioiTinh, @NgaySinh, @DiaChi, @Luong, @SDT, @Email, @MaNQL, @MaTT, @MaTo)

		DECLARE @MaNV NVARCHAR(10)
		SELECT @MaNV = MAX(@MaNV) FROM dbo.NhanVien WHERE MaTo = @role

		COMMIT TRANSACTION Tran_InsertStaff
    END TRY
	BEGIN CATCH
		PRINT('Thêm không thành công!')
		COMMIT TRANSACTION Tran_InsertStaff
	END CATCH
END
GO
--Kết thúc Procedure thêm nhân viên mới
	
--Bắt đầu sửa nhân viên mới
CREATE PROCEDURE UpdateStaff (@TenNV nvarchar(32),
								@GioiTinh nvarchar(1),
								@NgaySinh DATETIME,
								@DiaChi nvarchar(255),
								@SDT varchar(10),
								@Email varchar(50),
								@MaNQL nvarchar(255),
								@MaTT varchar(20),
								@MaTo nvarchar(10))
AS
BEGIN
	BEGIN TRANSACTION Tran_UpdateStaff
	BEGIN TRY
		UPDATE dbo.NhanVien SET TenNV = @TenNV,
					GioiTinh = @GioiTinh,
					NgaySinh = @NgaySinh,
					DiaChi = @DiaChi,
					SDT = @SDT,
					Email = @Email,
					MaNQL = @MaNQL,
					MaTT = @MaTT,
					MaTo = @MaTo
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

--Bắt đầu xem nhân viên theo mã tổ của người tổ trưởng
CREATE PROCEDURE [dbo].[proc_NhanVienTheoTo]
	@MaTo NVARCHAR(10)
AS
	BEGIN
		SELECT MaNV, TenNV, GioiTinh, NgaySinh, DiaChi, SDT, Email, nt.TenTo
		FROM dbo.NhanVien nv INNER JOIN NhomTo nt ON nv.MaTo = nt.MaTo
		WHERE nv.MaTo = @MaTo
	END
--Kết thúc xem nhân viên theo mã tổ của người tổ trưởng

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