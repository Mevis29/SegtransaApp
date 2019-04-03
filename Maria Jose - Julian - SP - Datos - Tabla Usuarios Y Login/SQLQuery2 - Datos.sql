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
