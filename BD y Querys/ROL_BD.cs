﻿using System;
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
            string query = string.Format(@"SELECT rol_id as ID, rol_nombre as ROL
                                           FROM PENSAMIENTO_LINEAL.ROL
                                           ORDER BY 1 ASC");
            DBConnection.llenar_grilla(grillaRoles, query);
        }
    }
}
