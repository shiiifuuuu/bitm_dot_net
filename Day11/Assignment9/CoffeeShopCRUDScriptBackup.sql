CREATE DATABASE CoffeeShopCRUD
USE [CoffeeShopCRUD]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 10/3/2019 11:35:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](25) NOT NULL,
	[Contact] [varchar](11) NOT NULL,
	[Address] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Items]    Script Date: 10/3/2019 11:35:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Items](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](15) NOT NULL,
	[Price] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 10/3/2019 11:35:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Quantity] [int] NULL,
	[Price] [float] NULL,
	[CustomerId] [int] NULL,
	[ItemId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [Name], [Contact], [Address]) VALUES (1, N'Ali', N'01311369369', N'Dhaka')
INSERT [dbo].[Customers] ([Id], [Name], [Contact], [Address]) VALUES (2, N'Hasan', N'Sylhet', N'01711369369')
INSERT [dbo].[Customers] ([Id], [Name], [Contact], [Address]) VALUES (3, N'Rafi', N'BNorisal', N'01811369369')
INSERT [dbo].[Customers] ([Id], [Name], [Contact], [Address]) VALUES (4, N'Rafiul', N'Shamoly', N'123')
SET IDENTITY_INSERT [dbo].[Customers] OFF
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([Id], [Name], [Price]) VALUES (1, N'Black', 120)
INSERT [dbo].[Items] ([Id], [Name], [Price]) VALUES (2, N'Regular', 80)
INSERT [dbo].[Items] ([Id], [Name], [Price]) VALUES (3, N'Cold', 100)
INSERT [dbo].[Items] ([Id], [Name], [Price]) VALUES (4, N'Hot', 90)
INSERT [dbo].[Items] ([Id], [Name], [Price]) VALUES (5, N'Blue', 90)
SET IDENTITY_INSERT [dbo].[Items] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [Quantity], [Price], [CustomerId], [ItemId]) VALUES (1, 5, 600, 1, 1)
INSERT [dbo].[Orders] ([Id], [Quantity], [Price], [CustomerId], [ItemId]) VALUES (2, 3, 240, 1, 2)
INSERT [dbo].[Orders] ([Id], [Quantity], [Price], [CustomerId], [ItemId]) VALUES (3, 10, 900, 3, 4)
INSERT [dbo].[Orders] ([Id], [Quantity], [Price], [CustomerId], [ItemId]) VALUES (4, 2, 160, 2, 2)
INSERT [dbo].[Orders] ([Id], [Quantity], [Price], [CustomerId], [ItemId]) VALUES (5, 3, 300, 2, 3)
INSERT [dbo].[Orders] ([Id], [Quantity], [Price], [CustomerId], [ItemId]) VALUES (6, 6, 540, 2, 4)
INSERT [dbo].[Orders] ([Id], [Quantity], [Price], [CustomerId], [ItemId]) VALUES (7, 4, 360, 4, 4)
INSERT [dbo].[Orders] ([Id], [Quantity], [Price], [CustomerId], [ItemId]) VALUES (11, 10, 1200, 1, 1)
INSERT [dbo].[Orders] ([Id], [Quantity], [Price], [CustomerId], [ItemId]) VALUES (12, 3, 360, 2, 1)
INSERT [dbo].[Orders] ([Id], [Quantity], [Price], [CustomerId], [ItemId]) VALUES (13, 6, 0, 2, 5)
INSERT [dbo].[Orders] ([Id], [Quantity], [Price], [CustomerId], [ItemId]) VALUES (14, 6, 480, 2, 2)
SET IDENTITY_INSERT [dbo].[Orders] OFF
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([ItemId])
REFERENCES [dbo].[Items] ([Id])
GO
