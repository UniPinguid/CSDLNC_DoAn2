create database CONCUNG
go

use CONCUNG
go


create table KHACHHANG
(
	KH_ID char(10) not null, 
	TenKH nvarchar(20),
	SoDienThoai char(10) not null,
	Email char(30),
	Phai nvarchar(3),
	NgaySinh datetime,
	SoBe int
)
go


create table Con_KH
(
	KH_ID char(10) not null,
	STT int not null,
	Ten nvarchar(20),
	Phai nvarchar(3),
	NgaySinh datetime
)
go

create  table DiaChi_KH 
(
	KH_ID char(10) not null,
	TenNguoiNhan nvarchar(20),
	STT int not null,
	SoNha int,
	Duong nvarchar(20),
	XaPhuong nvarchar(20),
	Quan nvarchar(20),
	Tinh nvarchar(20)
)
go


create table SANPHAM
(
	SP_ID char(10) not null,
	TenSP nvarchar(20),
	Gia float,
	MoTa nvarchar(50),
	SLTon int,
	ThuongHieu nvarchar(20),
	KhuyenMai float,
	NgayBatDau datetime,
	NgayKetThuc datetime,
	GrSP_ID char(10) not null
)
go


create table LichSuGia
(
	SP_ID char(10) not null,
	ThoiGian datetime not null,
	Gia float
)

create table HOADON
(
	HD_ID char(10) not null,
	NgayMua datetime,
	DiaChiGiaoHang char(50),
	TienHang float,
	PhiVanChuyen float,
	TrangThai int,
	GiamGia float,
	ThanhTien float,
	PhuongThucThanhToan char(10),
	HoaToc bit,
	DonViVanChuyen nvarchar(30),
	NV_ID char(10) not null,
	KH_ID char(10) not null
)
go

create table CT_HoaDon
(
	HD_ID char(10) not null,
	SP_ID char(10) not null,
	SoLuong int
)
go

create table XuatHang
(
	XH_ID char(10) not null,
	DonViVanChuyen nvarchar(30)
)
go

create table NHANVIEN
(
	NV_ID char(10) not null,
	Ten_NV nvarchar(20),
	Phai_NV nvarchar(3),
	CMND_NV char(9) not null,
	NgaySinhNV datetime,
	DiaChiNV nvarchar(50),
	KPI_NV float,
	PhongBan nvarchar(30),
	Luong float

)
go


create table XH_SP
(
	XH_ID char(10) not null,
	SP_ID char(10) not null,
	ThoiGianXuat datetime,
	SoLuongXuat int
)
go

create table DonNhapHang
(
	NH_ID char(10) not null,
	NgayNhapHang datetime,
	NCC nvarchar(30),
	TienNhap float,
	SP_ID char(10) not null
)
go


create table NGUOIDUNG
(
	username char(20) not null,
	KH_ID char(10),
	NV_ID char(10) ,
	password char(20) not null,
	VaiTro int not null
)
go

create table NhomSP
(
	GrSP_ID char(10) not null,
	TenNhom nvarchar(30)
)
go

--PRIMARY KEY--

alter table KHACHHANG
add constraint PK_KHACHHANG primary key (KH_ID)
go

alter table SANPHAM
add constraint PK_SANPHAM primary key (SP_ID)
go

alter table HOADON
add constraint PK_HOADON primary key (HD_ID)
go

alter table NHANVIEN
add constraint PK_NHANVIEN primary key (NV_ID)
go

alter table DonNhapHang
add constraint PK_DONNHAPHANG primary key (NH_ID)
go

alter table Con_KH
add constraint PK_CONKH primary key (KH_ID, STT)
go

alter table DiaChi_KH
add constraint PK_DIACHI primary key (KH_ID, STT)
go

alter table CT_HOADON
add constraint PK_CTHD primary key (HD_ID, SP_ID)
go

alter table XuatHang 
add constraint PK_XUATHANG primary key (XH_ID)
go

alter table XH_SP 
add constraint PK_XHSP primary key (XH_ID, SP_ID)
go

alter table NGUOIDUNG
add constraint PK_NGUOIDUNG primary key (username)
go

alter table NhomSP
add constraint PK_NHOMSP primary key (GrSP_ID)

alter table LichSuGia
add constraint PK_LICHSUGIA primary key (SP_ID, ThoiGian)
go

--FOREIGN KEY--

alter table Con_KH
add constraint FK_CONKH_KHID foreign key (KH_ID) references KHACHHANG(KH_ID)
go

alter table DiaChi_KH
add constraint FK_DIACHI_KHID foreign key (KH_ID) references KHACHHANG(KH_ID)
go

alter table CT_HoaDon
add constraint FK_CTHD_HD foreign key (HD_ID) references HOADON(HD_ID)
go

alter table CT_HoaDon
add constraint FK_CTHD_SP foreign key (SP_ID) references SANPHAM(SP_ID)
go

alter table XH_SP
add constraint FK_XHSP_XHID foreign key (XH_ID) references XuatHang(XH_ID)
go

alter table DonNhapHang
add constraint FK_NHAPHANG_SPID foreign key (SP_ID) references SANPHAM(SP_ID)
go

alter table HOADON
add constraint FK_HOADON_NVID foreign key (NV_ID) references NHANVIEN(NV_ID)
go

alter table NGUOIDUNG
add constraint FK_USER_NVID foreign key (NV_ID) references NHANVIEN(NV_ID)
go

alter table NGUOIDUNG
add constraint FK_USER_KHID foreign key (KH_ID) references KHACHHANG(KH_ID)
go

alter table XH_SP
add constraint FK_XHSP_SPID foreign key (SP_ID) references SANPHAM(SP_ID)
go

alter table HOADON
add constraint FK_HOADON_KHID foreign key (KH_ID) references KHACHHANG(KH_ID)
go

alter table SANPHAM
add constraint FK_NHOMSP_GRSPID foreign key (GrSP_ID) references NhomSP(GrSP_ID)
go

alter table LichSuGia
add constraint FK_LICHSUGIA_SPID foreign key (SP_ID) references SANPHAM(SP_ID)
go
-----------


alter table KHACHHANG
add constraint uniqueKH_SoDienThoai UNIQUE(SoDienThoai)
go

alter table NHANVIEN
add constraint uniqueNV_CMND UNIQUE(CMND_NV)
go

-----
--Tính tiền hàng--
create trigger TinhTienHang_insert
on CT_HoaDon
after insert as
update HOADON
set HOADON.TienHang = (100-s.KhuyenMai)*i.SoLuong*s.Gia*0.01
from inserted i, HOADON h, SANPHAM s
where i.HD_ID = h.HD_ID and i.SP_ID = s.SP_ID

go

--Tình thành tiền--
create trigger TinhThanhTien
on HOADON
after update as
update HOADON
set HOADON.ThanhTien = i.TienHang*(100-i.GiamGia)*0.01+i.PhiVanChuyen
from HOADON h inner join inserted i on i.HD_ID = h.HD_ID
go

-- Tính tổng tiền hóa đơn
update HOADON
set ThanhTien = f.total
from HOADON h, (select a.HD_ID, SUM(a.ThanhTien) as total
                from (select ct.HD_ID, ThanhTien = sp.Gia * ct.SoLuong
	                  from CT_HoaDon ct, SANPHAM sp
	                  where ct.SP_ID = sp.SP_ID) a
	            group by a.HD_ID) f
where h.HD_ID = f.HD_ID

-- Nếu khuyến mãi lớn hơn giá thì khuyến mãi 50%
update SANPHAM
set KhuyenMai = Gia * 50/100
where KhuyenMai > Gia


--Thêm bảng lương--

create table LichSuLuong
(
	NV_ID char(10) not null,
	ThoiGian datetime not null,
	Luong float
)


alter table LichSuLuong
add constraint PK_LICHSULUONG primary key (NV_ID, ThoiGian)
go

alter table LichSuLuong
add constraint FK_LICHSULUONG_NVID foreign key (NV_ID) references NHANVIEN(NV_ID)
go