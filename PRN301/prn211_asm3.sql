USE [master]
GO
/****** Object:  Database [PRN_As3]    Script Date: 12/03/2024 21:28:24 ******/
CREATE DATABASE [PRN_As3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PRN_As3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\PRN_As3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PRN_As3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\PRN_As3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [PRN_As3] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PRN_As3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PRN_As3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PRN_As3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PRN_As3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PRN_As3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PRN_As3] SET ARITHABORT OFF 
GO
ALTER DATABASE [PRN_As3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PRN_As3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PRN_As3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PRN_As3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PRN_As3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PRN_As3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PRN_As3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PRN_As3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PRN_As3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PRN_As3] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PRN_As3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PRN_As3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PRN_As3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PRN_As3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PRN_As3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PRN_As3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PRN_As3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PRN_As3] SET RECOVERY FULL 
GO
ALTER DATABASE [PRN_As3] SET  MULTI_USER 
GO
ALTER DATABASE [PRN_As3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PRN_As3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PRN_As3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PRN_As3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PRN_As3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PRN_As3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PRN_As3', N'ON'
GO
ALTER DATABASE [PRN_As3] SET QUERY_STORE = ON
GO
ALTER DATABASE [PRN_As3] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [PRN_As3]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 12/03/2024 21:28:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberId] [int] NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[CompanyName] [varchar](40) NOT NULL,
	[City] [varchar](15) NOT NULL,
	[Country] [varchar](15) NOT NULL,
	[Password] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 12/03/2024 21:28:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[RequiredDate] [datetime] NULL,
	[ShippedDate] [datetime] NULL,
	[Freight] [money] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 12/03/2024 21:28:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 12/03/2024 21:28:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProductName] [varchar](40) NOT NULL,
	[Weight] [varchar](20) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[UnitsInStock] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (1, N'hieuthu2@gmail.com', N'FptSoftware', N'Hanoi', N'Hoa Lac', N'123456789')
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (2, N'anhbaus@gmail.com', N'Viettel', N'Da Nang', N'Tren May', N'123456789')
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (3, N'sontungMtp@gmail.com', N'RapViet', N'Ho Chi Minh', N'Tren Troi', N'123456789')
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (4, N'mono@gmail.com', N'TheVoice', N'Ha Giang', N'Duoi Dat', N'123456789')
GO
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (1, 1, CAST(N'2022-05-12T09:30:00.000' AS DateTime), CAST(N'2022-05-12T09:30:00.000' AS DateTime), CAST(N'2022-05-12T09:30:00.000' AS DateTime), 9.0000)
GO
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (2, 2, CAST(N'2022-05-12T09:30:00.000' AS DateTime), CAST(N'2022-05-12T09:30:00.000' AS DateTime), CAST(N'2022-05-12T09:30:00.000' AS DateTime), 19.0000)
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1, 1, 1.0000, 1, 0)
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1, 2, 2.0000, 1, 0)
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1, 3, 6.0000, 2, 0)
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (2, 3, 6.0000, 2, 0)
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (2, 4, 8.0000, 2, 0)
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (2, 5, 5.0000, 1, 0)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (1, 1, N'The LowG', N'30', 1.0000, 20)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (2, 1, N'The DLow', N'30', 2.0000, 13)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (3, 1, N'The MCK', N'39', 3.0000, 30)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (4, 2, N'The Son Tung MTP', N'20', 4.0000, 40)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (5, 2, N'The Den Vau', N'30', 5.0000, 20)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (6, 2, N'The Ngoc Trinh', N'40', 6.0000, 20)
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Member]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Product]
GO
USE [master]
GO
ALTER DATABASE [PRN_As3] SET  READ_WRITE 
GO
