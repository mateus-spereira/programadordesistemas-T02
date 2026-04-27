CREATE DATABASE db_formulariosimples;

CREATE TABLE formulariosimples(
id INT AUTO_INCREMENT PRIMARY KEY,
Nome VARCHAR(100) NOT NULL,
NumeroCadastro INT (6) NOT NULL,
DatadeNascimento DATE,
Estado VARCHAR(100),
Genero BOOLEAN
);

ALTER TABLE formulariosimples MODIFY Genero VARCHAR(20);