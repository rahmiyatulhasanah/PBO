USE [master]
GO

/****** Object:  Database [DB_Food Delv Planner]    Script Date: 29/04/2021 08.44.25 ******/
CREATE DATABASE [DB_Food Delv Planner]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_Food Delv Planner', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DB_Food Delv Planner.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_Food Delv Planner_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DB_Food Delv Planner_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_Food Delv Planner].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [DB_Food Delv Planner] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [DB_Food Delv Planner] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [DB_Food Delv Planner] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [DB_Food Delv Planner] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [DB_Food Delv Planner] SET ARITHABORT OFF 
GO

ALTER DATABASE [DB_Food Delv Planner] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [DB_Food Delv Planner] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [DB_Food Delv Planner] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [DB_Food Delv Planner] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [DB_Food Delv Planner] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [DB_Food Delv Planner] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [DB_Food Delv Planner] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [DB_Food Delv Planner] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [DB_Food Delv Planner] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [DB_Food Delv Planner] SET  DISABLE_BROKER 
GO

ALTER DATABASE [DB_Food Delv Planner] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [DB_Food Delv Planner] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [DB_Food Delv Planner] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [DB_Food Delv Planner] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [DB_Food Delv Planner] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [DB_Food Delv Planner] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [DB_Food Delv Planner] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [DB_Food Delv Planner] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [DB_Food Delv Planner] SET  MULTI_USER 
GO

ALTER DATABASE [DB_Food Delv Planner] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [DB_Food Delv Planner] SET DB_CHAINING OFF 
GO

ALTER DATABASE [DB_Food Delv Planner] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [DB_Food Delv Planner] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [DB_Food Delv Planner] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [DB_Food Delv Planner] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [DB_Food Delv Planner] SET QUERY_STORE = OFF
GO

ALTER DATABASE [DB_Food Delv Planner] SET  READ_WRITE 
GO

