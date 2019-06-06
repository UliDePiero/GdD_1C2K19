DROP TABLE [PENSAMIENTO_LINEAL].[Rol_Usuario]
GO

DROP TABLE [PENSAMIENTO_LINEAL].[Rol_Funcion]
GO

DROP TABLE [PENSAMIENTO_LINEAL].[Rol]
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