alter proc Sp_GetEmpByID
@orgID_FK varchar(100)
as begin
select * from [dbo].[Organization_Employee] 
where orgID_FK=@orgID_FK
end

select * from [dbo].[Organization_Employee]