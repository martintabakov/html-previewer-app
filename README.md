# HTML Previewer Application

An application that renders the value of a textarea as HTML. The different HTML samples are stored in a database and can be loaded for editing.

## Used Technologies and libraries

1. JavaScript
1. jQuery
2. Kendo UI
3. .Net Core 3.1
4. SQL Server

## How to setup the database and run the project

1. To generate the database for the project, execute the script below in SQL Server Management Studio:

```
USE [master]
GO
/****** Object:  Database [HtmlSamples]    Script Date: 20/09/2021 10:53:01 AM ******/
CREATE DATABASE [HtmlSamples]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HtmlSamples', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\HtmlSamples.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HtmlSamples_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\HtmlSamples_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HtmlSamples] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HtmlSamples].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HtmlSamples] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HtmlSamples] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HtmlSamples] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HtmlSamples] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HtmlSamples] SET ARITHABORT OFF 
GO
ALTER DATABASE [HtmlSamples] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HtmlSamples] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HtmlSamples] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HtmlSamples] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HtmlSamples] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HtmlSamples] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HtmlSamples] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HtmlSamples] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HtmlSamples] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HtmlSamples] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HtmlSamples] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HtmlSamples] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HtmlSamples] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HtmlSamples] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HtmlSamples] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HtmlSamples] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HtmlSamples] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HtmlSamples] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HtmlSamples] SET  MULTI_USER 
GO
ALTER DATABASE [HtmlSamples] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HtmlSamples] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HtmlSamples] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HtmlSamples] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HtmlSamples] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HtmlSamples] SET QUERY_STORE = OFF
GO
USE [HtmlSamples]
GO
/****** Object:  Table [dbo].[HtmlSamples]    Script Date: 20/09/2021 10:53:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HtmlSamples](
	[HtmlSample] [nvarchar](max) NOT NULL,
	[SampleID] [int] NOT NULL,
	[CreateDate] [smalldatetime] NOT NULL,
	[LastEditDate] [smalldatetime] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SampleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [HtmlSamples] SET  READ_WRITE 
GO
```

**Make sure to change the FILENAME location to where your Management Studio is located.**

2. After the database is generated, build and run the project.
