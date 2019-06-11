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

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class ReservaForm : Form
    {
        private DateTime fecha_salida;
        private string rol_nombre;

        public ReservaForm(string rol)
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

        private void PuertoOrigen_Enter(object sender, EventArgs e)
        {

        }

        private void PuertoDestino_Enter(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            var puertoOrigen = comboBoxPuertoO.SelectedItem;
            var puertoDestino = comboBoxPuertoD.SelectedItem;


            if (puertoOrigen == null)
            {
                MessageBox.Show("Debe seleccionar el puerto origen", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (puertoDestino == null)
            {
                MessageBox.Show("Debe seleccionar el puerto destino", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (fecha_salida < DateTime.Now)
            {
                MessageBox.Show("Debe seleccionar el puerto destino", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            Reserva_DB.llenar_grilla_reservas_disp(dataGridView1, fecha_salida, puertoOrigen.ToString(), puertoDestino.ToString());

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu form = new Menu(rol_nombre);
            form.Show();
        }

        private void reservar_Click(object sender, EventArgs e)
        {
            Reserva r = obtener_reserva_seleccionada();
            IngresarDatosCliente form = new IngresarDatosCliente(r);
            form.Show();
        }

        private Reserva obtener_reserva_seleccionada()
        {
            string rese_cru_identificador = dataGridView1.SelectedCells[0].Value.ToString();
            DateTime rese_fSalida = DateTime.Parse(dataGridView1.SelectedCells[1].Value.ToString());
            string rese_cabi_tipo = dataGridView1.SelectedCells[2].Value.ToString();
            var viaje = Reserva_DB.obtener_viaje(rese_fSalida, rese_cru_identificador);
            return new Reserva(Reserva_DB.ultimoCodigoReserva(), viaje, Reserva_DB.obtener_cabina_id(rese_cabi_tipo, viaje));
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            fecha_salida = DateTime.Parse(dateTimePicker2.Value.ToString());
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
