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

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class IngresarDatosCliente : Form
    {
        private Datos dato;
        private Usuario usuario;
        private string ident;
        private int cantPasajes;
        private int registrado;
        private string doc;

        public IngresarDatosCliente(Datos d, int _cantidad)
        {
            InitializeComponent();
            dato = d;
//          doc = textBox.Text;
            cantPasajes = _cantidad;
        }


        private void IngresarDatosCliente_Load(object sender, EventArgs e)
        {

        }

        private void identificadorCrucero_Click(object sender, EventArgs e)
        {

        }

        private void listViewCabinas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buscarCliente_Click(object sender, EventArgs e)
        {
            doc = textBox.Text;
            DatosCliente_BD.llenar_grilla_clientes(dataGridView1, textBox.Text);
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("No existen datos para el documento indicado. Ingrese sus datos", "Sin registros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            textBox.Enabled = false;

        }

        private Usuario obtener_usuario_seleccionado()
        {
                                        
            string usua_nombre = dataGridView1.SelectedCells[0].Value.ToString();
            string usua_apellido = dataGridView1.SelectedCells[1].Value.ToString();
            string usua_telefono = dataGridView1.SelectedCells[2].Value.ToString();
            string usua_direccion = dataGridView1.SelectedCells[3].Value.ToString();
            string usua_mail = dataGridView1.SelectedCells[4].Value.ToString();
            string usua_fechaNac = dataGridView1.SelectedCells[5].Value.ToString();

            return new Usuario(usua_nombre, usua_apellido,usua_telefono, usua_direccion, usua_mail, doc, usua_fechaNac);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            usuario = obtener_usuario_seleccionado();
            textBox1.Text = usuario.nombre;
            textBox2.Text = usuario.apellido;
            textBox3.Text = usuario.telefono;
            textBox4.Text = usuario.direccion;
            textBox5.Text = usuario.mail;
            dateTimePicker2.Value = DateTime.Parse(usuario.fechaNacimiento);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ReservaForm ReservaForm1 = (ReservaForm)Application.OpenForms["ReservaForm"];
            ReservaForm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells[0] == null || dataGridView1.RowCount == 0)
            {
                registrado = 0;
            }
            else
                registrado = 1;

            if (textBox.Text == null || textBox1.Text == null || textBox2.Text == null || textBox3.Text == null || textBox4.Text == null || textBox5.Text == null)
            {
                MessageBox.Show("Faltan completar datos", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (textBox1.Text != usuario.nombre || textBox2.Text != usuario.apellido || textBox3.Text != usuario.telefono || textBox4.Text != usuario.direccion || textBox5.Text != usuario.mail || dateTimePicker2.Value != DateTime.Parse(usuario.fechaNacimiento))
                DatosCliente_BD.actualizarCliente(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, dateTimePicker2.Value.ToString());
            
            if(registrado == 0)
            {
                DatosCliente_BD.registrarCliente(textBox.Text,textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, dateTimePicker2.Value.ToString());
            }
            this.Close();

            dato.finalizarTransaccion(DatosCliente_BD.clienteId(usuario), cantPasajes);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            textBox.Clear();
            textBox.Enabled = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            dateTimePicker2.Value = DateTime.Now;
        }
    }
}
