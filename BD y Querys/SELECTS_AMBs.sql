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

-- Mostrar cruceros, sus cabinas y tipos
select cruc_id as ID, cruc_identificador as IDENTIFICADOR, cabi_numero as NUMERO, cabi_piso as PISO, tipo_nombre as NOMBRE, tipo_porc_rec as RECARGO 
from PENSAMIENTO_LINEAL.Crucero
	join PENSAMIENTO_LINEAL.Cabina on (cruc_id = cabi_crucero)
	join PENSAMIENTO_LINEAL.Tipo_cabina on (cabi_tipo = tipo_id)
order by cruc_id desc

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