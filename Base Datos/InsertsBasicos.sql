-- INSERCION DE ROLES DE USUARIOS --
INSERT [dbo].[RolUsuarios] ([NombreRol]) VALUES ('Admin')
INSERT [dbo].[RolUsuarios] ([NombreRol]) VALUES ( 'Usuario')

-- INSERCION DE ESTADOS DE USUARIOS --
INSERT [dbo].[EstadoUsuarios] ([NombreEstado]) VALUES ('Activo')
INSERT [dbo].[EstadoUsuarios] ([NombreEstado]) VALUES ( 'Inactivo')

 -- INSERCION DE USUARIOS---
INSERT [dbo].[Usuarios] ([Nombre], [Apellido], [EstadoUsuario],[RolUsuario],[Cedula],[Contrasena], [Telefono], [Correo], [Direccion], [FechaCreacion],[FechaUltLogin])
 VALUES ('Efrain','Lopez', 1, 1, 70320800, '12345', '7777-7777','eolscr@gmail.com', 'San Jose', CAST('2018-10-10' AS DATE), CAST('2019-01-07' AS DATETIME) )
INSERT [dbo].[Usuarios] ([Nombre], [Apellido], [EstadoUsuario],[RolUsuario],[Cedula],[Contrasena], [Telefono], [Correo], [Direccion], [FechaCreacion],[FechaUltLogin])
 VALUES ('Melissa','Villalta', 1, 1, 309210921, '12345', '8888-8889','mvillalta@gmail.com', 'Heredia',CAST('2018-09-10' AS DATE), CAST('2019-03-10' AS DATETIME))
INSERT [dbo].[Usuarios] ([Nombre], [Apellido], [EstadoUsuario],[RolUsuario],[Cedula],[Contrasena], [Telefono], [Correo], [Direccion], [FechaCreacion],[FechaUltLogin])
 VALUES ('Randall','Herrera', 1, 2, 207470867, '12345', '8435-9444','randallherrera10@gmail.com', 'Alajuela', CAST('2019-03-20' AS DATE), CAST('2019-03-21' AS DATETIME) )
INSERT [dbo].[Usuarios] ([Nombre], [Apellido], [EstadoUsuario],[RolUsuario],[Cedula],[Contrasena], [Telefono], [Correo], [Direccion], [FechaCreacion],[FechaUltLogin])
 VALUES ('Alexandra','Martinez', 1, 2, 207470868, '12345', '8888-8889','amartinez07@gmail.com', 'Alajuela Atenas', CAST('2019-03-20' AS DATE), CAST('2019-03-21' AS DATETIME))
INSERT [dbo].[Usuarios] ([Nombre], [Apellido], [EstadoUsuario],[RolUsuario],[Cedula],[Contrasena], [Telefono], [Correo], [Direccion], [FechaCreacion],[FechaUltLogin])
 VALUES ('Pedro','Herrera', 2, 2, 207470869, '12345', '8888-8889','pherrerag@gmail.com', 'Alajuela', CAST('2019-03-20' AS DATE), CAST('2019-03-21' AS DATETIME))

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
			VALUES ('LAPT',1,'Computadora DELL M4600',1800,1000,'3/17/2019',7,1,24)
INSERT INTO Activos(CodActivo,Categoria,Descripcion,PrecioInicial,PrecioActual,FechaCompra,Proveedor,EstadoActivo,Garantia) 
			VALUES ('CPU',1,'CPU I5 7600K 8RAM',1000,8000,'3/17/2018',9,1,24)
INSERT INTO Activos(CodActivo,Categoria,Descripcion,PrecioInicial,PrecioActual,FechaCompra,Proveedor,EstadoActivo,Garantia) 
			VALUES ('CCTV',1,'CAMARA 5MP Hikvision',200,145,'3/17/2018',7,1,24)
INSERT INTO Activos(CodActivo,Categoria,Descripcion,PrecioInicial,PrecioActual,FechaCompra,Proveedor,EstadoActivo,Garantia) 
			VALUES ('MONT',1,'Monitor 24" AOC 2460ivk',400,320,'3/10/2018',10,1,24)
			INSERT INTO Activos(CodActivo,Categoria,Descripcion,PrecioInicial,PrecioActual,FechaCompra,Proveedor,EstadoActivo,Garantia) 
			VALUES ('ESCR',1,'Escritorio 125*75 Metal',125,100,'3/1/2018',11,1,24)


SELECT * FROM Activos


-- INSERCION DE THASIGNACIONES --

INSERT INTO  THAsignaciones(IdUsuario,IdActivo,FechaInicialAsignacion,FechafinalAsignacion)
					VALUES (2,9,'3/20/2019',NULL)
INSERT INTO  THAsignaciones(IdUsuario,IdActivo,FechaInicialAsignacion,FechafinalAsignacion)
					VALUES (3,10,'3/20/2018',NULL)
INSERT INTO  THAsignaciones(IdUsuario,IdActivo,FechaInicialAsignacion,FechafinalAsignacion)
					VALUES (3,12,'3/20/2018',NULL)
INSERT INTO  THAsignaciones(IdUsuario,IdActivo,FechaInicialAsignacion,FechafinalAsignacion)
					VALUES (3,13,'3/5/2018',NULL)

SELECT * FROM THAsignaciones

-- INSERCION DE THREPACIONES --

delete from THReparaciones where IdReparacion = 4
INSERT INTO THReparaciones (IdActivo,FechaInicialReparacion,FechafinalReparacion)
					values (11,'2/5/2019','2/13/2019')
				
select * from THReparaciones


