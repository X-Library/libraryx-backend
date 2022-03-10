USE [libraryx-dev]
GO

BEGIN TRANSACTION
CREATE TABLE [Category]
(
    [Id]          [UNIQUEIDENTIFIER] NOT NULL,
    [Title]       [NVARCHAR](80)     NOT NULL,
    [Description] [NVARCHAR](MAX)    NOT NULL
)
GO

ALTER TABLE [Category]
    ADD CONSTRAINT [PK_Category]
        PRIMARY KEY ([Id])
GO
ROLLBACK