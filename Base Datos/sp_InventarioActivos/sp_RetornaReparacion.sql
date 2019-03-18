USE [InventarioActivos]
GO
/****** Object:  StoredProcedure [dbo].[sp_RetornaDepreciacion]    Script Date: 17/3/2019 5:17:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[sp_RetornaReparacion]
@idActivo int=null,
@fechaInicial datetime=null,
@fechaFinal datetime=null
AS
	
SELECT tr.IdActivo, tAc.CodActivo, tu.Nombre, tr.FechaInicialReparacion,tr.FechafinalReparacion
FROM THReparaciones tr JOIN Activos tAc on (tr.IdActivo= @idActivo OR @idActivo IS NULL) AND 
(tr.FechaInicialReparacion>=@fechaInicial OR @fechaInicial IS NULL) AND 
(tr.FechafinalReparacion<=@fechaFinal OR @fechaFinal IS NULL) AND
tr.IdActivo=tAc.IdActivo JOIN THAsignaciones tAs on tAc.IdActivo= tAs.IdActivo JOIN Usuarios tu on tAs.IdUsuario= tu.IdUsuario
SET ANSI_NULLS ON

/*EXPLICACION DEL SELECT: Seleccionar el Id del activo y su codigo, nombre del usuario del activo, 
fecha inicial y final mediante Joins entre las distintas tablas que presentan los datos, donde
todos compartan el mismo IdActivo (si se pasó alguno, filtrando por activo individual) y
la tabla de asignación de activos comparta el idUsuario con la tabla Usuarios en donde se halle el idActivo correspondiente.
Filtra mediante fechas de manera que:
la fecha inicial de la reparación sea igual o mayor al parámetro de fecha inicial,
y la fecha final de la reparación sea igual o menor al parámetro de fecha final. 
Se puede también filtrar mediante una fecha si la otra es nula, mostrando, por ejemplo, las reparaciones que hayan realizado con x fecha inicial en adelante, 
o con x fecha final hacia atrás. */