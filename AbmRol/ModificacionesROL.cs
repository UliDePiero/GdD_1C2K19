﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRol
{
    public partial class ModificacionesROL : Form
    {
        public ModificacionesROL()
        {
            InitializeComponent();
        }

        private void ModificacionesROL_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
            ABM_ROL form = new ABM_ROL();
            form.Show();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            ABM_ROL form = new ABM_ROL();
            form.Show();
        }
    }
}
