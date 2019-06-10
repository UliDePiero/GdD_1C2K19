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
        private ROL rol;
        private string rol_nombre;
        public Menu(string rol_n)
        {
            InitializeComponent();
            rol_nombre = rol_n.Trim();
            ROL.Text = rol_nombre;
            List<ROL> roles = ROL_BD.obtener_todos_roles();            
            foreach (ROL r in roles)
            {
                if (r.nombre.StartsWith(rol_nombre)){
                    rol = new ROL(r.id, r.nombre, r.habilitado);                                                                   
                    break;
                }
            }                                                
            List<Funcionalidad> funcionalidades = ROL_BD.obtener_funcionalidades_asignadas(rol);
            foreach (Funcionalidad func in funcionalidades)
            {
                comboBoxFuncionalidades.Items.Add(func.nombre.Trim());                                
            }
        }

        private void ejecutar_Click(object sender, EventArgs e)
        {            
            if(comboBoxFuncionalidades.SelectedItem.ToString().StartsWith("ABM Crucero")){
                this.Close();
                ABM_Crucero form = new ABM_Crucero(rol_nombre);
                form.Show();
                }
                else if(comboBoxFuncionalidades.SelectedItem.ToString().StartsWith("ABM Puerto")){
                    this.Close();
                    ABM_Puerto form1 = new ABM_Puerto(rol_nombre);
                        form1.Show();
                    }
                    else if(comboBoxFuncionalidades.SelectedItem.ToString().StartsWith("ABM Recorrido")){
                        this.Close();
                        ABM_Recorrido form2 = new ABM_Recorrido(rol_nombre);
                            form2.Show();
                        }
                        else if(comboBoxFuncionalidades.SelectedItem.ToString().StartsWith("ABM Rol")){
                            this.Close();
                            ABM_ROL form3 = new ABM_ROL(rol_nombre);
                                form3.Show();
                            }
                            else if(comboBoxFuncionalidades.SelectedItem.ToString().StartsWith("Listado Estadístico")){
                                this.Close();
                                Listado_Estadistico form4 = new Listado_Estadistico(rol_nombre);
                                    form4.Show();
                                }
                                else if(comboBoxFuncionalidades.SelectedItem.ToString().StartsWith("Generar Viaje")){
                                    this.Close();
                                    Generacion_Viaje form5 = new Generacion_Viaje(rol_nombre);
                                        form5.Show(); 
                                    }
                                    else if (comboBoxFuncionalidades.SelectedItem.ToString().StartsWith("Reserva de pasaje")){
                                         this.Close();
                                        Reservar form6 = new Reservar(rol_nombre);                      //ACA PONER EL NOMBRE DEL FORM
                                            form6.Show();
                                        }
                                        else if (comboBoxFuncionalidades.SelectedItem.ToString().StartsWith("Pago de pasaje")){
                                            this.Close();
                                            PagarReserva form7 = new PagarReserva(rol_nombre);      //ACA PONER EL NOMBRE DEL FORM
                                                form7.Show();
                                        }
                                            else
                                                MessageBox.Show("Debe seleccionar una funcionalidad", "Menú", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        private void salir_Click(object sender, EventArgs e)
        {
            INICIO inicio = (INICIO)Application.OpenForms["INICIO"];
            inicio.Close();
        }

        private void comboBoxFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void funcionalidadesDisponibles_Enter(object sender, EventArgs e)
        {

        }

    }
}