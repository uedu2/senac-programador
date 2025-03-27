SELECT 
    *
FROM
    usuario
WHERE
    id = 1;
  
  
  SELECT 
    *
FROM
    wesley
WHERE
    email  LIKE '%@email.com';
    
    CREATE TABLE IF NOT EXISTS wesley (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    sobrenome VARCHAR(50) NOT NULL UNIQUE,
    apelido VARCHAR(16) NOT NULL,
    filme_favorito VARCHAR(100) NOT NULL
);

insert into wesley (
	nome, 
    sobrenome, 
    apelido,
    filme_favorito
) 
values 
('Wesley','Alexandre','Wesley','Clube da Luta'),
('Weslei','Carvalho','Abraham Lincoln','Garfild Cai na Real'),
('Uesley','Rocha','Ué?','James e o Pêssego Gigante'),
('VVeslei','Gomes','Çousa','Ace Ventura 2'),
('\/\/esley','Silva','Luz','Barbie Castelo de Cristal'),
('YYesley','Lira','Uae','Fuga das Galinhas'),
('UUeslei','Lee','Chun','Kung Fu Pow'),
('HHesley','Huck','Guerra','Ghosted: Sem Resposta'),
('\|/esley','Safadão','Saas','Mosconautas no Mundo da Lua'),
('W3sley','Lucas','Barry','O Genio do Videogame'),
('Wksley','Lengue','Lango','LEGO: As Aventuras dos Clutch Powers'),
('We5ley','Gazotti','Rozzz','O Grilo Feliz'),
('Wesney','Santos','Ney','FormiguinhaZ'),
('Weswei','Araújo','Meida','Ataque dos Tomates Assassinos'),
('11135731','Ferreira','Wes','Rubber: O Pneu Assassino');

SELECT 
    *
FROM
    wesley;
    