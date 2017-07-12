USE SistemaCampo;
GO
declare @fecha varchar(MAX)
declare @archivo varchar(MAX)
set @fecha = CONVERT(Varchar(max), GETDATE(),102)+'_'+SUBSTRING(CONVERT(varchar(10), getdate(),108),1,2)+SUBSTRING(CONVERT(varchar(10), getdate(),108),4,2)+'horas'
set @archivo ='C:\Backups\'+@fecha+'.bak'
BACKUP DATABASE SistemaCampo
TO DISK = @archivo
WITH NOFORMAT, NOINIT,  NAME = N'SistemaCampo-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10