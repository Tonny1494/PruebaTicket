USE [DB_Tickets]
GO
/****** Object:  Table [dbo].[Historial_Atencion]    Script Date: 25/7/2022 17:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historial_Atencion](
	[id_Historial] [int] NOT NULL,
	[fecha_Atencion] [datetime] NOT NULL,
	[coment_realizado] [nchar](30) NOT NULL,
 CONSTRAINT [PK_Historial_Atencion] PRIMARY KEY CLUSTERED 
(
	[id_Historial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 25/7/2022 17:56:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[id_Ticket] [int] NOT NULL,
	[persona_Sol] [nvarchar](50) NOT NULL,
	[asunto] [nchar](30) NOT NULL,
	[descrip_incidencia] [nchar](100) NOT NULL,
	[fecha_Ingreso] [datetime] NOT NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[id_Ticket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Historial_Atencion] ADD  CONSTRAINT [DF_Historial_Atencion_fecha_Atencion]  DEFAULT (getdate()) FOR [fecha_Atencion]
GO
ALTER TABLE [dbo].[Ticket] ADD  CONSTRAINT [DF_Ticket_fecha_Ingreso]  DEFAULT (getdate()) FOR [fecha_Ingreso]
GO
