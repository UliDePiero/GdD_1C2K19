Use [GD1C2019]
go
create Procedure DesabilitarCrucero(@crucero int)
as
begin
	insert PENSAMIENTO_LINEAL.Estado_crucero (esta_desc,esta_fechabaja,esta_fechaalta,esta_crucero)
	values  ('BAJA',GetDate(),NULL,@crucero)
	DECLARE viajes Cursor for Select reco_cruc_crucid,reco_cruc_recoid,reco_cruc_salida from PENSAMIENTO_LINEAL.Recorrido_crucero where @crucero = reco_cruc_crucid and reco_cruc_salida > GetDate()
	Declare @cruc int = 0
	Declare @reco int = 0
	Declare @fech smallDateTime = GetDate()
	Open viajes
	fetch from viajes INTO @cruc, @reco, @fech
	while (@@FETCH_STATUS = 0)
	begin
		Execute dbo.pasarPasajeros @cruc, @reco, @fech
		fetch from viajes INTO @cruc, @reco, @fech
	end
	close viajes
end