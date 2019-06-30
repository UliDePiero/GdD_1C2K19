using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
namespace FrbaCrucero.BD_y_Querys
{
    public static class Estadistica_BD
    {
        public static void cargar_grilla_estadisticas(DataGridView grillaEstadistica, string semestre, int anio, Estadistica estadistica)
        {
            string query = "";
            switch (estadistica)
            {
                case Estadistica.CRUCEROS_CON_MAS_DIAS_INHABILES:
                    query = string.Format(@"select TOP 5 cruc_id as ID, cruc_identificador as IDENTIFICADOR,
                                            marc_nombre as MARCA, mode_nombre as MODELO,
                                            sum(PENSAMIENTO_LINEAL.diasFuera(" + anio + @", '"+ semestre + @"', esta_fechabaja, esta_fechaalta)) as DIAS_FUERA_DE_SERVICIO
                                            from PENSAMIENTO_LINEAL.Crucero
                                            	join PENSAMIENTO_LINEAL.Estado_crucero on (cruc_id = esta_crucero)
                                                join PENSAMIENTO_LINEAL.Marca on (cruc_marca = marc_id)
	                                            join PENSAMIENTO_LINEAL.Modelo on (cruc_modelo = mode_id)
                                            where month(esta_fechaalta) " + semestre + @" AND year(esta_fechaalta) = " + anio + @"
                                            group by cruc_id, cruc_identificador, marc_nombre, mode_nombre
                                            order by 5 desc");
                    break;
                case Estadistica.RECORRIDOS_CON_MAS_CABINAS_LIBRES:
                    query = string.Format(@"select TOP 5 reco_cruc_recoid as RECORRIDO, reco_codigo as RECO_CODIGO, puer_nombre as ORIGEN, 
                                            reco_cruc_crucid as CRUCERO, marc_nombre as MARCA, mode_nombre as MODELO,
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
                                            where month(reco_Cruc_salida) "+ semestre +@" AND year(reco_cruc_salida) = "+ anio +@" 
                                            group by reco_cruc_recoid, reco_codigo, puer_nombre, reco_cruc_crucid, marc_nombre, mode_nombre
                                            order by 7 desc");
                    break;
                case Estadistica.RECORRIDOS_CON_MAS_PASAJES:
                    query = string.Format(@"select TOP 5 reco_cruc_recoid as ID, reco_codigo as CODIGO, puer_nombre as ORIGEN,
                                            count(pasa_id) as CANTIDAD_VENDIDOS, sum(pasa_precio) as GANANCIA
                                            from PENSAMIENTO_LINEAL.Recorrido_crucero
                                            	join PENSAMIENTO_LINEAL.Pasaje on (reco_cruc_id = pasa_viaje)
                                            	join PENSAMIENTO_LINEAL.Recorrido on (reco_cruc_recoid = reco_id)
                                            	join PENSAMIENTO_LINEAL.Tramo on (reco_primertramo = tram_id)
                                            	join PENSAMIENTO_LINEAL.Puerto on (tram_origen = puer_id)
                                            where month(pasa_fecha) " + semestre + @" AND year(pasa_fecha) = "+ anio +@"
                                            group by reco_cruc_recoid, reco_codigo, puer_nombre
                                            order by 4 desc");
                    break;
            }

            DBConnection.llenar_grilla(grillaEstadistica, query);
        }
    }

    public enum Estadistica
    {
        RECORRIDOS_CON_MAS_PASAJES,
        RECORRIDOS_CON_MAS_CABINAS_LIBRES,
        CRUCEROS_CON_MAS_DIAS_INHABILES
    }
}
