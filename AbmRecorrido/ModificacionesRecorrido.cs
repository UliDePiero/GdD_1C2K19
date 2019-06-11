using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.Clases;
using FrbaCrucero.BD_y_Querys;
namespace FrbaCrucero.AbmRecorrido
{
    public partial class ModificacionesRecorrido : Form
    {
        private string rol_nombre;
        private string tipo_ingreso;
        private Recorrido recorrido_modificar;        
        public ModificacionesRecorrido(string rol, Recorrido recorrido_modif, String operacion)
        {
            InitializeComponent();
            rol_nombre = rol;
            tipo_ingreso = operacion;
            recorrido_modificar = recorrido_modif;            
            if (tipo_ingreso != "Modificar")
                modificarRecorrido.Visible = false;
            List<Tramo> tramos = Recorrido_BD.obtener_todos_tramos();
            foreach (Tramo tra in tramos)
            {
                if (recorrido_modificar != null && recorrido_modificar.tramos.Any(t => t.id == tra.id))
                {
                    checkedListBoxTramos.Items.Add(tra, CheckState.Checked);
                }
                else
                {
                    checkedListBoxTramos.Items.Add(tra, CheckState.Unchecked);
                }
                checkedListBoxTramos.DisplayMember = "id";
                checkedListBoxTramos.ValueMember = "id";
            }
            if (recorrido_modificar != null)
            {
                textBoxCodigoRec.Text = recorrido_modificar.codigo;
                //textBoxPrecioRec.Text = calcular_precio_total();
                //textBoxDuracionRec.Text = calcular_duracion_total();
            }
        }

        private void ModificacionesRecorrido_Load(object sender, EventArgs e)
        {
            Recorrido_BD.cargar_grilla_tramos(dataGridView1);
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (recorrido_modificar == null)
            {
                nuevo_recorrido();
            }
            else
            {
                modificar_recorrido();
            }            
        }

        private void modificar_recorrido()
        {
            throw new NotImplementedException();
            /*this.Close();
            ABM_Recorrido form = new ABM_Recorrido(rol_nombre);
            form.Show();*/
        }

        private void nuevo_recorrido()
        {
            throw new NotImplementedException();
            /*this.Close();
            ABM_Recorrido form = new ABM_Recorrido(rol_nombre);
            form.Show();*/
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            ABM_Recorrido form = new ABM_Recorrido(rol_nombre);
            form.Show();
        }
    }
}
