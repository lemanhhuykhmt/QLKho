create database QLKho
go
use QLKho

create table VatTu
(
	MaVT int identity(1,1),
	TenVT nvarchar(50),
	DonVi nvarchar(20),
	SoLuong int,
	primary key (MaVT)
)
go
create table NhaCungCap
(
	MaNCC int identity(1,1),
	TenNCC nvarchar(100),
	DiaChi nvarchar(100),
	SDT nvarchar(20),
	primary key (MaNCC)
)
go
create table PhieuNhap
(
	MaPN int identity(1,1),
	MaNCC int,
	NgayLap date,
	primary key(MaPN)
)
go
create table ChiTietPN
(
	MaPN int,
	MaVT int,
	SoLuong int,
	primary key (MaPN, MaVT)
)
go
create table CuaHang
(
	MaCH int identity(1,1),
	TenCH nvarchar(100),
	DiaChi nvarchar(100),
	SDT nvarchar(20),
	primary key (MaCH)
)
go
create table PhieuXuat
(
	MaPX int identity(1,1),
	MaCH int,
	NgayLap date,
	primary key(MaPX)
)
go
create table ChiTietPX
(
	MaPX int,
	MaVT int,
	SoLuong int,
	primary key (MaPX, MaVT)
)

--Khoá Ngoại

--PhieuNhap
alter table PhieuNhap add constraint FK_PhieuNhap_NhaCungCap foreign key (MaNCC) references NhaCungCap(MaNCC)
--ChiTietPN
alter table ChiTietPN add constraint FK_ChiTietPN_PhieuNhap foreign key (MaPN) references PhieuNhap(MaPN)
alter table ChiTietPN add constraint FK_ChiTietPN_VatTu foreign key (MaVT) references VatTu(MaVT)

--PhieuXuat
alter table PhieuXuat add constraint FK_PhieuXuat_CuaHang foreign key (MaCH) references CuaHang(MaCH)
--ChiTietPX
alter table ChiTietPX add constraint FK_ChiTietPX_PhieuXuat foreign key (MaPX) references PhieuXuat(MaPX)
alter table ChiTietPX add constraint FK_ChiTietPX_VatTu foreign key (MaVT) references VatTu(MaVT)


go

--VatTu
insert into VatTu (TenVT, DonVi, SoLuong)
values (N'Thép ống', N'kg', 1485) -- 1
insert into VatTu (TenVT, DonVi, SoLuong)
values (N'Xăng 92', N'lít', 568) -- 2
insert into VatTu (TenVT, DonVi, SoLuong)
values (N'Tôn Hoa Sen', N'Tấm', 46e) -- 3
insert into VatTu (TenVT, DonVi, SoLuong)
values (N'Sơn Lót', N'thùng', 584) -- 4
insert into VatTu (TenVT, DonVi, SoLuong)
values (N'Ống Nước', N'mét', 574) -- 5
insert into VatTu (TenVT, DonVi, SoLuong)
values (N'Dây Điện', N'mét', 1587) -- 6
insert into VatTu (TenVT, DonVi, SoLuong)
values (N'Sơn Màu', N'thùng', 586) -- 7
go

--NhaCungCap
insert into NhaCungCap (TenNCC)
values (N'Công ty cung cấp sơn', N'599 Nguyễn Kiệm, P.9, Q. Phú Nhuận, TP Hồ Chí Minh', '01688883627') -- 1
insert into NhaCungCap (TenNCC)
values (N'Nhà Máy Sản Xuất Thép', N'1/14/20 TÔN ĐÚC THẮNG, Hải Phòng', '01689525898') -- 2
insert into NhaCungCap (TenNCC)
values (N'Bóng Điện Huỳnh Quang', N'số 43 Đặng Văn Ngữ Đống Đa Hà Nội', '01235099415') -- 3
go
--PhieuNhap
insert into PhieuNhap (MaNCC, NgayLap)
values (2, '2018-03-02') --1
insert into PhieuNhap (MaNCC, NgayLap)
values (1, '2018-05-08') --2
insert into PhieuNhap (MaNCC, NgayLap)
values (3, '2018-05-06') --3
insert into PhieuNhap (MaNCC, NgayLap)
values (2, '2018-02-02') --4
insert into PhieuNhap (MaNCC, NgayLap)
values (3, '2018-05-04') --5
insert into PhieuNhap (MaNCC, NgayLap)
values (1, '2018-01-02') --6
go
--ChiTietPN
insert into ChiTietPN (MaPN, MaVT, SoLuong)
values (1, 2, 223)
insert into ChiTietPN (MaPN, MaVT, SoLuong)
values (1, 3, 134)
insert into ChiTietPN (MaPN, MaVT, SoLuong)
values (2, 1, 275)
insert into ChiTietPN (MaPN, MaVT, SoLuong)
values (2, 5, 234)
insert into ChiTietPN (MaPN, MaVT, SoLuong)
values (3, 7, 321)
insert into ChiTietPN (MaPN, MaVT, SoLuong)
values (4, 1, 348)
insert into ChiTietPN (MaPN, MaVT, SoLuong)
values (4, 5, 326)
insert into ChiTietPN (MaPN, MaVT, SoLuong)
values (5, 3, 134)
insert into ChiTietPN (MaPN, MaVT, SoLuong)
values (5, 6, 683)
insert into ChiTietPN (MaPN, MaVT, SoLuong)
values (6, 2, 32)
insert into ChiTietPN (MaPN, MaVT, SoLuong)
values (6, 6, 322)

--CuaHang
insert into CuaHang (TenCH)
values (N'Anh Quang Shop', N'599 Nguyễn Kiệm, P.9, Q. Phú Nhuận, TP Hồ Chí Minh', '01688883627') -- 1
insert into CuaHang (TenCH)
values (N'Siêu Thị Điện Máy', N'1/14/20 TÔN ĐÚC THẮNG, Hải Phòng', '01689525898') -- 2
insert into CuaHang (TenCH)
values (N'Công Trình Chung Cư', N'số 43 Đặng Văn Ngữ Đống Đa Hà Nội', '01235099415') -- 3
go
--PhieuXuat
insert into PhieuXuat (MaCH, NgayLap)
values (3, '2018-04-06') --1
insert into PhieuXuat (MaCH, NgayLap)
values (2, '2018-03-01') --2
insert into PhieuXuat (MaCH, NgayLap)
values (2, '2018-03-12') --3
insert into PhieuXuat (MaCH, NgayLap)
values (1, '2018-05-08') --4

go
--ChiTietPX
insert into ChiTietPX (MaPX, MaVT, SoLuong)
values (1, 2, 218)
insert into ChiTietPX (MaPX, MaVT, SoLuong)
values (1, 3, 237)
insert into ChiTietPX (MaPX, MaVT, SoLuong)
values (2, 4, 12)
insert into ChiTietPX (MaPX, MaVT, SoLuong)
values (2, 6, 392)
insert into ChiTietPX (MaPX, MaVT, SoLuong)
values (3, 3, 347)
insert into ChiTietPX (MaPX, MaVT, SoLuong)
values (3, 5, 384)
insert into ChiTietPX (MaPX, MaVT, SoLuong)
values (3, 7, 473)
insert into ChiTietPX (MaPX, MaVT, SoLuong)
values (4, 1, 384)
insert into ChiTietPX (MaPX, MaVT, SoLuong)
values (4, 3, 345)

-------------------------------------------

-- VatTu
go
create proc themvt (@ten nvarchar(50), @donvi nvarchar(20), @soluong int)
as begin
	if(len(@ten) <= 0) return
	if(len(@donvi) <= 0) return
	if(@soluong <= 0) return
	
	insert into VatTu (TenVT, DonVi, SoLuong)
	values (@ten, @donvi, @soluong)
end
go
create proc suavt (@ma int, @ten nvarchar(50), @donvi nvarchar(20), @soluong int)
as begin
	if(@ma not in (select MaVT from VatTu)) return
	
	if(len(@ten) > 0)
	begin
		update VatTu set TenVT = @ten where MaVT = @ma
	end
	if(len(@donvi) > 0)
	begin
		update VatTu set DonVi = @donvi where MaVT = @ma
	end
	if(@soluong >= 0)
	begin
		update VatTu set SoLuong = @soluong where MaVT = @ma
	end
end
go
create proc xoavt (@ma int)
as begin
	if(@ma not in (select MaVT from VatTu)) return
	
	if(@ma in (select MaVT from ChiTietPN))
	begin
		delete ChiTietPN where MaVT = @ma
	end
	if(@ma in (select MaVT from ChiTietPX))
	begin
		delete ChiTietPX where MaVT = @ma
	end
	
	delete VatTu where MaVT = @ma
end

-------
-- NhaCungCap
go
create proc themncc (@ten nvarchar(100), @diachi nvarchar(100), @sdt nvarchar(20))
as begin
	if(len(@ten) <= 0) return
	if(len(@diachi) <= 0) return
	if(len(@sdt) <= 0) return
	insert into NhaCungCap (TenNCC, DiaChi, SDT)
	values (@ten, @diachi, @sdt)
end
go
create proc suancc(@ma int, @ten nvarchar(100), @diachi nvarchar(100), @sdt nvarchar(20))
as begin
	if(len(@ten) > 0)
	begin
		update NhaCungCap set TenNCC = @ten where MaNCC = @ma
	end
	if(len(@diachi) > 0)
	begin
		update NhaCungCap set DiaChi = @diachi where MaNCC = @ma
	end
	if(len(@sdt) > 0)
	begin
		update NhaCungCap set SDT = @sdt where MaNCC = @ma
	end
end
go
create proc xoancc(@ma int)
as begin
	if(@ma not in(select MaNCC from NhaCungCap)) return
	if(@ma in (select MaNCC from PhieuNhap)) 
	begin
		update PhieuNhap set MaNCC = null where MaNCC = @ma	
	end
	delete NhaCungCap where MaNCC = @ma
end
---------------

---
--PhieuNhap
go
create proc thempn (@ncc int, @ngaylap date)
as begin
	if(@ncc not in (select MaNCC from NhaCungCap)) return
	insert into PhieuNhap (MaNCC, NgayLap)
	values (@ncc, @ngaylap)
end
go
create proc suapn (@ma int, @ncc int, @ngaylap date)
as begin
	if(@ma not in (select MaPN from PhieuNhap)) return
	
	if(@ncc = 0)
	begin
		update PhieuNhap set MaNCC = null where MaPN = @ma
	end
	else if(@ncc != 0 and @ncc in (select MaNCC from NhaCungCap))
	begin
		update PhieuNhap set MaNCC = @ncc where MaPN = @ma
	end
	if(DATEDIFF(DAYOFYEAR, '1900-1-1', @ngaylap) > 0)
	begin
		update PhieuNhap set NgayLap = @ngaylap where MaPN = @ma
	end
end
go
create proc xoapn (@ma int)
as begin
	if(@ma not in(select MaPN from PhieuNhap)) return
	if(@ma in (select MaPN from ChiTietPN))
	begin
		delete ChiTietPN where MaPN = @ma
	end
	
	delete PhieuNhap where MaPN = @ma
end

--- ChiTietPN
go
create proc themctpn (@mapn int, @mavt int, @soluong int)
as begin
	if(@mapn not in (select MaPN from PhieuNhap)) return
	if(@mavt not in (select MaVT from VatTu)) return
	if(@soluong < 0) return
	
	insert into ChiTietPN (MaPN, MaVT, SoLuong)
	values (@mapn, @mavt, @soluong)
end
go
create proc suactpn(@mapn int, @mavt int, @soluong int)
as begin
	if(@soluong >= 0)
	begin
		update ChiTietPN set SoLuong = @soluong where MaPN = @mapn and MaVT = @mavt
	end
end
go
create proc xoactpn (@mapn int, @mavt int)
as begin
	delete ChiTietPN where MaPN = @mapn and MaVT = @mavt
end
-- CuaHang
go
create proc themch (@ten nvarchar(100), @diachi nvarchar(100), @sdt nvarchar(20))
as begin
	if(len(@ten) <= 0) return
	if(len(@diachi) <= 0) return
	if(len(@sdt) <= 0) return
	insert into CuaHang (TenCH, DiaChi, SDT)
	values (@ten, @diachi, @sdt)
end
go
create proc suach(@ma int, @ten nvarchar(100), @diachi nvarchar(100), @sdt nvarchar(20))
as begin
	if(len(@ten) > 0)
	begin
		update CuaHang set TenCH = @ten where MaCH = @ma
	end
	if(len(@diachi) > 0)
	begin
		update CuaHang set DiaChi = @diachi where MaCH = @ma
	end
	if(len(@sdt) > 0)
	begin
		update CuaHang set SDT = @sdt where MaCH = @ma
	end
end
go
create proc xoach(@ma int)
as begin
	if(@ma not in(select MaCH from CuaHang)) return
	if(@ma in (select MaCH from PhieuXuat)) 
	begin
		update PhieuXuat set MaCH = null where MaCH = @ma	
	end
	delete CuaHang where MaCH = @ma
end
---------------

---
--PhieuXuat
go
create proc thempx (@ch int, @ngaylap date)
as begin
	if(@ch not in (select MaCH from CuaHang)) return
	insert into PhieuXuat (MaCH, NgayLap)
	values (@ch, @ngaylap)
end
go
create proc suapx (@ma int, @ch int, @ngaylap date)
as begin
	if(@ma not in (select MaPX from PhieuXuat)) return
	
	if(@ch = 0)
	begin
		update PhieuXuat set MaCH = null where MaPX = @ma
	end
	else if(@ch != 0 and @ch in (select MaCH from CuaHang))
	begin
		update PhieuXuat set MaCH = @ch where MaPX = @ma
	end
	if(DATEDIFF(DAYOFYEAR, '1900-1-1', @ngaylap) > 0)
	begin
		update PhieuXuat set NgayLap = @ngaylap where MaPX = @ma
	end
end
go
create proc xoapx (@ma int)
as begin
	if(@ma not in(select MaPX from PhieuXuat)) return
	if(@ma in (select MaPX from ChiTietPX))
	begin
		delete ChiTietPX where MaPX = @ma
	end
	
	delete PhieuXuat where MaPX = @ma
end

--- ChiTietPX
go
create proc themctpx (@mapx int, @mavt int, @soluong int)
as begin
	if(@mapx not in (select MaPX from PhieuXuat)) return
	if(@mavt not in (select MaVT from VatTu)) return
	if(@soluong < 0) return
	
	insert into ChiTietPX (MaPX, MaVT, SoLuong)
	values (@mapx, @mavt, @soluong)
end
go
create proc suactpx(@mapx int, @mavt int, @soluong int)
as begin
	if(@soluong >= 0)
	begin
		update ChiTietPX set SoLuong = @soluong where MaPX = @mapx and MaVT = @mavt
	end
end
go
create proc xoactpx (@mapx int, @mavt int)
as begin
	delete ChiTietPX where MaPX = @mapx and MaVT = @mavt
end

