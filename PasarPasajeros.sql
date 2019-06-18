USE [GD1C2019]

go
create function Estado(@crucero int)
returns bit
as
begin
declare @mayorAlta smallDateTime = (select Top 1 esta_fechaalta from PENSAMIENTO_LINEAL.Estado_crucero where @crucero = esta_crucero order by esta_fechaalta DESC)
declare @mayorBaja smallDateTime = (select Top 1 esta_desc from PENSAMIENTO_LINEAL.Estado_crucero where @crucero = esta_crucero order by esta_desc DESC)

	if(@mayorAlta > @mayorBaja)
	return 1
return 0
end
/*
go
CREATE trigger DeleteServiciosCruzero
ON PENSAMIENTO_LINEAL.Servicio
after delete
as
begin
	delete PENSAMIENTO_LINEAL.Crucero_Servicio
	from PENSAMIENTO_LINEAL.Crucero_Servicio
	join deleted on (cruc_serv_servid=serv_id)
end*/
go
CREATE function buscarCruzeroRecoridoConLugar(@fecha dateTime, @origen int, @destino int)
returns int
begin
return (select reco_cruc_crucid
from PENSAMIENTO_LINEAL.Recorrido_crucero join
	 PENSAMIENTO_LINEAL.Recorrido on (reco_cruc_recoid = reco_codigo AND reco_primertramo = @origen) join
	 PENSAMIENTO_LINEAL.Recorrido_tramo on (reco_tram_recoid = reco_codigo) join
	 PENSAMIENTO_LINEAL.Tramo on (reco_tram_tramid = tram_id)
	 where tram_destino = @destino AND ABS(DATEDIFF(DAY,reco_cruc_salida,@fecha))<20 AND dbo.ContarPasajeros(reco_cruc_crucid,reco_cruc_recoid,reco_cruc_salida)>0)
end
go
CREATE function buscar1CruzeroRecoridoConLugar(@fecha dateTime, @origen int, @destino int)
returns int
begin
return (select TOP 1 reco_cruc_crucid
from PENSAMIENTO_LINEAL.Recorrido_crucero join
	 PENSAMIENTO_LINEAL.Recorrido on (reco_cruc_recoid = reco_codigo AND reco_primertramo = @origen) join
	 PENSAMIENTO_LINEAL.Recorrido_tramo on (reco_tram_recoid = reco_codigo) join
	 PENSAMIENTO_LINEAL.Tramo on (reco_tram_tramid = tram_id)
	 where tram_destino = @destino AND abs(DATEDIFF(DAY,reco_cruc_salida,@fecha))<2/* AND ContarPasajeros(reco_cruc_crucid,reco_cruc_recoid,reco_cruc_salida)>0*/)
end

go

CREATE function BuscarCruzeroReco (@fecha dateTime, @reco int, @crucero int)
returns table as

return select reco_cruc_crucid, reco_cruc_recoid, reco_cruc_salida
from PENSAMIENTO_LINEAL.Recorrido_crucero
where reco_cruc_recoid=@reco and abs(DATEDIFF(DAY,reco_cruc_salida,@fecha))<20 and reco_cruc_crucid <> @crucero and -DATEDIFF(DAY,reco_cruc_salida,@fecha)<20
	 /*
Create function BuscarCruzeroReco (@fecha dateTime, @reco int, @crucero)
returns table as
begin
return (select reco_cruc_crucid, reco_cruc_recoid, reco_cruc_salida
from PENSAMIENTO_LINEAL.Recorrido_crucero
where reco_cruc_recoid=@reco and DATEDIFF(DAY,reco_cruc_salida,@fecha)<20 and reco_cruc_crucid <> @crucero)
end*/
go
CREATE function ContarPasajeros(@reco int, @crucero int, @fecha dateTime)
returns int
as
begin
Declare @id int;
set @id = (select top 1 reco_cruc_id from PENSAMIENTO_LINEAL.Recorrido_crucero where reco_cruc_crucid = @crucero AND reco_cruc_recoid = @reco AND reco_cruc_salida = @fecha);
return (select COUNT(*) 
		from PENSAMIENTO_LINEAL.Pasaje 
		where pasa_viaje=@id)
end



go
CREATE function buscar1CruzeroRecorido(@fecha dateTime, @origen int, @destino int)
returns int
begin
return (select TOP 1 reco_cruc_crucid
from PENSAMIENTO_LINEAL.Recorrido_crucero join
	 PENSAMIENTO_LINEAL.Recorrido on (reco_cruc_recoid = reco_codigo AND reco_primertramo = @origen) join
	 PENSAMIENTO_LINEAL.Recorrido_tramo on (reco_tram_recoid = reco_codigo) join
	 PENSAMIENTO_LINEAL.Tramo on (reco_tram_tramid = tram_id)
	 where tram_destino = @destino AND ABS(DATEDIFF(DAY,reco_cruc_salida,@fecha))<2)
end

go
CREATE function LugaresLibres(@reco int, @crucero int, @fecha dateTime)
returns int
as
begin
Declare @id int;
set @id = (select top 1 reco_cruc_id from PENSAMIENTO_LINEAL.Recorrido_crucero where reco_cruc_crucid = @crucero AND reco_cruc_recoid = @reco AND reco_cruc_salida = @fecha);

return (select COUNT(*) 
		from PENSAMIENTO_LINEAL.Pasaje 
		where pasa_viaje=@id)-
		(select COUNT (*)
		from PENSAMIENTO_LINEAL.Cabina join
			 PENSAMIENTO_LINEAL.Crucero on (cabi_crucero = cruc_id))
end

go
CREATE PROCEDURE pasarPasajeros (@cruc int, @reco int,@fech dateTime)
as
begin
Declare @pasajeros int
Declare @ViajeOriginal int = (select Top 1 reco_cruc_id 
							  from PENSAMIENTO_LINEAL.Recorrido_crucero 
							  where reco_cruc_crucid=@cruc and reco_cruc_recoid=@reco and reco_cruc_salida=@fech)
SET @pasajeros = dbo.conContarPasajeros(@reco, @cruc, @fech)
Declare @cruzeros table (Cruc int, Reco int, fech dateTime)
insert Into @cruzeros
SELECT A1.reco_cruc_recoid,A1.reco_cruc_crucid,A1.reco_cruc_salida from BuscarCruzeroReco(@fech,@reco,@cruc) as A1 where dbo.Estado(A1.reco_cruc_crucid)=1

Declare db_cursor CURSOR FOR (Select reco_cruc_crucid, reco_cruc_recoid, reco_cruc_salida
from PENSAMIENTO_LINEAL.Recorrido_crucero C1 join @cruzeros C2 on (C1.reco_cruc_crucid = C2.Cruc AND C1.reco_cruc_recoid = C2.Reco AND C1.reco_cruc_salida = C2.fech))

Declare @crucero int
Declare @recorrido int
Declare @fecha int
Declare @cantidad int

open db_cursor
fetch NEXT from db_cursor INTO @crucero, @recorrido, @fecha
while (@@FETCH_STATUS = 0 AND @pasajeros>0)
begin
	Declare @Viaje int = (select top 1 reco_cruc_id from PENSAMIENTO_LINEAL.Recorrido_crucero where reco_cruc_crucid=@crucero and reco_cruc_recoid = @recorrido and reco_cruc_salida = @fecha)
/*	SET @cantidad = LugaresLibres(@cruzero, @recorrido, @fecha)*/
	DECLARE @Cabinas table (idpasajero int, idCabina int, Tipocabina int)
	insert Into @Cabinas
		SELECT pasa_codigo, pasa_cabina, cabi_tipo
		from PENSAMIENTO_LINEAL.Pasaje JOIN PENSAMIENTO_LINEAL.Cabina on (pasa_cabina = cabi_id)
	DECLARE @CabinasLibres table (idCabina int, Tipocabina int)
	insert into @CabinasLibres
	select cabi_id, cabi_tipo from PENSAMIENTO_LINEAL.Cabina where cabi_crucero = @crucero
	delete @CabinasLibres
	from PENSAMIENTO_LINEAL.Cabina join PENSAMIENTO_LINEAL.Pasaje on ( pasa_cabina = cabi_id)
	where pasa_viaje = @Viaje
	declare CabinasCursor Cursor FOR (select * from @CabinasLibres)
	declare @Cab_ID int
	declare @Tip_ID int
	open CabinasCursor
	fetch NEXT from CabinasCursor INTO @Cab_ID, @Tip_ID
		while (@@FETCH_STATUS = 0 AND @pasajeros>0)
		begin
			update PENSAMIENTO_LINEAL.Pasaje
			Set pasa_cabina=@Cab_ID, pasa_viaje=@Viaje
			where pasa_viaje=@ViajeOriginal
	
			fetch NEXT from CabinasCursor INTO @Cab_ID, @Tip_ID
		
	close CabinaCursor
	fetch NEXT from db_cursor INTO @crucero, @recorrido, @fecha
	end
	close db_cursor
end
end
/**/

