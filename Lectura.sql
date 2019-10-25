USE [ConsumoElectricidad]
GO

/****** Object:  Table [dbo].[Lectura]    Script Date: 10/18/2018 07:37:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Lectura](
	[idLectura] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NULL,
	[consumo] [decimal](18, 0) NULL,
	[idUsuario] [int] NOT NULL,
 CONSTRAINT [PK_Lectura] PRIMARY KEY CLUSTERED 
(
	[idLectura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Lectura]  WITH CHECK ADD  CONSTRAINT [FK_Lectura_Usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO

ALTER TABLE [dbo].[Lectura] CHECK CONSTRAINT [FK_Lectura_Usuario]
GO


