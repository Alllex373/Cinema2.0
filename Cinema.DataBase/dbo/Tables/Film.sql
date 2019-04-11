CREATE TABLE [dbo].[Film] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [ScrennShoots] NVARCHAR (MAX) NULL,
    [Duration]     FLOAT (53)     NULL,
    CONSTRAINT [PK_Film] PRIMARY KEY CLUSTERED ([Id] ASC)
);

