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
		
		UPDATE dbo.NhanVien SET Luong = @Luong 
		WHERE MaNV = @MaNV

		COMMIT TRANSACTION Tran_InsertStaff
    END TRY
	BEGIN CATCH
		PRINT('Thêm không thành công!')
		COMMIT TRANSACTION Tran_InsertStaff
	END CATCH
END
GO
--Kết thúc Procedure thêm nhân viên mới

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
