
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/04/2018 15:45:22
-- Generated from EDMX file: C:\Users\rspin\Documents\Visual Studio 2017\Projects\Nola\Nola\ModelNola.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [NolaDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Expense_Car]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Expense] DROP CONSTRAINT [FK_Expense_Car];
GO
IF OBJECT_ID(N'[dbo].[FK_Purchase_Car2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Purchase] DROP CONSTRAINT [FK_Purchase_Car2];
GO
IF OBJECT_ID(N'[dbo].[FK_Sale_Car]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sale] DROP CONSTRAINT [FK_Sale_Car];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Car]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Car];
GO
IF OBJECT_ID(N'[dbo].[Expense]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Expense];
GO
IF OBJECT_ID(N'[dbo].[Purchase]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Purchase];
GO
IF OBJECT_ID(N'[dbo].[Sale]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sale];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Car'
CREATE TABLE [dbo].[Car] (
    [IdCar] int IDENTITY(1,1) NOT NULL,
    [model] nvarchar(50)  NULL,
    [color] nvarchar(50)  NULL,
    [vin] nvarchar(100)  NULL
);
GO

-- Creating table 'Expense'
CREATE TABLE [dbo].[Expense] (
    [IdExpense] int IDENTITY(1,1) NOT NULL,
    [title] nvarchar(100)  NULL,
    [description] nvarchar(500)  NULL,
    [price] decimal(5,2)  NULL,
    [idCar] int  NULL
);
GO

-- Creating table 'Purchase'
CREATE TABLE [dbo].[Purchase] (
    [IdPurchase] int IDENTITY(1,1) NOT NULL,
    [datePurchase] datetime  NULL,
    [price] decimal(5,2)  NULL,
    [fee] decimal(5,2)  NULL,
    [idCar] int  NULL
);
GO

-- Creating table 'Sale'
CREATE TABLE [dbo].[Sale] (
    [IdSale] int IDENTITY(1,1) NOT NULL,
    [dateSale] datetime  NULL,
    [price] decimal(5,2)  NULL,
    [idCar] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdCar] in table 'Car'
ALTER TABLE [dbo].[Car]
ADD CONSTRAINT [PK_Car]
    PRIMARY KEY CLUSTERED ([IdCar] ASC);
GO

-- Creating primary key on [IdExpense] in table 'Expense'
ALTER TABLE [dbo].[Expense]
ADD CONSTRAINT [PK_Expense]
    PRIMARY KEY CLUSTERED ([IdExpense] ASC);
GO

-- Creating primary key on [IdPurchase] in table 'Purchase'
ALTER TABLE [dbo].[Purchase]
ADD CONSTRAINT [PK_Purchase]
    PRIMARY KEY CLUSTERED ([IdPurchase] ASC);
GO

-- Creating primary key on [IdSale] in table 'Sale'
ALTER TABLE [dbo].[Sale]
ADD CONSTRAINT [PK_Sale]
    PRIMARY KEY CLUSTERED ([IdSale] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [idCar] in table 'Expense'
ALTER TABLE [dbo].[Expense]
ADD CONSTRAINT [FK_Expense_Car]
    FOREIGN KEY ([idCar])
    REFERENCES [dbo].[Car]
        ([IdCar])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Expense_Car'
CREATE INDEX [IX_FK_Expense_Car]
ON [dbo].[Expense]
    ([idCar]);
GO

-- Creating foreign key on [idCar] in table 'Purchase'
ALTER TABLE [dbo].[Purchase]
ADD CONSTRAINT [FK_Purchase_Car2]
    FOREIGN KEY ([idCar])
    REFERENCES [dbo].[Car]
        ([IdCar])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Purchase_Car2'
CREATE INDEX [IX_FK_Purchase_Car2]
ON [dbo].[Purchase]
    ([idCar]);
GO

-- Creating foreign key on [idCar] in table 'Sale'
ALTER TABLE [dbo].[Sale]
ADD CONSTRAINT [FK_Sale_Car]
    FOREIGN KEY ([idCar])
    REFERENCES [dbo].[Car]
        ([IdCar])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Sale_Car'
CREATE INDEX [IX_FK_Sale_Car]
ON [dbo].[Sale]
    ([idCar]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------