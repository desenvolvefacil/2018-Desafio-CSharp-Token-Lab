CREATE TABLE [dbo].[Eventos] (
    [Id]        INT      IDENTITY (1, 1) NOT NULL,
    [Data]      DATE     NOT NULL,
    [Inicio]    TIME (7) NOT NULL,
    [Fim]       TIME (7) NOT NULL,
    [Descricao] VARCHAR (MAX)    NULL,
    [IdUsuario] INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Eventos_Usuarios] FOREIGN KEY ([IdUsuario]) REFERENCES [dbo].[Usuarios] ([Id])
);

