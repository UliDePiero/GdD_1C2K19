﻿using System;
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
        private string rol_nombre;
        public ModificacionesTramo(string rol)
        {
            InitializeComponent();
            rol_nombre = rol;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
            ABM_Tramo form = new ABM_Tramo(rol_nombre);
            form.Show();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            ABM_Tramo form = new ABM_Tramo(rol_nombre);
            form.Show();
        }
    }
}
