CREATE TABLE IF NOT EXISTS editora (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    documento VARCHAR(11) NOT NULL UNIQUE
);

SELECT 
    *
FROM
    autor;



INSERT INTO autor (
 nome,
    documento
) VALUES 
('rafael sousa', '04954132088'),
('mark manson', '09978898026'),
('monteiro lobatto', '35505614078'),
('kanye west', '86244487001'),
('larissa matos', '45090006008'),
('marildo', '83877450067'),
('daniela machado', '35291557052'),
('j. k. rowling', '83505744026'),
('richard russell riordan jr.', '85744402055'),
('tony stark', '52701783038'),
('felipe oliveira', '74429432090'),
('thm', '63205511000'),
('j.r.r. tolkien', '21285902050'),
('george orwell', '17170015056'),
('guilherme diniz', '91780337051'),
('andré luiz', '83861448076'),
('ray bradbury', '47257489009');



INSERT INTO genero (nome)
VALUES
('tecnologia'),
('documentário cinematográfico'),
('terror'),
('drama'),
('entrevista'),
('aventura'),
('fantasia'),
('ação'),
('ficção científica'),
('romance distópico');


INSERT INTO editora ( nome, documento)
VALUES
('intrínseca', '21306675000133'),
('abril', '87067440000144'),
('globo', '03708536000154'),
('panini', '22455174000181'),
('rocco ltda.', '41500632000100'),
('darkside', '80731635000106'),
('marvel', '49420531000122'),
('harpercollins', '36780957000145'),
('companhia das letras', '20413077000109'),
('senac', '82535051000182'),
('biblioteca azul', '97045992000105');





/*
genero
 tecnologia
 Documentário
 Terror
 Drama
 Literatura fantástica
 fantasia
 Ação
 Fantasia
 Aventura
 Romance distópico
*/

/*
editora
Intrínseca
Abril
Globo
Panini
Rocco Ltda.
Darkside
Marvel
araujo
starSol
HarperCollins
Companhia das Letras
Productions
Senac
Biblioteca Azul
*/

select * from livro, genero, autor, editora where livro.id_genero = genero.id and livro.id_autor = autor.id and livro.id_editora = editora.id;




drop table livro;