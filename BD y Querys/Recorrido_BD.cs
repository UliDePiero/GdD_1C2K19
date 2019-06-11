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
    public static class Recorrido_BD
    {
        public static void cargar_grilla_recorridos(DataGridView grillaRecorridos)
        {
            string query = string.Format(@"SELECT reco_codigo as Codigo, reco_primertramo as Puerto_origen
                                           FROM PENSAMIENTO_LINEAL.Recorrido
                                           ORDER BY 1 ASC");
            DBConnection.llenar_grilla(grillaRecorridos, query);
        }

        public static void cargar_grilla_tramos(DataGridView grillaTramos)
        {
            string query = string.Format(@"SELECT tram_id as ID, tram_precio as Precio, tram_duracion as Duracion, p1.puer_nombre as Puerto_Origen, p2.puer_nombre as Puerto_Destino
                                           FROM PENSAMIENTO_LINEAL.Tramo JOIN PENSAMIENTO_LINEAL.Puerto p1 ON(puer_id=tram_origen) JOIN PENSAMIENTO_LINEAL.Puerto p2 ON(puer_id=tram_destino)");
            DBConnection.llenar_grilla(grillaTramos, query);
        }

        public static Tramo obtener_primer_tramo(int recorrido_id)
        {
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.Tramo JOIN PENSAMIENTO_LINEAL.Recorrido ON (tram_id=reco_primertramo) WHERE reco_id=@recorrido_id");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@recorrido_id", recorrido_id);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            int id = int.Parse(reader["tram_id"].ToString());
            decimal precio = decimal.Parse(reader["tram_precio"].ToString());
            decimal duracion = decimal.Parse(reader["tram_duracion"].ToString());
            int origen = int.Parse(reader["tram_origen"].ToString());
            int destino = int.Parse(reader["tram_destino"].ToString());

            Puerto puerto_origen = obtener_puerto_con_ID(origen);
            Puerto puerto_destino = obtener_puerto_con_ID(destino);

            Tramo tramo = new Tramo(id, precio, duracion, puerto_origen, puerto_destino);

            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return tramo;
        }

        public static Puerto obtener_puerto_con_ID(int id)
        {
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.Puerto WHERE puer_id=@id");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            int id_puerto = int.Parse(reader["puer_id"].ToString());
            string nombre_puerto = reader["puer_nombre"].ToString();

            Puerto puerto = new Puerto(id_puerto, nombre_puerto);

            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return puerto;
        }

        public static List<Tramo> obtener_tramos_siguientes(Recorrido recorrido_modif)
        {
            List<Tramo> tramos = new List<Tramo>();
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.Tramo JOIN PENSAMIENTO_LINEAL.Recorrido ON (tram_id=reco_primertramo) WHERE reco_id=@recorrido_id AND reco_primertramo=@id_primertramo");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@recorrido_id", recorrido_modif.id);
            cmd.Parameters.AddWithValue("@id_primertramo", recorrido_modif.primerTramo.id);
            SqlDataReader reader = cmd.ExecuteReader();            
            while (reader.Read())
            {
                int id = int.Parse(reader["tram_id"].ToString());
                decimal precio = decimal.Parse(reader["tram_precio"].ToString());
                decimal duracion = decimal.Parse(reader["tram_duracion"].ToString());
                int origen = int.Parse(reader["tram_origen"].ToString());
                int destino = int.Parse(reader["tram_destino"].ToString());

                Puerto puerto_origen = obtener_puerto_con_ID(origen);
                Puerto puerto_destino = obtener_puerto_con_ID(destino);

                Tramo tramo = new Tramo(id, precio, duracion, puerto_origen, puerto_destino);
                tramos.Add(tramo);
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return tramos;
        }

        public static List<Tramo> obtener_todos_tramos()
        {
            List<Tramo> tramos = new List<Tramo>();
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.Tramo");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["tram_id"].ToString());
                decimal precio = decimal.Parse(reader["tram_precio"].ToString());
                decimal duracion = decimal.Parse(reader["tram_duracion"].ToString());
                int origen = int.Parse(reader["tram_origen"].ToString());
                int destino = int.Parse(reader["tram_destino"].ToString());

                Puerto puerto_origen = obtener_puerto_con_ID(origen);
                Puerto puerto_destino = obtener_puerto_con_ID(destino);

                Tramo tramo = new Tramo(id, precio, duracion, puerto_origen, puerto_destino);
                tramos.Add(tramo);
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return tramos;
        }
        
    }
}
