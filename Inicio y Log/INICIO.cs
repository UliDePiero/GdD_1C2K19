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
using FrbaCrucero.CompraReservaPasaje;

namespace FrbaCrucero
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        private void ingresar_Click(object sender, EventArgs e)
        {      
            this.Hide();
            Login form = new Login();
            form.Show();
        }

        private void compraReserva_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservar form6 = new Reservar("Cliente");
            form6.Show();
        }

        private void pagoReserva_Click(object sender, EventArgs e)
        {
            this.Hide();
            PagarReserva form7 = new PagarReserva("Cliente");
            form7.Show();
        }

    }
}
