CREATE TABLE [dbo].[Usuarios] (
    [Id]    INT           IDENTITY (1, 1) NOT NULL,
    [Login] VARCHAR (100) NOT NULL,
    [Senha] VARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Login] ASC)
);

