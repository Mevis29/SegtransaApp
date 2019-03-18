USE [InventarioActivos]
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertaReparacion]    Script Date: 18/3/2019 3:37:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[sp_InsertaReparacion]
@idUsuarioActual int,
@idActivo int,
@fechaInicialReparacion datetime,
@fechaFinalReparacion datetime
AS
	
INSERT INTO dbo.THReparaciones(IdActivo, FechaInicialReparacion, FechafinalReparacion)
       VALUES(@idActivo, @fechaFinalReparacion, @fechaFinalReparacion); --Inserta en Reparaciones--
	   
SET ANSI_NULLS ON