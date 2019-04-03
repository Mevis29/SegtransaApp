


-- ================================================
-- Author:      <Randall, María José Mangas, Melissa Villalta, Jorge Segnini, Jason Segnini, Julian Venegas, Erley >
-- Create date: <Marzo 2019>
-- Description:	<Creación de Procedimientos Almacenados>
-- ================================================

USE [Segtransa]
GO


/**
*
*  Agregar Activo
*
**/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
CREATE  or ALTER  PROCEDURE sp_agregarActivo
	-- Add the parameters for the stored procedure here
	@codActivo nchar(50),
	@categoria int,
	@descripcion nchar(90),
	@precioInicial money,
	@precioActual  money,
	@fechaCompra nchar(50),
	@proveedor int,
	@estadoActivo int,
	@garantia int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.Activos VALUES(@codActivo,@categoria,@descripcion,@precioInicial,@precioActual,@fechaCompra,@proveedor,@estadoActivo,@garantia);
END
GO

insert into Categorias values ('Computadora Portatil')
insert into Proveedores values ('Sitec',2295-4908,'sitec@outlook.com','Alajuela')
insert into EstadoActivos values ('Bueno')

exec sp_agregarActivo 200,1,'Computadora DELL M4600',1800,1000,'3/17/2019',1,1,24
select * from Activos


/**
*
*  Actualizar Activo
*
**/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  or ALTER  PROCEDURE sp_actualizarActivo
	-- Add the parameters for the stored procedure here
	@idActivo int,
	@codActivo nchar(50),
	@categoria int,
	@descripcion nchar(90),
	@precioInicial money,
	@precioActual  money,
	@fechaCompra nchar(50),
	@proveedor int,
	@estadoActivo int,
	@garantia int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE  dbo.Activos 
	set CodActivo = @codActivo,Categoria = @categoria,
		Descripcion = @descripcion,PrecioInicial = @precioInicial,
		PrecioActual =  @precioActual,FechaCompra = @fechaCompra,
		Proveedor =  @proveedor, EstadoActivo = @estadoActivo,
		Garantia = @garantia
	where IdActivo =@idActivo

END
GO

exec sp_actualizarActivo 1,200,1,'Computadora DELL M4700',1800,1000,'3/17/2019',1,1,24
select * from Activos



/**
*
*  Eliminar Activo
*
**/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  or ALTER  PROCEDURE sp_eliminarActivo 
	@idActivo int
AS
BEGIN
	
	DELETE FROM Activos WHERE IdActivo = @idActivo; 

END
GO

exec sp_eliminarActivo 1

/**
*
*  obtener Activos
*
**/


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE or ALTER PROCEDURE sp_obtenerActivos
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM dbo.Activos;
END
GO

exec sp_obtenerActivos


/**
*
*  Buscar Activo
*
**/


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE or ALTER PROCEDURE sp_BuscarActivos
	@string_busqueda VARCHAR(Max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select a.IdActivo,a.CodActivo,a.Descripcion,a.PrecioInicial,a.FechaCompra,p.NombreProveedor,e.NombreEstado
	from Activos A ,Proveedores P ,EstadoActivos E
	where Descripcion LIKE '%' + @string_busqueda + '%' and
	   a.Proveedor = p.IdProveedor and
	   a.EstadoActivo = e.IdEstadoActivo;

END
GO

exec sp_BuscarActivos Computadora 
select * from Activos

/**
*
* Informacion a mostrar del activo
*
**/


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE or ALTER PROCEDURE sp_mostrarActivo
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select a.IdActivo,a.CodActivo,a.Descripcion,a.PrecioInicial,a.FechaCompra,p.NombreProveedor,e.NombreEstado
	from Activos A ,Proveedores P ,EstadoActivos E
	where a.Proveedor = p.IdProveedor and
	   a.EstadoActivo = e.IdEstadoActivo;

END
GO

exec sp_mostrarActivo
select * from Activos
select * from Categorias


/**
*
* Informacion todos los CodActivos
*
**/


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE or ALTER PROCEDURE sp_mostrarCodActivo
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select codActivo from activos;

END
GO

exec sp_mostrarCodActivo

select * from Activos
select * from Categorias
select * from  Proveedores
select * from EstadoActivos
delete from EstadoActivos where IdEstadoActivo = 8
insert into EstadoActivos values('Nuevo')
insert into EstadoActivos values('Usado')

/**
*
* Informacion todos los CodActivosDiferentes
*
**/


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE or ALTER PROCEDURE sp_mostrarCodActivoDiferentes
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select distinct codActivo from activos;

END
Go

exec sp_mostrarCodActivoDiferentes

/**
*
* Informacion todos los CategoriasDiferentes
*
**/


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE or ALTER PROCEDURE sp_mostrarCategoriasDiferentes
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select distinct  Categoria from activos;


END
Go

exec sp_mostrarCategoriasDiferentes

ALTER TABLE Categorias
ADD UNIQUE (Descripcion);
