USE [Inventory]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 15-09-2020 23:22:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Items](
	[Ino] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[IDescription] [varchar](50) NULL,
	[Price] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ino] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([Ino], [Name], [IDescription], [Price]) VALUES (3, N'Pen', N'This is cello pen', 110)
SET IDENTITY_INSERT [dbo].[Items] OFF
