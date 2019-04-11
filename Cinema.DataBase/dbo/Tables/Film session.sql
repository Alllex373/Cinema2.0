CREATE TABLE [dbo].[Film session] (
    [Id]     INT      IDENTITY (1, 1) NOT NULL,
    [FilmId] INT      NULL,
    [Slot]   DATETIME NULL,
    [HallId] INT      NULL,
    CONSTRAINT [PK_Film session] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Film session_Film] FOREIGN KEY ([FilmId]) REFERENCES [dbo].[Film] ([Id]),
    CONSTRAINT [FK_Film session_Hall] FOREIGN KEY ([HallId]) REFERENCES [dbo].[Hall] ([Id])
);

