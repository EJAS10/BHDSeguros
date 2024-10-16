USE [master]
GO
/****** Object:  Database [pruebabhd]    Script Date: 11/10/2024 10:02:03 p. m. ******/
CREATE DATABASE [pruebabhd]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'pruebabhd', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\pruebabhd.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'pruebabhd_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\pruebabhd_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [pruebabhd] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [pruebabhd].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [pruebabhd] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [pruebabhd] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [pruebabhd] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [pruebabhd] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [pruebabhd] SET ARITHABORT OFF 
GO
ALTER DATABASE [pruebabhd] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [pruebabhd] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [pruebabhd] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [pruebabhd] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [pruebabhd] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [pruebabhd] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [pruebabhd] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [pruebabhd] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [pruebabhd] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [pruebabhd] SET  ENABLE_BROKER 
GO
ALTER DATABASE [pruebabhd] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [pruebabhd] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [pruebabhd] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [pruebabhd] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [pruebabhd] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [pruebabhd] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [pruebabhd] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [pruebabhd] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [pruebabhd] SET  MULTI_USER 
GO
ALTER DATABASE [pruebabhd] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [pruebabhd] SET DB_CHAINING OFF 
GO
ALTER DATABASE [pruebabhd] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [pruebabhd] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [pruebabhd] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [pruebabhd] SET QUERY_STORE = OFF
GO
USE [pruebabhd]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/10/2024 10:02:03 p. m. ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 11/10/2024 10:02:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientName] [nvarchar](max) NOT NULL,
	[ClientLastName] [nvarchar](max) NOT NULL,
	[ClientIdentification] [nvarchar](max) NOT NULL,
	[DateOfBirth] [datetime2](7) NOT NULL,
	[Status] [int] NOT NULL,
	[DateCreation] [datetime2](7) NOT NULL,
	[DateUpdate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientSecure]    Script Date: 11/10/2024 10:02:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientSecure](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[SecurePlansId] [int] NOT NULL,
	[Policy] [nvarchar](max) NOT NULL,
	[ProductNumber] [nvarchar](max) NOT NULL,
	[ProductTypeId] [int] NOT NULL,
	[Status] [int] NOT NULL,	
	[DateCreation] [datetime2](7) NOT NULL,
	[DateUpdate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ClientSecure] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductType]    Script Date: 11/10/2024 10:02:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductTypeName] [nvarchar](max) NOT NULL,
	[Status] [int] NOT NULL,
	[DateCreation] [datetime2](7) NOT NULL,
	[DateUpdate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ProductType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SecureApplications]    Script Date: 11/10/2024 10:02:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SecureApplications](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[SecurePlansId] [int] NOT NULL,
	[ProductTypeId] [int] NOT NULL,
	[ProductNumber] [nvarchar](max) NOT NULL,
	[SolicitudStatus] [int] NOT NULL,
	[Message] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[DateCreation] [datetime2](7) NOT NULL,
	[DateUpdate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_SecureApplications] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SecureCode]    Script Date: 11/10/2024 10:02:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SecureCode](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SecureCode] [nvarchar](max) NOT NULL,
	[CodeName] [nvarchar](max) NOT NULL,
	[Status] [int] NOT NULL,
	[DateCreation] [datetime2](7) NOT NULL,
	[DateUpdate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_SecureCode] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SecureCodeProductType]    Script Date: 11/10/2024 10:02:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SecureCodeProductType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SecureCodeId] [int] NOT NULL,
	[ProductTypeId] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[DateCreation] [datetime2](7) NOT NULL,
	[DateUpdate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_SecureCodeProductType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SecurePlans]    Script Date: 11/10/2024 10:02:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SecurePlans](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PlansCode] [nvarchar](max) NOT NULL,
	[PlansName] [nvarchar](max) NOT NULL,
	[PlanFee] [decimal](18, 2) NOT NULL,
	[MinAge] [int] NOT NULL,
	[MaxAge] [int] NOT NULL,
	[SecureCodeId] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[DateCreation] [datetime2](7) NOT NULL,
	[DateUpdate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_SecurePlans] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241011194309_Initial', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241011195410_cambiandomontoadecimal', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241011213800_agregandocampopoliza', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241011214133_messagepuedesernull', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241011214418_quitandousermodif', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241011235110_agregandocamposdetipoproductoalossegurosdelcliente', N'8.0.8')
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([Id], [ClientName], [ClientLastName], [ClientIdentification], [DateOfBirth], [Status], [DateCreation], [DateUpdate]) VALUES (1, N'Emmanuel 3', N'Almanzar 3', N'40200000003', CAST(N'1999-04-10T00:00:00.0000000' AS DateTime2), 1, CAST(N'2024-10-11T16:26:12.0000000' AS DateTime2), CAST(N'2024-10-11T16:26:12.0000000' AS DateTime2))
INSERT [dbo].[Client] ([Id], [ClientName], [ClientLastName], [ClientIdentification], [DateOfBirth], [Status], [DateCreation], [DateUpdate]) VALUES (2, N'Emmanuel 1', N'Almanzar 1', N'40200000001', CAST(N'1999-04-10T00:00:00.0000000' AS DateTime2), 1, CAST(N'2024-10-11T18:16:44.0000000' AS DateTime2), CAST(N'2024-10-11T18:16:44.0000000' AS DateTime2))
INSERT [dbo].[Client] ([Id], [ClientName], [ClientLastName], [ClientIdentification], [DateOfBirth], [Status], [DateCreation], [DateUpdate]) VALUES (3, N'Emmanuel 2', N'Almanzar 2', N'40200000002', CAST(N'1999-04-10T00:00:00.0000000' AS DateTime2), 1, CAST(N'2024-10-11T19:09:42.0000000' AS DateTime2), CAST(N'2024-10-11T19:09:42.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[ClientSecure] ON 

INSERT [dbo].[ClientSecure] ([Id], [ClientId], [SecurePlansId], [Status], [DateCreation], [DateUpdate], [Policy], [ProductNumber], [ProductTypeId]) VALUES (1, 1, 1, 1, CAST(N'2024-10-11T17:51:56.0000000' AS DateTime2), CAST(N'2024-10-11T17:51:56.0000000' AS DateTime2), N'MRE-A05-00004', N'123456789', 1)
INSERT [dbo].[ClientSecure] ([Id], [ClientId], [SecurePlansId], [Status], [DateCreation], [DateUpdate], [Policy], [ProductNumber], [ProductTypeId]) VALUES (2, 2, 1, 1, CAST(N'2024-10-11T18:16:45.0000000' AS DateTime2), CAST(N'2024-10-11T18:16:45.0000000' AS DateTime2), N'MRE-A05-00012', N'987654321', 1)
INSERT [dbo].[ClientSecure] ([Id], [ClientId], [SecurePlansId], [Status], [DateCreation], [DateUpdate], [Policy], [ProductNumber], [ProductTypeId]) VALUES (3, 1, 3, 1, CAST(N'2024-10-11T21:36:43.0000000' AS DateTime2), CAST(N'2024-10-11T21:36:43.0000000' AS DateTime2), N'MRE-A1B-00015', N'963852741', 1)
SET IDENTITY_INSERT [dbo].[ClientSecure] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductType] ON 

INSERT [dbo].[ProductType] ([Id], [ProductTypeName], [Status], [DateCreation], [DateUpdate]) VALUES (1, N'TC', 1, CAST(N'2024-10-11T15:49:04.0233333' AS DateTime2), CAST(N'2024-10-11T15:49:04.0233333' AS DateTime2))
INSERT [dbo].[ProductType] ([Id], [ProductTypeName], [Status], [DateCreation], [DateUpdate]) VALUES (2, N'CTA', 1, CAST(N'2024-10-11T15:49:04.0366667' AS DateTime2), CAST(N'2024-10-11T15:49:04.0366667' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ProductType] OFF
GO
SET IDENTITY_INSERT [dbo].[SecureApplications] ON 

INSERT [dbo].[SecureApplications] ([Id], [ClientId], [SecurePlansId], [ProductTypeId], [ProductNumber], [SolicitudStatus], [Message], [Status], [DateCreation], [DateUpdate]) VALUES (4, 1, 1, 1, N'0000000000000001', 1, NULL, 1, CAST(N'2024-10-11T17:50:26.0000000' AS DateTime2), CAST(N'2024-10-11T17:50:26.0000000' AS DateTime2))
INSERT [dbo].[SecureApplications] ([Id], [ClientId], [SecurePlansId], [ProductTypeId], [ProductNumber], [SolicitudStatus], [Message], [Status], [DateCreation], [DateUpdate]) VALUES (5, 1, 1, 1, N'0000000000000001', 0, N'El Cliente ya tiene este plan', 1, CAST(N'2024-10-11T17:54:26.0000000' AS DateTime2), CAST(N'2024-10-11T17:54:26.0000000' AS DateTime2))
INSERT [dbo].[SecureApplications] ([Id], [ClientId], [SecurePlansId], [ProductTypeId], [ProductNumber], [SolicitudStatus], [Message], [Status], [DateCreation], [DateUpdate]) VALUES (8, 1, 2, 2, N'00000001', 0, N'El tipo de producto no es valido para el plan', 1, CAST(N'2024-10-11T18:12:16.0000000' AS DateTime2), CAST(N'2024-10-11T18:12:16.0000000' AS DateTime2))
INSERT [dbo].[SecureApplications] ([Id], [ClientId], [SecurePlansId], [ProductTypeId], [ProductNumber], [SolicitudStatus], [Message], [Status], [DateCreation], [DateUpdate]) VALUES (9, 1, 1, 1, N'00000001', 0, N'El Cliente ya tiene este plan', 1, CAST(N'2024-10-11T18:13:01.0000000' AS DateTime2), CAST(N'2024-10-11T18:13:01.0000000' AS DateTime2))
INSERT [dbo].[SecureApplications] ([Id], [ClientId], [SecurePlansId], [ProductTypeId], [ProductNumber], [SolicitudStatus], [Message], [Status], [DateCreation], [DateUpdate]) VALUES (10, 1, 1, 1, N'00000001', 0, N'El Cliente no tiene una edad valida para el plan', 1, CAST(N'2024-10-11T18:14:12.0000000' AS DateTime2), CAST(N'2024-10-11T18:14:12.0000000' AS DateTime2))
INSERT [dbo].[SecureApplications] ([Id], [ClientId], [SecurePlansId], [ProductTypeId], [ProductNumber], [SolicitudStatus], [Message], [Status], [DateCreation], [DateUpdate]) VALUES (11, 1, 1, 1, N'00000001', 0, N'El Cliente ya tiene este plan. El Cliente no tiene una edad valida para el plan', 1, CAST(N'2024-10-11T18:15:40.0000000' AS DateTime2), CAST(N'2024-10-11T18:15:40.0000000' AS DateTime2))
INSERT [dbo].[SecureApplications] ([Id], [ClientId], [SecurePlansId], [ProductTypeId], [ProductNumber], [SolicitudStatus], [Message], [Status], [DateCreation], [DateUpdate]) VALUES (12, 2, 1, 1, N'00000001', 1, NULL, 1, CAST(N'2024-10-11T18:16:45.0000000' AS DateTime2), CAST(N'2024-10-11T18:16:45.0000000' AS DateTime2))
INSERT [dbo].[SecureApplications] ([Id], [ClientId], [SecurePlansId], [ProductTypeId], [ProductNumber], [SolicitudStatus], [Message], [Status], [DateCreation], [DateUpdate]) VALUES (13, 3, 1, 1, N'00000001', 1, NULL, 1, CAST(N'2024-10-11T19:09:53.0000000' AS DateTime2), CAST(N'2024-10-11T19:09:53.0000000' AS DateTime2))
INSERT [dbo].[SecureApplications] ([Id], [ClientId], [SecurePlansId], [ProductTypeId], [ProductNumber], [SolicitudStatus], [Message], [Status], [DateCreation], [DateUpdate]) VALUES (14, 2, 1, 1, N'00000001', 0, N'El Cliente ya tiene este plan. ', 1, CAST(N'2024-10-11T19:22:07.0000000' AS DateTime2), CAST(N'2024-10-11T19:22:07.0000000' AS DateTime2))
INSERT [dbo].[SecureApplications] ([Id], [ClientId], [SecurePlansId], [ProductTypeId], [ProductNumber], [SolicitudStatus], [Message], [Status], [DateCreation], [DateUpdate]) VALUES (15, 1, 3, 1, N'963852741', 1, NULL, 1, CAST(N'2024-10-11T21:35:58.0000000' AS DateTime2), CAST(N'2024-10-11T21:35:58.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[SecureApplications] OFF
GO
SET IDENTITY_INSERT [dbo].[SecureCode] ON 

INSERT [dbo].[SecureCode] ([Id], [SecureCode], [CodeName], [Status], [DateCreation], [DateUpdate]) VALUES (1, N'MRE', N'SeguroMRE', 1, CAST(N'2024-10-11T15:49:00.6233333' AS DateTime2), CAST(N'2024-10-11T15:49:00.6233333' AS DateTime2))
INSERT [dbo].[SecureCode] ([Id], [SecureCode], [CodeName], [Status], [DateCreation], [DateUpdate]) VALUES (2, N'MAE', N'SeguroMAE', 1, CAST(N'2024-10-11T15:49:00.6400000' AS DateTime2), CAST(N'2024-10-11T15:49:00.6400000' AS DateTime2))
INSERT [dbo].[SecureCode] ([Id], [SecureCode], [CodeName], [Status], [DateCreation], [DateUpdate]) VALUES (3, N'MRE', N'SeguroMNF', 1, CAST(N'2024-10-11T15:49:00.6400000' AS DateTime2), CAST(N'2024-10-11T15:49:00.6400000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[SecureCode] OFF
GO
SET IDENTITY_INSERT [dbo].[SecureCodeProductType] ON 

INSERT [dbo].[SecureCodeProductType] ([Id], [SecureCodeId], [ProductTypeId], [Status], [DateCreation], [DateUpdate]) VALUES (1, 1, 1, 1, CAST(N'2024-10-11T15:50:56.5200000' AS DateTime2), CAST(N'2024-10-11T15:50:56.5200000' AS DateTime2))
INSERT [dbo].[SecureCodeProductType] ([Id], [SecureCodeId], [ProductTypeId], [Status], [DateCreation], [DateUpdate]) VALUES (2, 2, 1, 1, CAST(N'2024-10-11T15:50:56.5366667' AS DateTime2), CAST(N'2024-10-11T15:50:56.5366667' AS DateTime2))
INSERT [dbo].[SecureCodeProductType] ([Id], [SecureCodeId], [ProductTypeId], [Status], [DateCreation], [DateUpdate]) VALUES (3, 2, 2, 1, CAST(N'2024-10-11T15:50:56.5366667' AS DateTime2), CAST(N'2024-10-11T15:50:56.5366667' AS DateTime2))
INSERT [dbo].[SecureCodeProductType] ([Id], [SecureCodeId], [ProductTypeId], [Status], [DateCreation], [DateUpdate]) VALUES (4, 3, 1, 1, CAST(N'2024-10-11T15:50:56.5366667' AS DateTime2), CAST(N'2024-10-11T15:50:56.5366667' AS DateTime2))
INSERT [dbo].[SecureCodeProductType] ([Id], [SecureCodeId], [ProductTypeId], [Status], [DateCreation], [DateUpdate]) VALUES (5, 3, 2, 1, CAST(N'2024-10-11T15:50:56.5366667' AS DateTime2), CAST(N'2024-10-11T15:50:56.5366667' AS DateTime2))
SET IDENTITY_INSERT [dbo].[SecureCodeProductType] OFF
GO
SET IDENTITY_INSERT [dbo].[SecurePlans] ON 

INSERT [dbo].[SecurePlans] ([Id], [PlansCode], [PlansName], [PlanFee], [MinAge], [MaxAge], [SecureCodeId], [Status], [DateCreation], [DateUpdate]) VALUES (1, N'A05', N'Plan 1', CAST(675.00 AS Decimal(18, 2)), 18, 59, 1, 1, CAST(N'2024-10-11T15:57:16.9266667' AS DateTime2), CAST(N'2024-10-11T15:57:16.9266667' AS DateTime2))
INSERT [dbo].[SecurePlans] ([Id], [PlansCode], [PlansName], [PlanFee], [MinAge], [MaxAge], [SecureCodeId], [Status], [DateCreation], [DateUpdate]) VALUES (2, N'A04', N'Plan 2', CAST(472.00 AS Decimal(18, 2)), 18, 59, 1, 1, CAST(N'2024-10-11T15:57:16.9500000' AS DateTime2), CAST(N'2024-10-11T15:57:16.9500000' AS DateTime2))
INSERT [dbo].[SecurePlans] ([Id], [PlansCode], [PlansName], [PlanFee], [MinAge], [MaxAge], [SecureCodeId], [Status], [DateCreation], [DateUpdate]) VALUES (3, N'A1B', N'Plan A1', CAST(141.00 AS Decimal(18, 2)), 18, 65, 1, 1, CAST(N'2024-10-11T15:57:16.9500000' AS DateTime2), CAST(N'2024-10-11T15:57:16.9500000' AS DateTime2))
INSERT [dbo].[SecurePlans] ([Id], [PlansCode], [PlansName], [PlanFee], [MinAge], [MaxAge], [SecureCodeId], [Status], [DateCreation], [DateUpdate]) VALUES (4, N'A1C', N'Plan A1', CAST(235.00 AS Decimal(18, 2)), 18, 65, 1, 1, CAST(N'2024-10-11T15:57:16.9500000' AS DateTime2), CAST(N'2024-10-11T15:57:16.9500000' AS DateTime2))
INSERT [dbo].[SecurePlans] ([Id], [PlansCode], [PlansName], [PlanFee], [MinAge], [MaxAge], [SecureCodeId], [Status], [DateCreation], [DateUpdate]) VALUES (5, N'M11', N'Plan BA1', CAST(47.00 AS Decimal(18, 2)), 18, 30, 1, 1, CAST(N'2024-10-11T15:57:16.9533333' AS DateTime2), CAST(N'2024-10-11T15:57:16.9533333' AS DateTime2))
INSERT [dbo].[SecurePlans] ([Id], [PlansCode], [PlansName], [PlanFee], [MinAge], [MaxAge], [SecureCodeId], [Status], [DateCreation], [DateUpdate]) VALUES (6, N'M10', N'Plan BA2', CAST(53.00 AS Decimal(18, 2)), 18, 30, 1, 1, CAST(N'2024-10-11T15:57:16.9533333' AS DateTime2), CAST(N'2024-10-11T15:57:16.9533333' AS DateTime2))
SET IDENTITY_INSERT [dbo].[SecurePlans] OFF
GO
/****** Object:  Index [IX_ClientSecure_ClientId]    Script Date: 11/10/2024 10:02:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_ClientSecure_ClientId] ON [dbo].[ClientSecure]
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ClientSecure_ProductTypeId]    Script Date: 11/10/2024 10:02:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_ClientSecure_ProductTypeId] ON [dbo].[ClientSecure]
(
	[ProductTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ClientSecure_SecurePlansId]    Script Date: 11/10/2024 10:02:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_ClientSecure_SecurePlansId] ON [dbo].[ClientSecure]
(
	[SecurePlansId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SecureApplications_ClientId]    Script Date: 11/10/2024 10:02:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_SecureApplications_ClientId] ON [dbo].[SecureApplications]
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SecureApplications_ProductTypeId]    Script Date: 11/10/2024 10:02:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_SecureApplications_ProductTypeId] ON [dbo].[SecureApplications]
(
	[ProductTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SecureApplications_SecurePlansId]    Script Date: 11/10/2024 10:02:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_SecureApplications_SecurePlansId] ON [dbo].[SecureApplications]
(
	[SecurePlansId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SecureCodeProductType_ProductTypeId]    Script Date: 11/10/2024 10:02:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_SecureCodeProductType_ProductTypeId] ON [dbo].[SecureCodeProductType]
(
	[ProductTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SecureCodeProductType_SecureCodeId]    Script Date: 11/10/2024 10:02:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_SecureCodeProductType_SecureCodeId] ON [dbo].[SecureCodeProductType]
(
	[SecureCodeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SecurePlans_SecureCodeId]    Script Date: 11/10/2024 10:02:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_SecurePlans_SecureCodeId] ON [dbo].[SecurePlans]
(
	[SecureCodeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ClientSecure] ADD  DEFAULT (N'') FOR [Policy]
GO
ALTER TABLE [dbo].[ClientSecure] ADD  DEFAULT (N'') FOR [ProductNumber]
GO
ALTER TABLE [dbo].[ClientSecure] ADD  DEFAULT ((1)) FOR [ProductTypeId]
GO
ALTER TABLE [dbo].[ClientSecure]  WITH CHECK ADD  CONSTRAINT [FK_ClientSecure_Client_ClientId] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Client] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ClientSecure] CHECK CONSTRAINT [FK_ClientSecure_Client_ClientId]
GO
ALTER TABLE [dbo].[ClientSecure]  WITH CHECK ADD  CONSTRAINT [FK_ClientSecure_ProductType_ProductTypeId] FOREIGN KEY([ProductTypeId])
REFERENCES [dbo].[ProductType] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ClientSecure] CHECK CONSTRAINT [FK_ClientSecure_ProductType_ProductTypeId]
GO
ALTER TABLE [dbo].[ClientSecure]  WITH CHECK ADD  CONSTRAINT [FK_ClientSecure_SecurePlans_SecurePlansId] FOREIGN KEY([SecurePlansId])
REFERENCES [dbo].[SecurePlans] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ClientSecure] CHECK CONSTRAINT [FK_ClientSecure_SecurePlans_SecurePlansId]
GO
ALTER TABLE [dbo].[SecureApplications]  WITH CHECK ADD  CONSTRAINT [FK_SecureApplications_Client_ClientId] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Client] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SecureApplications] CHECK CONSTRAINT [FK_SecureApplications_Client_ClientId]
GO
ALTER TABLE [dbo].[SecureApplications]  WITH CHECK ADD  CONSTRAINT [FK_SecureApplications_ProductType_ProductTypeId] FOREIGN KEY([ProductTypeId])
REFERENCES [dbo].[ProductType] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SecureApplications] CHECK CONSTRAINT [FK_SecureApplications_ProductType_ProductTypeId]
GO
ALTER TABLE [dbo].[SecureApplications]  WITH CHECK ADD  CONSTRAINT [FK_SecureApplications_SecurePlans_SecurePlansId] FOREIGN KEY([SecurePlansId])
REFERENCES [dbo].[SecurePlans] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SecureApplications] CHECK CONSTRAINT [FK_SecureApplications_SecurePlans_SecurePlansId]
GO
ALTER TABLE [dbo].[SecureCodeProductType]  WITH CHECK ADD  CONSTRAINT [FK_SecureCodeProductType_ProductType_ProductTypeId] FOREIGN KEY([ProductTypeId])
REFERENCES [dbo].[ProductType] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SecureCodeProductType] CHECK CONSTRAINT [FK_SecureCodeProductType_ProductType_ProductTypeId]
GO
ALTER TABLE [dbo].[SecureCodeProductType]  WITH CHECK ADD  CONSTRAINT [FK_SecureCodeProductType_SecureCode_SecureCodeId] FOREIGN KEY([SecureCodeId])
REFERENCES [dbo].[SecureCode] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SecureCodeProductType] CHECK CONSTRAINT [FK_SecureCodeProductType_SecureCode_SecureCodeId]
GO
ALTER TABLE [dbo].[SecurePlans]  WITH CHECK ADD  CONSTRAINT [FK_SecurePlans_SecureCode_SecureCodeId] FOREIGN KEY([SecureCodeId])
REFERENCES [dbo].[SecureCode] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SecurePlans] CHECK CONSTRAINT [FK_SecurePlans_SecureCode_SecureCodeId]
GO
USE [master]
GO
ALTER DATABASE [pruebabhd] SET  READ_WRITE 
GO
