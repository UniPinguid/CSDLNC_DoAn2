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