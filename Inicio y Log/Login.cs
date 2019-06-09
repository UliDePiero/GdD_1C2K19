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

namespace FrbaCrucero
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            //logins(textBoxUsuario.Text, textBoxContraseña.Text);
            
            this.Close();
            Menu form = new Menu();
            form.Show();
        }


        private static string server = ConfigurationManager.AppSettings["server"].ToString();
        private static string user = ConfigurationManager.AppSettings["user"].ToString();
        private static string password = ConfigurationManager.AppSettings["password"].ToString();

        public static SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "SERVER=" + server + "\\SQLSERVER2012; DATABASE = GD1C2019;UID=" + user + ";PASSWORD=" + password + ";";
            conn.Open();
            return conn;
        }


        void logins(string usua, string contra)
        {
            try
            {
                using (SqlConnection conexion = getConnection())
                {
                    //string comando = "SELECT usua_nombre, usua_password FROM PENSAMIENTO_LINEAL.Usuario WHERE usua_nombre = '" + usua + "' AND  usua_password = HASHBYTES('SHA2_256','" + contra + "')";

                    string comando = "SELECT usua_nombre, usua_password FROM PENSAMIENTO_LINEAL.Usuario WHERE usua_nombre = '" + usua + "' AND  usua_password = HASHBYTES('SHA2_256','" + contra + "')";
                    using (SqlCommand cmd = new SqlCommand(comando, conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Login exitoso.");
                            conexion.Close();
                            this.Close();
                            Menu form = new Menu();
                            form.Show();
                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("no funca");
                MessageBox.Show(ex.ToString());
            }

        }

    }
}
