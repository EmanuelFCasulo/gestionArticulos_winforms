use master
go
create database CATALOGO_DB
go
use CATALOGO_DB
go
USE [CATALOGO_DB]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[MARCAS](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[Descripcion] [varchar](50) NULL,
		CONSTRAINT [PK_MARCAS] PRIMARY KEY CLUSTERED ([Id] ASC)
		WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

USE [CATALOGO_DB]
GO

/****** Object:  Table [dbo].[CATEGORIAS]    Script Date: 08/09/2019 10:32:14 a.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CATEGORIAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_CATEGORIAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

USE [CATALOGO_DB]
GO

/****** Object:  Table [dbo].[ARTICULOS]    Script Date: 08/09/2019 10:32:24 a.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ARTICULOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](150) NULL,
	[IdMarca] [int] NULL,
	[IdCategoria] [int] NULL,
	[ImagenUrl] [varchar](1000) NULL,
	[Precio] [money] NULL,
 CONSTRAINT [PK_ARTICULOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

insert into MARCAS values ('Samsung'), ('Apple'), ('Sony'), ('Huawei'), ('Motorola')
insert into CATEGORIAS values ('Celulares'),('Televisores'), ('Media'), ('Audio')
insert into ARTICULOS values ('S01', 'Galaxy S10', 'Una canoa cara', 1, 1, 'https://images.samsung.com/is/image/samsung/co-galaxy-s10-sm-g970-sm-g970fzyjcoo-frontcanaryyellow-thumb-149016542', 69.999),
('M03', 'Moto G Play 7ma Gen', 'Ya siete de estos?', 1, 5, 'https://www.motorola.cl/arquivos/moto-g7-play-img-product.png?v=636862863804700000', 15699),
('S99', 'Play 4', 'Ya no se cuantas versiones hay', 3, 3, 'https://www.euronics.cz/image/product/800x800/532620.jpg', 35000),
('S56', 'Bravia 55', 'Alta tele', 3, 2, 'https://intercompras.com/product_thumb_keepratio_2.php?img=images/product/SONY_KDL-55W950A.jpg&w=650&h=450', 49500),
('A23', 'Apple TV', 'lindo loro', 2, 3, 'https://cnnespanol2.files.wordpress.com/2015/12/gadgets-mc3a1s-populares-apple-tv-2015-18.jpg?quality=100&strip=info&w=460&h=260&crop=1', 7850)

-- Querys post creacion de BD:
ALTER TABLE ARTICULOS ADD [Activo] [bit] default 1 NOT NULL

select * from ARTICULOS
select * from CATEGORIAS
select * from MARCAS
SELECT a.Codigo, c.Descripcion AS 'Categoria', m.Descripcion AS 'Marca', a.Nombre, a.Descripcion, a.Precio  FROM ARTICULOS a, MARCAS m, CATEGORIAS c WHERE a.IdMarca = m.Id AND a.IdCategoria = c.Id
SELECT a.Id, a.Codigo, c.Descripcion AS Categoria, c.Id AS IdCategoria, m.Id AS IdMarca, m.Descripcion AS Marca, a.Nombre, a.Descripcion, a.Precio, a.ImagenUrl FROM ARTICULOS a, MARCAS m, CATEGORIAS c WHERE a.IdMarca = m.Id AND a.IdCategoria = c.Id
SELECT a.Id, a.Codigo, c.Descripcion AS Categoria, c.Id AS IdCategoria, m.Id AS IdMarca, m.Descripcion AS Marca, a.Nombre, a.Descripcion, a.Precio, a.ImagenUrl FROM ARTICULOS a, MARCAS m, CATEGORIAS c WHERE a.IdMarca = m.Id AND a.IdCategoria = c.Id
INSERT INTO MARCAS VALUES ('AMD')
INSERT INTO MARCAS VALUES ('ANIME')

INSERT INTO CATEGORIAS VALUES ('Informatica')
INSERT INTO ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) VALUES ('R05','Asus Prime H510', 'Placa Madre', 6, 6, 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSeBm3a_tyI4Owzck6HPdPAYBjGyu5sg9u5xQ&usqp=CAU', 40000)
insert into ARTICULOS values ('S01', 'Galaxy S10', 'Una canoa cara', 1, 1, '', 69.999)
UPDATE ARTICULOS SET Codigo = 'R02', Nombre = 'Asus Pro G10', Descripcion = 'Placa Madre', IdMarca = 6, IdCategoria = 6, ImagenUrl = 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTykzhK2sbTQfp_5F2m28odQhV2afLik933uQ&usqp=CAU', Precio = 65000 WHERE Id = 15

-- ejemplos auxiliares:

SELECT a.Id, a.Codigo, a.IdCategoria, a.Activo, c.Descripcion as Categoria, a.IdMarca, m.Descripcion as Marca, a.Descripcion, a.Nombre, a.Precio, a.ImagenUrl FROM ARTICULOS a LEFT JOIN MARCAS m ON a.IdMarca = m.Id LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id WHERE c.Descripcion LIKE 'Televisores' AND m.Descripcion LIKE 'Sony' AND a.Precio < 100000
SELECT a.Id, a.Codigo, a.IdCategoria, c.Descripcion as Categoria, a.IdMarca, m.Descripcion as Marca, a.Descripcion, a.Nombre, a.Precio, a.ImagenUrl FROM ARTICULOS a LEFT JOIN MARCAS m ON a.IdMarca = m.Id LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id WHERE c.Descripcion LIKE 'Televisores' AND m.Descripcion LIKE 'Sony' AND a.Precio < 100000
SELECT a.Id, a.Codigo, a.IdCategoria, c.Descripcion as Categoria, a.IdMarca, m.Descripcion as Marca, a.Descripcion, a.Nombre, a.Precio, a.ImagenUrl FROM ARTICULOS a LEFT JOIN MARCAS m ON a.IdMarca = m.Id LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id WHERE c.Descripcion LIKE 'Celulares' AND m.Descripcion LIKE 'Samsung' AND a.Precio > 100
DELETE FROM CATEGORIAS WHERE Id = 5
--ALTER TABLE ARTICULOS DROP COLUMN [Activo]
--DROP TABLE ARTICULOS
SELECT a.Id, a.Codigo, a.IdCategoria, c.Descripcion as Categoria, a.IdMarca, m.Descripcion as Marca, a.Descripcion, a.Nombre, a.Precio, a.ImagenUrl FROM ARTICULOS a LEFT JOIN MARCAS m ON a.IdMarca = m.Id LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id

AlTER PROCEDURE SP_Listar AS
	 SELECT a.Id, a.Codigo, a.IdCategoria, a.Activo, c.Descripcion as Categoria, a.IdMarca, m.Descripcion as Marca, a.Descripcion, a.Nombre, a.Precio, a.ImagenUrl 
	 FROM ARTICULOS a LEFT JOIN MARCAS m ON a.IdMarca = m.Id LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id
EXEC SP_Listar
	--Tabla ARTICULOS:
	--[Id] [int] IDENTITY(1,1) NOT NULL,
	--[Codigo] [varchar](50) NULL,
	--[Nombre] [varchar](50) NULL,
	--[Descripcion] [varchar](150) NULL,
	--[IdMarca] [int] NULL,
	--[IdCategoria] [int] NULL,
	--[ImagenUrl] [varchar](1000) NULL,
	--[Precio] [money] NULL,
--
CREATE PROCEDURE SP_Agregar 
@Codigo varchar(50),
@Nombre varchar(50),
@Descripcion varchar(150),
@IdMarca int,
@IdCategoria int,
@ImagenUrl varchar(1000),
@Precio money
AS
INSERT INTO ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)
--
CREATE PROCEDURE SP_Modificar
@Codigo varchar(50),
@Nombre varchar(50),
@Descripcion varchar(150),
@IdMarca int,
@IdCategoria int,
@ImagenUrl varchar(1000),
@Precio money,
@Id int
AS
UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @precio 
WHERE Id = @Id
--
CREATE PROCEDURE SP_BajaLogica
@Id int
AS
UPDATE ARTICULOS SET Activo = 0
WHERE Id = @Id 
--
CREATE PROCEDURE SP_AltaLogica
@Id int
AS
UPDATE ARTICULOS SET Activo = 1
WHERE Id = @Id
--


SELECT a.Id, a.Codigo, a.IdCategoria, c.Descripcion as Categoria, a.IdMarca, m.Descripcion as Marca, a.Descripcion, a.Nombre, a.Precio, a.ImagenUrl FROM ARTICULOS a LEFT JOIN MARCAS m ON a.IdMarca = m.Id LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id WHERE c.Descripcion LIKE '%' AND m.Descripcion LIKE '%' --AND a.Precio > {fil}

SELECT a.Id, a.Codigo, a.IdCategoria, c.Descripcion as Categoria, a.IdMarca, m.Descripcion as Marca, a.Descripcion, a.Nombre, a.Precio, a.ImagenUrl FROM ARTICULOS a LEFT JOIN MARCAS m ON a.IdMarca = m.Id LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id WHERE c.Descripcion LIKE '%' AND m.Descripcion LIKE 'Apple' AND a.Precio > 0