USE [InventarioActivos]
GO
/****** Object:  StoredProcedure [dbo].[sp_RetornaBitacora]    Script Date: 18/3/2019 3:16:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[sp_RetornaBitacora]
@idUsuario int= null,
@fechaInicial datetime= null,
@fechaFinal datetime= null
AS
BEGIN
SELECT B.IdBitacora AS IdBitacora, format(B.FechaBitacora, 'dd-MMM-yyyy')  AS FechaBitacora ,B.DetalleBitacora AS DetalleBitacora, U.Nombre AS Nombre
FROM Bitacora B 
JOIN Usuarios U on B.IdUsuario= U.IdUsuario
WHERE B.IdUsuario= @idUsuario
AND FechaBitacora>=@fechaInicial or @fechaInicial is null
AND FechaBitacora<= @fechaFinal or @fechaFinal is null
End
