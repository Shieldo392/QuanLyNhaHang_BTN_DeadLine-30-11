use master
go
create database QuanLyBanHang_ver2
go
use QuanLyBanHang_ver2
go

create table QuanLy(maQL nchar(10) not null primary key,
					pass nchar(30) not null,
					tenQL nvarchar(30) not null,
					gioiTinh nchar(10), 
					  diaChi nvarchar(30),
					  namSinh int,
					  soDt nchar(10) not null)

create table NhanVien(maNv nchar(30) not null primary key,
					  matKhau nchar(30) not null,
					  tenNv nvarchar(30) not null,
					  gioiTinh nchar(10), 
					  diaChi nvarchar(30),
					  namSinh int,
					  soDt nchar(10) not null)
create table NhaCungCap(maNCC int Identity(1,1) primary key,
						tenNCC nvarchar(30) not  null,
						diaChi nvarchar(30),
						soDT nchar(10) not null)
create table SanPham(maSP int Identity(1,1) primary key,
					 tenSP nvarchar(30) not null,
					 soLuong int,
					 donGia int,)

create table KhachHang(maKH int identity primary key,
						tenKH nvarchar(30) not null,
						diaChi nvarchar(100),
						sdt nchar(30))


create table HoaDon(maHD nchar(10) primary key not null,
					ngayNhap date,
					maKH int,
					Constraint FK_KH foreign key (maKH) references KhachHang(maKH)
					)

create table ChiTietHD(maHD nchar(10) not null,
						maSP int,
						soLuong int,
						donGiaBan int,
						maNV nchar(30) not null,
						constraint PK_HD_SP primary key (maHD, maSP),
						constraint Fk_HD foreign key (maHD) references HoaDon(maHD),
						constraint Fk_SP foreign key (maSP) references SanPham(maSP),
						constraint Fk_nv foreign key(maNV) references NhanVien(maNV))
create table HDNhap(maHDN nchar(30) not null primary key,
				    maNCC int,
					ngayNhap date)
create table chiTietNhap(maHDN nchar(30) not null,
						 maSP int,
						 soLuongNhap int,
						 donGia int,
						 constraint PK primary key(maHDN, maSP),
						 constraint Fk_HD1 foreign key (maHDN) references HDNhap(maHDN),
						constraint Fk_SP1 foreign key (maSP) references SanPham(maSP))

/* nghiên cứu thêm cách nhập hàng và ràng buộc khác!*/

go
-- dữ liệu quản lý
insert into QuanLy values('Admin', 'admin', N'Nguyễn văn anh',N'Nam', N'hà Tây', 2000, '0912723456')
insert into QuanLy values('tranA', '1234', N'Nguyễn văn Bình', N'Nữ', N'hà Đông', 2001,'0912723456')

go
--dữ liệu nhân viên
insert into NhanVien values('A nguyen', 'nguyena', N'Nguyễn văn A',N'Nam', N'hà Tây', 2000, '0912723456')
insert into NhanVien values('B nguyen', 'nguyenb', N'Nguyễn văn B', N'Nữ', N'hà Đông', 2001,'0912723456')
insert into NhanVien values( 'C nguyen', 'nguyenc',N'Nguyễn văn C', N'Nam', N'Mỹ đình', 1998, '0912723456')
insert into NhanVien values('D nguyen', 'nguyend', N'Nguyễn văn D', N'Nữ', N'Cầu giấy', 1999, '0912723456')
insert into NhanVien values('shieldo', 'nguyena', N'Nguyễn văn A',N'Nam', N'hà Tây', 2000, '0912723456')
go
--dữ liệu khách hàng
insert into KhachHang values(N'Nguyễn Văn A', N'Bắc Ninh', '0943556567')
insert into KhachHang values(N'Nguyễn Văn c', N'Hà Tây', '0943556567')
insert into KhachHang values(N'Nguyễn Văn d', N'Hưng yên', '0943556567')
insert into KhachHang values(N'Nguyễn Văn e', N'Hà Nội', '0943556567')
insert into KhachHang values(N'Nguyễn Văn f', N'Lào cai', '0943556567')
select * from KhachHang
go

select * from NhanVien
go
-- dữ liệu hóa đơn
insert into HoaDon values('hd1', '1/6/2020', 2)
insert into HoaDon values('hd2', '5/7/2020', 3)
insert into HoaDon values('hd3', '2/8/2020', 4)
insert into HoaDon values('hd4', '3/9/2020', 2)
insert into HoaDon values('hd5', '4/10/2020', 1)


select * from NhaCungCap
go
-- dữ liệu nhà cung cấp
insert into NhaCungCap values(N'NowFood', N'Hà Nội', '09564131')
insert into NhaCungCap values(N'GrabFood', N'Thái Nguyêm', '09564131')
insert into NhaCungCap values(N'Bee', N'Hà Tây', '09564131')
insert into NhaCungCap values(N'Gojeck', N'Hà Nam', '09564131')
insert into NhaCungCap values(N'Hoang Long', N'Hà Nội', '09564131')
insert into NhaCungCap values(N'Vinmart', N'Ba ĐÌnh', '09564131')
go
-- dữ liệu sản phẩm

select * from SanPham
insert into SanPham values(N'Lẩu cua', 550, 550)
insert into SanPham values(N'Khăn ướt', 10, 10)
insert into SanPham values(N'Thịt bò', 140, 140)
insert into SanPham values(N'Tràng lợn ', 150, 150)
insert into SanPham values(N'Tôm', 140, 140)
insert into SanPham values(N'Sụn', 140, 140)
insert into SanPham values(N'Kê gà', 200, 200)
insert into SanPham values(N'Nước lẩu', 50, 50)
insert into SanPham values(N'Rau', 40, 40)
insert into SanPham values(N'Nấm Kim', 20, 20)
insert into SanPham values(N'Xôi chiên', 40, 40)
insert into SanPham values(N'Khoai lang kén', 30, 30)
insert into SanPham values(N'Ngô chiên', 30, 30)
insert into SanPham values(N'Dưa chuột', 10, 10)
insert into SanPham values(N'Rượu voska', 70, 70)
insert into SanPham values(N'Rượu táo', 40, 40)
insert into SanPham values(N'Rượu nếp', 40, 40)
insert into SanPham values(N'Lavi', 10, 10)
insert into SanPham values(N'Trà Đá', 10, 10)
insert into SanPham values(N'Nước ngọt', 10, 10)
insert into SanPham values(N'Bia Sài gòn', 13, 13)
insert into SanPham values(N'Thuốc lá 3 số', 50, 50)
insert into SanPham values(N'Thuốc lá Thăng long', 15, 15)

go
--dữ liệu chi tiết hóa đơn
select * from ChiTietHD
insert into ChiTietHD values('hd1', 7, 2, 135, 'A nguyen')
insert into ChiTietHD values('hd1', 8, 1, 35, 'A nguyen')
insert into ChiTietHD values('hd1', 10, 3, 135, 'C nguyen')
insert into ChiTietHD values('hd1', 13, 1, 135, 'B nguyen')
insert into ChiTietHD values('hd2', 7, 1, 235, 'D nguyen')
insert into ChiTietHD values('hd2', 8, 4, 435, 'A nguyen')





go
--dữ liệu hóa đơn nhập hàng
select * from HDNhap
insert into HDNhap values('hdn1', 1, '3/6/2020')
insert into HDNhap values('hdn2', 2, '8/9/2020')
insert into HDNhap values('hdn3', 3, '5/10/2020')
insert into HDNhap values('hdn4', 2, '2/1/2020')
insert into HDNhap values('hdn5', 1, '1/2/2020')
insert into HDNhap values('hdn6', 4, '8/4/2020')
go
-- dữ liệu chi tiết hóa đơn nhập
select * from chiTietNhap
insert into chiTietNhap values('hdn1', 1, 500, 120)
insert into chiTietNhap values('hdn2', 2, 200, 150)
insert into chiTietNhap values('hdn3', 1, 200, 170)
insert into chiTietNhap values('hdn1', 2, 300, 220)
insert into chiTietNhap values('hdn4', 3, 500, 120)
insert into chiTietNhap values('hdn5', 4, 200, 120)
insert into chiTietNhap values('hdn6', 3, 100, 120)


--
Select HoaDon.maHD , tenKH, KhachHang.diaChi, KhachHang.sdt, HoaDon.ngayNhap
from HoaDon inner join KhachHang on HoaDon.maKH = KhachHang.maKH

--
select ChiTietHD.maSP, tenSP, ChiTietHD.soLuong, donGia, (ChiTietHD.soLuong*donGia) as 'tongTien'
from ChiTietHD inner join SanPham on ChiTietHD.maSP = SanPham.maSP
where maHD = 'hd1'

update SanPham set donGia = 10 where tenSP = N'Khăn ướt'
--
--test---
Select SanPham.maSP, tenSP, ChiTietHD.soLuong, ChiTietHD.donGiaBan from SanPham inner join ChiTietHD on SanPham.maSP = ChiTietHD.maSP where maHD = 'hd1'
-- test
Update ChiTietHD set soLuong = 2, maNV = 'A Nguyen' where maHD = 'hd1' and maSP = 2
select * from ChiTietHD where  maHD = 'hd1' and maSP = 2
--
delete from HoaDon where maHD =''
select * from HoaDon

select HoaDon.maHD, tenKH, diaChi, sdt, ngayNhap from
                HoaDon inner join KhachHang on HoaDon.maKH = KhachHang.maKH 
               where tenKH LIKE N'%a%'
			   

select * from KhachHang
select * from chiTietNhap
select * from HDNhap inner join chiTietNhap on HDNhap.maHDN = chiTietNhap.maHDN

Select HDNhap.maHDN, tenNCC, ngayNhap, tenSP, soLuongNhap, chiTietNhap.donGia 
                from HDNhap inner join chiTietNhap on HDNhap.maHDN = chiTietNhap.maHDN 
                inner join SanPham  on SanPham.maSP = chiTietNhap.maSP 
                inner join NhaCungCap on HDNhap.maNCC = NhaCungCap.maNCC
				order by ngayNhap desc

Select tenSP, chiTietNhap.soLuongNhap, chiTietNhap.donGia from chiTietNhap inner join SanPham on chiTietNhap.maSP = SanPham.maSP where maHDN = 'hdn1'
Update chiTietNhap set  soLuongNhap = 20, donGia = 100 where chiTietNhap = '{2}' and maSP = {3}