/*CRIANDO O BANCO DADOS*/
CREATE DATABASE BDCrud2B;

/*USANDO O BANCO DE DADOS*/
USE BDCrud2B;

/*CRIANDO AS TABELAS DO BANCO */

CREATE TABLE Usuario(
	Id INT PRIMARY KEY auto_increment,
    Nome varchar(50) not null,
    Email varchar(50) not null,
    Senha varchar(50) not null
);

/*CONSULTANDO AS TABELAS DO BANCO*/

SELECT * FROM Usuario;