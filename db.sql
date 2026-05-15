CREATE DATABASE IF NOT EXISTS ForFans;
USE ForFans;

CREATE TABLE  Usuarios (
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    senha VARCHAR(255) NOT NULL,
    dataRegistro DATETIME(3) DEFAULT CURRENT_TIMESTAMP(3)
);

CREATE TABLE PlanoAssinatura (
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    descricao VARCHAR(255) NOT NULL,
    duracaoDias INT NOT NULL,
    valor DECIMAL(10,2)
);

CREATE TABLE Assinatura (
	id INT PRIMARY KEY AUTO_INCREMENT,
    usuarioId INT,
    planoId INT,
    dataInicio DATETIME NOT NULL,
    dataFim DATETIME NOT NULL,
    ativa BOOLEAN,
	FOREIGN KEY (usuarioId) REFERENCES Usuarios(id),
    FOREIGN KEY (planoId) REFERENCES PlanoAssinatura(id)
);

CREATE TABLE Conteudo (
	id INT PRIMARY KEY AUTO_INCREMENT,
    usuarioId INT,
    titulo VARCHAR(200) NOT NULL,
    descricao TEXT,
    tipoConteudo VARCHAR(10) CHECK (tipoConteudo IN ('Imagem','Video')),
    arquivo LONGBLOB NOT NULL,
    tipoConteudo VARCHAR(50),
    nomeArquivo VARCHAR(255),
    FOREIGN KEY (usuarioId) REFERENCES Usuarios(id)
);

CREATE TABLE PermissoesConteudo (
	planoId INT,
    conteudoId INT,
    PRIMARY KEY (planoId, conteudoId),
    FOREIGN KEY (planoId) REFERENCES PlanoAssinatura(id),
	FOREIGN KEY (conteudoId) REFERENCES Conteudo(id)
);