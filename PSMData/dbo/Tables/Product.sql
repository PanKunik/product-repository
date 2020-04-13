﻿CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(100) NOT NULL,
	[Description] NTEXT NOT NULL,
	[CategoryId] INT NOT NULL,
	[BrandId] INT NOT NULL
)