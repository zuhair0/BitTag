select * from BitTag
select * from BitTagUser
insert into BitTagUser([userid_fk], [vehid_fk],[bittagcode])
values('3EB76EF5-543A-4FDF-818C-3F8574D62167','DFE05BAD-1AB8-44C3-ADEE-B8CC7CB653F6','24372788')

create proc Sp_getBitTagById
@QRcode varchar(50)
as begin
SELECT v.*
FROM BitTagUser btu
INNER JOIN Vehicle v ON btu.vehid_fk = v.vehicleID
WHERE btu.bittagcode = @QRcode;
end

drop proc Sp_getBitTagById

Sp_getBitTagById 24372788

SELECT v.* 
FROM Vehicle v
INNER JOIN BitTagUser btu ON v.vehicleID = btu.vehid_fk
INNER JOIN BitTag bt ON btu.bittagcode = 24372788;--bt.QRcode;

SELECT v.*
FROM BitTagUser btu
INNER JOIN Vehicle v ON btu.vehid_fk = v.vehicleID
WHERE btu.bittagcode = '24372788';