CREATE DATABASE db3camadas; 
USE db3camadas; 

CREATE TABLE tbl_Medicamento
(
	id        	  INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	medicamento	  VARCHAR(40) NOT NULL,
	composicao	  VARCHAR(200) NOT NULL
);

CREATE TABLE tbl_Receita
(
	codigo		   INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nomePaciente   VARCHAR(30),
	idMedicamento  INT NOT NULL, 
	FOREIGN KEY(idMedicamento) REFERENCES tbl_Medicamento(id)
);