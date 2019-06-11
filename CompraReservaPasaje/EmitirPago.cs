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
    public partial class EmitirPago : Form
    {
        private Pasaje pasaje;
        public EmitirPago(Pasaje _pasa)
        {
            InitializeComponent();
            pasaje = _pasa;
        }
    }
}
