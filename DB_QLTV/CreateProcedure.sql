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
