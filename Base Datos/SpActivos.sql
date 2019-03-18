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