Sp_GetCustomer

create proc Sp_getCustByID
@custCNIC varchar(20)
as begin
select * from Customer where custCNIC=@custCNIC
end

Sp_GetAuth

select * from Customer
select * from Vehicle
select * from BitTagUser
select * from WorkInformation

create proc Sp_getVehByID
@custID_FK varchar(100)
as begin
select * from Vehicle where custID_FK=@custID_FK
end