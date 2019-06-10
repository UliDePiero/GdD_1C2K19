using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FrbaCrucero.AbmCrucero;
using FrbaCrucero.AbmPuerto;
using FrbaCrucero.AbmRecorrido;
using FrbaCrucero.AbmRol;
using FrbaCrucero.GeneracionViaje;
using FrbaCrucero.ListadoEstadistico;
using FrbaCrucero.CompraReservaPasaje;
using FrbaCrucero.BD_y_Querys;
using FrbaCrucero.Clases;

namespace FrbaCrucero
{
    public partial class Menu : Form
    {
        private List<ROL> rolesDelUsuario;
        List<Funcionalidad> funcionalidadesDelUsuario;
        public Menu()
        {
            InitializeComponent();
            cargarMenu();           
        }

        public void cargarMenu(){            
            usuarioLabel.Text = UsuarioLogeado.Username;
            rolesDelUsuario = new List<ROL>();
            funcionalidadesDelUsuario = new List<Funcionalidad>();
            List<ROL> roles = ROL_BD.obtener_todos_roles();
            List<int> ids = ROL_BD.obtener_todos_id_de_usuarios_con_username();
            foreach (ROL r in roles)
            {
                foreach (int id in ids)
                {
                    if (r.id == id)
                        rolesDelUsuario.Add(r);
                }
            }
            foreach (ROL r in rolesDelUsuario)
            {
                comboBoxRoles.Items.Add(r.nombre);
            }
        }
        private void ejecutar_Click(object sender, EventArgs e)
        {            
            if(comboBoxFuncionalidades.SelectedItem.ToString().StartsWith("ABM Crucero")){
                ABM_Crucero form = new ABM_Crucero(comboBoxRoles.SelectedItem.ToString());
                form.Show();
                }
                else if(comboBoxFuncionalidades.SelectedItem.ToString().StartsWith("ABM Puerto")){
                    ABM_Puerto form1 = new ABM_Puerto(comboBoxRoles.SelectedItem.ToString());
                        form1.Show();
                    }
                    else if(comboBoxFuncionalidades.SelectedItem.ToString().StartsWith("ABM Recorrido")){                        
                        ABM_Recorrido form2 = new ABM_Recorrido(comboBoxRoles.SelectedItem.ToString());
                            form2.Show();
                        }
                        else if(comboBoxFuncionalidades.SelectedItem.ToString().StartsWith("ABM Rol")){                            
                            ABM_ROL form3 = new ABM_ROL(comboBoxRoles.SelectedItem.ToString());
                                form3.Show();
                            }
                            else if(comboBoxFuncionalidades.SelectedItem.ToString().StartsWith("Listado Estadístico")){                                
                                Listado_Estadistico form4 = new Listado_Estadistico(comboBoxRoles.SelectedItem.ToString());
                                    form4.Show();
                                }
                                else if(comboBoxFuncionalidades.SelectedItem.ToString().StartsWith("Generar Viaje")){                                    
                                    Generacion_Viaje form5 = new Generacion_Viaje(comboBoxRoles.SelectedItem.ToString());
                                        form5.Show(); 
                                    }
                                    else if (comboBoxFuncionalidades.SelectedItem.ToString().StartsWith("Reserva de pasaje")){                                         
                                         Reservar form6 = new Reservar(comboBoxRoles.SelectedItem.ToString());                 
                                            form6.Show();
                                        }
                                        else if (comboBoxFuncionalidades.SelectedItem.ToString().StartsWith("Pago de pasaje")){                                            
                                            PagarReserva form7 = new PagarReserva(comboBoxRoles.SelectedItem.ToString());
                                                form7.Show();
                                        }
                                            else
                                                MessageBox.Show("Debe seleccionar una funcionalidad", "Menú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        private void comboBoxRoles_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            foreach (ROL r in rolesDelUsuario)
            {
                if (comboBoxRoles.SelectedItem.ToString().StartsWith(r.nombre))
                {
                    funcionalidadesDelUsuario = ROL_BD.obtener_funcionalidades_asignadas(r);
                    break;
                }
            }

            foreach (Funcionalidad func in funcionalidadesDelUsuario)
            {
                comboBoxFuncionalidades.Items.Add(func.nombre.Trim());
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            INICIO inicio = (INICIO)Application.OpenForms["INICIO"];
            inicio.Show();
            UsuarioLogeado.Username = "";
            this.Close();
        }

    }
}