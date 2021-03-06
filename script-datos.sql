USE [master]
GO
/****** Object:  Database [obligatorio1DA]    Script Date: 23/11/2017 18:38:22 ******/
CREATE DATABASE [obligatorio1DA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'obligatorio1DA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\obligatorio1DA.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'obligatorio1DA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\obligatorio1DA_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [obligatorio1DA] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [obligatorio1DA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [obligatorio1DA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [obligatorio1DA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [obligatorio1DA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [obligatorio1DA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [obligatorio1DA] SET ARITHABORT OFF 
GO
ALTER DATABASE [obligatorio1DA] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [obligatorio1DA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [obligatorio1DA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [obligatorio1DA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [obligatorio1DA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [obligatorio1DA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [obligatorio1DA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [obligatorio1DA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [obligatorio1DA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [obligatorio1DA] SET  ENABLE_BROKER 
GO
ALTER DATABASE [obligatorio1DA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [obligatorio1DA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [obligatorio1DA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [obligatorio1DA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [obligatorio1DA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [obligatorio1DA] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [obligatorio1DA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [obligatorio1DA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [obligatorio1DA] SET  MULTI_USER 
GO
ALTER DATABASE [obligatorio1DA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [obligatorio1DA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [obligatorio1DA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [obligatorio1DA] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [obligatorio1DA] SET DELAYED_DURABILITY = DISABLED 
GO
USE [obligatorio1DA]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 23/11/2017 18:38:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Alumnoes]    Script Date: 23/11/2017 18:38:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumnoes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[Apellido] [nvarchar](max) NULL,
	[Ci] [nvarchar](max) NULL,
	[UbicacionX] [float] NOT NULL,
	[UbicacionY] [float] NOT NULL,
 CONSTRAINT [PK_dbo.Alumnoes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AlumnoMaterias]    Script Date: 23/11/2017 18:38:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlumnoMaterias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AlumnoId] [int] NOT NULL,
	[MateriaId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.AlumnoMaterias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DocenteMaterias]    Script Date: 23/11/2017 18:38:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocenteMaterias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DocenteId] [int] NOT NULL,
	[MateriaId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.DocenteMaterias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Docentes]    Script Date: 23/11/2017 18:38:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Docentes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[Apellido] [nvarchar](max) NULL,
	[Ci] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Docentes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Materias]    Script Date: 23/11/2017 18:38:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CodigoMateria] [nvarchar](max) NULL,
	[Nombre] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Materias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Index [IX_AlumnoId]    Script Date: 23/11/2017 18:38:22 ******/
CREATE NONCLUSTERED INDEX [IX_AlumnoId] ON [dbo].[AlumnoMaterias]
(
	[AlumnoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MateriaId]    Script Date: 23/11/2017 18:38:22 ******/
CREATE NONCLUSTERED INDEX [IX_MateriaId] ON [dbo].[AlumnoMaterias]
(
	[MateriaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DocenteId]    Script Date: 23/11/2017 18:38:22 ******/
CREATE NONCLUSTERED INDEX [IX_DocenteId] ON [dbo].[DocenteMaterias]
(
	[DocenteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MateriaId]    Script Date: 23/11/2017 18:38:22 ******/
CREATE NONCLUSTERED INDEX [IX_MateriaId] ON [dbo].[DocenteMaterias]
(
	[MateriaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AlumnoMaterias]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AlumnoMaterias_dbo.Alumnoes_AlumnoId] FOREIGN KEY([AlumnoId])
REFERENCES [dbo].[Alumnoes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AlumnoMaterias] CHECK CONSTRAINT [FK_dbo.AlumnoMaterias_dbo.Alumnoes_AlumnoId]
GO
ALTER TABLE [dbo].[AlumnoMaterias]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AlumnoMaterias_dbo.Materias_MateriaId] FOREIGN KEY([MateriaId])
REFERENCES [dbo].[Materias] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AlumnoMaterias] CHECK CONSTRAINT [FK_dbo.AlumnoMaterias_dbo.Materias_MateriaId]
GO
ALTER TABLE [dbo].[DocenteMaterias]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DocenteMaterias_dbo.Docentes_DocenteId] FOREIGN KEY([DocenteId])
REFERENCES [dbo].[Docentes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DocenteMaterias] CHECK CONSTRAINT [FK_dbo.DocenteMaterias_dbo.Docentes_DocenteId]
GO
ALTER TABLE [dbo].[DocenteMaterias]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DocenteMaterias_dbo.Materias_MateriaId] FOREIGN KEY([MateriaId])
REFERENCES [dbo].[Materias] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DocenteMaterias] CHECK CONSTRAINT [FK_dbo.DocenteMaterias_dbo.Materias_MateriaId]
GO
USE [master]
GO
ALTER DATABASE [obligatorio1DA] SET  READ_WRITE 
GO
