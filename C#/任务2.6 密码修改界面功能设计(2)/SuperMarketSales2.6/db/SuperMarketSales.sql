create database SuperMarket
USE [SuperMarketSales]
GO
/****** Object:  Table [dbo].[EMPLOYEE]    Script Date: 11/02/2018 20:03:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EMPLOYEE](
	[ID] [int] NOT NULL,
	[NAME] [varchar](50) NOT NULL,
	[PASSWORD] [varchar](50) NOT NULL,
	[PHONE] [varchar](15) NULL,
	[TYPE] [varchar](10) NOT NULL,
 CONSTRAINT [PK_EMPLOYEE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'''收银员''或''库管员''' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EMPLOYEE', @level2type=N'COLUMN',@level2name=N'TYPE'
GO
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [PASSWORD], [PHONE], [TYPE]) VALUES (1001, N'老赵', N'123', N'13333333333', N'收银员')
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [PASSWORD], [PHONE], [TYPE]) VALUES (1002, N'老钱', N'123', N'13444444444', N'收银员')
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [PASSWORD], [PHONE], [TYPE]) VALUES (1003, N'老孙', N'123', N'13555555555', N'收银员')
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [PASSWORD], [PHONE], [TYPE]) VALUES (1004, N'老李', N'123', N'13666666666', N'收银员')
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [PASSWORD], [PHONE], [TYPE]) VALUES (2001, N'郭靖', N'123', N'15888888888', N'库管员')
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [PASSWORD], [PHONE], [TYPE]) VALUES (2002, N'张无忌', N'123', N'15999999999', N'库管员')
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [PASSWORD], [PHONE], [TYPE]) VALUES (2003, N'令狐冲', N'123', N'15777777777', N'库管员')
INSERT [dbo].[EMPLOYEE] ([ID], [NAME], [PASSWORD], [PHONE], [TYPE]) VALUES (2004, N'老赵', N'123', N'15666666666', N'库管员')
/****** Object:  Default [DF_USER_TYPE]    Script Date: 11/02/2018 20:03:25 ******/
ALTER TABLE [dbo].[EMPLOYEE] ADD  CONSTRAINT [DF_USER_TYPE]  DEFAULT ('收银员') FOR [TYPE]
GO
