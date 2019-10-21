create schema StudentStaffDetailsAutomation

create table StudentStaffDetailsAutomation.StudentDetails
( StudentId int identity (170000,1) primary key,
Name varchar(25),
Gender char check (gender in('M', 'F')),
Branch nvarchar(10),
year varchar(5),
DateofBirth date,
PhoneNumber nvarchar(10),
Addrees varchar(500)

)
drop table StudentStaffDetailsAutomation.StudentDetails
drop table StudentStaffDetailsAutomation.StaffDetails

--------------------
create table StudentStaffDetailsAutomation.StaffDetails
( StaffId int identity (200000,1) primary key,
Name varchar(25),
Gender char check (gender in('M', 'F')),
City varchar(20),
Experience int,
PhoneNumber nvarchar(10),
Salary Bigint,
[subject] varchar(20))

-----------------------
create table StudentStaffDetailsAutomation.Fees
( 
feesid int primary key Identity,
StudentId int foreign key references StudentStaffDetailsAutomation.StudentDetails(StudentId),
Amount bigint,
Paid varchar(10),
Balance bigint)

drop table StudentStaffDetailsAutomation.Fees
drop table StudentStaffDetailsAutomation.AdminLogin


create table StudentStaffDetailsAutomation.AdminLogin
(
	id int primary key Identity,
	adminUsername varchar(10),
	adminpassword varchar(20)
)

insert into StudentStaffDetailsAutomation.AdminLogin values('admin','admin')

select * from StudentStaffDetailsAutomation.AdminLogin