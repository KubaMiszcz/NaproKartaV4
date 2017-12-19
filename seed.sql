USE [NaproKartaDBv2]
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'16741705-3ec6-467f-a48c-a5d1c5db1e13', N'asd@asd.asd', 0, N'ABDWIT44/4JR+FkTVe290LaS94gP2NxSaA/OzKgFPcRxBnWqZxQjC0zYLfZ5MQJqGQ==', N'8d603811-3eaf-427f-a593-9acf4ccf5b4a', NULL, 0, 0, NULL, 1, 0, N'asd@asd.asd')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'440a6217-3fcc-460f-b1e9-381a53b87037', N'zxc@zxc.zxc', 0, N'AFpcfXhLVXDCczkwF1Ujtskah9qkaICO42dwNdoYdBD8n8lxyXXe1rLTMNJAcBrWZw==', N'195380ea-7d1c-4b92-802c-25bacbc3dec9', NULL, 0, 0, NULL, 1, 0, N'zxc@zxc.zxc')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'66f3feb6-418e-4079-9895-0417d1ba71da', N'qwe@qwe.qwe', 0, N'AxhSqhbqZ/XN/KBSxdlHgTiUxVgF82JdQ6UEnBP6Ezl81+YtY5XpYHjfBsyllA==', N'5336c8c8-f523-489d-8bb0-bad384c6c4d5', NULL, 0, 0, NULL, 1, 0, N'qwe@qwe.qwe')
go

SET IDENTITY_INSERT [dbo].[Charts] ON 
INSERT [dbo].[Charts] ([Id], [Title], [UserId], [Note]) VALUES (3, N'chart111', N'16741705-3ec6-467f-a48c-a5d1c5db1e13', N'chartnote11')
INSERT [dbo].[Charts] ([Id], [Title], [UserId], [Note]) VALUES (4, N'chart222', N'16741705-3ec6-467f-a48c-a5d1c5db1e13', N'chartnote22')
INSERT [dbo].[Charts] ([Id], [Title], [UserId], [Note]) VALUES (1003, N'chart333', N'440a6217-3fcc-460f-b1e9-381a53b87037', N'chartnote33')
INSERT [dbo].[Charts] ([Id], [Title], [UserId], [Note]) VALUES (1004, N'chart44', N'16741705-3ec6-467f-a48c-a5d1c5db1e13', N'chartnote44')
INSERT [dbo].[Charts] ([Id], [Title], [UserId], [Note]) VALUES (1005, N'chart55', N'16741705-3ec6-467f-a48c-a5d1c5db1e13', N'chartnote5')
INSERT [dbo].[Charts] ([Id], [Title], [UserId], [Note]) VALUES (1006, N'chart55', N'16741705-3ec6-467f-a48c-a5d1c5db1e13', N'chartnote5')
SET IDENTITY_INSERT [dbo].[Charts] OFF
go

INSERT [dbo].[Ciphers] ([Id]) VALUES (N'0')
INSERT [dbo].[Ciphers] ([Id]) VALUES (N'10')
INSERT [dbo].[Ciphers] ([Id]) VALUES (N'10DL')
INSERT [dbo].[Ciphers] ([Id]) VALUES (N'10SL')
INSERT [dbo].[Ciphers] ([Id]) VALUES (N'10WL')
INSERT [dbo].[Ciphers] ([Id]) VALUES (N'2')
INSERT [dbo].[Ciphers] ([Id]) VALUES (N'2W')
INSERT [dbo].[Ciphers] ([Id]) VALUES (N'4')
INSERT [dbo].[Ciphers] ([Id]) VALUES (N'6')
INSERT [dbo].[Ciphers] ([Id]) VALUES (N'8')
go

INSERT [dbo].[CipherCds] ([Id]) VALUES (N'"P"')
INSERT [dbo].[CipherCds] ([Id]) VALUES (N'B')
INSERT [dbo].[CipherCds] ([Id]) VALUES (N'C')
INSERT [dbo].[CipherCds] ([Id]) VALUES (N'C/K')
INSERT [dbo].[CipherCds] ([Id]) VALUES (N'G')
INSERT [dbo].[CipherCds] ([Id]) VALUES (N'L')
INSERT [dbo].[CipherCds] ([Id]) VALUES (N'P')
INSERT [dbo].[CipherCds] ([Id]) VALUES (N'Y')
go

SET IDENTITY_INSERT [dbo].[Comments] ON 
INSERT [dbo].[Comments] ([Id], [Content]) VALUES (1, N'Badania')
INSERT [dbo].[Comments] ([Id], [Content]) VALUES (2, N'Wizyta')
INSERT [dbo].[Comments] ([Id], [Content]) VALUES (3, N'ILupucupu')
SET IDENTITY_INSERT [dbo].[Comments] OFF 
go

INSERT [dbo].[Letters] ([Id]) VALUES (N'H')
INSERT [dbo].[Letters] ([Id]) VALUES (N'L')
INSERT [dbo].[Letters] ([Id]) VALUES (N'M')
INSERT [dbo].[Letters] ([Id]) VALUES (N'VL')
INSERT [dbo].[Letters] ([Id]) VALUES (N'VVL')
go

INSERT [dbo].[Markers] ([Id]) VALUES (N'none')
INSERT [dbo].[Markers] ([Id]) VALUES (N'green')
INSERT [dbo].[Markers] ([Id]) VALUES (N'greenbaby')
INSERT [dbo].[Markers] ([Id]) VALUES (N'grey')
INSERT [dbo].[Markers] ([Id]) VALUES (N'red')
INSERT [dbo].[Markers] ([Id]) VALUES (N'whitebaby')
INSERT [dbo].[Markers] ([Id]) VALUES (N'yellow')
INSERT [dbo].[Markers] ([Id]) VALUES (N'yellowbaby')
go

INSERT [dbo].[NumTimes] ([Id]) VALUES (N'AD')
INSERT [dbo].[NumTimes] ([Id]) VALUES (N'X1')
INSERT [dbo].[NumTimes] ([Id]) VALUES (N'X2')
INSERT [dbo].[NumTimes] ([Id]) VALUES (N'X3')
go
