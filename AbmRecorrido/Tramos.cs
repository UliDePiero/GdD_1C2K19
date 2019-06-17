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

namespace FrbaCrucero.AbmRecorrido
{
    public partial class Tramos : Form
    {
        private string rol_nombre;
        private string operacion;

        public Tramos(string rol_nombre)
        {
            InitializeComponent();
            this.rol_nombre = rol_nombre;
            cargar_grilla();
            foreach (Puerto p in Puerto_BD.obtener_todos_puertos())
            {
                comboBoxOrigen.Items.Add(p.nombre);
                comboBoxDestino.Items.Add(p.nombre);
            }
        }

        private void cargar_grilla()
        {
            Recorrido_BD.cargar_grilla_tramos(dataGridView1);
        }

        private Tramo obtener_tramo_seleccionado()
        {
            int tramo_id = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            decimal tramo_precio = decimal.Parse(dataGridView1.SelectedCells[1].Value.ToString());
            decimal tramo_duracion = decimal.Parse(dataGridView1.SelectedCells[2].Value.ToString());
            string puerto_origen = dataGridView1.SelectedCells[3].Value.ToString();
            string puerto_destino = dataGridView1.SelectedCells[4].Value.ToString();
            Tramo tramo = new Tramo(tramo_id, tramo_precio, tramo_duracion, Puerto_BD.obtener_puerto_con_nombre(puerto_origen), Puerto_BD.obtener_puerto_con_nombre(puerto_destino));

            return tramo;
        }

        private void nuevoTramo_Click(object sender, EventArgs e)
        {
            aceptar.Visible = true;
            cancelar.Visible = true;
            comboBoxOrigen.Visible = true;
            comboBoxDestino.Visible = true;
            puertoOrigen.Visible = true;
            puertoDestino.Visible = true;
            precioLB.Visible = true;
            duracionLB.Visible = true;
            textBoxPrecio.Visible = true;
            textBoxDuracion.Visible = true;
            operacion = "Nuevo";
        }

        private void modificarTramo_Click(object sender, EventArgs e)
        {
            aceptar.Visible = true;
            cancelar.Visible = true;
            precioLB.Visible = true;
            duracionLB.Visible = true;
            textBoxPrecio.Visible = true;
            textBoxDuracion.Visible = true;
            operacion = "Modificar";
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if(operacion == "Nuevo")
            {
                comboBoxOrigen.Visible = false;
                comboBoxDestino.Visible = false;
                puertoOrigen.Visible = false;
                puertoDestino.Visible = false;
                Tramo tramo = new Tramo(decimal.Parse(textBoxPrecio.Text), decimal.Parse(textBoxDuracion.Text), Puerto_BD.obtener_puerto_con_nombre(comboBoxOrigen.SelectedItem.ToString()), Puerto_BD.obtener_puerto_con_nombre(comboBoxDestino.SelectedItem.ToString()));
                Recorrido_BD.agregar_tramo(tramo);
            }
            else
            {
                Tramo tramo = obtener_tramo_seleccionado();
                tramo.precio = decimal.Parse(textBoxPrecio.Text);
                tramo.duracion = decimal.Parse(textBoxDuracion.Text);
                Recorrido_BD.modificar_tramo(tramo);
            }
            precioLB.Visible = false;
            duracionLB.Visible = false;
            textBoxPrecio.Visible = false;
            textBoxDuracion.Visible = false;
            aceptar.Visible = false;
            cancelar.Visible = false;
            textBoxPrecio.Text = "";
            textBoxDuracion.Text = "";
            cargar_grilla();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            comboBoxOrigen.Visible = false;
            comboBoxDestino.Visible = false;
            puertoOrigen.Visible = false;
            puertoDestino.Visible = false;
            precioLB.Visible = false;
            duracionLB.Visible = false;
            textBoxPrecio.Visible = false;
            textBoxDuracion.Visible = false;
            aceptar.Visible = false;
            cancelar.Visible = false;
            textBoxPrecio.Text = "";
            textBoxDuracion.Text = "";
        }

        private void atras_Click(object sender, EventArgs e)
        {
            ABM_Recorrido form = new ABM_Recorrido(rol_nombre);
            form.Show();
            this.Close();
        }
    }
}
