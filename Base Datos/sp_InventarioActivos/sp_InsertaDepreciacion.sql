USE [InventarioActivos]
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertaDepreciacion]    Script Date: 18/3/2019 3:14:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[sp_InsertaDepreciacion]
@idUsuarioActual int,
@activo int,
@fechaDepreciacion datetime,
@montoDepreciacion float,
@valor float
AS

INSERT INTO dbo.Depreciacion(activo, FechaDepreciacion, MontoDepreciacion, Valor)
       VALUES(@activo, @fechaDepreciacion, @montoDepreciacion, @valor);
	   
SET ANSI_NULLS ON