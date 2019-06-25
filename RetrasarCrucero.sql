Use [GD1C2019]
go
create Procedure RetrasarCrucero (@crucero int, @Baja smallDateTime, @Alta smallDateTime)
as
begin
	Declare @diff int = abs(DateDiff(DAY,@Baja,@Alta))
	update PENSAMIENTO_LINEAL.Recorrido_crucero
	Set reco_cruc_salida= DATEADD(DAY,@diff,reco_cruc_salida),reco_cruc_llegada_real=DATEADD(DAY,@diff,reco_cruc_llegada_real)
	where reco_cruc_crucid=@crucero and reco_cruc_salida>@Baja
end