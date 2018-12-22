CREATE DATABASE  [products_db]
GO
USE products_db
GO
/****** Object:  Table [dbo].[products]    Script Date: 12/22/2018 9:50:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[stock] [int] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[products] ON 
GO
INSERT [dbo].[products] ([Id], [name], [stock]) VALUES (1, N'Appy', 4)
GO
INSERT [dbo].[products] ([Id], [name], [stock]) VALUES (2, N'Real Juice Mango', 0)
GO
SET IDENTITY_INSERT [dbo].[products] OFF
GO
