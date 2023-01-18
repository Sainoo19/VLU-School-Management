CREATE DATABASE TrungTamDunno
GO

USE TrungTamDunno
GO

CREATE TABLE TaiKhoan(
	ID         INT IDENTITY,
	TaiKhoan   NVARCHAR(100) PRIMARY KEY,	 
	TenHienThi NVARCHAR(100) NOT NULL DEFAULT N'Kter', 
	MatKhau    NVARCHAR(100) NOT NULL DEFAULT 0,
)

INSERT INTO TaiKhoan VALUES
(N'admin', N'Nguyễn Văn A', '123'),
(N'nhanvien1', N'Nguyễn Văn B', '123'),
(N'nhanvien2', N'Nguyễn Văn C', '123')


CREATE TABLE LopHoc(
	MaLopHoc      NVARCHAR(30) ,	
	TenLopHoc     NVARCHAR(30),
	ThoiKhoaBieu  NVARCHAR(30),
	NgayKhaiGiang DATE,
	HocPhi        int ,
	PRIMARY KEY(MaLopHoc)
)
ALTER TABLE LopHoc
  ADD LoaiLop NVARCHAR(30);

INSERT INTO LopHoc VALUES
(N'DH001',N'Lap Trinh Huong Doi Tuong', N'Thu 2-4-6','2015-12-17',440000)

select*from LopHoc

CREATE TABLE MonHoc(
	MaMonHoc       NVARCHAR(30) PRIMARY KEY,
	MaLopHoc       NVARCHAR(30) FOREIGN KEY (MaLopHoc) REFERENCES LopHoc(MaLopHoc),
	MaHocPhan      NVARCHAR(30) FOREIGN KEY (MaHocPhan) REFERENCES HocPhan(MaHocPhan),
	TenMonHoc      NVARCHAR(30),
	SoTietLyThuyet INT,
	SoTietThucHanh INT,
)
INSERT INTO MonHoc VALUES
(N'LTC001', N'DH001',N'KTPM001',N'Lap Trinh C#',25,15)

select *from MonHoc
drop table MonHoc



CREATE TABLE HocVien(
	MaHocVien  NVARCHAR(30) PRIMARY KEY,
	MaLopHoc   NVARCHAR(30) FOREIGN KEY REFERENCES LopHoc(MaLopHoc),
	HoTen      NVARCHAR(30),
	GioiTinh   NVARCHAR(6) CHECK (GioiTinh = N'Nam' OR GioiTinh = N'Nữ'),
	NgaySinh   DATE,
	NoiSinh	   NVARCHAR(30),
	NgheNghiep NVARCHAR(30),
	
	
)

CREATE TABLE BienLai(
	MaBienLai NVARCHAR(30) PRIMARY KEY,
	MaHocVien NVARCHAR(30) FOREIGN KEY REFERENCES HocVien(MaHocVien),
	MaLopHoc  NVARCHAR(30) ,
	--TongHocPhi co the tinh toan khong can them vao gay du thua du lieu       ,
	TinhTrang NVARCHAR(14) CHECK (TinhTrang = N'Đã thanh toán' OR TinhTrang = N'Chưa thanh toán'),
	FOREIGN KEY (MaLopHoc) REFERENCES LopHoc(MaLopHoc)
	
)

CREATE TABLE DiemThi(
	MaMonHoc  NVARCHAR(30) FOREIGN KEY REFERENCES MonHoc(MaMonHoc) not null,
	MaHocVien NVARCHAR(30) FOREIGN KEY REFERENCES HocVien(MaHocVien) not null,
	Diemthi	  REAL
	PRIMARY KEY (MaMonHoc, MaHocVien)
)

create table HocPhan
( 
	MaHocPhan NVARCHAR(30) primary key,
	
	TenHocPhan NVARCHAR(30)
)
INSERT INTO HocPhan VALUES
    (N'KTPM001' , N'Ky Thuat Phan Mem')

/*
SELECT * FROM LopHoc
ALTER TABLE LopHoc ADD HocPhi INT
*/


drop table DiemThi