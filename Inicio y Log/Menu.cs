using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FrbaCrucero.AbmCrucero;
using FrbaCrucero.AbmPuerto;
using FrbaCrucero.AbmRecorrido;
using FrbaCrucero.AbmRol;
using FrbaCrucero.CompraPasaje;
using FrbaCrucero.GeneracionViaje;
using FrbaCrucero.ListadoEstadistico;
using FrbaCrucero.PagoReserva;


namespace FrbaCrucero
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ejecutar_Click(object sender, EventArgs e)
        {
            this.Close();
            ABM_Crucero form = new ABM_Crucero();
            form.Show();
            ABM_Puerto form1 = new ABM_Puerto();
            form1.Show();
            ABM_Recorrido form2 = new ABM_Recorrido();
            form2.Show();
            ABM_ROL form3 = new ABM_ROL();
            form3.Show();       
        }

        private void salir_Click(object sender, EventArgs e)
        {
            INICIO inicio = (INICIO)Application.OpenForms["INICIO"];
            inicio.Close();
        }
    }
}
