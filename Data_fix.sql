USE CONCUNG
GO
update NHANVIEN
set PhongBan = N'Nhân Sự'
where PhongBan = N'Phòng nhân sự' or PhongBan = N'Phòng hành chính'
go

update NHANVIEN
SET PhongBan = N'Quản Lý'
WHERE PhongBan = N'Phòng kinh doanh' or PhongBan = N'Phòng Kinh tế - Kỹ thuật'
GO
UPDATE NHANVIEN
SET PhongBan = N'Quản Trị'
WHERE PhongBan = N'Phòng tài vụ'
GO

CREATE TABLE KH_DATHANG(
	KH_ID CHAR(10) NOT NULL,
	SP_ID CHAR(10) NOT NULL,
	SoLuong INT,
	PRIMARY KEY (KH_ID, SP_ID),
	FOREIGN KEY (KH_ID) REFERENCES KHACHHANG(KH_ID),
	FOREIGN KEY (SP_ID) REFERENCES SANPHAM(SP_ID))
GO

CREATE PROC tinhTien @id CHAR(10), @tongTien FLOAT OUT
AS
BEGIN TRAN
	BEGIN TRY
		SET @tongTien = 0
		IF(NOT EXISTS (SELECT * FROM KH_DATHANG WHERE KH_ID = @id))
		BEGIN
			COMMIT TRAN
			RETURN
		END

		SELECT @tongTien = SUM(sp.Gia * dh.SoLuong)
		FROM KH_DATHANG dh, SANPHAM sp
		WHERE dh.KH_ID= @id AND dh.SP_ID = sp.SP_ID
	END TRY
	BEGIN CATCH
		PRINT(N'Lỗi hệ thống')
		ROLLBACK TRAN
		RETURN
	END CATCH
COMMIT TRAN
GO

CREATE PROCEDURE TaoHoaDon @diaChi CHAR(50), @idKH CHAR(10), @result INT OUT, @idHD CHAR(8)
AS
BEGIN TRAN
	BEGIN TRY
		SET @result = 0
		IF(NOT EXISTS (SELECT * FROM KH_DATHANG WHERE KH_ID = @idKH))
		BEGIN
			COMMIT TRAN
			RETURN
		END

		INSERT INTO HOADON(HD_ID,NgayMua, DiaChiGiaoHang, PhiVanChuyen, TrangThai, GiamGia,NV_ID,KH_ID)
		VALUES (@idHD,GETDATE(),@diaChi,0,0,0,'NV45898028',@idKH)
		SET @result = 1
	END TRY
	BEGIN CATCH
		SET @result = -1
		ROLLBACK TRAN
		RETURN
	END CATCH
COMMIT TRAN
GO

CREATE PROCEDURE ThemChiTietHoaDon @idKH CHAR(10), @idHD CHAR(10), @result INT OUT
AS
BEGIN TRAN
	BEGIN TRY
		IF (NOT EXISTS (SELECT * FROM KH_DATHANG WHERE KH_ID = @idKH))
		BEGIN
			SET @result = 0
			COMMIT TRAN
			RETURN
		END

		INSERT INTO CT_HoaDon(SP_ID,SoLuong,HD_ID)
		SELECT SP_ID,SoLuong,@idHD FROM KH_DATHANG WHERE KH_ID = @idKH

		DELETE KH_DATHANG
		WHERE KH_ID = @idKH
		SET @result = 1
	END TRY

	BEGIN CATCH
		SET @result = -1
		ROLLBACK TRAN
		RETURN
	END CATCH
COMMIT TRAN
GO
USE CONCUNG
GO

CREATE PROC CapNhatKhuyenMai @id CHAR(10), @newGia FLOAT, @newDiscount FLOAT, @ngayBD DATETIME, @ngayKT DATETIME, @result INT OUT
AS
BEGIN TRAN
	BEGIN TRY
		IF (NOT EXISTS (SELECT * FROM SANPHAM WHERE SP_ID = @id))
		BEGIN
			SET @result = 0
			COMMIT TRAN
			RETURN
		END

		UPDATE SANPHAM
		SET Gia = @newGia,
			KhuyenMai = @newDiscount,
			NgayBatDau = @ngayBD,
			NgayKetThuc = @ngayKT
		WHERE SP_ID = @id

		SET @result = 1
	END TRY
	BEGIN CATCH
		SET @result = -1
		ROLLBACK TRAN
		RETURN
	END CATCH
COMMIT TRAN
GO

CREATE PROC TinhTongDoanhThuThang @time DATETIME, @tongDoanhThu FLOAT OUT
AS
BEGIN TRAN
	BEGIN TRY
		SELECT @tongDoanhThu = SUM(ThanhTien)
		FROM HOADON
		WHERE MONTH(NgayMua)=MONTH(@time) AND YEAR(NgayMua)= YEAR(@time)
	END TRY

	BEGIN CATCH
		PRINT (N'lỗi hệ thống')
		ROLLBACK TRAN
		RETURN
	END CATCH
COMMIT TRAN
GO

CREATE PROC TinhDoanhThu @month INT, @year INT, @tongDoanhThu FLOAT OUT
AS
BEGIN TRAN
	BEGIN TRY
		IF(@month = 0)
		BEGIN
			SELECT @tongDoanhThu = SUM(ThanhTien)
			FROM HOADON
			WHERE YEAR(NgayMua)=@year
		END
		ELSE
		BEGIN
			SELECT @tongDoanhThu = SUM(ThanhTien)
			FROM HOADON
			WHERE MONTH(NgayMua)=@month AND YEAR(NgayMua)=@year
		END
	END TRY

	BEGIN CATCH
		PRINT (N'lỗi hệ thống')
	END CATCH
COMMIT TRAN
GO

CREATE PROC TinhSales @month INT, @year INT, @tongSale INT OUT
AS
BEGIN TRAN
	BEGIN TRY
		IF(@month = 0)
		BEGIN
			SELECT @tongSale = SUM(ct.SoLuong)
			FROM HOADON hd left join CT_HoaDon ct on hd.HD_ID=ct.HD_ID
			WHERE YEAR(NgayMua)=@year
		END
		ELSE
		BEGIN
			SELECT @tongSale = SUM(ct.SoLuong)
			FROM HOADON hd left join CT_HoaDon ct on hd.HD_ID=ct.HD_ID
			WHERE YEAR(NgayMua)=@year AND MONTH(NgayMua)=@month
		END
	END TRY

	BEGIN CATCH
		PRINT (N'lỗi hệ thống')
		ROLLBACK TRAN
	END CATCH
COMMIT TRAN
GO

CREATE PROC AdvancedSearch @name NCHAR(30), @brand NCHAR(30), @department NCHAR(30)
AS
BEGIN TRAN
	BEGIN TRY
		SELECT * FROM SANPHAM sp left join NhomSP gr on sp.GrSP_ID = gr.GrSP_ID
		WHERE sp.TenSP LIKE N'%'+@name+'%' AND ThuongHieu LIKE N'%'+@brand+'%' AND  gr.TenNhom LIKE N'%'+@department+'%'
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		RETURN
	END CATCH
COMMIT TRAN
GO