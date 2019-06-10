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

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class Reservar : Form
    {
        private DateTime fecha_salida;
        private string rol_nombre;

        public Reservar(string rol)
        {
            InitializeComponent();
                rol_nombre = rol;
                Reserva_DB.llenar_combox_puertos(comboBoxPuertoO);
                Reserva_DB.llenar_combox_puertos(comboBoxPuertoD);
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
            Menu form = new Menu(rol_nombre);
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

        }

        private void comboBoxPuertoD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
