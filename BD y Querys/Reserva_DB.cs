using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrbaCrucero.BD_y_Querys
{
    class Reserva_DB
    {
       public static void llenar_combox_puertos(ComboBox combox){
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

