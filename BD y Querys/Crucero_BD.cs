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
    public static class Crucero_BD
    {
        public static void cargar_grilla_cruceros(DataGridView grillaCruceros)
        {
            string query = string.Format(@"select cruc_id as ID, cruc_identificador as IDENTIFICADOR, marc_nombre as MARCA, mode_nombre as MODELO, cruc_bajadef as BAJA_DEFINITIVA, esta_fechabaja as FECHA_BAJA_SERVICIO, esta_fechaalta as FECHA_ALTA_SERVICIO, count(cabi_id) as CABINAS
                                            from PENSAMIENTO_LINEAL.Crucero 
	                                            join PENSAMIENTO_LINEAL.Marca on (cruc_marca = marc_id) 
	                                            join PENSAMIENTO_LINEAL.Modelo on (cruc_modelo = mode_id)
	                                            left join PENSAMIENTO_LINEAL.Estado_crucero on (cruc_id = esta_crucero)
	                                            join PENSAMIENTO_LINEAL.Cabina on (cruc_id = cabi_crucero)
                                            group by cruc_id, cruc_identificador, marc_nombre, mode_nombre, cruc_bajadef, esta_fechabaja, esta_fechaalta");
            DBConnection.llenar_grilla(grillaCruceros, query);
        }

        public static Crucero obtener_crucero_con_ID(int id)
        {
            string query = string.Format(@"SELECT cruc_id, cruc_identificador, cruc_marca, cruc_modelo, count(cabi_id) as CABINAS 
                                            FROM PENSAMIENTO_LINEAL.Crucero join PENSAMIENTO_LINEAL.Cabina on (cruc_id = cabi_crucero) 
                                            WHERE cruc_id=@id 
                                            GROUP BY cruc_id, cruc_identificador, cruc_marca, cruc_modelo");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string identificador = reader["cruc_identificador"].ToString();
            int marca = int.Parse(reader["cruc_marca"].ToString());
            int modelo = int.Parse(reader["cruc_modelo"].ToString());
            int cabinas = int.Parse(reader["CABINAS"].ToString());

            Crucero crucero = new Crucero(id, identificador, obtener_marca_con_ID(marca), obtener_modelo_con_ID(modelo), cabinas);

            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return crucero;
        }

        public static MarcaCrucero obtener_marca_con_ID(int id)
        {
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.Marca WHERE marc_id=@id");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string nombre = reader["marc_nombre"].ToString();            

            MarcaCrucero marca = new MarcaCrucero(id, nombre);

            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return marca;
        }

        public static MarcaCrucero obtener_marca_con_nombre(string nombre)
        {
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.Marca WHERE marc_nombre=@nombre");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id = int.Parse(reader["marc_id"].ToString());

            MarcaCrucero marca = new MarcaCrucero(id, nombre);

            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return marca;
        }

        public static ModeloCrucero obtener_modelo_con_ID(int id)
        {
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.Modelo WHERE mode_id=@id");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string nombre = reader["mode_nombre"].ToString();

            ModeloCrucero modelo = new ModeloCrucero(id, nombre);

            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return modelo;
        }

        public static ModeloCrucero obtener_modelo_con_nombre(string nombre)
        {
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.Modelo WHERE mode_nombre=@nombre");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id = int.Parse(reader["mode_id"].ToString());

            ModeloCrucero modelo = new ModeloCrucero(id, nombre);

            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return modelo;
        }

        public static TipoCabina obtener_tipoCabina_con_ID(int id)
        {
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.Tipo_cabina WHERE tipo_id=@id");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string nombre = reader["tipo_nombre"].ToString();
            double porcentaje = double.Parse(reader["tipo_porc_rec"].ToString());

            TipoCabina tipo = new TipoCabina(id, nombre, porcentaje);

            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return tipo;
        }

        public static List<Crucero> obtener_todos_cruceros()
        {
            List<Crucero> cruceros = new List<Crucero>();
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.Crucero");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["cruc_id"].ToString());
                string identificador = reader["cruc_identificador"].ToString();


                Crucero crucero = new Crucero(id, identificador);
                cruceros.Add(crucero);
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return cruceros;
        }

        public static List<MarcaCrucero> obtener_todos_marcas()
        {
            List<MarcaCrucero> marcas = new List<MarcaCrucero>();
            string query = string.Format(@"SELECT marc_id, marc_nombre FROM PENSAMIENTO_LINEAL.Marca");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["marc_id"].ToString());
                string nombre = reader["marc_nombre"].ToString();

                MarcaCrucero marca = new MarcaCrucero(id, nombre);
                marcas.Add(marca);
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return marcas;
        }

        public static List<ModeloCrucero> obtener_todos_modelos()
        {
            List<ModeloCrucero> modelos = new List<ModeloCrucero>();
            string query = string.Format(@"SELECT mode_id, mode_nombre FROM PENSAMIENTO_LINEAL.Modelo");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["mode_id"].ToString());
                string nombre = reader["mode_nombre"].ToString();

                ModeloCrucero mod = new ModeloCrucero(id, nombre);
                modelos.Add(mod);
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return modelos;
        }

        public static List<ServicioCrucero> obtener_todos_servicios()
        {
            List<ServicioCrucero> servicios = new List<ServicioCrucero>();
            string query = string.Format(@"SELECT serv_id, serv_desc FROM PENSAMIENTO_LINEAL.Servicio");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["serv_id"].ToString());
                string descripcion = reader["serv_desc"].ToString();

                ServicioCrucero serv = new ServicioCrucero(id, descripcion);
                servicios.Add(serv);
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return servicios;
        }

        public static List<EstadoCrucero> obtener_todos_estados()
        {
            List<EstadoCrucero> estados = new List<EstadoCrucero>();
            string query = string.Format(@"SELECT esta_id, esta_desc, esta_fechabaja, esta_fechaalta, esta_crucero FROM PENSAMIENTO_LINEAL.Estado_crucero");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["esta_id"].ToString());
                string descripcion = reader["esta_desc"].ToString();
                string fec_baja = reader["esta_fechabaja"].ToString();
                string fec_alta = reader["esta_fechaalta"].ToString();
                int id_crucero = int.Parse(reader["esta_crucero"].ToString());

                EstadoCrucero est = new EstadoCrucero(id, descripcion, DateTime.Parse(fec_baja), DateTime.Parse(fec_alta), obtener_crucero_con_ID(id_crucero));
                estados.Add(est);
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return estados;
        }



        public static List<TipoCabina> obtener_todas_tipoCabinas()
        {
            List<TipoCabina> cabinas = new List<TipoCabina>();
            string query = string.Format(@"SELECT tipo_id, tipo_nombre, tipo_porc_rec FROM PENSAMIENTO_LINEAL.Tipo_cabina");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["tipo_id"].ToString());
                string nombre = reader["tipo_nombre"].ToString();
                double porcentaje = double.Parse(reader["tipo_porc_rec"].ToString());

                TipoCabina cab = new TipoCabina(id, nombre, porcentaje);
                cabinas.Add(cab);
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return cabinas;
        }

        public static List<EstadoCrucero> obtener_estados_con_crucero(int cruc_id)
        {
            List<EstadoCrucero> estados = new List<EstadoCrucero>();
            string query = string.Format(@"SELECT esta_id, esta_desc, esta_fechabaja, esta_fechaalta, esta_crucero FROM PENSAMIENTO_LINEAL.Estado_crucero WHERE esta_crucero=@id");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", cruc_id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int esta_id = int.Parse(reader["esta_id"].ToString());
                string esta_desc = reader["esta_desc"].ToString();
                string esta_fechabaja = reader["esta_fechabaja"].ToString();
                string esta_fechaalta = reader["esta_fechaalta"].ToString();
                int esta_crucero = int.Parse(reader["esta_crucero"].ToString());

                EstadoCrucero est = new EstadoCrucero(esta_id, esta_desc, DateTime.Parse(esta_fechabaja), DateTime.Parse(esta_fechaalta), obtener_crucero_con_ID(esta_crucero));
                estados.Add(est);
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return estados;
        }

        public static List<ServicioCrucero> obtener_servicios_con_crucero(int cruc_id)
        {
            List<ServicioCrucero> servicios = new List<ServicioCrucero>();
            string query = string.Format(@"SELECT serv_id, serv_desc, cruc_serv_crucid FROM PENSAMIENTO_LINEAL.Servicio JOIN PENSAMIENTO_LINEAL.Crucero_Servicio ON (serv_id=cruc_serv_servid) WHERE cruc_serv_crucid=@id GROUP BY serv_id, serv_desc, cruc_serv_crucid");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", cruc_id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int serv_id = int.Parse(reader["serv_id"].ToString());
                string serv_desc = reader["serv_desc"].ToString();

                ServicioCrucero serv = new ServicioCrucero(serv_id, serv_desc);
                servicios.Add(serv);
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return servicios;
        }

        public static List<Cabina> obtener_Cabinas_con_crucero(int cruc_id)
        {
            List<Cabina> cabinas = new List<Cabina>();
            string query = string.Format(@"SELECT cabi_id, cabi_numero, cabi_piso, tipo_id, tipo_nombre, tipo_porc_rec
                                            FROM PENSAMIENTO_LINEAL.Cabina JOIN PENSAMIENTO_LINEAL.Tipo_cabina ON(cabi_tipo=tipo_id)
                                            WHERE cabi_crucero=@id");           
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", cruc_id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int cabi_id = int.Parse(reader["cabi_id"].ToString());
                int cabi_piso = int.Parse(reader["cabi_piso"].ToString());
                int cabi_numero = int.Parse(reader["cabi_numero"].ToString());                

                int tipo_id = int.Parse(reader["tipo_id"].ToString());
                string tipo_nombre = reader["tipo_nombre"].ToString();
                double tipo_porc_rec = double.Parse(reader["tipo_porc_rec"].ToString());

                TipoCabina tipo = new TipoCabina(tipo_id, tipo_nombre, tipo_porc_rec);
                Cabina Cab = new Cabina(cabi_id, cabi_piso, cabi_numero, tipo, obtener_crucero_con_ID(cruc_id));
                cabinas.Add(Cab);
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return cabinas;
        }


        public static bool existe_modelo(string mod)
        {
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.Modelo WHERE mode_nombre=@mode_nombre");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@mode_nombre", mod);
            bool rta = cmd.ExecuteScalar() != null;
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return rta;
        }

        public static bool agregar_modelo(string mod)
        {
            try
            {
                string query = string.Format(@"INSERT INTO PENSAMIENTO_LINEAL.Modelo(mode_nombre) VALUES (@mode_nombre)");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mode_nombre", mod);                

                cmd.ExecuteNonQuery();
                
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar modelo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static int agregar_crucero(Crucero crucero_nuevo)
        {
            try
            {
                string query = string.Format(@"INSERT INTO PENSAMIENTO_LINEAL.Crucero(cruc_identificador, cruc_marca, cruc_modelo) VALUES (@cruc_identificador, @cruc_marca, @cruc_modelo); SELECT SCOPE_IDENTITY()");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cruc_identificador", crucero_nuevo.identificador);
                cmd.Parameters.AddWithValue("@cruc_marca", crucero_nuevo.marca.id);
                cmd.Parameters.AddWithValue("@cruc_modelo", crucero_nuevo.modelo.id);

                int cruc_cod_generado = Convert.ToInt32(cmd.ExecuteScalar());
                
                foreach (ServicioCrucero serv in crucero_nuevo.servicios)
                {
                    cmd = new SqlCommand("INSERT INTO PENSAMIENTO_LINEAL.Crucero_Servicio (cruc_serv_crucid, cruc_serv_servid) VALUES (@cruc_serv_crucid, @cruc_serv_servid)", conn);

                    cmd.Parameters.AddWithValue("@cruc_serv_crucid", cruc_cod_generado);
                    cmd.Parameters.AddWithValue("@cruc_serv_servid", serv.id);

                    cmd.ExecuteNonQuery();
                }
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return cruc_cod_generado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar crucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }

        public static bool modificar_crucero(Crucero crucero_nuevo, List<ServicioCrucero> servicios_anteriores)
        {
           try
            {
                List<ServicioCrucero> servicios_nuevos = crucero_nuevo.servicios.Where(serv_a => !servicios_anteriores.Any(serv_b => serv_a.id == serv_b.id)).ToList();
                List<ServicioCrucero> servicios_quitados = servicios_anteriores.Where(serv_b => !crucero_nuevo.servicios.Any(serv_a => serv_b.id == serv_a.id)).ToList();
                string query = string.Format(@"UPDATE PENSAMIENTO_LINEAL.Crucero SET cruc_identificador=@cruc_identificador,cruc_marca=@cruc_marca,cruc_modelo=@cruc_modelo WHERE cruc_id=@cruc_id");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cruc_identificador", crucero_nuevo.identificador);
                cmd.Parameters.AddWithValue("@cruc_marca", crucero_nuevo.marca.id);
                cmd.Parameters.AddWithValue("@cruc_modelo", crucero_nuevo.modelo.id);
                cmd.Parameters.AddWithValue("@cruc_id", crucero_nuevo.id);

                cmd.ExecuteNonQuery();
                 
                foreach (ServicioCrucero serv in servicios_nuevos)
                {
                    cmd = new SqlCommand("INSERT INTO PENSAMIENTO_LINEAL.Crucero_Servicio (cruc_serv_crucid, cruc_serv_servid) VALUES (@cruc_serv_crucid, @cruc_serv_servid)", conn);
                    cmd.Parameters.AddWithValue("@cruc_serv_crucid", crucero_nuevo.id);
                    cmd.Parameters.AddWithValue("@cruc_serv_servid", serv.id);

                    cmd.ExecuteNonQuery();
                }
                foreach (ServicioCrucero serv in servicios_quitados)
                {
                    cmd = new SqlCommand("DELETE FROM PENSAMIENTO_LINEAL.Crucero_Servicio WHERE cruc_serv_crucid=@cruc_serv_crucid AND cruc_serv_servid=@cruc_serv_servid", conn);
                    cmd.Parameters.AddWithValue("@cruc_serv_crucid", crucero_nuevo.id);
                    cmd.Parameters.AddWithValue("@cruc_serv_servid", serv.id);

                    cmd.ExecuteNonQuery();
                }

                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al modificar crucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool reemplazar_crucero(Crucero cruc_modif)
        {
            try
            {
                string query = string.Format(@"EXECUTE PENSAMIENTO_LINEAL.PasarViajesCruceros @crucero = @crucero_id");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@crucero_id", cruc_modif.id);

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cambiar de crucero.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool postergar_viajes_crucero(Crucero cruc_modif, DateTime alta)
        {
            try
            {
                //CONVERT(datetime, '" + alta.ToString("yyyy-MM-dd HH:mm:ss") + "', 121)
                //CONVERT(smalldatetime, @alt, 121)
                string query = string.Format(@"EXECUTE PENSAMIENTO_LINEAL.RetrasarCrucero @crucero = @crucero_id, @Baja = @baj, @Alta = CONVERT(smalldatetime, @alt, 121)");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@crucero_id", cruc_modif.id);
                cmd.Parameters.AddWithValue("@alt", alta);
                cmd.Parameters.AddWithValue("@baj", DateTime.Parse(ConfigurationManager.AppSettings["fecha"].ToString()));

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al postergar viajes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static void cancelar_viajes(Crucero crucero, string descripcion)
        {
            string query = string.Format(@"SELECT usua_documento FROM PENSAMIENTO_LINEAL.Usuario WHERE usua_nombre=@nombre");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nombre", UsuarioLogeado.Username);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string documento = reader["usua_documento"].ToString();

            DateTime fecha = DateTime.Parse(ConfigurationManager.AppSettings["fecha"].ToString());
            List<string> codigos = new List<string>();
            query = string.Format(@"SELECT reco_cruc_id FROM PENSAMIENTO_LINEAL.Recorrido_crucero WHERE reco_cruc_crucid = @reco_cruc_crucid AND reco_cruc_salida > CONVERT(datetime, '" + fecha.ToString("yyyy-MM-dd HH:mm:ss") + "', 121)");
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@reco_cruc_crucid", crucero.id);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int viaje = int.Parse(reader["reco_cruc_id"].ToString());

                query = string.Format(@"SELECT rese_codigo FROM PENSAMIENTO_LINEAL.Reserva WHERE rese_viaje = @rese_viaje");
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@rese_viaje", viaje);
                SqlDataReader reader2 = cmd.ExecuteReader();
                while (reader2.Read())
                {
                    string codigo = reader["rese_codigo"].ToString();
                    codigos.Add(codigo);
                }
                query = string.Format(@"SELECT pasa_codigo FROM PENSAMIENTO_LINEAL.Pasaje WHERE pasa_viaje = @pasa_viaje");
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pasa_viaje", viaje);
                reader2 = cmd.ExecuteReader();
                while (reader2.Read())
                {
                    string codigo = reader["pasa_codigo"].ToString();
                    codigos.Add(codigo);
                }
                reader2.Close();
                reader2.Dispose();
            }

            foreach (string codigo in codigos)
            {
                query = string.Format(@"INSERT INTO PENSAMIENTO_LINEAL.Cancelaciones_log (canc_log_desc,canc_log_codigo,canc_log_usuario_nombre,canc_log_usuario_doc) VALUES (@canc_log_desc,@canc_log_codigo,@canc_log_usuario_nombre,@canc_log_usuario_doc)");
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@canc_log_desc", descripcion);
                cmd.Parameters.AddWithValue("@canc_log_usuario_nombre", UsuarioLogeado.Username);
                cmd.Parameters.AddWithValue("@canc_log_usuario_doc", documento);
                cmd.Parameters.AddWithValue("@canc_log_codigo", codigo);

                cmd.ExecuteNonQuery();
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
        }

        public static bool baja_definitiva(Crucero crucero, DateTime fecha_operacion)
        {
            try{
                string query = string.Format(@"UPDATE PENSAMIENTO_LINEAL.Crucero SET cruc_bajadef=CONVERT(smalldatetime,@cruc_bajadef,121) WHERE cruc_id=@cruc_id");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cruc_bajadef", fecha_operacion);
                cmd.Parameters.AddWithValue("@cruc_id", crucero.id);

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool baja_momentanea(Crucero crucero, DateTime fecha_operacion)
        {
            try
            {
                string query = string.Format(@"INSERT INTO PENSAMIENTO_LINEAL.Estado_crucero (esta_desc,esta_fechabaja,esta_fechaalta,esta_crucero) VALUES (@esta_desc,CONVERT(smalldatetime,@esta_fechabaja,121),CONVERT(smalldatetime,@esta_fechaalta,121),@esta_crucero)");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@esta_desc", "BAJA");
                cmd.Parameters.AddWithValue("@esta_fechabaja", DateTime.Parse(ConfigurationManager.AppSettings["fecha"].ToString()));
                cmd.Parameters.AddWithValue("@esta_fechaalta", fecha_operacion);
                cmd.Parameters.AddWithValue("@esta_crucero", crucero.id);

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en baja momentanea del crucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static TipoCabina obtener_tipoCabina_con_nombre(string nom)
        {
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.Tipo_cabina WHERE tipo_nombre=@nombre");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nombre", nom);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id = int.Parse(reader["tipo_id"].ToString());
            string nombre = reader["tipo_nombre"].ToString();
            double porcentaje = double.Parse(reader["tipo_porc_rec"].ToString());

            TipoCabina tipo = new TipoCabina(id, nombre, porcentaje);

            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return tipo;
        }

        public static int obtener_cantidad_de_cabinas_por_idTipo(int crucero_id, int tipo_id)
        {
            string query = string.Format(@"SELECT COUNT(*) as CANTIDAD FROM PENSAMIENTO_LINEAL.Cabina JOIN PENSAMIENTO_LINEAL.Tipo_cabina ON(tipo_id=cabi_tipo) WHERE cabi_crucero=@crucero_id AND cabi_tipo=@tipo_id");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@crucero_id", crucero_id);
            cmd.Parameters.AddWithValue("@tipo_id", tipo_id);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int cantidad = int.Parse(reader["CANTIDAD"].ToString());            

            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return cantidad;
        }

        public static Cabina obtener_cabina_por_tipo_ID(int crucero_id, int tipo_id)
        {
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.Cabina JOIN PENSAMIENTO_LINEAL.Tipo_cabina ON(cabi_tipo=tipo_id) WHERE cabi_crucero=@crucero_id AND cabi_tipo=@tipo_id");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@crucero_id", crucero_id);
            cmd.Parameters.AddWithValue("@tipo_id", tipo_id);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id = int.Parse(reader["cabi_id"].ToString());
            int piso = int.Parse(reader["cabi_piso"].ToString());
            int numero = int.Parse(reader["cabi_numero"].ToString());
            TipoCabina tipo = obtener_tipoCabina_con_ID(int.Parse(reader["cabi_tipo"].ToString()));
            Crucero crucero = obtener_crucero_con_ID(int.Parse(reader["cabi_crucero"].ToString()));;

            Cabina cabina = new Cabina(id, piso, numero, tipo, crucero);

            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return cabina;
        }

        public static bool validar_identificador(string identificador)
        {
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.Crucero WHERE cruc_identificador=@cruc_identificador");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cruc_identificador", identificador);
            bool rta = cmd.ExecuteScalar() == null;
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return rta;
        }

        public static void cargar_grilla_cabinas(DataGridView grillaCabinas, Crucero cruc_modificar)
        {
            string query = string.Format(@"SELECT cabi_id as ID, cabi_numero as NUMERO, cabi_piso as PISO, tipo_id as TIPO_ID, tipo_nombre as TIPO, tipo_porc_rec as PORCENTAJE
                                            FROM PENSAMIENTO_LINEAL.Cabina JOIN PENSAMIENTO_LINEAL.Tipo_cabina ON(cabi_tipo=tipo_id)
                                            WHERE cabi_crucero=" + cruc_modificar.id.ToString());
            
            DBConnection.llenar_grilla(grillaCabinas, query);
        }

        public static bool validar_numero_cabina(int Numero, int Piso, Crucero cruc_modificar)
        {
            List<Cabina> cabinas = obtener_Cabinas_con_crucero(cruc_modificar.id);
            foreach(Cabina c in cabinas){
                if (c.numero == Numero && c.piso == Piso)
                    return false;
            }
            return true;
        }

        public static bool insertar_cabina(Crucero cruc_modificar, int Numero, int Piso, TipoCabina tipoCabina)
        {
            try
            {
                string query = string.Format(@"INSERT INTO PENSAMIENTO_LINEAL.Cabina (cabi_piso,cabi_numero,cabi_crucero,cabi_tipo) VALUES (@cabi_piso,@cabi_numero,@cabi_crucero,@cabi_tipo)");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cabi_piso", Piso);
                cmd.Parameters.AddWithValue("@cabi_numero", Numero);
                cmd.Parameters.AddWithValue("@cabi_crucero", cruc_modificar.id);
                cmd.Parameters.AddWithValue("@cabi_tipo", tipoCabina.id);
                
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool sacar_cabina(Crucero cruc_modificar, Cabina cabina)
        {
            try
            {
                string query = string.Format(@"DELETE FROM PENSAMIENTO_LINEAL.Cabina WHERE cabi_crucero_id=@cabi_crucero_id AND cabi_id=@cabi_id");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cabi_crucero_id", cruc_modificar.id);
                cmd.Parameters.AddWithValue("@cabi_id", cabina.id);

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void cargar_grilla_cruceros_identificador(DataGridView grillaCruceros, string identificador)
        {
            string query = string.Format(@"select cruc_id as ID, cruc_identificador as IDENTIFICADOR, marc_nombre as MARCA, mode_nombre as MODELO, cruc_bajadef as BAJA_DEFINITIVA, esta_fechabaja as FECHA_BAJA_SERVICIO, esta_fechaalta as FECHA_ALTA_SERVICIO, count(cabi_id) as CABINAS
                                            from PENSAMIENTO_LINEAL.Crucero 
	                                            join PENSAMIENTO_LINEAL.Marca on (cruc_marca = marc_id) 
	                                            join PENSAMIENTO_LINEAL.Modelo on (cruc_modelo = mode_id)
	                                            left join PENSAMIENTO_LINEAL.Estado_crucero on (cruc_id = esta_crucero)
	                                            join PENSAMIENTO_LINEAL.Cabina on (cruc_id = cabi_crucero)
                                             where cruc_identificador = '" + identificador + "'" +
                                            "group by cruc_id, cruc_identificador, marc_nombre, mode_nombre, cruc_bajadef, esta_fechabaja, esta_fechaalta");
            DBConnection.llenar_grilla(grillaCruceros, query);
        }

        public static void cargar_grilla_cruceros_marca(DataGridView grillaCruceros, string marca)
        {
            string query = string.Format(@"select cruc_id as ID, cruc_identificador as IDENTIFICADOR, marc_nombre as MARCA, mode_nombre as MODELO, cruc_bajadef as BAJA_DEFINITIVA, esta_fechabaja as FECHA_BAJA_SERVICIO, esta_fechaalta as FECHA_ALTA_SERVICIO, count(cabi_id) as CABINAS
                                            from PENSAMIENTO_LINEAL.Crucero 
	                                            join PENSAMIENTO_LINEAL.Marca on (cruc_marca = marc_id) 
	                                            join PENSAMIENTO_LINEAL.Modelo on (cruc_modelo = mode_id)
	                                            left join PENSAMIENTO_LINEAL.Estado_crucero on (cruc_id = esta_crucero)
	                                            join PENSAMIENTO_LINEAL.Cabina on (cruc_id = cabi_crucero)
                                             where marc_nombre = '" + marca + "'" +
                                            "group by cruc_id, cruc_identificador, marc_nombre, mode_nombre, cruc_bajadef, esta_fechabaja, esta_fechaalta");
            DBConnection.llenar_grilla(grillaCruceros, query);
        }

        public static void cargar_grilla_cruceros(DataGridView grillaCruceros, string identificador, string marca)
        {
            string query = string.Format(@"select cruc_id as ID, cruc_identificador as IDENTIFICADOR, marc_nombre as MARCA, mode_nombre as MODELO, cruc_bajadef as BAJA_DEFINITIVA, esta_fechabaja as FECHA_BAJA_SERVICIO, esta_fechaalta as FECHA_ALTA_SERVICIO, count(cabi_id) as CABINAS
                                            from PENSAMIENTO_LINEAL.Crucero 
	                                            join PENSAMIENTO_LINEAL.Marca on (cruc_marca = marc_id) 
	                                            join PENSAMIENTO_LINEAL.Modelo on (cruc_modelo = mode_id)
	                                            left join PENSAMIENTO_LINEAL.Estado_crucero on (cruc_id = esta_crucero)
	                                            join PENSAMIENTO_LINEAL.Cabina on (cruc_id = cabi_crucero)
                                             where cruc_identificador = '" + identificador + "' AND marc_nombre = '" + marca + "'" +
                                            "group by cruc_id, cruc_identificador, marc_nombre, mode_nombre, cruc_bajadef, esta_fechabaja, esta_fechaalta");
            DBConnection.llenar_grilla(grillaCruceros, query);
        }


        public static void cargar_grilla_cruceros_con_alta(DataGridView grillaCruceros, DateTime alta)
        {
            string query = string.Format(@"select cruc_id as ID, cruc_identificador as IDENTIFICADOR, marc_nombre as MARCA, mode_nombre as MODELO, cruc_bajadef as BAJA_DEFINITIVA, esta_fechabaja as FECHA_BAJA_SERVICIO, esta_fechaalta as FECHA_ALTA_SERVICIO, count(cabi_id) as CABINAS
                                            from PENSAMIENTO_LINEAL.Crucero 
	                                            join PENSAMIENTO_LINEAL.Marca on (cruc_marca = marc_id) 
	                                            join PENSAMIENTO_LINEAL.Modelo on (cruc_modelo = mode_id)
	                                            left join PENSAMIENTO_LINEAL.Estado_crucero on (cruc_id = esta_crucero)
	                                            join PENSAMIENTO_LINEAL.Cabina on (cruc_id = cabi_crucero)
                                             where YEAR(esta_fechaalta) = YEAR('" + alta + "') AND MONTH(esta_fechaalta) = MONTH('" + alta + "') AND DAY(esta_fechaalta) = DAY('" + alta + "')" +
                                            "group by cruc_id, cruc_identificador, marc_nombre, mode_nombre, cruc_bajadef, esta_fechabaja, esta_fechaalta");
            DBConnection.llenar_grilla(grillaCruceros, query);
        }

        public static void cargar_grilla_cruceros_con_bajaM(DataGridView grillaCruceros, DateTime baja)
        {
            string query = string.Format(@"select cruc_id as ID, cruc_identificador as IDENTIFICADOR, marc_nombre as MARCA, mode_nombre as MODELO, cruc_bajadef as BAJA_DEFINITIVA, esta_fechabaja as FECHA_BAJA_SERVICIO, esta_fechaalta as FECHA_ALTA_SERVICIO, count(cabi_id) as CABINAS
                                            from PENSAMIENTO_LINEAL.Crucero 
	                                            join PENSAMIENTO_LINEAL.Marca on (cruc_marca = marc_id) 
	                                            join PENSAMIENTO_LINEAL.Modelo on (cruc_modelo = mode_id)
	                                            left join PENSAMIENTO_LINEAL.Estado_crucero on (cruc_id = esta_crucero)
	                                            join PENSAMIENTO_LINEAL.Cabina on (cruc_id = cabi_crucero)                                             
                                             where YEAR(esta_fechabaja) = YEAR('" + baja + "') AND MONTH(esta_fechabaja) = MONTH('" + baja + "') AND DAY(esta_fechabaja) = DAY('" + baja + "')" +
                                            "group by cruc_id, cruc_identificador, marc_nombre, mode_nombre, cruc_bajadef, esta_fechabaja, esta_fechaalta");
            DBConnection.llenar_grilla(grillaCruceros, query);
        }

        public static void cargar_grilla_cruceros_con_bajaD(DataGridView grillaCruceros, DateTime baja)
        {
            string query = string.Format(@"select cruc_id as ID, cruc_identificador as IDENTIFICADOR, marc_nombre as MARCA, mode_nombre as MODELO, cruc_bajadef as BAJA_DEFINITIVA, esta_fechabaja as FECHA_BAJA_SERVICIO, esta_fechaalta as FECHA_ALTA_SERVICIO, count(cabi_id) as CABINAS
                                            from PENSAMIENTO_LINEAL.Crucero 
	                                            join PENSAMIENTO_LINEAL.Marca on (cruc_marca = marc_id) 
	                                            join PENSAMIENTO_LINEAL.Modelo on (cruc_modelo = mode_id)
	                                            left join PENSAMIENTO_LINEAL.Estado_crucero on (cruc_id = esta_crucero)
	                                            join PENSAMIENTO_LINEAL.Cabina on (cruc_id = cabi_crucero)                                             
                                             where YEAR(cruc_bajadef) = YEAR('" + baja + "') AND MONTH(cruc_bajadef) = MONTH('" + baja + "') AND DAY(cruc_bajadef) = DAY('" + baja + "')" +
                                            "group by cruc_id, cruc_identificador, marc_nombre, mode_nombre, cruc_bajadef, esta_fechabaja, esta_fechaalta");
            DBConnection.llenar_grilla(grillaCruceros, query);
        }

        public static void cargar_grilla_cruceros_con_bajaD(DataGridView grillaCruceros)
        {
            string query = string.Format(@"select cruc_id as ID, cruc_identificador as IDENTIFICADOR, marc_nombre as MARCA, mode_nombre as MODELO, cruc_bajadef as BAJA_DEFINITIVA, esta_fechabaja as FECHA_BAJA_SERVICIO, esta_fechaalta as FECHA_ALTA_SERVICIO, count(cabi_id) as CABINAS
                                            from PENSAMIENTO_LINEAL.Crucero 
	                                            join PENSAMIENTO_LINEAL.Marca on (cruc_marca = marc_id) 
	                                            join PENSAMIENTO_LINEAL.Modelo on (cruc_modelo = mode_id)
	                                            left join PENSAMIENTO_LINEAL.Estado_crucero on (cruc_id = esta_crucero)
	                                            join PENSAMIENTO_LINEAL.Cabina on (cruc_id = cabi_crucero)
                                             where cruc_bajadef IS NOT NULL
                                             group by cruc_id, cruc_identificador, marc_nombre, mode_nombre, cruc_bajadef, esta_fechabaja, esta_fechaalta");
            DBConnection.llenar_grilla(grillaCruceros, query);
        }

    }
}
