INSERT [dbo].[RolUsuarios] ([NombreRol]) VALUES ('Admin')
INSERT [dbo].[RolUsuarios] ([NombreRol]) VALUES ( 'Usuario')

--
INSERT [dbo].[EstadoUsuarios] ([NombreEstado]) VALUES ('Activo')
INSERT [dbo].[EstadoUsuarios] ([NombreEstado]) VALUES ( 'Inactivo')

 -- 
INSERT [dbo].[Usuarios] ([Nombre], [Apellido], [EstadoUsuario],[RolUsuario],[Cedula],[Contrasena], [Telefono], [Correo], [Direccion], [FechaCreacion],[FechaUltLogin]) VALUES ('Efrain','Lopez', 1, 1, 70320800, '12345', '7777-7777','eolscr@gmail.com', 'San Jose', CAST('2018-10-10' AS DATE), CAST('2019-01-07' AS DATETIME) )
INSERT [dbo].[Usuarios] ([Nombre], [Apellido], [EstadoUsuario],[RolUsuario],[Cedula],[Contrasena], [Telefono], [Correo], [Direccion], [FechaCreacion],[FechaUltLogin]) VALUES ('Melissa','Villalta', 1, 1, 309210921, '12345', '8888-8889','mvillalta@gmail.com', 'Heredia',CAST('2018-09-10' AS DATE), CAST('2019-03-10' AS DATETIME))