﻿create database QLSinhVien_EF_ASP
go

use QLSinhVien_EF_ASP
go

create table Khoa
(
	MaKhoa int primary key,
	TenKhoa nvarchar(100)
)
go

create table Lop
(
	MaLop varchar(8) primary key,
	Gvcn nvarchar(100),
	Siso int,
	MaKhoa int foreign key references Khoa(MaKhoa)
)
go

create table SinhVien
(
	MaSV varchar(5) primary key,
	Hoten nvarchar(50),
	DiaChi nvarchar(100),
	MaLop varchar(8) foreign key references Lop(MaLop)
)
go

insert into Khoa
values
	(1, 'CNTT'),
	(2, 'Dien'),
	(3, 'Hoa hoc'),
	(4, 'Xay dung')

insert into Lop
values
	('21T3', 'Nguyễn Văn Phát', 40, 1),
	('21T1', 'Trần Bửu Dung', 35, 1),
	('21T2', 'Nguyễn Thị Hà Quyên', 45, 1),
	('21DT1', 'Hồ Văn Dũng', 28, 2)

insert into SinhVien
values
	('33701', N'Nguyễn Hồ Thành Nhân', N'Thừa Thiên Huế', '21T3'),
	('33702', N'Hồ Thành Nhân', N'Quảng Bình', '21T3'),
	('33703', N'Thành Nhân', N'Quảng Nam', '21T3'),
	('33704', N'Nguyễn Nhân', N'Quảng Trị', '21T3')