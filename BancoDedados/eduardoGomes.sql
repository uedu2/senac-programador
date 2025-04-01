CREATE TABLE IF NOT EXISTS empregado (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    idade INT NOT NULL,
    departamento VARCHAR(50),
    salario DECIMAL(10 , 2 ) NOT NULL
);

insert into empregado(
nome, idade, departamento, salario

) values
(
	"João",
    30,
    "RH",
    50000
),
(
	"Sarah",
    28,
    "TI",
    60000
),
(
	"Miguel",
    35,
    "Vendas",
    55000
),
(
	"Ana",
    27,
    "TI",
    62000
);

-- Tarefa 1
SELECT 
    *
FROM
    empregado
WHERE
    departamento = 'TI';

SELECT 
    nome, salario
FROM
    empregado
WHERE
    salario > 55000;

SELECT 
    *
FROM
    empregado
ORDER BY idade DESC;

-- Tarefa 2
SELECT 
    *
FROM
    empregado
WHERE
    idade BETWEEN 28 AND 35;

SELECT 
    *
FROM
    empregado
WHERE
    nome LIKE 'M%';

SELECT 
    *
FROM
    empregado
WHERE
    departamento != 'RH';

-- Tarefa 3
SELECT
    departamento,
    COUNT(departamento) as empregados
FROM empregado
GROUP BY departamento;

SELECT AVG(salario) as média_TI
FROM empregado where departamento = "TI";

SELECT count(salario) as salarios_Vendas 
FROM empregado where departamento = "Vendas";

-- tarefa 4
drop table empregado;

CREATE TABLE IF NOT EXISTS departamento (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL
);

insert into departamento(
	nome
)
values
("RH"),
("TI"),
("Vendas"),
("Café e Pão de Queijo"),
("Pesquisas Equivocadas"),
("Punições Agrículas");


drop table departamento;

CREATE TABLE IF NOT EXISTS empregado(
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    idade INT NOT NULL,
    departamento_id int not null,
    salario DECIMAL(10 , 2 ) NOT NULL,
    foreign key (departamento_id)
		references departamento (id)
);

insert into empregado(
	nome,idade,departamento_id, salario
)
values
("João",
	38,
	1, 
	50000
 ),
("Sarah",
    28,
    2,
    60000),
("Miguel",
    35,
    3,
    55000),
("Ana",
    27,
    2,
    62000);
    -- Select Teste 
    SELECT 
    empregado.nome,
    empregado.idade,
    empregado.salario,
    departamento.nome AS departamento
FROM
    empregado
        JOIN
    departamento ON empregado.departamento_id = departamento.id;
    
    -- Tarefa 4
    SELECT 
    empregado.nome,
    empregado.idade,
    empregado.salario,
    departamento.nome AS departamento
FROM
    empregado
        INNER JOIN
    departamento ON empregado.departamento_id = departamento.id;
    
    
    SELECT 
    empregado.nome,
    empregado.idade,
    empregado.salario,
    departamento.nome AS departamento
FROM
    departamento
        LEFT JOIN
    empregado ON departamento.id = empregado.departamento_id;

-- Tarefa 5
	
    SELECT 
    *
FROM
    empregado
WHERE
    salario > (SELECT 
            AVG(salario)
        FROM
            empregado);
    
SELECT 
    empregado.nome,
    empregado.idade,
    empregado.salario,
    departamento.nome
FROM 
      empregado
        INNER JOIN
    departamento ON empregado.departamento_id = departamento.id
WHERE 
    empregado.nome = "Sarah";
    
    
    
    
    
    