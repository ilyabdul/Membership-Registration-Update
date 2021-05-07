
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/24/2021 09:42:07
-- Generated from EDMX file: C:\Users\N I S L T\source\repos\Membership Registration Update\Membership Registration Update\Models\UpdateModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [NewRegistration];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Revalidation_Grade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Revalidations] DROP CONSTRAINT [FK_Revalidation_Grade];
GO
IF OBJECT_ID(N'[dbo].[FK_Revalidation_RevalStatus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Revalidations] DROP CONSTRAINT [FK_Revalidation_RevalStatus];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Grades]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Grades];
GO
IF OBJECT_ID(N'[dbo].[Regstatus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Regstatus];
GO
IF OBJECT_ID(N'[dbo].[Revalidations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Revalidations];
GO
IF OBJECT_ID(N'[dbo].[RevalStatus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RevalStatus];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'NewentryTBs'
CREATE TABLE [dbo].[NewentryTBs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Reference_No] nchar(40)  NOT NULL,
    [FullName] nchar(200)  NOT NULL,
    [Date_Printed] datetime  NOT NULL,
    [Date_Approved] datetime  NULL,
    [RegID] nchar(10)  NULL,
    [Status] nchar(10)  NOT NULL,
    [Remark] nvarchar(max)  NULL
);
GO

-- Creating table 'Regstatus'
CREATE TABLE [dbo].[Regstatus] (
    [statusId] nchar(10)  NOT NULL,
    [Status_name] nchar(20)  NOT NULL,
    [Refcode] int IDENTITY(1,1) NOT NULL,
    [Status_name1] nchar(20)  NOT NULL
);
GO

-- Creating table 'Grades'
CREATE TABLE [dbo].[Grades] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [GCode] int  NOT NULL,
    [Grade1] nchar(10)  NOT NULL
);
GO

-- Creating table 'Revalidations'
CREATE TABLE [dbo].[Revalidations] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [RegID] nchar(10)  NOT NULL,
    [Surname] nchar(20)  NOT NULL,
    [OtherNames] nchar(80)  NULL,
    [Grade] nchar(10)  NOT NULL,
    [Date_Printed] datetime  NULL,
    [Date_Approved] datetime  NULL,
    [Status] nchar(30)  NOT NULL,
    [Remark] nvarchar(max)  NULL
);
GO

-- Creating table 'RevalStatus'
CREATE TABLE [dbo].[RevalStatus] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Status_Code] int  NOT NULL,
    [Status] nchar(30)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'NewentryTBs'
ALTER TABLE [dbo].[NewentryTBs]
ADD CONSTRAINT [PK_NewentryTBs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [statusId] in table 'Regstatus'
ALTER TABLE [dbo].[Regstatus]
ADD CONSTRAINT [PK_Regstatus]
    PRIMARY KEY CLUSTERED ([statusId] ASC);
GO

-- Creating primary key on [Grade1] in table 'Grades'
ALTER TABLE [dbo].[Grades]
ADD CONSTRAINT [PK_Grades]
    PRIMARY KEY CLUSTERED ([Grade1] ASC);
GO

-- Creating primary key on [ID] in table 'Revalidations'
ALTER TABLE [dbo].[Revalidations]
ADD CONSTRAINT [PK_Revalidations]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Status] in table 'RevalStatus'
ALTER TABLE [dbo].[RevalStatus]
ADD CONSTRAINT [PK_RevalStatus]
    PRIMARY KEY CLUSTERED ([Status] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Status] in table 'NewentryTBs'
ALTER TABLE [dbo].[NewentryTBs]
ADD CONSTRAINT [FK_NewentryTB_Regstatus]
    FOREIGN KEY ([Status])
    REFERENCES [dbo].[Regstatus]
        ([statusId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NewentryTB_Regstatus'
CREATE INDEX [IX_FK_NewentryTB_Regstatus]
ON [dbo].[NewentryTBs]
    ([Status]);
GO

-- Creating foreign key on [Grade] in table 'Revalidations'
ALTER TABLE [dbo].[Revalidations]
ADD CONSTRAINT [FK_Revalidation_Grade]
    FOREIGN KEY ([Grade])
    REFERENCES [dbo].[Grades]
        ([Grade1])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Revalidation_Grade'
CREATE INDEX [IX_FK_Revalidation_Grade]
ON [dbo].[Revalidations]
    ([Grade]);
GO

-- Creating foreign key on [Status] in table 'Revalidations'
ALTER TABLE [dbo].[Revalidations]
ADD CONSTRAINT [FK_Revalidation_RevalStatus]
    FOREIGN KEY ([Status])
    REFERENCES [dbo].[RevalStatus]
        ([Status])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Revalidation_RevalStatus'
CREATE INDEX [IX_FK_Revalidation_RevalStatus]
ON [dbo].[Revalidations]
    ([Status]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------