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

           string query = string.Format(@"SELECT puer_nombre from Puerto");

           DBConnection.llenar_combox(combox, query);

       }
    }
}
