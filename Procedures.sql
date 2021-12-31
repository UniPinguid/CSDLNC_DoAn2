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
alter procedure getRevenueMonthly @year int
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



	
-- Test
select SUM(t.ThanhTien)	
from (select ct.HD_ID, sp.SP_ID, ct.SoLuong, sp.Gia, ThanhTien = sp.Gia * ct.SoLuong
	  from CT_HoaDon ct, SANPHAM sp
	  where ct.SP_ID = sp.SP_ID AND HD_ID = '00409') t
	  
select SUM(h.ThanhTien)
from HOADON h
where HD_ID = '00409'