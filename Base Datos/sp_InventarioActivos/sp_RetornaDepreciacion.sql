USE [InventarioActivos]
GO
/****** Object:  StoredProcedure [dbo].[sp_RetornaDepreciacion]    Script Date: 18/3/2019 3:16:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[sp_RetornaDepreciacion]
@activo int=null,
@fechaInicial datetime=null,
@fechaFinal datetime=null
AS
	
BEGIN
SELECT D.IdDepreciacion AS IdDepreciacion, format(D.FechaDepreciacion, 'dd-MMM-yyyy')  AS FechaDepreciacion ,D.MontoDepreciacion AS MontoDepreciacion, D.Valor AS Valor, A.CodActivo AS CodActivo
FROM Depreciacion D
JOIN Activos A on D.Activo= IdActivo
WHERE D.Activo=@activo
AND D.FechaDepreciacion>= @fechaInicial or @fechaInicial is null 
AND  D.FechaDepreciacion<= @fechaFinal or @fechaFinal is null 
End