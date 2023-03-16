USE [master]
GO
/****** Object:  Database [LandP]    Script Date: 3/16/2023 2:45:59 PM ******/
CREATE DATABASE [LandP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LandP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\LandP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LandP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\LandP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [LandP] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LandP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LandP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LandP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LandP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LandP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LandP] SET ARITHABORT OFF 
GO
ALTER DATABASE [LandP] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [LandP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LandP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LandP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LandP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LandP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LandP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LandP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LandP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LandP] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LandP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LandP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LandP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LandP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LandP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LandP] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [LandP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LandP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LandP] SET  MULTI_USER 
GO
ALTER DATABASE [LandP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LandP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LandP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LandP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LandP] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LandP] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [LandP] SET QUERY_STORE = ON
GO
ALTER DATABASE [LandP] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [LandP]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 3/16/2023 2:45:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 3/16/2023 2:45:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[Id] [uniqueidentifier] NOT NULL,
	[Province] [nvarchar](max) NULL,
	[District] [nvarchar](max) NULL,
	[Ward] [nvarchar](max) NULL,
	[Detail] [nvarchar](max) NULL,
	[CustomerId] [nvarchar](450) NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 3/16/2023 2:45:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 3/16/2023 2:45:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 3/16/2023 2:45:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 3/16/2023 2:45:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 3/16/2023 2:45:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 3/16/2023 2:45:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[BirthDay] [datetime2](7) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 3/16/2023 2:45:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 3/16/2023 2:45:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[LogoUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CartItems]    Script Date: 3/16/2023 2:45:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CartItems](
	[CustomerId] [nvarchar](450) NOT NULL,
	[ProductId] [uniqueidentifier] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_CartItems] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 3/16/2023 2:45:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[AvatarUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistoryStatuses]    Script Date: 3/16/2023 2:45:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistoryStatuses](
	[Id] [uniqueidentifier] NOT NULL,
	[Status] [nvarchar](max) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[OrderId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_HistoryStatuses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 3/16/2023 2:45:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderId] [uniqueidentifier] NOT NULL,
	[ProductId] [uniqueidentifier] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[PercentSale] [float] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 3/16/2023 2:45:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [uniqueidentifier] NOT NULL,
	[Status] [nvarchar](max) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[isPaid] [bit] NOT NULL,
	[CustomerId] [nvarchar](450) NULL,
	[AddressId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 3/16/2023 2:45:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Price] [float] NOT NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[Unit] [nvarchar](max) NULL,
	[Quantity] [int] NOT NULL,
	[PercentSale] [float] NOT NULL,
	[CategoryId] [uniqueidentifier] NOT NULL,
	[BrandId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reviews]    Script Date: 3/16/2023 2:45:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reviews](
	[CustomerId] [nvarchar](450) NOT NULL,
	[ProductId] [uniqueidentifier] NOT NULL,
	[Rating] [int] NOT NULL,
	[Comment] [nvarchar](max) NULL,
	[OrderId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Reviews] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Views]    Script Date: 3/16/2023 2:45:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Views](
	[CustomerId] [nvarchar](450) NOT NULL,
	[ProductId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Views] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230312113307_init', N'7.0.3')
GO
INSERT [dbo].[Addresses] ([Id], [Province], [District], [Ward], [Detail], [CustomerId]) VALUES (N'a76a63f7-ef1f-4e67-5197-08db236caeb4', N'Ca Mau', N'8', NULL, N'123 Truong Phung Xuan', N'5ab06a7c-2dd9-45f9-8ae1-8d93cf26bec7')
INSERT [dbo].[Addresses] ([Id], [Province], [District], [Ward], [Detail], [CustomerId]) VALUES (N'3d26563a-2e9c-463b-5092-08db237c1fd4', N'Ca Mau', N'8', NULL, N'123 Truong Phung Xuan', N'5ab06a7c-2dd9-45f9-8ae1-8d93cf26bec7')
INSERT [dbo].[Addresses] ([Id], [Province], [District], [Ward], [Detail], [CustomerId]) VALUES (N'798b5cb2-fac2-4d06-15c0-08db23c4abbd', N'Ca Mau', N'8', NULL, N'123 Truong Phung Xuan', N'5ab06a7c-2dd9-45f9-8ae1-8d93cf26bec7')
INSERT [dbo].[Addresses] ([Id], [Province], [District], [Ward], [Detail], [CustomerId]) VALUES (N'edd06ea1-a091-445e-9a24-08db23ca9a3f', N'Ca Mau', N'8', N'5', N'1234 Truong Phung Xuan', N'5ab06a7c-2dd9-45f9-8ae1-8d93cf26bec7')
INSERT [dbo].[Addresses] ([Id], [Province], [District], [Ward], [Detail], [CustomerId]) VALUES (N'72ee3853-2e5a-4324-f89f-08db23ccd565', N'Ca Mau', N'8', NULL, N'1235 Truong Phung Cuong', N'5ab06a7c-2dd9-45f9-8ae1-8d93cf26bec7')
INSERT [dbo].[Addresses] ([Id], [Province], [District], [Ward], [Detail], [CustomerId]) VALUES (N'f07e9fff-71b8-4bea-f8a0-08db23ccd565', N'Ca Mau', N'Tp Ca Mau', N'8', N'1235 Truong Phung Cuong', N'5ab06a7c-2dd9-45f9-8ae1-8d93cf26bec7')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'2bfe0b1e-117d-4afa-b055-f1d87d77b8eb', N'Admin', N'Admin', N'1')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'b3c08f46-a609-4982-8795-3fa49f92bff3', N'SuperAdmin', N'SuperAdmin', N'0')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'e02e213f-f75c-4214-8f5b-aeee20165626', N'User', N'User', N'2')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5ab06a7c-2dd9-45f9-8ae1-8d93cf26bec7', N'e02e213f-f75c-4214-8f5b-aeee20165626')
GO
INSERT [dbo].[AspNetUsers] ([Id], [Name], [BirthDay], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'5ab06a7c-2dd9-45f9-8ae1-8d93cf26bec7', N'Duong Phu Cuong', CAST(N'2002-12-01T00:00:00.0000000' AS DateTime2), N'cuongcamauit@gmail.com', N'CUONGCAMAUIT@GMAIL.COM', N'cuongcamauit@gmail.com', N'CUONGCAMAUIT@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEIibk7yB/D7RkHIt/40qe3MiKTZU4fRiSgHfR+Rzs9JQkwoZfRWVZolUtGWguxDKhg==', N'LIOBUGKLF42F7KCI3D3V5BSFX36CMDSU', N'61e2c631-3870-4910-af82-5d4bf5ed3284', N'0912345', 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[Brands] ([Id], [Name], [Description], [LogoUrl]) VALUES (N'9a2974e1-367a-41e5-8636-08db22f98dcf', N'abc', N'string', N'string')
INSERT [dbo].[Brands] ([Id], [Name], [Description], [LogoUrl]) VALUES (N'efe7fada-e649-43a8-bfb0-08db2497e64a', N'string', N'string', N'string')
INSERT [dbo].[Brands] ([Id], [Name], [Description], [LogoUrl]) VALUES (N'd81232c0-26d8-43da-0edb-08db250c1bea', N'test', N'abc', N'string')
INSERT [dbo].[Brands] ([Id], [Name], [Description], [LogoUrl]) VALUES (N'2e843a73-ffe5-4b11-3d7a-08db250c4b5f', N'string', N'string', N'string')
INSERT [dbo].[Brands] ([Id], [Name], [Description], [LogoUrl]) VALUES (N'973710cd-7d42-4e4c-75bc-08db250cd150', N'string', N'string', N'string')
INSERT [dbo].[Brands] ([Id], [Name], [Description], [LogoUrl]) VALUES (N'c8c66b14-f4c2-486a-75bd-08db250cd150', N'string123', N'string', N'string')
INSERT [dbo].[Brands] ([Id], [Name], [Description], [LogoUrl]) VALUES (N'ebd78fcc-159a-42a8-b9fe-79902ce36577', N'Samsung', NULL, N'hello')
GO
INSERT [dbo].[Categories] ([Id], [Name], [Description], [AvatarUrl]) VALUES (N'418725cd-ce72-42f3-3958-08db22f39159', N'Máy tính bảng', N'A smartdevice', N'https://th.bing.com/th/id/OIP.U1ypxTjWB6CT0BwpSokNWQHaFj?w=237&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7')
INSERT [dbo].[Categories] ([Id], [Name], [Description], [AvatarUrl]) VALUES (N'1d01a275-57bc-436f-ae61-08db22f42dbb', N'Tablet', N'A smartdevice', N'https://th.bing.com/th/id/OIP.U1ypxTjWB6CT0BwpSokNWQHaFj?w=237&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7')
INSERT [dbo].[Categories] ([Id], [Name], [Description], [AvatarUrl]) VALUES (N'b78a4ad8-25e4-44c8-f50e-08db22f45767', N'Tablet', N'A smartdevice', N'https://th.bing.com/th/id/OIP.U1ypxTjWB6CT0BwpSokNWQHaFj?w=237&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7')
INSERT [dbo].[Categories] ([Id], [Name], [Description], [AvatarUrl]) VALUES (N'ef455cff-cfcb-4a44-b44b-08db22f47707', N'Tablet', N'A smartdevice', N'https://th.bing.com/th/id/OIP.U1ypxTjWB6CT0BwpSokNWQHaFj?w=237&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7')
INSERT [dbo].[Categories] ([Id], [Name], [Description], [AvatarUrl]) VALUES (N'cee095c1-bb26-4bf1-9e89-08db22f5aa82', N'Tablet', N'A smartdevice', N'https://th.bing.com/th/id/OIP.U1ypxTjWB6CT0BwpSokNWQHaFj?w=237&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7')
INSERT [dbo].[Categories] ([Id], [Name], [Description], [AvatarUrl]) VALUES (N'af03667d-5e68-48e3-8f2d-08db22f5c9c3', N'Tablet', N'A smartdevice', N'https://th.bing.com/th/id/OIP.U1ypxTjWB6CT0BwpSokNWQHaFj?w=237&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7')
INSERT [dbo].[Categories] ([Id], [Name], [Description], [AvatarUrl]) VALUES (N'7f0257fd-b3cb-4196-84c4-08db22f617de', N'Tablet', N'A smartdevice', N'https://th.bing.com/th/id/OIP.U1ypxTjWB6CT0BwpSokNWQHaFj?w=237&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7')
INSERT [dbo].[Categories] ([Id], [Name], [Description], [AvatarUrl]) VALUES (N'ec457683-17a3-41ba-9613-939d258855d2', N'Test Category', NULL, NULL)
GO
INSERT [dbo].[HistoryStatuses] ([Id], [Status], [Date], [OrderId]) VALUES (N'5fddf1c0-4bb2-4290-8c0d-08db25eaf71d', N'New', CAST(N'2023-03-16T13:52:10.1529102' AS DateTime2), N'5d6f7d54-eaa0-4648-008b-08db25eaf6fc')
GO
INSERT [dbo].[OrderDetails] ([OrderId], [ProductId], [Quantity], [Price], [PercentSale]) VALUES (N'5d6f7d54-eaa0-4648-008b-08db25eaf6fc', N'b5e05d85-cef2-4bff-fe60-08db23c458b6', 2, 100000, 0)
GO
INSERT [dbo].[Orders] ([Id], [Status], [Date], [isPaid], [CustomerId], [AddressId]) VALUES (N'5d6f7d54-eaa0-4648-008b-08db25eaf6fc', N'New', CAST(N'2023-03-16T13:52:09.8650351' AS DateTime2), 1, N'5ab06a7c-2dd9-45f9-8ae1-8d93cf26bec7', N'a76a63f7-ef1f-4e67-5197-08db236caeb4')
GO
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [ImageUrl], [Unit], [Quantity], [PercentSale], [CategoryId], [BrandId]) VALUES (N'b5e05d85-cef2-4bff-fe60-08db23c458b6', N'Samsung a29', N'string', 100000, N'string', N'Cai', 8, 0, N'418725cd-ce72-42f3-3958-08db22f39159', N'ebd78fcc-159a-42a8-b9fe-79902ce36577')
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [ImageUrl], [Unit], [Quantity], [PercentSale], [CategoryId], [BrandId]) VALUES (N'f4fd9151-1c11-45ab-bdc1-08db25612b7d', N'string', N'string', 0, N'string', N'string', 0, 0, N'418725cd-ce72-42f3-3958-08db22f39159', N'ebd78fcc-159a-42a8-b9fe-79902ce36577')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Addresses_CustomerId]    Script Date: 3/16/2023 2:45:59 PM ******/
CREATE NONCLUSTERED INDEX [IX_Addresses_CustomerId] ON [dbo].[Addresses]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 3/16/2023 2:45:59 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 3/16/2023 2:45:59 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 3/16/2023 2:45:59 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 3/16/2023 2:45:59 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 3/16/2023 2:45:59 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 3/16/2023 2:45:59 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 3/16/2023 2:45:59 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CartItems_ProductId]    Script Date: 3/16/2023 2:45:59 PM ******/
CREATE NONCLUSTERED INDEX [IX_CartItems_ProductId] ON [dbo].[CartItems]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_HistoryStatuses_OrderId]    Script Date: 3/16/2023 2:45:59 PM ******/
CREATE NONCLUSTERED INDEX [IX_HistoryStatuses_OrderId] ON [dbo].[HistoryStatuses]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderDetails_ProductId]    Script Date: 3/16/2023 2:45:59 PM ******/
CREATE NONCLUSTERED INDEX [IX_OrderDetails_ProductId] ON [dbo].[OrderDetails]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_AddressId]    Script Date: 3/16/2023 2:45:59 PM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_AddressId] ON [dbo].[Orders]
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Orders_CustomerId]    Script Date: 3/16/2023 2:45:59 PM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_CustomerId] ON [dbo].[Orders]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_BrandId]    Script Date: 3/16/2023 2:45:59 PM ******/
CREATE NONCLUSTERED INDEX [IX_Products_BrandId] ON [dbo].[Products]
(
	[BrandId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_CategoryId]    Script Date: 3/16/2023 2:45:59 PM ******/
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId] ON [dbo].[Products]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Reviews_OrderId]    Script Date: 3/16/2023 2:45:59 PM ******/
CREATE NONCLUSTERED INDEX [IX_Reviews_OrderId] ON [dbo].[Reviews]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Reviews_ProductId]    Script Date: 3/16/2023 2:45:59 PM ******/
CREATE NONCLUSTERED INDEX [IX_Reviews_ProductId] ON [dbo].[Reviews]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Views_ProductId]    Script Date: 3/16/2023 2:45:59 PM ******/
CREATE NONCLUSTERED INDEX [IX_Views_ProductId] ON [dbo].[Views]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_AspNetUsers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_AspNetUsers_CustomerId]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[CartItems]  WITH CHECK ADD  CONSTRAINT [FK_CartItems_AspNetUsers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CartItems] CHECK CONSTRAINT [FK_CartItems_AspNetUsers_CustomerId]
GO
ALTER TABLE [dbo].[CartItems]  WITH CHECK ADD  CONSTRAINT [FK_CartItems_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CartItems] CHECK CONSTRAINT [FK_CartItems_Products_ProductId]
GO
ALTER TABLE [dbo].[HistoryStatuses]  WITH CHECK ADD  CONSTRAINT [FK_HistoryStatuses_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HistoryStatuses] CHECK CONSTRAINT [FK_HistoryStatuses_Orders_OrderId]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders_OrderId]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products_ProductId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Addresses_AddressId] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Addresses] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Addresses_AddressId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_AspNetUsers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_AspNetUsers_CustomerId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Brands_BrandId] FOREIGN KEY([BrandId])
REFERENCES [dbo].[Brands] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Brands_BrandId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_Reviews_AspNetUsers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_Reviews_AspNetUsers_CustomerId]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_Reviews_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_Reviews_Orders_OrderId]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_Reviews_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_Reviews_Products_ProductId]
GO
ALTER TABLE [dbo].[Views]  WITH CHECK ADD  CONSTRAINT [FK_Views_AspNetUsers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Views] CHECK CONSTRAINT [FK_Views_AspNetUsers_CustomerId]
GO
ALTER TABLE [dbo].[Views]  WITH CHECK ADD  CONSTRAINT [FK_Views_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Views] CHECK CONSTRAINT [FK_Views_Products_ProductId]
GO
USE [master]
GO
ALTER DATABASE [LandP] SET  READ_WRITE 
GO
