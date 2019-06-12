using System;
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
namespace FrbaCrucero.AbmRecorrido
{
    public partial class ModificacionesRecorrido : Form
    {
        private string rol_nombre;
        private string tipo_ingreso;
        private Recorrido recorrido_modificar;
        List<Tramo> tramosRecorrido; 
        public ModificacionesRecorrido(string rol, Recorrido recorrido_modif, String operacion)
        {
            InitializeComponent();
            rol_nombre = rol;
            tipo_ingreso = operacion;
            recorrido_modificar = recorrido_modif;            
            if (tipo_ingreso != "Modificar")
                modificarRecorrido.Visible = false;            
            List<Tramo> tramos = Recorrido_BD.obtener_todos_tramos();
            foreach (Tramo tra in tramos)
            {                
                if (recorrido_modificar != null && recorrido_modificar.tramos.Any(t => t.id == tra.id))
                {
                    checkedListBoxTramos.Items.Add(tra, CheckState.Checked);
                }
                else
                {
                    checkedListBoxTramos.Items.Add(tra, CheckState.Unchecked);
                }
                checkedListBoxTramos.DisplayMember = "id";
                checkedListBoxTramos.ValueMember = "id";
            }
            if (recorrido_modificar != null)
            {
                tramosRecorrido = obtener_tramos_checkList();
                foreach(Tramo t in tramosRecorrido)
                    comboBoxPuerto.Items.Add(t.id.ToString());
                textBoxCodigoRec.Text = recorrido_modificar.codigo;
                textBoxPrecioRec.Text = calcular_precio_total();
                textBoxDuracionRec.Text = calcular_duracion_total();
            }
        }

        private string calcular_duracion_total()
        {
            decimal duracionTotal = 0;
            foreach(Tramo t in tramosRecorrido)
                duracionTotal += t.duracion;
            return duracionTotal.ToString();
        }

        private string calcular_precio_total()
        {
            decimal precioTotal = 0;
            foreach (Tramo t in tramosRecorrido)
                precioTotal += t.precio;
            return precioTotal.ToString();
        }

        private void checkedListBoxTramos_SelectedIndexChanged(object sender, EventArgs e)
        {
            tramosRecorrido = obtener_tramos_checkList();
            comboBoxPuerto.Items.Clear();
            foreach (Tramo t in tramosRecorrido)
                comboBoxPuerto.Items.Add(t.id.ToString());
            textBoxPrecioRec.Text = calcular_precio_total();
            textBoxDuracionRec.Text = calcular_duracion_total();
        }

        private void ModificacionesRecorrido_Load(object sender, EventArgs e)
        {
            Recorrido_BD.cargar_grilla_tramos(dataGridView1);
        }

        private List<Tramo> obtener_tramos_checkList()
        {
            List<Tramo> tramos = new List<Tramo>();
            foreach (Tramo tra in checkedListBoxTramos.CheckedItems)
            {
                tramos.Add(tra);
            }
            return tramos;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (recorrido_modificar == null)
            {
                nuevo_recorrido();
            }
            else
            {
                modificar_recorrido();
            }            
        }

        private void modificar_recorrido()
        {
            if (comboBoxPuerto.SelectedItem != null)
            {
                List<Tramo> tramos = Recorrido_BD.obtener_todos_tramos();
                foreach (Tramo tra in tramos)
                {
                    if (comboBoxPuerto.SelectedItem.ToString() == tra.id.ToString())
                    {
                        Recorrido recorrido_nuevo = new Recorrido(textBoxCodigoRec.Text.Trim(), tra);
                        recorrido_nuevo.tramos = obtener_tramos_checkList();
                        if (!Recorrido_BD.validar_codigo(recorrido_nuevo.codigo))
                        {
                            MessageBox.Show("El codigo ya existe.", "Recorrido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                        {
                            if (Recorrido_BD.modificar_recorrido(recorrido_nuevo, int.Parse(comboBoxPuerto.SelectedItem.ToString()), recorrido_modificar.tramos))
                            {
                                MessageBox.Show("Recorrido modificado.", tipo_ingreso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                                ABM_Recorrido form = new ABM_Recorrido(rol_nombre);
                                form.Show();
                            }
                            else
                            {
                                MessageBox.Show("Hubo un error proceso " + tipo_ingreso + " recorrido.", "Recorrido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void nuevo_recorrido()
        {
            if(comboBoxPuerto.SelectedItem != null){
                List<Tramo> tramos = Recorrido_BD.obtener_todos_tramos();
                foreach(Tramo tra in tramos)
                {
                    if (comboBoxPuerto.SelectedItem.ToString() == tra.id.ToString())
                    {                       
                        Recorrido recorrido_nuevo = new Recorrido(textBoxCodigoRec.Text.Trim(), tra);
                        recorrido_nuevo.tramos = obtener_tramos_checkList();                        
                        if (!Recorrido_BD.validar_codigo(recorrido_nuevo.codigo))
                        {
                            MessageBox.Show("El codigo ya existe.", "Recorrido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                        {
                            if (Recorrido_BD.agregar_recorrido(recorrido_nuevo, int.Parse(comboBoxPuerto.SelectedItem.ToString())))
                            {
                                MessageBox.Show("Nuevo recorrido creado.", tipo_ingreso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                                ABM_Recorrido form = new ABM_Recorrido(rol_nombre);
                                form.Show();
                            }
                            else
                            {
                                MessageBox.Show("Hubo un error proceso " + tipo_ingreso + " recorrido.", "Recorrido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            ABM_Recorrido form = new ABM_Recorrido(rol_nombre);
            form.Show();
        }     
    }
}
