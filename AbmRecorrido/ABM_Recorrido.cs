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

namespace FrbaCrucero.AbmRecorrido
{
    public partial class ABM_Recorrido : Form
    {
        private string rol_nombre;

        public ABM_Recorrido(string rol)
        {
            InitializeComponent();
            rol_nombre = rol;
        }

        private void ABM_Recorrido_Load(object sender, EventArgs e)
        {
            Recorrido_BD.cargar_grilla_recorridos(dataGridView1);
        }

        private Recorrido obtener_recorrido_seleccionado()
        {
            int recorrido_id = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            string recorrido_codigo = dataGridView1.SelectedCells[1].Value.ToString();
            //bool recorrido_habilitado = dataGridView1.SelectedCells[4].Value.ToString();
            Tramo primerTramo = Recorrido_BD.obtener_primer_tramo(recorrido_id);
            
            return new Recorrido(recorrido_id, recorrido_codigo, primerTramo);
            //return new Recorrido(recorrido_id, recorrido_codigo, primerTramo, recorrido_habilitado);
        }

        private void nuevoRecorrido_Click(object sender, EventArgs e)
        {            
            ModificacionesRecorrido form = new ModificacionesRecorrido(rol_nombre, null, "Nuevo");
            form.Show();
            this.Close();
        }

        private void modificarRecorrido_Click(object sender, EventArgs e)
        {
            Recorrido recorrido_modif = obtener_recorrido_seleccionado();
            recorrido_modif.tramos = Recorrido_BD.obtener_tramos_recorrido(recorrido_modif);
            ModificacionesRecorrido form = new ModificacionesRecorrido(rol_nombre, recorrido_modif, "Modificar");
            form.Show();
            this.Close();
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminarRecorridos_Click(object sender, EventArgs e)
        {
            Recorrido recorrido_modif = obtener_recorrido_seleccionado();
            /*if(recorrido_modif.habilitado == true)
                Recorrido_BD.inhabilitar_recorrido(recorrido_modif);
            else
                Recorrido_BD.habilitar_recorrido(recorrido_modif);*/
        }

    }
}
