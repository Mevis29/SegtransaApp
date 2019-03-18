CREATE TRIGGER AccionSobreUsuario
ON Usuarios 
AFTER INSERT
AS

INSERT INTO Bitacora (FechaBitacora, DetalleBitacora, IdUsuario) values
 (GETDATE(), 'Se insertaron nuevos usuarios', (select IdUsuario from inserted))


