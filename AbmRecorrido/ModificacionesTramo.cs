using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRecorrido
{
    public partial class ModificacionesTramo : Form
    {
        public ModificacionesTramo()
        {
            InitializeComponent();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
            ABM_Tramo form = new ABM_Tramo();
            form.Show();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            ABM_Tramo form = new ABM_Tramo();
            form.Show();
        }
    }
}
