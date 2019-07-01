Use [GD1C2019]
go
CREATE function PENSAMIENTO_LINEAL.Estado(@crucero int,@fecha smallDateTime)
returns bit
as
begin

if (Not Exists(select * from PENSAMIENTO_LINEAL.Estado_crucero where @crucero = esta_crucero) and NOT EXISTS (select cruc_bajadef from PENSAMIENTO_LINEAL.Crucero where @crucero = cruc_id and cruc_bajadef = NULL))
	return 1
if (Not Exists(select * from PENSAMIENTO_LINEAL.Estado_crucero where @crucero = esta_crucero and esta_fechabaja<@fecha) and NOT EXISTS (select cruc_bajadef from PENSAMIENTO_LINEAL.Crucero where @crucero = cruc_id and cruc_bajadef = NULL))
	return 1
Declare @fecha2 smallDateTime = (select Top 1 esta_fechaalta from PENSAMIENTO_LINEAL.Estado_crucero where esta_crucero= @crucero order by esta_fechaalta DESC)
if(@fecha2<@fecha)
	return 1
return 0
end
go
CREATE Procedure PENSAMIENTO_LINEAL.PasarViajesCruceros (@crucero int)
as
begin
Declare @Marca int = (select Top 1 cruc_marca from PENSAMIENTO_LINEAL.Crucero where cruc_id=@crucero)
Declare @Modelo int = (select Top 1 cruc_modelo from PENSAMIENTO_LINEAL.Crucero where cruc_id=@crucero)
Declare @cabinas table (TipoCab int, Cant int)
insert Into @cabinas
select cabi_tipo, COUNT(cabi_id) from PENSAMIENTO_LINEAL.Cabina where cabi_crucero=@crucero group by cabi_tipo



declare @prueba int = (select Top 1 Cant from @cabinas)
print @prueba

declare viajes cursor LOCAL for select reco_cruc_crucid, reco_cruc_recoid, reco_cruc_salida, reco_cruc_id from PENSAMIENTO_LINEAL.Recorrido_crucero where reco_cruc_crucid=@crucero
declare @Cruc_ID int
declare @Reco_ID int
declare @Viaje_ID int
declare @Salida smallDateTime

open viajes
fetch Next from viajes Into @cruc_ID,@Reco_ID,@Salida,@Viaje_ID
while (@@FETCH_STATUS = 0)
begin
	declare @Tiempo int = (select Count(tram_duracion) from PENSAMIENTO_LINEAL.Recorrido_tramo join PENSAMIENTO_LINEAL.Tramo on (reco_tram_tramid = tram_id) where reco_tram_recoid = @Reco_ID)
	declare @Llegada smallDateTime = DateAdd(HOUR,@Tiempo,@Salida)

	declare Cruceros cursor for select DISTINCT(cruc_id)
	from PENSAMIENTO_LINEAL.Crucero                                                                                      
	where cruc_id <> @crucero and (cruc_marca = @Marca and cruc_modelo = @Modelo 
	and cruc_id NOT IN (SELECT reco_cruc_crucid FROM PENSAMIENTO_LINEAL.Recorrido_crucero) OR 
	cruc_id NOT IN (SELECT DISTINCT(reco_cruc_crucid) FROM PENSAMIENTO_LINEAL.Recorrido_crucero WHERE CONVERT(datetime,@Llegada,131) > reco_cruc_salida AND CONVERT(datetime, @Salida, 131) < reco_cruc_llegada_real))
	and PENSAMIENTO_LINEAL.Estado(cruc_id, @Salida) = 1
	open Cruceros
	Declare @cruz int
	fetch Next from Cruceros into @cruz
	while (@@FETCH_STATUS = 0)
	begin
		Declare @cabinas2 table (TipoCab2 int, Cant2 int)
		insert Into @cabinas2
		select cabi_tipo, COUNT(cabi_id) from PENSAMIENTO_LINEAL.Cabina where cabi_crucero=@cruz group by cabi_tipo
		Declare @diff table (diff int)
		insert @diff
		select (Cant2 - Cant) from @cabinas2 Join @cabinas on (TipoCab = TipoCab2)
		delete @cabinas2
		if(Not Exists(select * from @diff where diff <> 0))
		begin
			declare @Pasajes table (IDPasaje int, IDCabina int, TipoCabina int)
			insert into @Pasajes
			select pasa_id, cabi_id, cabi_tipo from PENSAMIENTO_LINEAL.Pasaje join PENSAMIENTO_LINEAL.Cabina on (pasa_cabina=cabi_id) where @Viaje_ID = pasa_viaje
			declare @pasaCant int = (select COUNT(*) from @Pasajes)
			print @pasaCant
			declare cabinas cursor for (select cabi_id, cabi_tipo from PENSAMIENTO_LINEAL.Cabina where cabi_crucero = @cruz)
			declare @cab int
			declare @Tipe int
			open cabinas
			fetch Next from cabinas Into @cab, @Tipe
			while (@@FETCH_STATUS = 0 or not Exists(select * from @Pasajes))
				begin
					declare @pas int = (select Top 1 IDPAsaje from @Pasajes where @Tipe = TIpoCabina)
					declare @cabin int = (select Top 1 IDCabina from @Pasajes where @Tipe = TIpoCabina)
					update PENSAMIENTO_LINEAL.Pasaje
					Set pasa_cabina = @cabin
					where pasa_id = @pas
					delete @Pasajes
					where IDPasaje = @pas
					fetch Next from cabinas into @cab, @Tipe
				end
				close cabinas
				deallocate cabinas
				
			update PENSAMIENTO_LINEAL.Recorrido_crucero
			Set reco_cruc_crucid = @cruz
			where @Viaje_ID = reco_cruc_id
			
		end
		fetch Next from Cruceros into @cruz
	end
	close Cruceros
	deallocate Cruceros
	fetch Next from viajes Into @cruc_ID,@Reco_ID,@Salida,@Viaje_ID
end
close viajes
deallocate viajes
end
go
CREATE procedure PENSAMIENTO_LINEAL.BorrarReservasViejas
as
begin
	delete PENSAMIENTO_LINEAL.Reserva
	where abs(DateDiff(Day,rese_fecha,GetDate()))>3
end
go
CREATE Procedure RetrasarCrucero (@crucero int, @Baja smallDateTime, @Alta smallDateTime)
as
begin
	Declare @diff int = abs(DateDiff(DAY,@Baja,@Alta))
	update PENSAMIENTO_LINEAL.Recorrido_crucero
	Set reco_cruc_salida= DATEADD(DAY,@diff,reco_cruc_salida),reco_cruc_llegada_real=DATEADD(DAY,@diff,reco_cruc_llegada_real)
	where reco_cruc_crucid=@crucero and reco_cruc_salida>@Baja
end
GO
CREATE function PENSAMIENTO_LINEAL.CodificarSha256(@contra varchar)
returns binary(32)
as
begin
return (HASHBYTES('SHA2_256',@contra))
end

GO
CREATE trigger PENSAMIENTO_LINEAL.CodificarContrasenia
on PENSAMIENTO_LINEAL.Usuario
instead of insert
as
begin
insert into PENSAMIENTO_LINEAL.Usuario
select usua_nombre,usua_apellido,usua_direccion,usua_mail,usua_username,PENSAMIENTO_LINEAL.CodificarSha256(usua_password),usua_telefono,usua_documento,usua_fechanac, usua_habilitado
from inserted
where usua_username IS NOT NULL
end

go
CREATE Procedure PENSAMIENTO_LINEAL.chasquearDedos (@puerto int)
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


