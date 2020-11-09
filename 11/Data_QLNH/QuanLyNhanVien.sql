use master
go
create database QuanLyBanHang_ver2
go
use QuanLyBanHang_ver2
go
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
					 donGia money,
					 maNCC int,
					 constraint FK_SP_NCC foreign key (maNCC) references NhaCungCap(maNCC))

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
						donGiaBan money,
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
						 donGia money,
						 maNCC int,
						 constraint PK primary key(maHDN, maSP),
						 constraint Fk_HD1 foreign key (maHDN) references HDNhap(maHDN),
						constraint Fk_SP1 foreign key (maSP) references SanPham(maSP),
						constraint FK_NCC foreign key(maNCC) references NhaCungCap(maNCC))

/* nghiên cứu thêm cách nhập hàng và ràng buộc khác!*/

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
insert into SanPham values(N'Thịt bò', 300, 120, 1)
insert into SanPham values(N'Nấm', 300, 20, 2)
insert into SanPham values(N'Tim Lợn', 300, 120, 3)
insert into SanPham values(N'Cua ', 300, 150, 4)
insert into SanPham values(N'Tôm hùm', 300, 1000, 5)
insert into SanPham values(N'Rau', 300, 40, 6)
go
--dữ liệu chi tiết hóa đơn
select * from ChiTietHD
insert into ChiTietHD values('hd1', 1, 2, 135, 'A nguyen')
insert into ChiTietHD values('hd1', 2, 1, 35, 'A nguyen')
insert into ChiTietHD values('hd1', 3, 3, 135, 'C nguyen')
insert into ChiTietHD values('hd1', 4, 1, 135, 'B nguyen')
insert into ChiTietHD values('hd2', 2, 1, 235, 'D nguyen')
insert into ChiTietHD values('hd2', 3, 4, 435, 'A nguyen')





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
insert into chiTietNhap values('hdn1', 1, 500, 120, 1)
insert into chiTietNhap values('hdn2', 2, 200, 150, 2)
insert into chiTietNhap values('hdn3', 1, 200, 170, 1)
insert into chiTietNhap values('hdn1', 2, 300, 220, 3)
insert into chiTietNhap values('hdn4', 3, 500, 120, 4)
insert into chiTietNhap values('hdn5', 4, 200, 120, 1)
insert into chiTietNhap values('hdn6', 3, 100, 120, 2)


--
Select HoaDon.maHD , tenKH, KhachHang.diaChi, KhachHang.sdt, HoaDon.ngayNhap
from HoaDon inner join KhachHang on HoaDon.maKH = KhachHang.maKH
