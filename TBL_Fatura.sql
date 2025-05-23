USE [WinForm]
GO

/****** Object:  Table [dbo].[TBL_FATURALAR]    Script Date: 11/09/2014 01:30:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TBL_FATURALAR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FATURATURU] [nvarchar](25) NULL,
	[FATURASERI] [nvarchar](5) NULL,
	[FATURANO] [nvarchar](15) NULL,
	[IRSALIYEID] [int] NULL,
	[CARIKODU] [nvarchar](30) NULL,
	[TARIHI] [datetime] NULL,
	[ACIKLAMA] [text] NULL,
	[GENELTOPLAM] [decimal](18, 2) NULL,
	[ODEMEYERI] [nvarchar](10) NULL,
	[ODEMEYERIID] [int] NULL,
	[SAVEUSER] [int] NULL,
	[SAVEDATE] [datetime] NULL,
	[EDITUSER] [int] NULL,
	[EDITDATE] [datetime] NULL,
 CONSTRAINT [PK_TBLFATURALAR] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

