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
            var codigo = textBox1.Text.ToString();

            Pasaje pasaje = Reserva_DB.buscarReservas(codigo);
            if (pasaje == null)
            {
                MessageBox.Show("No existe ninguna reserva para el codigo indicado", "Reserva no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
