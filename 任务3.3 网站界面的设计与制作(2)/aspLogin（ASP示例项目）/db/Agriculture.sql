USE [Agriculture]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 06/13/2018 01:25:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[email] [varchar](50) NOT NULL,
	[password] [varchar](50) NULL,
	[name] [varchar](50) NULL,
	[type] [varchar](50) NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Users] ([email], [password], [name], [type]) VALUES (N'test@163.com', N'123', N'风清扬', N'系统管理员')
