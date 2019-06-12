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
                    query = string.Format(@"select TOP 5 cruc_id as ID, cruc_identificador as IDENTIFICADOR, sum(DATEDIFF(day, esta_fechabaja, esta_fechaalta)) as DIAS_FUERA_DE_SERVICIO
                                            from PENSAMIENTO_LINEAL.Crucero
                                            	join PENSAMIENTO_LINEAL.Estado_crucero on (cruc_id = esta_crucero)
                                            where month(esta_fechaalta)" + semestre + @" AND year(esta_fechaalta) = " + anio + @"
                                            group by cruc_id, cruc_identificador
                                            order by 3 desc");
                    break;
                case Estadistica.RECORRIDOS_CON_MAS_CABINAS_LIBRES:
                    break;
                case Estadistica.RECORRIDOS_CON_MAS_PASAJES:
                    query = string.Format(@"select TOP 5 reco_id as ID, reco_codigo as CODIGO, puer_nombre as CIUDAD_ORIGEN,
                                            (select p2.puer_nombre
                                            from PENSAMIENTO_LINEAL.Recorrido as r2
                                            	join PENSAMIENTO_LINEAL.Recorrido_tramo as rt1 on (r2.reco_id = rt1.reco_tram_recoid)
                                            	join PENSAMIENTO_LINEAL.Tramo as t2 on (rt1.reco_tram_tramid = t2.tram_id)
                                            	join PENSAMIENTO_LINEAL.Puerto as p2 on (t2.tram_destino = p2.puer_id)
                                            where t2.tram_destino NOT IN (
                                            								select t3.tram_origen
                                            								from PENSAMIENTO_LINEAL.Recorrido as r3
                                            									join PENSAMIENTO_LINEAL.Recorrido_tramo as rt2 on (r3.reco_id = rt2.reco_tram_recoid)
                                            									join PENSAMIENTO_LINEAL.Tramo as t3 on (rt2.reco_tram_tramid = t3.tram_id)
                                            								where r2.reco_id = r3.reco_id
                                            							 ) AND r2.reco_id = r1.reco_id) as ULTIMO_DESTINO, count(reco_id) as CANTIDAD_VENDIDOS, sum(pasa_precio) as INGRESOS
                                            
                                            from PENSAMIENTO_LINEAL.Recorrido as r1
                                            	join PENSAMIENTO_LINEAL.Pasaje on (reco_id = pasa_recorrido)
                                            	join PENSAMIENTO_LINEAL.Tramo on (reco_primertramo = tram_id)
                                            	join PENSAMIENTO_LINEAL.Puerto on (tram_origen = puer_id)
                                            where month(pasa_fecha)" + semestre + @" AND year(pasa_fecha) = " + anio + @"
                                            group by reco_id, reco_codigo, puer_nombre
                                            order by count(reco_id) desc");
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
