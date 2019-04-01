USE [Segtransa];
GO

/****** Datos para Tabla "EstadoUsuarios" ******/

INSERT [EstadoUsuarios] ([NombreEstado]) 
VALUES ('Activo');
GO
INSERT [EstadoUsuarios] ([NombreEstado]) 
VALUES ('Inactivo');
GO

/****** Datos para Tabla "RolUsuarios" ******/

INSERT [RolUsuarios] ([NombreRol]) 
VALUES ('Admin');
GO
INSERT [RolUsuarios] ([NombreRol]) 
VALUES ('Empleado');
GO

/****** Datos para Tabla Usuarios" ******/

INSERT INTO [Usuarios] ([Nombre], [Apellido], [EstadoUsuario], [RolUsuario], [Cedula], [Contrasena], [Telefono], [Correo], [Direccion], [FechaCreacion], [FechaUltLogin]) 
VALUES ('Efrain','Lopez', 1, 1, 70320800, '12345', '7777-8888', 'eolscr@gmail.com', 'Heredia', '2018-10-10', CURRENT_TIMESTAMP)
GO
INSERT INTO [Usuarios] ([Nombre], [Apellido], [EstadoUsuario], [RolUsuario], [Cedula],  [Contrasena], [Telefono], [Correo], [Direccion], [FechaCreacion], [FechaUltLogin])
VALUES ('Melissa','Villalta', 1, 1, 60320980, '12345', '7777-7777', 'melsvilla@gmail.com', 'San Jose', '2018-11-10', CURRENT_TIMESTAMP)
GO
INSERT INTO [Usuarios] ([Nombre], [Apellido], [EstadoUsuario], [RolUsuario], [Cedula],  [Contrasena], [Telefono], [Correo], [Direccion], [FechaCreacion], [FechaUltLogin])
VALUES ('Jorge','Segnini', 1, 2, 70780809, '12345', '6788-7777', 'jorgseg@gmail.com', 'Heredia', '2018-12-10', CURRENT_TIMESTAMP)
GO
INSERT INTO [Usuarios] ([Nombre], [Apellido], [EstadoUsuario], [RolUsuario], [Cedula],  [Contrasena], [Telefono], [Correo], [Direccion], [FechaCreacion], [FechaUltLogin])
VALUES ('Juan','Lara', 2, 2, 50320765, '12345', '8932-7773', 'juancho@gmail.com', 'San Jose', '2018-12-10', CURRENT_TIMESTAMP)
GO

select * from RolUsuarios
select * from EstadoUsuarios
select * from Usuarios


-- INSERCION DE CATEGORIAS --
insert into Categorias values ('Computadora Portatil')
insert into Categorias values ('Computadora Escritorio')
insert into Categorias values ('Camara de videovigilancia')
insert into Categorias values ('Perifericos de Computadoras')
insert into Categorias values ('Mobiliario de Oficina')
select * from Categorias

-- INSERCION DE PROVEEDORES --
insert into Proveedores values ('Sitec','2295-4908','sitec@outlook.com','Alajuela')
insert into Proveedores values ('Intcomex','2295-4908','intcomex@outlook.com','Uruca San Jose')
insert into Proveedores values ('ExtremeTech','2295-4908','xtech@outlook.com','Heredia')
insert into Proveedores values ('Intelec','2295-4908','intelec@outlook.com','San Jose')
insert into Proveedores values ('Euromobilia','2295-4908','euromobilia@outlook.com','San Jose')
select * from Proveedores

-- INSERCION DE ESTADOS DE ACTIVOS --
insert into EstadoActivos values ('Bueno')
insert into EstadoActivos values ('Malo')
insert into EstadoActivos values ('Obsoleto')
insert into EstadoActivos values ('Reparado')
insert into EstadoActivos values ('En Garantia')
insert into EstadoActivos values ('Sin Garantia')


select * from EstadoActivos



 -- INSERCION DE ACTIVOS --

INSERT INTO Activos(CodActivo,Categoria,Descripcion,PrecioInicial,PrecioActual,FechaCompra,Proveedor,EstadoActivo,Garantia) 
			VALUES ('LAPT',1,'Computadora DELL M4600',1800,1000,'3/17/2019',1,1,24)
INSERT INTO Activos(CodActivo,Categoria,Descripcion,PrecioInicial,PrecioActual,FechaCompra,Proveedor,EstadoActivo,Garantia) 
			VALUES ('CPU',1,'CPU I5 7600K 8RAM',1000,8000,'3/17/2018',2,1,24)
INSERT INTO Activos(CodActivo,Categoria,Descripcion,PrecioInicial,PrecioActual,FechaCompra,Proveedor,EstadoActivo,Garantia) 
			VALUES ('CCTV',1,'CAMARA 5MP Hikvision',200,145,'3/17/2018',3,1,24)
INSERT INTO Activos(CodActivo,Categoria,Descripcion,PrecioInicial,PrecioActual,FechaCompra,Proveedor,EstadoActivo,Garantia) 
			VALUES ('MONT',1,'Monitor 24" AOC 2460ivk',400,320,'3/10/2018',4,1,24)
			INSERT INTO Activos(CodActivo,Categoria,Descripcion,PrecioInicial,PrecioActual,FechaCompra,Proveedor,EstadoActivo,Garantia) 
			VALUES ('ESCR',1,'Escritorio 125*75 Metal',125,100,'3/1/2018',5,1,24)


SELECT * FROM Activos


----------------SE DEBEN CARGAR --------------------------------------------------


-- INSERCION DE THASIGNACIONES --

INSERT INTO  THAsignaciones(IdUsuario,IdActivo,FechaInicialAsignacion,FechafinalAsignacion)
					VALUES (2,2,'2/20/2018', '3/20/2019')
INSERT INTO  THAsignaciones(IdUsuario,IdActivo,FechaInicialAsignacion,FechafinalAsignacion)
					VALUES (3,2,'3/10/2018','3/20/2019')
INSERT INTO  THAsignaciones(IdUsuario,IdActivo,FechaInicialAsignacion,FechafinalAsignacion)
					VALUES (1,2,'3/20/2018','3/20/2019')
INSERT INTO  THAsignaciones(IdUsuario,IdActivo,FechaInicialAsignacion,FechafinalAsignacion)
					VALUES (4,2,'3/5/2018','3/20/2019')

SELECT * FROM THAsignaciones

-- INSERCION DE THREPACIONES --

delete from THReparaciones where IdReparacion = 4
INSERT INTO THReparaciones (IdActivo,FechaInicialReparacion,FechafinalReparacion)
					values (2,'2/5/2019','2/13/2019')
				
select * from THReparaciones
