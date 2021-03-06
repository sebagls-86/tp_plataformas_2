USE [master]
GO
/****** Object:  Database [comercio]    Script Date: 26/11/2021 14:31:24 ******/
CREATE DATABASE [comercio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'comercio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS02\MSSQL\DATA\comercio.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'comercio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS02\MSSQL\DATA\comercio_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [comercio] SET COMPATIBILITY_LEVEL = 140
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
ALTER DATABASE [comercio] SET QUERY_STORE = OFF
GO
USE [comercio]
GO
/****** Object:  Table [dbo].[Carro]    Script Date: 26/11/2021 14:31:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carro](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CarroId] [int] NOT NULL,
	[UsuarioId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carro_productos]    Script Date: 26/11/2021 14:31:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carro_productos](
	[Id_Carro] [int] NOT NULL,
	[Id_Producto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 26/11/2021 14:31:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[CatId] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 26/11/2021 14:31:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[CompraId] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NOT NULL,
	[Total] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mercado]    Script Date: 26/11/2021 14:31:25 ******/
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
/****** Object:  Table [dbo].[Productos]    Script Date: 26/11/2021 14:31:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[ProductoId] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Precio] [float] NULL,
	[Cantidad] [int] NULL,
	[CatId] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos_compra]    Script Date: 26/11/2021 14:31:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos_compra](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_compra] [int] NOT NULL,
	[Id_producto] [int] NOT NULL,
	[Cantidad_producto] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 26/11/2021 14:31:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[UsuarioId] [int] NULL,
	[Cuil] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[MiCarro] [int] NULL,
	[TipoUsuario] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Carro] ON 

INSERT [dbo].[Carro] ([id], [CarroId], [UsuarioId]) VALUES (1, 1, 1)
INSERT [dbo].[Carro] ([id], [CarroId], [UsuarioId]) VALUES (2, 2, 2)
INSERT [dbo].[Carro] ([id], [CarroId], [UsuarioId]) VALUES (3, 3, 3)
INSERT [dbo].[Carro] ([id], [CarroId], [UsuarioId]) VALUES (10, 4, 4)
SET IDENTITY_INSERT [dbo].[Carro] OFF
GO
INSERT [dbo].[Carro_productos] ([Id_Carro], [Id_Producto], [Cantidad]) VALUES (2, 1, 1)
INSERT [dbo].[Carro_productos] ([Id_Carro], [Id_Producto], [Cantidad]) VALUES (2, 2, 1)
INSERT [dbo].[Carro_productos] ([Id_Carro], [Id_Producto], [Cantidad]) VALUES (2, 6, 1)
INSERT [dbo].[Carro_productos] ([Id_Carro], [Id_Producto], [Cantidad]) VALUES (1, 1, 1)
INSERT [dbo].[Carro_productos] ([Id_Carro], [Id_Producto], [Cantidad]) VALUES (2, 5, 1)
INSERT [dbo].[Carro_productos] ([Id_Carro], [Id_Producto], [Cantidad]) VALUES (10, 1, 1)
GO
INSERT [dbo].[Categorias] ([CatId], [Nombre]) VALUES (1, N'modificada')
INSERT [dbo].[Categorias] ([CatId], [Nombre]) VALUES (2, N'Panaderia')
INSERT [dbo].[Categorias] ([CatId], [Nombre]) VALUES (3, N'Lacteos')
INSERT [dbo].[Categorias] ([CatId], [Nombre]) VALUES (4, N'Cosas')
INSERT [dbo].[Categorias] ([CatId], [Nombre]) VALUES (5, N'5')
INSERT [dbo].[Categorias] ([CatId], [Nombre]) VALUES (6, N' ')
INSERT [dbo].[Categorias] ([CatId], [Nombre]) VALUES (7, N'7')
INSERT [dbo].[Categorias] ([CatId], [Nombre]) VALUES (8, N'8')
INSERT [dbo].[Categorias] ([CatId], [Nombre]) VALUES (9, N'9')
INSERT [dbo].[Categorias] ([CatId], [Nombre]) VALUES (10, N'10')
GO
SET IDENTITY_INSERT [dbo].[Compras] ON 

INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (1, 2, 4)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (2, 3, 514.25)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (3, 3, 514.25)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (4, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (11, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (15, 2, 695.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (16, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (17, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (18, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (19, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (20, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (21, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (22, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (26, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (27, 3, 364.21)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (28, 3, 364.21)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (29, 3, 12553.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (30, 3, 303.71)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (31, 3, 151.25)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (32, 3, 151.25)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (33, 3, 151.25)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (35, 3, 0)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (40, 3, 0)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (41, 3, 453.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (42, 3, 302.5)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (43, 3, 302.5)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (44, 3, 302.5)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (45, 3, 592.310125)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (46, 3, 546.0125)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (47, 3, 302.5)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (50, 3, 306.13)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (51, 3, 151.25)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (52, 3, 2.42)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (53, 3, 2.42)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (54, 3, 665.5)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (66, 3, 15125)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (67, 3, 15125)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (68, 3, 0)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (5, 3, 514.25)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (6, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (7, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (8, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (9, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (10, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (12, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (13, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (14, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (23, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (24, 3, 302.5)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (25, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (34, 3, 635.25)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (36, 3, 0)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (37, 3, 0)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (38, 3, 0)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (39, 3, 0)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (55, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (56, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (57, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (58, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (59, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (60, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (61, 3, 332.75)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (62, 3, 151.25)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (63, 3, 1210)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (64, 3, 28737.5)
INSERT [dbo].[Compras] ([CompraId], [idUsuario], [Total]) VALUES (65, 3, 14368.75)
SET IDENTITY_INSERT [dbo].[Compras] OFF
GO
INSERT [dbo].[Productos] ([ProductoId], [Nombre], [Precio], [Cantidad], [CatId]) VALUES (1, N'Papa', 125, 300, 1)
INSERT [dbo].[Productos] ([ProductoId], [Nombre], [Precio], [Cantidad], [CatId]) VALUES (2, N'pera', 150, 19900, 1)
INSERT [dbo].[Productos] ([ProductoId], [Nombre], [Precio], [Cantidad], [CatId]) VALUES (3, N'tomate', 125, 11920, 1)
INSERT [dbo].[Productos] ([ProductoId], [Nombre], [Precio], [Cantidad], [CatId]) VALUES (4, N'cebolla', 1, 20, 1)
INSERT [dbo].[Productos] ([ProductoId], [Nombre], [Precio], [Cantidad], [CatId]) VALUES (5, N'tomatitos', 200, 100, 1)
INSERT [dbo].[Productos] ([ProductoId], [Nombre], [Precio], [Cantidad], [CatId]) VALUES (6, N'batata', 100, 1, 1)
INSERT [dbo].[Productos] ([ProductoId], [Nombre], [Precio], [Cantidad], [CatId]) VALUES (7, N'ajo', 100, 10, 1)
INSERT [dbo].[Productos] ([ProductoId], [Nombre], [Precio], [Cantidad], [CatId]) VALUES (8, N'cambiado', 200, 200, 2)
GO
SET IDENTITY_INSERT [dbo].[Productos_compra] ON 

INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (1, 1, 1, 1)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (2, 22, 1, 1)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (3, 22, 2, 1)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (4, 23, 1, 1)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (10, 29, 1, 83)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (11, 30, 1, 2)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (12, 30, 4, 1)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (13, 31, 1, 1)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (14, 32, 1, 1)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (15, 33, 1, 1)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (16, 53, 4, 0)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (17, 54, 4, 0)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (18, 54, 1, 0)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (19, 54, 2, 0)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (28, 67, 1, 100)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (5, 23, 2, 1)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (6, 24, 1, 1)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (7, 24, 1, 1)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (8, 25, 2, 1)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (9, 25, 3, 1)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (20, 55, 1, 0)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (21, 55, 2, 0)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (22, 61, 1, 0)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (23, 61, 2, 0)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (24, 62, 1, 1)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (25, 63, 1, 8)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (26, 64, 1, 95)
INSERT [dbo].[Productos_compra] ([Id], [Id_compra], [Id_producto], [Cantidad_producto]) VALUES (27, 65, 1, 95)
SET IDENTITY_INSERT [dbo].[Productos_compra] OFF
GO
INSERT [dbo].[Usuarios] ([UsuarioId], [Cuil], [Nombre], [Apellido], [Mail], [Password], [MiCarro], [TipoUsuario]) VALUES (1, 1, N'1', N'1', N'1', N'1', 1, 1)
INSERT [dbo].[Usuarios] ([UsuarioId], [Cuil], [Nombre], [Apellido], [Mail], [Password], [MiCarro], [TipoUsuario]) VALUES (3, 3, N'3', N'3', N'3', N'3', 3, 3)
INSERT [dbo].[Usuarios] ([UsuarioId], [Cuil], [Nombre], [Apellido], [Mail], [Password], [MiCarro], [TipoUsuario]) VALUES (2, 2, N'2', N'2', N'2', N'2', 2, 3)
INSERT [dbo].[Usuarios] ([UsuarioId], [Cuil], [Nombre], [Apellido], [Mail], [Password], [MiCarro], [TipoUsuario]) VALUES (4, 4, N'4', N'4', N'4', N'4', 0, 2)
GO
USE [master]
GO
ALTER DATABASE [comercio] SET  READ_WRITE 
GO
