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
    public partial class ABM_Recorrido : Form
    {
        public ABM_Recorrido()
        {
            InitializeComponent();
        }

        private void ABM_Recorrido_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2019DataSet.Maestra' table. You can move, or remove it, as needed.
            //this.maestraTableAdapter.Fill(this.gD1C2019DataSet.Maestra);

        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu form = new Menu();
            form.Show();
        }

        private void editarTramos_Click(object sender, EventArgs e)
        {
            this.Close();
            ABM_Tramo form = new ABM_Tramo();
            form.Show();
        }

        private void nuevoRecorrido_Click(object sender, EventArgs e)
        {
            this.Close();
            ModificacionesRecorrido form = new ModificacionesRecorrido();
            form.Show();
        }

        private void modificarRecorrido_Click(object sender, EventArgs e)
        {
            this.Close();
            ModificacionesRecorrido form = new ModificacionesRecorrido();
            form.Show();
        }
    }
}
