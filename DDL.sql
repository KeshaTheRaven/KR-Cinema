CREATE TABLE ��������
(
	�������������  integer  IDENTITY (1,1) ,
	��������  varchar(40)  NULL ,
	 PRIMARY KEY   NONCLUSTERED (�������������  ASC)
)
go


CREATE TABLE ������
(
	�����������  integer  IDENTITY (1,1) ,
	������  varchar(40)  NULL ,
	 PRIMARY KEY   NONCLUSTERED (�����������  ASC)
)
go


CREATE TABLE ����
(
	���������  integer  IDENTITY (1,1) ,
	����  varchar(40)  NULL ,
	 PRIMARY KEY   NONCLUSTERED (���������  ASC)
)
go


CREATE TABLE ����
(
	���������  integer  IDENTITY (1,1) ,
	����  varchar(40)  NULL ,
	 PRIMARY KEY   NONCLUSTERED (���������  ASC)
)
go


CREATE TABLE ���������
(
	��������������  integer  IDENTITY (1,1) ,
	���������  varchar(40)  NULL ,
	���  varchar(40)  NULL ,
	����������  varchar(40)  NULL ,
	�����  varchar(40)  NULL ,
	���������  integer  NOT NULL ,
	 PRIMARY KEY   NONCLUSTERED (��������������  ASC),
	 FOREIGN KEY (���������) REFERENCES ����(���������)
		ON DELETE CASCADE
		ON UPDATE CASCADE
)
go


CREATE TABLE ���������
(
	��������������  integer  IDENTITY (1,1) ,
	���������  varchar(40)  NULL ,
	 PRIMARY KEY   NONCLUSTERED (��������������  ASC)
)
go


CREATE TABLE �����
(
	����������  integer  IDENTITY (1,1) ,
	�������������  integer  NOT NULL ,
	�����������  integer  NOT NULL ,
	���������  integer  NOT NULL ,
	�����  varchar(40)  NULL ,
	���������  integer  NULL ,
	���������  integer  NULL ,
	��������������  integer  NOT NULL ,
	��������������  integer  NOT NULL ,
	 PRIMARY KEY   NONCLUSTERED (����������  ASC),
	 FOREIGN KEY (�������������) REFERENCES ��������(�������������)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
 FOREIGN KEY (�����������) REFERENCES ������(�����������)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
 FOREIGN KEY (���������) REFERENCES ����(���������)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
 FOREIGN KEY (��������������) REFERENCES ���������(��������������)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
 FOREIGN KEY (��������������) REFERENCES ���������(��������������)
		ON DELETE CASCADE
		ON UPDATE CASCADE
)
go


CREATE TABLE �����
(
	����������  integer  IDENTITY (1,1) ,
	�����  varchar(40)  NULL ,
	 PRIMARY KEY   NONCLUSTERED (����������  ASC)
)
go


CREATE TABLE ���������
(
	��������������  integer  IDENTITY (1,1) ,
	���������  varchar(40)  NULL ,
	�����������  integer  NULL ,
	 PRIMARY KEY   NONCLUSTERED (��������������  ASC)
)
go


CREATE TABLE ���������
(
	��������������  integer  IDENTITY (1,1) ,
	���������  varchar(40)  NULL ,
	����������  integer  NOT NULL ,
	��������������  integer  NOT NULL ,
	�����  varchar(40)  NULL ,
	�������  varchar(40)  NULL ,
	��������  varchar(40)  NULL ,
	��������  varchar(40)  NULL ,
	����������  varchar(40)  NULL ,
	���  varchar(40)  NULL ,
	���������  integer  NOT NULL ,
	 PRIMARY KEY   NONCLUSTERED (��������������  ASC),
	 FOREIGN KEY (����������) REFERENCES �����(����������)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
 FOREIGN KEY (��������������) REFERENCES ���������(��������������)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
 FOREIGN KEY (���������) REFERENCES ����(���������)
		ON DELETE CASCADE
		ON UPDATE CASCADE
)
go


CREATE TABLE ������
(
	�����������  integer  IDENTITY (1,1) ,
	����������  date  NULL ,
	�������������  date  NULL ,
	�����������  integer  NULL ,
	����  integer  NULL ,
	����������  integer  NOT NULL ,
	��������������  integer  NOT NULL ,
	 PRIMARY KEY   NONCLUSTERED (�����������  ASC),
	 FOREIGN KEY (����������) REFERENCES �����(����������),
 FOREIGN KEY (��������������) REFERENCES ���������(��������������)
		ON DELETE CASCADE
		ON UPDATE CASCADE
)
go

USE [cinemarent]
GO
SET IDENTITY_INSERT [dbo].[��������] ON 

GO
INSERT [dbo].[��������] ([�������������], [��������]) VALUES (1, N'������� ��')
GO
INSERT [dbo].[��������] ([�������������], [��������]) VALUES (2, N'�������� ��')
GO
INSERT [dbo].[��������] ([�������������], [��������]) VALUES (3, N'�������� ��')
GO
INSERT [dbo].[��������] ([�������������], [��������]) VALUES (4, N'�������� ��')
GO
INSERT [dbo].[��������] ([�������������], [��������]) VALUES (5, N'������� ��')
GO
SET IDENTITY_INSERT [dbo].[��������] OFF
GO
SET IDENTITY_INSERT [dbo].[������] ON 

GO
INSERT [dbo].[������] ([�����������], [������]) VALUES (1, N'���������')
GO
INSERT [dbo].[������] ([�����������], [������]) VALUES (2, N'����')
GO
INSERT [dbo].[������] ([�����������], [������]) VALUES (3, N'�����')
GO
INSERT [dbo].[������] ([�����������], [������]) VALUES (4, N'�������')
GO
INSERT [dbo].[������] ([�����������], [������]) VALUES (5, N'�������')
GO
SET IDENTITY_INSERT [dbo].[������] OFF
GO
SET IDENTITY_INSERT [dbo].[����] ON 

GO
INSERT [dbo].[����] ([���������], [����]) VALUES (1, N'������')
GO
INSERT [dbo].[����] ([���������], [����]) VALUES (2, N'�������')
GO
INSERT [dbo].[����] ([���������], [����]) VALUES (3, N'���������')
GO
INSERT [dbo].[����] ([���������], [����]) VALUES (4, N'�����')
GO
INSERT [dbo].[����] ([���������], [����]) VALUES (5, N'����������')
GO
INSERT [dbo].[����] ([���������], [����]) VALUES (6, N'��������� ����')
GO
INSERT [dbo].[����] ([���������], [����]) VALUES (7, N'����������')
GO
INSERT [dbo].[����] ([���������], [����]) VALUES (8, N'������')
GO
SET IDENTITY_INSERT [dbo].[����] OFF
GO
SET IDENTITY_INSERT [dbo].[����] ON 

GO
INSERT [dbo].[����] ([���������], [����]) VALUES (1, N'���')
GO
INSERT [dbo].[����] ([���������], [����]) VALUES (2, N'��������')
GO
SET IDENTITY_INSERT [dbo].[����] OFF
GO
SET IDENTITY_INSERT [dbo].[���������] ON 

GO
INSERT [dbo].[���������] ([��������������], [���������], [���], [����������], [�����], [���������]) VALUES (1, N'������', N'564564', N'54634', N'��. ������ 34', 1)
GO
INSERT [dbo].[���������] ([��������������], [���������], [���], [����������], [�����], [���������]) VALUES (2, N'���������', N'456784', N'56455', N'��. ���������� 43', 2)
GO
SET IDENTITY_INSERT [dbo].[���������] OFF
GO
SET IDENTITY_INSERT [dbo].[���������] ON 

GO
INSERT [dbo].[���������] ([��������������], [���������]) VALUES (1, N'�������� ��')
GO
INSERT [dbo].[���������] ([��������������], [���������]) VALUES (2, N'�������� ��')
GO
SET IDENTITY_INSERT [dbo].[���������] OFF
GO
SET IDENTITY_INSERT [dbo].[�����] ON 

GO
INSERT [dbo].[�����] ([����������], [�������������], [�����������], [���������], [�����], [���������], [���������], [��������������], [��������������]) VALUES (1, 1, 2, 1, N'��������� ����', 2010, 100000, 1, 1)
GO
INSERT [dbo].[�����] ([����������], [�������������], [�����������], [���������], [�����], [���������], [���������], [��������������], [��������������]) VALUES (2, 2, 2, 3, N'�������', 2021, 150000, 2, 2)
GO
INSERT [dbo].[�����] ([����������], [�������������], [�����������], [���������], [�����], [���������], [���������], [��������������], [��������������]) VALUES (3, 3, 3, 3, N'����� �������', 2019, 200000, 2, 1)
GO
INSERT [dbo].[�����] ([����������], [�������������], [�����������], [���������], [�����], [���������], [���������], [��������������], [��������������]) VALUES (5, 2, 1, 4, N'�����', 2022, 200000, 1, 2)
GO
SET IDENTITY_INSERT [dbo].[�����] OFF
GO
SET IDENTITY_INSERT [dbo].[�����] ON 

GO
INSERT [dbo].[�����] ([����������], [�����]) VALUES (1, N'���������')
GO
INSERT [dbo].[�����] ([����������], [�����]) VALUES (2, N'��������')
GO
INSERT [dbo].[�����] ([����������], [�����]) VALUES (3, N'�����')
GO
INSERT [dbo].[�����] ([����������], [�����]) VALUES (4, N'��������')
GO
SET IDENTITY_INSERT [dbo].[�����] OFF
GO
SET IDENTITY_INSERT [dbo].[���������] ON 

GO
INSERT [dbo].[���������] ([��������������], [���������], [�����������]) VALUES (1, N'�������', 1000)
GO
INSERT [dbo].[���������] ([��������������], [���������], [�����������]) VALUES (2, N'�������', 500)
GO
INSERT [dbo].[���������] ([��������������], [���������], [�����������]) VALUES (3, N'���������', 250)
GO
SET IDENTITY_INSERT [dbo].[���������] OFF
GO
SET IDENTITY_INSERT [dbo].[���������] ON 

GO
INSERT [dbo].[���������] ([��������������], [���������], [����������], [��������������], [�����], [�������], [��������], [��������], [����������], [���], [���������]) VALUES (1, N'�����������', 1, 1, N'��. ���������� 22', N'373112', N'�������� ��', N'������ ��', N'334462', N'554422', 2)
GO
INSERT [dbo].[���������] ([��������������], [���������], [����������], [��������������], [�����], [�������], [��������], [��������], [����������], [���], [���������]) VALUES (2, N'�������', 2, 2, N'��. ������ 45', N'441122', N'���������� ��', N'������� ��', N'231154', N'331122', 1)
GO
INSERT [dbo].[���������] ([��������������], [���������], [����������], [��������������], [�����], [�������], [��������], [��������], [����������], [���], [���������]) VALUES (3, N'��������', 3, 3, N'��. ������ 2', N'634321', N'�������� ��', N'������ ��', N'634772', N'335622', 2)
GO
SET IDENTITY_INSERT [dbo].[���������] OFF
GO
