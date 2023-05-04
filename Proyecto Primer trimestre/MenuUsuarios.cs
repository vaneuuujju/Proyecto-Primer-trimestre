using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Primer_trimestre
{
    public partial class MenuUsuarios : Form
    {
        public MenuUsuarios()
        {
            InitializeComponent();
        }


        #region Eventos de los text box
        string txtTempo;


        #region Eventos de add usuarios

        private void txtNombreAdd_Leave(object sender, EventArgs e)
        {
            if (txtNombreAdd.Text == "")//verifica si el text box esta vacio
            {
                txtNombreAdd.Text = txtTempo; //txtTempo= el texto que trae el cuadro
            }
        }

        private void txtNombreAdd_Enter(object sender, EventArgs e)
        {
            txtTempo = txtNombreAdd.Text;
            txtNombreAdd.Text = "";
        }

        private void txtApellidos_Leave(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "")//verifica si el text box esta vacio
            {
                txtApellidos.Text = txtTempo; //txtTempo= el texto que trae el cuadro
            }
        }

        private void txtApellidos_Enter(object sender, EventArgs e)
        {
            txtTempo = txtApellidos.Text;
            txtApellidos.Text = "";
        }

        private void txtCorreoAdd_Leave(object sender, EventArgs e)
        {
            if (txtCorreoAdd.Text == "")//verifica si el text box esta vacio
            {
                txtCorreoAdd.Text = txtTempo; //txtTempo= el texto que trae el cuadro
            }
        }

        private void txtCorreoAdd_Enter(object sender, EventArgs e)
        {
            txtTempo = txtCorreoAdd.Text;
            txtCorreoAdd.Text = "";
        }

        private void txtTelefonoAdd_Leave(object sender, EventArgs e)
        {
            if (txtTelefonoAdd.Text == "")//verifica si el text box esta vacio
            {
                txtTelefonoAdd.Text = txtTempo; //txtTempo= el texto que trae el cuadro
            }
        }

        private void txtTelefonoAdd_Enter(object sender, EventArgs e)
        {
            txtTempo = txtTelefonoAdd.Text;
            txtTelefonoAdd.Text = "";
        }

        private void txtContrasenaAdd_Leave(object sender, EventArgs e)
        {
            if (txtContrasenaAdd.Text == "")//verifica si el text box esta vacio
            {
                txtContrasenaAdd.Text = txtTempo; //txtTempo= el texto que trae el cuadro
            }
        }

        private void txtContrasenaAdd_Enter(object sender, EventArgs e)
        {
            txtTempo = txtContrasenaAdd.Text;
            txtContrasenaAdd.Text = "";
        }


        #endregion

        #region Eventos de editar usuarios
        private void txtEditUsuario_Leave(object sender, EventArgs e)
        {
            if (txtEditUsuario.Text == "")//verifica si el text box esta vacio
            {
                txtEditUsuario.Text = txtTempo; //txtTempo= el texto que trae el cuadro
            }
        }

        private void txtEditUsuario_Enter(object sender, EventArgs e)
        {
            txtTempo = txtEditUsuario.Text;
            txtEditUsuario.Text = "";
        }
        #endregion

        #region  Eventos de datos usuarios
        private void txtBuscar1_Leave(object sender, EventArgs e)
        {
            if (txtBuscar1.Text == "")//verifica si el text box esta vacio
            {
                txtBuscar1.Text = txtTempo; //txtTempo= el texto que trae el cuadro
            }
        }

        private void txtBuscar1_Enter(object sender, EventArgs e)
        {
            txtTempo = txtBuscar1.Text;
            txtBuscar1.Text = "";
        }


        #endregion

        #endregion

        #region //Eventos de ver contraseña

        private void txtContrasenaAdd_TextChanged(object sender, EventArgs e)
        {
            txtContrasenaAdd.UseSystemPasswordChar = true;
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //si esta siendo mostrada se pone en pantalla el btn contrario
            btnOcultarAU.BringToFront();
            if (txtContrasenaAdd.UseSystemPasswordChar)
            {
                txtContrasenaAdd.UseSystemPasswordChar = false;//esta asi por default 
                txtContrasenaAdd.Text = "Ocultar";
            }
            else
            {
                btnOcultarAU.BringToFront();
                txtContrasenaAdd.UseSystemPasswordChar = true;//muestra la conrtaseña
                btnMostrar.Text = "Mostrar";
            }
        }
        private void btnOcultarAU_Click(object sender, EventArgs e)
        {
            txtContrasenaAdd.BringToFront();
        }
        private void btnVerUno_Click(object sender, EventArgs e)
        {
            txtBuscar1.Show();
            lupa.Show();
        }
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
