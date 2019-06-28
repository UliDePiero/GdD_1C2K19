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

namespace FrbaCrucero.AbmPuerto
{
    public partial class ABM_Puerto : Form
    {
        private string rol_nombre;
        private bool inicio;
        private string operacion;
        public ABM_Puerto(string rol)
        {
            InitializeComponent();
            rol_nombre = rol;
            inicio = true;
        }

        private void ABM_Puerto_Load(object sender, EventArgs e)
        {
            Puerto_BD.cargar_grilla_puertos(dataGridView1);
            comboBoxPuertos.SelectedIndex = 0;
            inicio = false;
        }

        private void comboBoxPuertos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!inicio)                
                switch(comboBoxPuertos.SelectedIndex){
                    case 0:
                        Puerto_BD.cargar_grilla_puertos(dataGridView1);
                        break;
                    case 1:
                        Puerto_BD.cargar_grilla_puertos_recorridos(dataGridView1);
                        break;
                    case 2:
                        Puerto_BD.cargar_grilla_puertos_viajes(dataGridView1);
                        break;
                    case 3:
                        Puerto_BD.cargar_grilla_puertos_no_recorridos(dataGridView1);
                        break;
                    case 4:
                        Puerto_BD.cargar_grilla_puertos_no_viajes(dataGridView1);
                        break;
                }
            if (dataGridView1.RowCount == 0)
            {
                modificarPuerto.Enabled = false;
                eliminarPuerto.Enabled = false;
            }
            else
            {
                modificarPuerto.Enabled = true;
                eliminarPuerto.Enabled = true;
            }
        }

        private Puerto obtener_puerto_seleccionado()
        {
            int puer_id = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            string puer_nombre = dataGridView1.SelectedCells[1].Value.ToString();

            return new Puerto(puer_id, puer_nombre.Trim());
        }

        private void nuevoPuerto_Click(object sender, EventArgs e)
        {
            nombre.Visible = true;
            nombrePuerto.Visible = true;
            aceptar.Visible = true;
            cancelar.Visible = true;
            operacion = "Nuevo";
        }

        private void modificarPuerto_Click(object sender, EventArgs e)
        {
            nombre.Visible = true;
            nombrePuerto.Visible = true;
            aceptar.Visible = true;
            cancelar.Visible = true;
            Puerto puerto = obtener_puerto_seleccionado();
            nombrePuerto.Text = puerto.nombre;
            operacion = "Modificar";
        }

        private void eliminarPuerto_Click(object sender, EventArgs e)
        {
            Puerto puerto = obtener_puerto_seleccionado();
            DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar definitivamente el puerto: "+puerto.nombre+" ?", "Eliminar Puerto", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Puerto_BD.eliminar_puerto(puerto);                
                Puerto_BD.cargar_grilla_puertos(dataGridView1);
                comboBoxPuertos.SelectedIndex = 0;
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            
        }

        private void aceptar_Click(object sender, EventArgs e)
        {            
            if(operacion == "Nuevo")
            {
                if(nombrePuerto.Text != "")
                {
                    if(Puerto_BD.validar_nombre(nombrePuerto.Text))
                        Puerto_BD.nuevo_puerto(nombrePuerto.Text);
                    else
                    {
                        MessageBox.Show("Ya existe un puerto con ese nombre.", "Puerto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Le faltan ingresar campos.", "Puerto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                if(Puerto_BD.validar_nombre(nombrePuerto.Text))
                {
                    Puerto puerto = obtener_puerto_seleccionado();
                    Puerto_BD.modificar_puerto(nombrePuerto.Text, puerto);
                }
                else
                {
                    MessageBox.Show("Ya existe un puerto con ese nombre.", "Puerto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            nombre.Visible = false;
            nombrePuerto.Visible = false;
            aceptar.Visible = false;
            cancelar.Visible = false;
            Puerto_BD.cargar_grilla_puertos(dataGridView1);
            comboBoxPuertos.SelectedIndex = 0;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            nombre.Visible = false;
            nombrePuerto.Visible = false;
            aceptar.Visible = false;
            cancelar.Visible = false;
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
