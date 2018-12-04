create database Envios
go
use Envios
go
create Table Usuarios
(
	UsuarioID int primary key identity(1,1),
	Nombre varchar(30),
	NombreUsuario varchar (max),
	Contrasena varchar (15)
	

);
go

set dateformat dmy;

insert into Usuarios values('Rood Jerry Pierre','JER','123456')

go
create Table Monedas
(
	MonedasID int primary key identity(1,1),
	TipoMonedas varchar(15),
	Inventario money

);
go
create table EntradaMonedas
(
	EntradaId int primary key identity(1,1),
	Fecha date,
	Cantidad int,
	MonedasID int,
	

);
go
create table Clientes 
(
	ClienteID int primary key identity(1,1),
	Nombres varchar(30),
	Direccion varchar(max),
	Identidad varchar(15),
	Telefono varchar(15)

);
go
create table Envios
(
	EnviosID int primary key identity(1,1),
	MonedasID int,
	ClienteID int,
	Fecha date,
	Autorizacion varchar(15),
	Beneficiario varchar(30),
	Ordenante varchar (30),
	Identidad varchar(15),
	TelefonoOrdenante varchar (15),
	PaisOrigen varchar (15),
	Cajero varchar (30),
	Efectivo money
);
go
create table EnviosDetalles
(
	ID int primary key identity(1,1),
	EnviosID int,
	UsuarioID int,
	MonedasID int,
	Cantidad int,
	Monedas varchar (15),
	Cantidad int,
	Importe int,
	ClienteID int
	
	

);
go


select *from Usuarios
select *from Monedas
select *from EntradaMonedas
select *from Clientes
select *from Envios
select *from EnviosDetalles
