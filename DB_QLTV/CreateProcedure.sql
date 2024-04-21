--Bắt đầu thêm nhân viên mới
CREATE PROCEDURE InsertStaff (@TenNV nvarchar(50),
								@GioiTinh nvarchar(1),
								@NgaySinh DATETIME,
								@DiaChi nvarchar(255),
								@Luong int,
								@SDT varchar(10),
								@Email varchar(50))
AS
BEGIN
	BEGIN TRANSACTION Tran_InsertStaff
	BEGIN TRY

		INSERT INTO dbo.ThongTinNhanVien(TenNV, GioiTinh, NgaySinh, DiaChi, Luong, SDT, Email)
		VALUES (@TenNV, @GioiTinh, @NgaySinh, @DiaChi, @Luong, @SDT, @Email)
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

--bắt đầu thêm độc giả mới
CREATE PROCEDURE InsertDocGia (
							  @TenDocGia NVARCHAR(255) NOT NULL,
							  @Email CHAR(50) NOT NULL,
							  @SoDienThoai CHAR(10) NOT NULL,
							  @GioiTinh NVARCHAR(1) NOT NULL,
							  @MaLoaiDG nvarchar(10)
							)
AS
BEGIN
	  -- Wrap the insert statement in a transaction for data integrity
	  BEGIN TRANSACTION Tran_InsertDocGia

	  BEGIN TRY
		-- Check if referenced LoaiDocGia record exists before insert
		IF NOT EXISTS (SELECT 1 FROM LoaiDocGia WHERE MaLoaiDG = @MaLoaiDG)
		BEGIN
		  PRINT('MaLoaiDG does not exist!');
		  THROW; -- Raise an error to rollback the transaction
		END

		-- Insert data into DocGia table
		INSERT INTO DocGia (TenDocGia, Email, SoDienThoai, GioiTinh, NgayTao, MaLoaiDG)
		VALUES (@TenDocGia, @Email, @SoDienThoai, @GioiTinh, GETDATE(), @MaLoaiDG);

		COMMIT TRANSACTION Tran_InsertDocGia
	  END TRY

	  BEGIN CATCH
		PRINT('Error inserting DocGia record!');
		ROLLBACK TRANSACTION Tran_InsertDocGia;
	  END CATCH
END;
GO
--kết thúc thêm đọc giả

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

--bắt đầu thêm độc giả mới
CREATE PROCEDURE InsertDocGia (
  @TenDocGia NVARCHAR(255) NOT NULL,
  @Email CHAR(50) NOT NULL,
  @SoDienThoai CHAR(10) NOT NULL,
  @GioiTinh NVARCHAR(1) NOT NULL,
  @MaLoaiDG NVARCHAR(10)
)
AS
BEGIN
  -- Begin transaction
  BEGIN TRANSACTION Tran_InsertDocGia;

  BEGIN TRY
    -- Check if MaLoaiDG exists
    IF NOT EXISTS (SELECT 1 FROM LoaiDocGia WHERE MaLoaiDG = @MaLoaiDG)
    BEGIN
      PRINT('MaLoaiDG does not exist!');
      THROW TRAN EXCEPT; -- Throw an exception within CATCH block
    END

    -- Insert DocGia
    INSERT INTO DocGia (TenDocGia, Email, SoDienThoai, GioiTinh, NgayTao, MaLoaiDG)
      VALUES (@TenDocGia, @Email, @SoDienThoai, @GioiTinh, GETDATE(), @MaLoaiDG);

    -- Commit transaction if successful
    COMMIT TRANSACTION Tran_InsertDocGia;
  END TRY

  BEGIN CATCH
    -- Handle errors here
    DECLARE @err NVARCHAR(MAX);
    SELECT @err = N'Lỗi: ' + ERROR_MESSAGE();
    RAISERROR (@err, 16, 1);

    -- Rollback transaction on error
    ROLLBACK TRANSACTION Tran_InsertDocGia;
  END CATCH
END


--kết thúc thêm đọc giả


--Cập nhật đọc giả
CREATE PROCEDURE UpdateDocGia (
  @MaDocGia NVARCHAR(10) NOT NULL,
  @TenDocGia NVARCHAR(255),
  @Email CHAR(50),
  @SoDienThoai CHAR(10),
  @GioiTinh NVARCHAR(1),
  @MaLoaiDG nvarchar(10)
)
AS
BEGIN
	  -- Wrap the update statement in a transaction for data integrity
	  BEGIN TRANSACTION Tran_UpdateDocGia

	  BEGIN TRY
		-- Check if DocGia record exists before updating
		IF NOT EXISTS (SELECT 1 FROM DocGia WHERE MaDocGia = @MaDocGia)
		BEGIN
		  PRINT('MaDocGia does not exist!');
		  THROW TRAN EXCEPT; -- Raise an error to rollback the transaction
		END

		-- Update the DocGia record
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
		DECLARE @err NVARCHAR(MAX);
		SELECT @err = N'Lỗi: ' + ERROR_MESSAGE();
		RAISERROR (@err, 16, 1);
		ROLLBACK TRANSACTION Tran_UpdateDocGia;
	  END CATCH
END;
GO
--kết thúc cập nhật đọc giả


--nhập sách và tạo phiếu nhập

CREATE PROCEDURE InsertPhieunhapChitietphieunhap(
			  @ngayNhap DATE,
			  @giaTriDonHang FLOAT,
			  @maNhaCC NVARCHAR(10),
			  @tenSach NVARCHAR(50),
			  @donGia FLOAT,
			  @soLuong INT,
			  @maNV NVARCHAR(10)
)
AS
BEGIN
	   IF EXISTS (
			SELECT 1
			FROM ToTruong
			WHERE MaNV = @maNV
	   ) OR EXISTS (
			SELECT 1
			FROM NguoiQuanLi
			WHERE MaNV = @maNV
	   )
	   BEGIN
	   RAISERROR ('Mã nhân viên không phù hợp.', 16, 1);
	   RETURN;
	   END;

	  -- 1. Kiểm tra xem sách có tồn tại hay không
	  DECLARE @maSach NVARCHAR(10);
	  DECLARE @maPhieuNhap INT

	  SELECT @maSach = MaSach
	  FROM Sach
	  WHERE TenSach = @tenSach;

	  IF @maSach IS NULL
	  BEGIN
		-- Sách chưa tồn tại, thông báo lỗi
		RAISERROR ('Sách không tồn tại.', 16, 1, @tenSach);
		RETURN;
	  END;

	  -- 2. Thêm phiếu nhập

	  INSERT INTO PhieuNhap (NgayNhap, GiaTriDonHang, MaNhaCC)
	  VALUES (@ngayNhap, @giaTriDonHang, @maNhaCC);

	  SET @maPhieuNhap = SCOPE_IDENTITY();

	  INSERT INTO ChiTietPhieuNhap (MaPhieuNhap, MaSach, DonGia, SL)
	  VALUES (@maPhieuNhap, @maSach, @donGia, @soLuong);
	 

	  -- 4. Cập nhật số lượng tồn kho của sách
	  UPDATE Sach
	  SET SoLuongTon = SoLuongTon + @soLuong
	  WHERE MaSach = @maSach;
END;
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

