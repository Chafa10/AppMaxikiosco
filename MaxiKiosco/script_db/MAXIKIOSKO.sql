create database MAXIKIOSCO_DB

create table PROVEDOR(
Id int identity,
Nom_razonsocial varchar(30) not null,
Telefono int not null,
Mail varchar(40) not null,
Direccion varchar(50) not null,
Cuit int not null,
Activo bit default 1,
primary key (Id)
)



insert into PROVEDOR
values ('Coca Cola sociedad anonima', 11338742, 'cocacolasociedadanonima@gmail.com',
'avenida siempre viva', 298649213, 1)
insert into PROVEDOR
values ('Playadito sociedad', 31245645, 'YerbaPlayadito@gmail.com',
'calle falsa 123', 543526546, 1)
insert into PROVEDOR
values ('Taragui', 21242354, 'Taraguilala@gmail.com',
'calle lala', 312412452, 1)


create table PRODUCTO(
Id int identity,
Categoria varchar(25) not null,
Marca varchar(25) not null,
Cantidad int not null default 1,
StockMinimo int not null default 1,
StockMaximo int not null default 1,
Precio int not null,
Activo bit default 1,
IdProvedor int,
primary key(Id),
foreign key (IdProvedor) references PROVEDOR(Id)
)

insert into PRODUCTO
values ('Gaseosa','Coca Cola', 100, 60, 200, 500, 1, 1)
insert into PRODUCTO
values ('Yerba','Playadito', 30, 10, 30, 300, 1, 1)
insert into PRODUCTO
values ('Yerba','Taragui', 30, 10, 30, 330, 1, 1)


select * from PRODUCTO

create table Rol (
id int identity,
nombre varchar(30),
descripcion varchar(30)
primary key (id)
)

create table Usuario(
id int identity,
nombreUsuario varchar(30),
contrasenia varchar(30),
idRol int,
primary key (id),
foreign key (idRol) references Rol(id)
)

insert into Rol
VALUES ('Administrador','MASTER')
insert into Rol
VALUES ('Usuario','Normal')

insert into Usuario
Values ('Javierg','123',1)