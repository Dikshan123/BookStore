CREATE TABLE [dbo].[AuthorContact] (
    [AuthorId]      INT            NOT NULL,
    [ContactNumber] NVARCHAR (15)  NULL,
    [Address]       NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([AuthorId] ASC),
    FOREIGN KEY ([AuthorId]) REFERENCES [dbo].[Author] ([Id])
);

