/****** Object:  StoredProcedure [dbo].[TestSP]    Script Date: 8/23/2022 2:43:39 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TestSP]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TestSP]
GO
/****** Object:  StoredProcedure [dbo].[GetData]    Script Date: 8/23/2022 2:43:39 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetData]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetData]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 8/23/2022 2:43:39 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Item]') AND type in (N'U'))
DROP TABLE [dbo].[Item]
GO

/****** Object:  Table [dbo].[Item]    Script Date: 8/23/2022 2:43:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Item]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Item](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](256) NOT NULL,
	[Versioning] [timestamp] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Item] ON 

GO
INSERT [dbo].[Item] ([Id], [Name], [CreatedAt], [UpdatedAt]) VALUES (1, N'Item One', CAST(N'2020-06-17 21:52:19.957' AS DateTime), CAST(N'2022-03-07 16:29:04.087' AS DateTime))
GO
INSERT [dbo].[Item] ([Id], [Name], [CreatedAt], [UpdatedAt]) VALUES (2, N'Item TWO', CAST(N'2020-06-17 21:56:15.640' AS DateTime), CAST(N'2021-11-17 13:05:11.800' AS DateTime))
GO
INSERT [dbo].[Item] ([Id], [Name], [CreatedAt], [UpdatedAt]) VALUES (4, N'Item THREE', CAST(N'2020-09-09 00:00:00.000' AS DateTime), CAST(N'2021-11-17 13:05:11.800' AS DateTime))
GO
INSERT [dbo].[Item] ([Id], [Name], [CreatedAt], [UpdatedAt]) VALUES (5, N'Item FOUR', CAST(N'2020-01-01 00:00:00.000' AS DateTime), CAST(N'2021-11-17 13:05:11.800' AS DateTime))
GO
INSERT [dbo].[Item] ([Id], [Name], [CreatedAt], [UpdatedAt]) VALUES (6, N'Item One', CAST(N'2020-01-01 00:00:00.000' AS DateTime), CAST(N'2021-11-17 13:05:11.800' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Item] OFF
GO
/****** Object:  StoredProcedure [dbo].[GetData]    Script Date: 8/23/2022 2:43:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetData]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetData] AS' 
END
GO
ALTER proc [dbo].[GetData](
	@Var1 char(1) = 'N'
)
as
SELECT * FROM [dbo].[Item]
GO
/****** Object:  StoredProcedure [dbo].[TestSP]    Script Date: 8/23/2022 2:43:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TestSP]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TestSP] AS' 
END
GO


ALTER proc [dbo].[TestSP]
as
begin
select 1234
end
GO
