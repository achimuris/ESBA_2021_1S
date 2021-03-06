USE [master]
GO
/****** Object:  Database [ESBA_2021_3CAPAS]    Script Date: 18/05/2021 21:39:35 ******/
CREATE DATABASE [ESBA_2021_3CAPAS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ESBA_2021_3CAPAS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ESBA_2021_3CAPAS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ESBA_2021_3CAPAS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ESBA_2021_3CAPAS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ESBA_2021_3CAPAS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET ARITHABORT OFF 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET  MULTI_USER 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET QUERY_STORE = OFF
GO
USE [ESBA_2021_3CAPAS]
GO
/****** Object:  Table [dbo].[tCliente]    Script Date: 18/05/2021 21:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tCliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre_cliente] [nvarchar](50) NOT NULL,
	[apellido_cliente] [nvarchar](50) NOT NULL,
	[id_tipo_cliente] [int] NOT NULL,
 CONSTRAINT [PK_tCliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tTipoDeCliente]    Script Date: 18/05/2021 21:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tTipoDeCliente](
	[id_tipo] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_tipo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tTipoDeCliente] PRIMARY KEY CLUSTERED 
(
	[id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tCliente] ON 

INSERT [dbo].[tCliente] ([id_cliente], [nombre_cliente], [apellido_cliente], [id_tipo_cliente]) VALUES (1, N'Gaston', N'Medin', 3)
INSERT [dbo].[tCliente] ([id_cliente], [nombre_cliente], [apellido_cliente], [id_tipo_cliente]) VALUES (2, N'Deisy', N'Acosta', 1)
INSERT [dbo].[tCliente] ([id_cliente], [nombre_cliente], [apellido_cliente], [id_tipo_cliente]) VALUES (3, N'Jose', N'Puyosa', 1)
INSERT [dbo].[tCliente] ([id_cliente], [nombre_cliente], [apellido_cliente], [id_tipo_cliente]) VALUES (4, N'Juan', N'Lence', 3)
INSERT [dbo].[tCliente] ([id_cliente], [nombre_cliente], [apellido_cliente], [id_tipo_cliente]) VALUES (5, N'Ricardo', N'Tapia', 3)
INSERT [dbo].[tCliente] ([id_cliente], [nombre_cliente], [apellido_cliente], [id_tipo_cliente]) VALUES (6, N'Andres', N'Chimuris', 1)
SET IDENTITY_INSERT [dbo].[tCliente] OFF
GO
SET IDENTITY_INSERT [dbo].[tTipoDeCliente] ON 

INSERT [dbo].[tTipoDeCliente] ([id_tipo], [descripcion_tipo]) VALUES (1, N'Premium')
INSERT [dbo].[tTipoDeCliente] ([id_tipo], [descripcion_tipo]) VALUES (3, N'Deluxe')
SET IDENTITY_INSERT [dbo].[tTipoDeCliente] OFF
GO
ALTER TABLE [dbo].[tCliente]  WITH CHECK ADD  CONSTRAINT [FK_tCliente_tTipoDeCliente] FOREIGN KEY([id_tipo_cliente])
REFERENCES [dbo].[tTipoDeCliente] ([id_tipo])
GO
ALTER TABLE [dbo].[tCliente] CHECK CONSTRAINT [FK_tCliente_tTipoDeCliente]
GO
/****** Object:  StoredProcedure [dbo].[sp_crear_cliente]    Script Date: 18/05/2021 21:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_crear_cliente]
	@nombre_cliente nvarchar(50),
	@apellido_cliente nvarchar(50),
	@id_tipo_cliente int,
	@id_cliente int OUT
as
	insert into tCliente (nombre_cliente, apellido_cliente, id_tipo_cliente)
	values(@nombre_cliente, @apellido_cliente, @id_tipo_cliente)

	
	set @id_cliente = ( SELECT IDENT_CURRENT('tCliente'))
GO
/****** Object:  StoredProcedure [dbo].[sp_Crear_Tipo]    Script Date: 18/05/2021 21:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Crear_Tipo] 
@descripcion nvarchar(50)
as
insert into tTipoDeCliente(descripcion_tipo)
values(@descripcion)

GO
/****** Object:  StoredProcedure [dbo].[sp_Recuperar_Tipo]    Script Date: 18/05/2021 21:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Recuperar_Tipo]
as
select * from tTipoDeCliente
GO
USE [master]
GO
ALTER DATABASE [ESBA_2021_3CAPAS] SET  READ_WRITE 
GO
