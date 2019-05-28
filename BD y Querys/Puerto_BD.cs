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
    public static class Puerto_BD
    {
        public static void cargar_grilla_puertos(DataGridView grillaPuertos)
        {
            string query = string.Format(@"SELECT puer_id as ID, puer_nombre as Puerto
                                           FROM PENSAMIENTO_LINEAL.Puerto
                                           ORDER BY 1 ASC");
            DBConnection.llenar_grilla(grillaPuertos, query);
        }
    }
}
