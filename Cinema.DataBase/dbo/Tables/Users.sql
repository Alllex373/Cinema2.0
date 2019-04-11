CREATE TABLE [dbo].[Users] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR (MAX) NULL,
    [SecondName] NVARCHAR (MAX) NULL,
    [Login]      NVARCHAR (MAX) NULL,
    [Password]   NVARCHAR (MAX) NULL,
    [SetOfRole]  NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);

