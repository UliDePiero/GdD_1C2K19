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
    public partial class PagarReserva : Form
    {
        private string rol_nombre;
        private Pasaje pasaje;
        private string codigo;


        public PagarReserva(string rol)
        {
            InitializeComponent();
            rol_nombre = rol;
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Debe buscar un pasaje", "Falta busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Reserva_DB.guardarCompra(pasaje);

            Reserva_DB.borrarR(codigo);

            this.Close();
            EmitirPago form7 = new EmitirPago(pasaje.codigo);
            form7.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void identificadorCrucero_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            codigo = textBox.Text.ToString();
            if (Reserva_DB.existeReserva(codigo))
            {
                pasaje = Reserva_DB.buscarReservas(codigo);


                Reserva_DB.llenar_grilla_reservasapagar(codigo, dataGridView1);
            }
            else
            {
                    MessageBox.Show("No existe reserva para el codigo indicado.", "Sin registros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
