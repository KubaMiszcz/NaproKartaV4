USE [NaproKartaDBv2]
GO
ALTER TABLE [dbo].[Observations] DROP CONSTRAINT [FK_dbo.Observations_dbo.NumTimes_NumTimeId]
GO
ALTER TABLE [dbo].[Observations] DROP CONSTRAINT [FK_dbo.Observations_dbo.Markers_MarkerId]
GO
ALTER TABLE [dbo].[Observations] DROP CONSTRAINT [FK_dbo.Observations_dbo.Letters_LetterId]
GO
ALTER TABLE [dbo].[Observations] DROP CONSTRAINT [FK_dbo.Observations_dbo.Cycles_CycleId]
GO
ALTER TABLE [dbo].[Observations] DROP CONSTRAINT [FK_dbo.Observations_dbo.Comments_CommentId]
GO
ALTER TABLE [dbo].[Observations] DROP CONSTRAINT [FK_dbo.Observations_dbo.Ciphers_CipherId]
GO
ALTER TABLE [dbo].[Observations] DROP CONSTRAINT [FK_dbo.Observations_dbo.CipherCds_CipherCdId]
GO
ALTER TABLE [dbo].[ObservationNotes] DROP CONSTRAINT [FK_dbo.ObservationNotes_dbo.Observations_ObservationId]
GO
ALTER TABLE [dbo].[Cycles] DROP CONSTRAINT [FK_dbo.Cycles_dbo.Charts_ChartId]
GO
ALTER TABLE [dbo].[Charts] DROP CONSTRAINT [FK_dbo.Charts_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserLogins] DROP CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserClaims] DROP CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
/****** Object:  Table [dbo].[Observations]    Script Date: 2018-01-12 10:56:11 ******/
DROP TABLE [dbo].[Observations]
GO
/****** Object:  Table [dbo].[ObservationNotes]    Script Date: 2018-01-12 10:56:11 ******/
DROP TABLE [dbo].[ObservationNotes]
GO
/****** Object:  Table [dbo].[NumTimes]    Script Date: 2018-01-12 10:56:11 ******/
DROP TABLE [dbo].[NumTimes]
GO
/****** Object:  Table [dbo].[Markers]    Script Date: 2018-01-12 10:56:11 ******/
DROP TABLE [dbo].[Markers]
GO
/****** Object:  Table [dbo].[Letters]    Script Date: 2018-01-12 10:56:11 ******/
DROP TABLE [dbo].[Letters]
GO
/****** Object:  Table [dbo].[Cycles]    Script Date: 2018-01-12 10:56:11 ******/
DROP TABLE [dbo].[Cycles]
GO
/****** Object:  Table [dbo].[Comments]    Script Date: 2018-01-12 10:56:11 ******/
DROP TABLE [dbo].[Comments]
GO
/****** Object:  Table [dbo].[Ciphers]    Script Date: 2018-01-12 10:56:11 ******/
DROP TABLE [dbo].[Ciphers]
GO
/****** Object:  Table [dbo].[CipherCds]    Script Date: 2018-01-12 10:56:11 ******/
DROP TABLE [dbo].[CipherCds]
GO
/****** Object:  Table [dbo].[Charts]    Script Date: 2018-01-12 10:56:11 ******/
DROP TABLE [dbo].[Charts]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 2018-01-12 10:56:11 ******/
DROP TABLE [dbo].[AspNetUsers]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 2018-01-12 10:56:11 ******/
DROP TABLE [dbo].[AspNetUserRoles]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 2018-01-12 10:56:11 ******/
DROP TABLE [dbo].[AspNetUserLogins]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 2018-01-12 10:56:11 ******/
DROP TABLE [dbo].[AspNetUserClaims]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 2018-01-12 10:56:11 ******/
DROP TABLE [dbo].[AspNetRoles]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 2018-01-12 10:56:11 ******/
DROP TABLE [dbo].[__MigrationHistory]
GO
