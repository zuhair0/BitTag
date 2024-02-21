create proc Sp_SaveBitTagUser
@userid_fk nvarchar(50),
@vehid_fk nvarchar(50),
@bittagcode nvarchar(50)
as begin
insert into BitTagUser([userid_fk], [vehid_fk], [bittagcode])
values(@userid_fk, @vehid_fk, @bittagcode)
end

create proc Sp_GetAuth
as begin
select * from Auth
end