/*
 Navicat Premium Data Transfer

 Source Server         : local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : .\SQLEXPRESS:1433
 Source Catalog        : ferreteriadb
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 01/10/2024 08:52:43
*/


-- ----------------------------
-- Table structure for Categorias
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Categorias]') AND type IN ('U'))
	DROP TABLE [dbo].[Categorias]
GO

CREATE TABLE [dbo].[Categorias] (
  [Idcategoria] int  IDENTITY(1,1) NOT NULL,
  [Nombre] varchar(255) COLLATE Modern_Spanish_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Categorias] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Categorias
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Categorias] ON
GO

INSERT INTO [dbo].[Categorias] ([Idcategoria], [Nombre]) VALUES (N'1', N'Hola')
GO

SET IDENTITY_INSERT [dbo].[Categorias] OFF
GO


-- ----------------------------
-- Table structure for Cliente
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Cliente]') AND type IN ('U'))
	DROP TABLE [dbo].[Cliente]
GO

CREATE TABLE [dbo].[Cliente] (
  [Idcliente] int  IDENTITY(1,1) NOT NULL,
  [Nombre] varchar(255) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [Apellido] varchar(255) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [Telefono] varchar(20) COLLATE Modern_Spanish_CI_AS  NULL,
  [Direccion] varchar(255) COLLATE Modern_Spanish_CI_AS  NULL,
  [Dui] varchar(15) COLLATE Modern_Spanish_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Cliente] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Cliente
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Cliente] ON
GO

INSERT INTO [dbo].[Cliente] ([Idcliente], [Nombre], [Apellido], [Telefono], [Direccion], [Dui]) VALUES (N'1', N'Hola', N'Juan', N'74784874', N'485445454', N'holi')
GO

SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO


-- ----------------------------
-- Table structure for Marca
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Marca]') AND type IN ('U'))
	DROP TABLE [dbo].[Marca]
GO

CREATE TABLE [dbo].[Marca] (
  [Idmarca] int  IDENTITY(1,1) NOT NULL,
  [Nombre] varchar(255) COLLATE Modern_Spanish_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Marca] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Marca
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Marca] ON
GO

INSERT INTO [dbo].[Marca] ([Idmarca], [Nombre]) VALUES (N'1', N'Hola')
GO

SET IDENTITY_INSERT [dbo].[Marca] OFF
GO


-- ----------------------------
-- Table structure for Movimientos
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Movimientos]') AND type IN ('U'))
	DROP TABLE [dbo].[Movimientos]
GO

CREATE TABLE [dbo].[Movimientos] (
  [IdMovimiento] int  IDENTITY(1,1) NOT NULL,
  [Fecha] datetime  NOT NULL,
  [Tipo] varchar(255) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [Producto] int  NOT NULL,
  [Cantidad] int  NOT NULL
)
GO

ALTER TABLE [dbo].[Movimientos] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Movimientos
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Movimientos] ON
GO

INSERT INTO [dbo].[Movimientos] ([IdMovimiento], [Fecha], [Tipo], [Producto], [Cantidad]) VALUES (N'1', N'2024-09-30 09:20:54.637', N'1', N'1', N'10')
GO

SET IDENTITY_INSERT [dbo].[Movimientos] OFF
GO


-- ----------------------------
-- Table structure for Productos
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Productos]') AND type IN ('U'))
	DROP TABLE [dbo].[Productos]
GO

CREATE TABLE [dbo].[Productos] (
  [IdProducto] int  IDENTITY(1,1) NOT NULL,
  [Marca] int  NULL,
  [Categoria] int  NULL,
  [Detalles] text COLLATE Modern_Spanish_CI_AS  NULL,
  [Precioventa] float(53)  NOT NULL,
  [Existencias] int  NOT NULL,
  [Imagen] varchar(255) COLLATE Modern_Spanish_CI_AS  NULL,
  [Codigobarra] varchar(16) COLLATE Modern_Spanish_CI_AS  NULL,
  [Nombre] varchar(255) COLLATE Modern_Spanish_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Productos] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Productos
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Productos] ON
GO

INSERT INTO [dbo].[Productos] ([IdProducto], [Marca], [Categoria], [Detalles], [Precioventa], [Existencias], [Imagen], [Codigobarra], [Nombre]) VALUES (N'1', N'1', N'1', N'asdasd', N'1', N'10', N'elfinde584.png', N'66163176', N'elfinde')
GO

SET IDENTITY_INSERT [dbo].[Productos] OFF
GO


-- ----------------------------
-- Table structure for VentaCabecera
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[VentaCabecera]') AND type IN ('U'))
	DROP TABLE [dbo].[VentaCabecera]
GO

CREATE TABLE [dbo].[VentaCabecera] (
  [Idventa] int  IDENTITY(1,1) NOT NULL,
  [Idcliente] int  NULL,
  [Fecha] date  NOT NULL
)
GO

ALTER TABLE [dbo].[VentaCabecera] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of VentaCabecera
-- ----------------------------
SET IDENTITY_INSERT [dbo].[VentaCabecera] ON
GO

SET IDENTITY_INSERT [dbo].[VentaCabecera] OFF
GO


-- ----------------------------
-- Table structure for Ventaprodutos
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Ventaprodutos]') AND type IN ('U'))
	DROP TABLE [dbo].[Ventaprodutos]
GO

CREATE TABLE [dbo].[Ventaprodutos] (
  [Idventapd] int  IDENTITY(1,1) NOT NULL,
  [Idventa] int  NULL,
  [Idproducto] int  NULL,
  [Preciounitario] float(53)  NOT NULL,
  [Cantidad] int  NOT NULL
)
GO

ALTER TABLE [dbo].[Ventaprodutos] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Ventaprodutos
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Ventaprodutos] ON
GO

SET IDENTITY_INSERT [dbo].[Ventaprodutos] OFF
GO


-- ----------------------------
-- Auto increment value for Categorias
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Categorias]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table Categorias
-- ----------------------------
ALTER TABLE [dbo].[Categorias] ADD CONSTRAINT [PK__Categori__ED5D47BC80187543] PRIMARY KEY CLUSTERED ([Idcategoria])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Cliente
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Cliente]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table Cliente
-- ----------------------------
ALTER TABLE [dbo].[Cliente] ADD CONSTRAINT [PK__Cliente__0D87C4E14B4C3B5D] PRIMARY KEY CLUSTERED ([Idcliente])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Marca
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Marca]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table Marca
-- ----------------------------
ALTER TABLE [dbo].[Marca] ADD CONSTRAINT [PK__Marca__D13ED1D48A27008A] PRIMARY KEY CLUSTERED ([Idmarca])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Movimientos
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Movimientos]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table Movimientos
-- ----------------------------
ALTER TABLE [dbo].[Movimientos] ADD CONSTRAINT [PK__Movimien__881A6AE02A8278C7] PRIMARY KEY CLUSTERED ([IdMovimiento])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Productos
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Productos]', RESEED, 2)
GO


-- ----------------------------
-- Primary Key structure for table Productos
-- ----------------------------
ALTER TABLE [dbo].[Productos] ADD CONSTRAINT [PK__Producto__09889210B467F9D2] PRIMARY KEY CLUSTERED ([IdProducto])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for VentaCabecera
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[VentaCabecera]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table VentaCabecera
-- ----------------------------
ALTER TABLE [dbo].[VentaCabecera] ADD CONSTRAINT [PK__VentaCab__AF5FD380B3778BB8] PRIMARY KEY CLUSTERED ([Idventa])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Ventaprodutos
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Ventaprodutos]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table Ventaprodutos
-- ----------------------------
ALTER TABLE [dbo].[Ventaprodutos] ADD CONSTRAINT [PK__Ventapro__5B4A68B039F9B69C] PRIMARY KEY CLUSTERED ([Idventapd])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table Movimientos
-- ----------------------------
ALTER TABLE [dbo].[Movimientos] ADD CONSTRAINT [FK_movimientos_producto] FOREIGN KEY ([Producto]) REFERENCES [dbo].[Productos] ([IdProducto]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Productos
-- ----------------------------
ALTER TABLE [dbo].[Productos] ADD CONSTRAINT [FK__Productos__Marca__4F7CD00D] FOREIGN KEY ([Marca]) REFERENCES [dbo].[Marca] ([Idmarca]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Productos] ADD CONSTRAINT [FK__Productos__Categ__5070F446] FOREIGN KEY ([Categoria]) REFERENCES [dbo].[Categorias] ([Idcategoria]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table VentaCabecera
-- ----------------------------
ALTER TABLE [dbo].[VentaCabecera] ADD CONSTRAINT [FK__VentaCabe__Idcli__534D60F1] FOREIGN KEY ([Idcliente]) REFERENCES [dbo].[Cliente] ([Idcliente]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Ventaprodutos
-- ----------------------------
ALTER TABLE [dbo].[Ventaprodutos] ADD CONSTRAINT [FK__Ventaprod__Idven__5629CD9C] FOREIGN KEY ([Idventa]) REFERENCES [dbo].[VentaCabecera] ([Idventa]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Ventaprodutos] ADD CONSTRAINT [FK__Ventaprod__Idpro__571DF1D5] FOREIGN KEY ([Idproducto]) REFERENCES [dbo].[Productos] ([IdProducto]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

