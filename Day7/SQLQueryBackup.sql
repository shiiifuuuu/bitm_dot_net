USE [coffeeShop]
GO
/****** Object:  Table [dbo].[items]    Script Date: 9/24/2019 11:54:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[items](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[price] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[items] ON 

INSERT [dbo].[items] ([ID], [name], [price]) VALUES (1, N'Black', 120)
INSERT [dbo].[items] ([ID], [name], [price]) VALUES (2, N'Cold', 100)
INSERT [dbo].[items] ([ID], [name], [price]) VALUES (3, N'Hot', 90)
INSERT [dbo].[items] ([ID], [name], [price]) VALUES (4, N'Regular', 80)
INSERT [dbo].[items] ([ID], [name], [price]) VALUES (5, N'Normal', 60)
INSERT [dbo].[items] ([ID], [name], [price]) VALUES (6, N'Cuppochino', 160)
SET IDENTITY_INSERT [dbo].[items] OFF
