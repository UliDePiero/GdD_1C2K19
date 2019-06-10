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
using FrbaCrucero.CompraReservaPasaje;

namespace FrbaCrucero.CompraPasaje
{
    public partial class Reserva : Form
    {
        private DateTime fecha_salida;

        public Reserva()
        {
            InitializeComponent();
        }

        private void Reserva_Load(object sender, EventArgs e)
        {

        }

        private void FechaSalida_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fecha_salida = DateTime.Parse(dateTimePicker1.Value.ToString());
        }

        private void PuertoOrigen_Enter(object sender, EventArgs e)
        {

        }

        private void buscarPasaje_Click(object sender, EventArgs e)
        {

        }

        private void PuertoDestino_Enter(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu form = new Menu();
            form.Show();
        }

        private void reservar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxPuertoO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reserva_DB.llenar_combox_puertos(comboBoxPuertoO);
        }

        private void comboBoxPuertoD_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reserva_DB.llenar_combox_puertos(comboBoxPuertoD);
        }
    }
}
