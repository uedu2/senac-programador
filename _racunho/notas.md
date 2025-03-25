0101001 0101001
sgbd
constraint
[primary key]*
[foreign key]
[unique]
[auto_increment]*


{todas as nossas ids serão numeros}



entidade -> classe
	- vai ser igual
	- dominio da nossa aplicação
	

{tabela}
	- usuario
		-> ID = int primary key auto_increment
		-> nome = varchar(100) not null
		-> email = varchar(50) not null
		-> senha = varchar(16) not null // null até -> confirmar email
__________________________________________________________________________
	- mysql
		-> console
		-> mysql workbench
		-> DBeaver