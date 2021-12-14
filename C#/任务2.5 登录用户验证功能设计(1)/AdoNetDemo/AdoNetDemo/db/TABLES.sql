create database SuperMarketSales
USE [SuperMarketSales]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 04/18/2018 14:16:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USERS](
	[ID] [int] NOT NULL,
	[NAME] [varchar](50) NULL,
	[PASSWORD] [varchar](50) NULL,
	[PHONE] [varchar](15) NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[USERS] ([ID], [NAME], [PASSWORD], [PHONE]) VALUES (1001, N'老赵', N'123', N'13333333333')
INSERT [dbo].[USERS] ([ID], [NAME], [PASSWORD], [PHONE]) VALUES (1002, N'老钱', N'123', N'13444444444')
INSERT [dbo].[USERS] ([ID], [NAME], [PASSWORD], [PHONE]) VALUES (1003, N'老孙', N'123', N'13555555555')
INSERT [dbo].[USERS] ([ID], [NAME], [PASSWORD], [PHONE]) VALUES (1004, N'老李', N'123', N'13666666666')
/****** Object:  Table [dbo].[ADMIN]    Script Date: 04/18/2018 14:16:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ADMIN](
	[ID] [int] NOT NULL,
	[NAME] [varchar](50) NULL,
	[PASSWORD] [varchar](50) NULL,
	[PHONE] [varchar](15) NULL,
 CONSTRAINT [PK_ADMIN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ADMIN] ([ID], [NAME], [PASSWORD], [PHONE]) VALUES (2001, N'郭靖', N'123', N'15888888888')
INSERT [dbo].[ADMIN] ([ID], [NAME], [PASSWORD], [PHONE]) VALUES (2002, N'张无忌', N'123', N'15999999999')
INSERT [dbo].[ADMIN] ([ID], [NAME], [PASSWORD], [PHONE]) VALUES (2003, N'令狐冲', N'123', N'15777777777')
INSERT [dbo].[ADMIN] ([ID], [NAME], [PASSWORD], [PHONE]) VALUES (2004, N'老赵', N'123', N'15666666666')
