-- Hàm tính tổng doanh thu theo tháng
create procedure getRevenueByMonth @month int, @year int
as
begin
	select SUM(h.ThanhTien)
	from HOADON h
	where MONTH(h.NgayMua) = @month and YEAR(h.NgayMua) = @year
end
go

exec getRevenueByMonth 02, 2012

-- Hàm tính tổng doanh thu theo năm
create procedure getRevenueByYear @year int
as
begin
	select SUM(h.ThanhTien)
	from HOADON h
	where YEAR(h.NgayMua) = @year
end
go

exec getRevenueByYear 2012

-- Hàm xuất ra doanh thu theo 12 tháng của 1 năm
create procedure getRevenueMonthly @year int
as
begin
	select MONTH(h.NgayMua) as 'Month', SUM(h.ThanhTien) as 'Total revenue'
	from HOADON h
	where YEAR(h.NgayMua) = @year
	group by MONTH(h.NgayMua)
end
go

exec getRevenueMonthly 2012

-- Hàm tìm danh sách 100 sản phẩm bán chạy nhất theo ngày
create procedure getTopSellerDaily
as
begin	
	select top 100 sp.SP_ID, sp.TenSP, sp.ThuongHieu, SUM(ct.SoLuong) as 'Sold'
	from CT_HoaDon ct, SANPHAM sp, HOADON h
	where ct.SP_ID = sp.SP_ID and h.HD_ID = ct.HD_ID
	      and h.NgayMua = GETDATE()
	group by sp.SP_ID, sp.TenSP, sp.ThuongHieu
	order by Sold desc
end
go
	
exec getTopSellerDaily
	
-- Hàm tìm danh sách 100 sản phẩm bán chạy theo tuần
create procedure getTopSellerWeekly
as
begin	
	select top 100 sp.SP_ID, sp.TenSP, sp.ThuongHieu, SUM(ct.SoLuong) as 'Sold'
	from CT_HoaDon ct, SANPHAM sp, HOADON h
	where ct.SP_ID = sp.SP_ID and h.HD_ID = ct.HD_ID
	      and h.NgayMua >= DATEADD(day,-7, GETDATE())
	group by sp.SP_ID, sp.TenSP, sp.ThuongHieu
	order by Sold desc
end
go
	
exec getTopSellerWeekly
	
-- Hàm tìm danh sách 100 sản phẩm bán chạy theo tháng
create procedure getTopSellerMonthly
as
begin	
	select top 100 sp.SP_ID, sp.TenSP, sp.ThuongHieu, SUM(ct.SoLuong) as 'Sold'
	from CT_HoaDon ct, SANPHAM sp, HOADON h
	where ct.SP_ID = sp.SP_ID and h.HD_ID = ct.HD_ID
	      and h.NgayMua >= DATEADD(day,-30, GETDATE())
	group by sp.SP_ID, sp.TenSP, sp.ThuongHieu
	order by Sold desc
end
go
	
exec getTopSellerMonthly

-- Hàm tìm danh sách 100 sản phẩm bán chạy theo năm
create procedure getTopSellerYearly
as
begin	
	select top 100 sp.SP_ID, sp.TenSP, sp.ThuongHieu, SUM(ct.SoLuong) as 'Sold'
	from CT_HoaDon ct, SANPHAM sp, HOADON h
	where ct.SP_ID = sp.SP_ID and h.HD_ID = ct.HD_ID
	      and h.NgayMua >= DATEADD(day,-365, GETDATE())
	group by sp.SP_ID, sp.TenSP, sp.ThuongHieu
	order by Sold desc
end
go
	
exec getTopSellerYearly

-- Hàm tìm danh sách sản phẩm bán chạy nhất mọi thời đại
create procedure getTopSellerAllTime
as
begin	
	select top 100 sp.SP_ID, sp.TenSP, sp.ThuongHieu, SUM(ct.SoLuong) as 'Sold'
	from CT_HoaDon ct, SANPHAM sp, HOADON h
	where ct.SP_ID = sp.SP_ID and h.HD_ID = ct.HD_ID
	group by sp.SP_ID, sp.TenSP, sp.ThuongHieu
	order by Sold desc
end
go
	
exec getTopSellerAllTime

-- Hàm lấy thông tin sản phẩm
create procedure getProduct @ID CHAR(10)
as
begin
	select *, (select SUM(ct.SoLuong)
	           from CT_HoaDon ct
	           where ct.SP_ID = @ID) sold
	from SANPHAM sp, NhomSP n
	where sp.SP_ID = @ID and n.GrSP_ID = sp.GrSP_ID
end
go

exec getProduct '04319'


go
	
-- Test
select SUM(t.ThanhTien)	
from (select ct.HD_ID, sp.SP_ID, ct.SoLuong, sp.Gia, ThanhTien = sp.Gia * ct.SoLuong
	  from CT_HoaDon ct, SANPHAM sp
	  where ct.SP_ID = sp.SP_ID AND HD_ID = '00409') t
	  
select SUM(h.ThanhTien)
from HOADON h
where HD_ID = '00409'

go
create proc addCustomerAddress @KhachHangID char(10), @Receiver nvarchar(20),
							   @HouseNumber int, @Street nvarchar(20), @Ward nvarchar(20), @District nvarchar(20), @Province nvarchar(20)
as
begin
declare @OrdinalNumber int
set @OrdinalNumber = ( select count(*) from DiaChi_KH where KH_ID = @KhachHangID)
set @OrdinalNumber = @OrdinalNumber + 1
insert into DiaChi_KH(KH_ID, STT, SoNha, TenNguoiNhan, Duong, XaPhuong, Quan ,Tinh)
values (@KhachHangID, @OrdinalNumber, @HouseNumber, @Receiver, @Street, @Ward, @District, @Province)
end
go

go
--Đăng ký khách hàng--
create proc SignUpCustomer @KhachHangID char(10), @Name nvarchar(20), @PhoneNumber char(10), @Email char(30), @Gender nvarchar(3), @Birthday datetime, 
						   @HouseNumber int, @Street nvarchar(20), @Ward nvarchar(20), @District nvarchar(20), @Province nvarchar(20),
						   @username char(10), @password char(20)
as
begin
	insert into KHACHHANG(KH_ID, TenKH, SoDienThoai, Email, Phai, NgaySinh, SoBe)
	values (@KhachHangID, @Name, @PhoneNumber, @Email, @Gender, @Birthday, 0)

	insert into NGUOIDUNG(username, password, VaiTro, KH_ID, NV_ID)
	values (@username, @password, 0, @KhachHangID, null)
	
	exec addCustomerAddress @KhachHangID , @Name, @HouseNumber, @Street, @Ward, @District, @Province
end
go

--Cập nhật địa chỉ--
create proc UpdateAddress @ID char(10), @STT int, @SoNha int, @Duong nvarchar(20), @XaPhuong nvarchar(20), @Quan nvarchar(20), @Tinh nvarchar(20)
as
update DiaChi_KH
set Duong = @Duong,
	SoNha = @SoNha,
	XaPhuong = @XaPhuong,
	Quan = @Quan,
	Tinh = @Tinh
where STT = @STT and @ID = KH_ID
go
--Cập nhật khách hàng--
create proc UpdateCustomer @ID char(10), @TenKH nvarchar(20), @Email nvarchar(30), @NgaySinh datetime, @Phai nvarchar(3), @SDT char(10)
as
update KHACHHANG
set TenKH = @TenKH,
	Email = @Email,
	NgaySinh = @NgaySinh,
	SoDienThoai = @SDT,
	Phai = @Phai
where KH_ID = @ID
GO
--Cập nhật con khách hàng--
create proc updateKid @ID char(10), @Ten nvarchar(20), @Phai nvarchar(3), @NgaySinh datetime, @STT INT
as
update Con_KH
set Ten = @Ten,
	Phai = @Phai,
	NgaySinh = @NgaySinh
where KH_ID = @ID and @STT = STT