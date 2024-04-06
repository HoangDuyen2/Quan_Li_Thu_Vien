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
