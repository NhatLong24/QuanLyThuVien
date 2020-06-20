
insert into TACGIA(MaTacGia, TenTacGia)
	values	
		('TG00001', N'Tô Văn Ban'),
		('TG00002', N'Emily Brontë'),
		('TG00003', N'Miguel de Cervantes Saavedra'),
		('TG00004', N'Nguyễn Khắc Nho'),
		('TG00005', N'PGS, TS Ngô Đăng Tri')
go

insert into THELOAI(MaTheLoai, TenTheLoai)
	values	
		('TL00001', N'Giáo trình'),
		('TL00002', N'Tiểu Thuyết'),
		('TL00003', N'Chính trị'),
		('TL00004', N'Lịch sử')
go

insert into NHAXUATBAN(MaNhaXuatBan, TenNhaXuatBan)
	values	
		('XB00001', N'Nhà xuất bản Giáo dục'),
		('XB00002', N'Nhà xuất bản Văn hóa'),
		('XB00003', N'Nhà xuất bản Chính trị quốc gia - Sự thật'),
		('XB00004', N'Nhà xuất bản thông tin và truyền thông')
go


insert into DAUSACH(MaSach, MaTheLoai, MaNhaXuatBan,MaTacGia, TenSach, SoLuong )
	values	
		('S00001', 'TL00001', 'XB00001', 'TG00001', N'Giáo trình Giải tích 1', 5),
		('S00002', 'TL00002', 'XB00002', 'TG00002', N'Đồi gió hú', 5),
		('S00003', 'TL00002', 'XB00002', 'TG00003', N'Don Quixote - Nhà Quý Tộc Tài Ba Xứ Mancha', 5),
		('S00004', 'TL00003', 'XB00003', 'TG00004', N'Phong cách Hồ Chí Minh', 5),
		('S00005', 'TL00004', 'XB00004', 'TG00005', N'TIẾN TRÌNH LỊCH SỬ ĐẢNG CỘNG SẢN VIỆT NAM (1930 - 2016)', 5)
go

insert into SACH(MaDonViSach, MaSach, TrangThai)
	values	
		('DVS10001', 'S00001',1),
		('DVS10002', 'S00001',1),
		('DVS10003', 'S00001',1),
		('DVS10004', 'S00001',1),
		('DVS10005', 'S00001',1),
		('DVS20001', 'S00002',1),
		('DVS20002', 'S00002',1),
		('DVS20003', 'S00002',1),
		('DVS20004', 'S00002',1),
		('DVS20005', 'S00002',1),
		('DVS30001', 'S00003',1),
		('DVS30002', 'S00003',1),
		('DVS30003', 'S00003',1),
		('DVS30004', 'S00003',1),
		('DVS30005', 'S00003',1),
		('DVS40001', 'S00004',1),
		('DVS40002', 'S00004',1),
		('DVS40003', 'S00004',1),
		('DVS40004', 'S00004',1),
		('DVS40005', 'S00004',1),
		('DVS50001', 'S00005',1),
		('DVS50002', 'S00005',1),
		('DVS50003', 'S00005',1),
		('DVS50004', 'S00005',1),
		('DVS50005', 'S00005',1)

go

insert into NHANVIEN(MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, DiaChi, SoDienThoai)
	values	
		('NV00001', N'Lê Thị Hồng', '1976-06-10', N'Nữ', N'Ngõ 28 Tăng Thiết Giáp, Cổ Nhuế 2, Bắc Từ Liêm, Hà Nội', 0948346158),
		('NV00002', N'Nguyễn Hữu Thành', '1967-04-25', N'Nam', N'SN 34 ngõ 13 Xuân Thủy, Cầu Giấy, Hà Nội', 0967351948),
		('NV00003', N'Trần Thanh Mai', '1979-10-01', N'Nữ', N'SN 43 Hồ Tùng Mậu, Mai Dịch, Cầu Giấy, Hà Nội', 0975814965),
		('NV00004', N'Nguyễn Việt Hà', '1982-04-29', N'Nữ', N'SN 38 ngõ 7 Phạm Văn Đồng, Cổ Nhuế 1, Bắc Từ Liêm, Hà Nội', 0946281756),
		('NV00005', N'Lã Thanh Tùng', '1984-03-15', N'Nam', N'Số 1 Xuân Đỉnh, Bắc Từ Liêm, Hà Nội', 0948521875)

go


insert into SINHVIEN(MaSinhVien, HoTen , NgaySinh, Gioitinh, DiaChi, SoDienThoai)
	values	
		('SV00001', N'Hoàng Trọng Tùng', '1999-04-25', N'Nam', 'HVKTQS', 0954756824),
		('SV00002', N'Lê Thị Hương', '1998-04-27', N'Nữ', 'HVKTQS', 0965148259),
		('SV00003', N'Nguyễn Thành Trung', '1996-07-15', N'Nam', 'HVKTQS', 0945625847),
		('SV00004', N'Trần Bá Hoàng', '1997-03-05', N'Nam', 'HVKTQS', 0965847265),
		('SV00005', N'Hoàng Trà My', '1999-08-15', N'Nữ', 'HVKTQS', 0385493584)
go

insert into THETHUVIEN(MaThe, MaSinhVien , NgayTaoThe, NgayGiaHan, NgayHetHan)
	values	
		('TTV00001', 'SV00001', '2017-11-05', '2019-10-25', '2020-12-31'),
		('TTV00002', 'SV00002', '2016-11-09', '2019-11-11', '2020-12-31'),
		('TTV00003', 'SV00003', '2014-10-22', '2019-10-25', '2020-12-31'),
		('TTV00004', 'SV00004', '2015-10-27', '2019-11-23', '2020-12-31'),
		('TTV00005', 'SV00005', '2017-11-06', '2019-12-16', '2020-12-31')
go

insert into MUONTRA(MaMuonTra , MaThe, MaNhanVien, NgayMuon, NgayTra, Ghichu)
	values	
		('MT00001',  'TTV00003', 'NV00005','2019-10-23', '2020-03-10', null),
		('MT00002',  'TTV00005', 'NV00004', '2019-09-20', '2020-03-14', null),
		('MT00003',  'TTV00004', 'NV00003','2019-09-21', '2020-03-12', null)
go


insert into CHITIETMUONTRA(MaMuonTra, MaDonViSach)
	values
		('MT00001', 'DVS20004'),
		('MT00001', 'DVS30001'),
		('MT00001', 'DVS40004'),
		('MT00002', 'DVS20003'),
		('MT00002', 'DVS10004'),
		('MT00003', 'DVS10001')
go


