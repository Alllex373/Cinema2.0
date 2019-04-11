CREATE TABLE [dbo].[FilmGenre] (
    [Filmid]  INT NOT NULL,
    [GenreId] INT NOT NULL,
    CONSTRAINT [PK_FilmGenre] PRIMARY KEY CLUSTERED ([Filmid] ASC, [GenreId] ASC),
    CONSTRAINT [FK_FilmGenre_Film] FOREIGN KEY ([Filmid]) REFERENCES [dbo].[Film] ([Id]),
    CONSTRAINT [FK_FilmGenre_Genre] FOREIGN KEY ([GenreId]) REFERENCES [dbo].[Genre] ([Id])
);

