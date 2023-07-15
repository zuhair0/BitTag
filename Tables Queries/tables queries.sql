create table WorkInformation
( org_FK nvarchar(50),
userID_FK nvarchar(50),
WorkType nvarchar(50),
Desig nvarchar(50),
worktime datetime
);

create table Customer(
custID nvarchar(50),
firstName nvarchar(50),
lastName nvarchar(50),
custCNIC bigint,
contact bigint,
DOB datetime,
custEmail nvarchar(50),
custPIN int
);

create table CustomerStatus(
custID_FK nvarchar(50),
custDesig nvarchar(50),
visiting bit ,
employment bit 
);

create table Login(
custCNIC bigint,
custEmail nvarchar(50),
custPIN int
);

create table VehicleOrganization(
orgID nvarchar(50),
VehiclePlate nvarchar(50),
tagID_FK nvarchar(50)
);

create table BitTag(
tagID nvarchar(50),
tagSerial bigint,
custID_FK nvarchar(50),
orgId nvarchar(50)
);

create table Vehicle(
custID_FK nvarchar(50),
tagID nvarchar(50),
vehiclePlate nvarchar(50),
vehicleMake nvarchar(50),
vehicleModel int,
vehicleType nvarchar(50),
vehicleColor nvarchar(50)
);

create table Organization(
ordID nvarchar(50),
orgName nvarchar(50),
orgType nvarchar(50),
orgAddress nvarchar(50),
orgCapacity int,
);
 
create table Organization_FocalPerson_Login(
fp_CNIC bigint,
fp_Password nvarchar(50)
);
 
create table Organization_FocalPerson(
orgID_FK nvarchar(50),
fp_firstName nvarchar(50),
fp_lastName nvarchar(50),
fp_CNIC bigint,
fp_Password nvarchar(50)
);