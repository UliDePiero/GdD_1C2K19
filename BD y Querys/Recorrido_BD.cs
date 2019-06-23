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
            string query = string.Format(@"select r1.reco_id as RECORRIDO, r1.reco_codigo as CODIGO, p1.puer_nombre as ORIGEN, p2.puer_nombre as ULTIMO_DESTINO, r1.reco_habilitado as HABILITADO
                                            from PENSAMIENTO_LINEAL.Recorrido as r1
	                                        join PENSAMIENTO_LINEAL.Recorrido_tramo as rt on (r1.reco_id = rt.reco_tram_recoid)
	                                        join PENSAMIENTO_LINEAL.Tramo as t1 on (r1.reco_primertramo = t1.tram_id)
	                                        join PENSAMIENTO_LINEAL.Tramo as t2 on (rt.reco_tram_tramid = t2.tram_id)
	                                        join PENSAMIENTO_LINEAL.Puerto as p1 on (t1.tram_origen = p1.puer_id)
	                                        join PENSAMIENTO_LINEAL.Puerto as p2 on (t2.tram_destino = p2.puer_id)
                                            where t2.tram_destino NOT IN (
							                                                select t3.tram_origen
							                                                from PENSAMIENTO_LINEAL.Recorrido as r2
							  	                                            join PENSAMIENTO_LINEAL.Recorrido_tramo as rt2 on (r2.reco_id = rt2.reco_tram_recoid)
							  	                                            join PENSAMIENTO_LINEAL.Tramo as t3 on (rt2.reco_tram_tramid = t3.tram_id)
							                                                where r1.reco_id = r2.reco_id
							                                                )
                                            order by r1.reco_id");
            DBConnection.llenar_grilla(grillaRecorridos, query);
        }

        public static void cargar_grilla_tramos(DataGridView grillaTramos)
        {
            string query = string.Format(@"SELECT tram_id as ID, tram_precio as Precio, tram_duracion as Duracion, p1.puer_nombre as Puerto_Origen, p2.puer_nombre as Puerto_Destino
                                           FROM PENSAMIENTO_LINEAL.Tramo JOIN PENSAMIENTO_LINEAL.Puerto p1 ON(p1.puer_id=tram_origen) JOIN PENSAMIENTO_LINEAL.Puerto p2 ON(p2.puer_id=tram_destino)");
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
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.Tramo JOIN PENSAMIENTO_LINEAL.Recorrido ON (tram_id=reco_primertramo) WHERE reco_id=@recorrido_id AND reco_primertramo!=@id_primertramo");
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

        public static List<Tramo> obtener_tramos_recorrido(Recorrido recorrido_modif)
        {
            List<Tramo> tramos = new List<Tramo>();
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.Tramo JOIN PENSAMIENTO_LINEAL.Recorrido_tramo ON (tram_id=reco_tram_tramid) WHERE reco_tram_recoid=@recorrido_id");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@recorrido_id", recorrido_modif.id);
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


        public static bool validar_codigo(string codigo)
        {
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.Recorrido WHERE reco_codigo=@codigo");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            bool rta = cmd.ExecuteScalar() == null;
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return rta;
        }

        public static bool agregar_recorrido(Recorrido recorrido_nuevo, int primerTramo)
        {
            try
            {
                string query = string.Format(@"INSERT INTO PENSAMIENTO_LINEAL.Recorrido(reco_codigo, reco_primertramo, reco_habilitado) VALUES (@reco_codigo, @reco_primertramo, 1); SELECT SCOPE_IDENTITY()");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@reco_codigo", recorrido_nuevo.codigo);
                cmd.Parameters.AddWithValue("@reco_primertramo", primerTramo);

                int recorrido_cod_generado = Convert.ToInt32(cmd.ExecuteScalar());
                foreach (Tramo tra in recorrido_nuevo.tramos)
                {
                    cmd = new SqlCommand("INSERT INTO PENSAMIENTO_LINEAL.Recorrido_tramo (reco_tram_recoid, reco_tram_tramid) VALUES (@reco_tram_recoid, @reco_tram_tramid)", conn);

                    cmd.Parameters.AddWithValue("@reco_tram_recoid", recorrido_cod_generado);
                    cmd.Parameters.AddWithValue("@reco_tram_tramid", tra.id);
                    cmd.ExecuteNonQuery();
                }
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar recorrido.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool modificar_recorrido(Recorrido recorrido_nuevo, int primerTramo, List<Tramo> tramos_anteriores)
        {
           try
            {
                List<Tramo> tramos_nuevos = recorrido_nuevo.tramos.Where(tra_a => !tramos_anteriores.Any(tra_b => tra_a.id == tra_b.id)).ToList();
                List<Tramo> tramos_quitados = tramos_anteriores.Where(tra_b => !recorrido_nuevo.tramos.Any(tra_a => tra_b.id == tra_a.id)).ToList();
                string query = string.Format(@"UPDATE PENSAMIENTO_LINEAL.Recorrido SET reco_codigo=@reco_codigo,reco_primertramo=@reco_primertramo WHERE reco_id=@reco_id");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@reco_codigo", recorrido_nuevo.codigo);
                cmd.Parameters.AddWithValue("@reco_primertramo", primerTramo);
                cmd.Parameters.AddWithValue("@reco_id", recorrido_nuevo.id);

                cmd.ExecuteNonQuery();                
                foreach (Tramo tra in tramos_nuevos)
                {
                    cmd = new SqlCommand("INSERT INTO PENSAMIENTO_LINEAL.Recorrido_tramo (reco_tram_recoid, reco_tram_tramid) VALUES (@reco_tram_recoid, @reco_tram_tramid)", conn);
                    cmd.Parameters.AddWithValue("@reco_tram_recoid", recorrido_nuevo.id);
                    cmd.Parameters.AddWithValue("@reco_tram_tramid", tra.id);
                    
                    cmd.ExecuteNonQuery();
                }                
                foreach (Tramo tra in tramos_quitados)
                {
                    cmd = new SqlCommand("DELETE FROM PENSAMIENTO_LINEAL.Recorrido_tramo WHERE reco_tram_recoid=@reco_tram_recoid AND reco_tram_tramid=@reco_tram_tramid", conn);
                    cmd.Parameters.AddWithValue("@reco_tram_recoid", recorrido_nuevo.id);
                    cmd.Parameters.AddWithValue("@reco_tram_tramid", tra.id);

                    cmd.ExecuteNonQuery();
                }

                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al modificar recorrido.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static void agregar_tramo(Tramo tramo)
        {
            try
            {
                string query = string.Format(@"INSERT INTO PENSAMIENTO_LINEAL.Tramo(tram_precio, tram_duracion, tram_origen, tram_destino) VALUES (@tram_precio, @tram_duracion, @tram_origen, @tram_destino)");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tram_precio", tramo.precio);
                cmd.Parameters.AddWithValue("@tram_duracion", tramo.duracion);
                cmd.Parameters.AddWithValue("@tram_origen", tramo.origen.id);
                cmd.Parameters.AddWithValue("@tram_destino", tramo.destino.id);

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar tramo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        public static void modificar_tramo(Tramo tramo)
        {
            try
            {
                string query = string.Format(@"UPDATE PENSAMIENTO_LINEAL.Tramo SET tram_precio=@tram_precio, tram_duracion=@tram_duracion, tram_origen=@tram_origen, tram_destino=@tram_destino WHERE tram_id=@tram_id");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tram_id", tramo.id);
                cmd.Parameters.AddWithValue("@tram_precio", tramo.precio);
                cmd.Parameters.AddWithValue("@tram_duracion", tramo.duracion);
                cmd.Parameters.AddWithValue("@tram_origen", tramo.origen.id);
                cmd.Parameters.AddWithValue("@tram_destino", tramo.destino.id);

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al modificar tramo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        public static void cargar_grilla_tramos(DataGridView grillaTramos, int id)
        {
            string query = string.Format(@"SELECT tram_id as ID, tram_precio as Precio, tram_duracion as Duracion, p1.puer_nombre as Puerto_Origen, p2.puer_nombre as Puerto_Destino
                                           FROM PENSAMIENTO_LINEAL.Tramo JOIN PENSAMIENTO_LINEAL.Puerto p1 ON(p1.puer_id=tram_origen) JOIN PENSAMIENTO_LINEAL.Puerto p2 ON(p2.puer_id=tram_destino) WHERE p1.puer_id="+id.ToString());
            DBConnection.llenar_grilla(grillaTramos, query);
        }

        public static bool tiene_pasajes_vendidos(Recorrido recorrido_modif)
        {
            string query = string.Format(@"select * from recorrido_crucero join pasaje on pasa_viaje = reco_cruc_id where reco_cruc_recoid = @reco_id and reco_cruc_salida >= '@fecha'");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@reco_id", recorrido_modif.id);
            cmd.Parameters.AddWithValue("@fecha", DateTime.Parse(ConfigurationManager.AppSettings["fecha"].ToString()));
            bool rta = cmd.ExecuteScalar() != null;
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return rta;
        }

        public static void inhabilitar_recorrido(Recorrido recorrido)
        {
            string query = string.Format(@"UPDATE PENSAMIENTO_LINEAL.Recorrido SET reco_habilitado=0 WHERE reco_id=@reco_id");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@reco_id", recorrido.id);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
            conn.Dispose();
        }

        public static void habilitar_recorrido(Recorrido recorrido)
        {
            string query = string.Format(@"UPDATE PENSAMIENTO_LINEAL.Recorrido SET reco_habilitado=1 WHERE reco_id=@reco_id");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@reco_id", recorrido.id);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
            conn.Dispose();
        }

        public static void cargar_grilla_recorridos_origen(DataGridView grillaRecorridos, string puerto)
        {
            string query = string.Format(@"select r1.reco_id as RECORRIDO, r1.reco_codigo as CODIGO, p1.puer_nombre as ORIGEN, p2.puer_nombre as ULTIMO_DESTINO, r1.reco_habilitado as HABILITADO
                                            from PENSAMIENTO_LINEAL.Recorrido as r1
	                                        join PENSAMIENTO_LINEAL.Recorrido_tramo as rt on (r1.reco_id = rt.reco_tram_recoid)
	                                        join PENSAMIENTO_LINEAL.Tramo as t1 on (r1.reco_primertramo = t1.tram_id)
	                                        join PENSAMIENTO_LINEAL.Tramo as t2 on (rt.reco_tram_tramid = t2.tram_id)
	                                        join PENSAMIENTO_LINEAL.Puerto as p1 on (t1.tram_origen = p1.puer_id)
	                                        join PENSAMIENTO_LINEAL.Puerto as p2 on (t2.tram_destino = p2.puer_id)
                                            where t2.tram_destino NOT IN (
							                                                select t3.tram_origen
							                                                from PENSAMIENTO_LINEAL.Recorrido as r2
							  	                                            join PENSAMIENTO_LINEAL.Recorrido_tramo as rt2 on (r2.reco_id = rt2.reco_tram_recoid)
							  	                                            join PENSAMIENTO_LINEAL.Tramo as t3 on (rt2.reco_tram_tramid = t3.tram_id)
							                                                where r1.reco_id = r2.reco_id
							                                                ) and p1.puer_nombre='" + puerto + "'" +
                                            "order by r1.reco_id");
            DBConnection.llenar_grilla(grillaRecorridos, query);
        }

        public static void cargar_grilla_recorridos_destino(DataGridView grillaRecorridos, string puerto)
        {
            string query = string.Format(@"select r1.reco_id as RECORRIDO, r1.reco_codigo as CODIGO, p1.puer_nombre as ORIGEN, p2.puer_nombre as ULTIMO_DESTINO, r1.reco_habilitado as HABILITADO
                                            from PENSAMIENTO_LINEAL.Recorrido as r1
	                                        join PENSAMIENTO_LINEAL.Recorrido_tramo as rt on (r1.reco_id = rt.reco_tram_recoid)
	                                        join PENSAMIENTO_LINEAL.Tramo as t1 on (r1.reco_primertramo = t1.tram_id)
	                                        join PENSAMIENTO_LINEAL.Tramo as t2 on (rt.reco_tram_tramid = t2.tram_id)
	                                        join PENSAMIENTO_LINEAL.Puerto as p1 on (t1.tram_origen = p1.puer_id)
	                                        join PENSAMIENTO_LINEAL.Puerto as p2 on (t2.tram_destino = p2.puer_id)
                                            where t2.tram_destino NOT IN (
							                                                select t3.tram_origen
							                                                from PENSAMIENTO_LINEAL.Recorrido as r2
							  	                                            join PENSAMIENTO_LINEAL.Recorrido_tramo as rt2 on (r2.reco_id = rt2.reco_tram_recoid)
							  	                                            join PENSAMIENTO_LINEAL.Tramo as t3 on (rt2.reco_tram_tramid = t3.tram_id)
							                                                where r1.reco_id = r2.reco_id
							                                                ) and p2.puer_nombre='" + puerto + "'" +
                                            "order by r1.reco_id");
            DBConnection.llenar_grilla(grillaRecorridos, query);
        }

        public static void cargar_grilla_recorridos(DataGridView grillaRecorridos, string puerto_origen, string puerto_destino)
        {
            string query = string.Format(@"select r1.reco_id as RECORRIDO, r1.reco_codigo as CODIGO, p1.puer_nombre as ORIGEN, p2.puer_nombre as ULTIMO_DESTINO, r1.reco_habilitado as HABILITADO
                                            from PENSAMIENTO_LINEAL.Recorrido as r1
	                                        join PENSAMIENTO_LINEAL.Recorrido_tramo as rt on (r1.reco_id = rt.reco_tram_recoid)
	                                        join PENSAMIENTO_LINEAL.Tramo as t1 on (r1.reco_primertramo = t1.tram_id)
	                                        join PENSAMIENTO_LINEAL.Tramo as t2 on (rt.reco_tram_tramid = t2.tram_id)
	                                        join PENSAMIENTO_LINEAL.Puerto as p1 on (t1.tram_origen = p1.puer_id)
	                                        join PENSAMIENTO_LINEAL.Puerto as p2 on (t2.tram_destino = p2.puer_id)
                                            where t2.tram_destino NOT IN (
							                                                select t3.tram_origen
							                                                from PENSAMIENTO_LINEAL.Recorrido as r2
							  	                                            join PENSAMIENTO_LINEAL.Recorrido_tramo as rt2 on (r2.reco_id = rt2.reco_tram_recoid)
							  	                                            join PENSAMIENTO_LINEAL.Tramo as t3 on (rt2.reco_tram_tramid = t3.tram_id)
							                                                where r1.reco_id = r2.reco_id
							                                                ) and p1.puer_nombre='" + puerto_origen + "' AND p2.puer_nombre='" + puerto_destino + "'" +
                                            "order by r1.reco_id");
            DBConnection.llenar_grilla(grillaRecorridos, query);
        }

        public static void cargar_grilla_recorridos(DataGridView grillaRecorridos, bool _mostrar)
        {
            int mostrar;
            if (_mostrar)
                mostrar = 1;
            else
                mostrar = 0;
            string query = string.Format(@"select r1.reco_id as RECORRIDO, r1.reco_codigo as CODIGO, p1.puer_nombre as ORIGEN, p2.puer_nombre as ULTIMO_DESTINO, r1.reco_habilitado as HABILITADO
                                            from PENSAMIENTO_LINEAL.Recorrido as r1
	                                        join PENSAMIENTO_LINEAL.Recorrido_tramo as rt on (r1.reco_id = rt.reco_tram_recoid)
	                                        join PENSAMIENTO_LINEAL.Tramo as t1 on (r1.reco_primertramo = t1.tram_id)
	                                        join PENSAMIENTO_LINEAL.Tramo as t2 on (rt.reco_tram_tramid = t2.tram_id)
	                                        join PENSAMIENTO_LINEAL.Puerto as p1 on (t1.tram_origen = p1.puer_id)
	                                        join PENSAMIENTO_LINEAL.Puerto as p2 on (t2.tram_destino = p2.puer_id)
                                            where t2.tram_destino NOT IN (
							                                                select t3.tram_origen
							                                                from PENSAMIENTO_LINEAL.Recorrido as r2
							  	                                            join PENSAMIENTO_LINEAL.Recorrido_tramo as rt2 on (r2.reco_id = rt2.reco_tram_recoid)
							  	                                            join PENSAMIENTO_LINEAL.Tramo as t3 on (rt2.reco_tram_tramid = t3.tram_id)
							                                                where r1.reco_id = r2.reco_id
							                                                ) and reco_habilitado = " + mostrar +
                                            "order by r1.reco_id");
            DBConnection.llenar_grilla(grillaRecorridos, query);
        }


        public static void cargar_grilla_recorridos_origen(DataGridView grillaRecorridos, string puerto, bool _mostrar)
        {
            int mostrar;
            if (_mostrar)
                mostrar = 1;
            else
                mostrar = 0;
            string query = string.Format(@"select r1.reco_id as RECORRIDO, r1.reco_codigo as CODIGO, p1.puer_nombre as ORIGEN, p2.puer_nombre as ULTIMO_DESTINO, r1.reco_habilitado as HABILITADO
                                            from PENSAMIENTO_LINEAL.Recorrido as r1
	                                        join PENSAMIENTO_LINEAL.Recorrido_tramo as rt on (r1.reco_id = rt.reco_tram_recoid)
	                                        join PENSAMIENTO_LINEAL.Tramo as t1 on (r1.reco_primertramo = t1.tram_id)
	                                        join PENSAMIENTO_LINEAL.Tramo as t2 on (rt.reco_tram_tramid = t2.tram_id)
	                                        join PENSAMIENTO_LINEAL.Puerto as p1 on (t1.tram_origen = p1.puer_id)
	                                        join PENSAMIENTO_LINEAL.Puerto as p2 on (t2.tram_destino = p2.puer_id)
                                            where t2.tram_destino NOT IN (
							                                                select t3.tram_origen
							                                                from PENSAMIENTO_LINEAL.Recorrido as r2
							  	                                            join PENSAMIENTO_LINEAL.Recorrido_tramo as rt2 on (r2.reco_id = rt2.reco_tram_recoid)
							  	                                            join PENSAMIENTO_LINEAL.Tramo as t3 on (rt2.reco_tram_tramid = t3.tram_id)
							                                                where r1.reco_id = r2.reco_id
							                                                ) and p1.puer_nombre='" + puerto + "'" + "AND reco_habilitado = " + mostrar +
                                            "order by r1.reco_id");
            DBConnection.llenar_grilla(grillaRecorridos, query);
        }

        public static void cargar_grilla_recorridos_destino(DataGridView grillaRecorridos, string puerto, bool _mostrar)
        {
            int mostrar;
            if (_mostrar)
                mostrar = 1;
            else
                mostrar = 0;
            string query = string.Format(@"select r1.reco_id as RECORRIDO, r1.reco_codigo as CODIGO, p1.puer_nombre as ORIGEN, p2.puer_nombre as ULTIMO_DESTINO, r1.reco_habilitado as HABILITADO
                                            from PENSAMIENTO_LINEAL.Recorrido as r1
	                                        join PENSAMIENTO_LINEAL.Recorrido_tramo as rt on (r1.reco_id = rt.reco_tram_recoid)
	                                        join PENSAMIENTO_LINEAL.Tramo as t1 on (r1.reco_primertramo = t1.tram_id)
	                                        join PENSAMIENTO_LINEAL.Tramo as t2 on (rt.reco_tram_tramid = t2.tram_id)
	                                        join PENSAMIENTO_LINEAL.Puerto as p1 on (t1.tram_origen = p1.puer_id)
	                                        join PENSAMIENTO_LINEAL.Puerto as p2 on (t2.tram_destino = p2.puer_id)
                                            where t2.tram_destino NOT IN (
							                                                select t3.tram_origen
							                                                from PENSAMIENTO_LINEAL.Recorrido as r2
							  	                                            join PENSAMIENTO_LINEAL.Recorrido_tramo as rt2 on (r2.reco_id = rt2.reco_tram_recoid)
							  	                                            join PENSAMIENTO_LINEAL.Tramo as t3 on (rt2.reco_tram_tramid = t3.tram_id)
							                                                where r1.reco_id = r2.reco_id
							                                                ) and p2.puer_nombre='" + puerto + "'" + "AND reco_habilitado = " + mostrar +
                                            "order by r1.reco_id");
            DBConnection.llenar_grilla(grillaRecorridos, query);
        }

        public static void cargar_grilla_recorridos(DataGridView grillaRecorridos, string puerto_origen, string puerto_destino, bool _mostrar)
        {
            int mostrar;
            if (_mostrar)
                mostrar = 1;
            else
                mostrar = 0;
            string query = string.Format(@"select r1.reco_id as RECORRIDO, r1.reco_codigo as CODIGO, p1.puer_nombre as ORIGEN, p2.puer_nombre as ULTIMO_DESTINO, r1.reco_habilitado as HABILITADO
                                            from PENSAMIENTO_LINEAL.Recorrido as r1
	                                        join PENSAMIENTO_LINEAL.Recorrido_tramo as rt on (r1.reco_id = rt.reco_tram_recoid)
	                                        join PENSAMIENTO_LINEAL.Tramo as t1 on (r1.reco_primertramo = t1.tram_id)
	                                        join PENSAMIENTO_LINEAL.Tramo as t2 on (rt.reco_tram_tramid = t2.tram_id)
	                                        join PENSAMIENTO_LINEAL.Puerto as p1 on (t1.tram_origen = p1.puer_id)
	                                        join PENSAMIENTO_LINEAL.Puerto as p2 on (t2.tram_destino = p2.puer_id)
                                            where t2.tram_destino NOT IN (
							                                                select t3.tram_origen
							                                                from PENSAMIENTO_LINEAL.Recorrido as r2
							  	                                            join PENSAMIENTO_LINEAL.Recorrido_tramo as rt2 on (r2.reco_id = rt2.reco_tram_recoid)
							  	                                            join PENSAMIENTO_LINEAL.Tramo as t3 on (rt2.reco_tram_tramid = t3.tram_id)
							                                                where r1.reco_id = r2.reco_id
							                                                ) and p1.puer_nombre='" + puerto_origen + "' AND p2.puer_nombre='" + puerto_destino + "'" + "AND reco_habilitado = " + mostrar +
                                            "order by r1.reco_id");
            DBConnection.llenar_grilla(grillaRecorridos, query);
        }

    }
}
