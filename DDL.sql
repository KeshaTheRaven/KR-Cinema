CREATE TABLE Режиссер
(
	РежиссерНомер  integer  IDENTITY (1,1) ,
	Режиссер  varchar(40)  NULL ,
	 PRIMARY KEY   NONCLUSTERED (РежиссерНомер  ASC)
)
go


CREATE TABLE Студия
(
	СтудияНомер  integer  IDENTITY (1,1) ,
	Студия  varchar(40)  NULL ,
	 PRIMARY KEY   NONCLUSTERED (СтудияНомер  ASC)
)
go


CREATE TABLE Жанр
(
	ЖанрНомер  integer  IDENTITY (1,1) ,
	Жанр  varchar(40)  NULL ,
	 PRIMARY KEY   NONCLUSTERED (ЖанрНомер  ASC)
)
go


CREATE TABLE Банк
(
	БанкНомер  integer  IDENTITY (1,1) ,
	Банк  varchar(40)  NULL ,
	 PRIMARY KEY   NONCLUSTERED (БанкНомер  ASC)
)
go


CREATE TABLE Поставщик
(
	ПоставщикНомер  integer  IDENTITY (1,1) ,
	Поставщик  varchar(40)  NULL ,
	ИНН  varchar(40)  NULL ,
	НомерСчета  varchar(40)  NULL ,
	Адрес  varchar(40)  NULL ,
	БанкНомер  integer  NOT NULL ,
	 PRIMARY KEY   NONCLUSTERED (ПоставщикНомер  ASC),
	 FOREIGN KEY (БанкНомер) REFERENCES Банк(БанкНомер)
		ON DELETE CASCADE
		ON UPDATE CASCADE
)
go


CREATE TABLE Сценарист
(
	СценаристНомер  integer  IDENTITY (1,1) ,
	Сценарист  varchar(40)  NULL ,
	 PRIMARY KEY   NONCLUSTERED (СценаристНомер  ASC)
)
go


CREATE TABLE Фильм
(
	ФильмНомер  integer  IDENTITY (1,1) ,
	РежиссерНомер  integer  NOT NULL ,
	СтудияНомер  integer  NOT NULL ,
	ЖанрНомер  integer  NOT NULL ,
	Фильм  varchar(40)  NULL ,
	ГодВыхода  integer  NULL ,
	Стоимость  integer  NULL ,
	ПоставщикНомер  integer  NOT NULL ,
	СценаристНомер  integer  NOT NULL ,
	 PRIMARY KEY   NONCLUSTERED (ФильмНомер  ASC),
	 FOREIGN KEY (РежиссерНомер) REFERENCES Режиссер(РежиссерНомер)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
 FOREIGN KEY (СтудияНомер) REFERENCES Студия(СтудияНомер)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
 FOREIGN KEY (ЖанрНомер) REFERENCES Жанр(ЖанрНомер)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
 FOREIGN KEY (ПоставщикНомер) REFERENCES Поставщик(ПоставщикНомер)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
 FOREIGN KEY (СценаристНомер) REFERENCES Сценарист(СценаристНомер)
		ON DELETE CASCADE
		ON UPDATE CASCADE
)
go


CREATE TABLE Район
(
	РайонНомер  integer  IDENTITY (1,1) ,
	Район  varchar(40)  NULL ,
	 PRIMARY KEY   NONCLUSTERED (РайонНомер  ASC)
)
go


CREATE TABLE Категория
(
	КатегорияНомер  integer  IDENTITY (1,1) ,
	Категория  varchar(40)  NULL ,
	Вместимость  integer  NULL ,
	 PRIMARY KEY   NONCLUSTERED (КатегорияНомер  ASC)
)
go


CREATE TABLE Кинотеатр
(
	КинотеатрНомер  integer  IDENTITY (1,1) ,
	Кинотеатр  varchar(40)  NULL ,
	РайонНомер  integer  NOT NULL ,
	КатегорияНомер  integer  NOT NULL ,
	Адрес  varchar(40)  NULL ,
	Телефон  varchar(40)  NULL ,
	Директор  varchar(40)  NULL ,
	Владелец  varchar(40)  NULL ,
	НомерСчета  varchar(40)  NULL ,
	ИНН  varchar(40)  NULL ,
	БанкНомер  integer  NOT NULL ,
	 PRIMARY KEY   NONCLUSTERED (КинотеатрНомер  ASC),
	 FOREIGN KEY (РайонНомер) REFERENCES Район(РайонНомер)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
 FOREIGN KEY (КатегорияНомер) REFERENCES Категория(КатегорияНомер)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
 FOREIGN KEY (БанкНомер) REFERENCES Банк(БанкНомер)
		ON DELETE CASCADE
		ON UPDATE CASCADE
)
go


CREATE TABLE Аренда
(
	АрендаНомер  integer  IDENTITY (1,1) ,
	ДатаНачала  date  NULL ,
	ДатаОкончания  date  NULL ,
	СуммаОплаты  integer  NULL ,
	Пени  integer  NULL ,
	ФильмНомер  integer  NOT NULL ,
	КинотеатрНомер  integer  NOT NULL ,
	 PRIMARY KEY   NONCLUSTERED (АрендаНомер  ASC),
	 FOREIGN KEY (ФильмНомер) REFERENCES Фильм(ФильмНомер),
 FOREIGN KEY (КинотеатрНомер) REFERENCES Кинотеатр(КинотеатрНомер)
		ON DELETE CASCADE
		ON UPDATE CASCADE
)
go

USE [cinemarent]
GO
SET IDENTITY_INSERT [dbo].[Режиссер] ON 

GO
INSERT [dbo].[Режиссер] ([РежиссерНомер], [Режиссер]) VALUES (1, N'Семенов АВ')
GO
INSERT [dbo].[Режиссер] ([РежиссерНомер], [Режиссер]) VALUES (2, N'Маклаков ВА')
GO
INSERT [dbo].[Режиссер] ([РежиссерНомер], [Режиссер]) VALUES (3, N'Лесников ВА')
GO
INSERT [dbo].[Режиссер] ([РежиссерНомер], [Режиссер]) VALUES (4, N'Кораблев ВВ')
GO
INSERT [dbo].[Режиссер] ([РежиссерНомер], [Режиссер]) VALUES (5, N'Синицын ВА')
GO
SET IDENTITY_INSERT [dbo].[Режиссер] OFF
GO
SET IDENTITY_INSERT [dbo].[Студия] ON 

GO
INSERT [dbo].[Студия] ([СтудияНомер], [Студия]) VALUES (1, N'Парамаунт')
GO
INSERT [dbo].[Студия] ([СтудияНомер], [Студия]) VALUES (2, N'Союз')
GO
INSERT [dbo].[Студия] ([СтудияНомер], [Студия]) VALUES (3, N'Мечта')
GO
INSERT [dbo].[Студия] ([СтудияНомер], [Студия]) VALUES (4, N'Контент')
GO
INSERT [dbo].[Студия] ([СтудияНомер], [Студия]) VALUES (5, N'Аркадия')
GO
SET IDENTITY_INSERT [dbo].[Студия] OFF
GO
SET IDENTITY_INSERT [dbo].[Жанр] ON 

GO
INSERT [dbo].[Жанр] ([ЖанрНомер], [Жанр]) VALUES (1, N'Боевик')
GO
INSERT [dbo].[Жанр] ([ЖанрНомер], [Жанр]) VALUES (2, N'Комедия')
GO
INSERT [dbo].[Жанр] ([ЖанрНомер], [Жанр]) VALUES (3, N'Мелодрама')
GO
INSERT [dbo].[Жанр] ([ЖанрНомер], [Жанр]) VALUES (4, N'Драма')
GO
INSERT [dbo].[Жанр] ([ЖанрНомер], [Жанр]) VALUES (5, N'Фантастика')
GO
INSERT [dbo].[Жанр] ([ЖанрНомер], [Жанр]) VALUES (6, N'Авторское кино')
GO
INSERT [dbo].[Жанр] ([ЖанрНомер], [Жанр]) VALUES (7, N'Мультфильм')
GO
INSERT [dbo].[Жанр] ([ЖанрНомер], [Жанр]) VALUES (8, N'Разное')
GO
SET IDENTITY_INSERT [dbo].[Жанр] OFF
GO
SET IDENTITY_INSERT [dbo].[Банк] ON 

GO
INSERT [dbo].[Банк] ([БанкНомер], [Банк]) VALUES (1, N'ВТБ')
GO
INSERT [dbo].[Банк] ([БанкНомер], [Банк]) VALUES (2, N'СберБанк')
GO
SET IDENTITY_INSERT [dbo].[Банк] OFF
GO
SET IDENTITY_INSERT [dbo].[Поставщик] ON 

GO
INSERT [dbo].[Поставщик] ([ПоставщикНомер], [Поставщик], [ИНН], [НомерСчета], [Адрес], [БанкНомер]) VALUES (1, N'Ортега', N'564564', N'54634', N'ул. Попова 34', 1)
GO
INSERT [dbo].[Поставщик] ([ПоставщикНомер], [Поставщик], [ИНН], [НомерСчета], [Адрес], [БанкНомер]) VALUES (2, N'СНАБФИЛЬМ', N'456784', N'56455', N'ул. Лермонтова 43', 2)
GO
SET IDENTITY_INSERT [dbo].[Поставщик] OFF
GO
SET IDENTITY_INSERT [dbo].[Сценарист] ON 

GO
INSERT [dbo].[Сценарист] ([СценаристНомер], [Сценарист]) VALUES (1, N'Михайлов ВА')
GO
INSERT [dbo].[Сценарист] ([СценаристНомер], [Сценарист]) VALUES (2, N'Протасов ВВ')
GO
SET IDENTITY_INSERT [dbo].[Сценарист] OFF
GO
SET IDENTITY_INSERT [dbo].[Фильм] ON 

GO
INSERT [dbo].[Фильм] ([ФильмНомер], [РежиссерНомер], [СтудияНомер], [ЖанрНомер], [Фильм], [ГодВыхода], [Стоимость], [ПоставщикНомер], [СценаристНомер]) VALUES (1, 1, 2, 1, N'Старинные часы', 2010, 100000, 1, 1)
GO
INSERT [dbo].[Фильм] ([ФильмНомер], [РежиссерНомер], [СтудияНомер], [ЖанрНомер], [Фильм], [ГодВыхода], [Стоимость], [ПоставщикНомер], [СценаристНомер]) VALUES (2, 2, 2, 3, N'Мелодия', 2021, 150000, 2, 2)
GO
INSERT [dbo].[Фильм] ([ФильмНомер], [РежиссерНомер], [СтудияНомер], [ЖанрНомер], [Фильм], [ГодВыхода], [Стоимость], [ПоставщикНомер], [СценаристНомер]) VALUES (3, 3, 3, 3, N'Синий трамвай', 2019, 200000, 2, 1)
GO
INSERT [dbo].[Фильм] ([ФильмНомер], [РежиссерНомер], [СтудияНомер], [ЖанрНомер], [Фильм], [ГодВыхода], [Стоимость], [ПоставщикНомер], [СценаристНомер]) VALUES (5, 2, 1, 4, N'Метро', 2022, 200000, 1, 2)
GO
SET IDENTITY_INSERT [dbo].[Фильм] OFF
GO
SET IDENTITY_INSERT [dbo].[Район] ON 

GO
INSERT [dbo].[Район] ([РайонНомер], [Район]) VALUES (1, N'Восточный')
GO
INSERT [dbo].[Район] ([РайонНомер], [Район]) VALUES (2, N'Северный')
GO
INSERT [dbo].[Район] ([РайонНомер], [Район]) VALUES (3, N'Южный')
GO
INSERT [dbo].[Район] ([РайонНомер], [Район]) VALUES (4, N'Западный')
GO
SET IDENTITY_INSERT [dbo].[Район] OFF
GO
SET IDENTITY_INSERT [dbo].[Категория] ON 

GO
INSERT [dbo].[Категория] ([КатегорияНомер], [Категория], [Вместимость]) VALUES (1, N'Большой', 1000)
GO
INSERT [dbo].[Категория] ([КатегорияНомер], [Категория], [Вместимость]) VALUES (2, N'Средний', 500)
GO
INSERT [dbo].[Категория] ([КатегорияНомер], [Категория], [Вместимость]) VALUES (3, N'Маленький', 250)
GO
SET IDENTITY_INSERT [dbo].[Категория] OFF
GO
SET IDENTITY_INSERT [dbo].[Кинотеатр] ON 

GO
INSERT [dbo].[Кинотеатр] ([КинотеатрНомер], [Кинотеатр], [РайонНомер], [КатегорияНомер], [Адрес], [Телефон], [Директор], [Владелец], [НомерСчета], [ИНН], [БанкНомер]) VALUES (1, N'Современник', 1, 1, N'ул. Строителей 22', N'373112', N'Михайлов ВА', N'Петров ВВ', N'334462', N'554422', 2)
GO
INSERT [dbo].[Кинотеатр] ([КинотеатрНомер], [Кинотеатр], [РайонНомер], [КатегорияНомер], [Адрес], [Телефон], [Директор], [Владелец], [НомерСчета], [ИНН], [БанкНомер]) VALUES (2, N'Октябрь', 2, 2, N'ул. Попова 45', N'441122', N'Митрофанов ВВ', N'Макаров ВВ', N'231154', N'331122', 1)
GO
INSERT [dbo].[Кинотеатр] ([КинотеатрНомер], [Кинотеатр], [РайонНомер], [КатегорияНомер], [Адрес], [Телефон], [Директор], [Владелец], [НомерСчета], [ИНН], [БанкНомер]) VALUES (3, N'Меркурий', 3, 3, N'ул. Попова 2', N'634321', N'Селезнев ВА', N'Петров ВВ', N'634772', N'335622', 2)
GO
SET IDENTITY_INSERT [dbo].[Кинотеатр] OFF
GO
