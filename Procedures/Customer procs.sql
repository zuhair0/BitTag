use BitTaag
alter proc Sp_AddCustomer
@custID nvarchar(50),
@firstName nvarchar(50),
@lastName nvarchar(50),
@custCNIC bigint,
@contact bigint,
@DOB datetime,
@custEmail nvarchar(50),
@custPIN int
as begin
insert into Customer([custID],[firstName],[lastName],[custCNIC],[contact],[DOB],[custEmail],[custPIN])
values(@custID,@firstName,@lastName,@custCNIC,@contact,@DOB,@custEmail,@custPIN)
end

alter proc Sp_GetCustomer
as begin
select * from Customer
end

alter proc Sp_DeleteCustomer
@custID nvarchar(50)
as begin
delete from Customer where custID=@custID
end