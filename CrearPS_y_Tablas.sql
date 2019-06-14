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
	[usua_habilitado] [bit] NULL,
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
	[reco_habilitado] [bit] NULL,
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