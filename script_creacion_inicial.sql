USE [GD1C2019]
GO

CREATE SCHEMA PENSAMIENTO_LINEAL
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [PENSAMIENTO_LINEAL].[Rol](
	[rol_id] [int] IDENTITY(1,1) NOT NULL,
	[rol_nombre] [nchar](50) NOT NULL,
	[rol_habilitado] [bit] NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[rol_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [PENSAMIENTO_LINEAL].[Funcionalidad](
	[func_id] [int] IDENTITY(1,1) NOT NULL,
	[func_nombre] [char](50) NOT NULL,
 CONSTRAINT [PK_Funcionalidad] PRIMARY KEY CLUSTERED 
(
	[func_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [PENSAMIENTO_LINEAL].[Rol_Funcion](
	[rol_func_rolid] [int] NOT NULL,
	[rol_func_funcid] [int] NOT NULL
) ON [PRIMARY]

GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Rol_Funcion]  WITH CHECK ADD  CONSTRAINT [FK_Rol_Funcion_Funcionalidadid] FOREIGN KEY([rol_func_funcid])
REFERENCES [PENSAMIENTO_LINEAL].[Funcionalidad] ([func_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Rol_Funcion] CHECK CONSTRAINT [FK_Rol_Funcion_Funcionalidadid]
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Rol_Funcion]  WITH CHECK ADD  CONSTRAINT [FK_Rol_Funcion_Rolid] FOREIGN KEY([rol_func_rolid])
REFERENCES [PENSAMIENTO_LINEAL].[Rol] ([rol_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Rol_Funcion] CHECK CONSTRAINT [FK_Rol_Funcion_Rolid]
GO

CREATE TABLE [PENSAMIENTO_LINEAL].[Usuario](
	[usua_id] [int] IDENTITY(1,1) NOT NULL,
	[usua_nombre] [char](50) NOT NULL,
	[usua_apellido] [char](50) NOT NULL,
	[usua_direccion] [char](100) NOT NULL,
	[usua_mail] [char](100) NOT NULL,
	[usua_username] [char](100) NULL,
	[usua_password] [char](100) NULL,
	[usua_telefono] [char](40) NOT NULL,
	[usua_documento] [char](20) NOT NULL,
	[usua_fechanac] [smalldatetime] NOT NULL,
	[usua_habilitado] [bit] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[usua_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [PENSAMIENTO_LINEAL].[Rol_Usuario](
	[rol_usuario_usuarioid] [int] NOT NULL,
	[rol_usuario_rolid] [int] NOT NULL
) ON [PRIMARY]

GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Rol_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Rol_Usuario_rolid] FOREIGN KEY([rol_usuario_rolid])
REFERENCES [PENSAMIENTO_LINEAL].[Rol] ([rol_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Rol_Usuario] CHECK CONSTRAINT [FK_Rol_Usuario_rolid]
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Rol_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Rol_Usuario_usuarioid] FOREIGN KEY([rol_usuario_usuarioid])
REFERENCES [PENSAMIENTO_LINEAL].[usuario] ([usua_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Rol_Usuario] CHECK CONSTRAINT [FK_Rol_Usuario_usuarioid]
GO

CREATE TABLE [PENSAMIENTO_LINEAL].[Marca](
	[marc_id] [int] IDENTITY(1,1) NOT NULL,
	[marc_nombre] [char](50) NOT NULL,
 CONSTRAINT [PK_Marca] PRIMARY KEY CLUSTERED 
(
	[marc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [PENSAMIENTO_LINEAL].[Modelo](
	[mode_id] [int] IDENTITY(1,1) NOT NULL,
	[mode_nombre] [char](20) NOT NULL,
 CONSTRAINT [PK_Modelo] PRIMARY KEY CLUSTERED 
(
	[mode_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


CREATE TABLE [PENSAMIENTO_LINEAL].[Crucero](
	[cruc_id] [int] IDENTITY(1,1) NOT NULL,
	[cruc_identificador] [char](40) NOT NULL,
	[cruc_marca] [int] NOT NULL,
	[cruc_modelo] [int] NOT NULL,
	[cruc_bajadef] [smalldatetime] NULL,
 CONSTRAINT [PK_Crucero] PRIMARY KEY CLUSTERED 
(
	[cruc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Crucero]  WITH CHECK ADD  CONSTRAINT [FK_Crucero_Marcaid] FOREIGN KEY([cruc_marca])
REFERENCES [PENSAMIENTO_LINEAL].[Marca] ([marc_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Crucero] CHECK CONSTRAINT [FK_Crucero_Marcaid]
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Crucero]  WITH CHECK ADD  CONSTRAINT [FK_Crucero_Modeloid] FOREIGN KEY([cruc_modelo])
REFERENCES [PENSAMIENTO_LINEAL].[Modelo] ([mode_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Crucero] CHECK CONSTRAINT [FK_Crucero_Modeloid]
GO


CREATE TABLE [PENSAMIENTO_LINEAL].[Estado_crucero](
	[esta_id] [int] IDENTITY(1,1) NOT NULL,
	[esta_desc] [char](10) NOT NULL,
	[esta_fechabaja] [smalldatetime] NOT NULL,
	[esta_fechaalta] [smalldatetime] NULL,
	[esta_crucero] [int] NOT NULL,
 CONSTRAINT [PK_Estado_crucero] PRIMARY KEY CLUSTERED 
(
	[esta_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Estado_crucero]  WITH CHECK ADD  CONSTRAINT [FK_Estado_crucero_CruceroId] FOREIGN KEY([esta_crucero])
REFERENCES [PENSAMIENTO_LINEAL].[Crucero] ([cruc_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Estado_crucero] CHECK CONSTRAINT [FK_Estado_crucero_CruceroId]
GO

CREATE TABLE [PENSAMIENTO_LINEAL].[Servicio](
	[serv_id] [int] IDENTITY(1,1) NOT NULL,
	[serv_desc] [char](50) NOT NULL,
 CONSTRAINT [PK_Servicio] PRIMARY KEY CLUSTERED 
(
	[serv_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [PENSAMIENTO_LINEAL].[Crucero_Servicio](
	[cruc_serv_crucid] [int] NOT NULL,
	[cruc_serv_servid] [int] NOT NULL
) ON [PRIMARY]

GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Crucero_Servicio]  WITH NOCHECK ADD  CONSTRAINT [FK_Crucero_Servicio_crucid] FOREIGN KEY([cruc_serv_crucid])
REFERENCES [PENSAMIENTO_LINEAL].[Crucero] ([cruc_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Crucero_Servicio] CHECK CONSTRAINT [FK_Crucero_Servicio_crucid]
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Crucero_Servicio]  WITH CHECK ADD  CONSTRAINT [FK_Crucero_Servicio_servid] FOREIGN KEY([cruc_serv_servid])
REFERENCES [PENSAMIENTO_LINEAL].[Servicio] ([serv_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Crucero_Servicio] CHECK CONSTRAINT [FK_Crucero_Servicio_servid]
GO



CREATE TABLE [PENSAMIENTO_LINEAL].[Tipo_cabina](
	[tipo_id] [int] IDENTITY(1,1) NOT NULL,
	[tipo_nombre] [char](20) NOT NULL,
	[tipo_porc_rec] [numeric](4,2) NOT NULL,
 CONSTRAINT [PK_Tipo_cabina] PRIMARY KEY CLUSTERED 
(
	[tipo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [PENSAMIENTO_LINEAL].[Cabina](
	[cabi_id] [int] IDENTITY(1,1) NOT NULL,
	[cabi_piso] [numeric](2, 0) NOT NULL,
	[cabi_numero] [numeric](5, 0) NOT NULL,
	[cabi_crucero] [int] NOT NULL,
	[cabi_tipo] [int] NOT NULL,
 CONSTRAINT [PK_Cabina] PRIMARY KEY CLUSTERED 
(
	[cabi_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Cabina]  WITH CHECK ADD  CONSTRAINT [FK_Cabina_Tipo_cabinaId] FOREIGN KEY([cabi_tipo])
REFERENCES [PENSAMIENTO_LINEAL].[Tipo_cabina] ([tipo_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Cabina] CHECK CONSTRAINT [FK_Cabina_Tipo_cabinaId]
GO

CREATE TABLE [PENSAMIENTO_LINEAL].[Puerto](
	[puer_id] [int] IDENTITY(1,1) NOT NULL,
	[puer_nombre] [char](20) NOT NULL,
 CONSTRAINT [PK_Puerto] PRIMARY KEY CLUSTERED 
(
	[puer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [PENSAMIENTO_LINEAL].[Tramo](
	[tram_id] [int] IDENTITY(1,1) NOT NULL,
	[tram_precio] [numeric](8, 4) NOT NULL,
	[tram_duracion] [numeric](8, 4) NOT NULL,
	[tram_origen] [int] NOT NULL,
	[tram_destino] [int] NOT NULL,
 CONSTRAINT [PK_Tramo] PRIMARY KEY CLUSTERED 
(
	[tram_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Tramo]  WITH CHECK ADD  CONSTRAINT [FK_Tramo_PuertoDestino] FOREIGN KEY([tram_destino])
REFERENCES [PENSAMIENTO_LINEAL].[Puerto] ([puer_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Tramo] CHECK CONSTRAINT [FK_Tramo_PuertoDestino]
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Tramo]  WITH CHECK ADD  CONSTRAINT [FK_Tramo_PuertoOrigen] FOREIGN KEY([tram_origen])
REFERENCES [PENSAMIENTO_LINEAL].[Puerto] ([puer_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Tramo] CHECK CONSTRAINT [FK_Tramo_PuertoOrigen]
GO

CREATE TABLE [PENSAMIENTO_LINEAL].[Recorrido](
	[reco_id] [int] IDENTITY(1,1) NOT NULL,
	[reco_codigo] [char](20) NOT NULL,
	[reco_primertramo] [int] NOT NULL,
	[reco_habilitado] [bit] NOT NULL,
 CONSTRAINT [PK_Recorrido] PRIMARY KEY CLUSTERED 
(
	[reco_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Recorrido]  WITH CHECK ADD  CONSTRAINT [FK_Recorrido_PrimerTramo] FOREIGN KEY([reco_primertramo])
REFERENCES [PENSAMIENTO_LINEAL].[Tramo] ([tram_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Recorrido] CHECK CONSTRAINT [FK_Recorrido_PrimerTramo]
GO

CREATE TABLE [PENSAMIENTO_LINEAL].[Recorrido_tramo](
	[reco_tram_recoid] [int] NOT NULL,
	[reco_tram_tramid] [int] NOT NULL
) ON [PRIMARY]

GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Recorrido_tramo]  WITH CHECK ADD  CONSTRAINT [FK_Recorrido_tramo_recoid] FOREIGN KEY([reco_tram_recoid])
REFERENCES [PENSAMIENTO_LINEAL].[Recorrido] ([reco_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Recorrido_tramo] CHECK CONSTRAINT [FK_Recorrido_tramo_recoid]
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Recorrido_tramo]  WITH CHECK ADD  CONSTRAINT [FK_Recorrido_tramo_tramid] FOREIGN KEY([reco_tram_tramid])
REFERENCES [PENSAMIENTO_LINEAL].[Tramo] ([tram_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Recorrido_tramo] CHECK CONSTRAINT [FK_Recorrido_tramo_tramid]
GO

CREATE TABLE [PENSAMIENTO_LINEAL].[Recorrido_crucero](
	[reco_cruc_id] [int] IDENTITY(1,1) NOT NULL,
	[reco_cruc_recoid] [int] NOT NULL,
	[reco_cruc_crucid] [int] NOT NULL,
	[reco_cruc_salida] [smalldatetime] NOT NULL,
	[reco_cruc_llegada_real] [smalldatetime] NULL
CONSTRAINT [PK_Recorrido_crucero] PRIMARY KEY CLUSTERED 
(
	[reco_cruc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Recorrido_crucero]  WITH CHECK ADD  CONSTRAINT [FK_Reco_Cruc_cruc_id] FOREIGN KEY([reco_cruc_crucid])
REFERENCES [PENSAMIENTO_LINEAL].[Crucero] ([cruc_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Recorrido_crucero] CHECK CONSTRAINT [FK_Reco_Cruc_cruc_id]
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Recorrido_crucero]  WITH CHECK ADD  CONSTRAINT [FK_Reco_Cruc_recoid] FOREIGN KEY([reco_cruc_recoid])
REFERENCES [PENSAMIENTO_LINEAL].[Recorrido] ([reco_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Recorrido_crucero] CHECK CONSTRAINT [FK_Reco_Cruc_recoid]
GO

CREATE TABLE [PENSAMIENTO_LINEAL].[Pasaje](
	[pasa_id] [int] IDENTITY(1,1) NOT NULL,
	[pasa_codigo] [char](50) NOT NULL,
	[pasa_fecha] [smalldatetime] NOT NULL,
	[pasa_precio] [numeric](8, 4) NOT NULL,
	[pasa_viaje] [int] NOT NULL,
	[pasa_cliente] [int] NOT NULL,
	[pasa_cabina] [int] NOT NULL,
CONSTRAINT [PK_Pasaje] PRIMARY KEY CLUSTERED 
(
	[pasa_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Pasaje]  WITH CHECK ADD  CONSTRAINT [FK_Pasaje_Cabina] FOREIGN KEY([pasa_cabina])
REFERENCES [PENSAMIENTO_LINEAL].[Cabina] ([cabi_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Pasaje] CHECK CONSTRAINT [FK_Pasaje_Cabina]
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Pasaje]  WITH CHECK ADD  CONSTRAINT [FK_Pasaje_Cliente] FOREIGN KEY([pasa_cliente])
REFERENCES [PENSAMIENTO_LINEAL].[usuario] ([usua_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Pasaje] CHECK CONSTRAINT [FK_Pasaje_Cliente]
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Pasaje]  WITH CHECK ADD  CONSTRAINT [FK_Pasaje_Recorrido_Crucero] FOREIGN KEY([pasa_viaje])
REFERENCES [PENSAMIENTO_LINEAL].[Recorrido_crucero] ([reco_cruc_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Pasaje] CHECK CONSTRAINT [FK_Pasaje_Recorrido_Crucero]
GO


CREATE TABLE [PENSAMIENTO_LINEAL].[Reserva](
	[rese_id] [int] IDENTITY(1,1) NOT NULL,
	[rese_codigo] [char](50) NOT NULL,
	[rese_fecha] [smalldatetime] NOT NULL,
	[rese_cliente] [int] NOT NULL,
	[rese_viaje] [int] NOT NULL,
	[rese_cabina] [int] NOT NULL,
CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[rese_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Cabina] FOREIGN KEY([rese_cabina])
REFERENCES [PENSAMIENTO_LINEAL].[Cabina] ([cabi_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Reserva] CHECK CONSTRAINT [FK_Reserva_Cabina]
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Cliente] FOREIGN KEY([rese_cliente])
REFERENCES [PENSAMIENTO_LINEAL].[usuario] ([usua_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Reserva] CHECK CONSTRAINT [FK_Reserva_Cliente]
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Recorrido_crucero] FOREIGN KEY([rese_viaje])
REFERENCES [PENSAMIENTO_LINEAL].[Recorrido_crucero] ([reco_cruc_id])
GO

ALTER TABLE [PENSAMIENTO_LINEAL].[Reserva] CHECK CONSTRAINT [FK_Reserva_Recorrido_crucero]
GO


CREATE TABLE [PENSAMIENTO_LINEAL].[Cancelaciones_log](
	[canc_log_id] [int] IDENTITY(1,1) NOT NULL,
	[canc_log_desc] [char](20) NOT NULL,
	[canc_log_codigo] [char](40) NOT NULL,
	[canc_log_usuario_nombre] [char](50) NOT NULL,
	[canc_log_usuario_doc] [char](20) NOT NULL,
 CONSTRAINT [PK_Cancelaciones_log] PRIMARY KEY CLUSTERED 
(
	[canc_log_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE PROCEDURE PENSAMIENTO_LINEAL.MigrarDB
AS
INSERT INTO PENSAMIENTO_LINEAL.Marca (marc_nombre)
SELECT  CRU_FABRICANTE 
from gd_esquema.Maestra 
group by CRU_FABRICANTE

INSERT INTO PENSAMIENTO_LINEAL.Modelo (mode_nombre)
select CRUCERO_MODELO 
from gd_esquema.Maestra 
group by crucero_modelo 
order by CRUCERO_MODELO;

INSERT INTO PENSAMIENTO_LINEAL.Tipo_Cabina (tipo_nombre, tipo_porc_rec)
select cabina_tipo, cabina_tipo_porc_recargo 
from gd_esquema.Maestra 
group by CABINA_TIPO, CABINA_TIPO_PORC_RECARGO

INSERT INTO PENSAMIENTO_LINEAL.Puerto (puer_nombre)
select puerto_desde 
from gd_esquema.Maestra 
group by puerto_desde

INSERT INTO PENSAMIENTO_LINEAL.Usuario (usua_nombre,usua_apellido,usua_documento,usua_direccion,usua_telefono,usua_mail,usua_fechanac,usua_habilitado)
select cli_nombre, cli_apellido, cli_dni, cli_direccion, cli_telefono, cli_mail, cli_fecha_nac, 1
from gd_esquema.Maestra 
group by cli_nombre, cli_apellido, cli_dni, cli_direccion, cli_telefono, cli_mail, cli_fecha_nac 

INSERT INTO PENSAMIENTO_LINEAL.Crucero (cruc_identificador,cruc_marca,cruc_modelo)
select a.crucero_identificador, b.marc_id, c.mode_id 
from gd_esquema.Maestra a 
join PENSAMIENTO_LINEAL.Marca b on a.CRU_FABRICANTE=b.marc_nombre 
join PENSAMIENTO_LINEAL.Modelo c on a.CRUCERO_MODELO=c.mode_nombre 
group by a.crucero_identificador,b.marc_id, c.mode_id

INSERT INTO PENSAMIENTO_LINEAL.Cabina (cabi_piso,cabi_numero,cabi_crucero,cabi_tipo)
select a.cabina_piso, a.CABINA_NRO, b.cruc_id, c.tipo_id 
from gd_esquema.Maestra a 
join PENSAMIENTO_LINEAL.Marca d on d.marc_nombre = a.CRU_FABRICANTE
join PENSAMIENTO_LINEAL.Crucero b on b.cruc_marca = d.marc_id and b.cruc_identificador=a.CRUCERO_IDENTIFICADOR
join PENSAMIENTO_LINEAL.Tipo_cabina c on c.tipo_nombre = a.CABINA_TIPO
group by a.cabina_piso, a.CABINA_NRO, b.cruc_id, c.tipo_id 
order by b.cruc_id, a.cabina_piso, a.CABINA_NRO

INSERT INTO PENSAMIENTO_LINEAL.Tramo (tram_origen,tram_destino,tram_precio,tram_duracion)
select distinct a.puer_id, b.puer_id, c.recorrido_precio_base, DATEDIFF(hour, c.FECHA_SALIDA, c.FECHA_LLEGADA_ESTIMADA) 
from pensamiento_lineal.puerto a 
join gd_esquema.maestra c on a.puer_nombre=c.puerto_desde 
join pensamiento_lineal.puerto b on b.puer_nombre=c.puerto_hasta 
group by a.puer_id, b.puer_id, c.recorrido_precio_base, c.FECHA_SALIDA, c.FECHA_LLEGADA_ESTIMADA, c.RECORRIDO_PRECIO_BASE, c.recorrido_precio_base
order by a.puer_id, b.puer_id

INSERT INTO PENSAMIENTO_LINEAL.Recorrido (reco_codigo,reco_primertramo,reco_habilitado)
select a.recorrido_codigo,b.tram_id,1
from gd_esquema.Maestra a 
join pensamiento_lineal.puerto c on c.puer_nombre=a.puerto_desde
join pensamiento_lineal.puerto d on d.puer_nombre=a.puerto_hasta
join PENSAMIENTO_LINEAL.Tramo b on c.puer_id=b.tram_origen and d.puer_id=b.tram_destino
group by a.recorrido_codigo, b.tram_id, a.recorrido_precio_base

INSERT INTO PENSAMIENTO_LINEAL.Recorrido_tramo (reco_tram_recoid,reco_tram_tramid)
select e.reco_id,b.tram_id
from gd_esquema.Maestra a 
join pensamiento_lineal.puerto c on c.puer_nombre=a.puerto_desde
join pensamiento_lineal.puerto d on d.puer_nombre=a.puerto_hasta
join PENSAMIENTO_LINEAL.Tramo b on c.puer_id=b.tram_origen and d.puer_id=b.tram_destino
join PENSAMIENTO_LINEAL.Recorrido e on e.reco_primertramo=b.tram_id
group by e.reco_id, b.tram_id

INSERT INTO PENSAMIENTO_LINEAL.Recorrido_crucero (reco_cruc_recoid,reco_cruc_crucid,reco_cruc_salida,reco_cruc_llegada_real)
select b.reco_id, c.cruc_id, a.FECHA_SALIDA, a.FECHA_LLEGADA
from PENSAMIENTO_LINEAL.recorrido b
join PENSAMIENTO_LINEAL.tramo d on b.reco_primertramo=d.tram_id
join PENSAMIENTO_LINEAL.puerto e on d.tram_origen=e.puer_id
join PENSAMIENTO_LINEAL.puerto f on d.tram_destino=f.puer_id
join gd_esquema.Maestra a on e.puer_nombre=a.PUERTO_DESDE and f.puer_nombre=a.PUERTO_HASTA
join PENSAMIENTO_LINEAL.Crucero c on c.cruc_identificador=a.CRUCERO_IDENTIFICADOR
group by b.reco_id, c.cruc_id, a.FECHA_SALIDA,a.FECHA_LLEGADA_ESTIMADA, a.FECHA_LLEGADA

INSERT INTO PENSAMIENTO_LINEAL.Pasaje (pasa_codigo,pasa_fecha,pasa_precio,pasa_cliente,pasa_viaje,pasa_cabina)
select a.PASAJE_CODIGO,a.PASAJE_FECHA_COMPRA,a.PASAJE_PRECIO, c.usua_id,j.reco_cruc_id,h.cabi_id
from gd_esquema.Maestra a
join PENSAMIENTO_LINEAL.Crucero d on d.cruc_identificador=CRUCERO_IDENTIFICADOR
join PENSAMIENTO_LINEAL.Usuario c on c.usua_apellido=a.CLI_APELLIDO and c.usua_nombre=a.CLI_NOMBRE and c.usua_documento=a.CLI_DNI
join PENSAMIENTO_LINEAL.Recorrido e on e.reco_codigo=a.RECORRIDO_CODIGO
join PENSAMIENTO_LINEAL.Tramo f on f.tram_id=e.reco_primertramo
join PENSAMIENTO_LINEAL.Puerto i on i.puer_id=f.tram_origen and i.puer_nombre=a.PUERTO_DESDE
join PENSAMIENTO_LINEAL.Cabina h on h.cabi_numero = a.CABINA_NRO and h.cabi_piso=a.CABINA_PISO and h.cabi_crucero=d.cruc_id
join PENSAMIENTO_LINEAL.Recorrido_crucero j on j.reco_cruc_recoid = e.reco_id and j.reco_cruc_crucid = d.cruc_id and j.reco_cruc_salida=a.FECHA_SALIDA
where RESERVA_CODIGO is null
group by a.PASAJE_CODIGO,a.PASAJE_FECHA_COMPRA,a.PASAJE_PRECIO,c.usua_id,d.cruc_id,e.reco_id,j.reco_cruc_id,h.cabi_id

INSERT INTO PENSAMIENTO_LINEAL.Reserva (rese_codigo,rese_fecha,rese_cliente,rese_viaje,rese_cabina)
select a.RESERVA_CODIGO,a.RESERVA_FECHA, c.usua_id,j.reco_cruc_crucid,h.cabi_id
from gd_esquema.Maestra a
join PENSAMIENTO_LINEAL.Crucero d on d.cruc_identificador=CRUCERO_IDENTIFICADOR
join PENSAMIENTO_LINEAL.Usuario c on c.usua_apellido=a.CLI_APELLIDO and c.usua_nombre=a.CLI_NOMBRE and c.usua_documento=a.CLI_DNI
join PENSAMIENTO_LINEAL.Recorrido e on e.reco_codigo=a.RECORRIDO_CODIGO
join PENSAMIENTO_LINEAL.Tramo f on f.tram_id=e.reco_primertramo
join PENSAMIENTO_LINEAL.Puerto i on i.puer_id=f.tram_origen and i.puer_nombre=a.PUERTO_DESDE
join PENSAMIENTO_LINEAL.Cabina h on h.cabi_numero = a.CABINA_NRO and h.cabi_piso=a.CABINA_PISO and h.cabi_crucero=d.cruc_id
join PENSAMIENTO_LINEAL.Recorrido_crucero j on j.reco_cruc_recoid = e.reco_id and j.reco_cruc_crucid = d.cruc_id and j.reco_cruc_salida=a.FECHA_SALIDA
where PASAJE_CODIGO is null
group by a.RESERVA_CODIGO,a.RESERVA_FECHA, c.usua_id,d.cruc_id,e.reco_id,h.cabi_id,j.reco_cruc_crucid

GO
exec PENSAMIENTO_LINEAL.MigrarDB
GO

create function PENSAMIENTO_LINEAL.diasFuera (@anio numeric(5), @semestre varchar(8), @fechabaja DateTime, @fechaalta DateTime)
returns numeric(10)
as
begin
	declare @retorno numeric(10)
	declare @cambioDeSemestre DateTime

	set @retorno = DATEDIFF(day, @fechabaja, @fechaalta)
	set @cambioDeSemestre = DATEFROMPARTS(@anio, 6, 30)

	if (@semestre = '<= 6' AND (@fechaalta > @cambioDeSemestre))
		set @retorno = DATEDIFF(day, @fechabaja, @cambioDeSemestre)
	else if (@semestre = '> 6' and (@fechabaja < @cambioDeSemestre))
		set @retorno = DATEDIFF(day, @cambioDeSemestre, @fechaalta)

	return @retorno
end

GO
CREATE function PENSAMIENTO_LINEAL.Estado(@crucero int,@fecha smallDateTime)
returns bit
as
begin

if (Not Exists(select * from PENSAMIENTO_LINEAL.Estado_crucero where @crucero = esta_crucero) and NOT EXISTS (select cruc_bajadef from PENSAMIENTO_LINEAL.Crucero where @crucero = cruc_id and cruc_bajadef = NULL))
	return 1
if (Not Exists(select * from PENSAMIENTO_LINEAL.Estado_crucero where @crucero = esta_crucero and esta_fechabaja<@fecha) and NOT EXISTS (select cruc_bajadef from PENSAMIENTO_LINEAL.Crucero where @crucero = cruc_id and cruc_bajadef = NULL))
	return 1
Declare @fecha2 smallDateTime = (select Top 1 esta_fechaalta from PENSAMIENTO_LINEAL.Estado_crucero where esta_crucero= @crucero order by esta_fechaalta DESC)
if(@fecha2<@fecha)
	return 1
return 0
end
GO
CREATE Procedure PENSAMIENTO_LINEAL.PasarViajesCruceros (@crucero int)
as
begin
Declare @Marca int = (select Top 1 cruc_marca from PENSAMIENTO_LINEAL.Crucero where cruc_id=@crucero)
Declare @Modelo int = (select Top 1 cruc_modelo from PENSAMIENTO_LINEAL.Crucero where cruc_id=@crucero)
Declare @cabinas table (TipoCab int, Cant int)
insert Into @cabinas
select cabi_tipo, COUNT(cabi_id) from PENSAMIENTO_LINEAL.Cabina where cabi_crucero=@crucero group by cabi_tipo


declare @prueba int = (select Top 1 Cant from @cabinas)
print @prueba

declare viajes cursor LOCAL for select reco_cruc_crucid, reco_cruc_recoid, reco_cruc_salida, reco_cruc_id from PENSAMIENTO_LINEAL.Recorrido_crucero where reco_cruc_crucid=@crucero
declare @Cruc_ID int
declare @Reco_ID int
declare @Viaje_ID int
declare @Salida smallDateTime

open viajes
fetch Next from viajes Into @cruc_ID,@Reco_ID,@Salida,@Viaje_ID
while (@@FETCH_STATUS = 0)
begin
	declare @Tiempo int = (select Count(tram_duracion) from PENSAMIENTO_LINEAL.Recorrido_tramo join PENSAMIENTO_LINEAL.Tramo on (reco_tram_tramid = tram_id) where reco_tram_recoid = @Reco_ID)
	declare @Llegada smallDateTime = DateAdd(HOUR,@Tiempo,@Salida)

	declare Cruceros cursor for select DISTINCT(cruc_id)
	from PENSAMIENTO_LINEAL.Crucero                                                                                      
	where cruc_id <> @crucero and (cruc_marca = @Marca and cruc_modelo = @Modelo and 
	cruc_id NOT IN (SELECT reco_cruc_crucid FROM PENSAMIENTO_LINEAL.Recorrido_crucero) OR 
	cruc_id NOT IN (SELECT DISTINCT(reco_cruc_crucid) FROM PENSAMIENTO_LINEAL.Recorrido_crucero WHERE CONVERT(datetime,@Llegada,131) > reco_cruc_salida AND CONVERT(datetime, @Salida, 131) < reco_cruc_llegada_real))
	open Cruceros
	Declare @cruz int
	fetch Next from Cruceros into @cruz
	while (@@FETCH_STATUS = 0)
	begin
		Declare @cabinas2 table (TipoCab2 int, Cant2 int)
		insert Into @cabinas2
		select cabi_tipo, COUNT(cabi_id) from PENSAMIENTO_LINEAL.Cabina where cabi_crucero=@cruz group by cabi_tipo
		Declare @diff table (diff int)
		insert @diff
		select (Cant2 - Cant) from @cabinas2 Join @cabinas on (TipoCab = TipoCab2)
		delete @cabinas2
		if(Not Exists(select * from @diff where diff <> 0))
		begin
			declare @Pasajes table (IDPasaje int, IDCabina int, TipoCabina int)
			insert into @Pasajes
			select pasa_id, cabi_id, cabi_tipo from PENSAMIENTO_LINEAL.Pasaje join PENSAMIENTO_LINEAL.Cabina on (pasa_cabina=cabi_id) where @Viaje_ID = pasa_viaje
			declare @pasaCant int = (select COUNT(*) from @Pasajes)
			print @pasaCant
			declare cabinas cursor for (select cabi_id, cabi_tipo from PENSAMIENTO_LINEAL.Cabina where cabi_crucero = @cruz)
			declare @cab int
			declare @Tipe int
			open cabinas
			fetch Next from cabinas Into @cab, @Tipe
			while (@@FETCH_STATUS = 0 or not Exists(select * from @Pasajes))
				begin
					declare @pas int = (select Top 1 IDPAsaje from @Pasajes where @Tipe = TIpoCabina)
					declare @cabin int = (select Top 1 IDCabina from @Pasajes where @Tipe = TIpoCabina)
					update PENSAMIENTO_LINEAL.Pasaje
					Set pasa_cabina = @cabin
					where pasa_id = @pas
					delete @Pasajes
					where IDPasaje = @pas
					fetch Next from cabinas into @cab, @Tipe
				end
				close cabinas
				deallocate cabinas
				
			update PENSAMIENTO_LINEAL.Recorrido_crucero
			Set reco_cruc_crucid = @cruz
			where @Viaje_ID = reco_cruc_id
			
		end
		fetch Next from Cruceros into @cruz
	end
	close Cruceros
	deallocate Cruceros
	fetch Next from viajes Into @cruc_ID,@Reco_ID,@Salida,@Viaje_ID
end
close viajes
deallocate viajes
end
GO
CREATE procedure PENSAMIENTO_LINEAL.BorrarReservasViejas
as
begin
	delete PENSAMIENTO_LINEAL.Reserva
	where abs(DateDiff(Day,rese_fecha,GetDate()))>3
end
GO
CREATE Procedure PENSAMIENTO_LINEAL.RetrasarCrucero (@crucero int, @Baja smallDateTime, @Alta smallDateTime)
as
begin
	Declare @diff int = abs(DateDiff(DAY,@Baja,@Alta))
	update PENSAMIENTO_LINEAL.Recorrido_crucero
	Set reco_cruc_salida= DATEADD(DAY,@diff,reco_cruc_salida),reco_cruc_llegada_real=DATEADD(DAY,@diff,reco_cruc_llegada_real)
	where reco_cruc_crucid=@crucero and reco_cruc_salida>@Baja
end
GO
CREATE function PENSAMIENTO_LINEAL.CodificarSha256(@contra varchar)
returns binary(32)
as
begin
return (HASHBYTES('SHA2_256',@contra))
end

GO
CREATE trigger PENSAMIENTO_LINEAL.CodificarContrasenia
on PENSAMIENTO_LINEAL.Usuario
instead of insert
as
begin
insert into PENSAMIENTO_LINEAL.Usuario
select usua_nombre,usua_apellido,usua_direccion,usua_mail,usua_username,PENSAMIENTO_LINEAL.CodificarSha256(usua_password),usua_telefono,usua_documento,usua_fechanac, usua_habilitado
from inserted
where usua_username IS NOT NULL
end

GO
CREATE Procedure PENSAMIENTO_LINEAL.chasquearDedos (@puerto int)
as
begin
Declare @Todo table (tramo int,reco int,recoCruc int) 
Insert into @Todo
select tram_id, reco_id, reco_cruc_id
from PENSAMIENTO_LINEAL.Tramo LEFT join 
	 PENSAMIENTO_LINEAL.Recorrido_tramo on (reco_tram_tramid = tram_id) LEFT join
	 PENSAMIENTO_LINEAL.Recorrido on (reco_tram_recoid= reco_id or reco_primertramo = tram_id) LEFT join
	 PENSAMIENTO_LINEAL.Recorrido_crucero on (reco_cruc_recoid = reco_id)
	 where @puerto = tram_destino OR @puerto = tram_origen
	 
Declare @tramos table (tramo int)
insert @tramos select distinct tramo from @Todo
Declare @recorridos table (reco int)
insert @recorridos select distinct reco from @Todo
Declare @viaje table (recoCruc int)
insert @viaje select distinct recoCruc from @Todo



delete PENSAMIENTO_LINEAL.Reserva
from @viaje
where rese_viaje = recoCruc
delete PENSAMIENTO_LINEAL.Pasaje
from @viaje
where pasa_viaje = recoCruc
delete PENSAMIENTO_LINEAL.Recorrido_crucero
from @viaje
where reco_cruc_id = recoCruc
delete PENSAMIENTO_LINEAL.Recorrido
from @recorridos
where reco_id = reco
delete PENSAMIENTO_LINEAL.Recorrido_tramo
from @tramos
where reco_tram_tramid = tramo
delete PENSAMIENTO_LINEAL.Tramo
from @tramos
where tram_id = tramo
delete PENSAMIENTO_LINEAL.Puerto
where @puerto = puer_id
end

GO

insert into PENSAMIENTO_LINEAL.Rol(rol_nombre,rol_habilitado)
values ('Cliente',1)

insert into PENSAMIENTO_LINEAL.Funcionalidad(func_nombre)
values ('Reserva de pasaje')

insert into PENSAMIENTO_LINEAL.Funcionalidad(func_nombre)
values ('Pago de pasajes')

insert into PENSAMIENTO_LINEAL.Rol(rol_nombre,rol_habilitado)
values ('Administrador General',1)

insert into PENSAMIENTO_LINEAL.Funcionalidad(func_nombre)
values ('ABM Crucero')

insert into PENSAMIENTO_LINEAL.Funcionalidad(func_nombre)
values ('ABM Puerto')

insert into PENSAMIENTO_LINEAL.Funcionalidad(func_nombre)
values ('ABM Recorrido')

insert into PENSAMIENTO_LINEAL.Funcionalidad(func_nombre)
values ('ABM Rol')

insert into PENSAMIENTO_LINEAL.Funcionalidad(func_nombre)
values ('Listado Estadístico')

insert into PENSAMIENTO_LINEAL.Funcionalidad(func_nombre)
values ('Generar Viaje')

insert into PENSAMIENTO_LINEAL.Rol_Funcion(rol_func_rolid,rol_func_funcid)
values(1,1)

insert into PENSAMIENTO_LINEAL.Rol_Funcion(rol_func_rolid,rol_func_funcid)
values(1,2)

insert into PENSAMIENTO_LINEAL.Rol_Funcion(rol_func_rolid,rol_func_funcid)
values(2,1)

insert into PENSAMIENTO_LINEAL.Rol_Funcion(rol_func_rolid,rol_func_funcid)
values(2,2)

insert into PENSAMIENTO_LINEAL.Rol_Funcion(rol_func_rolid,rol_func_funcid)
values(2,3)

insert into PENSAMIENTO_LINEAL.Rol_Funcion(rol_func_rolid,rol_func_funcid)
values(2,4)

insert into PENSAMIENTO_LINEAL.Rol_Funcion(rol_func_rolid,rol_func_funcid)
values(2,5)

insert into PENSAMIENTO_LINEAL.Rol_Funcion(rol_func_rolid,rol_func_funcid)
values(2,6)

insert into PENSAMIENTO_LINEAL.Rol_Funcion(rol_func_rolid,rol_func_funcid)
values(2,7)

insert into PENSAMIENTO_LINEAL.Rol_Funcion(rol_func_rolid,rol_func_funcid)
values(2,8)

insert into PENSAMIENTO_LINEAL.Servicio(serv_desc)
values('Pileta')

insert into PENSAMIENTO_LINEAL.Servicio(serv_desc)
values('Teatro')

insert into PENSAMIENTO_LINEAL.Servicio(serv_desc)
values('Cine')

insert into PENSAMIENTO_LINEAL.Servicio(serv_desc)
values('Restaurant tematico')

insert into PENSAMIENTO_LINEAL.Servicio(serv_desc)
values('Tobogan de agua')

insert into PENSAMIENTO_LINEAL.Servicio(serv_desc)
values('Spa')

insert into PENSAMIENTO_LINEAL.Usuario (usua_nombre,usua_apellido,usua_direccion,usua_mail,usua_username,usua_password,usua_telefono,usua_documento,usua_fechanac,usua_habilitado)
Values ('Admin','Admin','casa Admin','admin@admin.com','Admin','w23e','1511111111','40404404','1999-12-12 23:59:59',1);

insert into PENSAMIENTO_LINEAL.Rol_Usuario(rol_usuario_usuarioid,rol_usuario_rolid)
select usua_id,2
from PENSAMIENTO_LINEAL.Usuario
where usua_username = 'admin'
