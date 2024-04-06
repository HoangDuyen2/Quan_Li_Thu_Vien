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
