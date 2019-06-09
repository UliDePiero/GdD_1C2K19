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
    public partial class ABM_Recorrido : Form
    {
        private string rol_nombre;

        public ABM_Recorrido(string rol)
        {
            InitializeComponent();
            rol_nombre = rol;
        }

        private void ABM_Recorrido_Load(object sender, EventArgs e)
        {
            Recorrido_BD.cargar_grilla_recorridos(dataGridView1);
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu form = new Menu(rol_nombre);
            form.Show();
        }

        private void editarTramos_Click(object sender, EventArgs e)
        {
            this.Close();
            ABM_Tramo form = new ABM_Tramo(rol_nombre);
            form.Show();
        }

        private void nuevoRecorrido_Click(object sender, EventArgs e)
        {
            this.Close();
            ModificacionesRecorrido form = new ModificacionesRecorrido(rol_nombre);
            form.Show();
        }

        private void modificarRecorrido_Click(object sender, EventArgs e)
        {
            this.Close();
            ModificacionesRecorrido form = new ModificacionesRecorrido(rol_nombre);
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
