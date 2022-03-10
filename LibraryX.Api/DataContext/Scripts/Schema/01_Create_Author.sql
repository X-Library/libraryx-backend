USE
[libraryx-dev]
GO

BEGIN
TRANSACTION
CREATE TABLE [Author]
(
    [
    Id] [
    UNIQUEIDENTIFIER]
    NOT
    NULL, [
    Name] [
    NVARCHAR]
(
    80
) NOT NULL,
    [LastName] [NVARCHAR]
(
    80
) NOT NULL,
    [Nationality] [VARCHAR]
(
    80
) NOT NULL,
    [Email] [VARCHAR]
(
    160
) NOT NULL
    )
    GO

ALTER TABLE [Author]
    ADD CONSTRAINT [PK_Author]
    PRIMARY KEY ([ID])
    GO

CREATE
NONCLUSTERED INDEX [IX_Author_Email]
        ON [Author] ([Email])
    GO
ROLLBACK