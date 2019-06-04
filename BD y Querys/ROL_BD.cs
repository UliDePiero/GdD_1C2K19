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
    public static class ROL_BD
    {
        public static void cargar_grilla_roles(DataGridView grillaRoles)
        {
            string query = string.Format(@"SELECT rol_id as ID, rol_nombre as ROL
                                           FROM PENSAMIENTO_LINEAL.ROL
                                           ORDER BY 1 ASC");           
            DBConnection.llenar_grilla(grillaRoles, query);
        }
        public static List<Funcionalidad> obtener_todas_funcionalidades()
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            string query = string.Format(@"SELECT func_id, func_nombre FROM PENSAMIENTO_LINEAL.Funcionalidad");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["func_id"].ToString());
                string nombre = reader["func_nombre"].ToString();

                Funcionalidad func = new Funcionalidad(id, nombre);
                funcionalidades.Add(func);
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return funcionalidades;
        }
        public static void cargar_funcionalidades_asignadas(ROL rol)
        {
            /*rol.funcionalidades = new List<Funcionalidad>();
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.fn_get_funcionalidades_rol(@rol_id)");

            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@rol_id", rol.id);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["func_id"].ToString());
                string nombre = reader["func_nombre"].ToString();

                Funcionalidad func = new Funcionalidad(id, nombre);
                rol.funcionalidades.Add(func);
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();*/
        }

        public static void cargar_grilla_funcionalidades(DataGridView grillaFuncionalidades, ROL rol)
        {
            string query = string.Format(@" SELECT func_id as ID, func_nombre as Nombre FROM PENSAMIENTO_LINEAL.Funcionalidad 
                                    JOIN PENSAMIENTO_LINEAL.Rol_Funcion ON (func_id = rol_func_funcid )
                                    WHERE rol_func_rolid = '" + rol.id + "' ");
            DBConnection.llenar_grilla(grillaFuncionalidades, query);
        }

        public static bool agregar_rol(ROL rol)
        {
            try
            {
                string query = string.Format(@"INSERT INTO PENSAMIENTO_LINEAL.Rol(rol_nombre) VALUES (@rol_nombre); SELECT SCOPE_IDENTITY()");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@rol_nombre", rol.nombre);

                int rol_cod_generado = Convert.ToInt32(cmd.ExecuteScalar());
                foreach (Funcionalidad func in rol.funcionalidades)
                {
                    cmd = new SqlCommand("INSERT INTO PENSAMIENTO_LINEAL.Rol_Funcion (rol_func_rolid, rol_func_funcid) VALUES (@rol_id, @func_id)", conn);

                    cmd.Parameters.AddWithValue("@rol_id", rol_cod_generado);
                    cmd.Parameters.AddWithValue("@func_id", func.id);

                    cmd.ExecuteNonQuery();
                }
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool borrar_rol(ROL rol)
        {
            throw new NotImplementedException();
         /*
            try
            {
                string query = string.Format(@"UPDATE PENSAMIENTO_LINEAL.Rol SET Rol_habilitado = @rol_hab WHERE Rol_codigo=@rol_id");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@rol_hab", Convert.ToInt32(!rol.habilitado));
                cmd.Parameters.AddWithValue("@rol_id", rol.id);

                cmd.ExecuteNonQuery();
                
                if (rol.habilitado)
                {
                    cmd = new SqlCommand("DELETE FROM PENSAMIENTO_LINEAL.Rol_Usuario WHERE RolUsua_rol=@rol_id", conn);
                    cmd.Parameters.AddWithValue("@rol_id", rol.id);
                    
                    cmd.ExecuteNonQuery();
                }
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al borrar Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        */
        }
        public static bool modificar_rol(ROL rol, List<Funcionalidad> funcionalidades_anteriores)
        {
            try
            {                
                List<Funcionalidad> funcionalidades_nuevas = rol.funcionalidades.Where(func_a => !funcionalidades_anteriores.Any(func_b => func_a.id == func_b.id)).ToList();
                List<Funcionalidad> funcionalidades_quitadas = funcionalidades_anteriores.Where(func_b => !rol.funcionalidades.Any(func_a => func_b.id == func_a.id)).ToList();
                string query = string.Format(@"UPDATE PENSAMIENTO_LINEAL.Rol SET rol_nombre=@rol_nombre WHERE rol_id=@rol_id");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@rol_nombre", rol.nombre);
                cmd.Parameters.AddWithValue("@rol_id", rol.id);

                cmd.ExecuteNonQuery();                
                foreach (Funcionalidad func in funcionalidades_nuevas)
                {
                    cmd = new SqlCommand("INSERT INTO PENSAMIENTO_LINEAL.Rol_Funcion (rol_func_rolid, rol_func_funcid) VALUES (@rol_id, @func_id)", conn);
                    cmd.Parameters.AddWithValue("@rol_id", rol.id);
                    cmd.Parameters.AddWithValue("@func_id", func.id);
                    
                    cmd.ExecuteNonQuery();
                }                
                foreach (Funcionalidad func in funcionalidades_quitadas)
                {
                    cmd = new SqlCommand("DELETE FROM PENSAMIENTO_LINEAL.Rol_Funcion WHERE rol_func_funcid=@func_id AND rol_func_rolid=@rol_id", conn);
                    cmd.Parameters.AddWithValue("@func_id", func.id);
                    cmd.Parameters.AddWithValue("@rol_id", rol.id);

                    cmd.ExecuteNonQuery();
                }

                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al modificar Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
