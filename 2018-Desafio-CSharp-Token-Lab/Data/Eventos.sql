CREATE TABLE [dbo].[Eventos]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [Data] DATE NOT NULL, 
    [Inicio] TIME NOT NULL, 
    [Fim] TIME NOT NULL, 
    [Descricao] TEXT NULL, 
    [IdUsuario] INT NOT NULL, 
    CONSTRAINT [FK_Eventos_Usuarios] FOREIGN KEY ([IdUsuario]) REFERENCES [Usuarios]([Id])
)
