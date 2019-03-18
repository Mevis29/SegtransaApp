	GO
CREATE DATABASE [InventarioActivos]
GO

USE [InventarioActivos]
GO
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

select * from Proveedores

*/


CREATE TABLE EstadoActivos
(
	IdEstadoActivo int IDENTITY(1,1) NOT NULL,
	NombreEstado nvarchar(20) NULL,
 CONSTRAINT PK_EstadoActivos PRIMARY KEY (IdEstadoActivo)
 );
DBCC CHECKIDENT ('[EstadoActivos]', RESEED, 1);
GO

CREATE TABLE EstadoUsuarios
(
	IdEstadoUsuario int identity(1,1) not NULL,
	NombreEstado nvarchar(20) not NULL,
	constraint PK_EstadoUsuarios primary key (IdEstadoUsuario)
);
DBCC CHECKIDENT ('[EstadoUsuarios]', RESEED, 1);
GO


CREATE TABLE RolUsuarios
(
	IdRol int identity(1,1) not NULL,
	NombreRol nvarchar(50) not NULL,
	constraint PK_RolUsuarios primary key (IdRol)
);
DBCC CHECKIDENT ('[RolUsuarios]', RESEED, 1);
GO


CREATE TABLE Proveedores
(
	
	IdProveedor int identity(1,1) NOT NULL,
    NombreProveedor nvarchar(90) NOT NULL unique,
    Telefono nvarchar(75) NULL,
    Correo nvarchar(90) NULL,
    Direccion nvarchar(90) NULL,
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
   CodActivo nchar(50) NULL unique,
   Categoria int NULL,
   Descripcion nvarchar(90) NULL,
   PrecioInicial money NULL,
   PrecioActual money NULL,
   FechaCompra datetime NULL,
   Proveedor int NULL,
   EstadoActivo int NULL,
   Garantia int NULL,
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
   EstadoUsuario int NULL,
   RolUsuario int NULL,
   Cedula int NOT NULL,
   Contrasena nvarchar(50) NOT NULL,
   Telefono nvarchar(50) NULL,
   Correo nvarchar(75) NULL,
   Direccion nvarchar(75) NULL,
   FechaCreacion date NULL,
   FechaUltLogin datetime NULL,
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
	Activo int Not Null,
	FechaDepreciacion datetime Not Null,
	MontoDepreciacion float Not Null, 
	Valor float Not Null,
	constraint PK_Depreciacion primary key (IdDepreciacion),
	constraint FK_Activo_Depc foreign key (Activo) references Activos(IdActivo)
);  
DBCC CHECKIDENT ('[Depreciacion]', RESEED, 1);
GO


CREATE TABLE THAsignaciones
(
	IdAsignacion int IDENTITY(1,1) NOT NULL,
	IdUsuario int NULL,
	IdActivo int NULL,
	FechaInicialAsignacion datetime NULL,
	FechafinalAsignacion datetime NULL,
   constraint PK_THAsignaciones primary key (IdAsignacion),
   constraint FK_IdUsuario_THA foreign key (IdUsuario) references Usuarios(IdUsuario),
   constraint FK_IdActivo_THA foreign key (IdActivo) references Activos(IdActivo)
);  
DBCC CHECKIDENT ('[THAsignaciones]', RESEED, 1);
GO



CREATE TABLE THReparaciones
(
	IdReparacion int IDENTITY(1,1) NOT NULL,
	IdActivo int NULL,
	FechaInicialReparacion datetime NULL,
	FechafinalReparacion datetime NULL,
	constraint PK_THReparaciones primary key (IdReparacion),
	constraint FK_IdActivo_THR foreign key (IdActivo) references Activos(IdActivo)
 );   
DBCC CHECKIDENT ('[THReparaciones]', RESEED, 1);
GO


CREATE TABLE Bitacora
(
   IdBitacora int IDENTITY(1,1) NOT NULL,
   FechaBitacora timestamp NULL,
   DetalleBitacora ntext NULL,
   IdUsuario int NULL,
   constraint PK_Bitacora primary key (IdBitacora),
   constraint FK_IdUsuario_Bi foreign key (IdUsuario) references Usuarios(IdUsuario)    
);  
DBCC CHECKIDENT ('[Bitacora]', RESEED, 1);
GO
