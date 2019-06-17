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

        private void Generacion_Viaje_Load(object sender, EventArgs e)
        {
            Crucero_BD.cargar_grilla_cruceros(dataGridView1);
            RecorridoCrucero_BD.cargar_grilla_recorridos(dataGridView2);
            if (dataGridView1.RowCount == 0 || dataGridView2.RowCount == 0)            
                generarViaje.Enabled = false; 
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //textBoxFinalizacion.Text = calcular_fecha_finalizacion();
        }
        int crucero, recorrido;
        bool valido;
        private void generarViaje_Click(object sender, EventArgs e)
        {
            int cru = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            int rec = int.Parse(dataGridView2.SelectedCells[0].Value.ToString());

            if (cru == crucero && rec == recorrido && valido)
            {
                MessageBox.Show("" + RecorridoCrucero_BD.InsertarViaje(crucero, recorrido, dateTimePicker1.Value));
            }

            crucero = cru;
            recorrido = rec;
            RecorridoCrucero_BD.cargar_Crucero_Recorrido_Fecha(crucero, recorrido, dateTimePicker1.Value.ToString(), RecorridosInvalidos);

            valido = RecorridosInvalidos.RowCount == 0;
            if (valido)
            {

                generarViaje.Enabled = true;
                RecorridoCrucero_BD.CalcularTiempoRecorrido(Tiempos, recorrido);
                if (Tiempos.RowCount != 0)
                    textBoxFinalizacion.Text = Tiempos.Rows[0].Cells[0].Value.ToString();
            }
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarRecorrdos_Click(object sender, EventArgs e)
        {
        }
    }
}
