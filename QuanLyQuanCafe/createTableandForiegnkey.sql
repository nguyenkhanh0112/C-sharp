create database QuanLyQuanCafe
go

use  QuanLyQuanCafe
go

-- Food
-- Table 
-- FoodCategory
-- Account
-- Bill
--BillInfro

create table TableFood
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên',
	status nvarchar(100)not null default N'Trống', -- trống || có người 

)

go

create table Account
(
	UserName nvarchar(100) primary key ,
	displayName nvarchar(100) not null default N'Nguyễn khánh',
	passWord nvarchar(1000) not null default 1,
	Type int not null default 0-- 1 admin , 0 staff
)

go 
create table FoodCategory(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên '

)
go 

create table Food(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên',
	idCategory int not null,
	price float not null

)

go

create table Bill(
	id int identity primary key,
	DateCheckIn Date not null default getdate(),
	DataCheckOut date,
	idTable int not null,
	status int not null default 0, --1 là đã thanh toán && 0: chưa thanh toán 
	
)

go 
create table BillInfo
(
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	count int not null default 0

)
alter table BillInfo  add foreign key (idBill) references Bill(id)
alter table BillInfo add foreign key (idFood) references Food(id)
alter table Food add constraint FK_FoodFoodCategory  foreign key (idCategory) references FoodCategory(id)
alter table Bill add constraint FK_BillTableFood  foreign key (idTable) references TableFood(id)

go

