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
    public static class ROL_BD
    {
        public static void cargar_grilla_roles(DataGridView grillaRoles)
        {
            string query = string.Format(@"SELECT rol_id as ID, rol_nombre as Nombre, rol_habilitado as ROL
                                           FROM PENSAMIENTO_LINEAL.ROL");           
            DBConnection.llenar_grilla(grillaRoles, query);
        }
        public static void cargar_grilla_roles_habilitados(DataGridView grillaRoles)
        {
            string query = string.Format(@"SELECT rol_id as ID, rol_nombre as Nombre, rol_habilitado as ROL
                                           FROM PENSAMIENTO_LINEAL.ROL
                                            WHERE rol_habilitado=1");
            DBConnection.llenar_grilla(grillaRoles, query);
        }
        public static void inhabilitar_rol(ROL rol){
                string query = string.Format(@"UPDATE PENSAMIENTO_LINEAL.Rol SET rol_habilitado=0 WHERE rol_id=@rol_id");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);                
                cmd.Parameters.AddWithValue("@rol_id", rol.id);

                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("DELETE FROM PENSAMIENTO_LINEAL.Rol_Usuario WHERE rol_usuario_rolid=@rol_usuario_rolid", conn);
                cmd.Parameters.AddWithValue("@rol_usuario_rolid", rol.id);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
        }
        public static void habilitar_rol(ROL rol)
        {
            string query = string.Format(@"UPDATE PENSAMIENTO_LINEAL.Rol SET rol_habilitado=1 WHERE rol_id=@rol_id");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@rol_id", rol.id);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
            conn.Dispose();
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
        public static List<Funcionalidad> obtener_funcionalidades_asignadas(ROL rol)
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            string query = string.Format(@" SELECT func_id, func_nombre FROM PENSAMIENTO_LINEAL.Funcionalidad 
                                    JOIN PENSAMIENTO_LINEAL.Rol_Funcion ON (func_id = rol_func_funcid )
                                    WHERE rol_func_rolid = '" + rol.id + "' ");
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
                string query = string.Format(@"INSERT INTO PENSAMIENTO_LINEAL.Rol(rol_nombre, rol_habilitado) VALUES (@rol_nombre, 1); SELECT SCOPE_IDENTITY()");
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

        public static List<ROL> obtener_todos_roles()
        {
            List<ROL> roles = new List<ROL>();
            string query = string.Format(@"SELECT rol_id, rol_nombre, rol_habilitado FROM PENSAMIENTO_LINEAL.ROL");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["rol_id"].ToString());
                string nombre = reader["rol_nombre"].ToString();
                bool habilitado = reader.GetBoolean(reader.GetOrdinal("rol_habilitado"));

                ROL rol = new ROL(id, nombre, habilitado);
                if (rol.habilitado == true)
                    roles.Add(rol);
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return roles;
        }

        public static List<int> obtener_todos_id_de_usuarios_con_username()
        {
            List<int> ids = new List<int>();
            string query = string.Format(@"SELECT usua_id FROM PENSAMIENTO_LINEAL.Usuario WHERE usua_username IS NOT NULL");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["usua_id"].ToString());

                    ids.Add(id);
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return ids;
        }
        public static bool validar_nombre(string nombre)
        {
            string query = string.Format(@"SELECT * FROM PENSAMIENTO_LINEAL.Rol WHERE rol_nombre=@nombre");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            bool rta = cmd.ExecuteScalar() == null;
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return rta;
        }

        public static List<ROL> obtener_roles_con_username()
        {
            List<ROL> roles = new List<ROL>();
            string query = string.Format(@"SELECT rol_id, rol_nombre, rol_habilitado FROM PENSAMIENTO_LINEAL.Rol JOIN PENSAMIENTO_LINEAL.Rol_Usuario ON(rol_id = rol_usuario_rolid) JOIN PENSAMIENTO_LINEAL.Usuario ON(rol_usuario_usuarioid = usua_id) WHERE usua_username = @usua_username");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@usua_username", UsuarioLogeado.Username);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["rol_id"].ToString());
                string nombre = reader["rol_nombre"].ToString();
                bool habilitado = reader.GetBoolean(reader.GetOrdinal("rol_habilitado"));
                
                ROL rol = new ROL(id, nombre, habilitado);
                if (rol.habilitado == true)
                    roles.Add(rol);
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return roles;
        }

        public static void cargar_grilla_roles_con_funcionalidad(DataGridView grillaRoles, string funcionalidad)
        {
            string query = string.Format(@"SELECT rol_id as ID, rol_nombre as Nombre, rol_habilitado as ROL
                                            FROM PENSAMIENTO_LINEAL.Rol JOIN PENSAMIENTO_LINEAL.Rol_Funcion ON(rol_func_rolid=rol_id) JOIN PENSAMIENTO_LINEAL.Funcionalidad ON(rol_func_funcid=func_id)
                                            WHERE func_nombre='"+funcionalidad+"'");
            DBConnection.llenar_grilla(grillaRoles, query);
        }
    }
}
