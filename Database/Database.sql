use TTN_QuanLyThuVien
create table TACGIA
(
	MaTacGia char (15),
	TenTacGia nvarchar (50),
	primary key (MaTacGia)
)
go

create table THELOAI
(
	MaTheLoai char (15),
	TenTheLoai nvarchar (50),
	primary key (MaTheLoai)
)
go

create table NHAXUATBAN
(
	MaNhaXuatBan char (15),
	TenNhaXuatBan nvarchar (50),
	primary key (MaNhaXuatBan)
)
go


create table DAUSACH
(
	MaSach char (15),
	MaTheLoai char (15),
	MaNhaXuatBan char (15),
	MaTacGia char (15),
	TenSach nvarchar (400),
	SoLuong int,
	primary key (MaSach),
	constraint ds_MaTheLoai_fk FOREIGN KEY (MaTheLoai)
		 REFERENCES THELOAI (MaTheLoai),	
	constraint ds_MaNhaXuatBan_fk FOREIGN KEY (MaNhaXuatBan)
		 REFERENCES NHAXUATBAN (MaNhaXuatBan),
	constraint ds_MaTacGia_fk FOREIGN KEY (MaTacGia)
		 REFERENCES TACGIA (MaTacGia)
)
go

create table SACH
(
	MaDonViSach char(15),
	MaSach char(15),
	TrangThai BIT, -- 1: đã trả, 0: đang mượn
	primary key (MaDonViSach),
	constraint ds_MaSach_fk FOREIGN KEY (MaSach) REFERENCES DAUSACH (MaSach)
)
go

create table NHANVIEN
(
	MaNhanVien char (15),
	TenNhanVien nvarchar (50),
	NgaySinh date,
	GioiTinh nvarchar (10),
	DiaChi nvarchar (1000),
	SoDienThoai int,
	primary key (MaNhanVien)
)

create table SINHVIEN
(
	MaSinhVien char (15),
	HoTen nvarchar (50),
	NgaySinh date,
	Gioitinh nvarchar(50),
	DiaChi nvarchar(100),
	SoDienThoai int,
	primary key (MaSinhVien),
	
)
go

create table THETHUVIEN
(
	MaThe char(15),
	MaSinhVien char (15),
	NgayTaoThe date,
	NgayGiaHan date,
	NgayHetHan date,
	primary key (MaThe),
	constraint ttv_MaSinhVien_fk FOREIGN KEY(MaSinhVien)
		 REFERENCES SINHVIEN(MaSinhVien)	
)
go


create table MUONTRA
(
	MaMuonTra char (15),
	MaThe char(15),
	MaNhanVien char(15),
	NgayMuon date,
	NgayTra date,
	Ghichu Nvarchar (200),
	primary key (MaMuonTra),
	constraint mt_MaThe_fk FOREIGN KEY(MaThe)
		 REFERENCES THETHUVIEN (MaThe),
	constraint mt_MaNhanVien_fk FOREIGN KEY(MaNhanVien)
		 REFERENCES NHANVIEN (MaNhanVien)
)
go


create table CHITIETMUONTRA
(
	MaMuonTra char (15),
	MaDonViSach char (15),
	PRIMARY KEY (MaMuonTra , MaDonViSach ),
	constraint ctmt_MaMuonTra_fk FOREIGN KEY(MaMuonTra)
		 REFERENCES MUONTRA (MaMuonTra),	
	constraint ctmt_MaDonViSach_fk FOREIGN KEY(MaDonViSach)
		 REFERENCES SACH (MaDonViSach)
)
go

