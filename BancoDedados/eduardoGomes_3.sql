drop table produto;
CREATE TABLE IF NOT EXISTS produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    categoria VARCHAR(50),
    preco DECIMAL(10 , 2 ) NOT NULL,
    estoque INT NOT NULL,
    fornecedor_id INT NOT NULL,
    FOREIGN KEY (fornecedor_id)
        REFERENCES fornecedor (id)
);
drop table fornecedor;
create table if not exists fornecedor(
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    cidade  VARCHAR(100)
);
drop table pedido;
CREATE TABLE IF NOT EXISTS pedido (
    id INT PRIMARY KEY AUTO_INCREMENT,
    produto_id int NOT NULL,
    quantidade INT NOT NULL,
    data_pedido datetime NOT NULL,
    cliente_id INT NOT NULL,
    FOREIGN KEY (produto_id)
        REFERENCES produto (id),
	FOREIGN KEY (cliente_id)
        REFERENCES cliente (id)
	
);
drop table cliente;
create table if not exists cliente(
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    cidade  VARCHAR(100),
    idade int NOT NULL
);

insert into fornecedor (nome, cidade)
values ("TechBrasil", "São Paulo"),
("Computhech", "Rio de Janeiro"),
("Moveis&Co", "Curitiba");

insert into produto (nome, categoria, preco, estoque, fornecedor_id)
values ("Celular X", "Eletrônicos",2500,30,1),
("Notebook Y", "Eletrônicos",4800,15,2),
("Mesa de Madeira", "Móveis",750,10,3),
("Cadeira Z", "Móveis",300,25,3),
("TV 50", "Eletrônicos",3500,8,1);

insert into cliente (nome, cidade, idade)
values ("João Silva", "São Paulo", 35),
("Maria Santos", "Belo Horizonte", 28),
("Carlos Lima", "rio de janeiro",42),
("Fernanda Rocha", "rio de janeiro",30);

insert into pedido (produto_id, quantidade, data_pedido, cliente_id) values
(
	1,2,"2024-03-10",1
),
(
	3,1,"2024-03-11",2
),
(
	2,1,"2024-03-15",3
),
(
	5,3,"2024-03-18",1
),
(
	4,4,"2024-03-20",4
);
 
 SELECT 
    produto.nome, produto.categoria, produto.preco, fornecedor.nome, fornecedor.cidade
FROM
    produto
       JOIN
    fornecedor ON produto.fornecedor_id = fornecedor.id;
 
 
 
 
 
SELECT 
    nome, preco
FROM
    produto
WHERE
    categoria = 'Eletrônicos'
        AND preco > 3000
ORDER BY preco DESC;

SELECT 
    nome, cidade, idade
FROM
    cliente
    
WHERE
    cidade != 'São Paulo' AND idade > 30;

SELECT 
    *
FROM
    pedido
WHERE
    data_pedido BETWEEN '2024-03-10' AND '2024-03-15'
ORDER BY data_pedido ASC;

SELECT 
    *
FROM
    produto
WHERE
    estoque < 10
ORDER BY estoque ASC;

SELECT 
    *
FROM
    fornecedor
WHERE
    cidade != 'Rio de Janeiro'
        AND nome LIKE 'T%';


SELECT
	 produto.categoria,AVG(preco)
FROM produto
GROUP by categoria;

select count(produto_id), pedido.* from pedido group by cliente_id;



