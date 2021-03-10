# Projetos-c-sharp
Projetos de código aberto em c-sharp
=========================================
o projeto ainda esta na sua fase inicial entao ainda nao possui banco online
===========================================
BANCO mysql
===========================================
drop database estudo;
create database estudo;
use estudo;

create table usuario
(nick varchar(150) primary key not null,
nome varchar(150) not null,
dt_nascimento datetime not null,
idade int not null,
cargo enum('dba','developer','designer') not null,
foto longblob ,
registro datetime not null
)engine=innodb;

create table contato
(id int primary key auto_increment not null,
telefonere varchar(150),
telefonecel varchar(150),
email varchar(150) not null,
nick varchar(150) not null,
foreign key (nick) references usuario(nick) on delete cascade on update cascade
)engine=innodb;
 
create table endereco
(id int primary key auto_increment not null,
cep char(9) not null,
rua varchar(150) not null,
complemento1 varchar(150),
complemento2 varchar(150),
numero varchar(150) not null,
nick varchar(150) not null,
constraint nick foreign key (nick) references usuario(nick) on delete cascade on update cascade
)engine=innodb;

create table login
(id int primary key auto_increment not null,
acesso enum ('junior','senior','master') not null,
senha varchar(150) not null,
nick varchar(150) not null,
foreign key (nick) references usuario(nick) on delete cascade on update cascade
)engine=innodb;

create table pesquisa
(id int primary key auto_increment not null,
url varchar(150) not null,
registro datetime not null,
navegador enum('Google chorme') not null,
nick varchar(150) not null,
foreign key (nick) references usuario (nick)  on delete cascade  on update cascade
)engine=innodb;

create table agenda 
(titulo varchar(150) primary key not null,
texto varchar(150) not null,
dt datetime not null,
registro datetime not null,
nick varchar(150) not null,
foreign key (nick) references usuario (nick) on delete cascade  on update cascade
)engine=innodb;

use estudo;
select * from usuario;
insert into contato(telefonere ,telefonecel,email ,nick )values ('(11)11111-1111','(11)1111-1111','a@gmail.com','a');


