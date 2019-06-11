CREATE PROCEDURE PENSAMIENTO_LINEAL.MigrarDB
AS

INSERT INTO PENSAMIENTO_LINEAL.Marca (marc_nombre)
SELECT  CRU_FABRICANTE 
from gd_esquema.Maestra 
group by CRU_FABRICANTE

INSERT INTO PENSAMIENTO_LINEAL.Modelo (mode_nombre)
select CRUCERO_MODELO 
from gd_esquema.Maestra 
group by crucero_modelo 
order by CRUCERO_MODELO;

INSERT INTO PENSAMIENTO_LINEAL.Tipo_Cabina (tipo_nombre, tipo_porc_rec)
select cabina_tipo, cabina_tipo_porc_recargo 
from gd_esquema.Maestra 
group by CABINA_TIPO, CABINA_TIPO_PORC_RECARGO

INSERT INTO PENSAMIENTO_LINEAL.Puerto (puer_nombre)
select puerto_desde 
from gd_esquema.Maestra 
group by puerto_desde

INSERT INTO PENSAMIENTO_LINEAL.Usuario (usua_nombre,usua_apellido,usua_documento,usua_direccion,usua_telefono,usua_mail,usua_fechanac)
select cli_nombre, cli_apellido, cli_dni, cli_direccion, cli_telefono, cli_mail, cli_fecha_nac 
from gd_esquema.Maestra 
group by cli_nombre, cli_apellido, cli_dni, cli_direccion, cli_telefono, cli_mail, cli_fecha_nac 

INSERT INTO PENSAMIENTO_LINEAL.Crucero (cruc_identificador,cruc_marca,cruc_modelo)
select a.crucero_identificador, b.marc_id, c.mode_id 
from gd_esquema.Maestra a 
join PENSAMIENTO_LINEAL.Marca b on a.CRU_FABRICANTE=b.marc_nombre 
join PENSAMIENTO_LINEAL.Modelo c on a.CRUCERO_MODELO=c.mode_nombre 
group by a.crucero_identificador,b.marc_id, c.mode_id

INSERT INTO PENSAMIENTO_LINEAL.Cabina (cabi_piso,cabi_numero,cabi_crucero,cabi_tipo)
select a.cabina_piso, a.CABINA_NRO, b.cruc_id, c.tipo_id 
from gd_esquema.Maestra a 
join PENSAMIENTO_LINEAL.Marca d on d.marc_nombre = a.CRU_FABRICANTE
join PENSAMIENTO_LINEAL.Crucero b on b.cruc_marca = d.marc_id and b.cruc_identificador=a.CRUCERO_IDENTIFICADOR
join PENSAMIENTO_LINEAL.Tipo_cabina c on c.tipo_nombre = a.CABINA_TIPO
group by a.cabina_piso, a.CABINA_NRO, b.cruc_id, c.tipo_id 
order by b.cruc_id, a.cabina_piso, a.CABINA_NRO

INSERT INTO PENSAMIENTO_LINEAL.Tramo (tram_origen,tram_destino,tram_precio,tram_duracion)
select distinct a.puer_id, b.puer_id, c.recorrido_precio_base, DATEDIFF(hour, c.FECHA_SALIDA, c.FECHA_LLEGADA_ESTIMADA) 
from pensamiento_lineal.puerto a 
join gd_esquema.maestra c on a.puer_nombre=c.puerto_desde 
join pensamiento_lineal.puerto b on b.puer_nombre=c.puerto_hasta 
group by a.puer_id, b.puer_id, c.recorrido_precio_base, c.FECHA_SALIDA, c.FECHA_LLEGADA_ESTIMADA, c.RECORRIDO_PRECIO_BASE, c.recorrido_precio_base
order by a.puer_id, b.puer_id

INSERT INTO PENSAMIENTO_LINEAL.Recorrido (reco_codigo,reco_primertramo)
select a.recorrido_codigo,b.tram_id
from gd_esquema.Maestra a 
join pensamiento_lineal.puerto c on c.puer_nombre=a.puerto_desde
join pensamiento_lineal.puerto d on d.puer_nombre=a.puerto_hasta
join PENSAMIENTO_LINEAL.Tramo b on c.puer_id=b.tram_origen and d.puer_id=b.tram_destino
group by a.recorrido_codigo, b.tram_id, a.recorrido_precio_base

INSERT INTO PENSAMIENTO_LINEAL.Recorrido_tramo (reco_tram_recoid,reco_tram_tramid)
select e.reco_id,b.tram_id
from gd_esquema.Maestra a 
join pensamiento_lineal.puerto c on c.puer_nombre=a.puerto_desde
join pensamiento_lineal.puerto d on d.puer_nombre=a.puerto_hasta
join PENSAMIENTO_LINEAL.Tramo b on c.puer_id=b.tram_origen and d.puer_id=b.tram_destino
join PENSAMIENTO_LINEAL.Recorrido e on e.reco_primertramo=b.tram_id
group by e.reco_id, b.tram_id

INSERT INTO PENSAMIENTO_LINEAL.Recorrido_crucero (reco_cruc_recoid,reco_cruc_crucid,reco_cruc_salida,reco_cruc_llegada_real)
select b.reco_id, c.cruc_id, a.FECHA_SALIDA, a.FECHA_LLEGADA
from PENSAMIENTO_LINEAL.recorrido b
join PENSAMIENTO_LINEAL.tramo d on b.reco_primertramo=d.tram_id
join PENSAMIENTO_LINEAL.puerto e on d.tram_origen=e.puer_id
join PENSAMIENTO_LINEAL.puerto f on d.tram_destino=f.puer_id
join gd_esquema.Maestra a on e.puer_nombre=a.PUERTO_DESDE and f.puer_nombre=a.PUERTO_HASTA
join PENSAMIENTO_LINEAL.Crucero c on c.cruc_identificador=a.CRUCERO_IDENTIFICADOR
group by b.reco_id, c.cruc_id, a.FECHA_SALIDA,a.FECHA_LLEGADA_ESTIMADA, a.FECHA_LLEGADA

INSERT INTO PENSAMIENTO_LINEAL.Pasaje (pasa_codigo,pasa_fecha,pasa_precio,pasa_cliente,pasa_viaje,pasa_cabina)
select a.PASAJE_CODIGO,a.PASAJE_FECHA_COMPRA,a.PASAJE_PRECIO, c.usua_id,j.reco_cruc_crucid,h.cabi_id
from gd_esquema.Maestra a
join PENSAMIENTO_LINEAL.Crucero d on d.cruc_identificador=CRUCERO_IDENTIFICADOR
join PENSAMIENTO_LINEAL.Usuario c on c.usua_apellido=a.CLI_APELLIDO and c.usua_nombre=a.CLI_NOMBRE and c.usua_documento=a.CLI_DNI
join PENSAMIENTO_LINEAL.Recorrido e on e.reco_codigo=a.RECORRIDO_CODIGO
join PENSAMIENTO_LINEAL.Tramo f on f.tram_id=e.reco_primertramo
join PENSAMIENTO_LINEAL.Puerto i on i.puer_id=f.tram_origen and i.puer_nombre=a.PUERTO_DESDE
join PENSAMIENTO_LINEAL.Cabina h on h.cabi_numero = a.CABINA_NRO and h.cabi_piso=a.CABINA_PISO and h.cabi_crucero=d.cruc_id
join PENSAMIENTO_LINEAL.Recorrido_crucero j on j.reco_cruc_recoid = e.reco_id and j.reco_cruc_crucid = d.cruc_id and j.reco_cruc_salida=a.FECHA_SALIDA
where RESERVA_CODIGO is null
group by a.PASAJE_CODIGO,a.PASAJE_FECHA_COMPRA,a.PASAJE_PRECIO,c.usua_id,d.cruc_id,e.reco_id,j.reco_cruc_crucid,h.cabi_id

INSERT INTO PENSAMIENTO_LINEAL.Reserva (rese_codigo,rese_fecha,rese_cliente,rese_viaje,rese_cabina)
select a.RESERVA_CODIGO,a.RESERVA_FECHA, c.usua_id,j.reco_cruc_crucid,h.cabi_id
from gd_esquema.Maestra a
join PENSAMIENTO_LINEAL.Crucero d on d.cruc_identificador=CRUCERO_IDENTIFICADOR
join PENSAMIENTO_LINEAL.Usuario c on c.usua_apellido=a.CLI_APELLIDO and c.usua_nombre=a.CLI_NOMBRE and c.usua_documento=a.CLI_DNI
join PENSAMIENTO_LINEAL.Recorrido e on e.reco_codigo=a.RECORRIDO_CODIGO
join PENSAMIENTO_LINEAL.Tramo f on f.tram_id=e.reco_primertramo
join PENSAMIENTO_LINEAL.Puerto i on i.puer_id=f.tram_origen and i.puer_nombre=a.PUERTO_DESDE
join PENSAMIENTO_LINEAL.Cabina h on h.cabi_numero = a.CABINA_NRO and h.cabi_piso=a.CABINA_PISO and h.cabi_crucero=d.cruc_id
join PENSAMIENTO_LINEAL.Recorrido_crucero j on j.reco_cruc_recoid = e.reco_id and j.reco_cruc_crucid = d.cruc_id and j.reco_cruc_salida=a.FECHA_SALIDA
where PASAJE_CODIGO is null
group by a.RESERVA_CODIGO,a.RESERVA_FECHA, c.usua_id,d.cruc_id,e.reco_id,h.cabi_id,j.reco_cruc_crucid

GO

exec PENSAMIENTO_LINEAL.MigrarDB
