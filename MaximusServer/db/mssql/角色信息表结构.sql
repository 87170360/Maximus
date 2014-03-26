USE [master]
GO
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'maximus')
BEGIN
CREATE DATABASE [maximus] ON  PRIMARY 
( NAME = N'maximus', FILENAME = N'$(dbpath)/maximus.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'maximus_log', FILENAME = N'$(dbpath)/maximus_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END

GO
EXEC dbo.sp_dbcmptlevel @dbname=N'maximus', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [maximus].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO
ALTER DATABASE [maximus] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [maximus] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [maximus] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [maximus] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [maximus] SET ARITHABORT OFF 
GO
ALTER DATABASE [maximus] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [maximus] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [maximus] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [maximus] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [maximus] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [maximus] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [maximus] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [maximus] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [maximus] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [maximus] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [maximus] SET  ENABLE_BROKER 
GO
ALTER DATABASE [maximus] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [maximus] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [maximus] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [maximus] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [maximus] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [maximus] SET  READ_WRITE 
GO
ALTER DATABASE [maximus] SET RECOVERY FULL 
GO
ALTER DATABASE [maximus] SET  MULTI_USER 
GO
ALTER DATABASE [maximus] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [maximus] SET DB_CHAINING OFF 
USE [maximus]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[item]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[item](
	[id] [nchar](10) NOT NULL,
	[base_id] [nchar](10) NOT NULL,
	[owner] [nchar](10) NULL,
	[binary] [varbinary](max) NULL,
	[status] [int] NULL CONSTRAINT [DF_item_status]  DEFAULT ((0)),
 CONSTRAINT [PK_item] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[charactor]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[charactor](
	[charid] [nchar](10) NOT NULL,
	[userid] [nchar](10) NOT NULL,
	[role] [int] NOT NULL,
	[x_cood] [int] NOT NULL,
	[y_cood] [int] NOT NULL,
	[map_id] [int] NOT NULL,
	[map_type] [int] NOT NULL,
	[pre_map_id] [int] NULL CONSTRAINT [DF_charactor_info_pre_map_id]  DEFAULT ((0)),
	[pre_map_type] [int] NULL CONSTRAINT [DF_charactor_info_pre_map_type]  DEFAULT ((0)),
	[online_time] [bigint] NULL CONSTRAINT [DF_charactor_info_online_time]  DEFAULT ((0)),
	[create_time] [bigint] NOT NULL,
	[last_offline_time] [bigint] NOT NULL,
	[level] [int] NULL CONSTRAINT [DF_charactor_info_level]  DEFAULT ((1)),
	[exp] [nchar](10) NULL CONSTRAINT [DF_charactor_info_exp]  DEFAULT ((0)),
	[hp] [int] NOT NULL,
	[status] [int] NULL CONSTRAINT [DF_charactor_info_status]  DEFAULT ((0)),
	[currency] [int] NOT NULL CONSTRAINT [DF_charactor_info_currency]  DEFAULT ((0)),
	[binary] [varbinary](max) NULL,
 CONSTRAINT [PK_charactor_info_1] PRIMARY KEY CLUSTERED 
(
	[charid] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[charactor]') AND name = N'IX_charactor_info')
CREATE NONCLUSTERED INDEX [IX_charactor_info] ON [dbo].[charactor] 
(
	[charid] ASC,
	[userid] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'money' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'charactor', @level2type=N'COLUMN', @level2name=N'currency'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'charactor', @level2type=N'CONSTRAINT', @level2name=N'PK_charactor_info_1'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'帐号与角色索引' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'charactor', @level2type=N'INDEX', @level2name=N'IX_charactor_info'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mail](
	[from_id] [nchar](10) NOT NULL,
	[to_id] [nchar](10) NOT NULL,
	[subject] [ntext] NOT NULL,
	[content] [text] NOT NULL,
	[send_time] [int] NOT NULL,
	[receive_time] [int] NULL CONSTRAINT [DF_mail_receive_time]  DEFAULT ((0)),
	[status] [int] NULL CONSTRAINT [DF_mail_status]  DEFAULT ((0))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[mail]') AND name = N'IX_mail')
CREATE NONCLUSTERED INDEX [IX_mail] ON [dbo].[mail] 
(
	[from_id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'收件人索引' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'mail', @level2type=N'INDEX', @level2name=N'IX_mail'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[charactor_relation]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[charactor_relation](
	[first_charactor] [nchar](10) NOT NULL,
	[second_charactor] [nchar](10) NOT NULL,
	[relation] [int] NULL CONSTRAINT [DF_charactor_relation_relation]  DEFAULT ((0))
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[charactor_relation]') AND name = N'IX_charactor_relation')
CREATE NONCLUSTERED INDEX [IX_charactor_relation] ON [dbo].[charactor_relation] 
(
	[first_charactor] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[charactor_relation]') AND name = N'IX_charactor_relation_1')
CREATE NONCLUSTERED INDEX [IX_charactor_relation_1] ON [dbo].[charactor_relation] 
(
	[relation] ASC,
	[first_charactor] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'本人id索引' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'charactor_relation', @level2type=N'INDEX', @level2name=N'IX_charactor_relation'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'本人与其他人具体关系索引' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'charactor_relation', @level2type=N'INDEX', @level2name=N'IX_charactor_relation_1'

