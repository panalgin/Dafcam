
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 04/02/2015 21:03:26
-- Generated from EDMX file: C:\Users\Mashadow\Documents\Visual Studio 2012\Projects\Dafcam\Dafcam\DbContext.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Dafcam];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Bit_inherits_Item]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Items_Bit] DROP CONSTRAINT [FK_Bit_inherits_Item];
GO
IF OBJECT_ID(N'[dbo].[FK_Motor_inherits_Item]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Items_Motor] DROP CONSTRAINT [FK_Motor_inherits_Item];
GO
IF OBJECT_ID(N'[dbo].[FK_Spindle_inherits_Item]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Items_Spindle] DROP CONSTRAINT [FK_Spindle_inherits_Item];
GO
IF OBJECT_ID(N'[dbo].[FK_SpindleBit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Items_Spindle] DROP CONSTRAINT [FK_SpindleBit];
GO
IF OBJECT_ID(N'[dbo].[FK_SpindleBit1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Items_Spindle] DROP CONSTRAINT [FK_SpindleBit1];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Axes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Axes];
GO
IF OBJECT_ID(N'[dbo].[Items]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Items];
GO
IF OBJECT_ID(N'[dbo].[Items_Bit]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Items_Bit];
GO
IF OBJECT_ID(N'[dbo].[Items_Motor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Items_Motor];
GO
IF OBJECT_ID(N'[dbo].[Items_Spindle]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Items_Spindle];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Items'
CREATE TABLE [dbo].[Items] (
    [ItemID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Axes'
CREATE TABLE [dbo].[Axes] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NOT NULL
);
GO

-- Creating table 'Items_Spindle'
CREATE TABLE [dbo].[Items_Spindle] (
    [TargetRpm] int  NOT NULL,
    [CurrentRpm] int  NOT NULL,
    [CurrentBitID] int  NULL,
    [TargetBitID] int  NULL,
    [ItemID] int  NOT NULL
);
GO

-- Creating table 'Items_Bit'
CREATE TABLE [dbo].[Items_Bit] (
    [ShaftDiameter] float  NOT NULL,
    [OuterDiameter] float  NOT NULL,
    [Length] float  NOT NULL,
    [Worktime] bigint  NOT NULL,
    [IntStallsAt] nvarchar(100)  NOT NULL,
    [IntDropsAt] nvarchar(100)  NOT NULL,
    [ItemID] int  NOT NULL
);
GO

-- Creating table 'Items_Motor'
CREATE TABLE [dbo].[Items_Motor] (
    [AxisID] int  NOT NULL,
    [ShortDistance] decimal(20,0)  NOT NULL,
    [AccelerationStartsAt] int  NOT NULL,
    [Position] decimal(20,0)  NOT NULL,
    [UseRamping] bit  NOT NULL,
    [MaxRpm] int  NOT NULL,
    [DwellRpm] int  NOT NULL,
    [CurrentRpm] int  NOT NULL,
    [ItemID] int  NOT NULL
);
GO

-- Creating table 'Items_Controller'
CREATE TABLE [dbo].[Items_Controller] (
    [ItemID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ItemID] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [PK_Items]
    PRIMARY KEY CLUSTERED ([ItemID] ASC);
GO

-- Creating primary key on [ID] in table 'Axes'
ALTER TABLE [dbo].[Axes]
ADD CONSTRAINT [PK_Axes]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ItemID] in table 'Items_Spindle'
ALTER TABLE [dbo].[Items_Spindle]
ADD CONSTRAINT [PK_Items_Spindle]
    PRIMARY KEY CLUSTERED ([ItemID] ASC);
GO

-- Creating primary key on [ItemID] in table 'Items_Bit'
ALTER TABLE [dbo].[Items_Bit]
ADD CONSTRAINT [PK_Items_Bit]
    PRIMARY KEY CLUSTERED ([ItemID] ASC);
GO

-- Creating primary key on [ItemID] in table 'Items_Motor'
ALTER TABLE [dbo].[Items_Motor]
ADD CONSTRAINT [PK_Items_Motor]
    PRIMARY KEY CLUSTERED ([ItemID] ASC);
GO

-- Creating primary key on [ItemID] in table 'Items_Controller'
ALTER TABLE [dbo].[Items_Controller]
ADD CONSTRAINT [PK_Items_Controller]
    PRIMARY KEY CLUSTERED ([ItemID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CurrentBitID] in table 'Items_Spindle'
ALTER TABLE [dbo].[Items_Spindle]
ADD CONSTRAINT [FK_SpindleBit]
    FOREIGN KEY ([CurrentBitID])
    REFERENCES [dbo].[Items_Bit]
        ([ItemID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SpindleBit'
CREATE INDEX [IX_FK_SpindleBit]
ON [dbo].[Items_Spindle]
    ([CurrentBitID]);
GO

-- Creating foreign key on [TargetBitID] in table 'Items_Spindle'
ALTER TABLE [dbo].[Items_Spindle]
ADD CONSTRAINT [FK_SpindleBit1]
    FOREIGN KEY ([TargetBitID])
    REFERENCES [dbo].[Items_Bit]
        ([ItemID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SpindleBit1'
CREATE INDEX [IX_FK_SpindleBit1]
ON [dbo].[Items_Spindle]
    ([TargetBitID]);
GO

-- Creating foreign key on [AxisID] in table 'Items_Motor'
ALTER TABLE [dbo].[Items_Motor]
ADD CONSTRAINT [FK_MotorAxis]
    FOREIGN KEY ([AxisID])
    REFERENCES [dbo].[Axes]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MotorAxis'
CREATE INDEX [IX_FK_MotorAxis]
ON [dbo].[Items_Motor]
    ([AxisID]);
GO

-- Creating foreign key on [ItemID] in table 'Items_Spindle'
ALTER TABLE [dbo].[Items_Spindle]
ADD CONSTRAINT [FK_Spindle_inherits_Item]
    FOREIGN KEY ([ItemID])
    REFERENCES [dbo].[Items]
        ([ItemID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ItemID] in table 'Items_Bit'
ALTER TABLE [dbo].[Items_Bit]
ADD CONSTRAINT [FK_Bit_inherits_Item]
    FOREIGN KEY ([ItemID])
    REFERENCES [dbo].[Items]
        ([ItemID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ItemID] in table 'Items_Motor'
ALTER TABLE [dbo].[Items_Motor]
ADD CONSTRAINT [FK_Motor_inherits_Item]
    FOREIGN KEY ([ItemID])
    REFERENCES [dbo].[Items]
        ([ItemID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ItemID] in table 'Items_Controller'
ALTER TABLE [dbo].[Items_Controller]
ADD CONSTRAINT [FK_Controller_inherits_Item]
    FOREIGN KEY ([ItemID])
    REFERENCES [dbo].[Items]
        ([ItemID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------