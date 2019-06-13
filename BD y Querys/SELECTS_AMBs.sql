-------- ABM CRUCEROS --------

-- Mostrar todos los cruceros
select cruc_identificador as IDENTIFICADOR, mode_nombre as MODELO, marc_nombre as MARCA, cruc_bajadef as BAJA_DEFINITIVA, esta_fechabaja as FECHA_BAJA_SERVICIO, esta_fechaalta as FECHA_ALTA_SERVICIO, count(cabi_id) as CABINAS
from PENSAMIENTO_LINEAL.Crucero 
	join PENSAMIENTO_LINEAL.Marca on (cruc_marca = marc_id) 
	join PENSAMIENTO_LINEAL.Modelo on (cruc_modelo = mode_id)
	left join PENSAMIENTO_LINEAL.Estado_crucero on (cruc_id = esta_crucero)
	join PENSAMIENTO_LINEAL.Cabina on (cruc_id = cabi_crucero)
group by cruc_identificador, mode_nombre, marc_nombre, cruc_bajadef, esta_fechabaja, esta_fechaalta

-- Para saber la marca del crucero en cuestion
select marc_nombre
from PENSAMIENTO_LINEAL.Crucero join PENSAMIENTO_LINEAL.Marca on (cruc_marca = marc_id)
where cruc_identificador LIKE 'identificador del crucero a modificar'

-- Cuando modificas uno existente y queres saber los servicios que tiene
select serv_desc
from PENSAMIENTO_LINEAL.Crucero 
	join PENSAMIENTO_LINEAL.Crucero_Servicio on (cruc_id = cruc_serv_crucid)
	join PENSAMIENTO_LINEAL.Servicio on (cruc_serv_servid = serv_id)
where cruc_identificador LIKE 'identificador del crucero a modificar'

-- Cuando creas uno nuevo y queres saber todos los servicios disponibles
select serv_desc
from PENSAMIENTO_LINEAL.Servicio

-- Mostrar tipos de cabinas
select tipo_nombre as TIPO
from PENSAMIENTO_LINEAL.Tipo_Cabina

---------- ABM ROL ----------

-- Mostrar todos los roles
select rol_nombre
from PENSAMIENTO_LINEAL.Rol

-- Mostrar todas las funciones
select func_nombre
from PENSAMIENTO_LINEAL.Funcionalidad

-- Mostrar las funciones que tiene un rol dado
select func_nombre
from PENSAMIENTO_LINEAL.Rol 
	join PENSAMIENTO_LINEAL.Rol_Funcion on (rol_id = rol_func_rolid)
	join PENSAMIENTO_LINEAL.Funcionalidad on (rol_func_funcid = func_id)
where rol_nombre LIKE 'nombre del rol'

----------- ABM RECORRIDOS -------------

-- mostrar todos los tramos disponibles
select tram_id as ID, p1.puer_nombre as PUERTO_ORIGEN, p2.puer_nombre as PUERTO_DESTINO, tram_duracion as DURACION, tram_precio as PRECIO
from PENSAMIENTO_LINEAL.Tramo
	join PENSAMIENTO_LINEAL.Puerto as p1 on (tram_origen = p1.puer_id)
	join PENSAMIENTO_LINEAL.Puerto as p2 on (tram_destino = p2.puer_id)

-- Todos los puertos en los que para un recorrido dado
select puer_nombre as DESTINO
from PENSAMIENTO_LINEAL.Recorrido
	join PENSAMIENTO_LINEAL.Recorrido_tramo on (reco_id = reco_tram_recoid)
	join PENSAMIENTO_LINEAL.Tramo on (reco_tram_tramid = tram_id)
	join PENSAMIENTO_LINEAL.Puerto on (tram_destino = puer_id)
where reco_id = 44 -- <-- Aca metes el id que corresponda

-- Mostrar todos los recorrido con su puerto de salid y su puerto final del recorrido
select r1.reco_id as RECORRIDO, r1.reco_codigo as CODIGO, p1.puer_nombre as SALIDA, p2.puer_nombre as ULTIMO_DESTINO
from PENSAMIENTO_LINEAL.Recorrido as r1
	join PENSAMIENTO_LINEAL.Recorrido_tramo as rt on (r1.reco_id = rt.reco_tram_recoid)
	join PENSAMIENTO_LINEAL.Tramo as t1 on (r1.reco_primertramo = t1.tram_id)
	join PENSAMIENTO_LINEAL.Tramo as t2 on (rt.reco_tram_tramid = t2.tram_id)
	join PENSAMIENTO_LINEAL.Puerto as p1 on (t1.tram_origen = p1.puer_id)
	join PENSAMIENTO_LINEAL.Puerto as p2 on (t2.tram_destino = p2.puer_id)
where t2.tram_destino NOT IN (
							  select t3.tram_origen
							  from PENSAMIENTO_LINEAL.Recorrido as r2
							  	join PENSAMIENTO_LINEAL.Recorrido_tramo as rt2 on (r2.reco_id = rt2.reco_tram_recoid)
							  	join PENSAMIENTO_LINEAL.Tramo as t3 on (rt2.reco_tram_tramid = t3.tram_id)
							  where r1.reco_id = r2.reco_id
							 )
order by r1.reco_id

----------- ESTADISTICAS ------------
-- TOP 5 de los recorridos con mas pasajes comprados
select TOP 5 reco_cruc_recoid as ID, count(pasa_id) as CANTIDAD_VENDIDOS, sum(pasa_precio) as GANANCIA
from PENSAMIENTO_LINEAL.Recorrido_crucero
	join PENSAMIENTO_LINEAL.Pasaje on (reco_cruc_id = pasa_viaje)
where month(pasa_fecha) <= 6 AND year(pasa_fecha) = 2018
group by reco_cruc_recoid
order by 2 desc

-- TOP 5 de los cruceros con mayor cantidad de dias fuera de servicio
select TOP 5 cruc_id as ID, cruc_identificador as IDENTIFICADOR, 
sum(PENSAMIENTO_LINEAL.diasFuera(2012, '<= 6', esta_fechabaja, esta_fechaalta)) as DIAS_FUERA_DE_SERVICIO
from PENSAMIENTO_LINEAL.Crucero
	join PENSAMIENTO_LINEAL.Estado_crucero on (cruc_id = esta_crucero)
where month(esta_fechaalta) <= 6 AND year(esta_fechaalta) = 2012
group by cruc_id, cruc_identificador
order by 3 desc

/* donde:

create function PENSAMIENTO_LINEAL.diasFuera (@anio numeric(5), @semestre varchar(8), @fechabaja DateTime, @fechaalta DateTime)
returns numeric(10)
as
begin
	declare @retorno numeric(10)

	set @retorno = DATEDIFF(day, @fechabaja, @fechaalta)

	if (@semestre = '<= 6' AND (@fechaalta > concat(@anio, '-06-30 00:00:00')))
		set @retorno = DATEDIFF(day, @fechabaja, concat(@anio, '-06-30 00:00:00'))
	else if (@semestre = '> 6' and (@fechabaja < concat(@anio, '-06-30 00:00:00')))
		set @retorno = DATEDIFF(day, concat(@anio, '-06-30 00:00:00'), @fechaalta)

	return @retorno
end

*/
/*
-- TOP 5 de los recorridos con mayor cantidad de cabinas libres en cada viaje
select TOP 5 reco_cruc_recoid as RECORRIDO, reco_codigo as RECO_CODIGO, puer_nombre as ORIGEN,
PENSAMIENTO_LINEAL.ultimoDestino(reco_id) as ULTIMO_DESTINO, reco_cruc_crucid as CRUCERO,
marc_nombre as MARCA, mode_nombre as MODELO,
((select count(*) as CABINAS_DISPONIBLES
from PENSAMIENTO_LINEAL.Crucero as c2
	join PENSAMIENTO_LINEAL.Cabina on (c2.cruc_id = cabi_crucero)
where c2.cruc_id = reco_cruc_crucid 
group by c2.cruc_id) - count(distinct pasa_cabina)) as CABINAS_LIBRES
from PENSAMIENTO_LINEAL.Recorrido_crucero
	join PENSAMIENTO_LINEAL.Pasaje on (reco_cruc_id = pasa_viaje)
	join PENSAMIENTO_LINEAL.Recorrido on (reco_cruc_recoid = reco_id)
	join PENSAMIENTO_LINEAL.Tramo on (reco_primertramo = tram_id)
	join PENSAMIENTO_LINEAL.Puerto on (tram_origen = puer_id)
	join PENSAMIENTO_LINEAL.Crucero as c1 on (reco_cruc_crucid = c1.cruc_id)
	join PENSAMIENTO_LINEAL.Marca on (c1.cruc_marca = marc_id)
	join PENSAMIENTO_LINEAL.Modelo on (c1.cruc_modelo = mode_id)
where month(reco_cruc_salida) <= 6 AND year(reco_cruc_salida) = 2018 
group by reco_cruc_recoid, reco_codigo, puer_nombre, PENSAMIENTO_LINEAL.ultimoDestino(reco_id),
reco_cruc_crucid, marc_nombre, mode_nombre
order by 8 desc
*/
-- Donde

/*
create function PENSAMIENTO_LINEAL.ultimoDestino(@id_recorrido int)
returns char(20)
as
begin

	return (select p2.puer_nombre as ULTIMO_DESTINO
			from PENSAMIENTO_LINEAL.Recorrido as r1
				join PENSAMIENTO_LINEAL.Recorrido_tramo as rt on (r1.reco_id = rt.reco_tram_recoid)
				join PENSAMIENTO_LINEAL.Tramo as t2 on (rt.reco_tram_tramid = t2.tram_id)
				join PENSAMIENTO_LINEAL.Puerto as p2 on (t2.tram_destino = p2.puer_id)
			where t2.tram_destino NOT IN (
								  select t3.tram_origen
								  from PENSAMIENTO_LINEAL.Recorrido as r2
								  	join PENSAMIENTO_LINEAL.Recorrido_tramo as rt2 on (r2.reco_id = rt2.reco_tram_recoid)
								  	join PENSAMIENTO_LINEAL.Tramo as t3 on (rt2.reco_tram_tramid = t3.tram_id)
								  where r1.reco_id = r2.reco_id
								 ) and r1.reco_id = @id_recorrido)
end      
*/