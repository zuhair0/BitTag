use BitTaag
alter proc Sp_AddOrg
@ordID varchar(50),
@orgName varchar(50),
@orgType varchar(50),
@orgAddress varchar(50),
@orgCapacity varchar(50)
as
begin
insert into Organization([ordID],[orgName], [orgType], [orgAddress], [orgCapacity])
values(@ordID,@orgName,@orgType,@orgAddress, @orgCapacity)
end

select * from Organization

truncate table Organization