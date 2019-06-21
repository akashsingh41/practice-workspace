
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/06/2018 13:58:31
-- Generated from EDMX file: c:\users\singhaka\documents\visual studio 2015\Projects\EF_ModelFirst\EF_ModelFirst\CustomModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [sample_test];
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

-- Creating table 'Books'
CREATE TABLE [dbo].[Books] (
    [ISBN] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Author] nvarchar(max)  NOT NULL,
    [PublishedYear] nvarchar(max)  NOT NULL,
    [Publisher] nvarchar(max)  NOT NULL,
    [StudentID] int  NOT NULL
);
GO

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [StudentID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Discipline] nvarchar(max)  NOT NULL,
    [AdmissionYear] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ISBN] in table 'Books'
ALTER TABLE [dbo].[Books]
ADD CONSTRAINT [PK_Books]
    PRIMARY KEY CLUSTERED ([ISBN] ASC);
GO

-- Creating primary key on [StudentID] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([StudentID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [StudentID] in table 'Books'
ALTER TABLE [dbo].[Books]
ADD CONSTRAINT [FK_BookStudent]
    FOREIGN KEY ([StudentID])
    REFERENCES [dbo].[Students]
        ([StudentID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BookStudent'
CREATE INDEX [IX_FK_BookStudent]
ON [dbo].[Books]
    ([StudentID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------