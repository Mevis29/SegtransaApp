-- ================================================
-- Author:      <María José Mangas, Melissa Villalta, Jorge Segnini, Jason Segnini, Julian Venegas, Randal y Erley >
-- Create date: <Marzo 2019>
-- Description:	<Creación de Procedimientos Almacenados>
-- ================================================

USE [Segtransa]
GO


-- =============================================
-- Description:	<Estados - Retorna Lista de todos los Estados de Usuario>
-- =============================================

CREATE PROCEDURE spEstadoUsuariosRetornaLista
AS
BEGIN
SELECT E.IdEstadoUsuario AS Id, E.NombreEstado AS Nombre
FROM EstadoUsuarios E
END
GO


-- =============================================
-- Description:	<Roles - Retorna Lista de todos los Roles de Usuario>
-- =============================================

CREATE PROCEDURE spRolesRetornaLista
AS
BEGIN
SELECT R.IdRol AS Id, R.NombreRol AS Nombre
FROM RolUsuarios R
END
GO

--*************************************************************************
--******** Estos dos SP son de Login q muestran el ultimo ingreso del usuario, ambos SP van juntos******************
-- =============================================
-- Description:	<Usuarios - Retorna/Valida Datos de Usuario para Login>
-- =============================================

CREATE PROCEDURE spUsuariosRetornaDatosLogin
@correo varchar(100),
@contrasena varchar(50)
AS
BEGIN
SELECT U.IdUsuario AS Id, (U.Nombre + ' ' + U.Apellido) AS Nombre,
 U.Correo AS Correo, format(U.FechaUltLogin, 'dd-MMM-yyyy hh:mm tt') AS UltLogin,
 E.NombreEstado AS Estado, R.NombreRol AS Rol
FROM Usuarios U 
join EstadoUsuarios E on U.EstadoUsuario=E.IdEstadoUsuario
join RolUsuarios R on U.RolUsuario=R.IdRol
WHERE Correo=@correo and Contrasena=@contrasena
END
GO


-- =============================================
-- Description:	<Usuarios - Actualiza Fecha/Hora de último Login>
-- =============================================

CREATE PROCEDURE spUsuariosActualizaUltLogin
@IdUsuario int
AS
BEGIN
UPDATE Usuarios SET FechaUltLogin = CURRENT_TIMESTAMP
WHERE IdUsuario=@IdUsuario
END
GO

--*************************************************************************
--*************************************************************************


-- =============================================
-- Description:	<Usuarios - Retorna Lista de todos los Usuarios>
-- =============================================

CREATE PROCEDURE spUsuariosRetornaLista
@cedula varchar(20)=NULL,
@nombre varchar(100)=NULL,
@correo varchar(100)=NULL
AS
BEGIN
SELECT U.IdUsuario AS Id, U.Cedula AS Cedula, U.Nombre AS Nombre, U.Apellido AS Apellido,
  U.Correo AS Correo, E.NombreEstado AS Estado, R.NombreRol AS Rol, format(U.FechaCreacion, 'dd-MMM-yyyy') AS FechaCreacion,
  format(U.FechaUltLogin, 'dd-MMM-yyyy hh:mm tt') AS FechaLogin, U.Direccion AS Direccion, U.Telefono AS Telefono
FROM Usuarios U 
join EstadoUsuarios E on U.EstadoUsuario=E.IdEstadoUsuario
join RolUsuarios R on U.RolUsuario=R.IdRol
WHERE (Nombre like (case when @nombre is null then '%%' else '%' + @nombre +'%' end)
or Apellido like (case when @nombre is null then '%%' else '%' + @nombre +'%' end))
and Correo like (case when @correo is null then '%%' else '%' + @correo + '%' end)
and CAST(Cedula as varchar) like (case when @cedula is null then '%%' else '%' + @cedula + '%' end)
End
go

-- =============================================
-- Description:	<Usuarios - Retorna Lista de Usuarios con Rol Empleado Asignado>
-- =============================================

CREATE PROCEDURE spUsuariosRetornaListaEmpleados
@IdEmpleado int NULL
AS
BEGIN
SELECT U.IdUsuario AS Id, (CAST(Cedula as varchar) + ' - ' + U.Nombre + ' ' + U.Apellido) AS Empleado
FROM Usuarios U 
join RolUsuarios R on U.RolUsuario=R.IdRol
WHERE R.NombreRol='Empleado'
AND IdUsuario=(case when @IdEmpleado  is null then IdUsuario else @IdEmpleado end)
END
GO


-- =============================================
-- Description:	<Usuarios - Retorna Lista de Usuario por Id>
-- filtrar a los Usuarios x el Id
-- =============================================

CREATE PROCEDURE spUsuariosRetornaListaId
@IdUsuario int
AS
BEGIN
SELECT U.IdUsuario AS Id, U.Cedula AS Cedula, U.Nombre AS Nombre, U.Apellido AS Apellido,
  U.Correo AS Correo, E.NombreEstado AS Estado, R.NombreRol AS Rol, format(U.FechaCreacion, 'dd-MMM-yyyy') AS FechaCreacion,
  format(U.FechaUltLogin, 'dd-MMM-yyyy hh:mm tt') AS FechaLogin, U.Direccion AS Direccion, U.Telefono AS Telefono
FROM Usuarios U 
join EstadoUsuarios E on U.EstadoUsuario=E.IdEstadoUsuario
join RolUsuarios R on U.RolUsuario=R.IdRol
WHERE IdUsuario=@IdUsuario
END
GO






-- =============================================
-- Description:	<Usuarios - Retorna Datos de Usuario por Id>
-- =============================================

CREATE PROCEDURE spUsuariosRetornaDatosId
@IdUsuario int
AS
BEGIN
SELECT U.IdUsuario AS Id, U.Cedula AS Cedula, U.Nombre AS Nombre, U.Apellido AS Apellido,
  U.Correo AS Correo, U.Contrasena AS Contrasena, U.EstadoUsuario AS Estado, U.RolUsuario AS Rol, 
  format(U.FechaCreacion, 'dd-MMM-yyyy') AS FechaCreacion,
  format(U.FechaUltLogin, 'dd-MMM-yyyy hh:mm tt') AS FechaLogin, 
  U.Direccion AS Direccion, U.Telefono AS Telefono
FROM Usuarios U 
WHERE IdUsuario=@IdUsuario
END
GO


-- =============================================
-- Description:	<Usuarios - Inserta Datos de Nuevo Usuario-Empleado asignado>
-- =============================================

CREATE PROCEDURE spUsuariosInsertaDatos
@nombre varchar(80),
@apellido varchar(80),
@estado int,
@rol int,
@cedula int,	
@contrasena varchar(50),
@telefono varchar(20),
@correo varchar(100),	
@direccion varchar(250),
@fechaCreacion date
AS
BEGIN
INSERT INTO Usuarios
( Nombre, Apellido, EstadoUsuario, RolUSuario, Cedula, Contrasena, Telefono, Correo, Direccion, FechaCreacion, FechaUltLogin)
VALUES
(@nombre, @apellido,@estado, @rol, @cedula, @contrasena, @telefono, @correo, @direccion, @fechaCreacion, '01-01-2000')
END
GO

-- =============================================
-- Description:	<Usuarios - Modifica Datos de Usuario-Empleado Existente>
-- =============================================

CREATE PROCEDURE spUsuariosModificaDatos	
@IdUsuario int,
@nombre varchar(80),
@apellido varchar(80),
@estado int,
@rol int,
@cedula int,	
@contrasena varchar(50),
@telefono varchar(20),
@correo varchar(100),	
@direccion varchar(250),
@fechaCreacion date       
AS
BEGIN
UPDATE Usuarios SET Nombre=@nombre, Apellido=@apellido, EstadoUsuario=@estado, RolUSuario=@rol, Cedula=@cedula,
  Contrasena=@contrasena, Telefono=@telefono, Correo=@correo, Direccion=@direccion, FechaCreacion=@fechaCreacion
WHERE IdUsuario=@IdUsuario
END
GO

-- =============================================
-- Description:	<Usuarios - Elimina un Usuario-Empleado Existente>
-- =============================================

CREATE PROCEDURE spUsuariosEliminaDatos	
@IdUsuario int         
AS
BEGIN
DELETE FROM Usuarios        
WHERE IdUsuario=@IdUsuario 
END
GO
