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
    public static class Crucero_BD
    {
        public static void cargar_grilla_cruceros(DataGridView grillaCruceros)
        {
            string query = string.Format(@"SELECT cruc_id as ID, cruc_identificador as Identificador, cruc_marca as Marca, cruc_modelo as Modelo
                                           FROM PENSAMIENTO_LINEAL.Crucero
                                           ORDER BY 1 ASC");
            DBConnection.llenar_grilla(grillaCruceros, query);
        }
    }
}
