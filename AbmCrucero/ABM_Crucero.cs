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

namespace FrbaCrucero.AbmCrucero
{
    public partial class ABM_Crucero : Form
    {
        public ABM_Crucero()
        {
            InitializeComponent();
        }

        private void ABM_Crucero_Load(object sender, EventArgs e)
        {
            Crucero_BD.cargar_grilla_cruceros(dataGridView1);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nuevoCrucero_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificacionesCrucero form = new ModificacionesCrucero();
            form.Show();
        }

        private void modificarCrucero_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificacionesCrucero form = new ModificacionesCrucero();
            form.Show();
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu form = new Menu();
            form.Show();
        }
    }
}
