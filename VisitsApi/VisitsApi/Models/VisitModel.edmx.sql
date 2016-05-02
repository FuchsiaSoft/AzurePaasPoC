
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/02/2016 13:40:32
-- Generated from EDMX file: C:\Users\dupoi\Documents\GitHub\AzurePaasPoC\VisitsApi\VisitsApi\Models\VisitModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [VisitsDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ServiceUserTypeServiceUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ServiceUsers] DROP CONSTRAINT [FK_ServiceUserTypeServiceUser];
GO
IF OBJECT_ID(N'[dbo].[FK_ServiceUserTypeQuickText]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[QuickTexts] DROP CONSTRAINT [FK_ServiceUserTypeQuickText];
GO
IF OBJECT_ID(N'[dbo].[FK_VisitorServiceUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ServiceUsers] DROP CONSTRAINT [FK_VisitorServiceUser];
GO
IF OBJECT_ID(N'[dbo].[FK_ServiceUserVisit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Visits] DROP CONSTRAINT [FK_ServiceUserVisit];
GO
IF OBJECT_ID(N'[dbo].[FK_VisitorVisit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Visits] DROP CONSTRAINT [FK_VisitorVisit];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ServiceUserTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ServiceUserTypes];
GO
IF OBJECT_ID(N'[dbo].[QuickTexts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QuickTexts];
GO
IF OBJECT_ID(N'[dbo].[Visits]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Visits];
GO
IF OBJECT_ID(N'[dbo].[ServiceUsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ServiceUsers];
GO
IF OBJECT_ID(N'[dbo].[Visitors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Visitors];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ServiceUserTypes'
CREATE TABLE [dbo].[ServiceUserTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'QuickTexts'
CREATE TABLE [dbo].[QuickTexts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Body] nvarchar(max)  NOT NULL,
    [ServiceUserType_Id] int  NOT NULL
);
GO

-- Creating table 'Visits'
CREATE TABLE [dbo].[Visits] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [Comments] nvarchar(max)  NULL,
    [ServiceUser_Id] int  NOT NULL,
    [Visitor_Id] int  NOT NULL
);
GO

-- Creating table 'ServiceUsers'
CREATE TABLE [dbo].[ServiceUsers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Firstname] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NOT NULL,
    [AddressOne] nvarchar(max)  NOT NULL,
    [AddressTwo] nvarchar(max)  NULL,
    [AddressThree] nvarchar(max)  NULL,
    [AddressFour] nvarchar(max)  NULL,
    [PostCode] nvarchar(max)  NULL,
    [ServiceUserType_Id] int  NOT NULL,
    [Visitor_Id] int  NOT NULL
);
GO

-- Creating table 'Visitors'
CREATE TABLE [dbo].[Visitors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Firstname] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NOT NULL,
    [JobTitle] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ServiceUserTypes'
ALTER TABLE [dbo].[ServiceUserTypes]
ADD CONSTRAINT [PK_ServiceUserTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'QuickTexts'
ALTER TABLE [dbo].[QuickTexts]
ADD CONSTRAINT [PK_QuickTexts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Visits'
ALTER TABLE [dbo].[Visits]
ADD CONSTRAINT [PK_Visits]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ServiceUsers'
ALTER TABLE [dbo].[ServiceUsers]
ADD CONSTRAINT [PK_ServiceUsers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Visitors'
ALTER TABLE [dbo].[Visitors]
ADD CONSTRAINT [PK_Visitors]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ServiceUserType_Id] in table 'ServiceUsers'
ALTER TABLE [dbo].[ServiceUsers]
ADD CONSTRAINT [FK_ServiceUserTypeServiceUser]
    FOREIGN KEY ([ServiceUserType_Id])
    REFERENCES [dbo].[ServiceUserTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServiceUserTypeServiceUser'
CREATE INDEX [IX_FK_ServiceUserTypeServiceUser]
ON [dbo].[ServiceUsers]
    ([ServiceUserType_Id]);
GO

-- Creating foreign key on [ServiceUserType_Id] in table 'QuickTexts'
ALTER TABLE [dbo].[QuickTexts]
ADD CONSTRAINT [FK_ServiceUserTypeQuickText]
    FOREIGN KEY ([ServiceUserType_Id])
    REFERENCES [dbo].[ServiceUserTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServiceUserTypeQuickText'
CREATE INDEX [IX_FK_ServiceUserTypeQuickText]
ON [dbo].[QuickTexts]
    ([ServiceUserType_Id]);
GO

-- Creating foreign key on [Visitor_Id] in table 'ServiceUsers'
ALTER TABLE [dbo].[ServiceUsers]
ADD CONSTRAINT [FK_VisitorServiceUser]
    FOREIGN KEY ([Visitor_Id])
    REFERENCES [dbo].[Visitors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VisitorServiceUser'
CREATE INDEX [IX_FK_VisitorServiceUser]
ON [dbo].[ServiceUsers]
    ([Visitor_Id]);
GO

-- Creating foreign key on [ServiceUser_Id] in table 'Visits'
ALTER TABLE [dbo].[Visits]
ADD CONSTRAINT [FK_ServiceUserVisit]
    FOREIGN KEY ([ServiceUser_Id])
    REFERENCES [dbo].[ServiceUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServiceUserVisit'
CREATE INDEX [IX_FK_ServiceUserVisit]
ON [dbo].[Visits]
    ([ServiceUser_Id]);
GO

-- Creating foreign key on [Visitor_Id] in table 'Visits'
ALTER TABLE [dbo].[Visits]
ADD CONSTRAINT [FK_VisitorVisit]
    FOREIGN KEY ([Visitor_Id])
    REFERENCES [dbo].[Visitors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VisitorVisit'
CREATE INDEX [IX_FK_VisitorVisit]
ON [dbo].[Visits]
    ([Visitor_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------