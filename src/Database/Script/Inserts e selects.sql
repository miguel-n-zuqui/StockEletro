-- Inserindo dados na tabela Categoria
INSERT INTO Categoria (Nome, "Status")
VALUES ('Eletrônicos', 1), ('Móveis', 1), ('Livros', 1), ('Roupas', 1), ('Brinquedos', 1);

-- Inserindo dados na tabela Subcategoria
INSERT INTO Subcategoria (Nome, "Status", CategoriaId)
VALUES ('Celulares', 1, 1), ('Sofás', 1, 2), ('Romance', 1, 3), ('Camisetas', 1, 4), ('Bonecos', 1, 5);

-- Inserindo dados na tabela Departamento
INSERT INTO Departamento (Nome, "Status")
VALUES ('Vendas', 1), ('Marketing', 1), ('RH', 1), ('Financeiro', 1), ('TI', 1);

-- Inserindo dados na tabela Endereco
INSERT INTO Endereco (Cep, Uf, Municipio, Bairro, Logradouro, Numero)
VALUES ('29010-390', 'ES', 'Vitória', 'Centro', 'Rua General Osório', 83),
       ('29015-460', 'ES', 'Vitória', 'Centro', 'Avenida Princesa Isabel', 574),
       ('29015-160', 'ES', 'Vitória', 'Centro', 'Avenida Jerônimo Monteiro', 240),
       ('29010-800', 'ES', 'Vitória', 'Centro', 'Rua Duque de Caxias', 105),
       ('29015-140', 'ES', 'Vitória', 'Centro', 'Rua Pedro Palácios', 60),
	   ('29.902-150', 'ES', 'Linhares', 'Novo Horizonte', 'Avenida Barão Monjardim', 815),
	   ('29015-020', 'ES', 'Vitória', 'Centro', 'Rua José Alexandre Buaiz', 160),
       ('29015-010', 'ES', 'Vitória', 'Centro', 'Avenida Nossa Senhora dos Navegantes', 451),
       ('29010-335', 'ES', 'Vitória', 'Centro', 'Rua Misael Pedreira da Silva', 98),
       ('29010-650', 'ES', 'Vitória', 'Centro', 'Rua Almirante Tamandaré', 231),
       ('29010-360', 'ES', 'Vitória', 'Centro', 'Rua Graciano Neves', 222);
-- Inserindo dados na tabela Colaborador
INSERT INTO Colaborador (Nome, "Status", DataNascimento, Cpf, Email, Telefone, EnderecoId, DepartamentoId)
VALUES ('João Silva Pereira', 1, '1980-01-01', '000.000.000-00', 'joao.silva@email.com', '27999999999', 11, 1),
       ('Maria Santos Antonieta', 1, '1981-02-02', '111.111.111-11', 'maria.santos@email.com', '27999999998', 10, 2),
       ('Erwin Rudolf Josef Alexander Schrödinger', 1, '1982-03-03', '222.222.222-22', 'Schrodinger.Erwin@email.com', '27999999997', 9, 3),
       ('Max Karl Ernst Ludwig Planck', 1, '1983-04-04', '333.333.333-33', 'Marx.Planck@email.com', '27999999996', 8, 4),
       ('Niels Henrik David Bohr', 1, '1984-05-05', '444.444.444-44', 'Niels.Bohr@email.com', '27999999995', 7, 5),
	   ('Danillo Lopes Sousa',1,'2004-09-09','169.326.997-02', 'lopessousa2004@gmail.com','27999824821',6,3);

-- Inserindo dados na tabela Cliente
INSERT INTO Cliente (Nome, "Status", Cnpj, EnderecoId, Telefone)
VALUES ('Empresa XYZ', 1, '00.000.000/0001-00', 1, '2733333333'),
       ('Empresa ABC', 1, '11.111.111/1111-11', 2, '2733333332'),
       ('Empresa DEF', 1, '22.222.222/2222-22', 3, '2733333331'),
       ('Empresa GHI', 1, '33.333.333/3333-33', 4, '2733333330'),
       ('Empresa JKL', 1, '44.444.444/4444-44', 5, '2733333329');

-- Inserindo dados na tabela Usuario
INSERT INTO Usuario (Usuario, Senha, "Status", ColaboradorId)
VALUES ('joaosilva', 'senha1231', 1, 1),
       ('mariasantos', 'senha4561', 1, 2),
       ('ErwinSch', 'senha7891', 1, 3),
       ('mplanck', 'senha0121', 1, 4),
       ('NiBohr', 'senha3451', 1, 5),
	   ('danillols', '12345678', 1, 6);

-- Inserindo dados na tabela Produto
INSERT INTO Produto (Nome, "Status", Sku, Preco, EstoqueInicial, EstoqueEntrada, EstoqueSaida, NivelMinimo, CategoriaId, SubcategoriaId)
VALUES ('iPhone 13', 1, 'IP13', 6999.99, 100, 50, 10, 20, 1, 1),
       ('Sofá de Couro', 1, 'SC01', 2999.99, 50, 25, 5, 10, 2, 2),
       ('O Alquimista', 1, 'OA01', 29.99, 200, 100, 20, 40, 3, 3),
       ('Camiseta Polo', 1, 'CP01', 79.99, 150, 75, 15, 30, 4, 4),
       ('Boneco do Homem-Aranha', 1, 'BHA01', 99.99, 80, 40, 8, 16, 5, 5);

-- Selecionando todos os dados da tabela Categoria
SELECT * FROM Categoria;

-- Selecionando todos os dados da tabela Subcategoria
SELECT * FROM Subcategoria;

-- Selecionando todos os dados da tabela Departamento
SELECT * FROM Departamento;

-- Selecionando todos os dados da tabela Endereco
SELECT * FROM Endereco;

-- Selecionando todos os dados da tabela Colaborador
SELECT * FROM Colaborador;

-- Selecionando todos os dados da tabela Cliente
SELECT * FROM Cliente;

-- Selecionando todos os dados da tabela Usuario



-- Selecionando todos os dados da tabela Produto
SELECT * FROM Produto;