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
    public partial class ABM_Recorrido : Form
    {
        private string rol_nombre;
        private bool inicio;
        private bool mostrar;        

        public ABM_Recorrido(string rol)
        {
            InitializeComponent();
            rol_nombre = rol;
            inicio = true;
            mostrar = false;            
        }

        private void ABM_Recorrido_Load(object sender, EventArgs e)
        {
            Recorrido_BD.cargar_grilla_recorridos(dataGridView1);
            comboBoxOrigen.SelectedIndex = 0;
            comboBoxDestino.SelectedIndex = 0;
            List<Puerto> puertos = Puerto_BD.obtener_todos_puertos();
            foreach(Puerto p in puertos){
                comboBoxOrigen.Items.Add(p.nombre);
                comboBoxDestino.Items.Add(p.nombre);
            }
            inicio = false;
        }

        private Recorrido obtener_recorrido_seleccionado()
        {
            int recorrido_id = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            string recorrido_codigo = dataGridView1.SelectedCells[1].Value.ToString();
            bool recorrido_habilitado = bool.Parse(dataGridView1.SelectedCells[4].Value.ToString());
            Tramo primerTramo = Recorrido_BD.obtener_primer_tramo(recorrido_id);
                        
            return new Recorrido(recorrido_id, recorrido_codigo, primerTramo, recorrido_habilitado);
        }

        private void nuevoRecorrido_Click(object sender, EventArgs e)
        {            
            ModificacionesRecorrido form = new ModificacionesRecorrido(rol_nombre, null, "Nuevo");
            form.Show();
            this.Close();
        }

        private void modificarRecorrido_Click(object sender, EventArgs e)
        {
            Recorrido recorrido_modif = obtener_recorrido_seleccionado();
            recorrido_modif.tramos = Recorrido_BD.obtener_tramos_recorrido(recorrido_modif);
            ModificacionesRecorrido form = new ModificacionesRecorrido(rol_nombre, recorrido_modif, "Modificar");
            form.Show();
            this.Close();
        }

        private void eliminarRecorridos_Click(object sender, EventArgs e)
        {
            Recorrido recorrido_modif = obtener_recorrido_seleccionado();
            if(recorrido_modif.habilitado == true)
            {
                if(Recorrido_BD.tiene_pasajes_vendidos(recorrido_modif))
                {
                    MessageBox.Show("Existen viajes sin realizar con pasajes vendidos para el recorrido seleccionado. No se puede inhabilitar.", "Recorrido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                    Recorrido_BD.inhabilitar_recorrido(recorrido_modif);
            }
            else
                Recorrido_BD.habilitar_recorrido(recorrido_modif);            
            if (mostrar == true)            
                Recorrido_BD.cargar_grilla_recorridos(dataGridView1, mostrar);            
            else            
                Recorrido_BD.cargar_grilla_recorridos(dataGridView1);
            comboBoxOrigen.SelectedIndex = 0;
            comboBoxDestino.SelectedIndex = 0;
        }

        private void editarTramos_Click(object sender, EventArgs e)
        {
            Tramos form = new Tramos(rol_nombre);
            form.Show();
            this.Close();
        }

        private void comboBoxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!inicio)
                if (mostrar == true)
                {
                    if(comboBoxOrigen.SelectedIndex == 0 && comboBoxDestino.SelectedIndex == 0)
                        Recorrido_BD.cargar_grilla_recorridos(dataGridView1, mostrar);
                    else
                    if (comboBoxOrigen.SelectedIndex == 0)
                        Recorrido_BD.cargar_grilla_recorridos_destino(dataGridView1, comboBoxDestino.SelectedItem.ToString(), mostrar);
                    else
                        if (comboBoxDestino.SelectedIndex == 0)
                            Recorrido_BD.cargar_grilla_recorridos_origen(dataGridView1, comboBoxOrigen.SelectedItem.ToString(), mostrar);
                        else
                            Recorrido_BD.cargar_grilla_recorridos(dataGridView1, comboBoxOrigen.SelectedItem.ToString(), comboBoxDestino.SelectedItem.ToString(), mostrar);
                }
                else
                {
                 if(comboBoxOrigen.SelectedIndex == 0 && comboBoxDestino.SelectedIndex == 0)
                        Recorrido_BD.cargar_grilla_recorridos(dataGridView1);
                    else
                    if (comboBoxOrigen.SelectedIndex == 0)
                        Recorrido_BD.cargar_grilla_recorridos_destino(dataGridView1, comboBoxDestino.SelectedItem.ToString());
                    else
                        if (comboBoxDestino.SelectedIndex == 0)
                            Recorrido_BD.cargar_grilla_recorridos_origen(dataGridView1, comboBoxOrigen.SelectedItem.ToString());
                        else
                            Recorrido_BD.cargar_grilla_recorridos(dataGridView1, comboBoxOrigen.SelectedItem.ToString(), comboBoxDestino.SelectedItem.ToString());
                }
        }

        private void comboBoxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!inicio)
                if (mostrar == true)
                {
                    if (comboBoxOrigen.SelectedIndex == 0 && comboBoxDestino.SelectedIndex == 0)
                        Recorrido_BD.cargar_grilla_recorridos(dataGridView1, mostrar);
                    else
                        if (comboBoxDestino.SelectedIndex == 0)
                            Recorrido_BD.cargar_grilla_recorridos_origen(dataGridView1, comboBoxOrigen.SelectedItem.ToString(), mostrar);
                        else
                            if (comboBoxOrigen.SelectedIndex == 0)
                                Recorrido_BD.cargar_grilla_recorridos_destino(dataGridView1, comboBoxDestino.SelectedItem.ToString(), mostrar);
                            else
                                Recorrido_BD.cargar_grilla_recorridos(dataGridView1, comboBoxOrigen.SelectedItem.ToString(), comboBoxDestino.SelectedItem.ToString(), mostrar);
                }
                else
                {
                    if (comboBoxOrigen.SelectedIndex == 0 && comboBoxDestino.SelectedIndex == 0)
                        Recorrido_BD.cargar_grilla_recorridos(dataGridView1);
                    else
                        if (comboBoxDestino.SelectedIndex == 0)
                            Recorrido_BD.cargar_grilla_recorridos_origen(dataGridView1, comboBoxOrigen.SelectedItem.ToString());
                        else
                            if (comboBoxOrigen.SelectedIndex == 0)
                                Recorrido_BD.cargar_grilla_recorridos_destino(dataGridView1, comboBoxDestino.SelectedItem.ToString());
                            else
                                Recorrido_BD.cargar_grilla_recorridos(dataGridView1, comboBoxOrigen.SelectedItem.ToString(), comboBoxDestino.SelectedItem.ToString());
                }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrar == true)
            {
                Recorrido_BD.cargar_grilla_recorridos(dataGridView1);
                mostrar = false;                
            }
            else
            {                
                mostrar = true;
                Recorrido_BD.cargar_grilla_recorridos(dataGridView1, mostrar);
            }
            comboBoxOrigen.SelectedIndex = 0;
            comboBoxDestino.SelectedIndex = 0;
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
