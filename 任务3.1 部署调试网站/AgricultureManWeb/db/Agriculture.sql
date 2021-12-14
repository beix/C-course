create database Agriculture
USE [Agriculture]
GO
/****** Object:  Table [dbo].[Operator]    Script Date: 11/25/2018 23:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Operator](
	[operid] [int] IDENTITY(1,1) NOT NULL,
	[opername] [varchar](20) NOT NULL,
	[operpwd] [varchar](50) NOT NULL,
	[opertype] [varchar](5) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Operator] ON
INSERT [dbo].[Operator] ([operid], [opername], [operpwd], [opertype]) VALUES (1, N'test', N'123', NULL)
SET IDENTITY_INSERT [dbo].[Operator] OFF
