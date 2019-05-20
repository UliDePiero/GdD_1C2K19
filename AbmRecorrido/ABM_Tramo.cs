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
    public partial class ABM_Tramo : Form
    {
        public ABM_Tramo()
        {
            InitializeComponent();
        }

        private void ABM_Tramo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2019DataSet.Maestra' table. You can move, or remove it, as needed.
            //this.maestraTableAdapter.Fill(this.gD1C2019DataSet.Maestra);

        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
            ABM_Recorrido form = new ABM_Recorrido();
            form.Show();
        }

        private void nuevoTramo_Click(object sender, EventArgs e)
        {
            this.Close();
            ModificacionesTramo form = new ModificacionesTramo();
            form.Show();
        }

        private void modificarTramo_Click(object sender, EventArgs e)
        {
            this.Close();
            ModificacionesTramo form = new ModificacionesTramo();
            form.Show();
        }
    }
}
