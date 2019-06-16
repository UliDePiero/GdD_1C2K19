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
                                          where usua_documento = '" + Text + @"'");

            DBConnection.llenar_grilla(dataGridView1, query);

        }

        public static void actualizarCliente(string nombre, string apellido, string telefono, string direccion, string mail, string fechaNacimiento)
        {
            string query = string.Format(@"UPDATE PENSAMIENTO_LINEAL.Usuario SET usua_nombre=$usua_nombre, usua_apellido=$usua_apellido, usua_telefono=$usua_telefono,usua_direccion=$usua_direccion,usua_mail=$usua_mail,usua_documento=$usua_documento,usua_fechanac=$usua_fechanac where usua_id = (select usua_id from PENSAMIENTO_LINEAL.Usuario where usua_nombre=$usua_nombre and usua_apellido=$usua_apellido and usua_telefono=$usua_telefono and usua_direccion=$usua_direccion and usua_mail=$usua_maila and usua_documento=$usua_documento and usua_fechanac=$usua_fechanac)");
           
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("$usua_nombre", nombre);
            cmd.Parameters.AddWithValue("$usua_apellido", apellido);
            cmd.Parameters.AddWithValue("$usua_telefono", telefono);
            cmd.Parameters.AddWithValue("$usua_direccion", direccion);
            cmd.Parameters.AddWithValue("$usua_mail", mail);
            cmd.Parameters.AddWithValue("$usua_fechanac", fechaNacimiento);

            cmd.ExecuteNonQuery();
        }

        public static void registrarCliente(string doc, string nombre, string apellido, string telefono, string direccion, string mail, string fechaNacimiento)
        {
            string query = string.Format(@"INSERT INTO PENSAMIENTO_LINEAL.Usuario(usua_nombre, usua_apellido, usua_telefono,usua_direccion,usua_mail,usua_documento,usua_fechanac) VALUES ($usua_nombre,$usua_apellido,$usua_telefono,$usua_direccion,$usua_mail,$usua_documento,$usua_fechanac)");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("$usua_nombre", nombre);
            cmd.Parameters.AddWithValue("$usua_apellido", apellido);
            cmd.Parameters.AddWithValue("$usua_telefono", telefono);
            cmd.Parameters.AddWithValue("$usua_direccion", direccion);
            cmd.Parameters.AddWithValue("$usua_mail", mail);
            cmd.Parameters.AddWithValue("$usua_documento", doc);
            cmd.Parameters.AddWithValue("$usua_fechanac", fechaNacimiento);

            cmd.ExecuteNonQuery();
        }

        public static int clienteId(Usuario u)
        {
            int id;
            string query = string.Format(@"select usua_id from PENSAMIENTO_LINEAL.Usuario where usua_documento = '" + u.documento.Replace(" ", "") + @"' and usua_nombre = '" + u.nombre.Replace(" ", "") + @"' and usua_apellido = '" + u.apellido.Replace(" ", "") + @"' and usua_telefono = '" + u.telefono.Replace(" ", "") + @"' and usua_mail = '" + u.mail.Replace(" ", "") + @"' and year(usua_fechanac) = year('" + u.fechaNacimiento + @"') and month(usua_fechanac) = month('" + u.fechaNacimiento + @"') and day(usua_fechanac) = day('" + u.fechaNacimiento + @"')");

            using (SqlConnection conn = DBConnection.getConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                id = (Int32)cmd.ExecuteScalar();

            }
            return (int)id;

            /* int id = (Int32)cmd.ExecuteScalar();
             SqlDataReader reader = cmd.ExecuteReader();
             reader.Read();
             int id = int.Parse(reader["usua_id"].ToString());
           
             reader.Close();
             reader.Dispose();
             cmd.Dispose();
             conn.Close();
             conn.Dispose();
             return id;  */
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
