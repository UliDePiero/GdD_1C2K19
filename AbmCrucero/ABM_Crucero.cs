﻿using System;
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

namespace FrbaCrucero.AbmCrucero
{
    public partial class ABM_Crucero : Form
    {
        private string operacion_fecha;
        private DateTime fecha_operacion;

        public ABM_Crucero()
        {
            InitializeComponent();
        }

        private void ABM_Crucero_Load(object sender, EventArgs e)
        {
            Crucero_BD.cargar_grilla_cruceros(dataGridView1);
             if (dataGridView1.RowCount == 0){
                 modificarCrucero.Enabled = false;
                 bajaDefCrucero.Enabled = false;
                 altaCrucero.Enabled = false;
                 bajaMomCrucero.Enabled = false;
             }
        }

        private Crucero obtener_crucero_seleccionado()
        {           
            int cru_id = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            string cru_identificador = dataGridView1.SelectedCells[1].Value.ToString();
            string cru_marca = dataGridView1.SelectedCells[2].Value.ToString();
            string cru_modelo = dataGridView1.SelectedCells[3].Value.ToString();            
            int cru_cabinas = int.Parse(dataGridView1.SelectedCells[7].Value.ToString());

            return new Crucero(cru_id, cru_identificador, Crucero_BD.obtener_marca_con_nombre(cru_marca), Crucero_BD.obtener_modelo_con_nombre(cru_modelo), cru_cabinas);
        }

        private void nuevoCrucero_Click(object sender, EventArgs e)
        {
            this.Close();
            ModificacionesCrucero form = new ModificacionesCrucero("Nuevo", null);
            form.Show();
        }

        private void modificarCrucero_Click(object sender, EventArgs e)
        {
            Crucero cruc_modif = obtener_crucero_seleccionado();
            cruc_modif.Cabinas = Crucero_BD.obtener_Cabinas_con_crucero(cruc_modif.id);
            cruc_modif.servicios = Crucero_BD.obtener_servicios_con_crucero(cruc_modif.id);
            cruc_modif.estados = Crucero_BD.obtener_estados_con_crucero(cruc_modif.id);
            this.Close();
            ModificacionesCrucero form = new ModificacionesCrucero("Modificar", cruc_modif);
            form.Show();
        }

        private void bajaDefCrucero_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            aceptar.Visible = true;
            cancelar.Visible = true;
            operacion_fecha = "Baja definitiva";
        }

        private void altaCrucero_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            aceptar.Visible = true;
            cancelar.Visible = true;
            operacion_fecha = "Alta";
        }

        private void bajaMomCrucero_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            aceptar.Visible = true;
            cancelar.Visible = true;
            operacion_fecha = "Baja momentanea";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fecha_operacion = DateTime.Parse(dateTimePicker1.Value.ToString());
        }

        private void bajaDefinitiva(Crucero crucero, string operacion_fecha)
        {
            if (Crucero_BD.baja_definitiva(crucero, fecha_operacion))
            {
                MessageBox.Show("Crucero dado de baja definitivamente.", operacion_fecha, MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else
            {
                MessageBox.Show("Hubo un error en la operacion " + operacion_fecha, " del crucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bajaMomentanea(Crucero crucero, string operacion_fecha)
        {
            if (Crucero_BD.baja_momentanea(crucero, fecha_operacion))
            {
                MessageBox.Show("Crucero dado de baja momentaneamente.", operacion_fecha, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error en la operacion " + operacion_fecha, " del crucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alta(Crucero crucero, string operacion_fecha)
        {
            if (Crucero_BD.alta(crucero, fecha_operacion))
            {
                MessageBox.Show("Crucero programado a dar de alta.", operacion_fecha, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error en la operacion " + operacion_fecha, " del crucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void aceptar_Click(object sender, EventArgs e)
        {
            Crucero cruc_modif = obtener_crucero_seleccionado();
            switch(operacion_fecha){
                case "Baja definitiva":
                    bajaDefinitiva(cruc_modif, operacion_fecha);
                    break;
                case "Baja momentanea":
                    bajaMomentanea(cruc_modif, operacion_fecha);
                    break;
                case "Alta":
                    alta(cruc_modif, operacion_fecha);
                    break;           
            }
            Crucero_BD.cargar_grilla_cruceros(dataGridView1);
            dateTimePicker1.Visible = false;
            aceptar.Visible = false;
            cancelar.Visible = false;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
            aceptar.Visible = false;
            cancelar.Visible = false;
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu form = new Menu();
            form.Show();
        }
    }
}
