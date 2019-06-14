Use [GD1C2019]
go
create Procedure chasquearDedos (@puerto int)
as
begin
Declare @Todo table (tramo int,reco int,recoCruc int) 
Insert into @Todo
select tram_id, reco_id, reco_cruc_id
from PENSAMIENTO_LINEAL.Tramo join 
	 PENSAMIENTO_LINEAL.Recorrido_tramo on (reco_tram_tramid = tram_id) join
	 PENSAMIENTO_LINEAL.Recorrido on (reco_tram_recoid= reco_id) join
	 PENSAMIENTO_LINEAL.Recorrido_crucero on (reco_cruc_id= reco_id) join
	 PENSAMIENTO_LINEAL.Pasaje on (reco_cruc_id =pasa_viaje)
	 where @puerto = tram_destino OR @puerto = tram_origen
delete PENSAMIENTO_LINEAL.Pasaje
From PENSAMIENTO_LINEAL.Pasaje join @Todo on (pasa_viaje = recoCruc)
delete PENSAMIENTO_LINEAL.Recorrido_crucero
From PENSAMIENTO_LINEAL.Recorrido_crucero join @Todo on (reco_cruc_id = recoCruc)
delete PENSAMIENTO_LINEAL.Recorrido
from PENSAMIENTO_LINEAL.Recorrido join @Todo on (reco_id = reco)
delete PENSAMIENTO_LINEAL.Recorrido_tramo
from PENSAMIENTO_LINEAL.Recorrido_tramo join @Todo on (tramo = reco_tram_tramid)
delete PENSAMIENTO_LINEAL.Tramo
from PENSAMIENTO_LINEAL.Tramo join @Todo on (tramo = tram_id)
delete PENSAMIENTO_LINEAL.Puerto
where @puerto = puer_id
end

