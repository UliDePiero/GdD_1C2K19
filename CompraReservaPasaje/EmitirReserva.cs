using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class EmitirReserva : Form
    {
        string codigo;
        public EmitirReserva(string _cod)
        {
            InitializeComponent();
            textBox1.Text = _cod;
            textBox1.Enabled = false;
        }

        private void identificadorCrucero_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmitirReserva_Load(object sender, EventArgs e)
        {

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            ReservaForm ReservaForm = (ReservaForm)Application.OpenForms["ReservaForm"];
            ReservaForm.Show();
        }


    }
}
