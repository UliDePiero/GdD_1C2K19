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
        private string pasaje;
        public EmitirPago(string _pasa)
        {
            InitializeComponent();
            textBox1.Text = _pasa;
            textBox1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
                INICIO inicio = (INICIO)Application.OpenForms["INICIO"];
                inicio.Show();
                this.Close();
        }
    }
}
