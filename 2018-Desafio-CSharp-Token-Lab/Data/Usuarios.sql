CREATE TABLE [dbo].[Usuarios]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	Nome varchar(100) not null,
	Login varchar(100) not null,
	Senha text not null
)
