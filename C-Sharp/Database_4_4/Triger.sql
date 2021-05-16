use webt2289_StudentManager_Thuy
go
------------------------------------------------STORE PROCEDURE-------------------------------------------
create proc USP_PRINT_STUDENT_FULL
as
begin
	print 'Table is already full';
end
go
create proc USP_PRINT_STUDENT
	@S_id char(8),
	@S_name nvarchar(100)
as
begin
	print @S_id+':' +@S_name;
end
go

------------------------------------------------TRIGGER ROCEDURE-----------------------------------------
------------PREVENT STUDENT INSERTION IF COUNT >30-----------
create trigger UTG_STUDENT_INSERT_PREVENT on Student for insert
as
begin
	declare @count int
	select @count=count(*)
	from Student
	if(@count=30)
	begin
	exec USP_PRINT_STUDENT_FULL
	rollback tran
	end
end
go
insert into Student values('19120001',N'Nguyễn Thị Nhung','20',N'Nữ','12/28/2001','19CTT2','K1','KHTN',getdate());
go

-------------PRINT NEAREST DELETED STUDENT------------------------------
alter trigger UTG_STUDENT_DELETE on Student after delete, update
as
	declare @sl_id char(8)
	declare @sl_name nvarchar(100)
begin
	select @sl_id=D.S_id,@sl_name=D.name
	from deleted D
	EXEC USP_PRINT_STUDENT @sl_id,@sl_name;
end
go
--
delete from Student where S_id='19120001'
go
--
update Student set name=N'Nguyễn Trần Khả Ái' where S_id='19120001'
go
-------------PRINT NEAREST INSERTED STUDENT----------------------------
alter trigger UTG_STUDENT_INSERT on Student after insert
as
	declare @sl_id char(8)
	declare @sl_name nvarchar(100)
begin
	select @sl_id=I.S_id,@sl_name=I.name
	from inserted I
	EXEC USP_PRINT_STUDENT @sl_id,@sl_name;
end
go

