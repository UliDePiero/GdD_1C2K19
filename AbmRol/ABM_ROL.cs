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

namespace FrbaCrucero.AbmRol
{
    public partial class ABM_ROL : Form
    {


        public ABM_ROL()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ROL_BD.cargar_grilla_roles(dataGridView1);
            if (dataGridView1.RowCount != 0)
            {
                ROL_BD.cargar_grilla_funcionalidades(dataGridView2, obtener_rol_seleccionado());
                habilitar_desRol.Enabled = true;
                modificarRol.Enabled = true;
                mostrar_ocuRol.Enabled = true;
            }
            else
            {
                habilitar_desRol.Enabled = false;
                modificarRol.Enabled = false;
                mostrar_ocuRol.Enabled = false;
                dataGridView2.DataSource = null;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ROL_BD.cargar_grilla_funcionalidades(dataGridView2, obtener_rol_seleccionado());
        } 

        private ROL obtener_rol_seleccionado()
        {
            //bool rol_habilitado = bool.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            int rol_id = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            string rol_nombre = dataGridView1.SelectedCells[1].Value.ToString();            

            //return new ROL(rol_id, rol_nombre, rol_habilitado);
            return new ROL(rol_id, rol_nombre, true);
        }

        private List<Funcionalidad> obtener_funcionalidades()
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                int func_id = int.Parse(row.Cells[0].Value.ToString());
                string func_nombre = row.Cells[1].Value.ToString();
                Funcionalidad func = new Funcionalidad(func_id, func_nombre);
                funcionalidades.Add(func);
            }
            return funcionalidades;
        }

        private void nuevoRol_Click(object sender, EventArgs e)
        {
            this.Close();
            ModificacionesROL form = new ModificacionesROL("Nuevo", null);
            form.Show();
        }

        private void modificarRol_Click(object sender, EventArgs e)
        {           
            ROL rol_modif = obtener_rol_seleccionado();
            rol_modif.funcionalidades = obtener_funcionalidades();
            this.Close();
            ModificacionesROL form = new ModificacionesROL("Modificar", rol_modif);
            form.Show();
        }

        private void habilitar_desRol_Click(object sender, EventArgs e)
        {

        }

        private void mostrar_ocuRol_Click(object sender, EventArgs e)
        {

        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu form = new Menu();
            form.Show();
        }
        
    }
}
