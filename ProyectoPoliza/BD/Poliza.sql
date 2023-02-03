USE [master]
GO
/****** Object:  Database [Poliza]    Script Date: 03/02/2023 14:25:47 ******/
CREATE DATABASE [Poliza]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Poliza', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Poliza.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Poliza_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Poliza_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Poliza] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Poliza].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Poliza] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Poliza] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Poliza] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Poliza] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Poliza] SET ARITHABORT OFF 
GO
ALTER DATABASE [Poliza] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Poliza] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Poliza] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Poliza] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Poliza] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Poliza] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Poliza] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Poliza] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Poliza] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Poliza] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Poliza] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Poliza] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Poliza] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Poliza] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Poliza] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Poliza] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Poliza] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Poliza] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Poliza] SET  MULTI_USER 
GO
ALTER DATABASE [Poliza] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Poliza] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Poliza] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Poliza] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Poliza] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Poliza] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Poliza] SET QUERY_STORE = OFF
GO
USE [Poliza]
GO
/****** Object:  Table [dbo].[Asegurados]    Script Date: 03/02/2023 14:25:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asegurados](
	[IdPoliza] [nchar](10) NOT NULL,
	[IdAsegurado] [nchar](10) NOT NULL,
	[Dni] [nchar](10) NULL,
	[Nombre] [nvarchar](50) NULL,
	[FechaNacimiento] [datetime] NULL,
	[Estado] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Poliza]    Script Date: 03/02/2023 14:25:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Poliza](
	[IdPoliza] [nchar](10) NOT NULL,
	[IdProducto] [nchar](10) NOT NULL,
	[IdTipoProducto] [nchar](10) NOT NULL,
	[Estado] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 03/02/2023 14:25:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[IdProducto] [nchar](10) NOT NULL,
	[Nombre] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoProducto]    Script Date: 03/02/2023 14:25:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoProducto](
	[IdTipoProducto] [nchar](10) NOT NULL,
	[Nombre] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Asegurados] ([IdPoliza], [IdAsegurado], [Dni], [Nombre], [FechaNacimiento], [Estado]) VALUES (N'1         ', N'1         ', N'565642    ', N'Santiago', CAST(N'2000-07-18T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Asegurados] ([IdPoliza], [IdAsegurado], [Dni], [Nombre], [FechaNacimiento], [Estado]) VALUES (N'2         ', N'12        ', N'665645    ', N'Sofia', CAST(N'1998-11-25T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Asegurados] ([IdPoliza], [IdAsegurado], [Dni], [Nombre], [FechaNacimiento], [Estado]) VALUES (N'4         ', N'6         ', N'252525    ', N'Marcos', CAST(N'1995-11-10T00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[Poliza] ([IdPoliza], [IdProducto], [IdTipoProducto], [Estado]) VALUES (N'1         ', N'1         ', N'1         ', 1)
GO
INSERT [dbo].[Poliza] ([IdPoliza], [IdProducto], [IdTipoProducto], [Estado]) VALUES (N'2         ', N'5         ', N'2         ', 1)
GO
INSERT [dbo].[Poliza] ([IdPoliza], [IdProducto], [IdTipoProducto], [Estado]) VALUES (N'3         ', N'4         ', N'7         ', 1)
GO
INSERT [dbo].[Poliza] ([IdPoliza], [IdProducto], [IdTipoProducto], [Estado]) VALUES (N'4         ', N'4         ', N'4         ', 1)
GO
INSERT [dbo].[Producto] ([IdProducto], [Nombre]) VALUES (N'1         ', N'SeguroAuto')
GO
INSERT [dbo].[Producto] ([IdProducto], [Nombre]) VALUES (N'2         ', N'SeguroMoto')
GO
INSERT [dbo].[Producto] ([IdProducto], [Nombre]) VALUES (N'3         ', N'Seguro3')
GO
INSERT [dbo].[TipoProducto] ([IdTipoProducto], [Nombre]) VALUES (N'1         ', N'Tipo1')
GO
INSERT [dbo].[TipoProducto] ([IdTipoProducto], [Nombre]) VALUES (N'2         ', N'Tipo2')
GO
INSERT [dbo].[TipoProducto] ([IdTipoProducto], [Nombre]) VALUES (N'3         ', N'Tipo3')
GO
INSERT [dbo].[TipoProducto] ([IdTipoProducto], [Nombre]) VALUES (N'4         ', N'Tipo4')
GO
USE [master]
GO
ALTER DATABASE [Poliza] SET  READ_WRITE 
GO
