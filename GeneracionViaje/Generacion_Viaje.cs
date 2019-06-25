using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.BD_y_Querys;
using FrbaCrucero.Clases;

namespace FrbaCrucero.GeneracionViaje
{
    public partial class Generacion_Viaje : Form
    {
        private string rol_nombre;
        int crucero;
        Recorrido recorrido;
        public Generacion_Viaje(string rol)
        {
            InitializeComponent();
            rol_nombre = rol;
        }

        private void Generacion_Viaje_Load(object sender, EventArgs e)
        {            
            Recorrido_BD.cargar_grilla_recorridos(dataGridView2,true);
            DateTime date = DateTime.Parse(ConfigurationManager.AppSettings["fecha"].ToString());
            date.AddDays(1);
            dateTimePicker1.MinDate = date;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            recorrido = new Recorrido(int.Parse(dataGridView2.SelectedCells[0].Value.ToString()));
            buscarCruceros.Enabled = true;
            groupBox1.Enabled = true;            
        }        

        private void numericUpDownHoras_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value != null) textBoxFinalizacion.Text = calcular_fecha_finalizacion(dateTimePicker1.Value);
        }

        private void numericUpDownMinutos_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value != null) textBoxFinalizacion.Text = calcular_fecha_finalizacion(dateTimePicker1.Value);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBoxFinalizacion.Text = calcular_fecha_finalizacion(dateTimePicker1.Value);            
        }

        private string calcular_fecha_finalizacion(DateTime dateTime)
        {
            double duracionTotal = 0;
            DateTime fechaLlegada = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, (int)numericUpDownHoras.Value, (int)numericUpDownMinutos.Value, 0);

            foreach (Tramo t in Recorrido_BD.obtener_tramos_recorrido(recorrido))
                duracionTotal += (double)t.duracion;
            DateTime nuevaFechaLlegada = fechaLlegada.AddHours(duracionTotal);

            return nuevaFechaLlegada.ToString();
        }

        private void buscarCruceros_Click(object sender, EventArgs e)
        {
            cargar_grilla_cruceros();
        }

        private void cargar_grilla_cruceros()
        {
            DateTime salida = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, (int)numericUpDownHoras.Value, (int)numericUpDownMinutos.Value, 0);
            RecorridoCrucero_BD.cargar_grilla_cruceros(dataGridView1, salida, DateTime.Parse(textBoxFinalizacion.Text));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            crucero = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            generarViaje.Enabled = true;
        }

        private void generarViaje_Click(object sender, EventArgs e)
        {
            if(RecorridoCrucero_BD.InsertarViaje(crucero, recorrido.id, dateTimePicker1.Value, DateTime.Parse(textBoxFinalizacion.Text)))
            {
                MessageBox.Show("Nuevo viaje creado.", "Generar Viaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                generarViaje.Enabled = false;
                groupBox1.Enabled = false;
                buscarCruceros.Enabled = false;                
                numericUpDownHoras.Value = 0;
                numericUpDownMinutos.Value = 0;
                textBoxFinalizacion.Text = "";
                dataGridView1.DataSource = null;
            }
        }
        
        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
