GO
CREATE DATABASE [Segtransa]
GO

USE [Segtransa]
GO

---------------------- DROP TABLES -----------------
/*
DROP TABLE Usuarios
DROP TABLE Activos
DROP TABLE THAsignaciones
DROP TABLE THReparaciones
DROP TABLE Categoria
DROP TABLE EstadoActivo
DROP TABLE EstadoUsuario
DROP TABLE Proveedores
DROP TABLE Rol_Usuario
DROP TABLE Bitacora
DROP TABLE Depreciacion
*/

------------------- SELECT * FROM ------------------

/*
select * from Proveedores
select * from Activos
select * from Usuarios
select * from RolUsuarios
select * from EstadoActivos
select * from EstadoUsuarios
select * from Categorias
select * from Bitacora
select * from THAsignaciones
select * from THReparaciones
select * from Depreciacion
*/

--------------------- CREATE TABLES -------------------

CREATE TABLE EstadoActivos
(
	IdEstadoActivo int IDENTITY(1,1) NOT NULL,
	NombreEstado nvarchar(20) NOT NULL,
 CONSTRAINT PK_EstadoActivos PRIMARY KEY (IdEstadoActivo)
 );
DBCC CHECKIDENT ('[EstadoActivos]', RESEED, 1);
GO

CREATE TABLE EstadoUsuarios
(
	IdEstadoUsuario int identity(1,1) NOT NULL,
	NombreEstado nvarchar(20) NOT NULL,
	constraint PK_EstadoUsuarios primary key (IdEstadoUsuario)
);
DBCC CHECKIDENT ('[EstadoUsuarios]', RESEED, 1);
GO


CREATE TABLE RolUsuarios
(
	IdRol int identity(1,1) NOT NULL,
	NombreRol nvarchar(50) NOT NULL,
	constraint PK_RolUsuarios primary key (IdRol)
);
DBCC CHECKIDENT ('[RolUsuarios]', RESEED, 1);
GO


CREATE TABLE Proveedores
(
	
	IdProveedor int identity(1,1) NOT NULL,
    NombreProveedor nvarchar(90) NOT NULL,
    TelefonoProv nvarchar(75) NOT NULL,
    CorreoProv nvarchar(90) NOT NULL,
    DireccionProv nvarchar(90) NOT NULL,
	constraint PK_Proveedores primary key (IdProveedor),
	constraint UQ_Proveedores_NO unique (NombreProveedor)   
);  
DBCC CHECKIDENT ('[Proveedores]', RESEED, 1);
GO

CREATE TABLE Categorias
(
   IdCategoria int IDENTITY(1,1) NOT NULL,
   Descripcion nvarchar(100) NOT NULL,
   constraint PK_Categorias primary key (IdCategoria)    
);  
DBCC CHECKIDENT ('[Categorias]', RESEED, 1);
GO


CREATE TABLE Activos
(
   IdActivo int IDENTITY(1,1) NOT NULL,
   CodActivo nvarchar(50) NOT NULL,
   Categoria int NOT NULL,
   Descripcion nvarchar(90) NOT NULL,
   PrecioInicial money NOT NULL,
   PrecioActual money NOT NULL,
   FechaCompra date NOT NULL,
   Proveedor int NOT NULL,
   EstadoActivo int NOT NULL,
   Garantia int NOT NULL,
   constraint PK_Activos primary key (IdActivo),
   constraint UQ_Activos_CO unique (CodActivo),
   constraint FK_Categ_Act foreign key (Categoria) references Categorias(IdCategoria),
   constraint FK_Proved_Act foreign key (Proveedor) references Proveedores(IdProveedor),
   constraint FK_EstActivo_US foreign key (EstadoActivo) references EstadoActivos(IdEstadoActivo)
);  
DBCC CHECKIDENT ('[Activos]', RESEED, 1);
GO


CREATE TABLE Usuarios
(
   IdUsuario int IDENTITY(1,1) NOT NULL,
   Nombre nvarchar(50) NOT NULL,
   Apellido nvarchar(50) NOT NULL,
   EstadoUsuario int NOT NULL,
   RolUsuario int NOT NULL,
   Cedula int NOT NULL,
   Contrasena nvarchar(50) NOT NULL,
   Telefono nvarchar(50) NOT NULL,
   Correo nvarchar(75) NOT NULL,
   Direccion nvarchar(75) NOT NULL,
   FechaCreacion date NOT NULL,
   FechaUltLogin datetime NOT NULL,
   constraint PK_Usuarios primary key (IdUsuario),
   constraint UQ_Usuarios_CE unique (Cedula),
   constraint UQ_Usuarios_CO unique (Correo),
   constraint FK_EstUsuario_US foreign key (EstadoUsuario) references EstadoUsuarios(IdEstadoUsuario),
   constraint FK_RolUsuario_US foreign key (RolUsuario) references RolUsuarios(IdRol)
);  
DBCC CHECKIDENT ('[Usuarios]', RESEED, 1);
GO



CREATE TABLE Depreciacion
(
    IdDepreciacion int IDENTITY(1,1) NOT NULL,
	Activo int NOT NULL,
	FechaDepreciacion date NOT NULL,
	MontoDepreciacion float NOT NULL, 
	Valor float NOT NULL,
	constraint PK_Depreciacion primary key (IdDepreciacion),
	constraint FK_Activo_Depc foreign key (Activo) references Activos(IdActivo)
);  
DBCC CHECKIDENT ('[Depreciacion]', RESEED, 1);
GO


CREATE TABLE THAsignaciones
(
	IdAsignacion int IDENTITY(1,1) NOT NULL,
	IdUsuario int NOT NULL,
	IdActivo int NOT NULL,
	FechaInicialAsignacion date NOT NULL,
	FechafinalAsignacion date NOT NULL,
   constraint PK_THAsignaciones primary key (IdAsignacion),
   constraint FK_IdUsuario_THA foreign key (IdUsuario) references Usuarios(IdUsuario),
   constraint FK_IdActivo_THA foreign key (IdActivo) references Activos(IdActivo)
);  
DBCC CHECKIDENT ('[THAsignaciones]', RESEED, 1);
GO



CREATE TABLE THReparaciones
(
	IdReparacion int IDENTITY(1,1) NOT NULL,
	IdActivo int NOT NULL,
	FechaInicialReparacion date NOT NULL,
	FechafinalReparacion date NOT NULL,
	constraint PK_THReparaciones primary key (IdReparacion),
	constraint FK_IdActivo_THR foreign key (IdActivo) references Activos(IdActivo)
 );   
DBCC CHECKIDENT ('[THReparaciones]', RESEED, 1);
GO


CREATE TABLE Bitacora
(
   IdBitacora int IDENTITY(1,1) NOT NULL,
   FechaBitacora timestamp NOT NULL,
   DetalleBitacora ntext NOT NULL,
   IdUsuario int NOT NULL,
   constraint PK_Bitacora primary key (IdBitacora),
   constraint FK_IdUsuario_Bi foreign key (IdUsuario) references Usuarios(IdUsuario)    
);  
DBCC CHECKIDENT ('[Bitacora]', RESEED, 1);
GO
