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
    public partial class EmitirReserva : Form
    {
        private string cod;

        public EmitirReserva(string codigo_reserva)
        {
            InitializeComponent();
            cod = codigo_reserva;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cerrar_Click(object sender, EventArgs e)
        {

        }
    }
}
