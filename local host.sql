create database projeto;
use projeto;
create table cargo(
codigocargo int primary key auto_increment,
cargo varchar(100)
);
create table Funcionario(
codigo int primary key auto_increment,
nome varchar(60),
email varchar(60),
senha varchar(255),
salario varchar(60),
cargo int,
constraint fk_cargo foreign key (cargo) references cargo(codigocargo)
);

create table tipo(
codigotipo int primary key auto_increment,
descricao varchar(100)
);
insert into tipo(descricao) values("");
insert into tipo(descricao) values("");

create table produto(
codigoproduto int primary key auto_increment,
descricao varchar(100),
valor decimal(5,2),
quantidade int,
foto varchar(100),
nome varchar(45),
tipo int,
constraint fk_tipo foreign key (tipo) references tipo(codigotipo)
);

create table  Financeiro(
codigofinanceiro int primary key auto_increment,
descriçao varchar(100),
valor decimal(5,2),
tipo int,
serviço int,
Data_T Date
);

INSERT INTO Funcionarios (nome, cargo, salario) VALUES
('João Silva', 'Analista de Sistemas', 4500.00),
('Maria Oliveira', 'Desenvolvedora', 5000.00),
('Carlos Souza', 'Gerente de TI', 8000.00);

-- Produtos
INSERT INTO Produtos (nome_produto, preco, estoque) VALUES
('Notebook', 3500.00, 10),
('Smartphone', 1500.00, 20),
('Cadeira Ergonomica', 800.00, 5);

-- Transações Financeiras
INSERT INTO Financeiro (tipo, valor, data, id_funcionario, id_produto) VALUES
('entrada', 3500.00, '2025-09-01', 2, 1),  -- João Silva vendendo um notebook
('saida', 1500.00, '2025-09-02', 3, 2),   -- Maria Oliveira comprando um smartphone
('entrada', 8000.00, '2025-09-03', 1, NULL); -- Carlos Souza recebendo um pagamento sem produto associado







