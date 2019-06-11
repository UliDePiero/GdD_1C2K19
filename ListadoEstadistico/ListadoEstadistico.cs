using FrbaCrucero.BD_y_Querys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.ListadoEstadistico
{
    public partial class Listado_Estadistico : Form
    {
        private string rol_nombre;
        public Listado_Estadistico(string rol)
        {
            InitializeComponent();
            rol_nombre = rol;
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listado_Estadistico_Load(object sender, EventArgs e)
        {

        }

        private void visualizarListado_Click(object sender, EventArgs e)
        {
            Estadistica seleccion = 0;
            string semestre = "<= 6";

            if (comboBoxSemestre.Text == "Primer semestre (Enero - Junio)")
                semestre = "<= 6";
            else if (comboBoxSemestre.Text == "Segundo semestre(Julio - Diciembre)")
                semestre = "> 6";

            if (comboBoxFunciones.Text == "Recorridos con más pasajes comprados")
                seleccion = Estadistica.RECORRIDOS_CON_MAS_PASAJES;
            else if (comboBoxFunciones.Text == "Recorridos con más cabinas libres en cada uno de los viajes realizados")
                seleccion = Estadistica.RECORRIDOS_CON_MAS_CABINAS_LIBRES;
            else if (comboBoxFunciones.Text == "Cruceros con mayor cantidad de días fuera de servicio")
                seleccion = Estadistica.CRUCEROS_CON_MAS_DIAS_INHABILES;

            Estadistica_BD.cargar_grilla_estadisticas(dataGridView1, semestre, (int)numericUpDown1.Value, seleccion);
        }

    }
}
