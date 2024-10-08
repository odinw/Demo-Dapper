USE [Demo]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2024/8/12 下午 03:22:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[Age] [int] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Id], [Name], [Age]) VALUES (1, N'Audin', 20)
INSERT [dbo].[Customer] ([Id], [Name], [Age]) VALUES (2, N'Tom', 21)
INSERT [dbo].[Customer] ([Id], [Name], [Age]) VALUES (4, N'Bell', 22)
INSERT [dbo].[Customer] ([Id], [Name], [Age]) VALUES (17, N'Postman', 1)
INSERT [dbo].[Customer] ([Id], [Name], [Age]) VALUES (18, N'Postman', 2)
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
