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

namespace FrbaCrucero.AbmRecorrido
{
    public partial class ABM_Tramo : Form
    {
        private string rol_nombre;
        public ABM_Tramo(string rol)
        {
            InitializeComponent();
            rol_nombre = rol;
        }

        private void ABM_Tramo_Load(object sender, EventArgs e)
        {
            Tramo_BD.cargar_grilla_tramos(dataGridView1);
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
            ABM_Recorrido form = new ABM_Recorrido(rol_nombre);
            form.Show();
        }

        private void nuevoTramo_Click(object sender, EventArgs e)
        {
            this.Close();
            ModificacionesTramo form = new ModificacionesTramo(rol_nombre);
            form.Show();
        }

        private void modificarTramo_Click(object sender, EventArgs e)
        {
            this.Close();
            ModificacionesTramo form = new ModificacionesTramo(rol_nombre);
            form.Show();
        }
    }
}
