Create database barberDb

use barberDb

create table bbblogs
(
Id int primary key identity,
Title nvarchar(50) not null,
[Desc] nvarchar(500) not null,
BlogTime datetime not null
)

create table [services]
(
Id int primary key identity,
[Name] nvarchar(50) not null,
Price decimal(4,2) constraint ck_price check(Price<=30),
ImgName nvarchar(100) not null
)

create table blogservices
(
Id int primary key identity,
BlogId int constraint fk_blogs_blogservices foreign key 
references bbblogs(Id),
ServiceId int constraint fk_services_blogservices foreign key 
references [services](Id)
)

insert bbblogs
values(N'Saç kəsimi',N'Mənim saçımı kəsin', '2012-12-12')