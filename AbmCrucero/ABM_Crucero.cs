using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero
{
    public partial class ABM_Crucero : Form
    {
        public ABM_Crucero()
        {
            InitializeComponent();
        }

        private void ABM_Crucero_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2019DataSet.Maestra' table. You can move, or remove it, as needed.
            this.maestraTableAdapter.Fill(this.gD1C2019DataSet.Maestra);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
