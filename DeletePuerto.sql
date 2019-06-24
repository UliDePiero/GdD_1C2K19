Use [GD1C2019]
go
CREATE Procedure chasquearDedos (@puerto int)
as
begin
Declare @Todo table (tramo int,reco int,recoCruc int) 
Insert into @Todo
select tram_id, reco_id, reco_cruc_id
from PENSAMIENTO_LINEAL.Tramo LEFT join 
	 PENSAMIENTO_LINEAL.Recorrido_tramo on (reco_tram_tramid = tram_id) LEFT join
	 PENSAMIENTO_LINEAL.Recorrido on (reco_tram_recoid= reco_id or reco_primertramo = tram_id) LEFT join
	 PENSAMIENTO_LINEAL.Recorrido_crucero on (reco_cruc_recoid = reco_id)
	 where @puerto = tram_destino OR @puerto = tram_origen
	 
Declare @tramos table (tramo int)
insert @tramos select distinct tramo from @Todo
Declare @recorridos table (reco int)
insert @recorridos select distinct reco from @Todo
Declare @viaje table (recoCruc int)
insert @viaje select distinct recoCruc from @Todo



delete PENSAMIENTO_LINEAL.Reserva
from @viaje
where rese_viaje = recoCruc
delete PENSAMIENTO_LINEAL.Pasaje
from @viaje
where pasa_viaje = recoCruc
delete PENSAMIENTO_LINEAL.Recorrido_crucero
from @viaje
where reco_cruc_id = recoCruc
delete PENSAMIENTO_LINEAL.Recorrido
from @recorridos
where reco_id = reco
delete PENSAMIENTO_LINEAL.Recorrido_tramo
from @tramos
where reco_tram_tramid = tramo
delete PENSAMIENTO_LINEAL.Tramo
from @tramos
where tram_id = tramo
delete PENSAMIENTO_LINEAL.Puerto
where @puerto = puer_id
end