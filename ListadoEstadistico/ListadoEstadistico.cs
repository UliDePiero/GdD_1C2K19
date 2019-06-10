using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.ListadoEstadistico
{
    public partial class Listado_Estadistico : Form
    {
        private string rol_nombre;
        public Listado_Estadistico(string rol)
        {
            InitializeComponent();
            rol_nombre = rol;
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu form = new Menu(rol_nombre);
            form.Show();
        }

        private void Listado_Estadistico_Load(object sender, EventArgs e)
        {

        }

        private void visualizarListado_Click(object sender, EventArgs e)
        {

        }

    }
}
