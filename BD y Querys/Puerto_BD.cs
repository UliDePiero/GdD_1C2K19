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
            string query = string.Format(@"SELECT puer_id as ID, puer_nombre as Puerto
                                           FROM PENSAMIENTO_LINEAL.Puerto
                                           ORDER BY 2 ASC");
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

        public static void cargar_grilla_puertos_recorridos(DataGridView grillaPuertos)
        {
            string query = string.Format(@"SELECT DISTINCT(puer_id) as ID, puer_nombre as Puerto
                                           FROM PENSAMIENTO_LINEAL.Puerto 
										   JOIN PENSAMIENTO_LINEAL.Tramo t1 ON(puer_id=t1.tram_origen)
										   JOIN PENSAMIENTO_LINEAL.Tramo t2 ON(puer_id=t2.tram_destino)
										   JOIN PENSAMIENTO_LINEAL.Recorrido_tramo ON(t1.tram_id=reco_tram_tramid OR t2.tram_id=reco_tram_tramid)
                                           ORDER BY 2 ASC");
            DBConnection.llenar_grilla(grillaPuertos, query);
        }

        public static void cargar_grilla_puertos_viajes(DataGridView grillaPuertos)
        {
            string query = string.Format(@"SELECT DISTINCT(puer_id) as ID, puer_nombre as Puerto
                                           FROM PENSAMIENTO_LINEAL.Puerto 
										   JOIN PENSAMIENTO_LINEAL.Tramo t1 ON(puer_id=t1.tram_origen)
										   JOIN PENSAMIENTO_LINEAL.Tramo t2 ON(puer_id=t2.tram_destino)
										   JOIN PENSAMIENTO_LINEAL.Recorrido_tramo ON(t1.tram_id=reco_tram_tramid OR t2.tram_id=reco_tram_tramid)
										   JOIN PENSAMIENTO_LINEAL.Recorrido_crucero ON(reco_cruc_recoid=reco_tram_recoid)
                                           ORDER BY 2 ASC");
            DBConnection.llenar_grilla(grillaPuertos, query);
        }

        public static void cargar_grilla_puertos_pasajes(DataGridView grillaPuertos) //TARDA MUCHO //TARDA MUCHO //TARDA MUCHO 
        {
            string query = string.Format(@"SELECT DISTINCT(puer_id) as ID, puer_nombre as Puerto
                                           FROM PENSAMIENTO_LINEAL.Puerto 
										   JOIN PENSAMIENTO_LINEAL.Tramo t1 ON(puer_id=t1.tram_origen)
										   JOIN PENSAMIENTO_LINEAL.Tramo t2 ON(puer_id=t2.tram_destino)
										   JOIN PENSAMIENTO_LINEAL.Recorrido_tramo ON(t1.tram_id=reco_tram_tramid OR t2.tram_id=reco_tram_tramid)
										   JOIN PENSAMIENTO_LINEAL.Recorrido_crucero ON(reco_cruc_recoid=reco_tram_recoid)
										   JOIN PENSAMIENTO_LINEAL.Pasaje ON(pasa_viaje=reco_cruc_id)
                                           ORDER BY 2 ASC");
            DBConnection.llenar_grilla(grillaPuertos, query);
        }

        public static void cargar_grilla_puertos_no_recorridos(DataGridView grillaPuertos)
        {
            string query = string.Format(@"SELECT DISTINCT(puer_id) as ID, puer_nombre as Puerto
                                           FROM PENSAMIENTO_LINEAL.Puerto
										   WHERE puer_id NOT IN (SELECT puer_id
																FROM PENSAMIENTO_LINEAL.Puerto 
																JOIN PENSAMIENTO_LINEAL.Tramo t1 ON(puer_id=t1.tram_origen)
																JOIN PENSAMIENTO_LINEAL.Tramo t2 ON(puer_id=t2.tram_destino)
																JOIN PENSAMIENTO_LINEAL.Recorrido_tramo ON(t1.tram_id=reco_tram_tramid OR t2.tram_id=reco_tram_tramid))
                                           ORDER BY 2 ASC");
            DBConnection.llenar_grilla(grillaPuertos, query);
        }

        public static void cargar_grilla_puertos_no_viajes(DataGridView grillaPuertos)
        {
            string query = string.Format(@"SELECT DISTINCT(puer_id) as ID, puer_nombre as Puerto
                                           FROM PENSAMIENTO_LINEAL.Puerto
										   WHERE puer_id NOT IN (SELECT puer_id
                                                                FROM PENSAMIENTO_LINEAL.Puerto 
										                        JOIN PENSAMIENTO_LINEAL.Tramo t1 ON(puer_id=t1.tram_origen)
										                        JOIN PENSAMIENTO_LINEAL.Tramo t2 ON(puer_id=t2.tram_destino)
										                        JOIN PENSAMIENTO_LINEAL.Recorrido_tramo ON(t1.tram_id=reco_tram_tramid OR t2.tram_id=reco_tram_tramid)
										                        JOIN PENSAMIENTO_LINEAL.Recorrido_crucero ON(reco_cruc_recoid=reco_tram_recoid))
                                           ORDER BY 2 ASC");
            DBConnection.llenar_grilla(grillaPuertos, query);
        }

        public static void cargar_grilla_puertos_no_pasajes(DataGridView grillaPuertos) //TARDA MUCHO //TARDA MUCHO //TARDA MUCHO 
        {
            string query = string.Format(@"SELECT DISTINCT(puer_id) as ID, puer_nombre as Puerto
                                           FROM PENSAMIENTO_LINEAL.Puerto
										   WHERE puer_id NOT IN (SELECT puer_id
                                                                FROM PENSAMIENTO_LINEAL.Puerto 
										                        JOIN PENSAMIENTO_LINEAL.Tramo t1 ON(puer_id=t1.tram_origen)
										                        JOIN PENSAMIENTO_LINEAL.Tramo t2 ON(puer_id=t2.tram_destino)
										                        JOIN PENSAMIENTO_LINEAL.Recorrido_tramo ON(t1.tram_id=reco_tram_tramid OR t2.tram_id=reco_tram_tramid)
										                        JOIN PENSAMIENTO_LINEAL.Recorrido_crucero ON(reco_cruc_recoid=reco_tram_recoid)
										                        JOIN PENSAMIENTO_LINEAL.Pasaje ON(pasa_viaje=reco_cruc_id))
                                           ORDER BY 2 ASC");
            DBConnection.llenar_grilla(grillaPuertos, query);
        }

        public static bool nuevo_puerto(string puerto)
        {
            try
            {
                string query = string.Format(@"INSERT INTO PENSAMIENTO_LINEAL.Puerto(puer_nombre) VALUES (@puer_nombre)");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@puer_nombre", puerto);

                cmd.ExecuteNonQuery();
                
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar puerto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool modificar_puerto(string nombre, Puerto puerto)
        {
            try
            {
                string query = string.Format(@"UPDATE INTO PENSAMIENTO_LINEAL.Puerto SET puer_nombre=@puer_nombre WHERE puer_id=@puer_id");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@puer_id", puerto.id);
                cmd.Parameters.AddWithValue("@puer_nombre", nombre);

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al modificar puerto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool eliminar_puerto(Puerto puerto)
        {
            try
            {
                string query = string.Format(@"EXECUTE PENSAMIENTO_LINEAL.chasquearDedos @puerto = @puer_id");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@puer_id", puerto.id);                

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar puerto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

    }
}
