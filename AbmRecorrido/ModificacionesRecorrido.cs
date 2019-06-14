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
        private Recorrido recorrido_nuevo;
        List<Tramo> tramosRecorrido;
        public ModificacionesRecorrido(string rol, Recorrido recorrido_modif, String operacion)
        {
            InitializeComponent();
            rol_nombre = rol;
            tipo_ingreso = operacion;
            recorrido_modificar = recorrido_modif;
            tramosRecorrido = new List<Tramo>();
            if (tipo_ingreso != "Modificar")
                modificarRecorrido.Visible = false;
            foreach (Puerto p in Puerto_BD.obtener_todos_puertos())
            {
                comboBoxPuerto.Items.Add(p.nombre);
            }
            if (recorrido_modificar != null)
            {
                listViewViejos.Visible = true;
                tramosPrevios.Visible = true;
                string[] arr = new string[3];
                ListViewItem itm;
                foreach (Tramo t in recorrido_modificar.tramos)
                {                    
                    arr[0] = t.id.ToString();
                    arr[1] = t.origen.nombre;
                    arr[2] = t.destino.nombre;
                    itm = new ListViewItem(arr);
                    listViewViejos.Items.Add(itm);
                    tramosRecorrido.Add(t);
                }                               
                textBoxCodigoRec.Text = recorrido_modificar.codigo;
                textBoxPrecioRec.Text = "$"+calcular_precio_total();
                textBoxDuracionRec.Text = calcular_duracion_total()+" horas";
            }
        }

        private string calcular_duracion_total()
        {
            int duracionTotal = 0;
            foreach(Tramo t in tramosRecorrido)
                duracionTotal += (int)t.duracion;
            return duracionTotal.ToString();
        }

        private string calcular_precio_total()
        {
            int precioTotal = 0;
            foreach (Tramo t in tramosRecorrido)
                precioTotal += (int)t.precio;
            return precioTotal.ToString();
        }

        private void ModificacionesRecorrido_Load(object sender, EventArgs e)
        {
            Recorrido_BD.cargar_grilla_tramos(dataGridView1);
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
            if (recorrido_nuevo == null)
                recorrido_nuevo = new Recorrido(recorrido_modificar.id, textBoxCodigoRec.Text, recorrido_modificar.primerTramo);
              
            recorrido_nuevo.tramos = tramosRecorrido;                
            if (recorrido_modificar.codigo != recorrido_nuevo.codigo && !Recorrido_BD.validar_codigo(recorrido_nuevo.codigo))
            {
                MessageBox.Show("El codigo ya existe.", "Recorrido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Recorrido_BD.modificar_recorrido(recorrido_nuevo, recorrido_nuevo.primerTramo.id, recorrido_modificar.tramos))
                {
                    MessageBox.Show("Recorrido modificado.", tipo_ingreso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    ABM_Recorrido form = new ABM_Recorrido(rol_nombre);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Hubo un error proceso " + tipo_ingreso + " recorrido.", "Recorrido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void nuevo_recorrido()
        {
            if (recorrido_nuevo != null)
            {
                recorrido_nuevo.tramos = tramosRecorrido;
                if (!Recorrido_BD.validar_codigo(recorrido_nuevo.codigo))
                {
                    MessageBox.Show("El codigo ya existe.", "Recorrido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Recorrido_BD.agregar_recorrido(recorrido_nuevo, recorrido_nuevo.primerTramo.id))
                    {
                        MessageBox.Show("Nuevo recorrido creado.", tipo_ingreso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        ABM_Recorrido form = new ABM_Recorrido(rol_nombre);
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error proceso " + tipo_ingreso + " recorrido.", "Recorrido", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void comboBoxPuerto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(recorrido_nuevo != null){                
                recorrido_nuevo.tramos.Clear();                
                tramosRecorrido.Clear();
            }            
            Recorrido_BD.cargar_grilla_tramos(dataGridView1, Puerto_BD.obtener_IDpuerto_con_nombre(comboBoxPuerto.SelectedItem.ToString()));
            listViewNuevos.Items.Clear();            
            textBoxPrecioRec.Text = "$0";
            textBoxDuracionRec.Text = "";
            agregarTramo.Visible = true;
            vaciarLista.Visible = true;
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

        private void agregarTramo_Click(object sender, EventArgs e)
        {            
            Tramo tramo = obtener_tramo_seleccionado();
            if (recorrido_nuevo == null)
            {                                
                if(recorrido_modificar != null){
                    recorrido_nuevo = new Recorrido(recorrido_modificar.id,recorrido_modificar.codigo, tramo);
                    tramosRecorrido.Clear();
                }
                else
                    recorrido_nuevo = new Recorrido(textBoxCodigoRec.Text, tramo);
            }
            bool esta = false;
            foreach (Tramo t in tramosRecorrido)
                if (t.id == tramo.id || t.origen.id == tramo.origen.id || t.destino.id == tramo.destino.id || (t.origen.id == tramo.destino.id && recorrido_nuevo.primerTramo.origen.id != tramo.destino.id))
                    esta = true;
            
            if(!esta){
                string[] arr = new string[3];
                ListViewItem itm;                        
                arr[0] = tramo.id.ToString();
                arr[1] = tramo.origen.nombre;
                arr[2] = tramo.destino.nombre;
                itm = new ListViewItem(arr);
                listViewNuevos.Items.Add(itm);
                tramosRecorrido.Add(tramo);
                textBoxPrecioRec.Text = "$" + calcular_precio_total();
                textBoxDuracionRec.Text = calcular_duracion_total() + " horas";
                Recorrido_BD.cargar_grilla_tramos(dataGridView1, tramo.destino.id);
            }
        }

        private void vaciarLista_Click(object sender, EventArgs e)
        {
            listViewNuevos.Items.Clear();
            tramosRecorrido.Clear();
            textBoxPrecioRec.Text = "$";
            textBoxDuracionRec.Text = "";
        }
    
    }
}
