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
