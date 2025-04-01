CREATE TABLE IF NOT EXISTS cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    idade INT NOT NULL,
    cidade VARCHAR(100),
    saldo DECIMAL(10 , 2 ) NOT NULL
);
insert into cliente (
	nome, idade,cidade,saldo
)
values
(
 "Carlos",
45,
"São Paulo",
2500.00
),
(
	"Mariana",
    32,
    "Rio de Janeiro",
    3200.50
),
(
	"Pedro",
    27,
    "Belo Horizonte",
    1500.75
),
(
	"Fernanda",
    38,
    "Curitiba",
    4200.00
);

select * from cliente;

select * from cliente where cidade = "Rio de Janeiro";

select * from cliente where saldo > 2000 order by saldo desc;

select nome, idade from cliente where idade > 30;


select * from cliente where idade between 25 and 40;

select * from cliente where nome like "f%";

select * from cliente where cidade != "São Paulo" and cidade != "Curitiba";


create table if not exists pedido(
	 id INT PRIMARY KEY AUTO_INCREMENT,
	cliente_id int not null,
    valor decimal(10 , 2 ) NOT NULL,
     data_pedido DATETIME NOT NULL,
       foreign key (cliente_id)
		references cliente (id)
);

insert into pedido(
	cliente_id,
    valor,
    data_pedido
)
values
(1,
500.00, 
"2024-03-10"
),
(2,
1200.00, 
"2024-03-12"
),
(3,
300.00, 
"2024-03-15"
),
(4,
800.00, 
"2024-03-18"
);


SELECT 
    cliente.nome,
    cliente.cidade,
    pedido.valor AS valor_pedido,
    pedido.data_pedido as data_pedido
FROM
    pedido
        INNER JOIN
    cliente ON pedido.cliente_id = cliente.id;
    
    SELECT 
    cliente.nome,
    cliente.cidade,
    pedido.valor AS valor_pedido,
    pedido.data_pedido as data_pedido
FROM
    cliente
        left JOIN
    pedido ON cliente.id = pedido.cliente_id;
    
    
    SELECT 
    cliente.nome,
    cliente.cidade,
    pedido.valor AS valor_pedido,
    pedido.data_pedido as data_pedido
FROM
    pedido
        INNER JOIN
    cliente ON pedido.cliente_id = cliente.id where valor > (select avg(valor) from pedido); 
    
    
    
    SELECT 
    cliente.nome,
    cliente.cidade,
    pedido.valor AS valor_pedido,
    pedido.data_pedido as data_pedido
FROM
    pedido
        INNER JOIN
    cliente ON pedido.cliente_id = cliente.id where valor > 1000;
    
    
    insert into cliente
    (
		nome,cidade
    )values("Rafael","Porto Alegre");
    
    update cliente
    set saldo = saldo + (0.1 * saldo);
    
    
    delete from pedido where valor < 500;
    
    








