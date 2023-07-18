Create proc Sp_AddOrgEmployee
@orgID_FK nvarchar(50),
@Emp_ID nvarchar(50),
@Emp_firstName nvarchar(50),
@Emp_lastName nvarchar(50),
@Emp_CNIC bigint,
@Pin int,
@Designation nvarchar(50),
@PhoneNum bigint
as begin
insert into [dbo].[Organization_Employee](
orgID_FK,
Emp_ID,
Emp_firstName,
Emp_lastName,
Emp_CNIC,
Pin,
Designation,
PhoneNum
)
values(
@orgID_FK,
@Emp_ID,
@Emp_firstName,
@Emp_lastName,
@Emp_CNIC,
@Pin,
@Designation,
@PhoneNum
)
end

create proc Sp_GetOrgEmployees
as begin
select * from [dbo].[Organization_Employee]
end