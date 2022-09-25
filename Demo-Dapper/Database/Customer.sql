USE [Demo]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2022/9/25 上午 09:46:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Name] [nvarchar](20) NOT NULL,
	[Age] [int] NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Name], [Age], [Id]) VALUES (N'Audin', 18, 1)
INSERT [dbo].[Customer] ([Name], [Age], [Id]) VALUES (N'Tom', 35, 2)
INSERT [dbo].[Customer] ([Name], [Age], [Id]) VALUES (N'Andy', 40, 3)
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
