using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaCrucero.Clases;

namespace FrbaCrucero.BD_y_Querys
{
    class DatosCliente_BD
    {
        public static void llenar_grilla_clientes(DataGridView dataGridView1, string Text)
        {
            string query = string.Format(@"select usua_nombre as Nombre, usua_apellido as Apellido, usua_telefono as Telefono, usua_direccion as Direccion, usua_mail as Mail, usua_fechanac as 'Fecha de nacimiento' 
                                          from PENSAMIENTO_LINEAL.Usuario 
                                          where usua_documento = $documento");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("$documento", Text);

            DBConnection.llenar_grilla_command(dataGridView1, cmd);

        }

        public static void actualizarCliente(string nombre, string apellido, string telefono, string direccion, string mail, string fechaNacimiento)
        { 
            
        }

        public static int clienteId(Usuario u)
        {
            string query = string.Format(@"select usua_id
                                          from PENSAMIENTO_LINEAL.Usuario 
                                          where usua_documento = $documento and usua_nombre = $nombre and usua_apellido = $apellido and usua_telefono = $telefono and usua_fechanac = $fnac ");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("$nombre", u.nombre);
            cmd.Parameters.AddWithValue("$apellido", u.apellido);
            cmd.Parameters.AddWithValue("$documento", u.documento);
            cmd.Parameters.AddWithValue("$telefono", u.telefono);
            cmd.Parameters.AddWithValue("$fnac", u.fechaNacimiento);

            SqlDataReader reader = cmd.ExecuteReader();

            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return Int32.Parse(reader.GetValue(0).ToString()); 
        }
                
        
        public static bool buscarCliente(string Text)
        {
            string query = string.Format(@"select usua_documento from PENSAMIENTO_LINEAL.Usuario where usua_documento = $documento");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("$documento", Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.GetByte(0) != 0)
                return true;
            else
                return false;

        }

    }
}
