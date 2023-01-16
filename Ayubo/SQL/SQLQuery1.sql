CREATE TABLE H_Rent
(
hireid int PRIMARY KEY IDENTITY (1, 1), 
pickupplace varchar (255),
dropedplace varchar (255),
rentdate date,
vehiclebrand varchar (255),
vehicletype varchar (255),
startread int,
endread int, 
weiting float, 
totalcharge int,
journey int
);

CREATE TABLE L_Tour
(
fulname varchar (255),
email varchar (255) not null,
nic varchar (255) PRIMARY KEY NOT NULL,
rentdate date,
returneddate date,
telno int,
vbrand varchar (255),
vtype varchar (255),
dstatus varchar (255)
);

CREATE TABLE R_vehicle
(
fulname varchar(255),
email varchar (255) not null,
rentdate date,
returndate date,
telno int,
nic int PRIMARY KEY NOT NULL,
totalcharge int,
rm_reading int,
em_reading int,
h_duration int, 
v_brand varchar (255),
v_type varchar (255),
d_status varchar (255),
tour_type varchar (255),
);

CREATE TABLE A_vehicle
(
reg_no int PRIMARY KEY NOT NULL,
m_reding int,
adddate date,
lastowner varchar (255),
wheels varchar (255),
m_year int,
v_brand varchar (255),
v_type varchar (255)
);

CREATE TABLE S_Tour
(
fulname varchar (255),
email varchar (255) NOT NULL,
r_date date,
return_date date,
telno int,
nic int PRIMARY KEY NOT NULL, 
v_brand varchar(255),
v_type varchar (255),
d_status varchar (255)
);