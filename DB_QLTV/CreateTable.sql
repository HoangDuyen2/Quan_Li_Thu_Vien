--Tạo bảng Nhóm tổ
CREATE TABLE NhomTo(
  MaTo nvarchar(10) PRIMARY KEY,
  TenTo nvarchar(50) NOT NULL
)

--Tạo bảng Nhân viên
CREATE TABLE NhanVien(
	MaNV nvarchar(10) PRIMARY KEY,
	TenNV nvarchar(50) NOT NULL,
	GioiTinh CHAR(1) NOT NULL CHECK (GioiTinh IN ('M', 'F')), 
	NgaySinh date check (DATEDIFF(year, NgaySinh, GETDATE())>=18),
	DiaChi nvarchar(255) NOT NULL,
	Luong int NOT NULL,
	SDT nchar(11) NOT NULL check (len(SDT) = 10),
	Email CHAR(50) NOT NULL,
	CHECK(Email LIKE '%@%'),
	MaNQL nvarchar(10),
	MaTT nvarchar(10),
	MaTo nvarchar(10) CONSTRAINT FK_NhanVien_To FOREIGN KEY REFERENCES NhomTo(MaTo),
	CONSTRAINT FK_NhanVien_MaTT FOREIGN KEY (MaTT) REFERENCES NhanVien(MaNV),
	CONSTRAINT FK_NhanVien_NQL FOREIGN KEY(MaNQL) REFERENCES NhanVien(MaNV),
)

  --Tạo bảng Tài khoản
CREATE TABLE TaiKhoan(
	Username nvarchar(50) PRIMARY KEY,
	PasswordUser nvarchar(50) NOT NULL,
	MaNV nvarchar(10) NOT NULL FOREIGN KEY REFERENCES NhanVien(MaNV)
)

--Tạo bảng Loại độc giả
CREATE TABLE LoaiDocGia ( 
	MaLoaiDG nvarchar(10) CONSTRAINT PK_LoaiDocGia PRIMARY KEY, 
	TenLoaiDG NVARCHAR(255) NOT NULL 
)

--Tạo bảng Độc giả
CREATE TABLE DocGia ( 
	MaDocGia nvarchar(10) CONSTRAINT PK_DocGia PRIMARY KEY, 
	TenDocGia NVARCHAR(255) NOT NULL, 
	Email CHAR(50) NOT NULL,
	CHECK(Email LIKE '%@%'),
	SoDienThoai CHAR(10) NOT NULL CONSTRAINT CHECK_SoDienThoai CHECK (LEN(SoDienThoai) = 10),
	GioiTinh NVARCHAR(1) NOT NULL CHECK (GioiTinh IN ('M', 'F')),
	NgayTao datetime,
	MaLoaiDG nvarchar(10) CONSTRAINT FK_DocGia_LoaiDocGia FOREIGN KEY REFERENCES LoaiDocGia(MaLoaiDG)	 
)

  --Tạo bảng Ngôn ngữ
CREATE TABLE NgonNgu(
	MaNgonNgu nvarchar(10) CONSTRAINT PK_NgonNgu PRIMARY KEY,
	TenNgonNgu nvarchar(50) NOT NULL
)

--Tạo bảng Loại sách
CREATE TABLE LoaiSach(
	MaLoaiSach nvarchar(10) CONSTRAINT PK_LoaiSach PRIMARY KEY,
	TenLoaiSach nvarchar(50) NOT NULL
)

  --Tạo bảng Nhà xuất bản
CREATE TABLE NXB(
	MaNXB nvarchar(10) CONSTRAINT PK_NXB PRIMARY KEY,
	TenNXB nvarchar(50) NOT NULL,
	DiaChi nvarchar(50) NOT NULL,
	SDT nvarchar(11) NOT NULL check (len(SDT) = 10)
)

  --Tạo bảng Tác giả
CREATE TABLE TacGia(
	MaTG nvarchar(10) CONSTRAINT PK_TacGia PRIMARY KEY,
	TenTG nvarchar(50) NOT NULL,
	GioiTinh nvarchar(1) NOT NULL CHECK (GioiTinh IN('M','F')),
	NamSinh int check (NamSinh > 0),
	NamMat int check (NamMat > 0),
	QueQuan nvarchar(50)
)

  --Tạo bảng Sách
CREATE TABLE Sach (
    	MaSach nvarchar(10) PRIMARY KEY,
    	TenSach nvarchar(50) NOT NULL,
    	MaNXB nvarchar(10),
    	MaLoaiSach nvarchar(10),
		MaNgonNgu nvarchar(10),
		NamXB int CHECK (NamXB > 0),
		SoLuongTon int CHECK (SoLuongTon >= 0),
		SoLuongSach int,
		CHECK (SoLuongSach >= SoLuongTon),
		CONSTRAINT FK_Sach_NgonNgu FOREIGN KEY (MaNgonNgu) REFERENCES NgonNgu(MaNgonNgu),
    	CONSTRAINT FK_Sach_NXB FOREIGN KEY (MaNXB) REFERENCES NXB(MaNXB),
    	CONSTRAINT FK_Sach_TheLoai FOREIGN KEY (MaLoaiSach) REFERENCES LoaiSach(MaLoaiSach)
)

  --Tạo bảng Tác giả của sách
CREATE TABLE TacGiaSach(
	MaTG nvarchar(10) CONSTRAINT FK_TacGiaSach_TacGia FOREIGN KEY REFERENCES TacGia(MaTG),
	MaSach nvarchar(10) CONSTRAINT FK_TacGiaSach_Sach FOREIGN KEY REFERENCES Sach(MaSach),
	CONSTRAINT PK_TacGiaSach PRIMARY KEY (MaTG, MaSach)
)

  --Tạo bảng Phiếu mượn trả
CREATE TABLE PhieuMuonTra ( 
	MaPhieuMuonTra nvarchar(10) PRIMARY KEY,
	MaNV nvarchar(10) CONSTRAINT FK_PhieuMuonTra_NhanVien FOREIGN KEY 
	REFERENCES NhanVien(MaNV),
	MaDocGia nvarchar(10) CONSTRAINT FK_PhieuMuonTra_DocGia FOREIGN KEY
	REFERENCES DocGia(MaDocGia),
	NgayMuon DATETIME NOT NULL CHECK (NgayMuon >= 0), 
	HanTra  DATETIME NOT NULL
)

--Tạo bảng chi tiết phiếu mượn trả
CREATE TABLE ChiTietPhieuMuonTra ( 
	MaPhieuMuonTra nvarchar(10) CONSTRAINT FK_ChiTietPhieuMuonTra_PhieuMuonTra FOREIGN KEY REFERENCES PhieuMuonTra(MaPhieuMuonTra),
	MaSach nvarchar(10) CONSTRAINT FK_ChiTietPhieuMuonTra_Sach FOREIGN KEY REFERENCES Sach(MaSach),
	TinhTrang NVARCHAR(255) NOT NULL, 
	NgayTra DATETIME CHECK (NgayTra >= 0),
	CONSTRAINT PK_ChiTietPhieuMuonTra PRIMARY KEY (MaPhieuMuonTra, MaSach)
)

  --Tạo bảng Phạt
CREATE TABLE Phat (
  LoaiPhat nvarchar(20) PRIMARY KEY, 
  TienPhat int NOT NULL
);

--Tạo bảng Phiếu phạt
CREATE TABLE PhieuPhat(
	MaPhieuPhat NVARCHAR(10) PRIMARY KEY,
	MaPhieuMuonTra NVARCHAR(10) not null CONSTRAINT FK_PhieuPhat_MaPhieuMuonTra FOREIGN KEY REFERENCES PhieuMuonTra(MaPhieuMuonTra),
	TongTien int check (TongTien >= 0),
	MaSach NVARCHAR(10) not null CONSTRAINT FK_PhieuPhat_MaSach FOREIGN KEY REFERENCES Sach(MaSach),
	NgayXuatPhieu DATETIME not null CHECK (NgayXuatPhieu >= 0),
)

  --Tạo bảng Chi tiết phiếu phạt
CREATE TABLE [dbo].[ChiTietPhieuPhat] (
    [MaPhieuPhat] NVARCHAR (10) NOT NULL,
    [LoaiPhat]       NVARCHAR (20) NOT NULL,
    CONSTRAINT [PK_ChiTietPhieuPhat] PRIMARY KEY CLUSTERED ([MaPhieuPhat] ASC, [LoaiPhat] ASC),
    CONSTRAINT [FK_CTPP_MPP] FOREIGN KEY ([MaPhieuPhat]) REFERENCES [dbo].[PhieuPhat] ([MaPhieuPhat]),
    CONSTRAINT [FK_CTPP_PhieuPhat] FOREIGN KEY ([LoaiPhat]) REFERENCES [dbo].[Phat] ([LoaiPhat])
);

  --Tạo bảng Cung cấp
CREATE TABLE CungCap ( 
	MaNhaCC nvarchar(10) CONSTRAINT PK_CungCap PRIMARY KEY, 
	TenNhaCC NVARCHAR(255) NOT NULL, 
	DiaChi NVARCHAR(255) NOT NULL, 
	SoDienThoai CHAR(11) NOT NULL, 
	CONSTRAINT CK_SoDienThoai CHECK (LEN(SoDienThoai) = 10)
)

  --Tạo bảng Phiếu nhập
CREATE TABLE PhieuNhap ( 
	MaPhieuNhap nvarchar(10) CONSTRAINT PK_PhieuNhap PRIMARY KEY, 
	NgayNhap date check (DATEDIFF(day, NgayNhap, GETDATE())>=0),  
	GiaTriDonHang float check (GiaTriDonHang >= 0),
	MaNhaCC nvarchar(10) CONSTRAINT FK_PhieuNhap_MaNhaCC FOREIGN KEY REFERENCES CungCap(MaNhaCC) 
)

  --Tạo bảng Chi tiết phiếu nhập
CREATE TABLE ChiTietPhieuNhap(
	MaPhieuNhap nvarchar(10) CONSTRAINT FK_PhieuNhap_ChiTiet FOREIGN KEY REFERENCES
	PhieuNhap(MaPhieuNhap),
	MaSach nvarchar(10) CONSTRAINT FK_ChiTiet_Sach FOREIGN KEY REFERENCES
	Sach(MaSach),
	DonGia float check (DonGia >= 0),
	SL int check (SL > 0),
	CONSTRAINT PK_ChiTietPhieuNhap PRIMARY KEY (MaPhieuNhap, MaSach)
)
