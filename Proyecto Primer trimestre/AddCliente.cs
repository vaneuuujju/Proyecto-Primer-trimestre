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
    public partial class AddCliente : Form
    {
        public AddCliente()
        {
            InitializeComponent();
        }

        private void txtNombreAddCliente_TextChanged(object sender, EventArgs e)
        {

        }
        #region Eventos de los text box
        string txtTempo; //para los eventos leave y enter de los textBox
        #region Nombre cliente
        private void txtNombreAddCliente_Leave(object sender, EventArgs e)
        {
            if (txtNombreAddCliente.Text == "")//verifica si el text box esta vacio
            {
                txtNombreAddCliente.Text = txtTempo; //txtTempo= el texto que trae el cuadro
            }
        }

        private void txtNombreAddCliente_Enter(object sender, EventArgs e)
        {
            txtTempo = txtNombreAddCliente.Text;
            txtNombreAddCliente.Text = "";
        }
        #endregion

        #region Correo electronico
        private void txtCorreoAddCliente_Leave(object sender, EventArgs e)
        {
            if (txtCorreoAddCliente.Text == "")//verifica si el text box esta vacio
            {
                txtCorreoAddCliente.Text = txtTempo; //txtTempo= el texto que trae el cuadro
            }
        }

        private void txtCorreoAddCliente_Enter(object sender, EventArgs e)
        {
            txtTempo = txtCorreoAddCliente.Text;
            txtCorreoAddCliente.Text = "";
        }
        #endregion

        #region Telefono cliente
        private void txtTelefonoAddCliente_Leave(object sender, EventArgs e)
        {
            if (txtTelAddCli.Text == "")//verifica si el text box esta vacio
            {
                txtTelAddCli.Text = txtTempo; //txtTempo= el texto que trae el cuadro
            }
        }

        private void txtTelefonoAddCliente_Enter(object sender, EventArgs e)
        {
            txtTempo = txtTelAddCli.Text;
            txtTelAddCli.Text = "";
        }
        #endregion

        #endregion

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
