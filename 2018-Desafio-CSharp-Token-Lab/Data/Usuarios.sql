CREATE TABLE [dbo].[Usuarios]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	Login varchar(100) unique not null,
	Senha varchar(max) not null
)
