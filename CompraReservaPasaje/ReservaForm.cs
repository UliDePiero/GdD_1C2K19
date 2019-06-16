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
        private int cantidad;

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


            validarCompletos();
            
            Reserva_DB.llenar_grilla_reservas_disp(dataGridView1, fecha_salida.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"), puertoOrigen.ToString(), puertoDestino.ToString());

        }

        private void validarCompletos()
        {
            if (puertoOrigen == null)
            {
                MessageBox.Show("Debe seleccionar el puerto origen", "Falta puerto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (puertoDestino == null)
            {
                MessageBox.Show("Debe seleccionar el puerto destino", "Falta puerto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (fecha_salida < DateTime.Now)
            {
                MessageBox.Show("Debe seleccionar una fecha de salida en el futuro", "Fecha incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {            
            if(rol_nombre == "Cliente" ){
                INICIO inicio = (INICIO)Application.OpenForms["INICIO"];
                inicio.Show();
                this.Close();
            }
            else{
                this.Close();
            }
        }

        private void reservar_Click(object sender, EventArgs e)
        {
            validarCompletos();

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar la cantidad de pasajes a comprar", "Falta cantidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
 
            if (dataGridView1.SelectedCells[0] == null || dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar una opcion", "Falta seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            this.Hide();
            cantidad = Int32.Parse(comboBox1.SelectedItem.ToString());

            if (cantidad > Int32.Parse(dataGridView1.SelectedCells[3].Value.ToString()))
            {
                MessageBox.Show("Selecciono mas cabinas de las disponibles", "Cabinas ocupadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Reserva r = obtener_reserva_seleccionada();
            IngresarDatosCliente form = new IngresarDatosCliente(r,cantidad);

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            form.Show();
        }

        private Reserva obtener_reserva_seleccionada()
        {
            string cabi_tipo_nombre = dataGridView1.SelectedCells[2].Value.ToString();
            int viaje = Int32.Parse(dataGridView1.SelectedCells[5].Value.ToString());
            return new Reserva(viaje, Reserva_DB.obtener_cabina_id(cabi_tipo_nombre, viaje,cantidad));
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
            this.Hide();

            cantidad = Int32.Parse(comboBox1.SelectedItem.ToString());
            Pasaje p = obtener_pasaje_seleccionado();
            IngresarDatosCliente form = new IngresarDatosCliente(p, cantidad);

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            form.Show();
        }
        private Pasaje obtener_pasaje_seleccionado()
        {
            string cabi_tipo_nombre = dataGridView1.SelectedCells[2].Value.ToString();
            int viaje = Int32.Parse(dataGridView1.SelectedCells[5].Value.ToString());
            float precio = float.Parse(dataGridView1.SelectedCells[4].Value.ToString());
            return new Pasaje(viaje, Reserva_DB.obtener_cabina_id(cabi_tipo_nombre, viaje, cantidad),precio);
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
