use master
go
create database CATALOGO_P3_DB
go
use CATALOGO_P3_DB
go
USE CATALOGO_P3_DB
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
 CONSTRAINT [PK_MARCAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

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
	[Precio] [money] NULL,
 CONSTRAINT [PK_ARTICULOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

create table IMAGENES(
	Id int IDENTITY(1,1) not null,
	IdArticulo int not null,
	ImagenUrl varchar(1000) not null
)
go

insert into MARCAS values ('Samsung'), ('Apple'), ('Sony'), ('Huawei'), ('Motorola')
insert into CATEGORIAS values ('Celulares'),('Televisores'), ('Media'), ('Audio')
insert into ARTICULOS values ('S01', 'Galaxy S10', 'Una canoa cara', 1, 1, 69.999),
('M03', 'Moto G Play 7ma Gen', 'Ya siete de estos?', 5, 1, 15699),
('S99', 'Play 4', 'Ya no se cuantas versiones hay', 3, 3, 35000),
('S56', 'Bravia 55', 'Alta tele', 3, 2, 49500),
('A23', 'Apple TV', 'lindo loro', 2, 3, 7850)

insert into imagenes values
(1,'https://images.samsung.com/is/image/samsung/co-galaxy-s10-sm-g970-sm-g970fzyjcoo-frontcanaryyellow-thumb-149016542'),
(2, 'https://www.motorola.cl/arquivos/moto-g7-play-img-product.png?v=636862863804700000'),
(2, 'https://i.blogs.es/9da288/moto-g7-/1366_2000.jpg'),
(3, 'https://www.euronics.cz/image/product/800x800/532620.jpg'),
(4, 'https://intercompras.com/product_thumb_keepratio_2.php?img=images/product/SONY_KDL-55W950A.jpg&w=650&h=450'),
(5, 'https://cnnespanol2.files.wordpress.com/2015/12/gadgets-mc3a1s-populares-apple-tv-2015-18.jpg?quality=100&strip=info&w=460&h=260&crop=1')


------------------------- POST CREACION -----------------------------------

-- correccion de articulo mal cargado
UPDATE ARTICULOS SET IdCategoria = 1, IdMarca = 5 WHERE Id = 2

select * from CATEGORIAS
select * from MARCAS
select * from IMAGENES where Id = 13
select IdArticulo, ImagenUrl from IMAGENES
select * from IMAGENES where Id = 11
select * from IMAGENES
select * from ARTICULOS
GO

-- 

-- TODOS LOS ARTICULOS 
SELECT A.Id, Codigo, Nombre, A.Descripcion as Descripcion, M.Descripcion as Marca, M.Id as IdMarca, C.Descripcion as Categoria, C.Id as IdCategoria, Precio, I.ImagenUrl 
FROM ARTICULOS A INNER JOIN CATEGORIAS C on C.Id = A.IdCategoria 
INNER JOIN MARCAS M on M.Id = A.IdMarca LEFT JOIN IMAGENES I on I.IdArticulo = A.Id
select IdArticulo, ImagenUrl from IMAGENES
--exec sp_who2


SELECT A.Codigo, A.Nombre, A.Descripcion as Descripcion, M.Descripcion as Marcas, C.Descripcion as Categorias, A.Precio
FROM ARTICULOS A, MARCAS M, CATEGORIAS C
WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id

-- INSERT
INSERT INTO ARTICULOS VALUES ('AAA', 'A', 'a', '1', '1', 1)
INSERT INTO IMAGENES VALUES (1000,'‪E:\Imagenes\080.png')

-- UPDATE
UPDATE IMAGENES SET ImagenUrl = 'E:\Imagenes\080.png' WHERE Id = 1


-- DELETE

DELETE FROM IMAGENES 
DELETE FROM ARTICULOS
DELETE FROM CATEGORIAS WHERE Id > 5