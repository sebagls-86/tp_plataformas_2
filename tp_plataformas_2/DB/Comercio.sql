USE [master]
GO
/****** Object:  Database [comercio]    Script Date: 24/10/2021 18:20:17 ******/
CREATE DATABASE [comercio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'comercio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\comercio.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'comercio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\comercio_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [comercio] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [comercio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [comercio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [comercio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [comercio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [comercio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [comercio] SET ARITHABORT OFF 
GO
ALTER DATABASE [comercio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [comercio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [comercio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [comercio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [comercio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [comercio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [comercio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [comercio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [comercio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [comercio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [comercio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [comercio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [comercio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [comercio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [comercio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [comercio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [comercio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [comercio] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [comercio] SET  MULTI_USER 
GO
ALTER DATABASE [comercio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [comercio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [comercio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [comercio] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [comercio] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [comercio] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [comercio] SET QUERY_STORE = OFF
GO
USE [comercio]
GO
/****** Object:  Table [dbo].[Carro]    Script Date: 24/10/2021 18:20:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carro](
	[Id] [int] NOT NULL,
	[Id_productos] [int] NULL,
	[Cantidad_productos] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 24/10/2021 18:20:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[Id] [int] NULL,
	[Nombre] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 24/10/2021 18:20:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[Id] [int] NOT NULL,
	[Id_usuario] [int] NULL,
	[Total] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mercado]    Script Date: 24/10/2021 18:20:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mercado](
	[productos] [int] NULL,
	[usuarios] [int] NULL,
	[categorias] [int] NULL,
	[IVA] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 24/10/2021 18:20:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[Id] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Precio] [decimal](18, 0) NULL,
	[Cantidad] [int] NULL,
	[Cat] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos_compra]    Script Date: 24/10/2021 18:20:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos_compra](
	[Id] [int] NOT NULL,
	[Id_compra] [int] NOT NULL,
	[Id_producto] [int] NOT NULL,
	[Cantidad_producto] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 24/10/2021 18:20:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] NULL,
	[CUIL] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[MiCarro] [int] NULL,
	[TipoUsuario] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Carro] ([Id], [Id_productos], [Cantidad_productos]) VALUES (3, NULL, NULL)
GO
INSERT [dbo].[Categoria] ([Id], [Nombre]) VALUES (1, N'Verduleria')
INSERT [dbo].[Categoria] ([Id], [Nombre]) VALUES (2, N'Panaderia')
INSERT [dbo].[Categoria] ([Id], [Nombre]) VALUES (3, N'lacteos')
INSERT [dbo].[Categoria] ([Id], [Nombre]) VALUES (4, N'fiambres')
INSERT [dbo].[Categoria] ([Id], [Nombre]) VALUES (5, N'Hogar')
INSERT [dbo].[Categoria] ([Id], [Nombre]) VALUES (6, N'iluminacion')
INSERT [dbo].[Categoria] ([Id], [Nombre]) VALUES (7, N'ferreteria')
INSERT [dbo].[Categoria] ([Id], [Nombre]) VALUES (8, N'electronica')
INSERT [dbo].[Categoria] ([Id], [Nombre]) VALUES (9, N'bazar')
INSERT [dbo].[Categoria] ([Id], [Nombre]) VALUES (10, N'Carniceria')
GO
INSERT [dbo].[Producto] ([Id], [Nombre], [Precio], [Cantidad], [Cat]) VALUES (1, N'Papa', CAST(125 AS Decimal(18, 0)), 485, 1)
INSERT [dbo].[Producto] ([Id], [Nombre], [Precio], [Cantidad], [Cat]) VALUES (2, N'pera', CAST(150 AS Decimal(18, 0)), 19901, 1)
INSERT [dbo].[Producto] ([Id], [Nombre], [Precio], [Cantidad], [Cat]) VALUES (3, N'tomate', CAST(125 AS Decimal(18, 0)), 11921, 1)
GO
INSERT [dbo].[Usuario] ([Id], [CUIL], [Nombre], [Apellido], [Mail], [Password], [MiCarro], [TipoUsuario]) VALUES (1, 1, N'1', N'1', N'1', N'1', 1, 1)
INSERT [dbo].[Usuario] ([Id], [CUIL], [Nombre], [Apellido], [Mail], [Password], [MiCarro], [TipoUsuario]) VALUES (3, 3, N'3', N'3', N'3', N'3', 3, 3)
INSERT [dbo].[Usuario] ([Id], [CUIL], [Nombre], [Apellido], [Mail], [Password], [MiCarro], [TipoUsuario]) VALUES (2, 2, N'2', N'2', N'2', N'2', 2, 3)
GO
USE [master]
GO
ALTER DATABASE [comercio] SET  READ_WRITE 
GO
