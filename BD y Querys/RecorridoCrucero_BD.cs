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
        public static void cargar_grilla_cruceros(DataGridView grillaCruceros, DateTime salida, DateTime llegada)
        {            
            string query = string.Format(@"select DISTINCT(cruc_id) as ID, cruc_identificador as IDENTIFICADOR, marc_nombre as MARCA, mode_nombre as MODELO
                                            from PENSAMIENTO_LINEAL.Crucero 
	                                            join PENSAMIENTO_LINEAL.Marca on (cruc_marca = marc_id) 
	                                            join PENSAMIENTO_LINEAL.Modelo on (cruc_modelo = mode_id)
	                                            left join PENSAMIENTO_LINEAL.Estado_crucero on (cruc_id = esta_crucero)	                                                                                      
                                            where cruc_id NOT IN (SELECT reco_cruc_crucid FROM PENSAMIENTO_LINEAL.Recorrido_crucero) OR cruc_id NOT IN (SELECT DISTINCT(reco_cruc_crucid) FROM PENSAMIENTO_LINEAL.Recorrido_crucero WHERE CONVERT(datetime, '" + llegada.ToString() + "', 131)>  reco_cruc_salida AND CONVERT(datetime, '" +salida.ToString() + "', 131) < reco_cruc_llegada_real )" +
                                            "group by cruc_id, cruc_identificador, marc_nombre, mode_nombre");
            DBConnection.llenar_grilla(grillaCruceros, query);
        }

        public static bool InsertarViaje(int CruceroID, int RecoridoID, DateTime Salida, DateTime Llegada)
        {
            try
            {
                string query = string.Format(@"insert into PENSAMIENTO_LINEAL.Recorrido_crucero (reco_cruc_recoid, reco_cruc_crucid, reco_cruc_salida, reco_cruc_llegada_real) Values(@reco_cruc_recoid,@reco_cruc_crucid,CONVERT(smalldatetime, @reco_cruc_salida, 121),CONVERT(smalldatetime, @reco_cruc_llegada_real, 121))");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@reco_cruc_recoid", RecoridoID);
                cmd.Parameters.AddWithValue("@reco_cruc_crucid", CruceroID);
                cmd.Parameters.AddWithValue("@reco_cruc_salida", Salida);
                cmd.Parameters.AddWithValue("@reco_cruc_llegada_real", Llegada);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al crear viaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
