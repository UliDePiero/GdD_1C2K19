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
                    query = string.Format(@"select TOP 5 cruc_id as ID, cruc_identificador as IDENTIFICADOR, sum(dbo.diasFuera(" + anio + @", '"+ semestre +@"', esta_fechabaja, esta_fechaalta)) as DIAS_FUERA_DE_SERVICIO
                                            from PENSAMIENTO_LINEAL.Crucero
                                            	join PENSAMIENTO_LINEAL.Estado_crucero on (cruc_id = esta_crucero)
                                            where month(esta_fechaalta) " + semestre + @" AND year(esta_fechaalta) = " + anio + @"
                                            group by cruc_id, cruc_identificador
                                            order by 3 desc");
                    break;
                case Estadistica.RECORRIDOS_CON_MAS_CABINAS_LIBRES:
                    break;
                case Estadistica.RECORRIDOS_CON_MAS_PASAJES:
                    query = string.Format(@"select TOP 5 reco_cruc_recoid as ID, count(pasa_id) as CANTIDAD_VENDIDOS, sum(pasa_precio) as GANANCIA
                                            from PENSAMIENTO_LINEAL.Recorrido_crucero
                                            	join PENSAMIENTO_LINEAL.Pasaje on (reco_cruc_id = pasa_viaje)
                                            where month(pasa_fecha) " + semestre + " AND year(pasa_fecha) = " + anio + @"
                                            group by reco_cruc_recoid
                                            order by 2 desc");
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
