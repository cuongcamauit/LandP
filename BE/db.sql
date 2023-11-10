USE [master]
GO
/****** Object:  Database [LandP4]    Script Date: 11/10/2023 2:26:40 PM ******/
CREATE DATABASE [LandP4]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LandP4', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\LandP4.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LandP4_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\LandP4_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [LandP4] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LandP4].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LandP4] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LandP4] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LandP4] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LandP4] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LandP4] SET ARITHABORT OFF 
GO
ALTER DATABASE [LandP4] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LandP4] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LandP4] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LandP4] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LandP4] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LandP4] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LandP4] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LandP4] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LandP4] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LandP4] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LandP4] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LandP4] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LandP4] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LandP4] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LandP4] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LandP4] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [LandP4] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LandP4] SET RECOVERY FULL 
GO
ALTER DATABASE [LandP4] SET  MULTI_USER 
GO
ALTER DATABASE [LandP4] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LandP4] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LandP4] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LandP4] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LandP4] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LandP4] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'LandP4', N'ON'
GO
ALTER DATABASE [LandP4] SET QUERY_STORE = ON
GO
ALTER DATABASE [LandP4] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [LandP4]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/10/2023 2:26:40 PM ******/
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
/****** Object:  Table [dbo].[Addresses]    Script Date: 11/10/2023 2:26:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[Id] [uniqueidentifier] NOT NULL,
	[ProvinceName] [nvarchar](max) NULL,
	[ProvinceId] [int] NOT NULL,
	[DistrictName] [nvarchar](max) NULL,
	[DistrictId] [int] NOT NULL,
	[WardName] [nvarchar](max) NULL,
	[WardCode] [nvarchar](max) NULL,
	[Detail] [nvarchar](max) NULL,
	[CustomerId] [nvarchar](450) NULL,
	[isDefault] [bit] NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 11/10/2023 2:26:41 PM ******/
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
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 11/10/2023 2:26:41 PM ******/
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
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 11/10/2023 2:26:41 PM ******/
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
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 11/10/2023 2:26:41 PM ******/
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
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 11/10/2023 2:26:41 PM ******/
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
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 11/10/2023 2:26:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[BirthDay] [datetime2](7) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NOT NULL,
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
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 11/10/2023 2:26:41 PM ******/
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
/****** Object:  Table [dbo].[AttributeGroups]    Script Date: 11/10/2023 2:26:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttributeGroups](
	[AttributeId] [int] NOT NULL,
	[CategoryId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_AttributeGroups] PRIMARY KEY CLUSTERED 
(
	[AttributeId] ASC,
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AttributeOptions]    Script Date: 11/10/2023 2:26:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttributeOptions](
	[Id] [int] NOT NULL,
	[AttributeId] [int] NOT NULL,
	[Value] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_AttributeOptions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[AttributeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Attributes]    Script Date: 11/10/2023 2:26:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attributes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Attributes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AttributeSpecs]    Script Date: 11/10/2023 2:26:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttributeSpecs](
	[ProductId] [uniqueidentifier] NOT NULL,
	[AttributeId] [int] NOT NULL,
	[Value] [nvarchar](max) NULL,
	[OptionID] [int] NULL,
 CONSTRAINT [PK_AttributeSpecs] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC,
	[AttributeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 11/10/2023 2:26:41 PM ******/
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
/****** Object:  Table [dbo].[CartItems]    Script Date: 11/10/2023 2:26:41 PM ******/
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
/****** Object:  Table [dbo].[Categories]    Script Date: 11/10/2023 2:26:41 PM ******/
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
/****** Object:  Table [dbo].[Documents]    Script Date: 11/10/2023 2:26:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Documents](
	[Id] [nvarchar](450) NOT NULL,
	[ProductId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Documents] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistoryStatuses]    Script Date: 11/10/2023 2:26:41 PM ******/
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
/****** Object:  Table [dbo].[Menus]    Script Date: 11/10/2023 2:26:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menus](
	[slugId] [nvarchar](450) NOT NULL,
	[ParentId] [nvarchar](450) NULL,
 CONSTRAINT [PK_Menus] PRIMARY KEY CLUSTERED 
(
	[slugId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 11/10/2023 2:26:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderId] [uniqueidentifier] NOT NULL,
	[ProductId] [uniqueidentifier] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 11/10/2023 2:26:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [uniqueidentifier] NOT NULL,
	[Status] [nvarchar](max) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[PaidAt] [datetime2](7) NULL,
	[SubTotal] [float] NOT NULL,
	[ShippingFee] [float] NOT NULL,
	[ShippingFeeVoucher] [float] NOT NULL,
	[ShopVoucher] [float] NOT NULL,
	[CustomerId] [nvarchar](450) NULL,
	[AddressId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductPrices]    Script Date: 11/10/2023 2:26:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductPrices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [uniqueidentifier] NOT NULL,
	[Price] [float] NOT NULL,
	[FromDate] [datetime2](7) NOT NULL,
	[ToDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ProductPrices] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 11/10/2023 2:26:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[IsDeleted] [bit] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Price] [float] NOT NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[FolderId] [nvarchar](max) NULL,
	[Unit] [nvarchar](max) NULL,
	[Quantity] [int] NOT NULL,
	[CategoryId] [uniqueidentifier] NOT NULL,
	[BrandId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reviews]    Script Date: 11/10/2023 2:26:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reviews](
	[ProductId] [uniqueidentifier] NOT NULL,
	[CustomerId] [nvarchar](450) NOT NULL,
	[OrderId] [uniqueidentifier] NOT NULL,
	[Rating] [int] NOT NULL,
	[Comment] [nvarchar](max) NULL,
	[Date] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Reviews] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC,
	[ProductId] ASC,
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SlugProducts]    Script Date: 11/10/2023 2:26:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SlugProducts](
	[SlugId] [nvarchar](450) NOT NULL,
	[ProductId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_SlugProducts] PRIMARY KEY CLUSTERED 
(
	[SlugId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Slugs]    Script Date: 11/10/2023 2:26:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Slugs](
	[Id] [nvarchar](450) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsSilder] [bit] NOT NULL,
	[MenuId] [nvarchar](450) NULL,
 CONSTRAINT [PK_Slugs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Views]    Script Date: 11/10/2023 2:26:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Views](
	[CustomerId] [nvarchar](450) NOT NULL,
	[ProductId] [uniqueidentifier] NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Views] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231110071832_Initial', N'7.0.3')
GO
INSERT [dbo].[Addresses] ([Id], [ProvinceName], [ProvinceId], [DistrictName], [DistrictId], [WardName], [WardCode], [Detail], [CustomerId], [isDefault]) VALUES (N'3fd64b58-5ded-40ed-876c-027bcc759a75', N'Thành phố Hồ Chí Minh', 202, N'Quận 12', 1454, N'Phường Tân Chánh Hiệp', N'21204', N'Đường Tô Ký', N'1b0b163d-032f-4e19-9e64-d89bf02f1751', 0)
INSERT [dbo].[Addresses] ([Id], [ProvinceName], [ProvinceId], [DistrictName], [DistrictId], [WardName], [WardCode], [Detail], [CustomerId], [isDefault]) VALUES (N'0750d8d3-bfff-45f2-b081-2a86ffe91bfd', N'Cà Mau', 252, N'Thành phố Cà Mau', 1654, N'8', N'610107', N'Khóm 5', N'04be0c35-571e-425c-992e-15a7227286de', 0)
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'04be0c35-571e-425c-992e-15a7227286de', N'User', N'User', N'2')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'289f6c6a783e4d89b25c847d1ffa4833', N'SuperAdmin', N'SuperAdmin', N'0')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'43bd8d30-85af-4960-8a9f-d7f7eeeb8571', N'Admin', N'Admin', N'1')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'04be0c35-571e-425c-992e-15a7227286de', N'04be0c35-571e-425c-992e-15a7227286de')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1b0b163d-032f-4e19-9e64-d89bf02f1751', N'04be0c35-571e-425c-992e-15a7227286de')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'289f6c6a783e4d89b25c847d1ffa4833', N'289f6c6a783e4d89b25c847d1ffa4833')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'43bd8d30-85af-4960-8a9f-d7f7eeeb8571', N'43bd8d30-85af-4960-8a9f-d7f7eeeb8571')
GO
INSERT [dbo].[AspNetUsers] ([Id], [Name], [BirthDay], [CreateDate], [UpdateDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'04be0c35-571e-425c-992e-15a7227286de', N'User', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'landpuserdemo@gmail.com', NULL, N'landpuserdemo@gmail.com', N'landpuserdemo@gmail.com', 1, N'AQAAAAEAACcQAAAAEN4oGABFvAFZiOK6IOfXFZ8TMF9NXvWkC+tN0KTD8zELbRXhlhpGAg3V2fshIgXo+Q==', N'c3f972ca-0668-487f-b596-5641221921fc', N'a30578da-6cf1-40ad-92a9-a6c90605db4c', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Name], [BirthDay], [CreateDate], [UpdateDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'1b0b163d-032f-4e19-9e64-d89bf02f1751', N'User1', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'landpuserdemo1@gmail.com', NULL, N'landpuserdemo1@gmail.com', N'landpuserdemo1@gmail.com', 1, N'AQAAAAEAACcQAAAAENBhW0ATM4Rm44CzpP3bLq3LpNhuR+f7k/XCimUGvnTSCMIewCdSy8en7YKmIkpw8w==', N'6e6b72bb-f59b-413d-8bc2-bc687e95b765', N'f3693d39-a89f-41b1-b0f1-97ff96ae3a56', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Name], [BirthDay], [CreateDate], [UpdateDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'289f6c6a783e4d89b25c847d1ffa4833', N'Super Admin', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'landpsupadmika@gmail.com', NULL, N'landpsupadmika@gmail.com', N'landpsupadmika@gmail.com', 1, N'AQAAAAEAACcQAAAAEHcCLvnwTI1mHLEye3XTWIznTJRPRTlALGAnnpHOu2924/DeNpDCfLaGWojcF4tiLg==', N'835b9025-fe00-49e7-8181-7d0cf88e629a', N'86d6ae36-cf6f-4bc6-8b96-8c83185549bb', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Name], [BirthDay], [CreateDate], [UpdateDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'43bd8d30-85af-4960-8a9f-d7f7eeeb8571', N'Admin', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'landpadmika@gmail.com', NULL, N'landpadmika@gmail.com', N'landpadmika@gmail.com', 1, N'AQAAAAEAACcQAAAAED/5BxlIwmntPlUk1j/A1/XqMBl30LG1URWuLxT1MTBSwLfb6Nrq8MPla53kVf64NA==', N'0221f2f2-c7a7-43ca-9ae3-50275b1e2c46', N'083c6cdb-f800-4051-adcf-631f1ffd1b9b', NULL, 0, 0, NULL, 0, 0)
GO
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (1, 1, N'APPLE')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (1, 3, N'Macbook Pro')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (1, 4, N'Silver')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (1, 5, N'Business')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (1, 6, N'Apple M')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (1, 9, N'4GB')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (1, 10, N'11.6"')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (1, 16, N'Android')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (2, 1, N'ACER')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (2, 3, N'Macbook Air')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (2, 4, N'Gold')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (2, 5, N'Entrepreneur')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (2, 6, N'Celeron')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (2, 9, N'8GB')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (2, 10, N'12.3"')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (2, 16, N'iOS')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (3, 1, N'ASUS')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (3, 3, N'Aspire 5')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (3, 4, N'Red')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (3, 5, N'Gaming')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (3, 6, N'Core i3')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (3, 9, N'16GB')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (3, 10, N'13"')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (4, 1, N'Dell')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (4, 3, N'Nitro 5')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (4, 4, N'Midnight')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (4, 5, N'Family')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (4, 6, N'Core i5')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (4, 9, N'24GB')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (4, 10, N'13.3"')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (5, 1, N'Samsung')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (5, 3, N'Nitro 16')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (5, 4, N'Starlight')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (5, 5, N'Students')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (5, 6, N'Core i7')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (5, 9, N'32GB')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (5, 10, N'13.4"')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (6, 1, N'Xiaomi')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (6, 3, N'Vivobook')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (6, 4, N'White')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (6, 5, N'Office')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (6, 6, N'Core i9')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (6, 9, N'64GB')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (6, 10, N'13.5"')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (7, 3, N'Inspiron')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (7, 4, N'Sand gold')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (7, 5, N'Graphics - Engineering')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (7, 6, N'Qualcomn')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (7, 10, N'13.6"')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (8, 3, N'Vostro')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (8, 4, N'Bronze gold')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (8, 6, N'Snapdrogon')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (8, 10, N'14"')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (9, 4, N'Green')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (9, 6, N'Ryzen 3')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (9, 10, N'14.2"')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (10, 4, N'Grey')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (10, 6, N'Ryzen 5')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (10, 10, N'14.5"')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (11, 4, N'Silver gray')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (11, 6, N'Ryzen 7')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (11, 10, N'15.3"')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (12, 4, N'Dark gray')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (12, 6, N'Ryzen 9')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (12, 10, N'15.6"')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (13, 4, N'Black')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (13, 10, N'16"')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (14, 10, N'16.1"')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (15, 10, N'17"')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (16, 10, N'17.3"')
INSERT [dbo].[AttributeOptions] ([Id], [AttributeId], [Value]) VALUES (17, 10, N'18"')
GO
SET IDENTITY_INSERT [dbo].[Attributes] ON 

INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (1, N'Trademark', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (2, N'Warranty', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (3, N'Laptop series', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (4, N'Colour', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (5, N'Demand', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (6, N'CPU generation', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (7, N'CPU', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (8, N'Graphics chip', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (9, N'RAM', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (10, N'Monitor', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (11, N'Archive', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (12, N'Video output port', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (13, N'Gateway', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (14, N'Wireless connection', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (15, N'Keyboard', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (16, N'Operating system', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (17, N'Dimension', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (18, N'Battery', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (19, N'Mass', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (20, N'Included accessories', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (21, N'Series', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (22, N'Screen type', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (23, N'Resolution', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (24, N'Capacity(ROM)', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (25, N'Chip', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (26, N'Battery technology', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (27, N'Charging port', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (28, N'SIM type', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (29, N'Mobile networks', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (30, N'Rear camera', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (31, N'Front camera', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (32, N'Wifi', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (33, N'GPS', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (34, N'Blutooth', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (35, N'Headphone jack', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (36, N'Feature', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (37, N'Case Size', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (38, N'Screen technology', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (39, N'Screen size', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (40, N'Glass Material', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (41, N'Internal memory', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (42, N'Connect', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (43, N'Time of use', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (44, N'Material', NULL)
INSERT [dbo].[Attributes] ([Id], [Name], [Description]) VALUES (45, N'Strap', NULL)
SET IDENTITY_INSERT [dbo].[Attributes] OFF
GO
INSERT [dbo].[AttributeSpecs] ([ProductId], [AttributeId], [Value], [OptionID]) VALUES (N'338e268a-f282-4cc6-b823-0b40592bb4c1', 1, NULL, 1)
INSERT [dbo].[AttributeSpecs] ([ProductId], [AttributeId], [Value], [OptionID]) VALUES (N'338e268a-f282-4cc6-b823-0b40592bb4c1', 2, N'12 months', NULL)
INSERT [dbo].[AttributeSpecs] ([ProductId], [AttributeId], [Value], [OptionID]) VALUES (N'338e268a-f282-4cc6-b823-0b40592bb4c1', 3, NULL, 1)
INSERT [dbo].[AttributeSpecs] ([ProductId], [AttributeId], [Value], [OptionID]) VALUES (N'338e268a-f282-4cc6-b823-0b40592bb4c1', 4, NULL, 1)
INSERT [dbo].[AttributeSpecs] ([ProductId], [AttributeId], [Value], [OptionID]) VALUES (N'338e268a-f282-4cc6-b823-0b40592bb4c1', 5, NULL, 1)
INSERT [dbo].[AttributeSpecs] ([ProductId], [AttributeId], [Value], [OptionID]) VALUES (N'338e268a-f282-4cc6-b823-0b40592bb4c1', 6, NULL, 1)
INSERT [dbo].[AttributeSpecs] ([ProductId], [AttributeId], [Value], [OptionID]) VALUES (N'338e268a-f282-4cc6-b823-0b40592bb4c1', 7, N'Apple M2 Max ( 12-Core CPU / 64-Core GPU )', NULL)
INSERT [dbo].[AttributeSpecs] ([ProductId], [AttributeId], [Value], [OptionID]) VALUES (N'338e268a-f282-4cc6-b823-0b40592bb4c1', 8, NULL, NULL)
INSERT [dbo].[AttributeSpecs] ([ProductId], [AttributeId], [Value], [OptionID]) VALUES (N'338e268a-f282-4cc6-b823-0b40592bb4c1', 9, NULL, 6)
INSERT [dbo].[AttributeSpecs] ([ProductId], [AttributeId], [Value], [OptionID]) VALUES (N'338e268a-f282-4cc6-b823-0b40592bb4c1', 10, NULL, 13)
INSERT [dbo].[AttributeSpecs] ([ProductId], [AttributeId], [Value], [OptionID]) VALUES (N'338e268a-f282-4cc6-b823-0b40592bb4c1', 11, NULL, NULL)
INSERT [dbo].[AttributeSpecs] ([ProductId], [AttributeId], [Value], [OptionID]) VALUES (N'338e268a-f282-4cc6-b823-0b40592bb4c1', 12, N'1 x HDMI', NULL)
INSERT [dbo].[AttributeSpecs] ([ProductId], [AttributeId], [Value], [OptionID]) VALUES (N'338e268a-f282-4cc6-b823-0b40592bb4c1', 13, N'3 x Thunderbolt 4 , 1 x 3.5 mm , 1 x SDXC Card Slot', NULL)
INSERT [dbo].[AttributeSpecs] ([ProductId], [AttributeId], [Value], [OptionID]) VALUES (N'338e268a-f282-4cc6-b823-0b40592bb4c1', 14, N'WiFi 802.11ax (Wifi 6) , Bluetooth 5.3', NULL)
INSERT [dbo].[AttributeSpecs] ([ProductId], [AttributeId], [Value], [OptionID]) VALUES (N'338e268a-f282-4cc6-b823-0b40592bb4c1', 15, NULL, NULL)
INSERT [dbo].[AttributeSpecs] ([ProductId], [AttributeId], [Value], [OptionID]) VALUES (N'338e268a-f282-4cc6-b823-0b40592bb4c1', 16, N'macOS', NULL)
INSERT [dbo].[AttributeSpecs] ([ProductId], [AttributeId], [Value], [OptionID]) VALUES (N'338e268a-f282-4cc6-b823-0b40592bb4c1', 17, N'1.68 x 35.57 x 24.81 cm', NULL)
INSERT [dbo].[AttributeSpecs] ([ProductId], [AttributeId], [Value], [OptionID]) VALUES (N'338e268a-f282-4cc6-b823-0b40592bb4c1', 18, N'100 Wh', NULL)
INSERT [dbo].[AttributeSpecs] ([ProductId], [AttributeId], [Value], [OptionID]) VALUES (N'338e268a-f282-4cc6-b823-0b40592bb4c1', 19, N'2.1 kg', NULL)
INSERT [dbo].[AttributeSpecs] ([ProductId], [AttributeId], [Value], [OptionID]) VALUES (N'338e268a-f282-4cc6-b823-0b40592bb4c1', 20, NULL, NULL)
GO
INSERT [dbo].[Brands] ([Id], [Name], [Description], [LogoUrl]) VALUES (N'71d6e1f9-8c22-43e8-ad37-1609dd7bc61e', N'Assus', N'In 2015 and 2016, Fortune magazine recognized ASUS as one of the world''s most popular companies, and for the past four years, Interbrand has ranked ASUS as Taiwan''s most valuable international brand . Loan', N'')
INSERT [dbo].[Brands] ([Id], [Name], [Description], [LogoUrl]) VALUES (N'2ef43281-9c42-466e-ad66-483ff6f46326', N'Samsung', N'Samsung Group or Samsung (Korean: 삼성, Roma: Samseong, Hanja: 三星; Sino-Vietnamese: Tam Tinh - 3 stars) is a South Korean multinational corporation headquartered in Samsung Town, Seocho , Seoul', N'')
INSERT [dbo].[Brands] ([Id], [Name], [Description], [LogoUrl]) VALUES (N'04d63fc1-582a-4ad3-9132-b531101220ca', N'Dell', N'Dell Inc is an American multinational company that develops and commercializes computer technology headquartered in Round Rock, Texas, United States. In 1984, Dell was founded by Michael Dell. It is the 28th largest company by revenue in the United States', N'')
INSERT [dbo].[Brands] ([Id], [Name], [Description], [LogoUrl]) VALUES (N'fc6fcd3e-f156-4a33-a257-c92adfba2c63', N'Acer', N'Founded in 1976, Acer is a Taiwanese multinational corporation of electronics and computer hardware', N'')
INSERT [dbo].[Brands] ([Id], [Name], [Description], [LogoUrl]) VALUES (N'36326612-2d44-446f-87cd-d060d14237a6', N'Apple', N'Apple is a large American technology corporation headquartered in Cupertino, California. Apple was founded on April 1, 1976 by three founders Steve Wozniak, Steve Jobs and Ronald Wayne, under the original name Apple Computer Inc, then changed its name to Apple in early 2007', N'')
INSERT [dbo].[Brands] ([Id], [Name], [Description], [LogoUrl]) VALUES (N'32a244dc-528a-402a-b8e0-d86b31f0b8cb', N'Xiaomi', N'Xiaomi is a Chinese technology corporation , headquartered in Beijing. Considered the Apple of China, after only 5 years of establishment, Xiaomi has become the smartphone manufacturer with the 5th largest market share in the world and 1st in its home market (2015)', N'')
GO
INSERT [dbo].[Categories] ([Id], [Name], [Description], [AvatarUrl]) VALUES (N'3f8d98cb-a695-4334-bec2-09008670c39a', N'Laptop', N'A smart device', N'')
INSERT [dbo].[Categories] ([Id], [Name], [Description], [AvatarUrl]) VALUES (N'bc17dda5-9e53-434d-ab30-32452bfc7d35', N'Smartphone', N'A smart device', N'')
INSERT [dbo].[Categories] ([Id], [Name], [Description], [AvatarUrl]) VALUES (N'a54988d2-7eeb-4e6c-8421-6f3fa5bb91a2', N'Tablet', N'A smart device', N'')
INSERT [dbo].[Categories] ([Id], [Name], [Description], [AvatarUrl]) VALUES (N'3649b208-05c6-4129-86bd-df77801d3d39', N'Smartwatch', N'A smart device', N'')
GO
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1F2Z5C1km_4FvIa70xF0b8bL-OwsK07d6', N'338e268a-f282-4cc6-b823-0b40592bb4c1')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1fXgj_qQJMKNQczOx0Kd_0foAVyiYcmb8', N'338e268a-f282-4cc6-b823-0b40592bb4c1')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1IrnkUeFEoVdNEY-FMf0Y4i33tOEOh1l8', N'338e268a-f282-4cc6-b823-0b40592bb4c1')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1p0Eq0ptA7J3g5mTUP9g131BgLb6XCiyI', N'338e268a-f282-4cc6-b823-0b40592bb4c1')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1KAPyG_jY6xo0pp13IhGHq3HosAlc42hB', N'9cd800e5-3457-4602-9083-1d7fee04e240')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1pmIx4SB6rmApjVB6YIm9rYmsn7C5GNua', N'9cd800e5-3457-4602-9083-1d7fee04e240')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1sf_iHr6KcO6Gl7oucfq46NirqaBERifh', N'9cd800e5-3457-4602-9083-1d7fee04e240')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1vpOJlcWyzrUGceYi-ilCZ4b3ufeMZapS', N'9cd800e5-3457-4602-9083-1d7fee04e240')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1_8nLKemsZNH5ob80loz-Rjk46gIPCyAk', N'33ae145c-880a-493c-aecd-3859d66f41a7')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=13YRnumTXIikNyks6MMGS7IHy2XKsLcUG', N'33ae145c-880a-493c-aecd-3859d66f41a7')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=18_VERsQCkR5top5RyAiyXBWoyQTVgYLU', N'33ae145c-880a-493c-aecd-3859d66f41a7')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1gCSDRkYeTgsuklm4-ZUVKutTKTu6bsOW', N'33ae145c-880a-493c-aecd-3859d66f41a7')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1oA7zu7vf9vxdDzRUOfTShMTO9TMYB2t1', N'33ae145c-880a-493c-aecd-3859d66f41a7')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1hcc5bb9xZwftkpNNLbNSdWO-OaglGEU-', N'53b17c22-a6de-49c3-8a15-3dc252805fa3')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1KGDOpVmwofx2viWcLPSdji5_dVz6IEYK', N'53b17c22-a6de-49c3-8a15-3dc252805fa3')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1NB-4hrhVBTP0kRbx9VOMRxMEOIsuT0Dt', N'53b17c22-a6de-49c3-8a15-3dc252805fa3')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'', N'1a7a8ea6-ccb4-4133-bc01-5031e0ea8de8')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1_mXukBwuEtyZsG7bR_MDAO-d7PjMhP-w', N'1a7a8ea6-ccb4-4133-bc01-5031e0ea8de8')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=17g-gOr-mKqeRCKmv3aLa7kNBIf8AMza2', N'1a7a8ea6-ccb4-4133-bc01-5031e0ea8de8')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1pW-V7JEHlpOswTpw68p7GbAV_NV8i62S', N'1a7a8ea6-ccb4-4133-bc01-5031e0ea8de8')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1sojVUeqtcf6kDA84Mdj73JcbipmW5HP0', N'1a7a8ea6-ccb4-4133-bc01-5031e0ea8de8')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=19JhyKc7SDq8OS-FKWCEE1fHlB9zmlF4_', N'86e30c06-9d56-44c4-8ddc-f209eea665df')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1ANMv2MD1x9POXwFzqbtAFJaSVDsBygR_', N'86e30c06-9d56-44c4-8ddc-f209eea665df')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1AoKIxY1_KpVC--DBDv-5vkL7KRBETaTj', N'86e30c06-9d56-44c4-8ddc-f209eea665df')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1D6w59akVTqabNKBcaDFvZeGh0DHiPZNS', N'86e30c06-9d56-44c4-8ddc-f209eea665df')
INSERT [dbo].[Documents] ([Id], [ProductId]) VALUES (N'https://drive.google.com/uc?export=view&id=1jFJ0Dy7LgyF9l-bnF6VeOVpvbqDDXkgz', N'86e30c06-9d56-44c4-8ddc-f209eea665df')
GO
INSERT [dbo].[Menus] ([slugId], [ParentId]) VALUES (N'laptop', NULL)
INSERT [dbo].[Menus] ([slugId], [ParentId]) VALUES (N'smartphone', NULL)
INSERT [dbo].[Menus] ([slugId], [ParentId]) VALUES (N'smartwatch', NULL)
INSERT [dbo].[Menus] ([slugId], [ParentId]) VALUES (N'tablet', NULL)
INSERT [dbo].[Menus] ([slugId], [ParentId]) VALUES (N'laptop-apple-macbook', N'laptop')
INSERT [dbo].[Menus] ([slugId], [ParentId]) VALUES (N'laptop-dell', N'laptop')
INSERT [dbo].[Menus] ([slugId], [ParentId]) VALUES (N'laptop-usus', N'laptop')
INSERT [dbo].[Menus] ([slugId], [ParentId]) VALUES (N'latop-acer', N'laptop')
INSERT [dbo].[Menus] ([slugId], [ParentId]) VALUES (N'smartphone-iphone', N'smartphone')
INSERT [dbo].[Menus] ([slugId], [ParentId]) VALUES (N'smartphone-samsung', N'smartphone')
INSERT [dbo].[Menus] ([slugId], [ParentId]) VALUES (N'smartphone-xiaomi', N'smartphone')
INSERT [dbo].[Menus] ([slugId], [ParentId]) VALUES (N'smartwatch-apple', N'smartwatch')
INSERT [dbo].[Menus] ([slugId], [ParentId]) VALUES (N'tablet-ipad', N'tablet')
INSERT [dbo].[Menus] ([slugId], [ParentId]) VALUES (N'tablet-samsung', N'tablet')
GO
SET IDENTITY_INSERT [dbo].[ProductPrices] ON 

INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (1, N'338e268a-f282-4cc6-b823-0b40592bb4c1', 94690000, CAST(N'2023-11-10T14:18:31.7754855' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754866' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (2, N'53b17c22-a6de-49c3-8a15-3dc252805fa3', 34790000, CAST(N'2023-11-10T14:18:31.7754871' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754871' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (3, N'33ae145c-880a-493c-aecd-3859d66f41a7', 29990000, CAST(N'2023-11-10T14:18:31.7754872' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754873' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (4, N'86e30c06-9d56-44c4-8ddc-f209eea665df', 33290000, CAST(N'2023-11-10T14:18:31.7754873' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754874' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (5, N'1a7a8ea6-ccb4-4133-bc01-5031e0ea8de8', 26590000, CAST(N'2023-11-10T14:18:31.7754875' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754875' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (6, N'8f323332-b1c3-445b-8ac2-0a89cae35ec4', 25990000, CAST(N'2023-11-10T14:18:31.7754876' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754877' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (7, N'1f6bf39a-344a-4e1b-afa6-151b2577654a', 14990000, CAST(N'2023-11-10T14:18:31.7754878' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754878' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (8, N'959ce058-f49b-4d27-a215-acddc043ad97', 18990000, CAST(N'2023-11-10T14:18:31.7754880' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754880' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (9, N'3569044f-c6cd-403b-a5b1-34d08eca73d6', 9490000, CAST(N'2023-11-10T14:18:31.7754881' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754881' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (10, N'94ec5dcd-4bd1-428b-ae29-63fd6d3fed02', 14990000, CAST(N'2023-11-10T14:18:31.7754882' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754883' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (11, N'0b393809-33a5-4ed9-80dd-a9b610a8d3be', 15690000, CAST(N'2023-11-10T14:18:31.7754884' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754884' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (12, N'6699213e-ecb0-441c-8d08-1d97f0122f27', 14390000, CAST(N'2023-11-10T14:18:31.7754885' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754886' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (13, N'4d5125c7-82ea-43ad-9ca1-c631a68300c0', 18590000, CAST(N'2023-11-10T14:18:31.7754887' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754887' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (14, N'35b74922-f5ca-4f8c-901b-77be1f6b0079', 27990000, CAST(N'2023-11-10T14:18:31.7754888' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754889' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (15, N'31683266-0a17-4e17-b060-75be71acb1e8', 28690000, CAST(N'2023-11-10T14:18:31.7754890' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754890' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (16, N'8d90f72a-acf6-42a7-b75c-2ec1e5b41f7f', 24890000, CAST(N'2023-11-10T14:18:31.7754891' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754892' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (17, N'14fbcdc9-0efb-4d67-b435-37b099497949', 30290000, CAST(N'2023-11-10T14:18:31.7754893' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754894' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (18, N'1cbc4229-9501-4426-a3e1-523c3be1aaa5', 39490000, CAST(N'2023-11-10T14:18:31.7754895' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754896' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (19, N'34b1b9ec-8986-49b0-b2e3-56d5cb797b45', 15990000, CAST(N'2023-11-10T14:18:31.7754897' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754897' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (20, N'53ef75d3-a2b9-4154-8694-2885b926f257', 29190000, CAST(N'2023-11-10T14:18:31.7754898' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754898' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (21, N'5af43061-9c5e-4d1a-b8f4-a801f71a6419', 25190000, CAST(N'2023-11-10T14:18:31.7754899' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754900' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (22, N'ded6f0a0-a430-45d9-9f70-f238692804b2', 18790000, CAST(N'2023-11-10T14:18:31.7754901' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754901' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (23, N'1bc2effd-7841-4eb2-8630-20e5d5f02bcc', 2990000, CAST(N'2023-11-10T14:18:31.7754902' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754903' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (24, N'4da9a5c8-783b-475e-99ed-cd78314af7fa', 2490000, CAST(N'2023-11-10T14:18:31.7754904' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754904' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (25, N'6497c128-2315-4c15-9f40-e8a382087480', 19990000, CAST(N'2023-11-10T14:18:31.7754905' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754905' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (26, N'a90bc83a-958b-44c7-ab48-fe9744d581b5', 9390000, CAST(N'2023-11-10T14:18:31.7754906' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754907' AS DateTime2))
INSERT [dbo].[ProductPrices] ([Id], [ProductId], [Price], [FromDate], [ToDate]) VALUES (27, N'b022ad18-3f5a-494d-8d41-b6775f9eb961', 21490000, CAST(N'2023-11-10T14:18:31.7754909' AS DateTime2), CAST(N'2023-11-20T14:18:31.7754909' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ProductPrices] OFF
GO
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'8f323332-b1c3-445b-8ac2-0a89cae35ec4', N'Laptop ACER Nitro 16 Phoenix AN16-41-R5M4 (Ryzen 5 7535HS/RAM 8GB/RTX 4050/512GB SSD/ Windows 11)', 0, N'Are you a professional gamer, always want to have the best gaming experience? Are you also a person with a lot of work and study, need a versatile and efficient laptop? Are you also a lover of beauty and fashion, want a laptop with impressive design and convenience? If you have all the above requirements, then you cannot ignore ACER NITRO 16 PHOENIX Gaming Laptop - ACER''s national gaming laptop, introduced by Phong Vu at a reasonable price. ACER NITRO 16 PHOENIX Gaming Laptop will satisfy you with the features below, let''s find out in the article below!', 29990000, N'https://lh3.googleusercontent.com/OzQVKRXMUlErjxiwqtLwpWvOWUbmuLay-lL_o80bXTheu_tfX-j07L8fuGtCgddQTrvaF_hbjKwxMlU7IxMgE_6oTkrW06Gs=w1000-rw', N'14xHS-BcOOmhjY013toMSWulGWKadT_0N', N'Unit', 100, N'3f8d98cb-a695-4334-bec2-09008670c39a', N'fc6fcd3e-f156-4a33-a257-c92adfba2c63')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'338e268a-f282-4cc6-b823-0b40592bb4c1', N'Macbook Pro 16 M2 MAX 12C CPU 38C GPU 64GB 1TB SSD (SILVER)', 0, N'MacBook The 13.6-inch Air M2 Z15S00092 belongs to Apple''s high-end laptop line with Apple M2 CPU that delivers durable performance at incredible speed. Besides, MacBook Air possesses a luxurious appearance and youthful color gamut to help suit many needs of today''s Apple fans.', 100190000, N'https://lh3.googleusercontent.com/cPyVxwDbLfShad22xfK-dd2nlFWqTCSDMHXH7LffhPy37iGunzUM9VUtZCSiEgzzgPGcW3ZkGbImyjcVkf1RrjFr_plC_BjA=w500-rw', N'14copW3YiYA9OZtplLedaDhsV4LRN2eEz', N'Unit', 100, N'3f8d98cb-a695-4334-bec2-09008670c39a', N'36326612-2d44-446f-87cd-d060d14237a6')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'1f6bf39a-344a-4e1b-afa6-151b2577654a', N'Laptop ACER Aspire 5 A514-55-5954 (NX.K5BSV.001) (i5-1235U/RAM 8GB/512GB SSD/ Windows 11)', 0, N'Laptop Acer Aspire 5 A514-55-5954 NX. K5BSV.001 is one of the top choices for students as well as office workers. With a minimalist but still extremely sophisticated design along with powerful performance thanks to the Intel Core i5 CPU will be a great assistant for you in work, study as well as entertainment', 19990000, N'https://lh3.googleusercontent.com/dF2OlQH_sxhOSNEUvCpUhODxCVoNqtrPHIDtosatk9iKmkmc_k6uq_5salWjPEob-5U1urzlFmTtqpByX7kvmdn0cKFB43Ps=w500-rw', N'1U7gBEhG9szCsxXY95gzGO-mDX5M21Ric', N'Unit', 100, N'3f8d98cb-a695-4334-bec2-09008670c39a', N'fc6fcd3e-f156-4a33-a257-c92adfba2c63')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'9cd800e5-3457-4602-9083-1d7fee04e240', N'Macbook Pro 13 M2 8C CPU 10C GPU 24GB 512GB SSD (SILVER)', 0, N'Updating', 49590000, N'https://lh3.googleusercontent.com/sPJkn-BIybufvMuXd1Ut6UkSWqz1UG76-WdZ3JcZ0GS1mNvYlY3_tUAGjzD_TkbC-k3HV_3bgGsmcoB56sbIVCLzcVmul6E=w1000-rw', N'10TOIotAbfwDK0MQmc1QyELyxy8oScukl', N'Unit', 100, N'3f8d98cb-a695-4334-bec2-09008670c39a', N'36326612-2d44-446f-87cd-d060d14237a6')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'6699213e-ecb0-441c-8d08-1d97f0122f27', N'Laptop Dell Inspiron 15 3520 (3520-71003264) (i3-1215U/RAM 8GB/512GB SSD/ Windows 11 + Office)', 0, N'The Dell Inspiron 15 3520 3520-71003264 i3-1215U Carbon Black is the perfect office laptop. The device is equipped with Intel Core i3 Alder Lake - 1215U chip, integrated Intel UHD Graphics card. Not too powerful but enough to meet your daily study and work needs', 15990000, N'https://lh3.googleusercontent.com/nOikqpVL4HXGK3Hs6wKff1Wnl-U7aYbpvw6lu83FHjfGNVGMdF6OyoVLq_pErwB-MmmfDmN7VKIEaQ6Fc9T7k6hKYoXafeYhYg=w500-rw', N'1yobT5QGolFBw6r3dGOBKtutHG0eizgfy', N'Unit', 100, N'3f8d98cb-a695-4334-bec2-09008670c39a', N'04d63fc1-582a-4ad3-9132-b531101220ca')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'1bc2effd-7841-4eb2-8630-20e5d5f02bcc', N'Samsung Galaxy A05 (4+128) (Black) (SM-A055FZKGXXV)', 0, N'Updating', 3090000, N'https://lh3.googleusercontent.com/knEb077WDBllxLpzXhn_3HIAoR-l7TvZzCd2fsUL7P1dOeN5W6WDNQVDBn3xpHIir8jYE37c9s0ZI47I-rtni2dm2SB5xe8shg=w500-rw', N'10Z1Q2lr51ycdqF6fejHz_WgoaX7qDpYl', N'Unit', 100, N'bc17dda5-9e53-434d-ab30-32452bfc7d35', N'2ef43281-9c42-466e-ad66-483ff6f46326')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'53ef75d3-a2b9-4154-8694-2885b926f257', N'iPhone 14 Pro Max | Genuine VNA', 0, N'iPhone 14 Pro Max launched in September 2022 has made a prominent mark on the smart mobile market worldwide by an impressive makeover of the "Dynamic Island" screen design. iPhone 14 pro series is favored by Apple when equipped with a powerful A16 Bionic chip with outstanding processing performance, helping you perform many tasks on the device at the same time without jerking or lag', 36990000, N'https://lh3.googleusercontent.com/Y1OVqtPmmjFd3lzbR0onqBQLgUtNkiX2T4zCffguTiZoMs73EJ9naybVgmrRat4i6bqWSC6oMQYvkWZlKxWlddEY3EzNvIj6=w500-rw', N'10CQlOpmK0_9G6lBaJnvZ5TvXnecJOFgR', N'Unit', 100, N'bc17dda5-9e53-434d-ab30-32452bfc7d35', N'36326612-2d44-446f-87cd-d060d14237a6')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'8d90f72a-acf6-42a7-b75c-2ec1e5b41f7f', N'Laptop Dell Vostro 3430 (i7-1355U/RAM 16GB/512GB SSD/ Windows 11 + Office)', 0, N'Updating', 26690000, N'https://lh3.googleusercontent.com/QQEbvWwDKVxZedtS1EFexrYOZa6RqhW1J7mFYZU_IiMjbwV5fWHQWXvCxwwdv5hWK-GMOgthkMOslRRCAIUSA5p-HyCLbLE=w500-rw', N'134Zgrr4qGMDGTvc5iv-ajH2cELOW9GsK', N'Unit', 100, N'3f8d98cb-a695-4334-bec2-09008670c39a', N'04d63fc1-582a-4ad3-9132-b531101220ca')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'3569044f-c6cd-403b-a5b1-34d08eca73d6', N'Laptop ASUS Vivobook X515EA-EJ3633W (i3-1115G4/RAM 8GB/512GB SSD/ Windows 11)', 0, N'ASUS Vivobook X515EA-EJ3633W laptop (i3-1115G4) is equipped with Intel Core i3 CPU, 8GB Onboard DDR4 RAM capacity along with 512GB SSD hard drive for you to freely store study data, basic work with office tasks. Anti-glare screens help protect your eyes well from harmful blue light', 11290000, N'https://lh3.googleusercontent.com/kkZs0JLWxfJpJg1dMiuzMDNayo_HpxHAaCQzVHE_ecuXjXD3vvZTGynpe4S2Ou5Y0FR-HVCIh4UU_o11huEYAm104zukaYlk=w500-rw', N'1lge0An1ZzjQlD3oV-cjenDJ9M4WJzTL7', N'Unit', 100, N'3f8d98cb-a695-4334-bec2-09008670c39a', N'71d6e1f9-8c22-43e8-ad37-1609dd7bc61e')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'44a98b53-9fac-4cbd-a7d2-35cf17ccbf71', N'iPhone 13 mini 128GB (pink) (3J765VN/A) (DEMO) (PINK) - Exhibits', 0, N'Updating', 17490000, N'https://lh3.googleusercontent.com/rT4c6CfzG8osJnzcpD4kDpdmInxJZ3y_qKBaR5OiMKNUWvV3KDVCh5Ke4vm6D2tmQYluG4_gVDR5wHKgob2lKasef-ODOmWh=w500-rw', N'1FGeL7rFIhopiQKRmN4N47myHzxBOSmOB', N'Unit', 100, N'bc17dda5-9e53-434d-ab30-32452bfc7d35', N'36326612-2d44-446f-87cd-d060d14237a6')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'14fbcdc9-0efb-4d67-b435-37b099497949', N'Laptop Dell Inspiron 14 5430 (i7-1360P/RAM 16GB/1TB SSD/ Windows 11 + Office)', 0, N'Updating', 31490000, N'https://lh3.googleusercontent.com/JzaLDtRkM112HJ0nqZ1SiIVOxSimMwOgmCx00Bbat3LXC7H-cCja3vJJg4Ac70UHfE2TVGCMp6loAqLMUT8VD0WSvxCqphM=w500-rw', N'1sxNQzMjOHSJ7fTAIWGWdVkx1YkuAxdbw', N'Unit', 100, N'3f8d98cb-a695-4334-bec2-09008670c39a', N'04d63fc1-582a-4ad3-9132-b531101220ca')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'33ae145c-880a-493c-aecd-3859d66f41a7', N'MacBook Air 2020 13.3 inch MGNE3SA/A (M1/8GB/SSD512GB)', 0, N'MacBook Air 2020 13.3" MGNE3SA/A belongs to a high-end laptop product line from the Apple brand that possesses outstanding performance thanks to being equipped with a genuine proprietary processor. With an elegant design and outstanding powerful configuration, MacBook Air 2020 13.3" MGNE3SA/A promises to bring you an enjoyable experience', 34990000, N'https://lh3.googleusercontent.com/lc6DzDy1TKN_guYmItGOG1DIWMp3iACXwfMJL4ZdlW501Sqm4j86XGaQDD_mrGiT8OoxFGj7FQGrc5DTR8MSZjrwV0ezEds=w1000-rw', N'15zxKTkBDtJT9sr9bKwkfAQGZHnM6LjRz', N'Unit', 100, N'3f8d98cb-a695-4334-bec2-09008670c39a', N'36326612-2d44-446f-87cd-d060d14237a6')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'53b17c22-a6de-49c3-8a15-3dc252805fa3', N'MacBook Air 15 M2 8C CPU 10C GPU 8GB 512GB SSD(Midnight)', 0, N'Updating', 39990000, N'https://lh3.googleusercontent.com/lZLaRombXnbrg99vFtGOTiH4zUpkt3PhblRRTZWyqt7DUc-ztoRC6kT2VuuFD9-XJsPYf-8DVJNz1lRCs406a5NWdTROd1I=w1000-rw', N'1SqDtpkZFWiXmnAoeGKMJB0JRg_jZy63g', N'Unit', 100, N'3f8d98cb-a695-4334-bec2-09008670c39a', N'36326612-2d44-446f-87cd-d060d14237a6')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'1a7a8ea6-ccb4-4133-bc01-5031e0ea8de8', N'MacBook Air 2022 13.6 inch MLY33SA/A (M2/ 8GB/ SSD 256GB)', 0, N'Updating', 31900000, N'https://lh3.googleusercontent.com/T4dQPx6nSJi3y147mwJH6kDJsxM6ULAAtIoZjgDDIi3yF5YpFYW7QbWh_nfT0Lhi2LxIDFuNPMamXlrBW-EcZ1NUGYBZ6VqbLw=w500-rw', N'1oRNlAF2LJEdMnyJsNbCGtirUa0GxSEYC', N'Unit', 100, N'3f8d98cb-a695-4334-bec2-09008670c39a', N'36326612-2d44-446f-87cd-d060d14237a6')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'1cbc4229-9501-4426-a3e1-523c3be1aaa5', N'iPhone 15 Pro Max - Genuine VNA', 0, N'iPhone 15 Pro Max belongs to the high-end product line that has just been launched by Apple on the market in 2023, retaining the outstanding design "Dynamic Island" along with a series of luxurious colors. The iPhone 15 Pro max is equipped with a new A17 Bionic chip with outstanding and powerful processing performance today to perform the tasks you want', 43990000, N'https://lh3.googleusercontent.com/8w4MFwwKtq8dboBtb_bJLWcYgZge4G4G3kVv2tF8yKEQfUeu0xihFhvC2IGiZaQrnSfoZDU_Qcbk938-uolUGIX396P_qlQ=w500-rw', N'1Ifg5rJYBvzJtFdk6ZfqM_cUbJvf6k6Mj', N'Unit', 100, N'bc17dda5-9e53-434d-ab30-32452bfc7d35', N'36326612-2d44-446f-87cd-d060d14237a6')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'34b1b9ec-8986-49b0-b2e3-56d5cb797b45', N'iPhone 13 128GB Pink mobile phone (MLPH3VN/A)', 0, N'The set of 4 versions of iPhone 12 is still attractive and has not cooled, but Apple brings users a new super product iPhone 13 with many interesting improvements that promise to bring the most attractive experience to users', 24990000, N'https://lh3.googleusercontent.com/NA85MErOuDh4WfEGmnTIDG6O-SMoCvMve2sGMqKpBJ-CrGCRcdv7Ouo5HpRr-ZrnIbah9GEWcZA_hO7BRmu4wHw0UktOkZgo=w500-rw', N'1q9K2oaCGMyerUkMlELsDRoBZrfGXmhNa', N'Unit', 100, N'bc17dda5-9e53-434d-ab30-32452bfc7d35', N'36326612-2d44-446f-87cd-d060d14237a6')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'94ec5dcd-4bd1-428b-ae29-63fd6d3fed02', N'Laptop ASUS Vivobook 15 X1504VA-NJ025W (i5-1335U/RAM 8GB/512GB SSD/ Windows 11)', 0, N'Updating', 17990000, N'https://lh3.googleusercontent.com/_w0us6FSWOX-V9byAkNIbBL2BDR0CH7_pQODsmFKEP2PcEHM4O8EfHSy2LpBx35SX5SWgQFNEJ0aW1kPp-_aujK9mhL2_AjBHg=w1000-rw', N'1iEEPx1N9MkI7LBBP_hBwODMvZ6sih4mX', N'Unit', 100, N'3f8d98cb-a695-4334-bec2-09008670c39a', N'71d6e1f9-8c22-43e8-ad37-1609dd7bc61e')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'31683266-0a17-4e17-b060-75be71acb1e8', N'Laptop Dell Inspiron 16 5630 - i7P165W11SL2050 (i7-1360P/RAM 16GB/512GB SSD/ Windows 11 + Office)', 0, N'Updating', 30990000, N'https://lh3.googleusercontent.com/kC9I2-5m1WbJlbXYStTMIuVcLNj1Qex_Bae7GQ1iqEwBzj1GhQSUCy2IJXxL0qinWDyWFlO80JZcYVN1YXLEPnhmsW70t639ww=w500-rw', N'1VCX_PE9G4DIU16blKhPiCdhWPWC6mvR8', N'Unit', 100, N'3f8d98cb-a695-4334-bec2-09008670c39a', N'04d63fc1-582a-4ad3-9132-b531101220ca')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'35b74922-f5ca-4f8c-901b-77be1f6b0079', N'Laptop Dell Inspiron 14 5430 - i5P165W11SL2050 (i5-1340P/RAM 16GB/512GB SSD/ Windows 11 + Office)', 0, N'Updating', 29790000, N'https://lh3.googleusercontent.com/wFM2g6YQMMVWACV2sVKL6ouSZpVFWeIcwvWZ9f1mjyDBOzPNghhib2EPJBLrRUcbrDbC52fSzGwRp8sCLbpvoYHkbE3nsg0=w500-rw', N'1Wxkpz8DL6OAuA-iE2Y8QfINzWwMdcYN7', N'Unit', 100, N'3f8d98cb-a695-4334-bec2-09008670c39a', N'04d63fc1-582a-4ad3-9132-b531101220ca')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'5af43061-9c5e-4d1a-b8f4-a801f71a6419', N'iPhone 15 Plus - Genuine VNA', 0, N'In the iPhone 15 series collection launched in 2023, iPhone 15 Plus in particular and other iPhone 15 versions in general are highly appreciated to have a leap in new design, outstanding features are improved compared to the iPhone 14 series in 2022, bringing a completely new experience for iPhone enthusiasts. Join Phong Vu to learn about iPhone 15 Plus through this article!', 27990000, N'https://lh3.googleusercontent.com/_eACMH4Tyg60SnkYcrMPgscrJ1P6PB8I_hmIUdWjDouY-hSJ44lNjiD2BDE6XMQ_ZUoIUvU9C4zlJCfBOwv5AC-eA6eQC1g=w500-rw', N'1PeJEiAIBag3DupEC0hZOI4BRKqtuoTI5', N'Unit', 100, N'bc17dda5-9e53-434d-ab30-32452bfc7d35', N'36326612-2d44-446f-87cd-d060d14237a6')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'0b393809-33a5-4ed9-80dd-a9b610a8d3be', N'Laptop ASUS Vivobook 16 M1605YA-MB303W (Ryzen 7 7730U/RAM 16GB/512GB SSD/ Windows 11)', 0, N'Updating', 18490000, N'https://lh3.googleusercontent.com/GBCMEXu9-VgSeUAO8fW-XlSD-9GGd5YYwOkH8yi3cQOn0rRXFvNbIkDhoQbcr0iI3aeO6PDS4hHS2ZbQDhA8Rwedz5u1VOnS=w1000-rw', N'1kX3Ic2DGpw7jR46-iNGWgpDlHGHNt40o', N'Unit', 100, N'3f8d98cb-a695-4334-bec2-09008670c39a', N'71d6e1f9-8c22-43e8-ad37-1609dd7bc61e')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'959ce058-f49b-4d27-a215-acddc043ad97', N'Laptop ACER Nitro 5 Eagle AN515-57-54MV (i5-11400H/RAM 8GB/RTX 3050/512GB SSD/ Windows 11)', 0, N'As a gaming laptop line of the Acer brand, the Acer Nitro 5 Eagle AN515-57-54MV laptop is equipped with a powerful i5 chip, NVIDIA GeForce RTX 3050 graphics card, 8Gb ram and large capacity. Combined with its beautiful and powerful design, this will be the choice for young gamers and people doing graphics-related work', 25990000, N'https://lh3.googleusercontent.com/c7VuA4P8sHHJCilfzRVp50AQmgZEkJOyOCuh4vvkcT9jxfqTzZVd2gepUFSSqzXVSEljnYlAN319sJD-H1IztNcxPT3UypA=w500-rw', N'1p7PobtADVoyyLZnOokk2ltDiFCAsdyfL', N'Unit', 100, N'3f8d98cb-a695-4334-bec2-09008670c39a', N'fc6fcd3e-f156-4a33-a257-c92adfba2c63')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'b022ad18-3f5a-494d-8d41-b6775f9eb961', N'Apple Watch Ultra 2 4G 49mm (Blue Olive Alpine - M Titanium Case) (MREY3VN/A)', 0, N'Updating', 25990000, N'https://lh3.googleusercontent.com/h1DPkY2SVo3kw4e37lnqiJRd1nd5QlaNPDXxjiF8UJ4yakeTrR1wNzGO4W7qTMjSy8qQI7_2yS_B2M6975c4ceziO__U0MryBw=w500-rw', N'18B4NF_mYnJqpx41VfJLjAGBKbtQyfB4M', N'Unit', 100, N'3649b208-05c6-4129-86bd-df77801d3d39', N'36326612-2d44-446f-87cd-d060d14237a6')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'4d5125c7-82ea-43ad-9ca1-c631a68300c0', N'Laptop Dell Inspiron 3530 - N5I5791W1 (i5-1335U/RAM 16GB/512GB SSD/ Windows 11 + Office)', 0, N'Updating', 20290000, N'https://lh3.googleusercontent.com/b00d0m8txaixII_rmYYCu1W1N0yeXlgANpNPvGC6ATQLAFZWbyqtUnAMqJhTsirVuwCVMXb0FwX6JXBPRPQLtAmGujAbLNuS=w500-rw', N'1ildfLhZpElIwWRcHPfmhIe9xwWhusoTY', N'Unit', 100, N'3f8d98cb-a695-4334-bec2-09008670c39a', N'04d63fc1-582a-4ad3-9132-b531101220ca')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'4da9a5c8-783b-475e-99ed-cd78314af7fa', N'Xiaomi Redmi 12C (4GB/64GB) (Blue)', 0, N'Updating', 3590000, N'https://lh3.googleusercontent.com/wSCq7HZuqP30D8ZFZrFpi95EX_GLeN22ZymVx5_it-B8QjrqL2xdQ8q98PJix7lE0BtpOfTaPNVazU84Gv9YyADTC57OAss=w500-rw', N'19a9uKIG6FsYwGBIpdAOOeuybQIfhg_3I', N'Unit', 100, N'bc17dda5-9e53-434d-ab30-32452bfc7d35', N'32a244dc-528a-402a-b8e0-d86b31f0b8cb')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'6497c128-2315-4c15-9f40-e8a382087480', N'iPad Pro 11 inch M2 Wifi', 0, N'Updating', 23990000, N'https://lh3.googleusercontent.com/xrZTVonyBNNMAjArfukj_4B1xD8O4T_poW3j0SLYpaYVIvei3Pv2zYzefhLA65v_6_2aFfv0953cGXXVZ8UBZAu0g5CLSA=w500-rw', N'1R0gypNL_KuXDb4Hsw-TK92OB4wyBcKlN', N'Unit', 100, N'a54988d2-7eeb-4e6c-8421-6f3fa5bb91a2', N'36326612-2d44-446f-87cd-d060d14237a6')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'86e30c06-9d56-44c4-8ddc-f209eea665df', N'MacBook Air 2022 13.6 inch Z15S00092 (M2/ 16GB/ 256GB SSD)', 0, N'MacBook The 13.6-inch Air M2 Z15S00092 belongs to Apple''s high-end laptop line with Apple M2 CPU that delivers durable performance at incredible speed. Besides, MacBook Air possesses a luxurious appearance and youthful color gamut to help suit many needs of today''s Apple fans', 36890000, N'https://lh3.googleusercontent.com/u2qUk5mgupuh9ubXaQxqE2kum6Exm8DygVJFez6Ksj6Yjb6CDjwQ3Jgh7bQ3-TjNxfWxmXTUd6zkxbA2w79-9zTlYsLUp9ah=w1000-rw', N'1gzBXbbcWwhP3NKwYzlVZ10k362zzQ8WO', N'Unit', 100, N'3f8d98cb-a695-4334-bec2-09008670c39a', N'36326612-2d44-446f-87cd-d060d14237a6')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'ded6f0a0-a430-45d9-9f70-f238692804b2', N'iPhone 14 128GB', 0, N'Product descriptions will be updated as soon as possible!', 24990000, N'https://lh3.googleusercontent.com/HD6tK_lv_T2Hp6WDHzRREnZI0T-Cnx1hgDTAPuMWZBHB8di1gdeyL5KBZz34diG54BDRF0zqXQL6loA90vL4HoS0jmUYFEc=w500-rw', N'1rgiZ9htIqDMEvN_6_xUpKZQ3oXMY704V', N'Unit', 100, N'bc17dda5-9e53-434d-ab30-32452bfc7d35', N'36326612-2d44-446f-87cd-d060d14237a6')
INSERT [dbo].[Products] ([Id], [Name], [IsDeleted], [Description], [Price], [ImageUrl], [FolderId], [Unit], [Quantity], [CategoryId], [BrandId]) VALUES (N'a90bc83a-958b-44c7-ab48-fe9744d581b5', N'Samsung Galaxy Tab S7 FE LTE Tablet 4GB/64GB (Black) (SM-T735NZKAXXV)', 0, N'Updating', 13990000, N'https://lh3.googleusercontent.com/WDBs6MVNz4hnSM3L1ukUN98WmnDm7Ag_s_AhLNYVWuvg0lYprSCTmtj8UDNCHu621AvU1eUMwlEylid-_JamBDp1Xdo33W0b=w500-rw', N'1HVLMIm5HTuj-anZwQGeewsD4XpeioTLx', N'Unit', 100, N'a54988d2-7eeb-4e6c-8421-6f3fa5bb91a2', N'2ef43281-9c42-466e-ad66-483ff6f46326')
GO
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'black-friday', N'8f323332-b1c3-445b-8ac2-0a89cae35ec4')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop', N'8f323332-b1c3-445b-8ac2-0a89cae35ec4')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'latop-acer', N'8f323332-b1c3-445b-8ac2-0a89cae35ec4')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'sale-laptop', N'8f323332-b1c3-445b-8ac2-0a89cae35ec4')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop', N'338e268a-f282-4cc6-b823-0b40592bb4c1')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop-apple-macbook', N'338e268a-f282-4cc6-b823-0b40592bb4c1')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'best-sale', N'1f6bf39a-344a-4e1b-afa6-151b2577654a')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop', N'1f6bf39a-344a-4e1b-afa6-151b2577654a')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'latop-acer', N'1f6bf39a-344a-4e1b-afa6-151b2577654a')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'sale-laptop', N'1f6bf39a-344a-4e1b-afa6-151b2577654a')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop', N'9cd800e5-3457-4602-9083-1d7fee04e240')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop-apple-macbook', N'9cd800e5-3457-4602-9083-1d7fee04e240')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop', N'6699213e-ecb0-441c-8d08-1d97f0122f27')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop-dell', N'6699213e-ecb0-441c-8d08-1d97f0122f27')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'sale-laptop', N'6699213e-ecb0-441c-8d08-1d97f0122f27')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'smartphone', N'1bc2effd-7841-4eb2-8630-20e5d5f02bcc')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'smartphone-samsung', N'1bc2effd-7841-4eb2-8630-20e5d5f02bcc')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'smartphone', N'53ef75d3-a2b9-4154-8694-2885b926f257')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'smartphone-iphone', N'53ef75d3-a2b9-4154-8694-2885b926f257')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'best-sale', N'8d90f72a-acf6-42a7-b75c-2ec1e5b41f7f')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop', N'8d90f72a-acf6-42a7-b75c-2ec1e5b41f7f')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop-dell', N'8d90f72a-acf6-42a7-b75c-2ec1e5b41f7f')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop', N'3569044f-c6cd-403b-a5b1-34d08eca73d6')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop-usus', N'3569044f-c6cd-403b-a5b1-34d08eca73d6')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'sale-laptop', N'3569044f-c6cd-403b-a5b1-34d08eca73d6')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'smartphone', N'44a98b53-9fac-4cbd-a7d2-35cf17ccbf71')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'smartphone-iphone', N'44a98b53-9fac-4cbd-a7d2-35cf17ccbf71')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'black-friday', N'14fbcdc9-0efb-4d67-b435-37b099497949')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop', N'14fbcdc9-0efb-4d67-b435-37b099497949')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop-dell', N'14fbcdc9-0efb-4d67-b435-37b099497949')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'sale-laptop', N'14fbcdc9-0efb-4d67-b435-37b099497949')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'best-sale', N'33ae145c-880a-493c-aecd-3859d66f41a7')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop', N'33ae145c-880a-493c-aecd-3859d66f41a7')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop-apple-macbook', N'33ae145c-880a-493c-aecd-3859d66f41a7')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'best-sale', N'53b17c22-a6de-49c3-8a15-3dc252805fa3')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop', N'53b17c22-a6de-49c3-8a15-3dc252805fa3')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop-apple-macbook', N'53b17c22-a6de-49c3-8a15-3dc252805fa3')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'best-sale', N'1a7a8ea6-ccb4-4133-bc01-5031e0ea8de8')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop', N'1a7a8ea6-ccb4-4133-bc01-5031e0ea8de8')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop-apple-macbook', N'1a7a8ea6-ccb4-4133-bc01-5031e0ea8de8')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'black-friday', N'1cbc4229-9501-4426-a3e1-523c3be1aaa5')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'smartphone', N'1cbc4229-9501-4426-a3e1-523c3be1aaa5')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'smartphone-iphone', N'1cbc4229-9501-4426-a3e1-523c3be1aaa5')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'smartphone', N'34b1b9ec-8986-49b0-b2e3-56d5cb797b45')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'smartphone-iphone', N'34b1b9ec-8986-49b0-b2e3-56d5cb797b45')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop', N'94ec5dcd-4bd1-428b-ae29-63fd6d3fed02')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop-usus', N'94ec5dcd-4bd1-428b-ae29-63fd6d3fed02')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop', N'31683266-0a17-4e17-b060-75be71acb1e8')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop-dell', N'31683266-0a17-4e17-b060-75be71acb1e8')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'sale-laptop', N'31683266-0a17-4e17-b060-75be71acb1e8')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop', N'35b74922-f5ca-4f8c-901b-77be1f6b0079')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop-dell', N'35b74922-f5ca-4f8c-901b-77be1f6b0079')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'sale-laptop', N'35b74922-f5ca-4f8c-901b-77be1f6b0079')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'smartphone', N'5af43061-9c5e-4d1a-b8f4-a801f71a6419')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'smartphone-iphone', N'5af43061-9c5e-4d1a-b8f4-a801f71a6419')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'black-friday', N'0b393809-33a5-4ed9-80dd-a9b610a8d3be')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop', N'0b393809-33a5-4ed9-80dd-a9b610a8d3be')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop-usus', N'0b393809-33a5-4ed9-80dd-a9b610a8d3be')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'best-sale', N'959ce058-f49b-4d27-a215-acddc043ad97')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop', N'959ce058-f49b-4d27-a215-acddc043ad97')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'latop-acer', N'959ce058-f49b-4d27-a215-acddc043ad97')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'black-friday', N'b022ad18-3f5a-494d-8d41-b6775f9eb961')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'smartwatch', N'b022ad18-3f5a-494d-8d41-b6775f9eb961')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'smartwatch-apple', N'b022ad18-3f5a-494d-8d41-b6775f9eb961')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop', N'4d5125c7-82ea-43ad-9ca1-c631a68300c0')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop-dell', N'4d5125c7-82ea-43ad-9ca1-c631a68300c0')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'sale-laptop', N'4d5125c7-82ea-43ad-9ca1-c631a68300c0')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'smartphone', N'4da9a5c8-783b-475e-99ed-cd78314af7fa')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'smartphone-xiaomi', N'4da9a5c8-783b-475e-99ed-cd78314af7fa')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'best-sale', N'6497c128-2315-4c15-9f40-e8a382087480')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'tablet', N'6497c128-2315-4c15-9f40-e8a382087480')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'tablet-ipad', N'6497c128-2315-4c15-9f40-e8a382087480')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop', N'86e30c06-9d56-44c4-8ddc-f209eea665df')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'laptop-apple-macbook', N'86e30c06-9d56-44c4-8ddc-f209eea665df')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'smartphone', N'ded6f0a0-a430-45d9-9f70-f238692804b2')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'smartphone-iphone', N'ded6f0a0-a430-45d9-9f70-f238692804b2')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'best-sale', N'a90bc83a-958b-44c7-ab48-fe9744d581b5')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'black-friday', N'a90bc83a-958b-44c7-ab48-fe9744d581b5')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'tablet', N'a90bc83a-958b-44c7-ab48-fe9744d581b5')
INSERT [dbo].[SlugProducts] ([SlugId], [ProductId]) VALUES (N'tablet-samsung', N'a90bc83a-958b-44c7-ab48-fe9744d581b5')
GO
INSERT [dbo].[Slugs] ([Id], [Title], [Image], [IsDeleted], [IsSilder], [MenuId]) VALUES (N'best-sale', N'Sale up to 50%', N'https://cdn.tgdd.vn/mwgcart/mwgcore/ContentMwg/images/homev2/fs-0611-1211-theme/desk/tgdd/banner-title.gif', 0, 1, NULL)
INSERT [dbo].[Slugs] ([Id], [Title], [Image], [IsDeleted], [IsSilder], [MenuId]) VALUES (N'black-friday', N'Black Friday', N'https://ben.com.vn/tin-tuc/wp-content/uploads/2021/10/black-friday-la-ngay-bao-nhieu-750x536.jpg', 0, 1, NULL)
INSERT [dbo].[Slugs] ([Id], [Title], [Image], [IsDeleted], [IsSilder], [MenuId]) VALUES (N'laptop', N'Laptop', N'https://lh3.googleusercontent.com/lFZZtBMUqkbl9qKKUe3DSmHqpb62UjWrOkxqcJ6lN3yM83Wg2Irp-ZlvkUwGO6TMcsscLELMZa_lN9jo8tKteWsCzmUii7po=rw', 0, 0, N'laptop')
INSERT [dbo].[Slugs] ([Id], [Title], [Image], [IsDeleted], [IsSilder], [MenuId]) VALUES (N'laptop-apple-macbook', N'Apple (Macbook)', NULL, 0, 0, N'laptop-apple-macbook')
INSERT [dbo].[Slugs] ([Id], [Title], [Image], [IsDeleted], [IsSilder], [MenuId]) VALUES (N'laptop-dell', N'Dell', NULL, 0, 0, N'laptop-dell')
INSERT [dbo].[Slugs] ([Id], [Title], [Image], [IsDeleted], [IsSilder], [MenuId]) VALUES (N'laptop-usus', N'ASUS', NULL, 0, 0, N'laptop-usus')
INSERT [dbo].[Slugs] ([Id], [Title], [Image], [IsDeleted], [IsSilder], [MenuId]) VALUES (N'latop-acer', N'Acer', NULL, 0, 0, N'latop-acer')
INSERT [dbo].[Slugs] ([Id], [Title], [Image], [IsDeleted], [IsSilder], [MenuId]) VALUES (N'sale-laptop', N'Laptop gaming sale up to 40%', N'https://static.vecteezy.com/system/resources/thumbnails/006/241/067/small/abstract-polygon-3d-triangle-yellow-geometric-background-free-photo.jpg', 0, 1, NULL)
INSERT [dbo].[Slugs] ([Id], [Title], [Image], [IsDeleted], [IsSilder], [MenuId]) VALUES (N'smartphone', N'Smartphone', N'https://lh3.googleusercontent.com/qtC62XnXkTsyJbMok7Z7Uu5GOPvhqslzU5YscZZ0HvorTWRs0Qg5s8gWU6l6CTcmc-pQA2y1myJCZ92t9VDq=rw', 0, 0, N'smartphone')
INSERT [dbo].[Slugs] ([Id], [Title], [Image], [IsDeleted], [IsSilder], [MenuId]) VALUES (N'smartphone-iphone', N'Iphone', NULL, 0, 0, N'smartphone-iphone')
INSERT [dbo].[Slugs] ([Id], [Title], [Image], [IsDeleted], [IsSilder], [MenuId]) VALUES (N'smartphone-samsung', N'Samsung', NULL, 0, 0, N'smartphone-samsung')
INSERT [dbo].[Slugs] ([Id], [Title], [Image], [IsDeleted], [IsSilder], [MenuId]) VALUES (N'smartphone-xiaomi', N'Xiaomi', NULL, 0, 0, N'smartphone-xiaomi')
INSERT [dbo].[Slugs] ([Id], [Title], [Image], [IsDeleted], [IsSilder], [MenuId]) VALUES (N'smartwatch', N'Smartwatch', N'https://th.bing.com/th/id/R.2650cb6112fbd5590eb781022a3c148e?rik=ZlMWy8mm%2fzwGTg&pid=ImgRaw&r=0', 0, 0, N'smartwatch')
INSERT [dbo].[Slugs] ([Id], [Title], [Image], [IsDeleted], [IsSilder], [MenuId]) VALUES (N'smartwatch-apple', N'Apple', NULL, 0, 0, N'smartwatch-apple')
INSERT [dbo].[Slugs] ([Id], [Title], [Image], [IsDeleted], [IsSilder], [MenuId]) VALUES (N'tablet', N'Tablet', N'https://lh3.googleusercontent.com/dkzFFaKYmPLLkPnC-cyefC1u1Qh0Iy_6Loz7adsbIMs-KAK8FA_PwUOklM3gEppESc1uSeaTa63U4Vejifo=rw', 0, 0, N'tablet')
INSERT [dbo].[Slugs] ([Id], [Title], [Image], [IsDeleted], [IsSilder], [MenuId]) VALUES (N'tablet-ipad', N'Apple (iPad)', NULL, 0, 0, N'tablet-ipad')
INSERT [dbo].[Slugs] ([Id], [Title], [Image], [IsDeleted], [IsSilder], [MenuId]) VALUES (N'tablet-samsung', N'Samsung', NULL, 0, 0, N'tablet-samsung')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Addresses_CustomerId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_Addresses_CustomerId] ON [dbo].[Addresses]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AttributeGroups_CategoryId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_AttributeGroups_CategoryId] ON [dbo].[AttributeGroups]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AttributeOptions_AttributeId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_AttributeOptions_AttributeId] ON [dbo].[AttributeOptions]
(
	[AttributeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AttributeSpecs_AttributeId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_AttributeSpecs_AttributeId] ON [dbo].[AttributeSpecs]
(
	[AttributeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AttributeSpecs_OptionID_AttributeId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_AttributeSpecs_OptionID_AttributeId] ON [dbo].[AttributeSpecs]
(
	[OptionID] ASC,
	[AttributeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CartItems_ProductId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_CartItems_ProductId] ON [dbo].[CartItems]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Documents_ProductId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_Documents_ProductId] ON [dbo].[Documents]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_HistoryStatuses_OrderId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_HistoryStatuses_OrderId] ON [dbo].[HistoryStatuses]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Menus_ParentId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_Menus_ParentId] ON [dbo].[Menus]
(
	[ParentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderDetails_ProductId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_OrderDetails_ProductId] ON [dbo].[OrderDetails]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_AddressId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_AddressId] ON [dbo].[Orders]
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Orders_CustomerId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_CustomerId] ON [dbo].[Orders]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductPrices_ProductId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_ProductPrices_ProductId] ON [dbo].[ProductPrices]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_BrandId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_Products_BrandId] ON [dbo].[Products]
(
	[BrandId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_CategoryId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId] ON [dbo].[Products]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Reviews_OrderId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_Reviews_OrderId] ON [dbo].[Reviews]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Reviews_ProductId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_Reviews_ProductId] ON [dbo].[Reviews]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SlugProducts_ProductId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE NONCLUSTERED INDEX [IX_SlugProducts_ProductId] ON [dbo].[SlugProducts]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Slugs_MenuId]    Script Date: 11/10/2023 2:26:41 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Slugs_MenuId] ON [dbo].[Slugs]
(
	[MenuId] ASC
)
WHERE ([MenuId] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Views_ProductId]    Script Date: 11/10/2023 2:26:41 PM ******/
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
ALTER TABLE [dbo].[AttributeGroups]  WITH CHECK ADD  CONSTRAINT [FK_AttributeGroups_Attributes_AttributeId] FOREIGN KEY([AttributeId])
REFERENCES [dbo].[Attributes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AttributeGroups] CHECK CONSTRAINT [FK_AttributeGroups_Attributes_AttributeId]
GO
ALTER TABLE [dbo].[AttributeGroups]  WITH CHECK ADD  CONSTRAINT [FK_AttributeGroups_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AttributeGroups] CHECK CONSTRAINT [FK_AttributeGroups_Categories_CategoryId]
GO
ALTER TABLE [dbo].[AttributeOptions]  WITH CHECK ADD  CONSTRAINT [FK_AttributeOptions_Attributes_AttributeId] FOREIGN KEY([AttributeId])
REFERENCES [dbo].[Attributes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AttributeOptions] CHECK CONSTRAINT [FK_AttributeOptions_Attributes_AttributeId]
GO
ALTER TABLE [dbo].[AttributeSpecs]  WITH CHECK ADD  CONSTRAINT [FK_AttributeSpecs_AttributeOptions_OptionID_AttributeId] FOREIGN KEY([OptionID], [AttributeId])
REFERENCES [dbo].[AttributeOptions] ([Id], [AttributeId])
GO
ALTER TABLE [dbo].[AttributeSpecs] CHECK CONSTRAINT [FK_AttributeSpecs_AttributeOptions_OptionID_AttributeId]
GO
ALTER TABLE [dbo].[AttributeSpecs]  WITH CHECK ADD  CONSTRAINT [FK_AttributeSpecs_Attributes_AttributeId] FOREIGN KEY([AttributeId])
REFERENCES [dbo].[Attributes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AttributeSpecs] CHECK CONSTRAINT [FK_AttributeSpecs_Attributes_AttributeId]
GO
ALTER TABLE [dbo].[AttributeSpecs]  WITH CHECK ADD  CONSTRAINT [FK_AttributeSpecs_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AttributeSpecs] CHECK CONSTRAINT [FK_AttributeSpecs_Products_ProductId]
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
ALTER TABLE [dbo].[Documents]  WITH CHECK ADD  CONSTRAINT [FK_Documents_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Documents] CHECK CONSTRAINT [FK_Documents_Products_ProductId]
GO
ALTER TABLE [dbo].[HistoryStatuses]  WITH CHECK ADD  CONSTRAINT [FK_HistoryStatuses_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HistoryStatuses] CHECK CONSTRAINT [FK_HistoryStatuses_Orders_OrderId]
GO
ALTER TABLE [dbo].[Menus]  WITH CHECK ADD  CONSTRAINT [FK_Menus_Menus_ParentId] FOREIGN KEY([ParentId])
REFERENCES [dbo].[Menus] ([slugId])
GO
ALTER TABLE [dbo].[Menus] CHECK CONSTRAINT [FK_Menus_Menus_ParentId]
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
ALTER TABLE [dbo].[ProductPrices]  WITH CHECK ADD  CONSTRAINT [FK_ProductPrices_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductPrices] CHECK CONSTRAINT [FK_ProductPrices_Products_ProductId]
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
ALTER TABLE [dbo].[SlugProducts]  WITH CHECK ADD  CONSTRAINT [FK_SlugProducts_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SlugProducts] CHECK CONSTRAINT [FK_SlugProducts_Products_ProductId]
GO
ALTER TABLE [dbo].[SlugProducts]  WITH CHECK ADD  CONSTRAINT [FK_SlugProducts_Slugs_SlugId] FOREIGN KEY([SlugId])
REFERENCES [dbo].[Slugs] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SlugProducts] CHECK CONSTRAINT [FK_SlugProducts_Slugs_SlugId]
GO
ALTER TABLE [dbo].[Slugs]  WITH CHECK ADD  CONSTRAINT [FK_Slugs_Menus_MenuId] FOREIGN KEY([MenuId])
REFERENCES [dbo].[Menus] ([slugId])
GO
ALTER TABLE [dbo].[Slugs] CHECK CONSTRAINT [FK_Slugs_Menus_MenuId]
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
ALTER DATABASE [LandP4] SET  READ_WRITE 
GO
