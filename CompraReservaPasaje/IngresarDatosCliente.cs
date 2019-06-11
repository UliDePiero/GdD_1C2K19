using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.Clases;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class IngresarDatosCliente : Form
    {
        private Reserva r;
        public IngresarDatosCliente(Reserva _r)
        {
            InitializeComponent();
            r = _r;
        }

        private void IngresarDatosCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
