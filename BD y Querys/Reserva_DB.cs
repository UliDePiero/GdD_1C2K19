using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using FrbaCrucero.Clases;

namespace FrbaCrucero.BD_y_Querys
{
    class Reserva_DB
    {
        public static void llenar_grilla_reservas_disp(DataGridView dataGrid1, string fechaSalida, string puertoOrigen, string puertoDestino)
        {
            string query = string.Format(@"select cruc_identificador as 'Crucero ID', CONVERT(nvarchar(30), reco_cruc_salida, 108) as 'Horario de partida', tipo_nombre as 'Tipo de cabina' , count(cabi_id) as 'Cabinas Disponibles' , (tipo_porc_rec * 
                                            (
					                        select sum(tram_precio) 
					                        from PENSAMIENTO_LINEAL.Tramo 
					                        join PENSAMIENTO_LINEAL.Recorrido_tramo on tram_id=reco_tram_tramid 
					                        where reco_tram_recoid = reco_cruc_recoid)
					                        ) as Precio, reco_cruc_id as Viaje
                                        from PENSAMIENTO_LINEAL.Recorrido_crucero
                                        join PENSAMIENTO_LINEAL.Recorrido_tramo on reco_tram_recoid = reco_cruc_recoid
										join PENSAMIENTO_LINEAL.Crucero on reco_cruc_crucid = cruc_id
                                        join PENSAMIENTO_LINEAL.Tramo a on a.tram_id = reco_tram_tramid
                                        join PENSAMIENTO_LINEAL.Tramo b on b.tram_id = reco_tram_tramid
                                        join PENSAMIENTO_LINEAL.Puerto c on c.puer_id = a.tram_origen and c.puer_nombre = '" + puertoOrigen + @"'
                                        join PENSAMIENTO_LINEAL.Puerto d on d.puer_id = b.tram_destino and d.puer_nombre =  '" + puertoDestino + @"'
                                        join PENSAMIENTO_LINEAL.Cabina on cabi_crucero = reco_cruc_crucid 
                                        join PENSAMIENTO_LINEAL.Tipo_cabina on tipo_id = cabi_tipo 
                                        where cabi_id not in (select cabi_id from PENSAMIENTO_LINEAL.Cabina join PENSAMIENTO_LINEAL.Pasaje on pasa_cabina=cabi_id and pasa_viaje = reco_cruc_id) 
										  and cabi_id not in (select cabi_id from PENSAMIENTO_LINEAL.Cabina join PENSAMIENTO_LINEAL.Reserva on rese_cabina=cabi_id and rese_viaje = reco_cruc_id)
										  and year(reco_cruc_salida) = year('" + fechaSalida + @"')
                                          and month(reco_cruc_salida) = month('" + fechaSalida + @"') 
                                          and day(reco_cruc_salida) = day('" + fechaSalida + @"')
									    group by reco_cruc_id,reco_cruc_salida,cruc_identificador, c.puer_nombre, d.puer_nombre, tipo_nombre, tipo_porc_rec, reco_cruc_recoid");


            DBConnection.llenar_grilla(dataGrid1, query);

        }
        public static int obtener_viaje(string rese_fSalida, string rese_cru_identificador)
        {
            int viajeId;
            string query = string.Format(@"select reco_cruc_id 
                                          from PENSAMIENTO_LINEAL.Recorrido_crucero 
                                          join PENSAMIENTO_LINEAL.Crucero on reco_cruc_crucid = cruc_id and cruc_identificador = '" + rese_cru_identificador + @"'
                                          where year(reco_cruc_salida) = year('" + rese_fSalida + @"')
                                          and  month(reco_cruc_salida) = month('" + rese_fSalida + @"') 
                                          and day(reco_cruc_salida) = day('" + rese_fSalida + @"')
                                          and DATEPART ( hour , reco_cruc_salida )  = DATEPART ( hour , '" + rese_fSalida + @"' ) 
                                          and DATEPART ( minute , reco_cruc_salida )  = DATEPART ( minute , '" + rese_fSalida + @"' )"
                                         );



            using (SqlConnection conn = DBConnection.getConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                viajeId = (Int32)cmd.ExecuteScalar();

            }
            return (int)viajeId;


        } //devuelve la pk de recorrido crucero

        public static void guardar(Reserva r)
        {

            using (SqlConnection conn = DBConnection.getConnection())
            {
                foreach (int cabina in r.cabina)
                {
                    string query = string.Format(@"INSERT INTO PENSAMIENTO_LINEAL.Reserva(rese_codigo, rese_cliente, rese_cabina,rese_fecha,rese_viaje) 
                                                  VALUES ('" + r.codigo + "'," + r.cliente + "," + cabina + ",'" + r.fecha + "'," + r.viaje + ")");

                    SqlCommand cmd = new SqlCommand(query, conn);


                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void borrarR(string codigo)
        {

            using (SqlConnection conn = DBConnection.getConnection())
            {

                string query = string.Format(@"DELETE FROM PENSAMIENTO_LINEAL.Reserva WHERE rese_codigo='" + codigo + "'");
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();
            }
        }

        public static void guardarCompra(Pasaje p)
        {
            var precio = p.precio.ToString().Replace(',', '.');
            using (SqlConnection conn = DBConnection.getConnection())
            {
                foreach (int cabina in p.cabina)
                {
                    string query = string.Format(@"INSERT INTO PENSAMIENTO_LINEAL.Pasaje(pasa_codigo, pasa_cliente, pasa_cabina, pasa_fecha, pasa_viaje, pasa_precio) 
                                        VALUES ('" + p.codigo + "'," + p.cliente + "," + cabina + ",'" + p.fecha + "'," + p.viaje + "," + precio + ")");

                    SqlCommand cmd = new SqlCommand(query, conn);


                    cmd.ExecuteNonQuery();
                }
            }
        }


        public static Pasaje buscarReservas(string codigo)
        {
            Pasaje nuevo_pasaje = null;

            string query = string.Format(@"select rese_id,rese_codigo,rese_cliente,rese_viaje,rese_cabina,(
					                        select sum(tram_precio) 
					                        from PENSAMIENTO_LINEAL.Tramo 
					                        join PENSAMIENTO_LINEAL.Recorrido_tramo on tram_id=reco_tram_tramid 
                                            join PENSAMIENTO_LINEAL.Recorrido_crucero on reco_tram_recoid = reco_cruc_recoid        
					                        where rese_viaje = reco_cruc_id) as Precio
                                            from PENSAMIENTO_LINEAL.Reserva
                                            where rese_codigo = '" + codigo + "'"
                                         );

            using (SqlConnection conn = DBConnection.getConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    int cliente = Int32.Parse(reader.GetValue(2).ToString());
                    int viaje = Int32.Parse(reader.GetValue(3).ToString());
                    float precio = float.Parse(reader.GetValue(5).ToString());
                    int cabina;
                    nuevo_pasaje = new Pasaje(cliente, viaje, precio);
                        while(true)
                        {
                            cabina = Int32.Parse(reader.GetValue(4).ToString());

                            nuevo_pasaje.cabina.Add(cabina);

                            if (!reader.Read())
                                break;
                        }
                }
             }
            string nuevo_codigo = Reserva_DB.ultimoCodigoPasaje();
            nuevo_pasaje.codigo = nuevo_codigo;
                return nuevo_pasaje;

        }


        public static List<int> obtener_cabina_id(string cabi_tipo_nombre, int viajeId, int cantidad)
        {
            List<int> cabi_id = new List<int>();

            string query = string.Format(@"select cabi_id 
                                            from PENSAMIENTO_LINEAL.Cabina
                                            join PENSAMIENTO_LINEAL.Tipo_cabina on cabi_tipo = tipo_id
                                            join PENSAMIENTO_LINEAL.Recorrido_crucero on cabi_crucero = reco_cruc_crucid
                                            where tipo_nombre = '" + cabi_tipo_nombre + @"' and reco_cruc_id = " + viajeId + @"
                                            and cabi_id not in (select cabi_id from PENSAMIENTO_LINEAL.Cabina join PENSAMIENTO_LINEAL.Pasaje on pasa_cabina=cabi_id and pasa_viaje = reco_cruc_id) 
										    and cabi_id not in (select cabi_id from PENSAMIENTO_LINEAL.Cabina join PENSAMIENTO_LINEAL.Reserva on rese_cabina=cabi_id and rese_viaje = reco_cruc_id);"
                                        );

            using (SqlConnection conn = DBConnection.getConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                for (int i = 0; i < cantidad; i++)
                {
                    reader.Read();
                    cabi_id.Add(Int32.Parse(reader.GetValue(0).ToString()));
                }

            }

            return cabi_id;
            //devuelve la pk de la cabina q este disponible de ese tipo para ese crucero
        }
        public static string ultimoCodigoReserva()
        {
            string query = string.Format(@"select max(rese_codigo) from PENSAMIENTO_LINEAL.Reserva");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            var num = System.Convert.ToInt32(reader.GetValue(0).ToString()) + 1;
            return System.Convert.ToString(num);
        }

        public static string ultimoCodigoPasaje()
        {
            string query = string.Format(@"select max(pasa_codigo) from PENSAMIENTO_LINEAL.Pasaje");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            var num = System.Convert.ToInt32(reader.GetValue(0).ToString()) + 1;
            return System.Convert.ToString(num);
        }

        public static string grabarReserva(Reserva r)
        {
            try
            {
                string query = string.Format(@"INSERT INTO PENSAMIENTO_LINEAL.Reserva(rese_codigo, rese_fecha, rese_cliente, rese_viaje, rese_cabina) VALUES (@rese_codigo, @rese_fecha, @rese_cliente, @rese_viaje, @rese_cabina); SELECT SCOPE_IDENTITY()");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                var ultimo = ultimoCodigoReserva();
                cmd.Parameters.AddWithValue("@rese_codigo", ultimo);
                cmd.Parameters.AddWithValue("@rese_fecha", r.fecha);
                cmd.Parameters.AddWithValue("@rese_cliente", r.cliente);
                cmd.Parameters.AddWithValue("@rese_cabina", r.cabina);
                cmd.Parameters.AddWithValue("@rese_viaje", r.viaje);

                SqlDataReader reader = cmd.ExecuteReader();

                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return reader.GetValue(1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al reservar pasaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;

        }

        public static void llenar_combox_puertos(ComboBox combox)
        {
            SqlConnection conn = DBConnection.getConnection();
            string query = string.Format(@"SELECT puer_nombre from PENSAMIENTO_LINEAL.Puerto");

            SqlDataReader dr = new SqlCommand(query, conn).ExecuteReader();
            while (dr.Read())
            {
                combox.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
            conn.Close();
        }
    }
}

