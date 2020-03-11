CREATE DATABASE Senatur_Tarde;

USE Senatur_Tarde;

CREATE TABLE Pacotes(
IdPacote		INT PRIMARY KEY IDENTITY,
NomePacote		VARCHAR (255),
Descricao		TEXT,
DataIda			DATETIME,
DataVolta		DATETIME,
Valor			DECIMAL,
NomeCidade		VARCHAR (255),
IdStatusViagem	INT FOREIGN KEY REFERENCES StatusViagem(IdStatusViagem)
);

CREATE TABLE StatusViagem(
IdStatusViagem		INT PRIMARY KEY IDENTITY,
TituloStatus		VARCHAR (255)
);

CREATE TABLE TiposUsuario(
IdTipoUsuario		INT PRIMARY KEY IDENTITY,
Titulo				VARCHAR(255)
);

CREATE TABLE Usuarios(
IdUsuario		INT PRIMARY KEY IDENTITY,
Email			VARCHAR (255),
Senha			VARCHAR (255),
IdTipoUsuario	INT FOREIGN KEY REFERENCES TiposUsuario(IdTipoUsuario)
);
