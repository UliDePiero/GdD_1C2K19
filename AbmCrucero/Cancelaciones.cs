﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.Clases;
using FrbaCrucero.BD_y_Querys;

namespace FrbaCrucero.AbmCrucero
{
    public partial class Cancelaciones : Form
    {
        Crucero crucero;
        public Cancelaciones(Crucero cruc)
        {
            InitializeComponent();
            crucero = cruc;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (descripcion.Text != "")
            {
                Crucero_BD.cancelar_viajes(crucero, descripcion.Text);
                this.Close();
            }
            else
                MessageBox.Show("Le falta completar el motivo.", "Registro baja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
