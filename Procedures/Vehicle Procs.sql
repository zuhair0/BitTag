alter proc Sp_AddVehicle 
@vehicleID nvarchar(50),
@custID_FK nvarchar(50),
@tagID nvarchar(50),
@vehiclePlate nvarchar(50),
@vehicleMake nvarchar(50),
@vehicleModel int,
@vehicleType nvarchar(50),
@vehicleColor nvarchar(50)
as begin
insert into Vehicle([vehicleID],[custID_FK],[tagID],[vehiclePlate],[vehicleMake],[vehicleModel],
[vehicleType],[vehicleColor])
values(@vehicleID,@custID_FK,@tagID,@vehiclePlate,@vehicleMake,@vehicleModel,@vehicleType,
@vehicleColor)
end

create proc Sp_GetVehicle
as begin
select * from Vehicle
end

alter proc Sp_DeleteVehicle
@vehicleID nvarchar(50)
as begin
delete from Vehicle where vehicleID=@vehicleID
end


