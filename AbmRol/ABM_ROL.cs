using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.BD_y_Querys;
using FrbaCrucero.Clases;

namespace FrbaCrucero.AbmRol
{
    public partial class ABM_ROL : Form
    {
        private string rol_nombre;
        private bool mostrar;

        public ABM_ROL(string rol)
        {
            InitializeComponent();
            rol_nombre = rol;
            mostrar = true;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ROL_BD.cargar_grilla_roles(dataGridView1);
            cargarGrillaFunc();
        }
        private void cargarGrillaFunc(){
            if (dataGridView1.RowCount != 0)
            {
                ROL_BD.cargar_grilla_funcionalidades(dataGridView2, obtener_rol_seleccionado());
                habilitar_desRol.Enabled = true;
                modificarRol.Enabled = true;              
            }
            else
            {
                habilitar_desRol.Enabled = false;
                modificarRol.Enabled = false;
                dataGridView2.DataSource = null;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ROL_BD.cargar_grilla_funcionalidades(dataGridView2, obtener_rol_seleccionado());
        } 

        private ROL obtener_rol_seleccionado()
        {
            bool rol_habilitado = bool.Parse(dataGridView1.SelectedCells[2].Value.ToString());
            int rol_id = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            string rol_nombre = dataGridView1.SelectedCells[1].Value.ToString();            

            return new ROL(rol_id, rol_nombre, rol_habilitado);
        }

        private List<Funcionalidad> obtener_funcionalidades()
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                int func_id = int.Parse(row.Cells[0].Value.ToString());
                string func_nombre = row.Cells[1].Value.ToString();
                Funcionalidad func = new Funcionalidad(func_id, func_nombre);
                funcionalidades.Add(func);
            }
            return funcionalidades;
        }

        private void nuevoRol_Click(object sender, EventArgs e)
        {
            this.Close();
            ModificacionesROL form = new ModificacionesROL("Nuevo", null, rol_nombre);
            form.Show();
        }

        private void modificarRol_Click(object sender, EventArgs e)
        {           
            ROL rol_modif = obtener_rol_seleccionado();
            rol_modif.funcionalidades = obtener_funcionalidades();
            this.Close();
            ModificacionesROL form = new ModificacionesROL("Modificar", rol_modif, rol_nombre);
            form.Show();
        }

        private void habilitar_desRol_Click(object sender, EventArgs e)
        {
            ROL rol=obtener_rol_seleccionado();
            if (rol.habilitado == true){
                if(rol_nombre == rol.nombre){
                    DialogResult dialogResult = MessageBox.Show("Se dehabilitará su rol actual y será cerrarán las ventanas abiertas, pudiendo perder acceso a ciertas funcionalidades del sistema, está seguro?", "Deshabilitar Rol", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ROL_BD.inhabilitar_rol(rol);
                        Menu menu = (Menu)Application.OpenForms["Menu"];
                        menu.cargarMenu();
                        List<Form> openForms = new List<Form>();

                        foreach (Form f in Application.OpenForms)
                            openForms.Add(f);

                        foreach (Form f in openForms)
                        {
                            if (f.Name != "INICIO" && f.Name != "Menu")
                                f.Close();
                        }                        
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                    ROL_BD.inhabilitar_rol(rol);
            }
            else
                ROL_BD.habilitar_rol(rol);

            mostrar = false;
            ROL_BD.cargar_grilla_roles_habilitados(dataGridView1);
            cargarGrillaFunc();
        }

        private void mostrar_ocuRol_Click(object sender, EventArgs e)
        {
            if(mostrar == true){
                mostrar = false;
                ROL_BD.cargar_grilla_roles_habilitados(dataGridView1);
                cargarGrillaFunc();
            }
            else{
                mostrar = true;
                ROL_BD.cargar_grilla_roles(dataGridView1);
                cargarGrillaFunc();
            }
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
