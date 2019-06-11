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
       public static void  llenar_grilla_reservas_disp(DataGridView dataGrid1,DateTime fechaSalida, string puertoOrigen, string puertoDestino)
       {
           SqlConnection conn = DBConnection.getConnection();
           string query = string.Format(@"select cruc_identificador, reco_cruc_salida, c.puer_nombre, d.puer_nombre, tipo_nombre, count(cabi_id) as 'Cabinas Disponibles' , (tipo_porc_rec * 
                                            (
					                        select sum(tram_precio) 
					                        from PENSAMIENTO_LINEAL.Tramo 
					                        join PENSAMIENTO_LINEAL.Recorrido_tramo on tram_id=reco_tram_tramid 
					                        where reco_tram_recoid = reco_id)
					                        ) as Precio
                                        from PENSAMIENTO_LINEAL.Recorrido_crucero
                                        join PENSAMIENTO_LINEAL.Crucero on cruc_id = reco_cruc_crucid
                                        join PENSAMIENTO_LINEAL.Recorrido on reco_id = reco_cruc_recoid
                                        join PENSAMIENTO_LINEAL.Recorrido_tramo on reco_tram_recoid = reco_id
                                        join PENSAMIENTO_LINEAL.Tramo a on a.tram_id = reco_tram_tramid
                                        join PENSAMIENTO_LINEAL.Tramo b on b.tram_id = reco_tram_tramid
                                        join PENSAMIENTO_LINEAL.Puerto c on c.puer_id = a.tram_origen and c.puer_nombre = $puertoOrigen
                                        join PENSAMIENTO_LINEAL.Puerto d on d.puer_id = b.tram_destino and d.puer_nombre = $puertoDestino
                                        join PENSAMIENTO_LINEAL.Cabina on cabi_crucero = cruc_id 
                                        join PENSAMIENTO_LINEAL.Tipo_cabina on tipo_id = cabi_tipo
										join PENSAMIENTO_LINEAL.Pasaje on pasa_cabina = reco_cruc_id
										join PENSAMIENTO_LINEAL.Reserva on rese_viaje = reco_cruc_id
										where reco_cruc_salida = $fechaSalida and cabi_id not in (select cabi_id from PENSAMIENTO_LINEAL.Cabina where pasa_cabina=cabi_id or rese_cabina = cabi_id) 
                                        group by cruc_identificador, reco_cruc_salida, c.puer_nombre, d.puer_nombre, tipo_nombre, tipo_porc_rec, reco_id");

           SqlCommand cmd = new SqlCommand(query, conn);
           cmd.Parameters.AddWithValue("$fechaSalida", fechaSalida);
           cmd.Parameters.AddWithValue("$puertoOrigen", puertoOrigen);
           cmd.Parameters.AddWithValue("$puertoDestino", puertoDestino);

           DBConnection.llenar_grilla_command(dataGrid1, cmd);

       }
       public static int obtener_viaje(DateTime rese_fSalida, string rese_cru_identificador); //devuelve la pk de recorrido crucero
       
       public static int obtener_cabina_id(string rese_cru_identificador, int rese_cabi_tipo);//devuelve la pk de la cabina q este disponible de ese tipo para ese crucero

       public static string ultimoCodigoReserva()
       {
           string query = string.Format(@"select Top 1 rese_codigo from PENSAMIENTO_LINEAL.Reserva order by rese_codigo DESC");
           SqlConnection conn = DBConnection.getConnection();
           SqlCommand cmd = new SqlCommand(query, conn);
           SqlDataReader reader = cmd.ExecuteReader();
           var num = System.Convert.ToDecimal(reader.GetValue(0).ToString()) + 1;
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

