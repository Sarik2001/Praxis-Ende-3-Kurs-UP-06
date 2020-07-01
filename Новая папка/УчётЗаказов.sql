USE [УчётЗаказов]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Заказы](
		[ID] [int] IDENTITY(1,1),
		[Имя] [nvarchar] (50) NOT NULL,
		[Заказ] [nvarchar] (100) NOT NULL,
		[Адресс] [nvarchar] (100) NOT NULL
)
GO


ALTER TABLE [Заказы]
ADD CONSTRAINT [PK_Заказы_ID] PRIMARY KEY CLUSTERED (ID)
GO

/*************************************************************************/

CREATE TABLE [dbo].[ПостоянныеПокупатели](
		[ID] [int] IDENTITY(1,1),
		[Фамилия] [nchar] (50) NOT NULL,
		[Имя] [nchar] (50) NOT NULL,
		[Отчество] [nchar] (50) NOT NULL,
		[Скидка %] [int] NOT NULL,
)
GO

ALTER TABLE dbo.Заказы ADD [Номер телефона] nvarchar(11) NULL;

ALTER TABLE [ПостоянныеПокупатели]
ADD CONSTRAINT [PK_ПостоянныеПокупатели_ID] PRIMARY KEY CLUSTERED (ID)
GO

/***************************************************************************/

CREATE TABLE [dbo].[Учётные данные](
		[ID] [int] IDENTITY(1,1),
		[Логин] [nchar] (50) NOT NULL,
		[Пароль] [nchar] (50) NOT NULL
)
GO

ALTER TABLE [Учётные данные]
ADD CONSTRAINT [PK_Учётные данные_ID] PRIMARY KEY CLUSTERED (ID)
GO


TRUNCATE table [Заказы];