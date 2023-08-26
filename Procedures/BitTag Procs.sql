alter proc Sp_BitTagDetils
@tagID nvarchar(50),
@tagSerial nvarchar(50),
@QRcode nvarchar(50),
@orgId nvarchar(50)
as begin
insert into BitTag([tagID], [tagSerial], [QRcode], [orgId])
values(@tagID,@tagSerial,@QRcode,@orgId)
end

create proc Sp_GetBitTagDetails
as begin
select * from BitTag
end

truncate table BitTag

create proc Sp_DeleteBitTag
@tagID nvarchar(50)
as begin
delete from BitTag where @tagID=tagID
end