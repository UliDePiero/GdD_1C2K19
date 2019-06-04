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
    public static class Recorrido_BD
    {
        public static void cargar_grilla_recorridos(DataGridView grillaRecorridos)
        {
            string query = string.Format(@"SELECT reco_codigo as Codigo, reco_primertramo as Puerto_origen
                                           FROM PENSAMIENTO_LINEAL.Recorrido
                                           ORDER BY 1 ASC");
            DBConnection.llenar_grilla(grillaRecorridos, query);
        }
    }
}
