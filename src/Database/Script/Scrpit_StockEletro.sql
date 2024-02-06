CREATE DATABASE STOCKELETRO
GO
USE STOCKELETRO
GO

--O BANCO PREENCHE AUTOMATICAMENTE O CRIADO EM E ALTERADO EM NA CRIAÇÃO DO BANCO

CREATE TABLE Categoria(
	Id int IDENTITY(1,1) NOT NULL
		CONSTRAINT PK_CategoriaId PRIMARY KEY(Id),
	Nome varchar(60) NOT NULL
		CONSTRAINT AK_Categoria_Nome UNIQUE(Nome),
	"Status" bit NOT NULL,
	CriadoEm datetime2(0) 
		CONSTRAINT DF_Categoria_CriadoEm DEFAULT GETDATE() NOT NULL
		
);

CREATE TABLE Subcategoria(
	Id int IDENTITY(1,1)
		CONSTRAINT PK_SubcategoriaId PRIMARY KEY(Id),
	Nome varchar(60)  NOT NULL
		CONSTRAINT AK_Subcategoria_Nome UNIQUE(Nome),
	"Status" bit NOT NULL,
	CategoriaId int NOT NULL
		CONSTRAINT FK_Subcategoria_Categoria 
		FOREIGN KEY(CategoriaId) REFERENCES Categoria(Id),
	CriadoEm datetime2(0) 
		CONSTRAINT DF_Subcategoria_CriadoEm DEFAULT GETDATE() NOT NULL
);


CREATE TABLE Departamento(
	Id int IDENTITY(1,1) NOT NULL
		CONSTRAINT PK_DepartamentoId PRIMARY KEY(Id),
	Nome varchar(60)  NOT NULL
		CONSTRAINT AK_Departamento_Nome UNIQUE(Nome),
	"Status" bit NOT NULL,
);

CREATE TABLE Endereco(
	Id int IDENTITY(1,1)
		CONSTRAINT PK_EnderecoId PRIMARY KEY(Id),
	Cep char(10) NOT NULL,
	Uf char(2) NOT NULL,
	Municipio varchar(60) NOT NULL,
	Bairro varchar(60) NOT NULL,
	Logradouro varchar(150) NOT NULL,
	Numero int NOT NULL
);

CREATE TABLE Colaborador(
	Id int IDENTITY(1,1) NOT NULL
		CONSTRAINT PK_ColaboradorId PRIMARY KEY(Id),
	Nome varchar(60) NOT NULL
	CONSTRAINT CK_Colaborador_Nome CHECK(LEN(Nome)>=10),
	"Status" bit NOT NULL,
	DataNascimento date NOT NULL,
	Cpf char(14) NOT NULL
		CONSTRAINT AK_Colaborador_Cpf UNIQUE(Cpf),
	Email varchar(100) NOT NULL,
	Telefone varchar(11) NOT NULL,
	EnderecoId int NOT NULL
		CONSTRAINT FK_Colaborador_Endereco
		FOREIGN KEY(EnderecoId) REFERENCES Endereco(Id),
	DepartamentoId int NOT NULL
		CONSTRAINT FK_Colaborador_Departamento
		FOREIGN KEY(DepartamentoId) REFERENCES Departamento(Id)
	
);

CREATE TABLE Cliente(
	Id int IDENTITY(1,1) NOT NULL
		CONSTRAINT PK_ClienteId PRIMARY KEY(Id),
	Nome varchar(60) NOT NULL
		CONSTRAINT AK_Cliente_Nome UNIQUE(Nome),
	"Status" bit NOT NULL,
	Cnpj char(18) NOT NULL 
		CONSTRAINT AK_Cliente_Cnpj UNIQUE(Cnpj),
		EnderecoId int NOT NULL
		CONSTRAINT FK_Cliente_Endereco
		FOREIGN KEY(EnderecoId) REFERENCES Endereco(Id),
	Telefone varchar(11) NOT NULL
);

CREATE TABLE Usuario(
	Id int IDENTITY(1,1)
		CONSTRAINT PK_UsuarioId PRIMARY KEY(Id),
	Usuario varchar(60) NOT NULL,
		CONSTRAINT AK_Usuario_Usuario UNIQUE(Usuario),
	Senha varchar(15) NOT NULL
		CONSTRAINT CK_Usuario_Senha CHECK(LEN(Senha)>=8),
	"Status" bit NOT NULL,
	ColaboradorId int NOT NULL
		CONSTRAINT FK_Usuario_Colaborador
			FOREIGN KEY(ColaboradorId) REFERENCES Colaborador(Id),
	CriadoEm datetime2(0) 
		CONSTRAINT DF_Usuario_CriadoEm DEFAULT GETDATE() NOT NULL,
	AlteradoEm datetime2(0) 
		CONSTRAINT DF_Usuario_AlteradoEm DEFAULT GETDATE() NOT NULL
); 

CREATE TABLE Produto(
Id int IDENTITY(1,1)
CONSTRAINT PK_ProdutoId PRIMARY KEY(Id),
Nome varchar(60)NOT NULL
CONSTRAINT AK_Produto_Nome UNIQUE(Nome)
CONSTRAINT CK_Produto_Nome CHECK(LEN(Nome)>=5),
"Status" bit NOT NULL,
Sku varchar(10) NOT NULL,
Preco decimal NOT NULL,
EstoqueAtual int NOT NULL,
NivelMinimo int NOT NULL,
CategoriaId int NOT NULL
CONSTRAINT FK_Produto_Categoria
FOREIGN KEY(CategoriaId) REFERENCES Categoria(Id),
SubcategoriaId int NOT NULL
CONSTRAINT FK_Produto_Subcategoria
FOREIGN KEY(SubcategoriaId) REFERENCES Subcategoria(Id),
CriadoEm datetime2(0)
CONSTRAINT DF_Produto_CriadoEm DEFAULT GETDATE() NOT NULL,
AlteradoEm datetime2(0)
CONSTRAINT DF_Produto_AlteradoEm DEFAULT GETDATE() NOT NULL
);


CREATE TABLE EstoqueEntrada (
    Id INT IDENTITY(1, 1) CONSTRAINT PK_EstoqueEntradaId PRIMARY KEY,
    ProdutoId INT,
    Quantidade INT NOT NULL,
    DataEntrada DATETIME NOT NULL,
    CONSTRAINT FK_ProdutoIdEntrada FOREIGN KEY (ProdutoId) REFERENCES Produto(Id)
);

CREATE TABLE EstoqueSaida (
    Id INT IDENTITY(1, 1) CONSTRAINT PK_EstoqueSaidaId PRIMARY KEY,
    ProdutoId INT,
	ClienteId INT,
    Quantidade INT NOT NULL,
    DataSaida DATETIME NOT NULL,
    CONSTRAINT FK_ProdutoIdSaida FOREIGN KEY (ProdutoId) REFERENCES Produto(Id),
	CONSTRAINT FK_ClienteId FOREIGN KEY (ClienteId) REFERENCES Cliente(Id)
);
