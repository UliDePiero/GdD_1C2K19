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
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.Puerto ORDER BY puer_nombre ASC");
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

        public static int obtener_IDpuerto_con_nombre(string puer_nombre)
        {
            string query = string.Format(@"SELECT puer_id FROM PENSAMIENTO_LINEAL.Puerto WHERE puer_nombre=@puer_nombre");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@puer_nombre", puer_nombre);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id = int.Parse(reader["puer_id"].ToString());
            
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return id;
        }

        public static Puerto obtener_puerto_con_nombre(string puer_nombre)
        {
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.Puerto WHERE puer_nombre=@puer_nombre");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@puer_nombre", puer_nombre);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id = int.Parse(reader["puer_id"].ToString());
            string nombre = reader["puer_nombre"].ToString();
            Puerto puerto = new Puerto(id, nombre);

            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return puerto;
        }
    }
}
