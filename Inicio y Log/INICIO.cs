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

namespace FrbaCrucero
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
            List<ROL> roles = ROL_BD.obtener_todos_roles();
            foreach (ROL rol in roles)
            {
                comboBoxRoles.Items.Add(rol.nombre);
            }
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            if (comboBoxRoles.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un Rol", "Inicio", MessageBoxButtons.OK, MessageBoxIcon.Error);              
            }
            else {
                if (comboBoxRoles.SelectedItem.ToString().StartsWith("Administrador"))
                {                    
                    this.Hide();
                    Login form = new Login();
                    form.Show();                    
                }
                else{            
                    this.Hide();
                    Menu form = new Menu(comboBoxRoles.SelectedItem.ToString());
                    form.Show();
                }        
            }
        }

        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
