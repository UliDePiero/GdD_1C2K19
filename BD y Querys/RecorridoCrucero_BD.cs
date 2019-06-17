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
    public static class RecorridoCrucero_BD
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
        public static void cargar_grilla_recorridos(DataGridView grillaRecorridos)
        {
            string query = string.Format(@"SELECT reco_id as Codigo, reco_primertramo as Puerto_origen
                                           FROM PENSAMIENTO_LINEAL.Recorrido
                                           ORDER BY 1 ASC");
            DBConnection.llenar_grilla(grillaRecorridos, query);
        }
        public static void cargar_grilla_Recoridos_Cruceros(int id,DataGridView grillaCruceros)
        {/* "select reco_cruc_crucid as id, reco_cruc_id as crucero_id, reco_cruc_recoid as recorido_id, reco_cruc_salida as fecha_Salida, reco_cruc_llegada_real as fecha_Llegada
from PENSAMIENTO_LINEAL.Recorrido_crucero"
*/         // string query = string.Format(@"select * from PENSAMIENTO_LINEAL.Crucero");
            string query = string.Format(@"select reco_cruc_crucid as id, reco_cruc_id as crucero_id, reco_cruc_recoid as recorido_id, reco_cruc_salida as fecha_Salida, reco_cruc_llegada_real as fecha_Llegada from PENSAMIENTO_LINEAL.Recorrido_crucero where reco_cruc_crucid = '"+id+"' group by  reco_cruc_crucid,reco_cruc_id, reco_cruc_recoid, reco_cruc_salida, reco_cruc_llegada_real");
            /*SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", id);
            DBConnection.llenar_grilla_command(grillaCruceros, cmd);
            cmd.Dispose();
            conn.Close();
            conn.Dispose();*/
            DBConnection.llenar_grilla(grillaCruceros, query);
        }
        public static void cargar_Crucero_Recorrido_Fecha(int CruceroID,int RecorridoId, string Salida, DataGridView grilla)
        {
             Salida = "2019-02-05";                                                            
            //Salida = DateTime.Today;
         //   string query = string.Format(@"select * from PENSAMIENTO_LINEAL.Recorrido_crucero where '"+Salida+"' between reco_cruc_salida and DATEADD(HOUR, dbo.calcularDuracion(reco_cruc_recoid), reco_cruc_salida) OR DATEADD(HOUR, dbo.calcularDuracion(9), GETDATE()) between  reco_cruc_salida and DATEADD(HOUR, dbo.calcularDuracion(reco_cruc_recoid), reco_cruc_salida) OR(reco_cruc_salida between GETDATE() and DATEADD(HOUR, dbo.calcularDuracion('9'), GETDATE()))"
          //      );
            
            string query = string.Format(@"select * 
                                            from PENSAMIENTO_LINEAL.Recorrido_crucero 
                                            where '" + CruceroID + "' =reco_cruc_crucid AND " +
                                              "('"+Salida+ "' between reco_cruc_salida and DATEADD(HOUR, dbo.calcularDuracion(reco_cruc_recoid),reco_cruc_salida) " +
                                              "OR DATEADD(HOUR,dbo.calcularDuracion(" + RecorridoId + "), '"+Salida+ "') between  reco_cruc_salida and DATEADD(HOUR, dbo.calcularDuracion(reco_cruc_recoid),reco_cruc_salida) OR (reco_cruc_salida between '"+Salida+ "' and DATEADD(HOUR,dbo.calcularDuracion('" + RecorridoId + "'), '" + Salida + "')))");
            
            DBConnection.llenar_grilla(grilla, query);

        }
        public static int CalcularTiempoRecorrido(int Recorrido)
        {
            string query = string.Format(@"select sum(tram_duracion) from PENSAMIENTO_LINEAL.Recorrido_tramo join PENSAMIENTO_LINEAL.Tramo on (reco_tram_tramid = tram_id) where reco_tram_recoid = '" + Recorrido +"'");
            DataGridView dataGrid = new DataGridView();
            DBConnection.llenar_grilla(dataGrid, query);
            //if(dataGrid.RowCount!=0)
            return int.Parse(dataGrid.Rows[0].Cells[0].Value.ToString());
            //  return 0;
        }
        public static int CalcularTiempoRecorrido(DataGridView grin, int Recorrido)
        {
            //string query = string.Format(@"select sum(tram_duracion) from PENSAMIENTO_LINEAL.Recorrido_tramo join PENSAMIENTO_LINEAL.Tramo on (reco_tram_tramid = tram_id) where reco_tram_recoid = '" + Recorrido + "'");
            string query = string.Format(@"select dbo.calcularDuracion('" + Recorrido + "')");
            DBConnection.llenar_grilla(grin, query);
            //if(dataGrid.RowCount!=0)
            return 0;//int.Parse(dataGrid.Rows[0].Cells[0].Value.ToString());
            //  return 0;
        }
        public static bool InsertarViaje(int CruceroID, int RecoridoID, DateTime Salida)
        {
            try
            {
                string query = string.Format(@"insert into PENSAMIENTO_LINEAL.Recorrido_crucero (reco_cruc_crucid, reco_cruc_recoid, reco_cruc_salida) Values('" + CruceroID + "','" + RecoridoID + "','"+Salida.ToString()+"')");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
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
    }
}
