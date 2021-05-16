use DBServer
go
alter table Student add foreign key(class,uni) references Class(C_id,uni)
go
alter table Class add foreign key(uni) references University(U_id) 
go
alter table Department add foreign key(uni) references University(U_id)
go
------------
alter table Student add create_date datetime
go
update Student set create_date=getdate()
go
alter table Class add create_date datetime
go
update Class set create_date=getdate()
go
alter table Department add create_date datetime
go
update Department set create_date=getdate()
go
alter table University add create_date datetime
go
update University set create_date=getdate()
go