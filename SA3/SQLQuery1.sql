-- COMANDO PARA CRIAR BANCO DE DADOS
--CREATE DATABASE uc9SA3PBE10

-- COANDO PARA USAR O BANCO CRIADO
--USE uc9SA3PBE10

-- COMANDO PARA CRIAR UMA TABELA
CREATE TABLE Usuarios(
Id INT PRIMARY KEY IDENTITY,
-- CREAR USUARIO N�O PODE SER VAZIO
Email VARCHAR(50) UNIQUE NOT NULL,
Senha VARCHAR(50) NOT NULL
)
-- COMANDO PARA INSERIR USUARIOS DA TABELA
INSERT INTO Usuarios VALUES('adriano@gmail.com', 'admin1234')
INSERT INTO Usuarios VALUES('gustavo@gmail.com', 'admin1234')
INSERT INTO Usuarios VALUES('marlon@gmail.com', 'admin1234')

-- COMANDO PARA CONSULTAR DADOS DE UMA TABELA
SELECT Email, Senha FROM Usuarios 

-- COMANDO PARA CONSUTAR DADOS DE UMA TABELA USANDO A FUN��O DE HASHBYTES
-- NESSE EXEMPLO, VAMOS FAZER UM HASH DA SENHA CADASTRADA
SELECT Email, HASHBYTES('MD2', Senha) AS Senha FROM Usuarios
SELECT Email, HASHBYTES('MD4', Senha) AS Senha FROM Usuarios
SELECT Email, HASHBYTES('MD5', Senha) AS Senha FROM Usuarios
SELECT Email, HASHBYTES('SHA', Senha) AS Senha FROM Usuarios
SELECT Email, HASHBYTES('SHA2_256', Senha) AS Senha FROM Usuarios
SELECT Email, HASHBYTES('SHA2_512', Senha) AS Senha FROM Usuarios

-- COMANDO PARA CONSULTAR COM CONDICIONAL
SELECT Email, HASHBYTES('SHA2_512', Senha) AS Senha FROM Usuarios WHERE Id = 1

-- COMANDO PARA COLSULTA , USANDO A FUN��O PWDENCRYPT (SENHAS IGUAIS GERAM HASHS DIFERENTES)
SELECT Email, PWDENCRYPT(Senha) AS Senha FROM Usuarios