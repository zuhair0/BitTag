CREATE DATABASE BitTag
USE[BitTag]

--TABLES
CREATE TABLE WorkInformation
(
	org_FK NVARCHAR(50),
	userID_FK NVARCHAR(50),
	WorkType NVARCHAR(50),
	Desig NVARCHAR(50),
	worktime DATETIME
);

CREATE TABLE Auth(
	CustCNIC NVARCHAR(13),
	CustPIN INT
);

CREATE TABLE Customer(
	custID nvarchar(50),
	firstName nvarchar(50),
	lastName nvarchar(50),
	custCNIC nvarchar(50),
	contact nvarchar(50),
	DOB datetime,
	custEmail nvarchar(50),
	custPIN int
);

CREATE TABLE CustomerStatus(
	custID_FK nvarchar(50),
	custDesig nvarchar(50),
	visiting bit,
	employment bit 
);

CREATE TABLE [Login](
	custCNIC BIGINT,
	custEmail NVARCHAR(50),
	custPIN INT
);

CREATE TABLE VehicleOrganization(
	orgID NVARCHAR(50),
	VehiclePlate NVARCHAR(50),
	tagID_FK NVARCHAR(50)
);

CREATE TABLE BitTag(
	tagID NVARCHAR(50),
	tagSerial INT,
	QRcode NVARCHAR(50),
	orgId NVARCHAR(50)
); 

CREATE TABLE BitTagUser(
	userid_fk NVARCHAR(50),
	vehid_fk NVARCHAR(50),
	bittagcode NVARCHAR(50)
);

CREATE TABLE Vehicle(
	vehicleID NVARCHAR(50),
	custID_FK NVARCHAR(50),
	tagID NVARCHAR(50),
	vehiclePlate NVARCHAR(50),
	vehicleMake NVARCHAR(50),
	vehicleModel INT,
	vehicleType NVARCHAR(50),
	vehicleColor NVARCHAR(50)
);

CREATE TABLE Organization(
	ordID NVARCHAR(50),
	orgName NVARCHAR(50),
	orgType NVARCHAR(50),
	orgAddress NVARCHAR(50),
	orgCapacity INT
);

CREATE TABLE Organization_FocalPerson_Login(
	fp_CNIC BIGINT,
	fp_Password NVARCHAR(50)
);

CREATE TABLE Organization_Employee(
	orgID_FK NVARCHAR(50),
	Emp_ID NVARCHAR(50),
	Emp_firstName NVARCHAR(50),
	Emp_lastName NVARCHAR(50),
	Emp_CNIC BIGINT,
	Pin INT,
	Designation NVARCHAR(50),
	PhoneNum BIGINT
);

--STORED PROCEDURES

CREATE PROC Sp_AddVehicle 
	@vehicleID NVARCHAR(50),
	@custID_FK NVARCHAR(50),
	@tagID NVARCHAR(50),
	@vehiclePlate NVARCHAR(50),
	@vehicleMake NVARCHAR(50),
	@vehicleModel INT,
	@vehicleType NVARCHAR(50),
	@vehicleColor NVARCHAR(50)
	AS BEGIN
	INSERT INTO Vehicle([vehicleID],[custID_FK],[tagID],[vehiclePlate],[vehicleMake],[vehicleModel],
	[vehicleType],[vehicleColor])
	VALUES(@vehicleID,@custID_FK,@tagID,@vehiclePlate,@vehicleMake,@vehicleModel,@vehicleType,
	@vehicleColor)
END

CREATE PROC Sp_GetVehicle
AS BEGIN
SELECT * FROM Vehicle
END

CREATE PROC Sp_DeleteVehicle
@vehicleID NVARCHAR(50)
AS BEGIN
DELETE FROM Vehicle WHERE vehicleID=@vehicleID
END

CREATE PROC Sp_BitTagDetils
@tagID NVARCHAR(50),
@QRcode NVARCHAR(50),
@orgId NVARCHAR(50)
AS BEGIN
INSERT INTO BitTag([tagID], [QRcode], [orgId])
VALUES(@tagID,@QRcode,@orgId)
END

CREATE PROC Sp_GetBitTagDetails
AS BEGIN
SELECT * FROM BitTag
END

CREATE PROC Sp_DeleteBitTag
@tagID NVARCHAR(50)
AS BEGIN
DELETE FROM BitTag WHERE @tagID=tagID
END

CREATE PROC Sp_getBitTagById
@QRcode VARCHAR(50)
AS BEGIN
SELECT v.*
FROM BitTagUser btu
INNER JOIN Vehicle v ON btu.vehid_fk = v.vehicleID
WHERE btu.bittagcode = @QRcode;
END

CREATE PROC Sp_SaveBitTagUser
@userid_fk NVARCHAR(50),
@vehid_fk NVARCHAR(50),
@bittagcode NVARCHAR(50)
AS BEGIN
INSERT INTO BitTagUser([userid_fk], [vehid_fk], [bittagcode])
VALUES(@userid_fk, @vehid_fk, @bittagcode)
END

CREATE PROC Sp_GetAuth
AS BEGIN
SELECT * FROM Auth
END

CREATE PROC Sp_getCustByID
@custCNIC VARCHAR(20)
AS BEGIN
SELECT * FROM Customer WHERE custCNIC=@custCNIC
END

CREATE PROC Sp_getVehByID
@custCNIC VARCHAR(100)
AS BEGIN
SELECT v.*
FROM Customer c
JOIN Vehicle v ON c.custID = v.custID_FK
WHERE c.custCNIC = @custCNIC;
END

CREATE PROC Sp_getWorkinfoByID
@custCNIC VARCHAR(100)
AS BEGIN
SELECT wi.*
FROM Customer c
JOIN WorkInformation wi ON c.custID = wi.userID_FK
WHERE c.custCNIC = @custCNIC;
END

CREATE PROC Sp_AddCustomer
@custID NVARCHAR(50),
@firstName NVARCHAR(50),
@lastName NVARCHAR(50),
@custCNIC BIGINT,
@contact BIGINT,
@DOB DATETIME,
@custEmail NVARCHAR(50),
@custPIN INT
AS BEGIN
INSERT INTO Customer([custID],[firstName],[lastName],[custCNIC],[contact],[DOB],[custEmail],[custPIN])
VALUES(@custID,@firstName,@lastName,@custCNIC,@contact,@DOB,@custEmail,@custPIN)
INSERT INTO Auth([custCNIC],[custPIN])
VALUES(@custCNIC,@custPIN)
END

CREATE PROC Sp_GetCustomer
AS BEGIN
SELECT * FROM Customer
END

CREATE PROC Sp_DeleteCustomer
@custID NVARCHAR(50)
AS BEGIN
DELETE FROM Customer WHERE custID=@custID
END

CREATE PROC Sp_SaveWorkInfo
@org_FK NVARCHAR(50),
@userID_FK NVARCHAR(50),
@WorkType NVARCHAR(50),
@Desig NVARCHAR(50),
@worktime DATETIME
AS BEGIN
INSERT INTO WorkInformation([org_FK],[userID_FK],[WorkType],[Desig],[worktime])
VALUES(@org_FK,@userID_FK,@WorkType,@Desig,@worktime)
END

CREATE PROC Sp_GetWorkInfo
AS BEGIN
SELECT * FROM WorkInformation
END

CREATE PROC Sp_AddOrgEmployee
@orgID_FK NVARCHAR(50),
@Emp_ID NVARCHAR(50),
@Emp_firstName NVARCHAR(50),
@Emp_lastName NVARCHAR(50),
@Emp_CNIC BIGINT,
@Pin INT,
@Designation NVARCHAR(50),
@PhoneNum BIGINT
AS BEGIN
INSERT INTO [dbo].[Organization_Employee](
	orgID_FK,
	Emp_ID,
	Emp_firstName,
	Emp_lastName,
	Emp_CNIC,
	Pin,
	Designation,
	PhoneNum
)
VALUES
(
	@orgID_FK,
	@Emp_ID,
	@Emp_firstName,
	@Emp_lastName,
	@Emp_CNIC,
	@Pin,
	@Designation,
	@PhoneNum
)
END

CREATE PROC Sp_GetOrgEmployees
AS BEGIN
SELECT * FROM [dbo].[Organization_Employee]
END

CREATE PROC Sp_DeleteEmployee
@Emp_ID NVARCHAR(50)
AS BEGIN
DELETE FROM [dbo].[Organization_Employee]
WHERE Emp_ID=@Emp_ID
END

CREATE PROC Sp_AddOrg
@ordID VARCHAR(50),
@orgName VARCHAR(50),
@orgType VARCHAR(50),
@orgAddress VARCHAR(50),
@orgCapacity VARCHAR(50)
AS
BEGIN
INSERT INTO Organization([ordID],[orgName], [orgType], [orgAddress], [orgCapacity])
VALUES(@ordID,@orgName,@orgType,@orgAddress, @orgCapacity)
END

CREATE PROC Sp_DeleteOrg
@ordID VARCHAR(50)
AS BEGIN
DELETE FROM [dbo].[Organization]
WHERE ordID=@ordID
END

CREATE PROC Sp_GetOrganization
AS BEGIN
SELECT * FROM Organization
END

CREATE PROC Sp_GetEmpByID
@orgID_FK VARCHAR(100)
AS BEGIN
SELECT * FROM [dbo].[Organization_Employee] 
WHERE orgID_FK=@orgID_FK
END

