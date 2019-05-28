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

namespace FrbaCrucero.AbmPuerto
{
    public partial class ABM_Puerto : Form
    {
        public ABM_Puerto()
        {
            InitializeComponent();
        }

        private void ABM_Puerto_Load(object sender, EventArgs e)
        {
            Puerto_BD.cargar_grilla_puertos(dataGridView1);
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu form = new Menu();
            form.Show();
        }
    }
}
