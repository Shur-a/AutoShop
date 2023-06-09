USE [UserRegistration]
GO
/****** Object:  Table [dbo].[Authorization]    Script Date: 30.05.2023 11:36:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authorization](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Authorization] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 30.05.2023 11:36:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[CarID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Details]    Script Date: 30.05.2023 11:36:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Details](
	[NameId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](80) NOT NULL,
	[ModelCar] [nvarchar](50) NOT NULL,
	[YearofreleaseCar] [nvarchar](50) NOT NULL,
	[Price] [money] NOT NULL,
	[Count] [int] NOT NULL,
	[PathImage] [nvarchar](max) NOT NULL,
	[CarId] [int] NOT NULL,
 CONSTRAINT [PK_Details] PRIMARY KEY CLUSTERED 
(
	[NameId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Authorization] ON 

INSERT [dbo].[Authorization] ([UserId], [Login], [Password]) VALUES (1, N'login', N'password')
INSERT [dbo].[Authorization] ([UserId], [Login], [Password]) VALUES (2, N'dad', N'dad')
INSERT [dbo].[Authorization] ([UserId], [Login], [Password]) VALUES (3, N'    ', N' ')
SET IDENTITY_INSERT [dbo].[Authorization] OFF
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([CarID], [Name]) VALUES (1, N'Mazda')
INSERT [dbo].[Cars] ([CarID], [Name]) VALUES (2, N'Tayota')
INSERT [dbo].[Cars] ([CarID], [Name]) VALUES (3, N'Subaru')
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[Details] ON 

INSERT [dbo].[Details] ([NameId], [Name], [ModelCar], [YearofreleaseCar], [Price], [Count], [PathImage], [CarId]) VALUES (1, N'Тормозной диск', N'6', N'2006', 2300.0000, 34, N'c00edd4f5643404e8bcf9b1493cb0311', 1)
INSERT [dbo].[Details] ([NameId], [Name], [ModelCar], [YearofreleaseCar], [Price], [Count], [PathImage], [CarId]) VALUES (2, N'Передний рычаг', N'Corolla', N'2000', 2500.0000, 8, N'perRychag.jpg', 2)
INSERT [dbo].[Details] ([NameId], [Name], [ModelCar], [YearofreleaseCar], [Price], [Count], [PathImage], [CarId]) VALUES (3, N'Стойка стабилизатора', N'Impreza', N'1999', 4000.0000, 3, N'stoika.jpg', 3)
INSERT [dbo].[Details] ([NameId], [Name], [ModelCar], [YearofreleaseCar], [Price], [Count], [PathImage], [CarId]) VALUES (6, N'Шрус', N'6', N'2003', 2340.0000, 45, N'shrus.jpg', 1)
INSERT [dbo].[Details] ([NameId], [Name], [ModelCar], [YearofreleaseCar], [Price], [Count], [PathImage], [CarId]) VALUES (9, N'Пружина', N'Corolla', N'2008', 6540.0000, 7, N'pruzhina.jpg', 2)
INSERT [dbo].[Details] ([NameId], [Name], [ModelCar], [YearofreleaseCar], [Price], [Count], [PathImage], [CarId]) VALUES (11, N'Подшибник', N'Impreza', N'1999', 1234.0000, 3, N'podshipnik.jpg', 3)
INSERT [dbo].[Details] ([NameId], [Name], [ModelCar], [YearofreleaseCar], [Price], [Count], [PathImage], [CarId]) VALUES (13, N'Шрус', N'3', N'2012', 756.0000, 23, N'shrus3.jpg', 1)
INSERT [dbo].[Details] ([NameId], [Name], [ModelCar], [YearofreleaseCar], [Price], [Count], [PathImage], [CarId]) VALUES (1005, N'Передний амортизатор', N'Land Cruser', N'2019', 10000.0000, 15, N'Amor.jpg', 2)
INSERT [dbo].[Details] ([NameId], [Name], [ModelCar], [YearofreleaseCar], [Price], [Count], [PathImage], [CarId]) VALUES (1006, N'Диски(r18)x4', N'6', N'2006', 30000.0000, 1, N'discki.jpg', 1)
INSERT [dbo].[Details] ([NameId], [Name], [ModelCar], [YearofreleaseCar], [Price], [Count], [PathImage], [CarId]) VALUES (1007, N'Шаровая опора', N'Forester', N'2017', 5000.0000, 5, N'shar.jpg', 3)
INSERT [dbo].[Details] ([NameId], [Name], [ModelCar], [YearofreleaseCar], [Price], [Count], [PathImage], [CarId]) VALUES (1008, N'Диски(r20)x4', N'Mark2', N'1994', 25000.0000, 1, N'discki2.jpg', 2)
INSERT [dbo].[Details] ([NameId], [Name], [ModelCar], [YearofreleaseCar], [Price], [Count], [PathImage], [CarId]) VALUES (1009, N'Тормозные колодки', N'Corolla', N'2004', 3000.0000, 5, N'kolodki.jpg', 2)
INSERT [dbo].[Details] ([NameId], [Name], [ModelCar], [YearofreleaseCar], [Price], [Count], [PathImage], [CarId]) VALUES (1010, N'Передний амортизатор', N'Forester', N'2016', 10000.0000, 6, N'Amorforester.jpg', 3)
INSERT [dbo].[Details] ([NameId], [Name], [ModelCar], [YearofreleaseCar], [Price], [Count], [PathImage], [CarId]) VALUES (1011, N'Передний амортизатор', N'CX6', N'2018', 25000.0000, 5, N'amorcx6.jpg', 1)
SET IDENTITY_INSERT [dbo].[Details] OFF
GO
ALTER TABLE [dbo].[Details]  WITH CHECK ADD  CONSTRAINT [FK_Details_Cars] FOREIGN KEY([CarId])
REFERENCES [dbo].[Cars] ([CarID])
GO
ALTER TABLE [dbo].[Details] CHECK CONSTRAINT [FK_Details_Cars]
GO
