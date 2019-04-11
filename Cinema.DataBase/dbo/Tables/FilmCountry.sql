CREATE TABLE [dbo].[FilmCountry] (
    [FilmId]    INT NOT NULL,
    [CountryId] INT NOT NULL,
    CONSTRAINT [PK_FilmCountry] PRIMARY KEY CLUSTERED ([FilmId] ASC, [CountryId] ASC),
    CONSTRAINT [FK_FilmCountry_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([Id]),
    CONSTRAINT [FK_FilmCountry_Film] FOREIGN KEY ([FilmId]) REFERENCES [dbo].[Film] ([Id])
);

