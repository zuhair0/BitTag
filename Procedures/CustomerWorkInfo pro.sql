create proc Sp_SaveWorkInfo
@org_FK nvarchar(50),
@userID_FK nvarchar(50),
@WorkType nvarchar(50),
@Desig nvarchar(50),
@worktime datetime
as begin
insert into WorkInformation([org_FK],[userID_FK],[WorkType],[Desig],[worktime])
values(@org_FK,@userID_FK,@WorkType,@Desig,@worktime)
end

create proc Sp_GetWorkInfo
as begin
select * from WorkInformtion
end

