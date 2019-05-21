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
    public static class ROL_BD
    {
        public static void cargar_grilla_roles(DataGridView grillaRoles, bool habilitado)
        {
            string query = string.Format(@"SELECT DISTINCT (PUERTO_DESDE)
                                           FROM gd_esquema.Maestra
                                           ORDER BY PUERTO_DESDE ASC");
            //string query = string.Format(@"SELECT Rol_codigo Código, Rol_nombre Nombre, Rol_habilitado Habilitado FROM PENSAMIENTO_LINEAL.Rol");
            /*if (habilitado)
            {
                query += " WHERE Rol_habilitado = 1";
            }*/
            DBConnection.llenar_grilla(grillaRoles, query);
        }
    }
}
