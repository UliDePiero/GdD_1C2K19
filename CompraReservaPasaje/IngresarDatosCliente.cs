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
        private string doc;
        private Usuario usuario;
        private string ident;

        public IngresarDatosCliente(Datos d)
        {
            InitializeComponent();
            dato = d;
            doc = textBox.Text;
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
           
            DatosCliente_BD.llenar_grilla_clientes(dataGridView1, textBox.Text);
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("No existen datos para el documento indicado. Ingrese sus datos", "Sin registros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            }
                
        }

        private Usuario obtener_usuario_seleccionado()
        {
                                        
            string usua_nombre = dataGridView1.SelectedCells[0].Value.ToString();
            string usua_apellido = dataGridView1.SelectedCells[1].Value.ToString();
            string usua_telefono = dataGridView1.SelectedCells[3].Value.ToString();
            string usua_direccion = dataGridView1.SelectedCells[4].Value.ToString();
            string usua_mail = dataGridView1.SelectedCells[5].Value.ToString();
            DateTime usua_fechaNac = DateTime.Parse(dataGridView1.SelectedCells[6].Value.ToString());

            return new Usuario(usua_nombre, usua_apellido,usua_telefono, usua_direccion, usua_mail, doc, usua_fechaNac);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            usuario = obtener_usuario_seleccionado();
            label1.Text = usuario.nombre;
            label2.Text = usuario.apellido;
            label3.Text = usuario.telefono;
            label4.Text = usuario.direccion;
            label5.Text = usuario.mail;
            label6.Text = usuario.fechaNacimiento.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox.Text == usuario.documento)
            {
                if(label1.Text != usuario.nombre || label2.Text != usuario.apellido || label3.Text != usuario.telefono || label4.Text != usuario.direccion || label5.Text != usuario.mail || label6.Text != usuario.fechaNacimiento.ToString())
                this.Close();
                //DatosCliente_BD.actualizarCliente(label1.Text, label2.Text, label3.Text, label4.Text, label5.Text, label6.Text);
                dato.finalizarTransaccion(DatosCliente_BD.clienteId(usuario));

            }
            else
            {
                MessageBox.Show("No se puede modificar el documento", "Modificacion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
