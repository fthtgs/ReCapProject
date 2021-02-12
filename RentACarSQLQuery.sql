CREATE DATABASE RantACar;

use RantACar;

CREATE TABLE Brands
(
	BrandId int	PRIMARY KEY IDENTITY (1,1),
	BrandName varchar(40)
);



CREATE TABLE Colors
(
	ColorID int	PRIMARY KEY IDENTITY (1,1),
	ColorName varchar(40)
);

CREATE TABLE Cars
(
	CarId int	PRIMARY KEY IDENTITY (1, 1),
	BrandId int,
	ColorId int,
	CarName varchar(40),
	ModelYear int,
	DailyPrice decimal,
	Descriptions varchar(40),
	FOREIGN KEY (BrandId) REFERENCES Brands(BrandId),
	FOREIGN KEY (ColorId) REFERENCES Colors(ColorId)
);

INSERT INTO Brands(BrandName)
VALUES
	('Renault'),
	('Peugeot'),
	('Volkswagen'),
	('Hyundai'),
	('Fiat');

INSERT INTO Colors(ColorName)
VALUES
	('Beyaz'),
	('Siyah'),
	('Kırmızı'),
	('Mavi');

INSERT INTO Cars (BrandId,ColorId,CarName,ModelYear,DailyPrice,Descriptions)
VALUES
	('1','3','Clio','2017','180','Manuel - Benzinli - Ekonomi'),
	('1','2','Symbol','2018','201','Manuel - Dizel - Ekonomi'),
	('3','1','Passat','2019','966.23','Otomatik - Benzinli - Premium'),
	('3','4','Golf','2018','252','Otomatik - Dizel - Ekonomi'),
	('2','4','208','2017','193','Manuel - Dizel - Ekonomi'),
	('2','1','301','2018','395.07','Manuel - Dizel - Kompakt'),
	('1','3','Megan Sedan','2018','235','Otomatik - Dizel - Ekonomi'),
	('4','4','Accent Blue','2019','127','Otomatik - Benzin - Ekonomi'),
	('4','1','i20','2019','127','Otomatik - Benzin - Ekonomi'),
	('5','3','Linea','2016','109','Manuel - Dizel - Intermediate'),
	('5','1','Egea','2017','367','Manuel - Benzin - Kompakt'),
	('1','3','Fluence','2016','200','Manuel - Dizel - Ekonomi'),
	('3','4','Passat','2018','280','Otomatik - Dizel - Intermediate'),
	('2','4','508','2020','800','Otomatik - Dizel - Premium');




