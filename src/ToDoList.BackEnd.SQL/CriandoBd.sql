CREATE DATABASE db_ToDoList;

--Criando tabela de Tarefa =============
USE db_ToDoList;
CREATE TABLE Tarefa(
	Id INT PRIMARY KEY NOT NULL,
	Nome VARCHAR (50) NOT NULL,
	Descricao VARCHAR (150),
	Categoria VARCHAR (20),
	DataPrazo Date 
);