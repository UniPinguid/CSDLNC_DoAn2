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