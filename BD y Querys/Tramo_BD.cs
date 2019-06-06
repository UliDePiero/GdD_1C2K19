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
    public static class Tramo_BD
    {
        public static void cargar_grilla_tramos(DataGridView grillaTramos)
        {
            string query = string.Format(@"SELECT tram_precio as Precio, tram_duracion as Duracion, tram_origen as Puerto_origen, tram_destino as Puerto_destino
                                           FROM PENSAMIENTO_LINEAL.Tramo
                                           ORDER BY 1 ASC");
            DBConnection.llenar_grilla(grillaTramos, query);
        }
    }
}
