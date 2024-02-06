CREATE TABLE [dbo].[Book] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (100) NOT NULL,
    [CategoryId]  INT            NOT NULL,
    [PublisherId] INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[BookCategory] ([Id]),
    FOREIGN KEY ([PublisherId]) REFERENCES [dbo].[Publisher] ([Id])
);

