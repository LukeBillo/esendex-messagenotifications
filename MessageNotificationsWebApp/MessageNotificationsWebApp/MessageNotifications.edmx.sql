
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/09/2017 22:39:34
-- Generated from EDMX file: E:\More Documents\Esendex\esendex-messagenotifications\MessageNotificationsWebApp\MessageNotificationsWebApp\MessageNotifications.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MessageNotifications];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'InboundMessages1'
CREATE TABLE [dbo].[InboundMessages1] (
    [Id] uniqueidentifier  NOT NULL,
    [MessageId] uniqueidentifier  NOT NULL,
    [AccountId] uniqueidentifier  NOT NULL,
    [MessageText] nvarchar(max)  NOT NULL,
    [From] nvarchar(max)  NOT NULL,
    [To] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DeliveredMessages'
CREATE TABLE [dbo].[DeliveredMessages] (
    [Id] uniqueidentifier  NOT NULL,
    [MessageId] uniqueidentifier  NOT NULL,
    [AccountId] uniqueidentifier  NOT NULL,
    [OccurredAt] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'FailedMessages'
CREATE TABLE [dbo].[FailedMessages] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MessageId] uniqueidentifier  NOT NULL,
    [AccountId] uniqueidentifier  NOT NULL,
    [OccurredAt] nvarchar(max)  NOT NULL,
    [FailureCode] nvarchar(max)  NOT NULL,
    [FailureDetail] nvarchar(max)  NOT NULL,
    [IsPermanentFailure] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'InboundMessages1'
ALTER TABLE [dbo].[InboundMessages1]
ADD CONSTRAINT [PK_InboundMessages1]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DeliveredMessages'
ALTER TABLE [dbo].[DeliveredMessages]
ADD CONSTRAINT [PK_DeliveredMessages]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FailedMessages'
ALTER TABLE [dbo].[FailedMessages]
ADD CONSTRAINT [PK_FailedMessages]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------