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
    public partial class ModificacionesCrucero : Form
    {
        private string tipo_ingreso;
        private Crucero cruc_modificar;        
        private string rol_nombre;

        public ModificacionesCrucero(String operacion, Crucero cruc_modif, string rol)
        {
            InitializeComponent();
            rol_nombre = rol;
            this.tipo_ingreso = operacion;
            this.cruc_modificar = cruc_modif;
            if (tipo_ingreso != "Modificar")
                modificarCrucero.Visible = false;
            List<MarcaCrucero> marcas = Crucero_BD.obtener_todos_marcas();
            int marcaID = 0, marca = 0;
            foreach (MarcaCrucero marc in marcas)
            {
                comboBoxMarcas.Items.Add(marc.nombre);
                marcaID++;
                if (cruc_modificar != null && cruc_modificar.marca.id == marc.id){
                    marca = marcaID-1;                                                             
                }
            }
            comboBoxMarcas.SelectedIndex = marca;  
            List<ServicioCrucero> servicios = Crucero_BD.obtener_todos_servicios();
            foreach (ServicioCrucero serv in servicios)
            {
                if (cruc_modificar != null && cruc_modificar.servicios.Any(s => s.id == serv.id))
                {
                    checkedListBox1.Items.Add(serv, CheckState.Checked);
                }
                else
                {
                    checkedListBox1.Items.Add(serv, CheckState.Unchecked);
                }
                checkedListBox1.DisplayMember = "descripcion";
                checkedListBox1.ValueMember = "id";
            }
            List<TipoCabina> tipoCabinas = Crucero_BD.obtener_todas_cabinas();
            string[] arr = new string[3];
            ListViewItem itm;
            foreach (TipoCabina tcab in tipoCabinas)
            {
                comboBoxCabinas.Items.Add(tcab.nombre);
                if (cruc_modificar != null && cruc_modificar.Cabinas.Any(c => c.tipo.id == tcab.id))
                {                                                            
                    arr[0] = tcab.id.ToString();
                    arr[1] = tcab.nombre;
                    arr[2] = Crucero_BD.obtener_cabina_por_tipo_ID(cruc_modificar.id, tcab.id).piso.ToString();                    
                    itm = new ListViewItem(arr);
                    listViewCabinas.Items.Add(itm);                
                }
            }
            if (cruc_modificar != null)
            {
                textBoxCrucero.Text = cruc_modificar.identificador;
                textBoxModelo.Text = cruc_modificar.modelo.nombre;                
            }
        }

        private void agregarCabina_Click(object sender, EventArgs e)
        {
            string[] arr = new string[3];
            ListViewItem itm;
            TipoCabina tipo = Crucero_BD.obtener_tipoCabina_con_nombre(comboBoxCabinas.SelectedItem.ToString());
            int piso = (int) numericUpDownPiso.Value;
            arr[0] = tipo.id.ToString();
            arr[1] = tipo.nombre;
            arr[2] = piso.ToString();
            itm = new ListViewItem(arr);
            listViewCabinas.Items.Add(itm);
        }

        private void sacarCabina_Click(object sender, EventArgs e)
        {
            string[] arr = new string[3];           
            TipoCabina tipo = Crucero_BD.obtener_tipoCabina_con_nombre(comboBoxCabinas.SelectedItem.ToString());
            string piso = numericUpDownPiso.Value.ToString();
            foreach (ListViewItem it in listViewCabinas.Items)
            {
                if (it.SubItems[1].Text == tipo.nombre && it.SubItems[2].Text == piso)
                {
                    it.Remove();
                    break;
                }
            }
        }

        private List<ServicioCrucero> obtener_servicios_checkList()
        {
            List<ServicioCrucero> servicios = new List<ServicioCrucero>();
            foreach (ServicioCrucero serv in checkedListBox1.CheckedItems)
            {
                servicios.Add(serv);
            }
            return servicios;
        }

        private List<Cabina> obtener_cabinas_listView()
        {
            List<TipoCabina> tipoCabinas = new List<TipoCabina>();
            TipoCabina tipo;
            List<Cabina> cabinas = new List<Cabina>();
            Cabina cabina;
            foreach (ListViewItem it in listViewCabinas.Items)
            {
                tipo = Crucero_BD.obtener_tipoCabina_con_ID(int.Parse(it.SubItems[0].Text));
                tipoCabinas.Add(tipo);                
            }
            foreach (ListViewItem it in listViewCabinas.Items)
            {
                foreach (TipoCabina tCab in tipoCabinas)
                {
                    cabina = new Cabina(int.Parse(it.SubItems[2].Text), tCab);
                    cabinas.Add(cabina);
                }                
            }
            return cabinas;
        }

        private void nuevo_crucero()
        {
            Crucero crucero_nuevo = new Crucero(textBoxCrucero.Text, Crucero_BD.obtener_marca_con_nombre(comboBoxMarcas.SelectedItem.ToString()), Crucero_BD.obtener_modelo_con_nombre(textBoxModelo.Text), obtener_cabinas_listView(), obtener_servicios_checkList());
            if (Crucero_BD.validar_identificador(crucero_nuevo.identificador))
            {
                MessageBox.Show("El identificador ya existe.", " Crucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                if (Crucero_BD.agregar_crucero(crucero_nuevo))
                {
                    MessageBox.Show("Nuevo crucero creado.", tipo_ingreso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    ABM_Crucero form = new ABM_Crucero(rol_nombre);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Hubo un error proceso " + tipo_ingreso +" crucero.", "Crucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }    

        private void modificar_crucero()
        {
            Crucero crucero_nuevo = new Crucero(textBoxCrucero.Text, Crucero_BD.obtener_marca_con_nombre(comboBoxMarcas.SelectedItem.ToString()), Crucero_BD.obtener_modelo_con_nombre(textBoxModelo.Text), obtener_cabinas_listView(), obtener_servicios_checkList());
            crucero_nuevo.id = cruc_modificar.id;
            if (Crucero_BD.validar_identificador(crucero_nuevo.identificador))
            {
                MessageBox.Show("El identificador ya existe.", " Crucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                if (Crucero_BD.modificar_crucero(crucero_nuevo, cruc_modificar.Cabinas, cruc_modificar.servicios))
                {
                    MessageBox.Show("Crucero modificado.", tipo_ingreso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    ABM_Crucero form = new ABM_Crucero(rol_nombre);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Hubo un error proceso " + tipo_ingreso + " crucero.", " Crucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }              

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (cruc_modificar == null)
            {
                nuevo_crucero();
            }
            else
            {
                modificar_crucero();
            }
        }       

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            ABM_Crucero form = new ABM_Crucero(rol_nombre);
            form.Show();
        }

    }
}
