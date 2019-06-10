using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRecorrido
{
    public partial class ModificacionesRecorrido : Form
    {
        private string rol_nombre;
        public ModificacionesRecorrido(string rol)
        {
            InitializeComponent();
            rol_nombre = rol;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModificacionesRecorrido_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2019DataSet.Maestra' table. You can move, or remove it, as needed.
            //this.maestraTableAdapter.Fill(this.gD1C2019DataSet.Maestra);

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
            ABM_Recorrido form = new ABM_Recorrido(rol_nombre);
            form.Show();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            ABM_Recorrido form = new ABM_Recorrido(rol_nombre);
            form.Show();
        }
    }
}
