USE [NaproKartaDBv2]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 2018-01-12 11:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 2018-01-12 11:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 2018-01-12 11:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 2018-01-12 11:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 2018-01-12 11:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Charts]    Script Date: 2018-01-12 11:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Charts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NULL,
	[Title] [nvarchar](max) NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Charts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CipherCds]    Script Date: 2018-01-12 11:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CipherCds](
	[Id] [int] NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.CipherCds] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ciphers]    Script Date: 2018-01-12 11:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciphers](
	[Id] [int] NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Ciphers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Comments]    Script Date: 2018-01-12 11:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Comments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cycles]    Script Date: 2018-01-12 11:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cycles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ChartId] [int] NOT NULL,
	[NumberInChart] [nvarchar](max) NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Cycles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Letters]    Script Date: 2018-01-12 11:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Letters](
	[Id] [int] NOT NULL,
	[Value] [nvarchar](3) NULL,
 CONSTRAINT [PK_dbo.Letters] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Markers]    Script Date: 2018-01-12 11:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Markers](
	[Id] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.Markers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NumTimes]    Script Date: 2018-01-12 11:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NumTimes](
	[Id] [int] NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.NumTimes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ObservationNotes]    Script Date: 2018-01-12 11:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ObservationNotes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](max) NULL,
	[IsImportant] [bit] NOT NULL,
	[ObservationId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.ObservationNotes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Observations]    Script Date: 2018-01-12 11:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Observations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CycleId] [int] NOT NULL,
	[NumberInCycle] [int] NOT NULL,
	[MarkerId] [nvarchar](128) NULL,
	[Date] [datetime] NOT NULL,
	[LetterId] [int] NOT NULL,
	[IsB] [bit] NOT NULL,
	[NumTimeId] [int] NOT NULL,
	[CipherId] [int] NOT NULL,
	[CommentId] [int] NULL,
	[CipherCdId] [int] NOT NULL,
	[PeakDayNumber] [int] NULL,
 CONSTRAINT [PK_dbo.Observations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'16741705-3ec6-467f-a48c-a5d1c5db1e13', N'asd@asd.asd', 0, N'ABDWIT44/4JR+FkTVe290LaS94gP2NxSaA/OzKgFPcRxBnWqZxQjC0zYLfZ5MQJqGQ==', N'8d603811-3eaf-427f-a593-9acf4ccf5b4a', NULL, 0, 0, NULL, 1, 0, N'asd@asd.asd')
GO
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'440a6217-3fcc-460f-b1e9-381a53b87037', N'zxc@zxc.zxc', 0, N'AFpcfXhLVXDCczkwF1Ujtskah9qkaICO42dwNdoYdBD8n8lxyXXe1rLTMNJAcBrWZw==', N'195380ea-7d1c-4b92-802c-25bacbc3dec9', NULL, 0, 0, NULL, 1, 0, N'zxc@zxc.zxc')
GO
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'66f3feb6-418e-4079-9895-0417d1ba71da', N'qwe@qwe.qwe', 0, N'AxhSqhbqZ/XN/KBSxdlHgTiUxVgF82JdQ6UEnBP6Ezl81+YtY5XpYHjfBsyllA==', N'5336c8c8-f523-489d-8bb0-bad384c6c4d5', NULL, 0, 0, NULL, 1, 0, N'qwe@qwe.qwe')
GO
SET IDENTITY_INSERT [dbo].[Charts] ON 

GO
INSERT [dbo].[Charts] ([Id], [UserId], [Title], [Note]) VALUES (3, N'16741705-3ec6-467f-a48c-a5d1c5db1e13', N'chart111', N'chartnote11')
GO
INSERT [dbo].[Charts] ([Id], [UserId], [Title], [Note]) VALUES (4, N'16741705-3ec6-467f-a48c-a5d1c5db1e13', N'chart222', N'chartnote22')
GO
INSERT [dbo].[Charts] ([Id], [UserId], [Title], [Note]) VALUES (1003, N'440a6217-3fcc-460f-b1e9-381a53b87037', N'chart333', N'chartnote33')
GO
INSERT [dbo].[Charts] ([Id], [UserId], [Title], [Note]) VALUES (1004, N'16741705-3ec6-467f-a48c-a5d1c5db1e13', N'chart44', N'chartnote44')
GO
INSERT [dbo].[Charts] ([Id], [UserId], [Title], [Note]) VALUES (1007, N'16741705-3ec6-467f-a48c-a5d1c5db1e13', N'Karta nr 5', N'n555')
GO
INSERT [dbo].[Charts] ([Id], [UserId], [Title], [Note]) VALUES (1008, N'16741705-3ec6-467f-a48c-a5d1c5db1e13', N'Karta nr 6', N'n6')
GO
INSERT [dbo].[Charts] ([Id], [UserId], [Title], [Note]) VALUES (1009, N'16741705-3ec6-467f-a48c-a5d1c5db1e13', N'Karta nr 7', N'n7')
GO
SET IDENTITY_INSERT [dbo].[Charts] OFF
GO
INSERT [dbo].[CipherCds] ([Id], [Value]) VALUES (1, N'"P"')
GO
INSERT [dbo].[CipherCds] ([Id], [Value]) VALUES (2, N'B')
GO
INSERT [dbo].[CipherCds] ([Id], [Value]) VALUES (3, N'C')
GO
INSERT [dbo].[CipherCds] ([Id], [Value]) VALUES (4, N'C/K')
GO
INSERT [dbo].[CipherCds] ([Id], [Value]) VALUES (5, N'G')
GO
INSERT [dbo].[CipherCds] ([Id], [Value]) VALUES (6, N'L')
GO
INSERT [dbo].[CipherCds] ([Id], [Value]) VALUES (7, N'P')
GO
INSERT [dbo].[CipherCds] ([Id], [Value]) VALUES (8, N'Y')
GO
INSERT [dbo].[Ciphers] ([Id], [Value]) VALUES (1, N'0')
GO
INSERT [dbo].[Ciphers] ([Id], [Value]) VALUES (2, N'10')
GO
INSERT [dbo].[Ciphers] ([Id], [Value]) VALUES (3, N'10DL')
GO
INSERT [dbo].[Ciphers] ([Id], [Value]) VALUES (4, N'10SL')
GO
INSERT [dbo].[Ciphers] ([Id], [Value]) VALUES (5, N'10WL')
GO
INSERT [dbo].[Ciphers] ([Id], [Value]) VALUES (6, N'2')
GO
INSERT [dbo].[Ciphers] ([Id], [Value]) VALUES (7, N'2W')
GO
INSERT [dbo].[Ciphers] ([Id], [Value]) VALUES (8, N'4')
GO
INSERT [dbo].[Ciphers] ([Id], [Value]) VALUES (9, N'6')
GO
INSERT [dbo].[Ciphers] ([Id], [Value]) VALUES (10, N'8')
GO
SET IDENTITY_INSERT [dbo].[Comments] ON 

GO
INSERT [dbo].[Comments] ([Id], [Content]) VALUES (1, N'Badania')
GO
INSERT [dbo].[Comments] ([Id], [Content]) VALUES (2, N'Wizyta')
GO
INSERT [dbo].[Comments] ([Id], [Content]) VALUES (3, N'ILupucupu')
GO
SET IDENTITY_INSERT [dbo].[Comments] OFF
GO
SET IDENTITY_INSERT [dbo].[Cycles] ON 

GO
INSERT [dbo].[Cycles] ([Id], [ChartId], [NumberInChart], [Note]) VALUES (1, 3, N'0', N'n1')
GO
INSERT [dbo].[Cycles] ([Id], [ChartId], [NumberInChart], [Note]) VALUES (4, 4, N'0', N'n1')
GO
SET IDENTITY_INSERT [dbo].[Cycles] OFF
GO
INSERT [dbo].[Letters] ([Id], [Value]) VALUES (1, N'H')
GO
INSERT [dbo].[Letters] ([Id], [Value]) VALUES (2, N'L')
GO
INSERT [dbo].[Letters] ([Id], [Value]) VALUES (3, N'M')
GO
INSERT [dbo].[Letters] ([Id], [Value]) VALUES (4, N'VL')
GO
INSERT [dbo].[Letters] ([Id], [Value]) VALUES (5, N'VVL')
GO
INSERT [dbo].[Markers] ([Id]) VALUES (N'confused')
GO
INSERT [dbo].[Markers] ([Id]) VALUES (N'green')
GO
INSERT [dbo].[Markers] ([Id]) VALUES (N'greenbaby')
GO
INSERT [dbo].[Markers] ([Id]) VALUES (N'none')
GO
INSERT [dbo].[Markers] ([Id]) VALUES (N'red')
GO
INSERT [dbo].[Markers] ([Id]) VALUES (N'whitebaby')
GO
INSERT [dbo].[Markers] ([Id]) VALUES (N'yellow')
GO
INSERT [dbo].[Markers] ([Id]) VALUES (N'yellowbaby')
GO
INSERT [dbo].[NumTimes] ([Id], [Value]) VALUES (1, N'AD')
GO
INSERT [dbo].[NumTimes] ([Id], [Value]) VALUES (2, N'X1')
GO
INSERT [dbo].[NumTimes] ([Id], [Value]) VALUES (3, N'X2')
GO
INSERT [dbo].[NumTimes] ([Id], [Value]) VALUES (4, N'X3')
GO
SET IDENTITY_INSERT [dbo].[ObservationNotes] ON 

GO
INSERT [dbo].[ObservationNotes] ([Id], [Content], [IsImportant], [ObservationId]) VALUES (2, N'n2', 0, 3)
GO
INSERT [dbo].[ObservationNotes] ([Id], [Content], [IsImportant], [ObservationId]) VALUES (4, N'n4', 0, 3)
GO
INSERT [dbo].[ObservationNotes] ([Id], [Content], [IsImportant], [ObservationId]) VALUES (5, N'n5', 1, 3)
GO
SET IDENTITY_INSERT [dbo].[ObservationNotes] OFF
GO
SET IDENTITY_INSERT [dbo].[Observations] ON 

GO
INSERT [dbo].[Observations] ([Id], [CycleId], [NumberInCycle], [MarkerId], [Date], [LetterId], [IsB], [NumTimeId], [CipherId], [CommentId], [CipherCdId], [PeakDayNumber]) VALUES (3, 1, 1, N'red', CAST(0x0000A84800000000 AS DateTime), 1, 1, 1, 1, 1, 1, NULL)
GO
INSERT [dbo].[Observations] ([Id], [CycleId], [NumberInCycle], [MarkerId], [Date], [LetterId], [IsB], [NumTimeId], [CipherId], [CommentId], [CipherCdId], [PeakDayNumber]) VALUES (4, 1, 2, N'red', CAST(0x0000A85A00000000 AS DateTime), 1, 1, 3, 1, 1, 1, NULL)
GO
INSERT [dbo].[Observations] ([Id], [CycleId], [NumberInCycle], [MarkerId], [Date], [LetterId], [IsB], [NumTimeId], [CipherId], [CommentId], [CipherCdId], [PeakDayNumber]) VALUES (5, 1, 3, N'red', CAST(0x0000A83B00000000 AS DateTime), 2, 0, 2, 2, 2, 2, NULL)
GO
INSERT [dbo].[Observations] ([Id], [CycleId], [NumberInCycle], [MarkerId], [Date], [LetterId], [IsB], [NumTimeId], [CipherId], [CommentId], [CipherCdId], [PeakDayNumber]) VALUES (23, 4, 0, N'red', CAST(0x0000A84800000000 AS DateTime), 5, 0, 4, 2, 1, 4, NULL)
GO
INSERT [dbo].[Observations] ([Id], [CycleId], [NumberInCycle], [MarkerId], [Date], [LetterId], [IsB], [NumTimeId], [CipherId], [CommentId], [CipherCdId], [PeakDayNumber]) VALUES (24, 4, 2, N'red', CAST(0x0000A85A00000000 AS DateTime), 4, 0, 2, 3, 1, 3, NULL)
GO
INSERT [dbo].[Observations] ([Id], [CycleId], [NumberInCycle], [MarkerId], [Date], [LetterId], [IsB], [NumTimeId], [CipherId], [CommentId], [CipherCdId], [PeakDayNumber]) VALUES (25, 4, 5, N'red', CAST(0x0000A83B00000000 AS DateTime), 1, 1, 1, 4, 2, 2, NULL)
GO
SET IDENTITY_INSERT [dbo].[Observations] OFF
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Charts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Charts_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Charts] CHECK CONSTRAINT [FK_dbo.Charts_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Cycles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Cycles_dbo.Charts_ChartId] FOREIGN KEY([ChartId])
REFERENCES [dbo].[Charts] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cycles] CHECK CONSTRAINT [FK_dbo.Cycles_dbo.Charts_ChartId]
GO
ALTER TABLE [dbo].[ObservationNotes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ObservationNotes_dbo.Observations_ObservationId] FOREIGN KEY([ObservationId])
REFERENCES [dbo].[Observations] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ObservationNotes] CHECK CONSTRAINT [FK_dbo.ObservationNotes_dbo.Observations_ObservationId]
GO
ALTER TABLE [dbo].[Observations]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Observations_dbo.CipherCds_CipherCdId] FOREIGN KEY([CipherCdId])
REFERENCES [dbo].[CipherCds] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Observations] CHECK CONSTRAINT [FK_dbo.Observations_dbo.CipherCds_CipherCdId]
GO
ALTER TABLE [dbo].[Observations]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Observations_dbo.Ciphers_CipherId] FOREIGN KEY([CipherId])
REFERENCES [dbo].[Ciphers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Observations] CHECK CONSTRAINT [FK_dbo.Observations_dbo.Ciphers_CipherId]
GO
ALTER TABLE [dbo].[Observations]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Observations_dbo.Comments_CommentId] FOREIGN KEY([CommentId])
REFERENCES [dbo].[Comments] ([Id])
GO
ALTER TABLE [dbo].[Observations] CHECK CONSTRAINT [FK_dbo.Observations_dbo.Comments_CommentId]
GO
ALTER TABLE [dbo].[Observations]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Observations_dbo.Cycles_CycleId] FOREIGN KEY([CycleId])
REFERENCES [dbo].[Cycles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Observations] CHECK CONSTRAINT [FK_dbo.Observations_dbo.Cycles_CycleId]
GO
ALTER TABLE [dbo].[Observations]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Observations_dbo.Letters_LetterId] FOREIGN KEY([LetterId])
REFERENCES [dbo].[Letters] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Observations] CHECK CONSTRAINT [FK_dbo.Observations_dbo.Letters_LetterId]
GO
ALTER TABLE [dbo].[Observations]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Observations_dbo.Markers_MarkerId] FOREIGN KEY([MarkerId])
REFERENCES [dbo].[Markers] ([Id])
GO
ALTER TABLE [dbo].[Observations] CHECK CONSTRAINT [FK_dbo.Observations_dbo.Markers_MarkerId]
GO
ALTER TABLE [dbo].[Observations]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Observations_dbo.NumTimes_NumTimeId] FOREIGN KEY([NumTimeId])
REFERENCES [dbo].[NumTimes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Observations] CHECK CONSTRAINT [FK_dbo.Observations_dbo.NumTimes_NumTimeId]
GO
