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
    public partial class ABM_Crucero : Form
    {
        private string operacion_fecha;
        private DateTime fecha_operacion;
        private string rol_nombre;
        private bool inicio;

        public ABM_Crucero(string rol)
        {
            InitializeComponent();
            rol_nombre = rol;
            inicio = true;
        }

        private void ABM_Crucero_Load(object sender, EventArgs e)
        {
            Crucero_BD.cargar_grilla_cruceros(dataGridView1);
            comboBoxIdentificador.SelectedIndex = 0;
            comboBoxMarca.SelectedIndex = 0;
             if (dataGridView1.RowCount == 0){
                 modificarCrucero.Enabled = false;
                 bajaDefCrucero.Enabled = false;                 
                 bajaMomCrucero.Enabled = false;
             }
             List<MarcaCrucero> marcas = Crucero_BD.obtener_todos_marcas();
             List<Crucero> cruceros = Crucero_BD.obtener_todos_cruceros();
             foreach (MarcaCrucero m in marcas)
                 comboBoxMarca.Items.Add(m.nombre);
             foreach (Crucero c in cruceros)
                 comboBoxIdentificador.Items.Add(c.identificador);
             inicio = false;
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
            ModificacionesCrucero form = new ModificacionesCrucero("Nuevo", null, rol_nombre);
            form.Show();
            this.Close();
        }

        private void modificarCrucero_Click(object sender, EventArgs e)
        {
            Crucero cruc_modif = obtener_crucero_seleccionado();
            cruc_modif.Cabinas = Crucero_BD.obtener_Cabinas_con_crucero(cruc_modif.id);
            cruc_modif.servicios = Crucero_BD.obtener_servicios_con_crucero(cruc_modif.id);
            cruc_modif.estados = Crucero_BD.obtener_estados_con_crucero(cruc_modif.id);            
            ModificacionesCrucero form = new ModificacionesCrucero("Modificar", cruc_modif, rol_nombre);
            form.Show();
            this.Close();
        }

        private void modificarCabinas_Click(object sender, EventArgs e)
        {
            Crucero cruc_modif = obtener_crucero_seleccionado();
            cruc_modif.Cabinas = Crucero_BD.obtener_Cabinas_con_crucero(cruc_modif.id);
            ABM_Cabina form = new ABM_Cabina(cruc_modif, rol_nombre);
            form.Show();
            this.Close();
        }

        private void bajaDefCrucero_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            aceptar.Visible = true;
            cancelar.Visible = true;
            operacion_fecha = "Baja definitiva";
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
                MessageBox.Show("Hubo un error en la operacion " + operacion_fecha + " del crucero", "Crucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Hubo un error en la operacion " + operacion_fecha + " del crucero", "Crucero", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void aceptar_Click(object sender, EventArgs e)
        {
            if(fecha_operacion != null)
            {
                Crucero cruc_modif = obtener_crucero_seleccionado();
                switch(operacion_fecha){
                    case "Baja definitiva":
                        bajaDefinitiva(cruc_modif, operacion_fecha);
                        break;
                    case "Baja momentanea":
                        bajaMomentanea(cruc_modif, operacion_fecha);
                        break;          
                }
                Crucero_BD.cargar_grilla_cruceros(dataGridView1);
                dateTimePicker1.Visible = false;
                aceptar.Visible = false;
                cancelar.Visible = false;
            }
            else
                MessageBox.Show("Debe seleccionar una fecha", "Crucero", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
            aceptar.Visible = false;
            cancelar.Visible = false;
        }

        private void comboBoxIdentificador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!inicio)
                if (comboBoxIdentificador.SelectedIndex == 0 && comboBoxMarca.SelectedIndex == 0)
                    Crucero_BD.cargar_grilla_cruceros(dataGridView1);
                else
                    if (comboBoxMarca.SelectedIndex == 0)
                        Crucero_BD.cargar_grilla_cruceros_identificador(dataGridView1, comboBoxIdentificador.SelectedItem.ToString());
                    else
                        if (comboBoxIdentificador.SelectedIndex == 0)
                            Crucero_BD.cargar_grilla_cruceros_marca(dataGridView1, comboBoxMarca.SelectedItem.ToString());
                        else
                            Crucero_BD.cargar_grilla_cruceros(dataGridView1, comboBoxIdentificador.SelectedItem.ToString(), comboBoxMarca.SelectedItem.ToString());
        }

        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!inicio)
                if (comboBoxIdentificador.SelectedIndex == 0 && comboBoxMarca.SelectedIndex == 0)
                    Crucero_BD.cargar_grilla_cruceros(dataGridView1);
                else
                    if (comboBoxMarca.SelectedIndex == 0)
                        Crucero_BD.cargar_grilla_cruceros_identificador(dataGridView1, comboBoxIdentificador.SelectedItem.ToString());
                    else
                        if (comboBoxIdentificador.SelectedIndex == 0)
                            Crucero_BD.cargar_grilla_cruceros_marca(dataGridView1, comboBoxMarca.SelectedItem.ToString());
                        else
                            Crucero_BD.cargar_grilla_cruceros(dataGridView1, comboBoxIdentificador.SelectedItem.ToString(), comboBoxMarca.SelectedItem.ToString());
        }

        private void dateTimePickerAlta_ValueChanged(object sender, EventArgs e)
        {
            Crucero_BD.cargar_grilla_cruceros_con_alta(dataGridView1, dateTimePickerAlta.Value);
        }

        private void dateTimePickerBajaM_ValueChanged(object sender, EventArgs e)
        {
            Crucero_BD.cargar_grilla_cruceros_con_bajaM(dataGridView1, dateTimePickerBajaM.Value);
        }

        private void dateTimePickerBajaD_ValueChanged(object sender, EventArgs e)
        {
            Crucero_BD.cargar_grilla_cruceros_con_bajaD(dataGridView1, dateTimePickerBajaD.Value);
        }

        private void mostrarBajaDef_Click(object sender, EventArgs e)
        {
            Crucero_BD.cargar_grilla_cruceros_con_bajaD(dataGridView1);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            Crucero_BD.cargar_grilla_cruceros(dataGridView1);
            comboBoxIdentificador.SelectedIndex = 0;
            comboBoxMarca.SelectedIndex = 0;            
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
