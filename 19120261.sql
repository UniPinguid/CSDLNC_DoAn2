select * from nguoidung
select * from sanpham
go
create or alter proc editProduct @ID char(10), @Ten nvarchar(20), @Gia float, @MoTa nvarchar(50), @SLTon int, @ThuongHieu nvarchar(20), @KhuyenMai float, @NgayBatDau datetime,
	@NgayKetThuc datetime,
	@GrSP_ID char(10)
as 
begin
	if exists ( select * from SANPHAM where SP_ID = @ID)
		begin
			update SANPHAM
			set TenSP = @Ten,
				gia = @Gia,
				Mota = @MoTa,
				SLTon = @SLTon,
				ThuongHieu = @ThuongHieu,
				KhuyenMai = @KhuyenMai,
				NgayBatDau = @NgayBatDau,
				NgayKetThuc = @NgayKetThuc,
				GrSP_ID = @GrSP_ID
			where SP_ID = @ID
		end
	else
		begin
		insert into SANPHAM values (@ID, @Ten, @Gia, @MoTa, @SLTon, @ThuongHieu, @KhuyenMai, @NgayBatDau, @NgayKetThuc, @GrSP_ID)
		end
end


select * from NGUOIDUNG
select * from NHANVIEN where PhongBan like N'Qu?n tr?'
insert into NHANVIEN values ('k', null, null, '19120261',null,null,null,null,null)
update NHANVIEN set PhongBan = N'Qu?n Tr?' where NV_ID = 'k'
insert into nguoidung values ('k', null, 'k', 'k',1)
SELECT * FROM SANPHAM
select * from hoadon