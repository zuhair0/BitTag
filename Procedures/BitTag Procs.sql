create proc Sp_BitTagDetils
@tagID nvarchar(50),
@tagSerial bigint,
@custID_FK nvarchar(50),
@orgId nvarchar(50)
as begin
insert into BitTag([tagID], [tagSerial], [custID_FK], [orgId])
values(@tagID,@tagSerial,@custID_FK,@orgId)
end

create proc Sp_GetBitTagDetails
as begin
select * from BitTag
end

create proc Sp_DeleteBitTag
@tagID nvarchar(50)
as begin
delete from BitTag where @tagID=tagID
end