using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using FrbaCrucero.Clases;

namespace FrbaCrucero.BD_y_Querys
{
    public static class Puerto_BD
    {
        public static void cargar_grilla_puertos(DataGridView grillaPuertos)
        {
            string query = string.Format(@"SELECT puer_nombre as Puerto
                                           FROM PENSAMIENTO_LINEAL.Puerto
                                           ORDER BY 1 ASC");
            DBConnection.llenar_grilla(grillaPuertos, query);
        }

        public static List<Puerto> obtener_todos_puertos()
        {
            List<Puerto> puertos = new List<Puerto>();
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.Puerto");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["puer_id"].ToString());                
                string nombre = reader["puer_nombre"].ToString();

                Puerto puerto = new Puerto(id, nombre);
                puertos.Add(puerto);
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return puertos;
        }
    }
}
