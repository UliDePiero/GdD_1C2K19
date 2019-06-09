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

namespace FrbaCrucero.AbmCrucero
{
    public partial class ModificacionesCrucero : Form
    {
        private string tipo_ingreso;
        private Crucero cruc_modificar;

        public ModificacionesCrucero(String operacion, Crucero cruc_modif)
        {
            InitializeComponent();
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
            List<TipoCabina> cabinas = Crucero_BD.obtener_todas_cabinas();
            foreach (TipoCabina cab in cabinas)
            {
                if (cruc_modificar != null && cruc_modificar.Cabinas.Any(c => c.tipo.id == cab.id))
                {
                    checkedListBox2.Items.Add(cab, CheckState.Checked);
                }
                else
                {
                    checkedListBox2.Items.Add(cab, CheckState.Unchecked);
                }
                checkedListBox2.DisplayMember = "nombre";                
                checkedListBox2.ValueMember = "id";
            }
            if (cruc_modificar != null)
            {
                textBoxCrucero.Text = cruc_modificar.identificador;
                textBoxModelo.Text = cruc_modificar.modelo.nombre;
                numericUpDown1.Value = cruc_modificar.cabinas;
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

        private List<Cabina> obtener_cabinas_checkList(int cruc_id)
        {
            List<TipoCabina> tipoCabinas = new List<TipoCabina>();
            foreach (TipoCabina tCab in checkedListBox2.CheckedItems)
            {
                tipoCabinas.Add(tCab);
            }
            List<Cabina> cabinas = new List<Cabina>();
            foreach (TipoCabina tCab in tipoCabinas)
            {
                Cabina cabina = new Cabina(tCab, cruc_id);
                cabinas.Add(cabina);
            }
            return cabinas;
        }

        private void nuevo_crucero()
        {
            Crucero crucero_nuevo = new Crucero(textBoxCrucero.Text, Crucero_BD.obtener_marca_con_nombre(comboBoxMarcas.SelectedText), Crucero_BD.obtener_modelo_con_nombre(textBoxModelo.Text), obtener_cabinas_checkList(cruc_modificar.id), obtener_servicios_checkList(), int.Parse(numericUpDown1.Value.ToString()));
            if (Crucero_BD.agregar_crucero(crucero_nuevo))
            {
                MessageBox.Show("Nuevo crucero creado.", tipo_ingreso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                ABM_Crucero form = new ABM_Crucero();
                form.Show();
            }
            else
            {
                MessageBox.Show("Hubo un error proceso " + tipo_ingreso, " crucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    

        private void modificar_crucero()
        {
            Crucero crucero_nuevo = new Crucero(textBoxCrucero.Text, Crucero_BD.obtener_marca_con_nombre(comboBoxMarcas.SelectedText), Crucero_BD.obtener_modelo_con_nombre(textBoxModelo.Text), obtener_cabinas_checkList(cruc_modificar.id), obtener_servicios_checkList(), int.Parse(numericUpDown1.Value.ToString()));
            crucero_nuevo.id = cruc_modificar.id;
            if (Crucero_BD.modificar_crucero(crucero_nuevo, crucero_nuevo.Cabinas, crucero_nuevo.servicios))
            {
                MessageBox.Show("Crucero modificado.", tipo_ingreso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                ABM_Crucero form = new ABM_Crucero();
                form.Show();
            }
            else
            {
                MessageBox.Show("Hubo un error proceso " + tipo_ingreso, " crucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ABM_Crucero form = new ABM_Crucero();
            form.Show();
        }
    }
}
