Create table Cars(
	Id int Primary Key Identity(1,1),
	ColorId int,
	BrandId int,
	ModelYear nvarchar(20),
	DailyPrice decimal,
	Description nvarchar(20),
	Foreign Key(BrandId) References Brands(BrandId),
	Foreign Key(ColorId) References Colors(ColorID)

	
)
Create table Colors(
	ColorId int Primary Key Identity(1,1),
	ColorName nvarchar(20)
)
Create table Brands(
	BrandId int Primary Key Identity(1,1),
	BrandName nvarchar(20)
)
Insert Into Cars(BrandId,ColorId,ModelYear,DailyPrice,Description) VALUES
	(1,1,2010,75000,'Citroen C4'),
	(2,1,2015,87000,'Hyundai i20'),
	(3,2,2019,350000,'Volvo s40'),
	(4,3,2013,89000,'Volswagen Golf'),
	(5,3,2020,250000,'Pegeout 3008');
Insert Into Colors(ColorName) VALUES
	('Siyah'),
	('Beyaz'),
	('Kırmızı');
Insert Into Brands(BrandName) VALUES
	('Citroen'),
	('Mercedes'),
	('Hyundai'),
	('Pegeout'),
	('Volvo'),
	('Volkswagen');

Select * From Cars
Select * From Colors
Select * From Brands


