USE [CDocumentos]
GO

/****** Object:  Table [dbo].[Documento]    Script Date: 5/1/2021 5:36:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Documento](
	[DocumentoId] [int] IDENTITY(1,1) NOT NULL,
	[Ano] [date] NOT NULL,
	[DepartamentoOrigen] [varchar](50) NOT NULL,
	[DepartamentoDestino] [varchar](50) NOT NULL,
	[Secuencia] [int] NOT NULL,
	[NombreDocumento] [varchar](50) NULL,
	[FechaCreacionDocumento] [date] NOT NULL,
 CONSTRAINT [PK_Documento] PRIMARY KEY CLUSTERED 
(
	[DocumentoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

