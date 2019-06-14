using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using FrbaCrucero.Clases;

namespace FrbaCrucero
{
    public partial class Login : Form
    {
        private static string server = ConfigurationManager.AppSettings["server"].ToString();
        private static string user = ConfigurationManager.AppSettings["user"].ToString();
        private static string password = ConfigurationManager.AppSettings["password"].ToString();

        public Login()
        {
            InitializeComponent();
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            valor = true;
            if (logins(textBoxUsuario.Text, textBoxContraseña.Text))
            {
                this.Close();
                Menu form = new Menu();
                form.Show();
            }
            else
                if(valor)
                invalidarUsuarios(textBoxUsuario.Text);
        }

        public static SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "SERVER=" + server + "\\SQLSERVER2012; DATABASE = GD1C2019;UID=" + user + ";PASSWORD=" + password + ";";
            conn.Open();
            return conn;
        }

        bool valor = true;

        private bool logins(string usua, string contra)
        {
            int idUsu = Usuarios.IndexOf(usua);
            if (idUsu < 0)
            {
                MessageBox.Show("No se encontro usuario");
                valor = false;
                return false;
            }
            try
            {
                using (SqlConnection conexion = getConnection())
                {
                    string comando = "SELECT usua_username, usua_password FROM PENSAMIENTO_LINEAL.Usuario WHERE usua_username = @usua AND usua_password = dbo.codificarSHA256(@contra) AND  usua_habilitado = 1";
                    using (SqlCommand cmd = new SqlCommand(comando, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usua", usua);
                        cmd.Parameters.AddWithValue("@contra", contra);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {                            
                            MessageBox.Show("Inicio de sesión exitoso.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UsuarioLogeado.Username = usua;
                            conexion.Close();
                            return true;
                        }
                        else
                        {
                            Fallas[idUsu]++;
                            MessageBox.Show("Datos incorrectos.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                            
                            conexion.Close();
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);                                            
                return false;
            }
        }
        void invalidarUsuarios(string usuario)
        {
            try
            {
                using (SqlConnection conexion = getConnection())
                {
                    int idUsu = Usuarios.IndexOf(usuario);
                    if (Fallas[idUsu] >= 3)
                    {
                        string comando = "update PENSAMIENTO_LINEAL.Usuario set usua_habilitado = 0 where usua_username = '" + usuario + "'";
                        using (SqlCommand cms = new SqlCommand(comando, conexion))
                        {
                            MessageBox.Show("Usuario " + usuario + " ha sido invalidado");
                            cms.ExecuteNonQuery();
                        }

                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        List<String> Usuarios = new List<string>();
        List<int> Fallas = new List<int>();

        private void Login_Load(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conexion = getConnection())
                {
                    string comando = "SELECT distinct(usua_username) FROM PENSAMIENTO_LINEAL.Usuario WHERE usua_habilitado = 1 AND usua_username is Not NULL";
                    using (SqlCommand cmd = new SqlCommand(comando, conexion))
                    {
                        string usuario = "", temp = "";
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            temp = dr.GetString(0);
                            temp = temp.Replace(" ", String.Empty);
                            Usuarios.Add(temp);
                            Fallas.Add(0);
                            usuario += temp + " ,";
                        }
                        MessageBox.Show("" + Usuarios.Count + usuario);
                        conexion.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
