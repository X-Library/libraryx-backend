USE [libraryx-dev]
GO

BEGIN TRANSACTION
    CREATE TABLE [Book]
    (
        [Id]          [UNIQUEIDENTIFIER] NOT NULL,
        [AuthorId]    [UNIQUEIDENTIFIER] NOT NULL,
        [CategoryId]  [UNIQUEIDENTIFIER] NOT NULL,
        [Title]       [NVARCHAR](80)     NOT NULL,
        [Description] [NVARCHAR](MAX)    NOT NULL,
        [ISSN]        [VARCHAR](13)      NOT NULL
    )

    ALTER TABLE [Book]
        ADD CONSTRAINT [PK_Book]
            PRIMARY KEY ([Id])
    GO

    ALTER TABLE [Book]
        ADD CONSTRAINT [FK_Book_Author_AuthorID]
            FOREIGN KEY ([AuthorId])
                REFERENCES [Author]
    GO

    ALTER TABLE [Book]
        ADD CONSTRAINT [FK_Book_Category_CategoryID]
            FOREIGN KEY ([CategoryId])
                REFERENCES [Category]
    GO
ROLLBACKcd