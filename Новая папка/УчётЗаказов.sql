USE [�����������]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[������](
		[ID] [int] IDENTITY(1,1),
		[���] [nvarchar] (50) NOT NULL,
		[�����] [nvarchar] (100) NOT NULL,
		[������] [nvarchar] (100) NOT NULL
)
GO


ALTER TABLE [������]
ADD CONSTRAINT [PK_������_ID] PRIMARY KEY CLUSTERED (ID)
GO

/*************************************************************************/

CREATE TABLE [dbo].[��������������������](
		[ID] [int] IDENTITY(1,1),
		[�������] [nchar] (50) NOT NULL,
		[���] [nchar] (50) NOT NULL,
		[��������] [nchar] (50) NOT NULL,
		[������ %] [int] NOT NULL,
)
GO

ALTER TABLE dbo.������ ADD [����� ��������] nvarchar(11) NULL;

ALTER TABLE [��������������������]
ADD CONSTRAINT [PK_��������������������_ID] PRIMARY KEY CLUSTERED (ID)
GO

/***************************************************************************/

CREATE TABLE [dbo].[������� ������](
		[ID] [int] IDENTITY(1,1),
		[�����] [nchar] (50) NOT NULL,
		[������] [nchar] (50) NOT NULL
)
GO

ALTER TABLE [������� ������]
ADD CONSTRAINT [PK_������� ������_ID] PRIMARY KEY CLUSTERED (ID)
GO


TRUNCATE table [������];