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
    public partial class PagarReserva : Form
    {
        private string rol_nombre;

        public PagarReserva(string rol)
        {
            InitializeComponent();
            rol_nombre = rol;
        }
    }
}
