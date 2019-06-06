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

namespace FrbaCrucero.AbmRol
{
    public partial class ModificacionesROL : Form
    {
        private string tipo_ingreso;
        private ROL rol_modificar;

        public ModificacionesROL(String operacion, ROL rol_modif)
        {
            InitializeComponent();
            this.tipo_ingreso = operacion;
            this.rol_modificar = rol_modif;           
            if (tipo_ingreso != "Modificar")
                modificarROL.Visible = false;
            List<Funcionalidad> funcionalidades = ROL_BD.obtener_todas_funcionalidades();
            foreach (Funcionalidad func in funcionalidades)
            {
                if (rol_modificar != null && rol_modificar.funcionalidades.Any(f => f.id == func.id))
                {
                    checkedListBox1.Items.Add(func, CheckState.Checked);
                }
                else
                {
                    checkedListBox1.Items.Add(func, CheckState.Unchecked);
                }
                checkedListBox1.DisplayMember = "nombre";
                checkedListBox1.ValueMember = "id";
            }
            if (rol_modificar != null)
            {
                textBoxNombreROL.Text = rol_modificar.nombre;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private List<Funcionalidad> obtener_funcionalidades_checkList()
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            foreach (Funcionalidad func in checkedListBox1.CheckedItems)
            {
                funcionalidades.Add(func);
            }
            return funcionalidades;
        }

        private void nuevo_rol()
        {
            ROL rol_nuevo = new ROL(textBoxNombreROL.Text, obtener_funcionalidades_checkList());
            if (ROL_BD.agregar_rol(rol_nuevo))
            {
                MessageBox.Show("Nuevo ROL creado.", tipo_ingreso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                ABM_ROL form = new ABM_ROL();
                form.Show();
            }
            else
            {
                MessageBox.Show("Hubo un error proceso " + tipo_ingreso, " ROL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificar_rol()
        {
            ROL rol_nuevo = new ROL(textBoxNombreROL.Text, obtener_funcionalidades_checkList());
            rol_nuevo.id = rol_modificar.id;

            if (ROL_BD.modificar_rol(rol_nuevo, rol_modificar.funcionalidades))
            {
                MessageBox.Show("ROL modificado.", tipo_ingreso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                ABM_ROL form = new ABM_ROL();
                form.Show();
            }
            else
            {
                MessageBox.Show("Hubo un error proceso " + tipo_ingreso, " ROL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (rol_modificar == null)
            {
                nuevo_rol();
            }
            else
            {
                modificar_rol();
            }
            this.Close();
            ABM_ROL form = new ABM_ROL();
            form.Show();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            ABM_ROL form = new ABM_ROL();
            form.Show();
        }
    }
}
