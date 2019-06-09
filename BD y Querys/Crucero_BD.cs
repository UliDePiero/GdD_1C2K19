﻿using System;
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



        public static List<TipoCabina> obtener_todas_cabinas()
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
            string query = string.Format(@"SELECT cabi_id, cabi_piso, cabi_numero, cabi_crucero, cabi_tipo FROM PENSAMIENTO_LINEAL.Cabina WHERE cabi_crucero=@id");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", cruc_id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int cabi_id = int.Parse(reader["cabi_id"].ToString());
                int cabi_piso = int.Parse(reader["cabi_piso"].ToString());
                int cabi_numero = int.Parse(reader["cabi_numero"].ToString());
                int cabi_crucero = int.Parse(reader["cabi_crucero"].ToString());
                int cabi_tipo = int.Parse(reader["cabi_tipo"].ToString());

                Cabina Cab = new Cabina(cabi_id, cabi_piso, cabi_numero, obtener_tipoCabina_con_ID(cabi_tipo), obtener_crucero_con_ID(cabi_crucero));
                cabinas.Add(Cab);
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return cabinas;
        }


        public static bool agregar_crucero(Crucero crucero_nuevo)
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

                foreach (Cabina cab in crucero_nuevo.Cabinas)
                {
                    cmd = new SqlCommand("INSERT INTO PENSAMIENTO_LINEAL.Cabina (cabi_piso, cabi_numero, cabi_crucero, cabi_tipo) VALUES (1, 1, @cabi_crucero_id, @cabi_tipo)", conn); //HARDCODEADO PISO Y NUMERO

                    cmd.Parameters.AddWithValue("@cabi_crucero_id", cruc_cod_generado);
                    cmd.Parameters.AddWithValue("@cabi_tipo", cab.tipo.id);

                    cmd.ExecuteNonQuery();
                }
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
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar crucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool modificar_crucero(Crucero crucero_nuevo, List<Cabina> cabinas_anteriores, List<ServicioCrucero> servicios_anteriores)
        {
           try
            {                
                List<Cabina> cabinas_nuevas = crucero_nuevo.Cabinas.Where(cab_a => !cabinas_anteriores.Any(cab_b => cab_a.id == cab_b.id)).ToList();
                List<Cabina> cabinas_quitadas = cabinas_anteriores.Where(cab_b => !crucero_nuevo.Cabinas.Any(cab_a => cab_b.id == cab_a.id)).ToList();
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
                foreach (Cabina cab in cabinas_nuevas)
                {
                    cmd = new SqlCommand("INSERT INTO PENSAMIENTO_LINEAL.Cabina (cabi_piso, cabi_numero, cabi_crucero, cabi_tipo) VALUES (1, 1, @cabi_crucero_id, @cabi_tipo)", conn); //HARDCODEADO PISO Y NUMERO
                    cmd.Parameters.AddWithValue("@cabi_crucero_id", crucero_nuevo.id);
                    cmd.Parameters.AddWithValue("@cabi_tipo", cab.tipo.id);
                    
                    cmd.ExecuteNonQuery();
                }
                foreach (Cabina cab in cabinas_quitadas)
                {
                    cmd = new SqlCommand("DELETE FROM PENSAMIENTO_LINEAL.Cabina WHERE cabi_crucero_id=@cabi_crucero_id AND cabi_tipo=@cabi_tipo", conn);
                    cmd.Parameters.AddWithValue("@cabi_crucero_id", crucero_nuevo.id);
                    cmd.Parameters.AddWithValue("@cabi_tipo", cab.id);

                    cmd.ExecuteNonQuery();
                }
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

        public static bool baja_definitiva(Crucero crucero, DateTime fecha_operacion)
        {
            try{
                string query = string.Format(@"UPDATE PENSAMIENTO_LINEAL.Crucero SET cruc_bajadef=@cruc_bajadef WHERE cruc_id=@cruc_id");
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
                string query = string.Format(@"INSERT INTO PENSAMIENTO_LINEAL.Estado_crucero (esta_desc,esta_fechabaja,esta_crucero) VALUES (@esta_desc,@esta_fechabaja,@esta_crucero)");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@esta_desc", "BAJA");
                cmd.Parameters.AddWithValue("@esta_fechabaja", fecha_operacion);
                cmd.Parameters.AddWithValue("@esta_crucero", crucero.id);

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

        public static bool alta(Crucero crucero, DateTime fecha_operacion)
        {
            try
            {
                string query = string.Format(@"INSERT INTO PENSAMIENTO_LINEAL.Estado_crucero (esta_desc,esta_fechaalta,esta_crucero) VALUES (@esta_desc,@esta_fechaalta,@esta_crucero)");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@esta_desc", "ALTA");
                cmd.Parameters.AddWithValue("@esta_fechaalta", fecha_operacion);
                cmd.Parameters.AddWithValue("@esta_crucero", crucero.id);

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
    }
}
