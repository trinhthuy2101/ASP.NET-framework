create database DBServer
go
use DBServer
go
create table Student
(
	S_id char(8),
	name nvarchar(100),
	age int,
	gender nchar(3),
	dob date,
	class char(6),
	dep char(2),
	uni char(4)
	constraint PK_student primary key(S_id,uni)
)
go
create table Class
( 
	C_id char(6),
	dep char(2),
	uni char(4),
	constraint PK_class primary key(C_id, uni)
)
go
create table Department
(
	D_id char(2),
	uni char(4),
	constraint PK_Dep primary key(D_id, uni)
)
go
create table University
(
	U_id char(4),
	name nvarchar(100),
	constraint PK_uni primary key(U_id)
)
go