create database MAXIKIOSCO_DB

create table provedor(
id int identity,
nom_razonsocial varchar(30) not null,
telefono int not null,
mail varchar(40) not null,
direccion varchar(50) not null,
cuit int not null,
activo bit default 1,
primary key (id)
)

select id, nom_razonsocial, telefono, mail, direccion, cuit, activo from provedor

insert into provedor
values ('Coca Cola sociedad anonima', 11338742, 'cocacolasociedadanonima@gmail.com',
'avenida siempre viva', 298649213, 1)
insert into provedor
values ('Playadito sociedad', 31245645, 'YerbaPlayadito@gmail.com',
'calle falsa 123', 543526546, 1)
insert into provedor
values ('Taragui', 21242354, 'Taraguilala@gmail.com',
'calle lala', 312412452, 1)


create table producto(
id int identity,
categoria varchar(25) not null,
marca varchar(25) not null,
cantidad int not null default 1,
stockMinimo int not null default 1,
stockMaximo int not null default 1,
precio int not null,
activo bit default 1,
idProvedor int,
primary key(id),
foreign key (idProvedor) references provedor(id)
)

insert into producto
values ('Gaseosa','Coca Cola', 100, 60, 200, 500, 1, 1)
insert into producto
values ('Yerba','Playadito', 30, 10, 30, 300, 1, 1)
insert into producto
values ('Yerba','Taragui', 30, 10, 30, 330, 1, 1)

select id, categoria Categoria, marca Marca, stockMinimo 'Stock Minimo', cantidad 'Cantidad',
stockMinimo 'Stock Minimo',precio Precio, activo Activo, idProvedor 'Id Del Provedor'
from producto

select * from producto