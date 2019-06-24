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
    public partial class ABM_Cabina : Form
    {
        private Crucero cruc_modificar;
        private string rol_nombre;
        public ABM_Cabina(Crucero cruc_modif, string rol)
        {
            InitializeComponent();
            rol_nombre = rol;
            this.cruc_modificar = cruc_modif;            
            List<TipoCabina> tipoCabinas = Crucero_BD.obtener_todas_tipoCabinas();
            foreach (TipoCabina tcab in tipoCabinas)
            {
                comboBoxCabinas.Items.Add(tcab.nombre);
            }
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            Crucero_BD.cargar_grilla_cabinas(dataGridView1, cruc_modificar);
        }

        private Cabina obtener_cabina_seleccionada()
        {
            int cabi_id = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            int cabi_piso = int.Parse(dataGridView1.SelectedCells[1].Value.ToString());
            int cabi_numero = int.Parse(dataGridView1.SelectedCells[2].Value.ToString());

            int tipo_id = int.Parse(dataGridView1.SelectedCells[3].Value.ToString());
            string tipo_nombre = dataGridView1.SelectedCells[4].Value.ToString();
            double tipo_porc = double.Parse(dataGridView1.SelectedCells[5].Value.ToString());

            TipoCabina cabi_tipo = new TipoCabina(tipo_id, tipo_nombre, tipo_porc);

            return new Cabina(cabi_id, cabi_piso, cabi_numero, cabi_tipo, cruc_modificar);
        }

        private void agregarCabina_Click(object sender, EventArgs e)
        {
            if(comboBoxCabinas.SelectedItem != null)
            {
                if (Crucero_BD.validar_numero_cabina((int)numericUpDownNumero.Value, (int)numericUpDownPiso.Value, cruc_modificar))                
                    if(Crucero_BD.insertar_cabina(cruc_modificar, (int)numericUpDownNumero.Value, (int)numericUpDownPiso.Value, Crucero_BD.obtener_tipoCabina_con_nombre(comboBoxCabinas.SelectedItem.ToString())))
                    {
                        MessageBox.Show("Se agregó correctamente la cabina.", " Cabina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cruc_modificar.Cabinas = Crucero_BD.obtener_Cabinas_con_crucero(cruc_modificar.id);
                        cargarGrilla();
                    }
                    else
                        MessageBox.Show("Hubo un error en el agregado de la cabina.", " Cabina", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                else
                    MessageBox.Show("El número de cabina ya existe para ese piso.", " Cabina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
            }
        }

        private void sacarCabina_Click(object sender, EventArgs e)
        {
            Cabina cabina = obtener_cabina_seleccionada();
            if (Crucero_BD.sacar_cabina(cruc_modificar, cabina))
            {
                MessageBox.Show("Se quitó correctamente la cabina.", "Cabina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cruc_modificar.Cabinas = Crucero_BD.obtener_Cabinas_con_crucero(cruc_modificar.id);
                cargarGrilla();
            }
            else
                MessageBox.Show("Hubo un error en al sacar la cabina.", "Cabina", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void finalizar_Click(object sender, EventArgs e)
        {
            this.Close();
            ABM_Crucero form = new ABM_Crucero(rol_nombre);
            form.Show();
        }
    }
}
