create proc Sp_AddVehicle 
@custID_FK nvarchar(50),
@tagID nvarchar(50),
@vehiclePlate nvarchar(50),
@vehicleMake nvarchar(50),
@vehicleModel int,
@vehicleType nvarchar(50),
@vehicleColor nvarchar(50)
as begin
insert into Vehicle([custID_FK],[tagID],[vehiclePlate],[vehicleMake],[vehicleModel],
[vehicleType],[vehicleColor])
values(@custID_FK,@tagID,@vehiclePlate,@vehicleMake,@vehicleModel,@vehicleType,
@vehicleColor)
end

create proc Sp_GetVehicle
as begin
select * from Vehicle
end

create proc Sp_DeleteVehicle
@vehiclePlate nvarchar(50)
as begin
delete from Vehicle where vehiclePlate=@vehiclePlate
end


