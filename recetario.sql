USE [recetario]
GO
/****** Object:  Table [dbo].[menu]    Script Date: 17/05/2022 1:01:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menu](
	[cod_menu] [int] IDENTITY(1,1) NOT NULL,
	[cod_receta] [int] NOT NULL,
	[plato_menu] [varchar](50) NOT NULL,
	[precio_menu] [decimal](18, 2) NOT NULL,
	[comentario_menu] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_menu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[plato]    Script Date: 17/05/2022 1:01:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[plato](
	[cod_plato] [int] IDENTITY(1,1) NOT NULL,
	[cod_receta] [int] NOT NULL,
	[tipo_plato] [varchar](50) NOT NULL,
	[ingredientes_principal_plato] [varchar](100) NOT NULL,
	[precio_plato] [decimal](18, 2) NOT NULL,
	[comentario_adicional_plato] [varchar](100) NOT NULL,
	[nombre_plato] [varchar](100) NOT NULL,
	[calorias_plato] [varchar](100) NOT NULL,
	[cant_util_ing_por_plato] [decimal](5, 2) NOT NULL,
	[unidad_medida_por_plato] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_plato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[receta]    Script Date: 17/05/2022 1:01:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[receta](
	[cod_receta] [int] IDENTITY(1,1) NOT NULL,
	[fuente_receta] [varchar](100) NOT NULL,
	[ubicacion_fisica_receta] [varchar](100) NOT NULL,
	[lista_ingredientes_receta] [varchar](100) NOT NULL,
	[tiempo_ejecucion_receta] [time](7) NOT NULL,
	[utensilios_receta] [varchar](100) NOT NULL,
	[comentario_receta] [varchar](100) NOT NULL,
	[tiempo_receta] [time](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_receta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[menu]  WITH CHECK ADD  CONSTRAINT [fk_receta_menu] FOREIGN KEY([cod_receta])
REFERENCES [dbo].[receta] ([cod_receta])
GO
ALTER TABLE [dbo].[menu] CHECK CONSTRAINT [fk_receta_menu]
GO
ALTER TABLE [dbo].[plato]  WITH CHECK ADD  CONSTRAINT [fk_receta_plato] FOREIGN KEY([cod_receta])
REFERENCES [dbo].[receta] ([cod_receta])
GO
ALTER TABLE [dbo].[plato] CHECK CONSTRAINT [fk_receta_plato]
GO
/****** Object:  StoredProcedure [dbo].[agregar_menu]    Script Date: 17/05/2022 1:01:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[agregar_menu]
@cod_receta INT,
@plato_menu VARCHAR(50),
@precio_menu DECIMAL(18, 2),
@comentario_menu VARCHAR(100)
AS
INSERT INTO menu(
cod_receta,
plato_menu,
precio_menu,
comentario_menu
)
VALUES 
(
@cod_receta,
@plato_menu,
@precio_menu,
@comentario_menu
);
GO
/****** Object:  StoredProcedure [dbo].[agregar_plato]    Script Date: 17/05/2022 1:01:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[agregar_plato]
@cod_receta INT,
@tipo_plato VARCHAR(50),
@ingredientes_principal_plato VARCHAR(100),
@precio_plato DECIMAL(18, 2),
@comentario_adicional_plato VARCHAR(100),
@nombre_plato VARCHAR(100),
@calorias_plato VARCHAR(100),
@cant_util_ing_por_plato DECIMAL(5, 2),
@unidad_medida_por_plato VARCHAR(100)
AS
INSERT INTO plato(
cod_receta,
tipo_plato,
ingredientes_principal_plato,
precio_plato,
comentario_adicional_plato,
nombre_plato,
calorias_plato,
cant_util_ing_por_plato,
unidad_medida_por_plato
)
VALUES 
(
@cod_receta,
@tipo_plato,
@ingredientes_principal_plato,
@precio_plato,
@comentario_adicional_plato,
@nombre_plato,
@calorias_plato,
@cant_util_ing_por_plato,
@unidad_medida_por_plato
);
GO
/****** Object:  StoredProcedure [dbo].[agregar_receta]    Script Date: 17/05/2022 1:01:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[agregar_receta]
@fuente_receta VARCHAR(100), 
@ubicacion_fisica_receta VARCHAR(100), 
@lista_ingredientes_receta VARCHAR(100), 
@tiempo_ejecucion_receta TIME, 
@utensilios_receta VARCHAR(100), 
@comentario_receta VARCHAR(100), 
@tiempo_receta TIME
AS
INSERT INTO receta(
fuente_receta, 
ubicacion_fisica_receta, 
lista_ingredientes_receta, 
tiempo_ejecucion_receta, 
utensilios_receta, 
comentario_receta, 
tiempo_receta
)
VALUES 
(
@fuente_receta, 
@ubicacion_fisica_receta, 
@lista_ingredientes_receta, 
@tiempo_ejecucion_receta, 
@utensilios_receta, 
@comentario_receta, 
@tiempo_receta
);
GO
/****** Object:  StoredProcedure [dbo].[consultar_menu]    Script Date: 17/05/2022 1:01:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[consultar_menu]
@cod_menu INT
AS
SELECT * from menu
WHERE cod_menu = @cod_menu;
GO
/****** Object:  StoredProcedure [dbo].[consultar_plato]    Script Date: 17/05/2022 1:01:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[consultar_plato]
@cod_plato INT
AS
SELECT * from plato
WHERE cod_plato = @cod_plato;
GO
/****** Object:  StoredProcedure [dbo].[consultar_receta]    Script Date: 17/05/2022 1:01:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[consultar_receta]
@cod_receta INT
AS
SELECT * from receta
WHERE cod_receta = @cod_receta;

GO
/****** Object:  StoredProcedure [dbo].[delete_menu]    Script Date: 17/05/2022 1:01:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[delete_menu]
@cod_menu INT
AS
DELETE FROM menu
WHERE cod_menu = @cod_menu;
GO
/****** Object:  StoredProcedure [dbo].[delete_plato]    Script Date: 17/05/2022 1:01:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[delete_plato]
@cod_plato INT
AS
DELETE FROM plato
WHERE cod_plato = @cod_plato;
GO
/****** Object:  StoredProcedure [dbo].[delete_receta]    Script Date: 17/05/2022 1:01:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[delete_receta]
@cod_receta INT
AS
DELETE FROM receta
WHERE cod_receta = @cod_receta;
GO
/****** Object:  StoredProcedure [dbo].[update_menu]    Script Date: 17/05/2022 1:01:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[update_menu]
@cod_menu INT,
@cod_receta INT,
@plato_menu VARCHAR(50),
@precio_menu DECIMAL(18, 2),
@comentario_menu VARCHAR(100)
AS
UPDATE menu SET
cod_receta = @cod_receta,
plato_menu = @plato_menu,
precio_menu = @precio_menu,
comentario_menu = @comentario_menu
WHERE cod_menu = @cod_menu;
GO
/****** Object:  StoredProcedure [dbo].[update_plato]    Script Date: 17/05/2022 1:01:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[update_plato]
@cod_plato INT,
@cod_receta INT,
@tipo_plato VARCHAR(50),
@ingredientes_principal_plato VARCHAR(100),
@precio_plato DECIMAL(18, 2),
@comentario_adicional_plato VARCHAR(100),
@nombre_plato VARCHAR(100),
@calorias_plato VARCHAR(100),
@cant_util_ing_por_plato DECIMAL(5, 2),
@unidad_medida_por_plato VARCHAR(100)
AS
UPDATE plato SET
cod_receta = @cod_receta,
tipo_plato = @tipo_plato,
ingredientes_principal_plato = @ingredientes_principal_plato,
precio_plato = @precio_plato,
comentario_adicional_plato = @comentario_adicional_plato,
nombre_plato = @nombre_plato,
calorias_plato = @calorias_plato,
cant_util_ing_por_plato = @cant_util_ing_por_plato,
unidad_medida_por_plato = @unidad_medida_por_plato
WHERE cod_plato = @cod_plato;
GO
/****** Object:  StoredProcedure [dbo].[update_receta]    Script Date: 17/05/2022 1:01:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[update_receta]
@cod_receta INT, 
@fuente_receta VARCHAR(100), 
@ubicacion_fisica_receta VARCHAR(100), 
@lista_ingredientes_receta VARCHAR(100), 
@tiempo_ejecucion_receta TIME, 
@utensilios_receta VARCHAR(100), 
@comentario_receta VARCHAR(100), 
@tiempo_receta TIME
AS
UPDATE receta SET
fuente_receta = @fuente_receta, 
ubicacion_fisica_receta = @ubicacion_fisica_receta, 
lista_ingredientes_receta = @lista_ingredientes_receta, 
tiempo_ejecucion_receta = @tiempo_ejecucion_receta, 
utensilios_receta = @utensilios_receta, 
comentario_receta = @comentario_receta, 
tiempo_receta = @tiempo_receta 
WHERE cod_receta = @cod_receta;
GO
