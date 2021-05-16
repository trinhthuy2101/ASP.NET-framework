use DBServer
go

insert into University values('KHTN',N'KHOA HỌC TỰ NHIÊN') 
go
insert into University values('UIT',N'CÔNG NGHỆ THÔNG TIN')
go
insert into University values('USSH',N'KHOA HỌC XÃ HỘI VÀ NHÂN VĂN')
-----------
go
insert into Department values('A1','USSH')
go
insert into Department values('A2','USSH')
go
insert into Department values('I1','UIT')
go
insert into Department values('I2','UIT')
go
insert into Department values('K1','KHTN')
go
insert into Department values('K2','KHTN')
-----------
go
insert into Class values('19CTT2','K1','KHTN')
go
insert into Class values('19CNTN','K1','KHTN')
go
insert into Class values('19CTT1','K2','KHTN')
go
insert into Class values('19CTT3','K2','KHTN')
go
insert into Class values('19BC01','A1','USSH')
go
insert into Class values('19TT01','A1','USSH')
go
insert into Class values('19DL01','A2','USSH')
go
insert into Class values('19HQ01','A2','USSH')
go
insert into Class values('19KHMT','I1','UIT')
go
insert into Class values('19ATTT','I1','UIT')
go
insert into Class values('19HTTT','I2','UIT')
go
insert into Class values('19KTPM','I2','UIT')
go
--------------
insert into Student values('19120390',N'Trịnh Thị Thùy','21',N'Nữ','01/21/2000','19CTT2','K1','KHTN')
go
insert into Student values('19120330',N'Nguyễn Đoan Phúc','20',N'Nữ','12/28/2001','19CTT2','K1','KHTN')
go
insert into Student values('19120489',N'Lưu Trường Dương','21',N'Nam','3/4/2000','19CTT3','K2','KHTN')
go
insert into Student values('19120388',N'Nguyễn Nhật Hải','20',N'Nam','5/8/2001','19CTT3','K2','KHTN')
go
insert into Student values('19120376',N'Nguyễn Lê Bảo Thi','20',N'Nữ','5/8/2001','19CNTN','K1','KHTN')
go
insert into Student values('19120580',N'Lê Đức Minh','20',N'Nam','7/10/2001','19CNTN','K1','KHTN')
go
insert into Student values('19120123',N'Trịnh Xuân Thiện','20',N'Nam','3/25/2001','19CTT1','K2','KHTN')
go
insert into Student values('19120101',N'Trịnh Thị Minh Thư','20',N'Nữ','4/7/2001','19CTT1','K2','KHTN')
go
insert into Student values('19120001',N'Nguyễn Xuân Nhi','20',N'Nữ','8/7/2001','19BC01','A1','USSH')
go
insert into Student values('19120002',N'Trần Yến Phương','20',N'Nữ','1/7/2001','19DL01','A2','USSH')
go
insert into Student values('19120003',N'Nguyễn Ngọc Bảo Hân','20',N'Nữ','10/11/2001','19TT01','A1','USSH')
go
insert into Student values('1912004',N'Huỳnh Lê Khánh Huyền','20',N'Nữ','8/15/2001','19HQ01','A2','USSH')
go
insert into Student values('19120005',N'Huỳnh Lê Ánh Huyền','20',N'Nữ','8/15/2001','19HQ01','A2','USSH')
go
insert into Student values('19120006',N'Nguyễn Thu Hảo','20',N'Nữ','8/30/2001','19DL01','A2','USSH')
go
insert into Student values('19120007',N'Bùi Hoàng Hưng','20',N'Nam','4/9/2001','19BC01','A1','USSH')
go
insert into Student values('19120008',N'Nguyễn Quốc Huy','20',N'Nam','12/23/2001','19TT01','A1','USSH')
go
insert into Student values('19000001',N'Nguyễn Công Đức','20',N'Nam','11/8/2001','19KHMT','I1','UIT')
go
insert into Student values('19000002',N'Nguyễn Trần Khả Ái','20',N'Nữ','11/11/2001','19KHMT','I1','UIT')
go
insert into Student values('19000003',N'Nguyễn Hữu Bình','20',N'Nam','9/5/2001','19ATTT','I1','UIT')
go
insert into Student values('19000004',N'Trịnh Văn Minh','20',N'Nam','3/5/2001','19ATTT','I1','UIT')
go
insert into Student values('19000005',N'Phan Văn Nam','20',N'Nam','6/5/2001','19KTPM','I2','UIT')
go
insert into Student values('19000006',N'Phan Trịnh Thanh Hà','20',N'Nữ','7/12/2001','19KTPM','I2','UIT')
go
insert into Student values('19000007',N'Trần Văn Trường An','20',N'Nam','5/13/2001','19HTTT','I2','UIT')
go
insert into Student values('19000008',N'Trần Thị Tường Vi','20',N'Nữ','4/10/2001','19HTTT','I2','UIT')
go
