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