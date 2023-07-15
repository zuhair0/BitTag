use BitTaag
create proc Sp_AddOrg
@orgName varchar(50),
@orgType varchar(50),
@orgAddress varchar(50),
@orgCapacity varchar(50)
as
begin
insert into Organization([orgName], [orgType], [orgAddress], [orgCapacity])
values(@orgName,@orgType,@orgAddress, @orgCapacity)
end