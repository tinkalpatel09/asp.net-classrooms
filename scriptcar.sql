USE [master]
GO
/****** Object:  Database [CarRentalSystemDB]    Script Date: 2020-03-18 5:00:28 PM ******/
CREATE DATABASE [CarRentalSystemDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarRentalSystemDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\CarRentalSystemDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CarRentalSystemDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\CarRentalSystemDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CarRentalSystemDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarRentalSystemDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarRentalSystemDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarRentalSystemDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarRentalSystemDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarRentalSystemDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarRentalSystemDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarRentalSystemDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarRentalSystemDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarRentalSystemDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarRentalSystemDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarRentalSystemDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarRentalSystemDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarRentalSystemDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarRentalSystemDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarRentalSystemDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarRentalSystemDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CarRentalSystemDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarRentalSystemDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarRentalSystemDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarRentalSystemDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarRentalSystemDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarRentalSystemDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarRentalSystemDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarRentalSystemDB] SET RECOVERY FULL 
GO
ALTER DATABASE [CarRentalSystemDB] SET  MULTI_USER 
GO
ALTER DATABASE [CarRentalSystemDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarRentalSystemDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarRentalSystemDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarRentalSystemDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CarRentalSystemDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CarRentalSystemDB] SET QUERY_STORE = OFF
GO
USE [CarRentalSystemDB]
GO
/****** Object:  Table [dbo].[BillingDetails]    Script Date: 2020-03-18 5:00:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillingDetails](
	[Billid] [int] IDENTITY(1,1) NOT NULL,
	[BillDate] [date] NOT NULL,
	[TotalAmount] [float] NOT NULL,
	[BookingId] [int] NOT NULL,
 CONSTRAINT [PK_BillingDetails] PRIMARY KEY CLUSTERED 
(
	[Billid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookingDetails]    Script Date: 2020-03-18 5:00:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingDetails](
	[BookingId] [int] IDENTITY(1,1) NOT NULL,
	[Prize] [float] NOT NULL,
	[PickupLoc] [nvarchar](50) NOT NULL,
	[CarId] [int] NOT NULL,
	[Customer_Id] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
 CONSTRAINT [PK_BookingDetails] PRIMARY KEY CLUSTERED 
(
	[BookingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 2020-03-18 5:00:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[CarId] [int] IDENTITY(1,1) NOT NULL,
	[CarType] [nvarchar](50) NOT NULL,
	[CarModel] [nvarchar](50) NOT NULL,
	[CarBrand] [nvarchar](50) NOT NULL,
	[prize] [float] NOT NULL,
	[Available] [varchar](50) NOT NULL,
	[ImagePath] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2020-03-18 5:00:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Customer_Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Phonenumber] [int] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Customer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LocationDetails]    Script Date: 2020-03-18 5:00:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LocationDetails](
	[Loc_id] [int] NOT NULL,
	[LocationName] [nvarchar](50) NOT NULL,
	[Street] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[State] [nvarchar](50) NOT NULL,
	[ZipCode] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LocationDetails] PRIMARY KEY CLUSTERED 
(
	[Loc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([CarId], [CarType], [CarModel], [CarBrand], [prize], [Available], [ImagePath]) VALUES (1, N'Economy Car', N'Mirage or Similar', N'Mitsubishi', 40, N'yes', N'~/Content/upload/1.png')
INSERT [dbo].[Cars] ([CarId], [CarType], [CarModel], [CarBrand], [prize], [Available], [ImagePath]) VALUES (2, N'Compact Car', N'Nissan Versa or Similar', N'Nissan', 50, N'yes', N'~/Content/upload/2.png')
INSERT [dbo].[Cars] ([CarId], [CarType], [CarModel], [CarBrand], [prize], [Available], [ImagePath]) VALUES (3, N'Intermediate Car', N'Hyundai Elantra or Similar', N'Hyundai', 60, N'yes', N'~/Content/upload/3.png')
INSERT [dbo].[Cars] ([CarId], [CarType], [CarModel], [CarBrand], [prize], [Available], [ImagePath]) VALUES (4, N'Standard Car', N'Volkswagaen Jetta or Similar', N'Volkswagaen ', 70, N'yes', N'~/Content/upload/9634802034.png')
INSERT [dbo].[Cars] ([CarId], [CarType], [CarModel], [CarBrand], [prize], [Available], [ImagePath]) VALUES (5, N'Fullsize Car', N'Ford Fusion or Similar', N'Ford', 80, N'yes', N'~/Content/upload/19931392275.png')
INSERT [dbo].[Cars] ([CarId], [CarType], [CarModel], [CarBrand], [prize], [Available], [ImagePath]) VALUES (6, N'Convertible', N'Ford Mustang or Similar', N'Ford', 100, N'yes', N'~/Content/upload/20546622066.png')
INSERT [dbo].[Cars] ([CarId], [CarType], [CarModel], [CarBrand], [prize], [Available], [ImagePath]) VALUES (7, N'Sports Car', N'Dodge Challenger or Similar', N'Dodge', 110, N'yes', N'~/Content/upload/1374398767.png')
INSERT [dbo].[Cars] ([CarId], [CarType], [CarModel], [CarBrand], [prize], [Available], [ImagePath]) VALUES (8, N'Premium Car ', N'Chryslar 300s or Similar', N'Chrysler', 100, N'yes', N'~/Content/upload/18192453408.png')
INSERT [dbo].[Cars] ([CarId], [CarType], [CarModel], [CarBrand], [prize], [Available], [ImagePath]) VALUES (9, N'Luxury Car', N'Cadillac xts or Similar', N'Cadillac ', 130, N'yes', N'~/Content/upload/13471766539.png')
INSERT [dbo].[Cars] ([CarId], [CarType], [CarModel], [CarBrand], [prize], [Available], [ImagePath]) VALUES (10, N'Electric Car', N'Tesla Model S or Similar', N'Tesla', 150, N'yes', N'~/Content/upload/137980137410.png')
INSERT [dbo].[Cars] ([CarId], [CarType], [CarModel], [CarBrand], [prize], [Available], [ImagePath]) VALUES (11, N'Compact SUV', N'Ford Eco or Similar', N'Ford', 70, N'yes', N'~/Content/upload/41992396211.png')
INSERT [dbo].[Cars] ([CarId], [CarType], [CarModel], [CarBrand], [prize], [Available], [ImagePath]) VALUES (12, N'Intermediate SUV', N'Toyota RAV4 or similar', N'Toyota', 85, N'yes', N'~/Content/upload/40337771512.png')
INSERT [dbo].[Cars] ([CarId], [CarType], [CarModel], [CarBrand], [prize], [Available], [ImagePath]) VALUES (13, N'Standard SUV', N'Ford Edge or Similar', N'Ford Edge', 95, N'yes', N'~/Content/upload/38505118813.png')
INSERT [dbo].[Cars] ([CarId], [CarType], [CarModel], [CarBrand], [prize], [Available], [ImagePath]) VALUES (14, N'Fullsize SUV', N'Chevrolet tahoe or similar', N'Chevrolet', 110, N'yes', N'~/Content/upload/153712299614.png')
INSERT [dbo].[Cars] ([CarId], [CarType], [CarModel], [CarBrand], [prize], [Available], [ImagePath]) VALUES (15, N'Luxury SUV', N'Infiniti QX80 or Similar', N'Infiniti', 150, N'yes', N'~/Content/upload/23018425715.png')
INSERT [dbo].[Cars] ([CarId], [CarType], [CarModel], [CarBrand], [prize], [Available], [ImagePath]) VALUES (16, N'Premium SUV ', N'chevy suburban or Similar', N'chevy ', 140, N'yes', N'~/Content/upload/59547934016.png')
INSERT [dbo].[Cars] ([CarId], [CarType], [CarModel], [CarBrand], [prize], [Available], [ImagePath]) VALUES (17, N'Jeep 2 Door', N'Jeep wrangler or Similar', N'Jeep', 120, N'yes', N'~/Content/upload/33365793417.png')
INSERT [dbo].[Cars] ([CarId], [CarType], [CarModel], [CarBrand], [prize], [Available], [ImagePath]) VALUES (18, N'Jeep 4 Door', N'Jeep Unlimited or similar', N'Jeep', 140, N'yes', N'~/Content/upload/115061744718.png')
INSERT [dbo].[Cars] ([CarId], [CarType], [CarModel], [CarBrand], [prize], [Available], [ImagePath]) VALUES (19, N'Elite SUV ', N'Audi Q3 or Similar', N'Audi', 160, N'yes', N'~/Content/upload/184551808219.png')
SET IDENTITY_INSERT [dbo].[Cars] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Customer_Id], [FirstName], [LastName], [Username], [Phonenumber], [Email], [Address], [Password]) VALUES (1, N'Tinkal', N'patel', N'tinkal123', 123456789, N'Tinkalpatel@gmail.com', N'2125rue', N'12345')
INSERT [dbo].[Customer] ([Customer_Id], [FirstName], [LastName], [Username], [Phonenumber], [Email], [Address], [Password]) VALUES (2, N'alex', N'verko', N'alex1', 123456789, N'alex@gmail.com', N'2000cathrine', N'123')
INSERT [dbo].[Customer] ([Customer_Id], [FirstName], [LastName], [Username], [Phonenumber], [Email], [Address], [Password]) VALUES (3, N'Anthony', N'disoxa', N'anthony123', 123456789, N'Anthony@gmail.com', N'2322loreant', N'antho123')
INSERT [dbo].[Customer] ([Customer_Id], [FirstName], [LastName], [Username], [Phonenumber], [Email], [Address], [Password]) VALUES (4, N'Dinkar', N'Taneja', N'dink123', 438728333, N'dinkar@gmail.com', N'1200 stanley', N'asdfg1234')
SET IDENTITY_INSERT [dbo].[Customer] OFF
ALTER TABLE [dbo].[BillingDetails]  WITH CHECK ADD  CONSTRAINT [FK_BillingDetails_BookingDetails] FOREIGN KEY([BookingId])
REFERENCES [dbo].[BookingDetails] ([BookingId])
GO
ALTER TABLE [dbo].[BillingDetails] CHECK CONSTRAINT [FK_BillingDetails_BookingDetails]
GO
ALTER TABLE [dbo].[BookingDetails]  WITH CHECK ADD  CONSTRAINT [FK_BookingDetails_Cars] FOREIGN KEY([CarId])
REFERENCES [dbo].[Cars] ([CarId])
GO
ALTER TABLE [dbo].[BookingDetails] CHECK CONSTRAINT [FK_BookingDetails_Cars]
GO
ALTER TABLE [dbo].[BookingDetails]  WITH CHECK ADD  CONSTRAINT [FK_BookingDetails_Customer] FOREIGN KEY([Customer_Id])
REFERENCES [dbo].[Customer] ([Customer_Id])
GO
ALTER TABLE [dbo].[BookingDetails] CHECK CONSTRAINT [FK_BookingDetails_Customer]
GO
USE [master]
GO
ALTER DATABASE [CarRentalSystemDB] SET  READ_WRITE 
GO
