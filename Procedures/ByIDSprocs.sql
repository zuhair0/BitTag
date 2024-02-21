Sp_GetCustomer

create proc Sp_getCustByID
@custCNIC varchar(20)
as begin
select * from Customer where custCNIC=@custCNIC
end

Sp_GetAuth

select * from BitTagUser
select * from WorkInformation
select * from Customer
select * from Vehicle

SELECT v.*
FROM Customer c
JOIN Vehicle v ON c.custID = v.custID_FK
WHERE c.custCNIC = @custCNIC;

alter proc Sp_getVehByID
@custCNIC varchar(100)
as begin
SELECT v.*
FROM Customer c
JOIN Vehicle v ON c.custID = v.custID_FK
WHERE c.custCNIC = @custCNIC;
end
