USE [master]
GO
/****** Object:  Database [Ejemplo]    Script Date: 11/03/2022 01:26:23 p. m. ******/
CREATE DATABASE [Ejemplo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ejemplo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Ejemplo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ejemplo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Ejemplo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Ejemplo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ejemplo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ejemplo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ejemplo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ejemplo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ejemplo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ejemplo] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ejemplo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Ejemplo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ejemplo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ejemplo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ejemplo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ejemplo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ejemplo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ejemplo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ejemplo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ejemplo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Ejemplo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ejemplo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ejemplo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ejemplo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ejemplo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ejemplo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Ejemplo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ejemplo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Ejemplo] SET  MULTI_USER 
GO
ALTER DATABASE [Ejemplo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ejemplo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ejemplo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ejemplo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ejemplo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Ejemplo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Ejemplo] SET QUERY_STORE = OFF
GO
USE [Ejemplo]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 11/03/2022 01:26:24 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NULL,
	[Apellido] [varchar](20) NULL,
	[Correo] [varchar](20) NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Persona] ON 

INSERT [dbo].[Persona] ([Id], [Nombre], [Apellido], [Correo]) VALUES (1, N'Juan', N'Garza', N'garza@')
INSERT [dbo].[Persona] ([Id], [Nombre], [Apellido], [Correo]) VALUES (2, N'Juan', N'Fernando', NULL)
INSERT [dbo].[Persona] ([Id], [Nombre], [Apellido], [Correo]) VALUES (3, N'Valentina', N'de la Rosa', N'rosa@')
INSERT [dbo].[Persona] ([Id], [Nombre], [Apellido], [Correo]) VALUES (4, N'Oscar', N'Renta', N'renta@')
INSERT [dbo].[Persona] ([Id], [Nombre], [Apellido], [Correo]) VALUES (5, N'Sara', N'Teresa', NULL)
SET IDENTITY_INSERT [dbo].[Persona] OFF
GO
/****** Object:  StoredProcedure [dbo].[spBuscar]    Script Date: 11/03/2022 01:26:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spBuscar]
@Action varchar(2),
@Id int = null,
@Nom varchar(30)=null
as
	BEGIN
		set nocount on;
			if(@Action='S')
				Begin
					select * from Persona
				End
			if(@Action='B')
				Begin
					Select * from Persona
					where Id=@Id
				End
			if(@Action='BN')
				Begin
					select * from Persona
					where Nombre like '%' + @Nom + '%'
				End
	END
GO
/****** Object:  StoredProcedure [dbo].[spPersona]    Script Date: 11/03/2022 01:26:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spPersona]
@Action varchar(2),
@Id int = null,
@Nom varchar(30)=null,
@Ape varchar(20)=null,
@Cor varchar(20)=null
as
	BEGIN
		set nocount on;
			If(@Action='C')--Create
				Begin
					insert into Persona(Nombre,Apellido,Correo)
					values(@Nom,@Ape,@Cor)
				End
			If(@Action='R')--Read
				Begin
					Select * from Persona
				End
			If(@Action='U')--Update
				Begin
					Update Persona
					set  Nombre=@Nom,Apellido=@Ape,Correo=@Cor
					where Id=@Id
				End
			If(@Action='D')--Delete
				Begin
					Delete Persona
					where Id=@Id
				End
	END
GO
USE [master]
GO
ALTER DATABASE [Ejemplo] SET  READ_WRITE 
GO
