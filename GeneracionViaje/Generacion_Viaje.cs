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

namespace FrbaCrucero.GeneracionViaje
{
    public partial class Generacion_Viaje : Form
    {
        private string rol_nombre;
        public Generacion_Viaje(string rol)
        {
            InitializeComponent();
            rol_nombre = rol;
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Generacion_Viaje_Load(object sender, EventArgs e)
        {
            Crucero_BD.cargar_grilla_cruceros(dataGridView1);
            Recorrido_BD.cargar_grilla_recorridos(dataGridView2);
            if (dataGridView1.RowCount == 0 || dataGridView2.RowCount == 0)            
                generarViaje.Enabled = false; 
        }
    }
}
