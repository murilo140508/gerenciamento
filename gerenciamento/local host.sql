create database gerenciamento;
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
insert into tipo(descricao) values("Analista de Sistemas");
insert into tipo(descricao) values("Desenvolvedor");
insert into tio(descricao) values("Gerente de TI");

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
Data_T Date,
ativo tinyint
);









